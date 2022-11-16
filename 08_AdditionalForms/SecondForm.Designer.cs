namespace _08_AdditionalForms
{
    partial class SecondForm
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
            this.ExitSecFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameLb = new System.Windows.Forms.Label();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitSecFormBtn
            // 
            this.ExitSecFormBtn.Location = new System.Drawing.Point(807, 406);
            this.ExitSecFormBtn.Name = "ExitSecFormBtn";
            this.ExitSecFormBtn.Size = new System.Drawing.Size(467, 124);
            this.ExitSecFormBtn.TabIndex = 3;
            this.ExitSecFormBtn.Text = "Exit";
            this.ExitSecFormBtn.UseVisualStyleBackColor = true;
            this.ExitSecFormBtn.Click += new System.EventHandler(this.ExitSecFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(498, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Second Form";
            // 
            // UserNameLb
            // 
            this.UserNameLb.AutoSize = true;
            this.UserNameLb.Location = new System.Drawing.Point(611, 281);
            this.UserNameLb.Name = "UserNameLb";
            this.UserNameLb.Size = new System.Drawing.Size(123, 41);
            this.UserNameLb.TabIndex = 4;
            this.UserNameLb.Text = "Hello, ...";
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(229, 406);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(467, 124);
            this.ShowBtn.TabIndex = 5;
            this.ShowBtn.Text = "Show User";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 666);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.UserNameLb);
            this.Controls.Add(this.ExitSecFormBtn);
            this.Controls.Add(this.label1);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitSecFormBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserNameLb;
        private System.Windows.Forms.Button ShowBtn;
    }
}