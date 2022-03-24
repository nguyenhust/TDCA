
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace NETLINK.LIB
{
    public class FtpUltilies
    {

        //public const string SERVER = "ftp.4thebigdreams.com";
        //public const string USENAME = "bachmaipro";
        //public const string PASSWORD = "1234rewq";

        public IFtpChangeProgress updateProgress { get; set; }
        public const string SERVER = "192.168.30.3";
        public const string USENAME = "mdctftp";
        public const string PASSWORD = "123@123a";


        //public IFtpChangeProgress updateProgress { get; set; }
        //public const string SERVER = "192.168.1.24";
        //public const string USENAME = "Administrator";
        //public const string PASSWORD = "123a@";

        public string FtpServer
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
        
        public FtpUltilies() {
            FtpServer = string.Format("ftp://{0}", SERVER);
            Username = USENAME;
            Password = PASSWORD;
        }

        public FtpUltilies(string ftpServer) {
            FtpServer = ftpServer;
        }


        public bool UploadFile(string fileName, bool isUseDefaultCredemtials, out string realFileName) {
            string fName = GlobalCommon.SetFileNameForFTP(fileName);//Path.GetFileName(fileName);
            string uploadPath = String.Format("{0}/{1}", FtpServer, fName);
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uploadPath);
            realFileName = fName;
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.KeepAlive = false;
            request.Timeout = 20000;

            //request.UseDefaultCredentials = isUseDefaultCredemtials;

            //if (!isUseDefaultCredemtials)
            request.Credentials = new NetworkCredential(Username, Password);
            //else
            //    request.Credentials = new NetworkCredential("anonymous", "");

            StreamReader sourceStream = new StreamReader(fileName);
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);

            if (requestStream != null) {
                requestStream.Flush();
                requestStream.Close();
                requestStream.Dispose();
            
            }

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Console.WriteLine("Upload File Complete, status {0}", response.StatusDescription);

            response.Close();

            return response.StatusDescription.StartsWith("226");

        }

        public long getFileLength(string fileName) {
            System.IO.FileInfo _FileInfo = new System.IO.FileInfo(fileName);
            return _FileInfo.Length; ;
        }

        public bool UploadLargeFile(string fileName, bool isUseDefaultCredemtials, out string realFileName) {
            System.IO.FileInfo _FileInfo = new System.IO.FileInfo(fileName);
            string fName = GlobalCommon.SetFileNameForFTP(fileName);
            realFileName = fName;
            string uploadPath = String.Format("{0}/{1}", FtpServer, fName);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uploadPath);

            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.KeepAlive = false;
            request.Timeout = 20000;
            request.UseBinary = true;

            //request.UseDefaultCredentials = isUseDefaultCredemtials;

            //if (!isUseDefaultCredemtials)
            request.Credentials = new NetworkCredential(Username, Password);
            //else
            //    request.Credentials = new NetworkCredential("anonymous", "");

            request.ContentLength = _FileInfo.Length;

            int buffLength = 2048;
            byte[] buff = new byte[buffLength];

            // open a file stream to read the file to be uploaded
            FileStream fileStream = _FileInfo.OpenRead();
            int totalReadBytesCount = 0;

            try
            {
                Stream ftpStream = request.GetRequestStream();

                // Read from the file stream 2kb at a time
                int contentLen = fileStream.Read(buff, 0, buffLength);
                totalReadBytesCount = contentLen;
                
                while (contentLen != 0) {
                    ftpStream.Write(buff, 0, contentLen);
                    //if (updateProgress != null)
                    //{
                    //    var percent = totalReadBytesCount * 100.0 / _FileInfo.Length;
                    //    updateProgress.ChangeProgress((int)percent);
                    //}
                    contentLen = fileStream.Read(buff, 0, buffLength);
                }

                // close stream
                ftpStream.Close();
                ftpStream.Dispose();
                fileStream.Close();
                fileStream.Dispose();
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public string DirectoryListing()
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + FtpServer);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(Username, Password);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string result = string.Empty;

            while (!reader.EndOfStream)
            {
                result += reader.ReadLine() + Environment.NewLine;
            }

            reader.Close();
            response.Close();
            return result;
        }

        public string DirectoryListing(string folder)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + FtpServer + "/" + folder);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(Username, Password);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string result = string.Empty;

            while (!reader.EndOfStream)
            {
                result += reader.ReadLine() + Environment.NewLine;
            }

            reader.Close();
            response.Close();
            return result;
        }

        public void Download(string file, string destination)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + FtpServer + "/" + file);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(Username, Password);
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            StreamWriter writer = new StreamWriter(destination);
            writer.Write(reader.ReadToEnd());

            writer.Close();
            reader.Close();
            response.Close();
        }

        public string DownloadFile(string FileNameToDownload, string tempDirPathIncludeFileName)
        {
            string ResponseDescription = "";
            string PureFileName = new FileInfo(FileNameToDownload).Name;
            string DownloadedFilePath = tempDirPathIncludeFileName;// + "/" + PureFileName;
            string downloadUrl = String.Format("{0}/{1}", FtpServer, FileNameToDownload);
            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(downloadUrl);
            req.Method = WebRequestMethods.Ftp.DownloadFile;
            req.Credentials = new NetworkCredential(Username, Password);
            req.UseBinary = true;
            req.Proxy = null;
            try
            {
                FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                Stream stream = response.GetResponseStream();
                byte[] buffer = new byte[2048];
                FileStream fs = new FileStream(DownloadedFilePath, FileMode.Create);
                int ReadCount = stream.Read(buffer, 0, buffer.Length);
                while (ReadCount > 0)
                {
                    fs.Write(buffer, 0, ReadCount);
                    ReadCount = stream.Read(buffer, 0, buffer.Length);
                }
                ResponseDescription = response.StatusDescription;
                fs.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                throw e;
               // GlobalCommon.ShowErrorMessager(e);
            }
            return ResponseDescription;
        }
        public void SaveDownloadedFile(string FileNameToDownload)
        {
            try
            {
                SaveFileDialog filedialog = new SaveFileDialog();
                filedialog.FileName = FileNameToDownload;
                if (filedialog.ShowDialog() == DialogResult.OK)
                {
                    DownloadFile(FileNameToDownload, filedialog.FileName);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                }
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        public Stream DownloadFile(string FileNameToDownload)
        {
            string downloadUrl = String.Format("{0}/{1}", FtpServer, FileNameToDownload);
            FtpWebRequest req = (FtpWebRequest)FtpWebRequest.Create(downloadUrl);
            req.Method = WebRequestMethods.Ftp.DownloadFile;
            req.Credentials = new NetworkCredential(Username, Password);
            req.UseBinary = true;
            req.Proxy = null;
            try
            {
                FtpWebResponse response = (FtpWebResponse)req.GetResponse();
                Stream stream = response.GetResponseStream();
                return stream;     
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }

        public bool CheckFileExistOrNot(string ftpDirectory, string FileName)
        {
            FtpWebRequest ftpRequest = null;
            FtpWebResponse ftpResponse = null;
            bool IsExists = true;
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(FtpServer + "/" + ftpDirectory + "/" + FileName);
                ftpRequest.Credentials = new NetworkCredential(Username, Password);
                ftpRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                IsExists = false;
            }
            return IsExists;
        }

        public bool DeleteFileFromServer(string filename)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FtpServer + filename);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                request.Credentials = new NetworkCredential(Username, Password);

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                response.Close();
                return true;
            }

            catch (Exception ex) {
                return false;
            }

        }
    }
}
