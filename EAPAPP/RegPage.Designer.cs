namespace EAPAPP
{
    partial class FormRegistrationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrationPage));
            this.labelEAP = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRetypepassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxRetypePassword = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.ButtonBackReg = new System.Windows.Forms.Button();
            this.buttonExitR = new System.Windows.Forms.Button();
            this.checkBoxShowP = new System.Windows.Forms.CheckBox();
            this.checkBoxRP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelEAP
            // 
            this.labelEAP.AutoSize = true;
            this.labelEAP.BackColor = System.Drawing.Color.White;
            this.labelEAP.Font = new System.Drawing.Font("Georgia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEAP.Location = new System.Drawing.Point(131, 9);
            this.labelEAP.Name = "labelEAP";
            this.labelEAP.Size = new System.Drawing.Size(542, 41);
            this.labelEAP.TabIndex = 0;
            this.labelEAP.Text = "Employee Attendance Portal";
            this.labelEAP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(63, 113);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(63, 173);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(63, 230);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(98, 20);
            this.labelDepartment.TabIndex = 3;
            this.labelDepartment.Text = "Department:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(63, 293);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(48, 20);
            this.labelDOB.TabIndex = 4;
            this.labelDOB.Text = "DOB:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(230, 113);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(231, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(230, 173);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(231, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(230, 230);
            this.textBoxDepartment.Multiline = true;
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(231, 20);
            this.textBoxDepartment.TabIndex = 7;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(230, 293);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(231, 20);
            this.dateTimePickerDOB.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(63, 358);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 20);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password:";
            // 
            // labelRetypepassword
            // 
            this.labelRetypepassword.AutoSize = true;
            this.labelRetypepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelRetypepassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetypepassword.Location = new System.Drawing.Point(63, 411);
            this.labelRetypepassword.Name = "labelRetypepassword";
            this.labelRetypepassword.Size = new System.Drawing.Size(146, 20);
            this.labelRetypepassword.TabIndex = 10;
            this.labelRetypepassword.Text = "Re-Type Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(230, 358);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(231, 20);
            this.textBoxPassword.TabIndex = 11;
            // 
            // textBoxRetypePassword
            // 
            this.textBoxRetypePassword.Location = new System.Drawing.Point(230, 411);
            this.textBoxRetypePassword.Multiline = true;
            this.textBoxRetypePassword.Name = "textBoxRetypePassword";
            this.textBoxRetypePassword.PasswordChar = '*';
            this.textBoxRetypePassword.Size = new System.Drawing.Size(231, 20);
            this.textBoxRetypePassword.TabIndex = 12;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.BackColor = System.Drawing.Color.Lime;
            this.ButtonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSubmit.Location = new System.Drawing.Point(616, 403);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 28);
            this.ButtonSubmit.TabIndex = 13;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = false;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // ButtonBackReg
            // 
            this.ButtonBackReg.BackColor = System.Drawing.Color.Lime;
            this.ButtonBackReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackReg.Location = new System.Drawing.Point(509, 403);
            this.ButtonBackReg.Name = "ButtonBackReg";
            this.ButtonBackReg.Size = new System.Drawing.Size(75, 28);
            this.ButtonBackReg.TabIndex = 14;
            this.ButtonBackReg.Text = "Back";
            this.ButtonBackReg.UseVisualStyleBackColor = false;
            this.ButtonBackReg.Click += new System.EventHandler(this.ButtonBackReg_Click);
            // 
            // buttonExitR
            // 
            this.buttonExitR.Location = new System.Drawing.Point(713, 403);
            this.buttonExitR.Name = "buttonExitR";
            this.buttonExitR.Size = new System.Drawing.Size(75, 23);
            this.buttonExitR.TabIndex = 15;
            this.buttonExitR.Text = "Exit";
            this.buttonExitR.UseVisualStyleBackColor = true;
            this.buttonExitR.Click += new System.EventHandler(this.buttonExitR_Click);
            // 
            // checkBoxShowP
            // 
            this.checkBoxShowP.AutoSize = true;
            this.checkBoxShowP.Location = new System.Drawing.Point(408, 384);
            this.checkBoxShowP.Name = "checkBoxShowP";
            this.checkBoxShowP.Size = new System.Drawing.Size(53, 17);
            this.checkBoxShowP.TabIndex = 17;
            this.checkBoxShowP.Text = "Show";
            this.checkBoxShowP.UseVisualStyleBackColor = true;
            this.checkBoxShowP.CheckedChanged += new System.EventHandler(this.checkBoxShowP_CheckedChanged);
            // 
            // checkBoxRP
            // 
            this.checkBoxRP.AutoSize = true;
            this.checkBoxRP.Location = new System.Drawing.Point(408, 437);
            this.checkBoxRP.Name = "checkBoxRP";
            this.checkBoxRP.Size = new System.Drawing.Size(53, 17);
            this.checkBoxRP.TabIndex = 18;
            this.checkBoxRP.Text = "Show";
            this.checkBoxRP.UseVisualStyleBackColor = true;
            this.checkBoxRP.CheckedChanged += new System.EventHandler(this.checkBoxRP_CheckedChanged);
            // 
            // FormRegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.checkBoxRP);
            this.Controls.Add(this.checkBoxShowP);
            this.Controls.Add(this.buttonExitR);
            this.Controls.Add(this.ButtonBackReg);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.textBoxRetypePassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelRetypepassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEAP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistrationPage";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEAP;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRetypepassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxRetypePassword;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.Button ButtonBackReg;
        private System.Windows.Forms.Button buttonExitR;
        private System.Windows.Forms.CheckBox checkBoxShowP;
        private System.Windows.Forms.CheckBox checkBoxRP;
    }
}