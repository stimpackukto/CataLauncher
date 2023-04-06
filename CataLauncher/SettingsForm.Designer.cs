namespace CataLauncher
{
    partial class SettingsForm
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
            this.menuBar1 = new CataLauncher.MenuBar();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.browseButton = new CataLauncher.CataButton();
            this.cancelButton = new CataLauncher.CataButton();
            this.okButton = new CataLauncher.CataButton();
            this.wowLocationTextBox = new System.Windows.Forms.TextBox();
            this.wowLocationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar1
            // 
            this.menuBar1.ButtonColor = System.Drawing.Color.White;
            this.menuBar1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.MenuBarText = "세팅";
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(772, 30);
            this.menuBar1.TabIndex = 19;
            this.menuBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar1_MouseDown);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Image = global::CataLauncher.Properties.Resources.MinimizeButtonNoHover;
            this.MinimizePictureBox.Location = new System.Drawing.Point(722, 5);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(22, 18);
            this.MinimizePictureBox.TabIndex = 21;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            this.MinimizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizePictureBox_MouseDown);
            this.MinimizePictureBox.MouseEnter += new System.EventHandler(this.MinimizePictureBox_MouseEnter);
            this.MinimizePictureBox.MouseLeave += new System.EventHandler(this.MinimizePictureBox_MouseLeave);
            this.MinimizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinimizePictureBox_MouseUp);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = global::CataLauncher.Properties.Resources.ExitButtonNoHover;
            this.exitPictureBox.Location = new System.Drawing.Point(749, 5);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(22, 18);
            this.exitPictureBox.TabIndex = 20;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitPictureBox_MouseDown);
            this.exitPictureBox.MouseEnter += new System.EventHandler(this.exitPictureBox_MouseEnter);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitPictureBox_MouseUp);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(13)))), ((int)(((byte)(16)))));
            this.mainPanel.Controls.Add(this.browseButton);
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Controls.Add(this.okButton);
            this.mainPanel.Controls.Add(this.wowLocationTextBox);
            this.mainPanel.Controls.Add(this.wowLocationLabel);
            this.mainPanel.Controls.Add(this.MinimizePictureBox);
            this.mainPanel.Controls.Add(this.exitPictureBox);
            this.mainPanel.Controls.Add(this.menuBar1);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 170);
            this.mainPanel.TabIndex = 22;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // browseButton
            // 
            this.browseButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(9)))));
            this.browseButton.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.browseButton.ButtonText = "검색";
            this.browseButton.Location = new System.Drawing.Point(588, 66);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(113, 18);
            this.browseButton.TabIndex = 26;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(9)))));
            this.cancelButton.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cancelButton.ButtonText = "취소";
            this.cancelButton.Location = new System.Drawing.Point(14, 126);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(113, 33);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(148)))), ((int)(((byte)(9)))));
            this.okButton.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.okButton.ButtonText = "저장";
            this.okButton.Location = new System.Drawing.Point(649, 126);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(113, 33);
            this.okButton.TabIndex = 24;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // wowLocationTextBox
            // 
            this.wowLocationTextBox.Location = new System.Drawing.Point(240, 66);
            this.wowLocationTextBox.Name = "wowLocationTextBox";
            this.wowLocationTextBox.ReadOnly = true;
            this.wowLocationTextBox.Size = new System.Drawing.Size(340, 21);
            this.wowLocationTextBox.TabIndex = 23;
            // 
            // wowLocationLabel
            // 
            this.wowLocationLabel.AutoSize = true;
            this.wowLocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.wowLocationLabel.ForeColor = System.Drawing.Color.White;
            this.wowLocationLabel.Location = new System.Drawing.Point(139, 66);
            this.wowLocationLabel.Name = "wowLocationLabel";
            this.wowLocationLabel.Size = new System.Drawing.Size(57, 12);
            this.wowLocationLabel.TabIndex = 22;
            this.wowLocationLabel.Text = "와우 폴더";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 170);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(776, 170);
            this.MinimumSize = new System.Drawing.Size(776, 170);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuBar menuBar1;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label wowLocationLabel;
        private System.Windows.Forms.TextBox wowLocationTextBox;
        private CataButton okButton;
        private CataButton cancelButton;
        private CataButton browseButton;
    }
}