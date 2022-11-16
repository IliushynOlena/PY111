namespace _08_AdditionalForms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(409, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lodin Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(428, 252);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(504, 47);
            this.LoginTB.TabIndex = 3;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(428, 366);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(504, 47);
            this.PasswordTB.TabIndex = 4;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(216, 536);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(352, 101);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(732, 536);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(271, 101);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 776);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}