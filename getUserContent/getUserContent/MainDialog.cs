using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;


namespace getUserContent
{
    public partial class MainDialog : Form
    {
        BackgroundWorker worker_download;
        public MainDialog()
        {
            worker_download = new BackgroundWorker();
            worker_download.WorkerReportsProgress = true;
            worker_download.WorkerSupportsCancellation = true;
            worker_download.DoWork += worker_download_DoWork;
            worker_download.ProgressChanged += worker_download_ProgressChanged;
            worker_download.RunWorkerCompleted += worker_download_RunWorkerCompleted;
            InitializeComponent();
        }

        void worker_download_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Canceled", "FooBar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SelectNone_Click(null, null);
                MessageBox.Show("DONE!", "FooBar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DownloadButton.Text = "Start Download";
            }
        }

        void worker_download_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        void worker_download_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient webClient = new WebClient();
            for (int i = 0; i < UserDataList.CheckedItems.Count; i++)
            {
                string it = (string)UserDataList.CheckedItems[i];
                bool abortFlag = false;
                try
                {
                    webClient.DownloadFile("http://img.pr0gramm.com/" + it, DownloadPath.Text + "\\" + it.Replace('/', '_'));
                }
                catch (Exception ex)
                {
                    DialogResult dlResult = MessageBox.Show("Failed to download '" + it + "'.\nError:\n" + ex.Message, "Error while downloading file", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                    switch (dlResult)
                    {
                        case System.Windows.Forms.DialogResult.Retry:
                            i--;
                            break;
                        case System.Windows.Forms.DialogResult.Abort:
                            abortFlag = true;
                            break;
                    }
                }
                if (abortFlag || worker_download.CancellationPending)
                    break;
                if(i > 0)
                    worker_download.ReportProgress((int)((i / (double)UserDataList.CheckedItems.Count) * 100));
            }
        }

        private void DownloadPath_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dlResult = folderBrowserDialog1.ShowDialog();
            if (dlResult == System.Windows.Forms.DialogResult.OK)
            {
                DownloadPath.Text = folderBrowserDialog1.SelectedPath;
                DownloadButton.Enabled = true;
            }
        }

        private void getUserData_Click(object sender, EventArgs e)
        {
            try
            {
                var list = getUserDataList(username.Text);
                UserDataList.Items.AddRange(list.ToArray());
                SelectAll_Click(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to fetch data\n" + ex.Message, "Whoops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<string> getUserDataList(string username, int lastNum = -1)
        {
            List<string> list = new List<String>();
            WebRequest request = WebRequest.Create(@"http://pr0gramm.com/api/items/get?" + (lastNum < 0 ? "" : "older=" + lastNum + "&") + "flags=7&user=" + username);
            request.Method = "GET";
            request.Credentials = CredentialCache.DefaultCredentials;
            ((HttpWebRequest)request).UserAgent = @"Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2272.76 Safari/537.36";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            int nextIndex = 0;
            while ((nextIndex = responseString.IndexOf("\"image\":\"", nextIndex)) > 0)
            {
                int imageEndIndex = responseString.IndexOf("\",\"thumb\":\"", nextIndex);
                int imageStartIndex = nextIndex + "\"image\":\"".Length;
                string sub = responseString.Substring(imageStartIndex, imageEndIndex - imageStartIndex);
                sub = sub.Replace("\\/", "/");
                list.Add(sub);
                nextIndex = imageEndIndex;
            }
            if(list.Count != 0)
            {
                var indexStart = responseString.LastIndexOf("\"id\":") + "\"id\":".Length;
                var intString = responseString.Substring(indexStart, responseString.IndexOf(',', indexStart) - indexStart);
                lastNum = Convert.ToInt32(intString);
                list.AddRange(getUserDataList(username, lastNum));
            }

            return list;
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < UserDataList.Items.Count; i++)
            {
                UserDataList.SetItemChecked(i, true);
            }
        }

        private void SelectNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < UserDataList.Items.Count; i++)
            {
                UserDataList.SetItemChecked(i, false);
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (worker_download.IsBusy)
            {
                DownloadButton.Text = "Start Download";
                worker_download.CancelAsync();
            }
            else
            {
                DownloadButton.Text = "Abort Download";
                worker_download.RunWorkerAsync();
            }
        }
    }
}
