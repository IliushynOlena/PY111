using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroToWinForm
{
    public partial class Form1 : Form
    {
        Point startLocation;
        public Form1()
        {
            InitializeComponent();
            startLocation = CSharp.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello WF","Congratulation",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void ClickButton_MouseEnter(object sender, EventArgs e)
        {
            ClickButton.BackColor = Color.Cyan;
        }

        private void ClickButton_MouseLeave(object sender, EventArgs e)
        {
            ClickButton.BackColor = Color.Lime;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Do you want to close window?", " Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            { this.Close(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CSharp.Location = new Point(CSharp.Location.X+2, CSharp.Location.Y);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            CSharp.Location = new Point(CSharp.Location.X-2, CSharp.Location.Y);
        }

        private void CSharp_Click(object sender, EventArgs e)
        {
            CSharp.Location = startLocation;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Posotion : {e.X} : {e.Y}";

            Point mouse = e.Location;
            if(mouse.X >= CSharp.Left - 20 && (mouse.X <= CSharp.Left + CSharp.Width + 20))
            {
                if(mouse.X >= CSharp.Left + (CSharp.Width/2))
                {
                    CSharp.Left = CSharp.Left - 5;
                }
                else
                {
                    CSharp.Left = CSharp.Left + 5;
                }
            }
            if (mouse.Y >= CSharp.Top - 20 && (mouse.Y <= CSharp.Top + CSharp.Height + 20))
            {
                if (mouse.Y >= CSharp.Top + (CSharp.Height / 2))
                {
                    CSharp.Top = CSharp.Top - 5;
                }
                else
                {
                    CSharp.Top = CSharp.Top + 5;
                }
            }
            if(CSharp.Top < 0)
            {
                CSharp.Location = new Point(new Random().Next(this.Width), new Random().Next(this.Height));
            }
            if (CSharp.Left < 0)
            {
                CSharp.Location = new Point(new Random().Next(this.Width), new Random().Next(this.Height));
            }
            if((CSharp.Left + CSharp.Width) > this.ClientSize.Width)
            {
                CSharp.Location = new Point(new Random().Next(this.Width), new Random().Next(this.Height));
            }
            if ((CSharp.Top + CSharp.Height) > this.ClientSize.Height)
            {
                CSharp.Location = new Point(new Random().Next(this.Width), new Random().Next(this.Height));
            }
        
        }
    }
}
