using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult isExit;
            isExit = MessageBox.Show("Confirm if you want to close program", "Save data Grid",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (isExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text,
                textBox4.Text,textBox5.Text,textBox6.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                dataGridView.Rows.RemoveAt(row.Index);
            }
        }
        void ClearTextBox()
        {
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Text = String.Empty;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // ClearTextBox();
            int numRows = dataGridView.Rows.Count;
            for (int i = 0; i < numRows; i++)
            {
                try
                {
                    int max = dataGridView.Rows.Count - 1;
                    dataGridView.Rows.Remove(dataGridView.Rows[max]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("All rows are to be deleted " + ex, "Data Grid View Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int h = dataGridView.Height;
            dataGridView.Height = dataGridView.RowCount * dataGridView.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView.Width, dataGridView.Height);
            dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView.Width, dataGridView.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView.Height = h;

        }
    }
}
