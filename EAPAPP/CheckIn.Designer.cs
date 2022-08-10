namespace EAPAPP
{
    partial class CheckIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.buttonExitI = new System.Windows.Forms.Button();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.dateTimePickerI = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePickerCI = new System.Windows.Forms.DateTimePicker();
            this.buttonCI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExitI
            // 
            this.buttonExitI.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitI.Image")));
            this.buttonExitI.Location = new System.Drawing.Point(618, 388);
            this.buttonExitI.Name = "buttonExitI";
            this.buttonExitI.Size = new System.Drawing.Size(75, 23);
            this.buttonExitI.TabIndex = 5;
            this.buttonExitI.Text = "Exit";
            this.buttonExitI.UseVisualStyleBackColor = true;
            this.buttonExitI.Click += new System.EventHandler(this.buttonExitI_Click);
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.AutoSize = true;
            this.labelCheckIn.BackColor = System.Drawing.Color.White;
            this.labelCheckIn.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIn.Location = new System.Drawing.Point(308, 9);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(155, 41);
            this.labelCheckIn.TabIndex = 6;
            this.labelCheckIn.Text = "Check In";
            this.labelCheckIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerI
            // 
            this.dateTimePickerI.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerI.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerI.Location = new System.Drawing.Point(315, 248);
            this.dateTimePickerI.Name = "dateTimePickerI";
            this.dateTimePickerI.Size = new System.Drawing.Size(148, 26);
            this.dateTimePickerI.TabIndex = 7;
            // 
            // dateTimePickerCI
            // 
            this.dateTimePickerCI.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCI.Location = new System.Drawing.Point(315, 169);
            this.dateTimePickerCI.Name = "dateTimePickerCI";
            this.dateTimePickerCI.Size = new System.Drawing.Size(148, 26);
            this.dateTimePickerCI.TabIndex = 8;
            // 
            // buttonCI
            // 
            this.buttonCI.BackColor = System.Drawing.Color.Lime;
            this.buttonCI.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCI.Location = new System.Drawing.Point(315, 318);
            this.buttonCI.Name = "buttonCI";
            this.buttonCI.Size = new System.Drawing.Size(148, 35);
            this.buttonCI.TabIndex = 9;
            this.buttonCI.Text = "Check In";
            this.buttonCI.UseVisualStyleBackColor = false;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCI);
            this.Controls.Add(this.dateTimePickerCI);
            this.Controls.Add(this.dateTimePickerI);
            this.Controls.Add(this.labelCheckIn);
            this.Controls.Add(this.buttonExitI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitI;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerI;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCI;
        private System.Windows.Forms.Button buttonCI;
    }
}