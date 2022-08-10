namespace EAPAPP
{
    partial class ViewRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecords));
            this.buttonExitVR = new System.Windows.Forms.Button();
            this.buttonBackVR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExitVR
            // 
            this.buttonExitVR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitVR.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitVR.Image")));
            this.buttonExitVR.Location = new System.Drawing.Point(676, 392);
            this.buttonExitVR.Name = "buttonExitVR";
            this.buttonExitVR.Size = new System.Drawing.Size(75, 23);
            this.buttonExitVR.TabIndex = 6;
            this.buttonExitVR.Text = "Exit";
            this.buttonExitVR.UseVisualStyleBackColor = true;
            this.buttonExitVR.Click += new System.EventHandler(this.buttonExitVR_Click);
            // 
            // buttonBackVR
            // 
            this.buttonBackVR.BackColor = System.Drawing.Color.White;
            this.buttonBackVR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBackVR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackVR.Image = ((System.Drawing.Image)(resources.GetObject("buttonBackVR.Image")));
            this.buttonBackVR.Location = new System.Drawing.Point(581, 392);
            this.buttonBackVR.Name = "buttonBackVR";
            this.buttonBackVR.Size = new System.Drawing.Size(75, 23);
            this.buttonBackVR.TabIndex = 7;
            this.buttonBackVR.Text = "Back";
            this.buttonBackVR.UseVisualStyleBackColor = false;
            this.buttonBackVR.Click += new System.EventHandler(this.buttonBackVR_Click);
            // 
            // ViewRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackVR);
            this.Controls.Add(this.buttonExitVR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewRecords";
            this.Text = "ViewRecords";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitVR;
        private System.Windows.Forms.Button buttonBackVR;
    }
}