using System;
using System.Windows.Forms;

namespace WinFormAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 확대하기축소하기기본값ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 50;
        }

        private void 메모장정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/search?q=windows%ec%9d%98+%eb%a9%94%eb%aa%a8%ec%9e%a5%ec%97%90+%eb%8c%80%ed%95%9c+%eb%8f%84%ec%9b%80%eb%a7%90+%eb%b3%b4%ea%b8%b0&filters=guid:%224466414-ko-dia%22%20lang:%22ko%22&form=T00032&ocid=HelpPane-BingIA");
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Maximum < toolStripProgressBar1.Value + toolStripProgressBar1.Step)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            }
            else
            {
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
            }
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Minimum > toolStripProgressBar1.Value - toolStripProgressBar1.Step)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
            }
            else
            {
                toolStripProgressBar1.Value -= toolStripProgressBar1.Step;
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }
    }
}
