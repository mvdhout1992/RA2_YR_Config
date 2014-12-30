using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.Globalization;

namespace RA2_YR_Config
{
    public partial class UpdaterForm : Form
    {
        string FileProgress = "Current File Progress:";
        string TotalProgress = "Total Progress:";
        string CheckingForUpdates = "Checking for Updates...";
        string UpdateFailedCheckFirewall = "Update failed... Please check your connection, Anti-Virus and Firewall settings! {0}";
        string Extracting = "Extracting";
        string BadChecksumError = "Bad Checksum... Please restart the Launcher to retry the Update. {0}";

        string ClientVersionTxt = "Dune2000Update.txt";
        string[] UpdateMirrors = new string[] { "http://dune2000online.com/update/" };
        List<DownloadQueueStruct> DownloadQueue = new List<DownloadQueueStruct>();
        Stopwatch FileDownloadStopwatch = new Stopwatch();
        int TotalProgressFileSize = 0, TotalBytesDownloaded = 0;
        string[] OnlineVersionTxt = null;
        Thread updaterThread;
        TWebClient webClient = new TWebClient();
        string currentlyProcessed = "";

        struct VersionTxtStruct
        {
            public VersionTxtStruct(string[] cSV)
            {
                this.Name = cSV[0];
                this.DestDir = cSV[1];
                this.Checksum = cSV[2];
                this.IsArchive = (cSV[3] == "1");
                this.Mirrors = new List<string>();
                for (int i = 4; i < cSV.Length; i++) Mirrors.Add(cSV[i]);
            }
            public string Name;
            public string DestDir;
            public string Checksum;
            public bool IsArchive;
            public List<string> Mirrors;
        }

        struct DownloadQueueStruct
        {
            public DownloadQueueStruct(string uRL, string destDir, string name, bool isArchive, int size, string checksum)
            {
                this.URL = uRL;
                this.DestDir = destDir;
                this.Name = name;
                this.IsArchive = isArchive;
                this.Size = size;
                this.Checksum = checksum;
            }
            public string URL;
            public string DestDir;
            public string Name;
            public bool IsArchive;
            public int Size;
            public string Checksum;
        }

        public UpdaterForm()
        {
            InitializeComponent();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
            FileProgressLabel.Text = CheckingForUpdates;
            TotalProgressLabel.Text = TotalProgress;
        }

        private void UpdaterForm_Load(object sender, EventArgs e)
        {
            updaterThread = new Thread(new ThreadStart(CheckForUpdates));
            updaterThread.IsBackground = true;
            updaterThread.Start();
        }

        private void CheckForUpdates()
        {
            foreach (string mirror in UpdateMirrors)
            {
                if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                {
                    FileProgressLabel.Text = CheckingForUpdates + " (" + mirror + ")";
                });

                if ((OnlineVersionTxt = Utils.ReadWebsite(mirror + ClientVersionTxt, Environment.NewLine.ToCharArray())) != null) break;
            }
            if (OnlineVersionTxt == null)
            {
                MessageBox.Show(string.Format(UpdateFailedCheckFirewall, string.Join(Environment.NewLine, UpdateMirrors)));
                if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                {
                    this.Close();
                });
                return;
            }
            var onlineVersion = new List<VersionTxtStruct>();
            foreach (string line in OnlineVersionTxt)
            {
                if ((line.Length > 0) && (!line.StartsWith(";")))
                {
                    string[] cSV = Utils.ReadCSV(line);
                    if (cSV.Length >= 5) onlineVersion.Add(new VersionTxtStruct(cSV));
                }
            }

