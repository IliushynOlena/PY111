namespace IntroToWinForm
{
    partial class Form1
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
            this.ClickButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CSharp = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickButton
            // 
            this.ClickButton.BackColor = System.Drawing.Color.Lime;
            this.ClickButton.Font = new System.Drawing.Font("MS PGothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClickButton.Location = new System.Drawing.Point(115, 171);
            this.ClickButton.Name = "ClickButton";
            this.ClickButton.Size = new System.Drawing.Size(317, 157);
            this.ClickButton.TabIndex = 0;
            this.ClickButton.Text = "Click me";
            this.ClickButton.UseVisualStyleBackColor = false;
            this.ClickButton.Click += new System.EventHandler(this.button1_Click);
            this.ClickButton.MouseEnter += new System.EventHandler(this.ClickButton_MouseEnter);
            this.ClickButton.MouseLeave += new System.EventHandler(this.ClickButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitButton.Location = new System.Drawing.Point(649, 169);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(317, 157);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(238, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 94);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello Windows form";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Move left";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CSharp
            // 
            this.CSharp.Location = new System.Drawing.Point(521, 489);
            this.CSharp.Name = "CSharp";
            this.CSharp.Size = new System.Drawing.Size(70, 70);
            this.CSharp.TabIndex = 4;
            this.CSharp.Text = "C#";
            this.CSharp.UseVisualStyleBackColor = true;
            this.CSharp.Click += new System.EventHandler(this.CSharp_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(886, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Move Right";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 721);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CSharp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClickButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CSharp;
        private System.Windows.Forms.Button button3;
    }
}
