namespace CataLauncher
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.creditsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.serverStatusLabel = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.statusLabel = new System.Windows.Forms.Label();
			this.startDownloadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.downloadProgressLabel = new System.Windows.Forms.Label();
			this.checkServerStatusBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.PlayButtonPictureBox = new System.Windows.Forms.PictureBox();
			this.deathWingPictureBox = new System.Windows.Forms.PictureBox();
			this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
			this.ExitPictureBox = new System.Windows.Forms.PictureBox();
			this.launcherOuterPictureBox = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuBar1 = new CataLauncher.MenuBar();
			this.downloadBar1 = new CataLauncher.DownloadBar();
			this.panel1.SuspendLayout();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlayButtonPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.deathWingPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.launcherOuterPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
			this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem1});
			this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem1.Text = "About";
			// 
			// creditsToolStripMenuItem1
			// 
			this.creditsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
			this.creditsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.creditsToolStripMenuItem1.Name = "creditsToolStripMenuItem1";
			this.creditsToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
			this.creditsToolStripMenuItem1.Text = "Credits";
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
			this.fileMenuItem.ForeColor = System.Drawing.Color.White;
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileMenuItem.Text = "File";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.BackColor = System.Drawing.Color.Black;
			this.exitMenuItem.ForeColor = System.Drawing.Color.White;
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(93, 22);
			this.exitMenuItem.Text = "Exit";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
			this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// creditsToolStripMenuItem
			// 
			this.creditsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.creditsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
			this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.creditsToolStripMenuItem.Text = "Credits";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.serverStatusLabel);
			this.panel1.Controls.Add(this.menuStrip);
			this.panel1.Controls.Add(this.statusLabel);
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(804, 25);
			this.panel1.TabIndex = 7;
			// 
			// serverStatusLabel
			// 
			this.serverStatusLabel.AutoSize = true;
			this.serverStatusLabel.BackColor = System.Drawing.Color.Black;
			this.serverStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.serverStatusLabel.ForeColor = System.Drawing.Color.White;
			this.serverStatusLabel.Location = new System.Drawing.Point(660, 5);
			this.serverStatusLabel.Name = "serverStatusLabel";
			this.serverStatusLabel.Size = new System.Drawing.Size(61, 13);
			this.serverStatusLabel.TabIndex = 10;
			this.serverStatusLabel.Text = "서버 현황:";
			this.serverStatusLabel.Click += new System.EventHandler(this.serverStatusLabel_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.Black;
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
			this.menuStrip.Location = new System.Drawing.Point(25, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(72, 24);
			this.menuStrip.TabIndex = 6;
			this.menuStrip.Text = "menuStrip1";
			this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
			this.fileToolStripMenuItem1.Font = new System.Drawing.Font("맑은 고딕", 8F);
			this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
			this.fileToolStripMenuItem1.Text = "폴더설정";
			this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.settingsToolStripMenuItem.Text = "세팅";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
			this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
			this.exitToolStripMenuItem1.Text = "취소";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
			// 
			// statusLabel
			// 
			this.statusLabel.AutoSize = true;
			this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
			this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusLabel.ForeColor = System.Drawing.Color.Red;
			this.statusLabel.Location = new System.Drawing.Point(726, 5);
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(55, 13);
			this.statusLabel.TabIndex = 11;
			this.statusLabel.Text = "오프라인";
			this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
			// 
			// startDownloadBackgroundWorker
			// 
			this.startDownloadBackgroundWorker.WorkerReportsProgress = true;
			// 
			// downloadProgressLabel
			// 
			this.downloadProgressLabel.AutoSize = true;
			this.downloadProgressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
			this.downloadProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.downloadProgressLabel.ForeColor = System.Drawing.Color.White;
			this.downloadProgressLabel.Location = new System.Drawing.Point(282, 402);
			this.downloadProgressLabel.Name = "downloadProgressLabel";
			this.downloadProgressLabel.Size = new System.Drawing.Size(133, 16);
			this.downloadProgressLabel.TabIndex = 9;
			this.downloadProgressLabel.Text = "Download Progress: ";
			this.downloadProgressLabel.Visible = false;
			this.downloadProgressLabel.Click += new System.EventHandler(this.downloadProgressLabel_Click);
			// 
			// checkServerStatusBackgroundWorker
			// 
			this.checkServerStatusBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkServerStatusBackgroundWorker_DoWork);
			// 
			// PlayButtonPictureBox
			// 
			this.PlayButtonPictureBox.Image = global::CataLauncher.Properties.Resources.PlayNoHover;
			this.PlayButtonPictureBox.Location = new System.Drawing.Point(652, 423);
			this.PlayButtonPictureBox.Name = "PlayButtonPictureBox";
			this.PlayButtonPictureBox.Size = new System.Drawing.Size(140, 84);
			this.PlayButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PlayButtonPictureBox.TabIndex = 5;
			this.PlayButtonPictureBox.TabStop = false;
			this.PlayButtonPictureBox.Click += new System.EventHandler(this.PlayButtonPictureBox_Click);
			this.PlayButtonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayButtonPictureBox_MouseDown);
			this.PlayButtonPictureBox.MouseEnter += new System.EventHandler(this.PlayButtonPictureBox_MouseEnter);
			this.PlayButtonPictureBox.MouseLeave += new System.EventHandler(this.PlayButtonPictureBox_MouseLeave);
			this.PlayButtonPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayButtonPictureBox_MouseUp);
			// 
			// deathWingPictureBox
			// 
			this.deathWingPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.deathWingPictureBox.BackgroundImage = global::CataLauncher.Properties.Resources.Deathwing2;
			this.deathWingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.deathWingPictureBox.Location = new System.Drawing.Point(0, 52);
			this.deathWingPictureBox.Name = "deathWingPictureBox";
			this.deathWingPictureBox.Size = new System.Drawing.Size(804, 511);
			this.deathWingPictureBox.TabIndex = 4;
			this.deathWingPictureBox.TabStop = false;
			this.deathWingPictureBox.Click += new System.EventHandler(this.deathWingPictureBox_Click);
			// 
			// MinimizePictureBox
			// 
			this.MinimizePictureBox.Image = global::CataLauncher.Properties.Resources.MinimizeButtonNoHover;
			this.MinimizePictureBox.Location = new System.Drawing.Point(757, 5);
			this.MinimizePictureBox.Name = "MinimizePictureBox";
			this.MinimizePictureBox.Size = new System.Drawing.Size(21, 19);
			this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.MinimizePictureBox.TabIndex = 2;
			this.MinimizePictureBox.TabStop = false;
			this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
			this.MinimizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizePictureBox_MouseDown);
			this.MinimizePictureBox.MouseEnter += new System.EventHandler(this.MinimizePictureBox_MouseEnter);
			this.MinimizePictureBox.MouseLeave += new System.EventHandler(this.MinimizePictureBox_MouseLeave);
			this.MinimizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinimizePictureBox_MouseUp);
			// 
			// ExitPictureBox
			// 
			this.ExitPictureBox.Image = global::CataLauncher.Properties.Resources.ExitButtonNoHover;
			this.ExitPictureBox.Location = new System.Drawing.Point(780, 5);
			this.ExitPictureBox.Name = "ExitPictureBox";
			this.ExitPictureBox.Size = new System.Drawing.Size(21, 19);
			this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ExitPictureBox.TabIndex = 1;
			this.ExitPictureBox.TabStop = false;
			this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
			this.ExitPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitPictureBox_MouseDown);
			this.ExitPictureBox.MouseEnter += new System.EventHandler(this.ExitPictureBox_MouseEnter);
			this.ExitPictureBox.MouseLeave += new System.EventHandler(this.ExitPictureBox_MouseLeave);
			this.ExitPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ExitPictureBox_MouseUp);
			// 
			// launcherOuterPictureBox
			// 
			this.launcherOuterPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.launcherOuterPictureBox.BackgroundImage = global::CataLauncher.Properties.Resources.LauncherOuter;
			this.launcherOuterPictureBox.Location = new System.Drawing.Point(25, 52);
			this.launcherOuterPictureBox.Name = "launcherOuterPictureBox";
			this.launcherOuterPictureBox.Size = new System.Drawing.Size(498, 277);
			this.launcherOuterPictureBox.TabIndex = 3;
			this.launcherOuterPictureBox.TabStop = false;
			this.launcherOuterPictureBox.Click += new System.EventHandler(this.launcherOuterPictureBox_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.BackgroundImage = global::CataLauncher.Properties.Resources.LauncherOuter;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(25, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(410, 285);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// menuBar1
			// 
			this.menuBar1.ButtonColor = System.Drawing.Color.White;
			this.menuBar1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.menuBar1.Location = new System.Drawing.Point(0, 0);
			this.menuBar1.MenuBarText = "빛의수호자 런쳐";
			this.menuBar1.Name = "menuBar1";
			this.menuBar1.Size = new System.Drawing.Size(804, 30);
			this.menuBar1.TabIndex = 18;
			this.menuBar1.Load += new System.EventHandler(this.menuBar1_Load);
			this.menuBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar1_MouseDown);
			// 
			// downloadBar1
			// 
			this.downloadBar1.BackColor = System.Drawing.Color.Black;
			this.downloadBar1.BarState = CataLauncher.DownloadBar.DownloadBarState.Setup;
			this.downloadBar1.Location = new System.Drawing.Point(74, 401);
			this.downloadBar1.Name = "downloadBar1";
			this.downloadBar1.Size = new System.Drawing.Size(680, 150);
			this.downloadBar1.TabIndex = 19;
			this.downloadBar1.Value = 0D;
			this.downloadBar1.Load += new System.EventHandler(this.downloadBar1_Load);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lime;
			this.ClientSize = new System.Drawing.Size(806, 563);
			this.Controls.Add(this.PlayButtonPictureBox);
			this.Controls.Add(this.deathWingPictureBox);
			this.Controls.Add(this.downloadProgressLabel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.MinimizePictureBox);
			this.Controls.Add(this.ExitPictureBox);
			this.Controls.Add(this.menuBar1);
			this.Controls.Add(this.launcherOuterPictureBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.downloadBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "WoW Launcher";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlayButtonPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.deathWingPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.launcherOuterPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox launcherOuterPictureBox;
        private System.Windows.Forms.PictureBox deathWingPictureBox;
        private System.Windows.Forms.PictureBox PlayButtonPictureBox;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker startDownloadBackgroundWorker;
        private System.Windows.Forms.Label downloadProgressLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem1;
        private System.Windows.Forms.Label statusLabel;
        private System.ComponentModel.BackgroundWorker checkServerStatusBackgroundWorker;
        private MenuBar menuBar1;
        private DownloadBar downloadBar1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label serverStatusLabel;
    }
}

