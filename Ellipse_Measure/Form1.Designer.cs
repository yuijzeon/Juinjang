namespace Oval_Measure
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chineseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingReferencePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measureSquareGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sizeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mouseTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ReferencePointTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.LongTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ShortTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.AngleTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.squareGridSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pRADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pradTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.resetSquareGridMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateEpsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Oval_Measure.Properties.Settings.Default, "language", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1497, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = global::Oval_Measure.Properties.Settings.Default.language;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 34);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(227, 44);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(76, 34);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem1,
            this.chineseToolStripMenuItem1});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem1
            // 
            this.englishToolStripMenuItem1.Name = "englishToolStripMenuItem1";
            this.englishToolStripMenuItem1.Size = new System.Drawing.Size(226, 44);
            this.englishToolStripMenuItem1.Text = "English";
            this.englishToolStripMenuItem1.Click += new System.EventHandler(this.englishToolStripMenuItem1_Click);
            // 
            // chineseToolStripMenuItem1
            // 
            this.chineseToolStripMenuItem1.Name = "chineseToolStripMenuItem1";
            this.chineseToolStripMenuItem1.Size = new System.Drawing.Size(226, 44);
            this.chineseToolStripMenuItem1.Text = "中文";
            this.chineseToolStripMenuItem1.Click += new System.EventHandler(this.chineseToolStripMenuItem1_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingReferencePointToolStripMenuItem,
            this.measureToolStripMenuItem,
            this.measureSquareGridToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(82, 34);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // settingReferencePointToolStripMenuItem
            // 
            this.settingReferencePointToolStripMenuItem.Name = "settingReferencePointToolStripMenuItem";
            this.settingReferencePointToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.settingReferencePointToolStripMenuItem.Text = "Setting Reference Point";
            this.settingReferencePointToolStripMenuItem.Click += new System.EventHandler(this.settingReferencePointToolStripMenuItem_Click);
            // 
            // measureToolStripMenuItem
            // 
            this.measureToolStripMenuItem.Name = "measureToolStripMenuItem";
            this.measureToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.measureToolStripMenuItem.Text = "Measure";
            this.measureToolStripMenuItem.Click += new System.EventHandler(this.measureToolStripMenuItem_Click);
            // 
            // measureSquareGridToolStripMenuItem
            // 
            this.measureSquareGridToolStripMenuItem.Name = "measureSquareGridToolStripMenuItem";
            this.measureSquareGridToolStripMenuItem.Size = new System.Drawing.Size(413, 44);
            this.measureSquareGridToolStripMenuItem.Text = "Measure Square Grid";
            this.measureSquareGridToolStripMenuItem.Click += new System.EventHandler(this.measureSquareGridToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(86, 34);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(231, 44);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 38);
            this.toolStripTextBox1.Text = "V1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseCaptureChanged += new System.EventHandler(this.pictureBox1_MouseCaptureChanged);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeTextBox,
            this.mouseTextBox,
            this.ReferencePointTextBox,
            this.LongTextBox,
            this.ShortTextBox,
            this.AngleTextBox,
            this.toolStripTextBox2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 850);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip2.Size = new System.Drawing.Size(1497, 46);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Enabled = false;
            this.sizeTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(242, 38);
            // 
            // mouseTextBox
            // 
            this.mouseTextBox.Enabled = false;
            this.mouseTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.mouseTextBox.Name = "mouseTextBox";
            this.mouseTextBox.Size = new System.Drawing.Size(143, 38);
            // 
            // ReferencePointTextBox
            // 
            this.ReferencePointTextBox.Enabled = false;
            this.ReferencePointTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.ReferencePointTextBox.Name = "ReferencePointTextBox";
            this.ReferencePointTextBox.Size = new System.Drawing.Size(242, 38);
            // 
            // LongTextBox
            // 
            this.LongTextBox.Enabled = false;
            this.LongTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.LongTextBox.Name = "LongTextBox";
            this.LongTextBox.Size = new System.Drawing.Size(242, 38);
            this.LongTextBox.Text = "Long Axis:";
            // 
            // ShortTextBox
            // 
            this.ShortTextBox.Enabled = false;
            this.ShortTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.ShortTextBox.Name = "ShortTextBox";
            this.ShortTextBox.Size = new System.Drawing.Size(242, 38);
            this.ShortTextBox.Text = "Short Axis:";
            // 
            // AngleTextBox
            // 
            this.AngleTextBox.Enabled = false;
            this.AngleTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.AngleTextBox.Name = "AngleTextBox";
            this.AngleTextBox.Size = new System.Drawing.Size(242, 38);
            this.AngleTextBox.Text = "Angle:";
            this.AngleTextBox.Click += new System.EventHandler(this.AngleTextBox_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(160, 38);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareGridSettingsToolStripMenuItem,
            this.dTextBox,
            this.pRADToolStripMenuItem,
            this.pradTextBox,
            this.resetSquareGridMenuItem,
            this.CalculateEpsToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 896);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1497, 42);
            this.menuStrip3.TabIndex = 4;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // squareGridSettingsToolStripMenuItem
            // 
            this.squareGridSettingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.squareGridSettingsToolStripMenuItem.Name = "squareGridSettingsToolStripMenuItem";
            this.squareGridSettingsToolStripMenuItem.Size = new System.Drawing.Size(296, 38);
            this.squareGridSettingsToolStripMenuItem.Text = "Square Grid Settings: D";
            // 
            // dTextBox
            // 
            this.dTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(100, 38);
            this.dTextBox.Text = "0.0925";
            this.dTextBox.TextChanged += new System.EventHandler(this.dTextBox_TextChanged);
            // 
            // pRADToolStripMenuItem
            // 
            this.pRADToolStripMenuItem.Name = "pRADToolStripMenuItem";
            this.pRADToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.pRADToolStripMenuItem.Text = "PRAD";
            // 
            // pradTextBox
            // 
            this.pradTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.pradTextBox.Name = "pradTextBox";
            this.pradTextBox.Size = new System.Drawing.Size(100, 38);
            this.pradTextBox.Text = "100000";
            this.pradTextBox.TextChanged += new System.EventHandler(this.pradTextBox_TextChanged);
            // 
            // resetSquareGridMenuItem
            // 
            this.resetSquareGridMenuItem.Name = "resetSquareGridMenuItem";
            this.resetSquareGridMenuItem.Size = new System.Drawing.Size(172, 38);
            this.resetSquareGridMenuItem.Text = "Reset Points";
            this.resetSquareGridMenuItem.Click += new System.EventHandler(this.resetSquareGridMenuItem_Click);
            // 
            // CalculateEpsToolStripMenuItem
            // 
            this.CalculateEpsToolStripMenuItem.Name = "CalculateEpsToolStripMenuItem";
            this.CalculateEpsToolStripMenuItem.Size = new System.Drawing.Size(182, 38);
            this.CalculateEpsToolStripMenuItem.Text = "Calculate Eps";
            this.CalculateEpsToolStripMenuItem.Click += new System.EventHandler(this.calculateEpsoolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1497, 938);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chineseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem settingReferencePointToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripTextBox sizeTextBox;
        private System.Windows.Forms.ToolStripTextBox mouseTextBox;
        private System.Windows.Forms.ToolStripTextBox ReferencePointTextBox;
        private System.Windows.Forms.ToolStripMenuItem measureToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox LongTextBox;
        private System.Windows.Forms.ToolStripTextBox ShortTextBox;
        private System.Windows.Forms.ToolStripTextBox AngleTextBox;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem measureSquareGridToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem squareGridSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox dTextBox;
        private System.Windows.Forms.ToolStripMenuItem pRADToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox pradTextBox;
        private System.Windows.Forms.ToolStripMenuItem resetSquareGridMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculateEpsToolStripMenuItem;
    }
}

