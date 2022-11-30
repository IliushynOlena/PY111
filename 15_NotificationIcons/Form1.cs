using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_NotificationIcons
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1000;
            this.ShowInTaskbar = false;
            notifyIcon1.Click += NotifyIcon1_Click;

        }

        private void NotifyIcon1_Click(object? sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            label1.Text = (++count).ToString();
        }

        //private void notifyIcon1_Click(object sender, EventArgs e)
        //{
        //    this.ShowInTaskbar = true;
        //    this.WindowState = FormWindowState.Normal;
        //}

        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Таймер почав відлік!";
            notifyIcon1.BalloonTipTitle = "Увага !";
            notifyIcon1.ShowBalloonTip(1000);
            //notifyIcon1.ShowBalloonTip(2000, "Увага !", "Таймер почав відлік!", ToolTipIcon.Info);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;

            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.BalloonTipText = "Таймер зупинив відлік!";
            notifyIcon1.BalloonTipTitle = "Увага !";
            notifyIcon1.ShowBalloonTip(1000);

        }
    }
}
