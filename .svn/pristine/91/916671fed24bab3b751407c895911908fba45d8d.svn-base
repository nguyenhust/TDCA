using System.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NETLINK.LIB
{
    public static class Dic_LogInfo
    {       
        /// <summary>
        ///  ghi lai su thay doi du lieu o server
        /// </summary>
        /// <param name="cn"> Chôi ket noi</param>
        /// <param name="strtableName"></param>
        /// <param name="strIDRow"></param>
        /// <param name="Transactypes"></param>
        public static void LogDic(SqlTransaction tns, string strtableName, string strIDRow, TransacType Transactypes)
        {
            DateTime _dteServertTime = GlobalCommon.GetTimeServer();
            using (SqlCommand cm = tns.Connection.CreateCommand())
            {                
                if (Transactypes == TransacType.Unpdate)
                {

                    cm.Parameters.AddWithValue("@Actions", "U");

                }
                if (Transactypes == TransacType.Insert)
                {

                    cm.Parameters.AddWithValue("@Actions", "I");

                }
                if (Transactypes == TransacType.Delete)
                {
                    cm.Parameters.AddWithValue("@Actions", "D");
                }
                cm.Transaction = tns;
                cm.Parameters.AddWithValue("@RowID", strIDRow);
                cm.Parameters.AddWithValue("@TableName", strtableName);
                cm.Parameters.AddWithValue("@ServerDateTime", _dteServertTime);
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "ADM_DIC_LogInfo_Ins";
                cm.ExecuteNonQuery();
            }            
        }
        /// <summary>
        ///  lay ve chuoi de cap nhat ve client
        /// </summary>
        /// <param name="cn"></param>
        /// <param name="strtableName"></param>
        /// <param name="lngIDRow"></param>
        /// <param name="Transactypes"></param>
        /// <returns></returns>
        public static string GetSqlToClient(long lngID, string strIDRow, string strtableName, TransacType Transactypes)
        {
            string _strSql = string.Empty;
            string _strActions = string.Empty;

            DateTime _dteClientTime = DateTime.Now;
            if (Transactypes == TransacType.Unpdate)
            {
                _strActions = "U";
            }
            if (Transactypes == TransacType.Insert)
            {
                _strActions = "I";
            }
            if (Transactypes == TransacType.Delete)
            {
                _strActions = "D";
            }

            _strSql = " Insert ADM_Dic_LogInfo(ID, RowID,TableName,Actions, ClientDateTime) ";
            _strSql = _strSql + " Values('" + lngID.ToString() + "','" + strIDRow + "','" + strtableName + "','";
            _strSql = _strSql + _strActions + "','" + _dteClientTime.ToString("MM/dd/yyyy HH:mm:ss") + "')";
            return _strSql;
        }
        
    }
}