            foreach (var file in onlineVersion)
            {
                string localFilePath = Program.path;
                if (file.DestDir.Length > 0) localFilePath += file.DestDir + Path.DirectorySeparatorChar;
                localFilePath += (file.IsArchive) ? Path.GetFileNameWithoutExtension(file.Name) : file.Name;

                if (localFilePath.ToLower() == Files.NewLauncherExecutable.ToLower()) localFilePath = Application.ExecutablePath;

                if ((Utils.GetSHA1Checksum(localFilePath) != file.Checksum) && (!FileIsOnline(file)))
                {
                    MessageBox.Show(string.Format(UpdateFailedCheckFirewall, file.Name));
                    if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                    {
                        this.Close();
                    });
                    return;
                }
            }

            if (DownloadQueue.Count > 0) StartDownload();
            else
            {
                if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                {
                    this.DialogResult = DialogResult.Ignore;
                    this.Close();
                });
            }
        }

        private bool FileIsOnline(VersionTxtStruct file)
        {
            bool fileIsOnline = false;
            foreach (string mirror in file.Mirrors)
            {
                var httpWebRequest = HttpWebRequest.Create(mirror + file.Name);
                httpWebRequest.Method = "HEAD";
                httpWebRequest.Proxy = null;
                httpWebRequest.Timeout = 10000;
                try
                {
                    using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                    {
                        if (httpWebResponse.StatusCode == HttpStatusCode.OK)
                        {
                            int fileSize = 0;
                            int.TryParse(httpWebResponse.Headers.Get("Content-Length"), out fileSize);
                            if (file.DestDir.Length > 0) file.DestDir += Path.DirectorySeparatorChar;

                            DownloadQueue.Add(new DownloadQueueStruct(mirror + file.Name, Program.path + file.DestDir, file.Name,
                                file.IsArchive, fileSize, file.Checksum));

                            fileIsOnline = true;
                            break;
                        }
                    }
                }
                catch
                {
                }
            }
            return fileIsOnline;
        }

        private void StartDownload()
        {
            foreach (var file in DownloadQueue) TotalProgressFileSize += file.Size;
            foreach (var file in DownloadQueue)
            {
                currentlyProcessed = file.Name;
                FileDownloadStopwatch.Start();
                try
                {
                    if (!Directory.Exists(file.DestDir)) Directory.CreateDirectory(file.DestDir);

                    if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                    {
                        webClient.DownloadFileAsync(new Uri(file.URL), file.DestDir + file.Name);
                    });
                    else return;

                    while (webClient.IsBusy) Thread.Sleep(50);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                    {
                        this.Close();
                    });
                    return;
                }
                FileDownloadStopwatch.Reset();
                TotalBytesDownloaded += file.Size;
            }

            foreach (var file in DownloadQueue)
            {
                if (file.IsArchive)
                {
                    if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                    {
                        FileProgressLabel.Text = Extracting + "... " + "(" + file.Name +")";
                    });

                    string sourceFile = file.DestDir + file.Name;
                    string destFile = file.DestDir + Path.GetFileNameWithoutExtension(file.Name);

                    try
                    {
                        Utils.DecompressFileLZMA(sourceFile, destFile);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                        {
                            this.Close();
                        });
                        return;
                    }

                    if (Utils.GetSHA1Checksum(destFile) != file.Checksum)
                    {
                        if (destFile.ToLower() == Files.NewLauncherExecutable.ToLower())
                        {
                            try
                            {
                                File.Delete(destFile);
                            }
                            catch
                            {
                            }

                        }
                        MessageBox.Show(string.Format(BadChecksumError, destFile));
                        if (IsHandleCreated) this.Invoke((MethodInvoker)delegate()
                        {
                            this.Close();
                        });
                        return;
                    }

                    try
                    {
                        File.Delete(sourceFile);
                    }
                    catch
                    {
                    }
                }
            }

            this.Invoke((MethodInvoker)delegate()
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            });
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                string downloadStatus = FileProgress + " ";
                downloadStatus += (Convert.ToDouble(e.BytesReceived) / 1024 / 1024).ToString("0.00") + " MB" + " / " + (Convert.ToDouble(e.TotalBytesToReceive) / 1024 / 1024).ToString("0.00") + " MB ";
                downloadStatus += "(" + e.ProgressPercentage.ToString() + "%) - ";
                downloadStatus += (Convert.ToDouble(e.BytesReceived) / 1024 / FileDownloadStopwatch.Elapsed.TotalSeconds).ToString("0") + " kB/s ";
                downloadStatus += "(" + currentlyProcessed +")";

                if (FileProgressLabel.Text != downloadStatus) FileProgressLabel.Text = downloadStatus;
                if (FileProgressBar.Value != e.ProgressPercentage) FileProgressBar.Value = e.ProgressPercentage;

                if (TotalProgressFileSize != 0)
                {
                    int totalBytesDownloaded = (Convert.ToInt32(e.BytesReceived) + TotalBytesDownloaded);
                    int totalProgressPercentage = Convert.ToInt32(((Convert.ToDouble(totalBytesDownloaded) / TotalProgressFileSize) * 100));

                    string totalProgressStatus = TotalProgress + " ";
                    totalProgressStatus += (Convert.ToDouble(totalBytesDownloaded) / 1024 / 1024).ToString("0.00") + " MB" + " / " + (Convert.ToDouble(TotalProgressFileSize) / 1024 / 1024).ToString("0.00") + " MB ";
                    totalProgressStatus += "(" + totalProgressPercentage.ToString() + "%)";

                    if (totalProgressPercentage <= 100)
                    {
                        if (TotalProgressBar.Value != totalProgressPercentage) TotalProgressBar.Value = totalProgressPercentage;
                        if (TotalProgressLabel.Text != totalProgressStatus) TotalProgressLabel.Text = totalProgressStatus;
                    }
                }
            }
            catch
            {
            }
        }

        private void UpdaterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (var file in DownloadQueue)
                {
                    if (file.IsArchive)
                    {
                        try
                        {
                            File.Delete(file.DestDir + file.Name);
                        }
                        catch
                        {
                        }
                    }
                }
            }
            catch
            {
            }

            try
            {
                webClient.CancelAsync();
                updaterThread.Abort();
            }
            catch
            {
            }
        }


    }
}
