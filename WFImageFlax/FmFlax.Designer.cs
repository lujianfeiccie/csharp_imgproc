namespace WFImageFlax
{
    partial class FmFlax
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmFlax));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericFixedValue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.numericPercent = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectoryBrowser = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFixedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpeg图片(*.jpg)png图片(*.png)|*.jpg";
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.Color.White;
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(80, 29);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(308, 21);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.Enter += new System.EventHandler(this.btnBrower_Click);
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(394, 27);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(75, 23);
            this.btnBrower.TabIndex = 1;
            this.btnBrower.Text = "浏览…";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "原始图片";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(12, 235);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(86, 23);
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.Text = "图片另存为";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericFixedValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.numericPercent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericHeight);
            this.groupBox1.Controls.Add(this.numericWidth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(29, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 158);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // numericFixedValue
            // 
            this.numericFixedValue.Enabled = false;
            this.numericFixedValue.Location = new System.Drawing.Point(73, 133);
            this.numericFixedValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericFixedValue.Name = "numericFixedValue";
            this.numericFixedValue.Size = new System.Drawing.Size(60, 21);
            this.numericFixedValue.TabIndex = 23;
            this.numericFixedValue.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "固定值：";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 111);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(275, 16);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.Text = "指定宽、高最大不能超过一个固定值伸缩（px）";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // numericPercent
            // 
            this.numericPercent.Location = new System.Drawing.Point(91, 35);
            this.numericPercent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericPercent.Name = "numericPercent";
            this.numericPercent.Size = new System.Drawing.Size(60, 21);
            this.numericPercent.TabIndex = 20;
            this.numericPercent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "百分比(%)：";
            // 
            // numericHeight
            // 
            this.numericHeight.Enabled = false;
            this.numericHeight.Location = new System.Drawing.Point(176, 84);
            this.numericHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(60, 21);
            this.numericHeight.TabIndex = 18;
            this.numericHeight.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numericWidth
            // 
            this.numericWidth.Enabled = false;
            this.numericWidth.Location = new System.Drawing.Point(51, 84);
            this.numericWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(60, 21);
            this.numericWidth.TabIndex = 17;
            this.numericWidth.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "高：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "宽：";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(143, 16);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "按指定大小伸缩（px）";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 16);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "按百分比伸缩";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "图片拉伸和缩小编辑器（Image Flax Edit）";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.还原ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // 还原ToolStripMenuItem
            // 
            this.还原ToolStripMenuItem.Name = "还原ToolStripMenuItem";
            this.还原ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.还原ToolStripMenuItem.Text = "还原";
            this.还原ToolStripMenuItem.Click += new System.EventHandler(this.还原ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.BackColor = System.Drawing.Color.White;
            this.txtDirectory.Location = new System.Drawing.Point(105, 235);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(308, 21);
            this.txtDirectory.TabIndex = 6;
            // 
            // btnDirectoryBrowser
            // 
            this.btnDirectoryBrowser.Location = new System.Drawing.Point(419, 235);
            this.btnDirectoryBrowser.Name = "btnDirectoryBrowser";
            this.btnDirectoryBrowser.Size = new System.Drawing.Size(61, 23);
            this.btnDirectoryBrowser.TabIndex = 7;
            this.btnDirectoryBrowser.Text = "浏览";
            this.btnDirectoryBrowser.UseVisualStyleBackColor = true;
            this.btnDirectoryBrowser.Click += new System.EventHandler(this.btnDirectoryBrowser_Click);
            // 
            // FmFlax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 270);
            this.Controls.Add(this.btnDirectoryBrowser);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSaveAs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmFlax";
            this.Text = "图片拉伸和缩小编辑器（Image Flax Edit）";
            this.Load += new System.EventHandler(this.FmFlax_Load);
            this.SizeChanged += new System.EventHandler(this.FmFlax_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFixedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.NumericUpDown numericFixedValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 还原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnDirectoryBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}