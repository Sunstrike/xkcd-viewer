namespace xkcd_Viewer
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.viewerCoreLabel = new System.Windows.Forms.Label();
            this.offlineViewingLabel = new System.Windows.Forms.Label();
            this.jettisonLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.offlineViewingButton = new System.Windows.Forms.Button();
            this.jettisonButton = new System.Windows.Forms.Button();
            this.imagePurgeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewerCoreLabel
            // 
            this.viewerCoreLabel.AutoSize = true;
            this.viewerCoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewerCoreLabel.Location = new System.Drawing.Point(12, 9);
            this.viewerCoreLabel.Name = "viewerCoreLabel";
            this.viewerCoreLabel.Size = new System.Drawing.Size(84, 15);
            this.viewerCoreLabel.TabIndex = 0;
            this.viewerCoreLabel.Text = "Viewer Core";
            // 
            // offlineViewingLabel
            // 
            this.offlineViewingLabel.Location = new System.Drawing.Point(41, 36);
            this.offlineViewingLabel.Name = "offlineViewingLabel";
            this.offlineViewingLabel.Size = new System.Drawing.Size(100, 13);
            this.offlineViewingLabel.TabIndex = 1;
            this.offlineViewingLabel.Text = "Offline Viewing";
            this.offlineViewingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jettisonLabel
            // 
            this.jettisonLabel.Location = new System.Drawing.Point(41, 98);
            this.jettisonLabel.Name = "jettisonLabel";
            this.jettisonLabel.Size = new System.Drawing.Size(100, 13);
            this.jettisonLabel.TabIndex = 2;
            this.jettisonLabel.Text = "Jettison Database";
            this.jettisonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purge Images";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Backend Management";
            // 
            // offlineViewingButton
            // 
            this.offlineViewingButton.Location = new System.Drawing.Point(173, 31);
            this.offlineViewingButton.Name = "offlineViewingButton";
            this.offlineViewingButton.Size = new System.Drawing.Size(75, 23);
            this.offlineViewingButton.TabIndex = 5;
            this.offlineViewingButton.Text = "Enable...";
            this.offlineViewingButton.UseVisualStyleBackColor = true;
            this.offlineViewingButton.Click += new System.EventHandler(this.offlineViewingButton_Click);
            // 
            // jettisonButton
            // 
            this.jettisonButton.Location = new System.Drawing.Point(173, 93);
            this.jettisonButton.Name = "jettisonButton";
            this.jettisonButton.Size = new System.Drawing.Size(75, 23);
            this.jettisonButton.TabIndex = 6;
            this.jettisonButton.Text = "Jettison";
            this.jettisonButton.UseVisualStyleBackColor = true;
            this.jettisonButton.Click += new System.EventHandler(this.jettisonButton_Click);
            // 
            // imagePurgeButton
            // 
            this.imagePurgeButton.Location = new System.Drawing.Point(173, 128);
            this.imagePurgeButton.Name = "imagePurgeButton";
            this.imagePurgeButton.Size = new System.Drawing.Size(75, 23);
            this.imagePurgeButton.TabIndex = 7;
            this.imagePurgeButton.Text = "Purge...";
            this.imagePurgeButton.UseVisualStyleBackColor = true;
            this.imagePurgeButton.Click += new System.EventHandler(this.imagePurgeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 102);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cache Maintenance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = "Running \'Purge Images\' is\r\nrecommended after\r\ndisabling Offline Viewing\r\nto recla" +
    "im disk space.";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(189, 274);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 309);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imagePurgeButton);
            this.Controls.Add(this.jettisonButton);
            this.Controls.Add(this.offlineViewingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jettisonLabel);
            this.Controls.Add(this.offlineViewingLabel);
            this.Controls.Add(this.viewerCoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Preferences";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewerCoreLabel;
        private System.Windows.Forms.Label offlineViewingLabel;
        private System.Windows.Forms.Label jettisonLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button offlineViewingButton;
        private System.Windows.Forms.Button jettisonButton;
        private System.Windows.Forms.Button imagePurgeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closeButton;
    }
}