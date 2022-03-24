using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Serialization;
using Csla.Security;
using NETLINK.LIB;
using Csla.Data;
using System.Data.SqlClient;
using System.Data;

namespace Authoration.LIB
{
    [Serializable]
    public class PTIdentity : CslaIdentityBase<PTIdentity>
    {
        private bool _isAuthenticated;
        private  string _tenDangnhap = string.Empty;
        private static string _FullName = string.Empty;
        private static long _IDNguoiDung;
        private static string _VaiTro = string.Empty;
        private List<string> _quyen = new List<string>();
        private List<string> _chucnang = new List<string>();

        public string AuthenticationType
        {
            get { return "Csla"; }
        }
        public bool IsAuthenticated
        {
            get { return _isAuthenticated; }
        }

        public static string FullName
        {
            get { return _FullName; }
        }

        public static string VaiTro
        {
            get { return _VaiTro; }
        }

        public  string Name
        {
            get { return _tenDangnhap; }
        }

        public static long IDNguoiDung
        {
            get { return _IDNguoiDung; }
        }

        internal bool IsInRole(string quyen)
        {
            return _quyen.Contains(quyen);
        }

        public static void GetPTIdentity(string username, string password, EventHandler<DataPortalResult<PTIdentity>> callback)
        {
            DataPortal.BeginFetch<PTIdentity>(new UsernameCriteria(username, password), callback);
        }

#if !SILVERLIGHT
        public static PTIdentity GetPTIdentity(string username, string password)
        {
            return DataPortal.Fetch<PTIdentity>(new UsernameCriteria(username, password));
        }

        private void DataPortal_Fetch(UsernameCriteria criteria)
        {
            try
            {
                using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
                {
                    using (var cmd = new SqlCommand("dbo.ADM_LogOn", ctx.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenDangNhap", criteria.Username);
                        cmd.Parameters.AddWithValue("@MatKhau", criteria.Password);
                        using (SafeDataReader dr = new SafeDataReader(cmd.ExecuteReader()))
                        {
                            base.Name = criteria.Username;
                            base.IsAuthenticated = true;
                            base.AuthenticationType = "Csla";                            
                            while (dr.Read())
                                _quyen.Add(dr.GetString(0));
                            #region set var
                            dr.NextResult();
                            while (dr.Read())
                            {
                                _FullName = dr.GetString(0);
                                _VaiTro = dr.GetString(1);
                                _IDNguoiDung = dr.GetInt64(2);
                             //   _tenDangnhap = dr.GetString(3);
                            }
                            #endregion
                            if (_quyen.Count > 0)
                            {
                                base.Roles = new Csla.Core.MobileList<string>(_quyen);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }
    }
#endif
}

