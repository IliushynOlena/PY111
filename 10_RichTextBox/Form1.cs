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

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
        }
    }
}
