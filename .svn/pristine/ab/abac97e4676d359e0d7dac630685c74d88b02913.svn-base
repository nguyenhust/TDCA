using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
namespace ModuleHanhChinh.LIB
{
   public class LopHocSeach
    {
         private Int32 _intIDLopHoc;
        public static string _strMaLopHoc = string.Empty;
        private string _strTenCanBoPhuTrach = string.Empty;
        private string _strTenChuyenKhoa = string.Empty;
        private string _strTenLop = string.Empty;
     public Int32 IDLopHoc
        {
            get { return _intIDLopHoc; }
            set { _intIDLopHoc = value; }
        }
     public string MaLopHoc
     {
         get { return _strMaLopHoc; }
         set { _strMaLopHoc = value; }
     }
     public string TenCanBoPhuTrach
     {
         get { return _strTenCanBoPhuTrach; }
         set { _strTenCanBoPhuTrach = value; }
     }
     public string TenChuyenKhoa
     {
         get { return _strTenChuyenKhoa; }
         set { _strTenChuyenKhoa = value; }
     }
     public string TenLop
     {
         get { return _strTenLop; }
         set { _strTenLop = value; }
     }
       public LopHocSeach(string strMaLopHoc)
     {
           _strMaLopHoc=strMaLopHoc;
     }
         public static void search(ref DataTable dt, Int32 intIDLopHoc)
         {
             string strSQL = " exec DT_LopHoc_gets ";
             //if (intIDHocVien !='')
             strSQL = strSQL + "'" + intIDLopHoc + "'" ;
             //else
             //    strSQL = strSQL + " null";

             using (SqlConnection cn = new SqlConnection(NETLINK.LIB.DBConnection.Connection))
             {
                 cn.Open();
                 using (SqlCommand cm = cn.CreateCommand())
                 {
                     cm.CommandText = strSQL;
                     cm.CommandType = CommandType.Text;
                     using (SqlDataAdapter dad = new SqlDataAdapter(cm))
                     {
                         dad.Fill(dt);
                     }
                 }
             }
         }
    }
}
