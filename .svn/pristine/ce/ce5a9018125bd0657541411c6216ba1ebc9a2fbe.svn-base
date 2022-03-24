using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETLINK.LIB
{
    public class FtpHelper : IFtpChangeProgress
    {
        private BackgroundWorker bw;

        public ProgressBar progressBar;

        public IFtpHandle FtpHandle { get; set; }

        public string InpuFile { get; set; }
        public string OutputFile { get; set; }

        FtpUltilies ftp = new FtpUltilies();

        public FtpHelper() {

            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.WorkerReportsProgress = true;
            ftp.updateProgress = this;
        }

        public FtpHelper(string fileName)
        {
            InpuFile = fileName;
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            bw.WorkerReportsProgress = true;
            ftp.updateProgress = this;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!string.IsNullOrEmpty(InpuFile))
            {
                string ftpFile = string.Empty;
                string outFile = string.Empty;
                bool isSuccess = ftp.UploadLargeFile(InpuFile, true, out outFile);
                OutputFile = outFile;
                if (isSuccess)
                    if (FtpHandle != null)
                        FtpHandle.OnFtpUpLoadSuccessFully();
                    else
                    {
                        FtpHandle.OnFtpUpLoadFailed();
                    }
            }
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        public void ChangeProgress(int percent) {
            bw.ReportProgress(percent);
        }

        public void StartUploadFile() {
            bw.RunWorkerAsync();
        }
    }
}
