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
            this.textBoxEmailLog = new System.Windows.Forms.TextBox();
            this.textBoxPassLog = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.ButtonBackLog = new System.Windows.Forms.Button();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
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
            // textBoxEmailLog
            // 
            this.textBoxEmailLog.Location = new System.Drawing.Point(183, 162);
            this.textBoxEmailLog.Multiline = true;
            this.textBoxEmailLog.Name = "textBoxEmailLog";
            this.textBoxEmailLog.Size = new System.Drawing.Size(302, 25);
            this.textBoxEmailLog.TabIndex = 3;
            // 
            // textBoxPassLog
            // 
            this.textBoxPassLog.Location = new System.Drawing.Point(183, 236);
            this.textBoxPassLog.Multiline = true;
            this.textBoxPassLog.Name = "textBoxPassLog";
            this.textBoxPassLog.PasswordChar = '*';
            this.textBoxPassLog.Size = new System.Drawing.Size(302, 25);
            this.textBoxPassLog.TabIndex = 4;
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
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Location = new System.Drawing.Point(519, 241);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(53, 17);
            this.checkBoxShow.TabIndex = 16;
            this.checkBoxShow.Text = "Show";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.ButtonBackLog);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.textBoxPassLog);
            this.Controls.Add(this.textBoxEmailLog);
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
        private System.Windows.Forms.TextBox textBoxEmailLog;
        private System.Windows.Forms.TextBox textBoxPassLog;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Button ButtonBackLog;
        private System.Windows.Forms.CheckBox checkBoxShow;
    }
}