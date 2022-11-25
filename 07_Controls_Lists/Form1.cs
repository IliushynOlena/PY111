using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Controls_Lists
{
    public partial class Form1 : Form
    {
        List<Order> orders = new List<Order>();
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        
            orders.Add(new Order(rand.Next(1000)));
            orders.Add(new Order(rand.Next(1000)));
            orders.Add(new Order(rand.Next(1000)));
            orders.Add(new Order(rand.Next(1000)));
            //OrderComboBox.Items.AddRange(orders.ToArray());
            //OrderComboBox.DataSource = orders;
            UpdateOrderComboBox();
        }
        private void UpdateOrderComboBox()
        {
            OrderComboBox.DataSource = null;
            OrderComboBox.DataSource = orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (OrderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an order from list");
                return;
            }
            Order selected = OrderComboBox.SelectedItem as Order;
            MessageBox.Show(selected.ToString(),
                "Order details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            orders.Add(new Order(numericUpDown1.Value));
            MessageBox.Show("Order was added");
            UpdateOrderComboBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (OrderComboBox.SelectedIndex == -1) return;
            orders.RemoveAt(OrderComboBox.SelectedIndex);
            MessageBox.Show("Order was deleted");
            UpdateOrderComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("No selected Item!");
                return;
            }
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string res = "----------- Selected Items -----------\n";
                foreach (var item in listBox1.SelectedItems)
                {
                    res += item.ToString() + Environment.NewLine;
                }
                MessageBox.Show(res);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems)
            {
                checkedListBox1.Items.Add(item);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 0;
        }
    }
}