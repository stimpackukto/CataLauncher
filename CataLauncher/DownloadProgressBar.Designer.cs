﻿namespace CataLauncher
{
    partial class DownloadProgressBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarPictureBox
            // 
            this.progressBarPictureBox.BackgroundImage = global::CataLauncher.Properties.Resources.DownloadProgressBarGreen;
            this.progressBarPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.progressBarPictureBox.Location = new System.Drawing.Point(0, 0);
            this.progressBarPictureBox.Name = "progressBarPictureBox";
            this.progressBarPictureBox.Size = new System.Drawing.Size(682, 9);
            this.progressBarPictureBox.TabIndex = 0;
            this.progressBarPictureBox.TabStop = false;
            // 
            // DownloadProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.Controls.Add(this.progressBarPictureBox);
            this.Name = "DownloadProgressBar";
            this.Size = new System.Drawing.Size(680, 4);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox progressBarPictureBox;
    }
}
