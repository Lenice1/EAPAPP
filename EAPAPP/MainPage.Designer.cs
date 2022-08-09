namespace EAPAPP
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.labelEAP = new System.Windows.Forms.Label();
            this.ButtonLog = new System.Windows.Forms.Button();
            this.ButtonReg = new System.Windows.Forms.Button();
            this.buttonExitM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEAP
            // 
            this.labelEAP.AutoSize = true;
            this.labelEAP.BackColor = System.Drawing.Color.White;
            this.labelEAP.Font = new System.Drawing.Font("Georgia", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEAP.Location = new System.Drawing.Point(92, 9);
            this.labelEAP.Name = "labelEAP";
            this.labelEAP.Size = new System.Drawing.Size(542, 41);
            this.labelEAP.TabIndex = 1;
            this.labelEAP.Text = "Employee Attendance Portal";
            this.labelEAP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonLog
            // 
            this.ButtonLog.BackColor = System.Drawing.Color.Cyan;
            this.ButtonLog.Location = new System.Drawing.Point(225, 271);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonLog.TabIndex = 2;
            this.ButtonLog.Text = "Login";
            this.ButtonLog.UseVisualStyleBackColor = false;
            this.ButtonLog.Click += new System.EventHandler(this.ButtonLog_Click);
            // 
            // ButtonReg
            // 
            this.ButtonReg.BackColor = System.Drawing.Color.Lime;
            this.ButtonReg.Location = new System.Drawing.Point(363, 271);
            this.ButtonReg.Name = "ButtonReg";
            this.ButtonReg.Size = new System.Drawing.Size(75, 23);
            this.ButtonReg.TabIndex = 3;
            this.ButtonReg.Text = "Register";
            this.ButtonReg.UseVisualStyleBackColor = false;
            this.ButtonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // buttonExitM
            // 
            this.buttonExitM.Location = new System.Drawing.Point(559, 372);
            this.buttonExitM.Name = "buttonExitM";
            this.buttonExitM.Size = new System.Drawing.Size(75, 23);
            this.buttonExitM.TabIndex = 4;
            this.buttonExitM.Text = "Exit";
            this.buttonExitM.UseVisualStyleBackColor = true;
            this.buttonExitM.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExitM);
            this.Controls.Add(this.ButtonReg);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.labelEAP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEAP;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.Button ButtonReg;
        private System.Windows.Forms.Button buttonExitM;
    }
}