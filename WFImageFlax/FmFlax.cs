using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WFImageFlax
{
    public partial class FmFlax : Form
    {
        private string globalFilePath;

        public FmFlax()
        {
            InitializeComponent();
        }

        private void btnBrower_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            //MessageBox.Show(dr.ToString());
            if (dr == DialogResult.OK) {
                globalFilePath = this.openFileDialog1.FileName;
                this.txtFilePath.Text = globalFilePath;
                System.Drawing.Image img = Image.FromFile(globalFilePath);
                this.btnSaveAs.Enabled = true;
            }
        }

        /**
         * 图片另存为事件
         * */
        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileNames.Length <= 0)
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            if (txtDirectory.Text.Length <= 0)
            {
                MessageBox.Show("请先选择保存路径");
                return;
            }
            foreach (string filename in this.openFileDialog1.FileNames)
            {
                saveFile(filename);
            }
            MessageBox.Show("已处理!");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.numericPercent.Enabled = this.radioButton1.Checked;
            this.numericWidth.Enabled = this.radioButton2.Checked;
            this.numericHeight.Enabled = this.radioButton2.Checked;
            this.numericFixedValue.Enabled = this.radioButton3.Checked;
        }

        /// <summary>
        /// 根据一个固定值生成伸缩图片的大小
        /// </summary>
        /// <param name="oldWidth"></param>
        /// <param name="oldHeight"></param>
        /// <param name="fixedValue"></param>
        /// <returns></returns>
        private Size calculateNetImageSize(int oldWidth, int oldHeight, double fixedValue) {
            int temp = oldWidth >= oldHeight ? oldWidth : oldHeight;
            double percent = fixedValue / temp;
            int newWidth = Convert.ToInt32(oldWidth * percent);
            int newHeight = Convert.ToInt32(oldHeight * percent);
            return new Size(newWidth, newHeight);        
        }

        private void FmFlax_Load(object sender, EventArgs e)
        {
            this.numericPercent.Focus();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "jpeg图片(*.jpg)|*.jpg|png图片(*.png)|*.png";
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Visible = true;
        }

        private void FmFlax_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.Visible = false;
            }
        }
 

        private void saveFile(string filename) {
            System.Drawing.Image img = Image.FromFile(filename);

            // 计算伸缩图的宽、高
            int width = 120;
            int height = 120;
            if (this.radioButton1.Checked)
            {
                double percent = Convert.ToDouble(this.numericPercent.Value) / 100;
                width = Convert.ToInt32(img.Width * percent);
                height = Convert.ToInt32(img.Height * percent);
            }
            else if (this.radioButton2.Checked)
            {
                width = Convert.ToInt32(this.numericWidth.Value);
                height = Convert.ToInt32(this.numericHeight.Value);
            }
            else if (this.radioButton3.Checked)
            {
                Size size = calculateNetImageSize(img.Width, img.Height,
                    Convert.ToDouble(this.numericFixedValue.Value));
                width = size.Width;
                height = size.Height;
            }
            // 绘制图片
            System.Drawing.Image imgFlax = new System.Drawing.Bitmap(width, height);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(imgFlax);
            g.DrawImage(img, new Rectangle(0, 0, width, height));

            string saveFileName = string.Format(@"{0}\{1}", txtDirectory.Text, System.IO.Path.GetFileName(filename));
            imgFlax.Save(saveFileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void btnDirectoryBrowser_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}