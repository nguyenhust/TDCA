using System.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SECURITY;

namespace NETLINK.LIB
{
    public enum TransacType
    {
        Insert =1,
        Unpdate =2,
        Delete =3
    }
   public static class SysRecordInfo
    {
       public static void SaveRecordInfor(SqlConnection tns, string strtableName, string strIDRow, TransacType Transactypes)
       {
       }
       /// <summary>
       /// Thuc hien chen hoac cap nhat du lieu vao bang sys_RecordInfo
       /// </summary>
       /// <param name="cn">mot ket noi da duoc open()</param>
       /// <param name="strtableName">Ten bang dang duoc cap nhat</param>
       /// <param name="strIDRow">  chi so cua hang duoc cap nhat( gia tri cua truong Identity)</param>
       /// <param name="Transactypes"> kieu cap nhat co ba loai nam trong enum Transactype</param>
       public static void SaveRecordInfor(SqlTransaction tns, string strtableName, string strIDRow, TransacType Transactypes)
       {
           if (GlobalCommon.GetParameter("LMR") == "1")
           {
               string _strIDNguoiDung = MySecurity.Encrypt(GlobalCommon.GetIDNguoiDung().ToString(), true);//GlobalCommon.GetIDNguoiDung().ToString();//
               string _strTenNguoiDung = MySecurity.Encrypt(GlobalCommon.GetTenNguoiDung(), true);// GlobalCommon.GetTenNguoiDung();
               String _strClientTime = MySecurity.Encrypt(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), true); //DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");//
               string _strServertTime = MySecurity.Encrypt(GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm:ss"), true); //GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm:ss");//
               string strSeverName = MySecurity.Encrypt(tns.Connection.DataSource.ToString(), true);
               string strClientIP = MySecurity.Encrypt(Dns.GetHostAddresses(tns.Connection.WorkstationId)[0].ToString(), true); // Dns.GetHostAddresses(cn.WorkstationId)[0].ToString();// phai ma hoa 
               string strSQL = "";
               strtableName = MySecurity.Encrypt(strtableName, true);
               // strIDRow =  MySecurity.Encrypt(strIDRow, true);// truong nay khong Can ma hoa de con kiem tra
               // neu khong ton tai trong sys_RecorInfo thi thuc thi cap lenh Update
               //A:TableName, B: IDRow,
               // C:IDNguoiDungI, D: TenNguoiDungI, E:ClientTimeI, F:ServerTimeI
               //G:IDNguoiDungU, H:TenNguoiDungU, I: ClientTimeU, J: ServerTimeU, 
               // K: IDNguoiDungD, L:TenNguoiDungD, M:ClientTimeD, N:SevertTimeD,
               //O: IPclientI, P: IPClientU, Q: IPClientD,
               //R:SeverName(IPCua Sever)
               if (!Exits(tns, strtableName, strIDRow))
               {
                   if (Transactypes == TransacType.Unpdate)
                   {
                       strSQL = "Insert ADM_RecordInfo(A, B, G, H,I, J, P,R ) values ( '";
                       strSQL = strSQL + strtableName + "','" + strIDRow + "','" + _strIDNguoiDung + "','" + _strTenNguoiDung + "','" + _strClientTime + "','" + _strServertTime + "','" + strClientIP + "','" + strSeverName + "')";
                   }
                   if (Transactypes == TransacType.Insert)
                   {
                       strSQL = "Insert ADM_RecordInfo(A,B, C,D,E, F,O,R) values ( '";
                       strSQL = strSQL + strtableName + "','" + strIDRow + "','" + _strIDNguoiDung + "','" + _strTenNguoiDung + "','" + _strClientTime + "','" + _strServertTime + "','" + strClientIP + "','" + strSeverName + "')";

                   }
                   if (Transactypes == TransacType.Delete)
                   {
                       strSQL = "Insert ADM_RecordInfo(A, B, K, L,M, N,Q,R ) values ( '";
                       strSQL = strSQL + strtableName + "','" + strIDRow + "','" + _strIDNguoiDung + "','" + _strTenNguoiDung + "','" + _strClientTime + "','" + _strServertTime + "','" + strClientIP + "','" + strSeverName + "')";
                   }
               }
               // neu da co roi
               else
               {
                   if (Transactypes == TransacType.Delete)
                   {
                       strSQL = "Update ADM_RecordInfo set ";
                       strSQL = strSQL + "K = '" + _strIDNguoiDung + "',   ";
                       strSQL = strSQL + "L = '" + _strTenNguoiDung + "', ";
                       strSQL = strSQL + "M = '" + _strClientTime + "', ";
                       strSQL = strSQL + "N = '" + _strServertTime + "',";
                       strSQL = strSQL + "Q = '" + strClientIP + "',";
                       strSQL = strSQL + "R = '" + strSeverName + "'";
                       strSQL = strSQL + " Where Upper(A)= '" + strtableName.ToUpper() + "' and Upper(B) = '" + strIDRow.ToUpper() + "'";
                   }
                   if (Transactypes == TransacType.Insert)
                   {
                       strSQL = "Update ADM_RecordInfo set ";
                       strSQL = strSQL + "C = '" + _strIDNguoiDung + "', ";
                       strSQL = strSQL + "D = '" + _strTenNguoiDung + "', ";
                       strSQL = strSQL + "E = '" + _strClientTime + "', ";
                       strSQL = strSQL + "F = '" + _strServertTime + "',";
                       strSQL = strSQL + "O = '" + strClientIP + "',";
                       strSQL = strSQL + "R = '" + strSeverName + "'";
                       strSQL = strSQL + " Where Upper(A)= '" + strtableName.ToUpper() + "' and Upper(B) = '" + strIDRow.ToUpper() + "'";
                   }
                   if (Transactypes == TransacType.Unpdate)
                   {
                       strSQL = "Update ADM_RecordInfo set ";
                       strSQL = strSQL + "G = '" + _strIDNguoiDung + "', ";
                       strSQL = strSQL + "H = '" + _strTenNguoiDung + "', ";
                       strSQL = strSQL + "I = '" + _strClientTime + "', ";
                       strSQL = strSQL + "J = '" + _strServertTime + "',";
                       strSQL = strSQL + "P = '" + strClientIP + "',";
                       strSQL = strSQL + "R = '" + strSeverName + "'";
                       strSQL = strSQL + " Where Upper(A)= '" + strtableName.ToUpper() + "' and Upper(B) = '" + strIDRow.ToUpper() + "'";
                   }
               }
               using (SqlCommand cm = tns.Connection.CreateCommand())
               {
                   cm.Transaction = tns;
                   cm.CommandType = CommandType.Text;
                   cm.CommandText = strSQL;
                   cm.ExecuteNonQuery();

               }
           }
       }
       private static bool Exits(SqlTransaction tns, string strTenBang, string strIDRow)
       {
           Boolean _exists = false;
           using (SqlCommand cm = tns.Connection.CreateCommand())
           {
               cm.Transaction = tns;
               cm.CommandType = CommandType.Text;
               cm.CommandText = "Select Count(*) from ADM_RecordInfo where Upper(A)='" + strTenBang.ToUpper() + "' and Upper(B) = '" + strIDRow.ToUpper() + "'";
               int count = (int)cm.ExecuteScalar();
               _exists = (count > 0);
               return _exists;
           }
       }
    }
}
