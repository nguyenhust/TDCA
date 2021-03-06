using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SECURITY;
using Csla;

namespace NETLINK.LIB
{
    public static class DBConnection
    {

        public const string SERVER = "Data Source";
        public const string DB = "Initial Catalog";
        public const string UID = "UID";
        public const string PWD = "PWD";
        public const string CONNECTION_TIMEOUT = "Connect Timeout";

        /// <summary>
        /// Phương thức này trả về chuỗi kết nối được cấu hình cho chương trình làm việc
        /// </summary>
        public static string Connection
        {
            get
            {
                string strConn = "";
                //Neu nhu lam viec online moi can kiem tra viec dang nhap lai
                //Neu lam viec offline thi khong can
                if (!GlobalCommon.GetLoginType())
                {
                    strConn = MySecurity.Decrypt(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString, true);
                    //Kiem tra xem nguoi dung co phai dang nhap lai hay khong
                    using (SqlConnection cn = new SqlConnection(strConn))
                    {
                        ////Kiem tra xem neu co thong voi may chu thi moi mo ket noi, neu khong thi dua ra biet le loi
                        //if (GlobalCommon.IsCoThongVoiMay(cn.DataSource))
                        //{
                        //    cn.Open();
                        //    using (SqlCommand cm = cn.CreateCommand())
                        //    {
                        //        cm.CommandText = "CheckLogout";
                        //        cm.Parameters.AddWithValue("@TenDangNhap", Csla.ApplicationContext.User.Identity.Name);
                        //        cm.CommandType = CommandType.StoredProcedure;
                        //        using (Csla.Data.SafeDataReader dr = new Csla.Data.SafeDataReader(cm.ExecuteReader()))
                        //        {
                        //            if (dr.Read())
                        //            {
                        //                string ret = dr.GetString("TenDangNhap");
                        //                if (ret != "")
                        //                {
                        //                    GlobalCommon.ShowError("Người quản trị hệ thống đã THÊM hoặc BỚT chức năng làm việc của bạn\r\nBạn vui lòng đăng nhập lại để tiếp tục làm việc\r\nChương trình sẽ khởi động lại sau khi bạn chọn OK", "Bạn vui lòng đăng nhập lại");
                        //                    System.Windows.Forms.Application.Restart();
                        //                }
                        //            }
                        //        }
                        //    }
                        //}
                        //else
                        //    throw new Exception("Chương trình không thể kết nối được đến máy chủ [" + cn.DataSource + "]");
                    }
                }
                else
                {
                    strConn = MySecurity.Decrypt(ConfigurationManager.ConnectionStrings["OffLineConnection"].ConnectionString, true);
                    using (SqlConnection cn = new SqlConnection(strConn))
                    {
                        if (!GlobalCommon.IsCoThongVoiMay(cn.DataSource))
                            throw new Exception("Chương trình không thể kết nối được đến máy chủ [" + cn.DataSource + "]");
                    }
                }
                return strConn;
            }
        }


        /// <summary>
        /// Phương thức này trả về chuỗi kết nối đến máy chủ và CSDL của khoa Dược
        /// </summary>
        public static string MMSConnection
        {
            get
            {



                string strConn = MySecurity.Decrypt(ConfigurationManager.ConnectionStrings["MMSConnection"].ConnectionString, true);
                return strConn;
            }
        }

        public static string OnLineConnection
        {
            get
            {
                string strConn = "";
                strConn = MySecurity.Decrypt(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString, true);
                //Kiem tra xem nguoi dung co phai dang nhap lai hay khong
                using (SqlConnection cn = new SqlConnection(strConn))
                {
                    //Kiem tra xem neu co thong voi may chu thi moi mo ket noi, neu khong thi dua ra biet le loi
                    if (GlobalCommon.IsCoThongVoiMay(cn.DataSource))
                    {
                        cn.Open();
                        using (SqlCommand cm = cn.CreateCommand())
                        {
                            cm.CommandText = "CheckLogout";
                            cm.Parameters.AddWithValue("@TenDangNhap", Csla.ApplicationContext.User.Identity.Name);
                            cm.CommandType = CommandType.StoredProcedure;
                            using (Csla.Data.SafeDataReader dr = new Csla.Data.SafeDataReader(cm.ExecuteReader()))
                            {
                                if (dr.Read())
                                {
                                    string ret = dr.GetString("TenDangNhap");
                                    if (ret != "")
                                    {
                                        GlobalCommon.ShowError("Người quản trị hệ thống đã THÊM hoặc BỚT chức năng làm việc của bạn\r\nBạn vui lòng đăng nhập lại để tiếp tục làm việc\r\nChương trình sẽ khởi động lại sau khi bạn chọn OK", "Bạn vui lòng đăng nhập lại");
                                        System.Windows.Forms.Application.Restart();
                                    }
                                }
                            }
                        }
                    }
                    else
                        throw new Exception("Chương trình không thể kết nối được đến máy chủ [" + cn.DataSource + "]");
                }
                return strConn;
            }
        }

        public static string OffLineConnection
        {
            get
            {
                string strConn = "";
                strConn = MySecurity.Decrypt(ConfigurationManager.ConnectionStrings["OffLineConnection"].ConnectionString, true);
                using (SqlConnection cn = new SqlConnection(strConn))
                {
                    if (!GlobalCommon.IsCoThongVoiMay(cn.DataSource))
                        throw new Exception("Chương trình không thể kết nối được đến máy chủ [" + cn.DataSource + "]");
                }
                return strConn;
            }
        }

        /// <summary>
        /// Phuong thuc lay chuoi ket noi admin
        /// </summary>
        public static string AdminConnection
        {
            get
            {
                //Neu nhu lam viec online thi lay AdminConnection
                //Neu nhu lam viec offlien thi tra ve chuoi ket noi offlineconnection
                string strConn = "";
                if (!GlobalCommon.GetLoginType())
                {
                    strConn = MySecurity.Decrypt(ConfigurationManager.ConnectionStrings["AdminConnection"].ConnectionString, true);
                    using (SqlConnection cn = new SqlConnection(strConn))
                    {
                        if (!GlobalCommon.IsCoThongVoiMay(cn.DataSource))
                            throw new Exception("Chương trình không thể kết nối được đến máy chủ [" + cn.DataSource + "]");
                    }
                }
                else
                {
                    strConn = MySecurity.Decrypt(ConfigurationManager.ConnectionStrings["OffLineConnection"].ConnectionString, true);
                    using (SqlConnection cn = new SqlConnection(strConn))
                    {
                        if (!GlobalCommon.IsCoThongVoiMay(cn.DataSource))
                            throw new Exception("Chương trình không thể kết nối được đến máy chủ [" + cn.DataSource + "]");
                    }
                }
                return strConn;
            }
        }

        /// <summary>
        /// Lấy từng thành phần trong session connectionStrings
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetConnectionString(string name)
        {
            return MySecurity.Decrypt(ConfigurationManager.ConnectionStrings[name].ConnectionString, true);
        }

        /// <summary>
        /// Cập nhập lại item trong session connectionStrings
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SaveConnectionString(string name, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings[name].ConnectionString = value;
            config.Save();
        }

        /// <summary>
        /// Lấy từng thuộc tính trong xâu kết nối
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string GetPropertyName(string connectionString, string property)
        {
            string result = string.Empty;
            property = property.ToLower();

            string[] arrProperty = connectionString.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in arrProperty)
            {
                if (s.ToLower().IndexOf(property) >= 0)
                {
                    result = s.Substring(s.IndexOf("=") + 1);
                    break;
                }
            }
            return result;
        }
    }
}
