namespace PPSS_Save_Editor
{
    partial class PPSS_Save_Editor
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPSS_Save_Editor));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutLabel = new System.Windows.Forms.LinkLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.pagesBox = new System.Windows.Forms.NumericUpDown();
            this.pagesLabel = new System.Windows.Forms.Label();
            this.timeMinBox = new System.Windows.Forms.NumericUpDown();
            this.timeColonLabel = new System.Windows.Forms.Label();
            this.timeHourBox = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.cometBox = new System.Windows.Forms.NumericUpDown();
            this.cometLabel = new System.Windows.Forms.Label();
            this.hpMaxBox = new System.Windows.Forms.NumericUpDown();
            this.hpSlashLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.hpNowBox = new System.Windows.Forms.NumericUpDown();
            this.coinLabel = new System.Windows.Forms.Label();
            this.coinBox = new System.Windows.Forms.NumericUpDown();
            this.stickerGroup = new System.Windows.Forms.GroupBox();
            this.stickerPosYBox = new System.Windows.Forms.NumericUpDown();
            this.stickerPosYLabel = new System.Windows.Forms.Label();
            this.stickerPosXLabel = new System.Windows.Forms.Label();
            this.stickerPosXBox = new System.Windows.Forms.NumericUpDown();
            this.stickerPosLabel = new System.Windows.Forms.Label();
            this.stickerTypeBox = new System.Windows.Forms.ComboBox();
            this.stickerTypeLabel = new System.Windows.Forms.Label();
            this.stickerChooseBox = new System.Windows.Forms.ComboBox();
            this.stickerChooseLabel = new System.Windows.Forms.Label();
            this.stickerPageBox = new System.Windows.Forms.ComboBox();
            this.stickerPageLabel = new System.Windows.Forms.Label();
            this.stickerPanel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.statusGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cometBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpMaxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpNowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBox)).BeginInit();
            this.stickerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stickerPosYBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stickerPosXBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DereferenceLinks = false;
            this.openFileDialog.Filter = "存档文件|*.bin|所有文件|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "存档文件|*.bin|所有文件|*.*";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItem,
            this.saveItem,
            this.aboutItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(584, 25);
            this.menuStrip.TabIndex = 0;
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(90, 21);
            this.openItem.Text = "打开文件 (&O)";
            this.openItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveItem
            // 
            this.saveItem.Enabled = false;
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(87, 21);
            this.saveItem.Text = "保存文件 (&S)";
            this.saveItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // aboutItem
            // 
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(64, 21);
            this.aboutItem.Text = "关于 (&A)";
            this.aboutItem.Click += new System.EventHandler(this.AboutClick);
            // 
            // aboutLabel
            // 
            this.aboutLabel.AccessibleName = "";
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.aboutLabel.Location = new System.Drawing.Point(504, 372);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(80, 17);
            this.aboutLabel.TabIndex = 4;
            this.aboutLabel.TabStop = true;
            this.aboutLabel.Text = "制作：Xzonn";
            this.aboutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex = 14;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(104, 17);
            this.statusLabel.Text = "未打开存档文件。";
            // 
            // statusGroup
            // 
            this.statusGroup.Controls.Add(this.pagesBox);
            this.statusGroup.Controls.Add(this.pagesLabel);
            this.statusGroup.Controls.Add(this.timeMinBox);
            this.statusGroup.Controls.Add(this.timeColonLabel);
            this.statusGroup.Controls.Add(this.timeHourBox);
            this.statusGroup.Controls.Add(this.timeLabel);
            this.statusGroup.Controls.Add(this.cometBox);
            this.statusGroup.Controls.Add(this.cometLabel);
            this.statusGroup.Controls.Add(this.hpMaxBox);
            this.statusGroup.Controls.Add(this.hpSlashLabel);
            this.statusGroup.Controls.Add(this.hpLabel);
            this.statusGroup.Controls.Add(this.hpNowBox);
            this.statusGroup.Controls.Add(this.coinLabel);
            this.statusGroup.Controls.Add(this.coinBox);
            this.statusGroup.Enabled = false;
            this.statusGroup.Location = new System.Drawing.Point(12, 28);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(274, 175);
            this.statusGroup.TabIndex = 15;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "状态";
            // 
            // pagesBox
            // 
            this.pagesBox.Location = new System.Drawing.Point(141, 138);
            this.pagesBox.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.pagesBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pagesBox.Name = "pagesBox";
            this.pagesBox.Size = new System.Drawing.Size(127, 23);
            this.pagesBox.TabIndex = 13;
            this.pagesBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pagesLabel
            // 
            this.pagesLabel.Location = new System.Drawing.Point(6, 138);
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(127, 23);
            this.pagesLabel.TabIndex = 12;
            this.pagesLabel.Text = "收集册的页面：";
            this.pagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeMinBox
            // 
            this.timeMinBox.Location = new System.Drawing.Point(211, 109);
            this.timeMinBox.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.timeMinBox.Name = "timeMinBox";
            this.timeMinBox.Size = new System.Drawing.Size(57, 23);
            this.timeMinBox.TabIndex = 11;
            // 
            // timeColonLabel
            // 
            this.timeColonLabel.Location = new System.Drawing.Point(199, 109);
            this.timeColonLabel.Name = "timeColonLabel";
            this.timeColonLabel.Size = new System.Drawing.Size(11, 23);
            this.timeColonLabel.TabIndex = 10;
            this.timeColonLabel.Text = ":";
            this.timeColonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeHourBox
            // 
            this.timeHourBox.Location = new System.Drawing.Point(141, 109);
            this.timeHourBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.timeHourBox.Name = "timeHourBox";
            this.timeHourBox.Size = new System.Drawing.Size(57, 23);
            this.timeHourBox.TabIndex = 9;
            // 
            // timeLabel
            // 
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(101)))), ((int)(((byte)(207)))));
            this.timeLabel.Location = new System.Drawing.Point(6, 109);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(127, 23);
            this.timeLabel.TabIndex = 8;
            this.timeLabel.Text = "游戏时间：";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cometBox
            // 
            this.cometBox.Location = new System.Drawing.Point(141, 80);
            this.cometBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.cometBox.Name = "cometBox";
            this.cometBox.Size = new System.Drawing.Size(127, 23);
            this.cometBox.TabIndex = 7;
            // 
            // cometLabel
            // 
            this.cometLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(170)))), ((int)(((byte)(188)))));
            this.cometLabel.Location = new System.Drawing.Point(6, 80);
            this.cometLabel.Name = "cometLabel";
            this.cometLabel.Size = new System.Drawing.Size(127, 23);
            this.cometLabel.TabIndex = 6;
            this.cometLabel.Text = "彗星：";
            this.cometLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hpMaxBox
            // 
            this.hpMaxBox.Location = new System.Drawing.Point(211, 22);
            this.hpMaxBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hpMaxBox.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.hpMaxBox.Name = "hpMaxBox";
            this.hpMaxBox.Size = new System.Drawing.Size(57, 23);
            this.hpMaxBox.TabIndex = 3;
            this.hpMaxBox.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.hpMaxBox.ValueChanged += new System.EventHandler(this.HpMaxChange);
            // 
            // hpSlashLabel
            // 
            this.hpSlashLabel.Location = new System.Drawing.Point(199, 22);
            this.hpSlashLabel.Name = "hpSlashLabel";
            this.hpSlashLabel.Size = new System.Drawing.Size(11, 23);
            this.hpSlashLabel.TabIndex = 2;
            this.hpSlashLabel.Text = "/";
            this.hpSlashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hpLabel
            // 
            this.hpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(134)))), ((int)(((byte)(140)))));
            this.hpLabel.Location = new System.Drawing.Point(6, 22);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(127, 23);
            this.hpLabel.TabIndex = 0;
            this.hpLabel.Text = "HP：";
            this.hpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hpNowBox
            // 
            this.hpNowBox.Location = new System.Drawing.Point(141, 22);
            this.hpNowBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hpNowBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hpNowBox.Name = "hpNowBox";
            this.hpNowBox.Size = new System.Drawing.Size(57, 23);
            this.hpNowBox.TabIndex = 1;
            this.hpNowBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // coinLabel
            // 
            this.coinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.coinLabel.Location = new System.Drawing.Point(6, 51);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(127, 23);
            this.coinLabel.TabIndex = 4;
            this.coinLabel.Text = "金币：";
            this.coinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // coinBox
            // 
            this.coinBox.Location = new System.Drawing.Point(141, 51);
            this.coinBox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.coinBox.Name = "coinBox";
            this.coinBox.Size = new System.Drawing.Size(127, 23);
            this.coinBox.TabIndex = 5;
            // 
            // stickerGroup
            // 
            this.stickerGroup.Controls.Add(this.stickerPosYBox);
            this.stickerGroup.Controls.Add(this.stickerPosYLabel);
            this.stickerGroup.Controls.Add(this.stickerPosXLabel);
            this.stickerGroup.Controls.Add(this.stickerPosXBox);
            this.stickerGroup.Controls.Add(this.stickerPosLabel);
            this.stickerGroup.Controls.Add(this.stickerTypeBox);
            this.stickerGroup.Controls.Add(this.stickerTypeLabel);
            this.stickerGroup.Controls.Add(this.stickerChooseBox);
            this.stickerGroup.Controls.Add(this.stickerChooseLabel);
            this.stickerGroup.Controls.Add(this.stickerPageBox);
            this.stickerGroup.Controls.Add(this.stickerPageLabel);
            this.stickerGroup.Enabled = false;
            this.stickerGroup.Location = new System.Drawing.Point(298, 28);
            this.stickerGroup.Name = "stickerGroup";
            this.stickerGroup.Size = new System.Drawing.Size(274, 175);
            this.stickerGroup.TabIndex = 14;
            this.stickerGroup.TabStop = false;
            this.stickerGroup.Text = "战斗贴纸";
            // 
            // stickerPosYBox
            // 
            this.stickerPosYBox.Location = new System.Drawing.Point(211, 144);
            this.stickerPosYBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.stickerPosYBox.Name = "stickerPosYBox";
            this.stickerPosYBox.Size = new System.Drawing.Size(57, 23);
            this.stickerPosYBox.TabIndex = 24;
            this.stickerPosYBox.ValueChanged += new System.EventHandler(this.StickerChange);
            // 
            // stickerPosYLabel
            // 
            this.stickerPosYLabel.Location = new System.Drawing.Point(141, 144);
            this.stickerPosYLabel.Name = "stickerPosYLabel";
            this.stickerPosYLabel.Size = new System.Drawing.Size(64, 23);
            this.stickerPosYLabel.TabIndex = 23;
            this.stickerPosYLabel.Text = "Y轴：";
            this.stickerPosYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stickerPosXLabel
            // 
            this.stickerPosXLabel.Location = new System.Drawing.Point(141, 115);
            this.stickerPosXLabel.Name = "stickerPosXLabel";
            this.stickerPosXLabel.Size = new System.Drawing.Size(64, 23);
            this.stickerPosXLabel.TabIndex = 22;
            this.stickerPosXLabel.Text = "X轴：";
            this.stickerPosXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stickerPosXBox
            // 
            this.stickerPosXBox.Location = new System.Drawing.Point(211, 115);
            this.stickerPosXBox.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.stickerPosXBox.Name = "stickerPosXBox";
            this.stickerPosXBox.Size = new System.Drawing.Size(57, 23);
            this.stickerPosXBox.TabIndex = 14;
            this.stickerPosXBox.ValueChanged += new System.EventHandler(this.StickerChange);
            // 
            // stickerPosLabel
            // 
            this.stickerPosLabel.Location = new System.Drawing.Point(6, 115);
            this.stickerPosLabel.Name = "stickerPosLabel";
            this.stickerPosLabel.Size = new System.Drawing.Size(127, 23);
            this.stickerPosLabel.TabIndex = 20;
            this.stickerPosLabel.Text = "贴纸位置：";
            this.stickerPosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stickerTypeBox
            // 
            this.stickerTypeBox.FormattingEnabled = true;
            this.stickerTypeBox.Location = new System.Drawing.Point(141, 84);
            this.stickerTypeBox.Name = "stickerTypeBox";
            this.stickerTypeBox.Size = new System.Drawing.Size(127, 25);
            this.stickerTypeBox.TabIndex = 19;
            this.stickerTypeBox.Text = "(无)";
            this.stickerTypeBox.SelectedIndexChanged += new System.EventHandler(this.StickerChange);
            // 
            // stickerTypeLabel
            // 
            this.stickerTypeLabel.Location = new System.Drawing.Point(6, 84);
            this.stickerTypeLabel.Name = "stickerTypeLabel";
            this.stickerTypeLabel.Size = new System.Drawing.Size(127, 25);
            this.stickerTypeLabel.TabIndex = 18;
            this.stickerTypeLabel.Text = "贴纸种类：";
            this.stickerTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stickerChooseBox
            // 
            this.stickerChooseBox.FormattingEnabled = true;
            this.stickerChooseBox.Location = new System.Drawing.Point(141, 53);
            this.stickerChooseBox.Name = "stickerChooseBox";
            this.stickerChooseBox.Size = new System.Drawing.Size(127, 25);
            this.stickerChooseBox.TabIndex = 17;
            this.stickerChooseBox.Text = "1";
            this.stickerChooseBox.SelectedIndexChanged += new System.EventHandler(this.StickerChooseBoxChange);
            // 
            // stickerChooseLabel
            // 
            this.stickerChooseLabel.Location = new System.Drawing.Point(6, 53);
            this.stickerChooseLabel.Name = "stickerChooseLabel";
            this.stickerChooseLabel.Size = new System.Drawing.Size(127, 25);
            this.stickerChooseLabel.TabIndex = 16;
            this.stickerChooseLabel.Text = "选择贴纸：";
            this.stickerChooseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stickerPageBox
            // 
            this.stickerPageBox.FormattingEnabled = true;
            this.stickerPageBox.Location = new System.Drawing.Point(141, 22);
            this.stickerPageBox.Name = "stickerPageBox";
            this.stickerPageBox.Size = new System.Drawing.Size(127, 25);
            this.stickerPageBox.TabIndex = 15;
            this.stickerPageBox.Text = "1";
            this.stickerPageBox.SelectedIndexChanged += new System.EventHandler(this.PageChange);
            // 
            // stickerPageLabel
            // 
            this.stickerPageLabel.Location = new System.Drawing.Point(6, 22);
            this.stickerPageLabel.Name = "stickerPageLabel";
            this.stickerPageLabel.Size = new System.Drawing.Size(127, 25);
            this.stickerPageLabel.TabIndex = 14;
            this.stickerPageLabel.Text = "页码：";
            this.stickerPageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stickerPanel
            // 
            this.stickerPanel.Location = new System.Drawing.Point(162, 209);
            this.stickerPanel.Name = "stickerPanel";
            this.stickerPanel.Size = new System.Drawing.Size(250, 150);
            this.stickerPanel.TabIndex = 16;
            // 
            // PPSS_Save_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.stickerPanel);
            this.Controls.Add(this.stickerGroup);
            this.Controls.Add(this.statusGroup);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PPSS_Save_Editor";
            this.Text = "纸片马力欧 超级贴纸 存档修改器";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.statusGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pagesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeMinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeHourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cometBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpMaxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpNowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBox)).EndInit();
            this.stickerGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stickerPosYBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stickerPosXBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.LinkLabel aboutLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.GroupBox statusGroup;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.NumericUpDown coinBox;
        private System.Windows.Forms.NumericUpDown hpMaxBox;
        private System.Windows.Forms.Label hpSlashLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.NumericUpDown hpNowBox;
        private System.Windows.Forms.NumericUpDown timeHourBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.NumericUpDown cometBox;
        private System.Windows.Forms.Label cometLabel;
        private System.Windows.Forms.NumericUpDown timeMinBox;
        private System.Windows.Forms.Label timeColonLabel;
        private System.Windows.Forms.NumericUpDown pagesBox;
        private System.Windows.Forms.Label pagesLabel;
        private System.Windows.Forms.GroupBox stickerGroup;
        private System.Windows.Forms.ComboBox stickerPageBox;
        private System.Windows.Forms.Label stickerPageLabel;
        private System.Windows.Forms.ComboBox stickerChooseBox;
        private System.Windows.Forms.Label stickerChooseLabel;
        private System.Windows.Forms.ComboBox stickerTypeBox;
        private System.Windows.Forms.Label stickerTypeLabel;
        private System.Windows.Forms.NumericUpDown stickerPosYBox;
        private System.Windows.Forms.Label stickerPosYLabel;
        private System.Windows.Forms.Label stickerPosXLabel;
        private System.Windows.Forms.NumericUpDown stickerPosXBox;
        private System.Windows.Forms.Label stickerPosLabel;
        private System.Windows.Forms.Panel stickerPanel;
    }
}

