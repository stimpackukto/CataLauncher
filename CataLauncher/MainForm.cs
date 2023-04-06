/* 
    Cata Launcher
    Copyright (C) 2011-2013  Mitchell Kutchuk

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Threading;
using System.Diagnostics;
using System.IO;
using CataLauncher.Properties;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace CataLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            ExitPictureBox.Image = Properties.Resources.ExitButton;
        }

        private void MinimizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButton;
        }

        private void ExitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPictureBox.Image = Properties.Resources.ExitButtonNoHover;
        }

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButtonNoHover;
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PlayButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            PlayButtonPictureBox.Image = Properties.Resources.Play_Hover;
        }

        private void PlayButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            PlayButtonPictureBox.Image = Properties.Resources.PlayNoHover;
        }

        private void PlayButtonPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PlayButtonPictureBox.Image = Properties.Resources.PlayButtonPress;
        }

        private void PlayButtonPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PlayButtonPictureBox.Image = Properties.Resources.Play_Hover;
        }

        private void ExitPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ExitPictureBox.Image = Properties.Resources.ExitButtonPress;
        }

        private void ExitPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            ExitPictureBox.Image = Properties.Resources.ExitButton;
        }

        private void MinimizePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButtonPress;
        }

        private void MinimizePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButton;
        }

        private void PlayButtonPictureBox_Click(object sender, EventArgs e)
        {

            string wowExe = WoW.ExecutableLocation;

            if (!string.IsNullOrEmpty(wowExe) && File.Exists(wowExe))
            {
                Process.Start(wowExe);

                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Could not find WoW.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private delegate void UpdateProgress(int percent, long bytesReceived, long totalBytesReceive);
        private delegate void MakeVisibleInvisible(bool visible);

        private readonly string tempPath = Path.GetTempFileName();

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Settings.Default.WowLocation) || !Directory.Exists(Settings.Default.WowLocation))
            {

                if (!string.IsNullOrEmpty(WoW.Directory))
                {
                    Settings.Default.WowLocation = WoW.Directory;
                    Settings.Default.Save();
                }
                else
                {
                    using (SettingsForm form = new SettingsForm())
                        form.ShowDialog();
                }

            }

            TransparencyKey = Color.Lime;

            downloadBar1.BarState = DownloadBar.DownloadBarState.Setup;

            checkServerStatusBackgroundWorker.RunWorkerAsync();

            try
            {
                string path = WoW.RealmListLocation;

                using (StreamWriter writer = new StreamWriter(path))
                {

                    try
                    {
                        TcpClient client = new TcpClient();

                        client.Connect(Settings.Default.server, Settings.Default.port);

                        writer.WriteLine(Settings.Default.realmlist);
                        writer.Flush();

                        writer.Close();
                    }
                    catch (Exception)
                    {
                        writer.WriteLine(Settings.Default.realmlistex);
                        writer.Flush();

                        writer.Close();
                    }
                }

                string loc = WoW.CacheDirectory;

                if (!string.IsNullOrEmpty(loc) && Directory.Exists(loc))
                {
                    Directory.Delete(loc, true);
                }

                if (Settings.Default.patchDownloadURL != String.Empty)
                    startDownloadBackgroundWorker.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new UpdateProgress(UpdateProgressbar), new object[] { e.ProgressPercentage, e.BytesReceived, e.TotalBytesToReceive });
        }

        private void UpdateProgressbar(int percent, long bytesReceived, long totalBytesToReceive)
        {

            string received = String.Empty;
            string total = String.Empty;

            if (int.Parse(bytesReceived.ToString()) >= 1073741824)
                received = String.Format("{0:0.00}gb", double.Parse(bytesReceived.ToString()) / 1024 / 1024 / 1024);

            else if (int.Parse(bytesReceived.ToString()) >= 1048576)
                received = String.Format("{0:0.00}mb", double.Parse(bytesReceived.ToString()) / 1024 / 1024);

            else
                received = String.Format("{0:0.00}kb", double.Parse(bytesReceived.ToString()) / 1024);


            if (int.Parse(totalBytesToReceive.ToString()) >= 1073741824)
                total = String.Format("{0:0.00}gb", double.Parse(totalBytesToReceive.ToString()) / 1024 / 1024 / 1024);

            else if (int.Parse(totalBytesToReceive.ToString()) >= 1048576)
                total = String.Format("{0:0.00}mb", double.Parse(totalBytesToReceive.ToString()) / 1024 / 1024);

            else
                total = String.Format("{0:0.00}kb", double.Parse(totalBytesToReceive.ToString()) / 1024);

            string progress = String.Format("Download Progress: {0} / {1}", received, total);

            downloadProgressLabel.Text = progress;

            downloadBar1.Value = percent;
        }

        private Queue<PatchFileInfo> patchQueue = new Queue<PatchFileInfo>();

        

        private void DownloadPatches_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

            if (patchQueue.Count != 0)
            {
                PatchFileInfo pfi = patchQueue.Dequeue();

                WebClient DownloadPatches = new WebClient();

                DownloadPatches.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadPatches_DownloadFileCompleted);
                DownloadPatches.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadPatches_DownloadProgressChanged);

                DownloadPatches.DownloadFileAsync(new Uri(pfi.url), pfi.file);

            }
            else
                this.Invoke(new MakeVisibleInvisible(DownloadCompleted), new object[] { false });
        }

        private void DownloadCompleted(bool visible)
        {
            if (visible)
            {
                downloadProgressLabel.Visible = true;
                downloadBar1.BarState = DownloadBar.DownloadBarState.Available;
                PlayButtonPictureBox.Enabled = false;
                PlayButtonPictureBox.Image = Properties.Resources.PlayButtonDisabled;
            }
            else
            {
                downloadProgressLabel.Visible = false;
                downloadBar1.BarState = DownloadBar.DownloadBarState.Playable;
                PlayButtonPictureBox.Enabled = true;
                PlayButtonPictureBox.Image = Properties.Resources.PlayNoHover;
            }
        }

        private void DownloadPatches_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new UpdateProgress(UpdateProgressbar), new object[] { e.ProgressPercentage, (int)e.BytesReceived, (int)e.TotalBytesToReceive });
        }

        private class PatchFileInfo
        {
            public string url { get; set; }
            public string file { get; set; }
            public string md5hash { get; set; }

            public PatchFileInfo(string URL, string File)
            {
                url = URL;
                file = File;
            }
        }

        private void checkServerStatusBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool status = false;
            bool statusex = false;

            try
            {
                TcpClient client = new TcpClient();

                client.Connect(Settings.Default.server, Settings.Default.port);

                status = true;
            }
            catch (Exception)
            {
                status = false;
            }

            if (!status)
            {
                try
                {
                    TcpClient client = new TcpClient();

                    client.Connect(Settings.Default.serverex, Settings.Default.port);

                    status = true;
                    statusex = true;
                }
                catch (Exception)
                {
                    status = false;
                }
            }

            statusLabel.Invoke((MethodInvoker)delegate
            {
                if (status)
                {
                    if (statusex)
                    {
                        statusLabel.ForeColor = Color.Green;
                        statusLabel.Text = "online";
                    }
                    else
                    {
                        statusLabel.ForeColor = Color.Green;
                        statusLabel.Text = "UK online";
                    }
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "오프라인";
                }
            });
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (Credits credits = new Credits())
                credits.ShowDialog();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void menuBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm sForm = new SettingsForm())
            {
                sForm.ShowDialog();
            }
        }

        private void deathWingPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuBar1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.ForumsUrl);
        }

        private void 홈페이지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.WebsiteUrl);
        }

        private void downloadProgressLabel_Click(object sender, EventArgs e)
        {

        }

        private void launcherOuterPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void WebBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void 커스텀안내ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.DonateUrl);
        }

        private void 자주하는질문ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.VoteUrl);
        }

        private void downloadBar1_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void serverStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
