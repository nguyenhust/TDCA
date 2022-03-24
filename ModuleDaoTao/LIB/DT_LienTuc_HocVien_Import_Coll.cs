using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{
    [Serializable]
    public partial class DT_LienTuc_HocVien_Import_Coll : BusinessBindingListBase<DT_LienTuc_HocVien_Import_Coll, DT_LienTuc_HocVien_Import_Info>
    {
        #region Factory Methods


        public static DT_LienTuc_HocVien_Import_Coll NewDT_LienTuc_HocVien_Import_Coll()
        {
            return DataPortal.Create<DT_LienTuc_HocVien_Import_Coll>();
        }

        public static void NewDT_LienTuc_HocVien_Import_Coll(EventHandler<DataPortalResult<DT_LienTuc_HocVien_Import_Coll>> callback)
        {
            DataPortal.BeginCreate<DT_LienTuc_HocVien_Import_Coll>(callback);
        }


        public static DT_LienTuc_HocVien_Import_Coll GetDT_LienTuc_HocVien_Import_Coll()
        {
            return DataPortal.Fetch<DT_LienTuc_HocVien_Import_Coll>();
        }

        public static void GetDT_LienTuc_HocVien_Import_Coll(EventHandler<DataPortalResult<DT_LienTuc_HocVien_Import_Coll>> callback)
        {
            DataPortal.BeginFetch<DT_LienTuc_HocVien_Import_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PhieuXuatBnCTColl"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public DT_LienTuc_HocVien_Import_Coll()
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = true;
            AllowEdit = true;
            AllowRemove = true;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Data Access

        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_LienTuc_HocVien_Import_Coll_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var args = new DataPortalHookArgs(cmd);
                    OnFetchPre(args);
                    LoadCollection(cmd);
                    OnFetchPost(args);
                }
            }
        }

        private void LoadCollection(SqlCommand cmd)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                Fetch(dr);
            }
        }

        /// <summary>
        /// Loads all <see cref="PhieuXuatBnCTColl"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(DT_LienTuc_HocVien_Import_Info.GetDT_LienTuc_HocVien_Import_Info(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Pseudo Events

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        #endregion
    }
}
