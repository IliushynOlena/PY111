using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateColor();
        }
        void UpdateColor()
        {
            Color c = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            BackColor = c;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            this.Opacity = trackBar4.Value / 100.0;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
