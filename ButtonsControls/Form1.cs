using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonsControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool IsSelectedMeal()
        {
            return (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if( !IsSelectedMeal())
            {
                MessageBox.Show("Select meal.....");
                return;
            }


            StringBuilder res = new StringBuilder("-------------Order--------------\n");
            res.Append("Meals : ");
            if (checkBox1.Checked)
                res.Append("Breakfast");
            if (checkBox2.Checked)
                res.Append("Lunch");
            if (checkBox3.Checked)
                res.Append("Dinner");
            res.AppendLine();
            res.Append("Delivery : ");
            if (radioButton1.Checked)
                res.Append("Economy");
            if (radioButton2.Checked)
                res.Append("Standart");
            if (radioButton3.Checked)
                res.Append("Fast");
            res.AppendLine();
            res.AppendLine("Login : " + textBox1.Text);
            res.AppendLine("Password : " + textBox2.Text);
            res.AppendLine("Phone : " + maskedTextBox1.Text);


            res.AppendLine("Date : " + dateTimePicker1.Value.ToString());
            res.AppendLine("From : " + monthCalendar1.SelectionStart);
            res.AppendLine("To : " + monthCalendar1.SelectionEnd);

            res.AppendLine("Count : " +numericUpDown1.Value);
            MessageBox.Show(res.ToString());
        }
    }
}
