using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_AdditionalForms
{
    public partial class LoginForm : Form
    {      
        public LoginInfo LoginInfo { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            LoginInfo = new LoginInfo();
        }
        public LoginForm(LoginInfo info)
        {
            InitializeComponent();
            LoginInfo = info;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //LoginInfo = new LoginInfo()
            //{
            //    Login = LoginTB.Text,
            //    Password = PasswordTB.Text

            //};
            if (string.IsNullOrEmpty(LoginTB.Text) ||
                string.IsNullOrEmpty(PasswordTB.Text))
            {
                MessageBox.Show("Enter login or password ....");
                return;
            }
            LoginInfo.Login = LoginTB.Text;
            LoginInfo.Password = PasswordTB.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
