using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{
    [Serializable]
    public partial class DIC_BoPhan : BusinessBase<DIC_BoPhan>
    {
        #region Static Fields

        private static Int64 _lastID;

        #endregion
        #region factorymethor
        public static void Delete_BoPhan(Int32 id)
        {
           
            DataPortal.Delete<DIC_BoPhan>(id);
        }
        public static void Delete_BoPhan(Int32 id, EventHandler<DataPortalResult<DIC_BoPhan>> callback)
        {
            DataPortal.BeginDelete<DIC_BoPhan>(id, callback);
        }
        #endregion

       
        #region Contructor

        private DIC_BoPhan()
        {

        }
        #endregion

        #region DataAccess
        [Csla.RunLocal]
        protected void DataPortal_Delete(Int32 id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                FieldManager.UpdateChildren(this);
                using (var cmd = new SqlCommand("dbo.DIC_BoPhan_Info_Del", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, id);

                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }

                ctx.Commit();
            }
            //LoadProperty(SLChucVuListProperty, DataPortal.CreateChild<DIC_SLChucVuBV_Coll>());
        }
        #endregion

        #region Pseudo
        partial void OnDeletePre(DataPortalHookArgs args);
        partial void OnDeletePost(DataPortalHookArgs args);
        #endregion
    }
}
