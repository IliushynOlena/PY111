using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_RichTextBox
{
    public partial class Form1 : Form
    {
        private string DescktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontFamily.GenericMonospace,30,FontStyle.Bold);    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.AliceBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionRightIndent++;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = checkBox1.Checked;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(DescktopPath + @"\doc.rtf", RichTextBoxStreamType.RichText);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(DescktopPath + @"\doc.rtf", RichTextBoxStreamType.RichText);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bulletToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redToolStripMenuItem.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.LightGray;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = font.Font;
            }
        }
    }
}
