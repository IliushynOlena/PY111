using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _08_AdditionalForms
{
    public partial class SecondForm : Form
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set 
            { 
                userName = value;
                UserNameLb.Text = $"Hello, dear {userName} ";
            }
        }

        //public string UserName { get; set; }
        public SecondForm()
        {
            InitializeComponent();
        }
        public SecondForm(string name)
        {
            InitializeComponent();
            UserName = name;
            UserNameLb.Text = $"Hello, dear {name} ";
        }

        private void ExitSecFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Show(string name)
        {
            UserName = name;
            this.Show();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserName);
        }
    }
}
