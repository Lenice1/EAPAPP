namespace EAPAPP
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelEAP = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.ButtonBackLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEAP
            // 
            this.labelEAP.AutoSize = true;
            this.labelEAP.BackColor = System.Drawing.Color.White;
            this.labelEAP.Font = new System.Drawing.Font("Georgia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEAP.Location = new System.Drawing.Point(127, 9);
            this.labelEAP.Name = "labelEAP";
            this.labelEAP.Size = new System.Drawing.Size(542, 41);
            this.labelEAP.TabIndex = 0;
            this.labelEAP.Text = "Employee Attendance Portal";
            this.labelEAP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(61, 167);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(61, 241);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 25);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 236);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 25);
            this.textBox2.TabIndex = 4;
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackColor = System.Drawing.Color.Lime;
            this.ButtonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnter.Location = new System.Drawing.Point(410, 313);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(75, 28);
            this.ButtonEnter.TabIndex = 14;
            this.ButtonEnter.Text = "Enter";
            this.ButtonEnter.UseVisualStyleBackColor = false;
            // 
            // ButtonBackLog
            // 
            this.ButtonBackLog.BackColor = System.Drawing.Color.Lime;
            this.ButtonBackLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackLog.Location = new System.Drawing.Point(183, 313);
            this.ButtonBackLog.Name = "ButtonBackLog";
            this.ButtonBackLog.Size = new System.Drawing.Size(75, 28);
            this.ButtonBackLog.TabIndex = 15;
            this.ButtonBackLog.Text = "Back";
            this.ButtonBackLog.UseVisualStyleBackColor = false;
            this.ButtonBackLog.Click += new System.EventHandler(this.ButtonBackLog_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.ButtonBackLog);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelEAP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEAP;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Button ButtonBackLog;
    }
}