using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_TabControls
{
    public partial class Form1 : Form
    {
        public TextBox SelectedNameTb 
        { 
            get
            {
                foreach (var item in tabControl.SelectedTab.Controls.OfType<TextBox>())
                {
                    if (item.Name == "nameTb")
                        return item;
                }
                return null;
            }
        }
        public Form1()
        {
            InitializeComponent();
            tabControl.TabPages.Clear();
        }

    
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage($"New Tab {tabControl.TabPages.Count + 1}");
            page.UseVisualStyleBackColor = true;

            // label1
            // 
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("SimSun", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            label.Location = new System.Drawing.Point(467, 218);
            label.Size = new System.Drawing.Size(414, 67);
            label.Text = "Hello User ";
            // 
            // nameTb
            // 
            TextBox textBox = new TextBox();    
            textBox.Location = new System.Drawing.Point(440, 393);
            textBox.Name = "nameTb";
            textBox.Size = new System.Drawing.Size(539, 47);
            textBox.TabIndex = 1;
            // 
            // label2
            // 
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(251, 396);
            nameLabel.Size = new System.Drawing.Size(120, 41);
            nameLabel.Text = "Name : ";
            // 
            // ClearBtn
            // 
            Button ClearBtn = new Button();
            ClearBtn.Location = new System.Drawing.Point(499, 621);
            ClearBtn.Size = new System.Drawing.Size(287, 131);
            ClearBtn.TabIndex = 3;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += (s, args) => { textBox.Clear(); };
            // 
            page.Controls.Add(label);
            page.Controls.Add(textBox);
            page.Controls.Add(nameLabel);
            page.Controls.Add(ClearBtn);

            tabControl.TabPages.Add(page);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           if ( tabControl.SelectedIndex != -1 )
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }
     

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name {SelectedNameTb.Text}");
        }
    }
}
