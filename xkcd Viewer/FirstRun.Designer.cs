namespace xkcd_Viewer
{
    partial class FirstRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstRun));
            this.BGImage = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.offlineModeCheck = new System.Windows.Forms.CheckBox();
            this.launchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGImage
            // 
            this.BGImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGImage.Image = ((System.Drawing.Image)(resources.GetObject("BGImage.Image")));
            this.BGImage.Location = new System.Drawing.Point(0, 0);
            this.BGImage.Name = "BGImage";
            this.BGImage.Size = new System.Drawing.Size(470, 340);
            this.BGImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BGImage.TabIndex = 0;
            this.BGImage.TabStop = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.offlineModeCheck);
            this.panel.Location = new System.Drawing.Point(29, 137);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(410, 87);
            this.panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "This controls whether images will be stored locally for offline access.\r\nEnabling" +
    " this will increase the size of the database.";
            // 
            // offlineModeCheck
            // 
            this.offlineModeCheck.AutoSize = true;
            this.offlineModeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offlineModeCheck.Location = new System.Drawing.Point(18, 16);
            this.offlineModeCheck.Name = "offlineModeCheck";
            this.offlineModeCheck.Size = new System.Drawing.Size(98, 17);
            this.offlineModeCheck.TabIndex = 0;
            this.offlineModeCheck.Text = "Offline Mode";
            this.offlineModeCheck.UseVisualStyleBackColor = true;
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(183, 277);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(106, 23);
            this.launchButton.TabIndex = 2;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // FirstRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 340);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.BGImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xkcd Viewer - First Run";
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BGImage;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox offlineModeCheck;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
    }
}