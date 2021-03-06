using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace NETLINK.LIB
{
    public static class AppConfig
    {
        /// <summary>
        /// Giới bạn số bản ghi hiển trị trên lưới
        /// </summary>
        public static string RecordLimit
        {
            get { return System.Configuration.ConfigurationManager.AppSettings.Get("RecordLimit"); }
        }

        /// <summary>
        /// Tự động hiển thị dữ liệu lên lưới
        /// </summary>
        public static string AutoShowData
        {
            get { return System.Configuration.ConfigurationManager.AppSettings.Get("AutoShowData"); }
        }

        /// <summary>
        /// Chuỗi tìm kiếm xuất hiện ở vị trí nào trong chuỗi chứa
        /// </summary>
        public static string SearchPosition
        {
            get { return System.Configuration.ConfigurationManager.AppSettings.Get("SearchPosition"); }
        }

        /// <summary>
        /// Đường dẫn thư mục nơi chứa báo cáo
        /// </summary>
        public static string ReportPath
        {
            get
            {
                string strReportPath = System.Configuration.ConfigurationManager.AppSettings.Get("ReportPath");
                return strReportPath.Equals("") ? System.Windows.Forms.Application.StartupPath + @"\Report\" : strReportPath;

            }
        }


        /// <summary>
        /// Lưu giá trị của key trong appSettings
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SaveAppSetting(string name, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[name].Value = value;
            config.Save();            
        }
        
        /// <summary>
        /// Lấy giá trị của key trong appSettings
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetKeyAppSetting(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(key);
        }
        /// <summary>
        /// Dang Van Thi, load lai gia tri cua AppConfig khi ghi vao
        /// </summary>
        public static void ReloadSectionAppconfig()
        {
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
