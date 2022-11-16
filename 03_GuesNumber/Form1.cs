using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_GuesNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Вгадай число!";
            BackColor = Color.YellowGreen;
            ForeColor = Color.Blue;
            Size = new Size(1000, 1000);

            button1.Text = "Start!";
            button1.BackColor = Color.Snow;
            button1.Location = new Point(400, 400);
            button1.Size = new Size(150, 150);

            label1.Text = "Загадай число від 0 до 1000. \nЯ намагатимусь його відгадати!";
            label1.Location = new Point(250, 300);
            label1.Size = new Size(100, 50);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberMin = 0;
            int numberMax = 1000;
            int quantity = 0;
            while (true)
            {
                quantity++;
                DialogResult res = MessageBox.Show("Your number is more than " + ((numberMax + numberMin) / 2), "Guess number", MessageBoxButtons.YesNoCancel);
                if(res == DialogResult.Yes)
                {
                    numberMin = (numberMax + numberMin) / 2 + 1;
                }
                else
                {
                    numberMax = (numberMax + numberMin) / 2;
                }
                if (numberMin == numberMax)
                    break;
                if (res == DialogResult.Cancel)
                {
                    this.Close();
                }
            }

            MessageBox.Show("You number " + numberMin + " Quantity " + quantity, "Guess number", MessageBoxButtons.OK);
        }
    }
}
