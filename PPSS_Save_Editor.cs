using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;

namespace PPSS_Save_Editor
{
    public partial class PPSS_Save_Editor : Form
    {
        public System.Resources.ResourceManager resources = new System.Resources.ResourceManager("PPSS_Save_Editor.Resources", typeof(Properties.Resources).Assembly);
        public class Sticker
        {
            public byte type;
            public int x;
            public int y;
            public PictureBox picture;
            public Image image;
        }

        public class StickerData
        {
            public string name;
            public byte code;
        }

        public static Sticker[] stickers = new Sticker[15];

        public class StickerDatabase
        {
            public static List<StickerData> stickerDatas;

            public static void LoadData()
            {
                string xml = Properties.Resources.ResourceManager.GetString("StickerData");
                XDocument data = XDocument.Load(new StringReader(xml));
                IEnumerable<XElement> elements = (from x in data.Root.Descendants("item") select x);

                stickerDatas = new List<StickerData>();
                foreach (XElement row in elements)
                {
                    stickerDatas.Add(new StickerData
                    {
                        name = row.Attribute("name").Value,
                        code = Convert.ToByte(row.Attribute("code").Value, 16)
                    });
                }
            }
        }

        public int lastPage = 0;
        public int lastSticker = 0;
        public bool isMouseDown = false;
        public Point mouseOffset;

        public PPSS_Save_Editor()
        {
            InitializeComponent();
            int i;
            for (i = 0; i < 15; i++)
            {
                stickers[i] = new Sticker
                {
                    picture = new PictureBox
                    {
                        Name = "Sticker_" + i,
                        Cursor = Cursors.Hand,
                        Visible = false
                    }
                };
                stickers[i].picture.MouseDown += new MouseEventHandler(this.StickerMouseDown);
                stickers[i].picture.MouseMove += new MouseEventHandler(this.StickerMouseMove);
                stickers[i].picture.MouseUp += new MouseEventHandler(this.StickerMouseUp);
                stickerPanel.Controls.Add(stickers[i].picture);
                stickerChooseBox.Items.Add(Convert.ToString(i + 1));
            }
            ResumeLayout(false);
            StickerDatabase.LoadData();
            foreach (StickerData stickerData in StickerDatabase.stickerDatas)
            {
                stickerTypeBox.Items.Add(stickerData.name);
            }
            
            for (i = 0; i < 18; i++)
            {
                stickerPageBox.Items.Add(Convert.ToString(i + 1));
            }
        }

        public class Data
        {
            public static byte[] data;
            public static int length;
            public static byte GetData(int n)
            {
                return data[n];
            }
            public static UInt16 GetInt16Data(int n)
            {
                int i;
                UInt16 value = 0;
                for (i = 1; i > -1; i--)
                {
                    value <<= 8;
                    value += data[n + i];
                }
                return value;
            }

            public static void SetData(int n, byte val)
            {
                data[n] = val;
            }
            public static void SetInt16Data(int n, UInt16 value)
            {
                int i;
                for (i = 0; i < 2; i++)
                {
                    data[n + i] = (byte)(value % 256);
                    value >>= 8;
                }
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == "") return;

