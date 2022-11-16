namespace _08_AdditionalForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OpenSeconBtn = new System.Windows.Forms.Button();
            this.NameTB = new System.Windows.Forms.Label();
            this.NameUserTB = new System.Windows.Forms.TextBox();
            this.OpenLoginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginLb = new System.Windows.Forms.Label();
            this.PasswordLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(442, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OpenSeconBtn
            // 
            this.OpenSeconBtn.Location = new System.Drawing.Point(118, 802);
            this.OpenSeconBtn.Name = "OpenSeconBtn";
            this.OpenSeconBtn.Size = new System.Drawing.Size(467, 124);
            this.OpenSeconBtn.TabIndex = 1;
            this.OpenSeconBtn.Text = "Open Second Form";
            this.OpenSeconBtn.UseVisualStyleBackColor = true;
            this.OpenSeconBtn.Click += new System.EventHandler(this.OpenSeconBtn_Click);
            // 
            // NameTB
            // 
            this.NameTB.AutoSize = true;
            this.NameTB.Location = new System.Drawing.Point(314, 290);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(112, 41);
            this.NameTB.TabIndex = 2;
            this.NameTB.Text = "Name :";
            // 
            // NameUserTB
            // 
            this.NameUserTB.Location = new System.Drawing.Point(492, 290);
            this.NameUserTB.Name = "NameUserTB";
            this.NameUserTB.Size = new System.Drawing.Size(409, 47);
            this.NameUserTB.TabIndex = 3;
            // 
            // OpenLoginBtn
            // 
            this.OpenLoginBtn.Location = new System.Drawing.Point(739, 802);
            this.OpenLoginBtn.Name = "OpenLoginBtn";
            this.OpenLoginBtn.Size = new System.Drawing.Size(467, 124);
            this.OpenLoginBtn.TabIndex = 4;
            this.OpenLoginBtn.Text = "Open Login Form";
            this.OpenLoginBtn.UseVisualStyleBackColor = true;
            this.OpenLoginBtn.Click += new System.EventHandler(this.OpenLoginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password : ";
            // 
            // LoginLb
            // 
            this.LoginLb.AutoSize = true;
            this.LoginLb.Location = new System.Drawing.Point(620, 448);
            this.LoginLb.Name = "LoginLb";
            this.LoginLb.Size = new System.Drawing.Size(60, 41);
            this.LoginLb.TabIndex = 7;
            this.LoginLb.Text = "......";
            // 
            // PasswordLb
            // 
            this.PasswordLb.AutoSize = true;
            this.PasswordLb.Location = new System.Drawing.Point(620, 589);
            this.PasswordLb.Name = "PasswordLb";
            this.PasswordLb.Size = new System.Drawing.Size(53, 41);
            this.PasswordLb.TabIndex = 8;
            this.PasswordLb.Text = ".....";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 1014);
            this.Controls.Add(this.PasswordLb);
            this.Controls.Add(this.LoginLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenLoginBtn);
            this.Controls.Add(this.NameUserTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.OpenSeconBtn);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenSeconBtn;
        private System.Windows.Forms.Label NameTB;
        private System.Windows.Forms.TextBox NameUserTB;
        private System.Windows.Forms.Button OpenLoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LoginLb;
        private System.Windows.Forms.Label PasswordLb;
    }
}
