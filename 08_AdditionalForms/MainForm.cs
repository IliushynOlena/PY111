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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenSeconBtn_Click(object sender, EventArgs e)
        {
            //1
            //SecondForm form = new SecondForm();
            ////form.Show();//non modal mode
            //form.ShowDialog();//in modal mode
            //2
            //SecondForm form = new SecondForm(NameUserTB.Text);
            ////form.Show();//non modal mode
            //form.ShowDialog();//in modal mode

            //string name = NameUserTB.Text;
            //SecondForm form = new SecondForm(name);
            //form.ShowDialog();
            //3
            string name = NameUserTB.Text;
            //SecondForm form = new SecondForm();
            //form.UserName = name;
            //form.Show();
            //4
            SecondForm form = new SecondForm();
            form.Show(name);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpenLoginBtn_Click(object sender, EventArgs e)
        {
            //1
            //LoginInfo loginInfo;
            //LoginForm login = new LoginForm();
            //if(login.ShowDialog() == DialogResult.OK)
            //{
            //    loginInfo = login.LoginInfo;
            //    LoginLb.Text = loginInfo.Login;
            //    PasswordLb.Text = loginInfo.Password;
            //}

            //2
            LoginInfo loginInfo = new LoginInfo();
            LoginForm login = new LoginForm(loginInfo);
            if (login.ShowDialog() == DialogResult.OK)
            {             
                LoginLb.Text = loginInfo.Login;
                PasswordLb.Text = loginInfo.Password;
            }





        }
    }
}