            FileInfo fi = new FileInfo(openFileDialog.FileName);
            /*
            if (fi.Length != 9904)
            {
                MessageBox.Show("存档文件大小错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
            try
            {
                Data.data = File.ReadAllBytes(openFileDialog.FileName);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                hpMaxBox.Value = Data.GetInt16Data(0x0150);
                hpNowBox.Maximum = hpMaxBox.Value;
                hpNowBox.Value = Data.GetInt16Data(0x014C);
                coinBox.Value = Data.GetInt16Data(0x0148);
                cometBox.Value = Data.GetInt16Data(0x017C);
                timeHourBox.Value = Data.GetData(0x1F);
                timeMinBox.Value = Data.GetData(0x1E);
                pagesBox.Value = Data.GetData(0x0D24);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            statusLabel.Text = Path.GetFileName(openFileDialog.FileName) + " 已打开。";

            stickerPageBox.Text = "1";
            ReadPageData();

            statusGroup.Enabled = true;
            stickerGroup.Enabled = true;
            saveItem.Enabled = true;
        }
        
        private void SaveFile(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName == "") return;

            WritePageData();

            Data.SetInt16Data(0x014C, (UInt16)hpNowBox.Value);
            Data.SetInt16Data(0x0150, (UInt16)hpMaxBox.Value);
            Data.SetInt16Data(0x0148, (UInt16)coinBox.Value);
            Data.SetInt16Data(0x017C, (UInt16)cometBox.Value);
            Data.SetData(0x1F, (byte)timeHourBox.Value);
            Data.SetData(0x1E, (byte)timeMinBox.Value);
            Data.SetData(0x0D24, (byte)pagesBox.Value);

            try
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, File.Exists(saveFileDialog.FileName) ? FileMode.Truncate : FileMode.CreateNew);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(Data.data, 0, Data.data.Length);

                bw.Close();
                fs.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("保存文件成功。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AboutClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Xzonn/Paper_Mario_Sticker_Star_Save_Editor");
        }

        private void PageChange(object sender, EventArgs e)
        {
            stickerPageBox.Focus();
            int page = stickerPageBox.SelectedIndex;
            if (page != lastPage)
            {
                WritePageData();
            }
            lastPage = page;
            ReadPageData();
        }

        private void WritePageData()
        {
            WriteStickerData();
            int i;
            for (i = 0; i < 15; i++)
            {
                Sticker sticker = stickers[i];
                Data.SetData(0x01E0 + 0xA0 * lastPage + 0x0A * i, sticker.type);
                Data.SetInt16Data(0x01E6 + 0xA0 * lastPage + 0x0A * i, (UInt16)(sticker.x * 25));
                Data.SetInt16Data(0x01E8 + 0xA0 * lastPage + 0x0A * i, (UInt16)(sticker.y * 25));
            }
        }

        private void ReadPageData()
        {
            int page = stickerPageBox.SelectedIndex;
            int i;
            for (i = 0; i < 15; i++)
            {
                Sticker sticker = stickers[i];
                sticker.type = Data.GetData(0x01E0 + 0xA0 * page + 0x0A * i);
                sticker.image = resources.GetObject("S" + Convert.ToString(sticker.type, 16).ToUpper()) as Image;
                if (sticker.image != null)
                {
                    sticker.x = Data.GetInt16Data(0x01E6 + 0xA0 * page + 0x0A * i) / 25;
                    sticker.y = Data.GetInt16Data(0x01E8 + 0xA0 * page + 0x0A * i) / 25;
                    sticker.picture.Image = sticker.image;
                    sticker.picture.Location = new Point(sticker.x * 25, sticker.y * 25);
                    sticker.picture.Size = new Size(sticker.image.Size.Width, sticker.image.Size.Height);
                    sticker.picture.Visible = true;
                }
                else
                {
                    sticker.picture.Visible = false;
                }
            }
            lastSticker = 0;
            stickerChooseBox.Text = (string)stickerChooseBox.Items[0];
            ReadStickerData();
        }

        private void StickerChooseBoxChange(object sender, EventArgs e)
        {
            stickerChooseBox.Focus();
            int selected = stickerChooseBox.SelectedIndex;
            if (selected != lastSticker)
                WriteStickerData();
            stickerChooseBox.Focus();
            lastSticker = selected;
            ReadStickerData();
        }

        private void WriteStickerData()
        {
            Sticker sticker = stickers[lastSticker];
            if (stickerTypeBox.Text != (string)stickerTypeBox.Items[0])
            {
                sticker.type = StickerDatabase.stickerDatas.Find(s => s.name == stickerTypeBox.Text).code;
                sticker.x = (int)stickerPosXBox.Value;
                sticker.y = (int)stickerPosYBox.Value;
            }
            else
            {
                stickers[lastSticker].type = 0;
            }
        }

        private void ReadStickerData()
        {
            int i;
            for (i = 0; i < 15; i++)
            {
                stickers[i].picture.BorderStyle = (i == lastSticker ? BorderStyle.Fixed3D : BorderStyle.None);
            }
            Sticker sticker = stickers[lastSticker];
            if (sticker.image != null)
            {
                stickerTypeBox.Text = StickerDatabase.stickerDatas.Find(s => s.code == sticker.type).name;
                stickerPosXBox.Value = sticker.x;
                stickerPosYBox.Value = sticker.y;
            }
            else
            {
                stickerTypeBox.Text = (string)stickerTypeBox.Items[0];
            }
        }

        private void StickerChoose(object sender, EventArgs e)
        {
        }

        private void StickerChange(object sender, EventArgs e)
        {
            Sticker sticker = stickers[stickerChooseBox.SelectedIndex];
            if (stickerTypeBox.Text != (string)stickerTypeBox.Items[0])
            {
                sticker.image = resources.GetObject("S" + Convert.ToString(StickerDatabase.stickerDatas.Find(s => s.name == stickerTypeBox.Text).code, 16).ToUpper()) as Image;
                sticker.picture.Image = sticker.image;
                sticker.picture.Location = new Point((int)stickerPosXBox.Value * 25, (int)stickerPosYBox.Value * 25);
                sticker.picture.Size = new Size(sticker.image.Size.Width, sticker.image.Size.Height);
                sticker.picture.Visible = true;
            }
            else
            {
                sticker.picture.Visible = false;
            }
        }

        private void HpMaxChange(object sender, EventArgs e)
        {
            if (hpNowBox.Value > hpMaxBox.Value)
            {
                hpNowBox.Value = hpMaxBox.Value;
            }
            hpNowBox.Maximum = hpMaxBox.Value;
        }

        private void StickerMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox picture = (PictureBox)sender;
                int num = Convert.ToInt32(picture.Name.Substring(8));
                stickerChooseBox.Text = (string)stickerChooseBox.Items[num];
                mouseOffset.X = e.X - 2;
                mouseOffset.Y = e.Y - 2;
                isMouseDown = true;
            }
        }

        private void StickerMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                PictureBox picture = (PictureBox)sender;
                int x = (picture.Left + e.X - mouseOffset.X) / 25;
                if (x < 0) x = 0;
                if (x > 9) x = 9;
                int y = (picture.Top + e.Y - mouseOffset.Y) / 25;
                if (y < 0) y = 0;
                if (y > 5) y = 5;
                stickerPosXBox.Value = x;
                stickerPosYBox.Value = y;
            }
        }

        private void StickerMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}