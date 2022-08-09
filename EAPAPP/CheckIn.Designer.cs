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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.buttonExitI = new System.Windows.Forms.Button();
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
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExitI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitI;
    }
}