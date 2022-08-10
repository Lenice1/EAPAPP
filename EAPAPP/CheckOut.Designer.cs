namespace EAPAPP
{
    partial class FormCheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckOut));
            this.buttonExitO = new System.Windows.Forms.Button();
            this.labelCheckOut = new System.Windows.Forms.Label();
            this.dateTimePickerCO = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerO = new System.Windows.Forms.DateTimePicker();
            this.buttonCO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExitO
            // 
            this.buttonExitO.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitO.Image")));
            this.buttonExitO.Location = new System.Drawing.Point(651, 389);
            this.buttonExitO.Name = "buttonExitO";
            this.buttonExitO.Size = new System.Drawing.Size(75, 23);
            this.buttonExitO.TabIndex = 6;
            this.buttonExitO.Text = "Exit";
            this.buttonExitO.UseVisualStyleBackColor = true;
            this.buttonExitO.Click += new System.EventHandler(this.buttonExitO_Click);
            // 
            // labelCheckOut
            // 
            this.labelCheckOut.AutoSize = true;
            this.labelCheckOut.BackColor = System.Drawing.Color.White;
            this.labelCheckOut.Font = new System.Drawing.Font("Georgia", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckOut.Location = new System.Drawing.Point(306, 9);
            this.labelCheckOut.Name = "labelCheckOut";
            this.labelCheckOut.Size = new System.Drawing.Size(178, 41);
            this.labelCheckOut.TabIndex = 7;
            this.labelCheckOut.Text = "Check Out";
            this.labelCheckOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePickerCO
            // 
            this.dateTimePickerCO.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerCO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCO.Location = new System.Drawing.Point(336, 169);
            this.dateTimePickerCO.Name = "dateTimePickerCO";
            this.dateTimePickerCO.Size = new System.Drawing.Size(148, 26);
            this.dateTimePickerCO.TabIndex = 9;
            // 
            // dateTimePickerO
            // 
            this.dateTimePickerO.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerO.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerO.Location = new System.Drawing.Point(336, 247);
            this.dateTimePickerO.Name = "dateTimePickerO";
            this.dateTimePickerO.Size = new System.Drawing.Size(148, 26);
            this.dateTimePickerO.TabIndex = 10;
            // 
            // buttonCO
            // 
            this.buttonCO.BackColor = System.Drawing.Color.Lime;
            this.buttonCO.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCO.Location = new System.Drawing.Point(336, 318);
            this.buttonCO.Name = "buttonCO";
            this.buttonCO.Size = new System.Drawing.Size(148, 35);
            this.buttonCO.TabIndex = 11;
            this.buttonCO.Text = "Check Out";
            this.buttonCO.UseVisualStyleBackColor = false;
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCO);
            this.Controls.Add(this.dateTimePickerO);
            this.Controls.Add(this.dateTimePickerCO);
            this.Controls.Add(this.labelCheckOut);
            this.Controls.Add(this.buttonExitO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckOut";
            this.Text = "CheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitO;
        private System.Windows.Forms.Label labelCheckOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerCO;
        private System.Windows.Forms.DateTimePicker dateTimePickerO;
        private System.Windows.Forms.Button buttonCO;
    }
}