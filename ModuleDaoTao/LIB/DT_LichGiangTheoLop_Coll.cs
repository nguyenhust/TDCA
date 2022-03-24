using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{
    public partial class DT_LichGiangTheoLop_Coll : ReadOnlyBindingListBase<DT_LichGiangTheoLop_Coll,DT_LichGiangTheoLop_Info>
    {

        
        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="PhieuNhap_Info"/> item is in the collection.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap of the item to search for.</param>
        /// <returns><c>true</c> if the PhieuNhap_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 iDLichGiang)
        {
            foreach (var dt_lichgiangtheolop_Info in this)
            {
                if (dt_lichgiangtheolop_Info.IDLichGiang == iDLichGiang)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="PhieuNhap_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="PhieuNhap_Coll"/> collection.</returns>
        public static DT_LichGiangTheoLop_Coll GetDT_LichGiangTheoLop_Coll()
        {
            return DataPortal.Fetch<DT_LichGiangTheoLop_Coll>();
        }
        public static DT_LichGiangTheoLop_Coll GetDT_LichGiangTheoLop_Coll_Type(Int16 type)
        {
            return DataPortal.Fetch<DT_LichGiangTheoLop_Coll>(type);
        }
        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="PhieuNhap_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDT_LichGiangTheoLop_Coll(EventHandler<DataPortalResult<DT_LichGiangTheoLop_Coll>> callback)
        {
            DataPortal.BeginFetch<DT_LichGiangTheoLop_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PhieuNhap_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_LichGiangTheoLop_Coll()
        {
            // Prevent direct creation

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = false;
            AllowEdit = false;
            AllowRemove = false;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="DT_LichGiangTheoLop_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_Coll_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var args = new DataPortalHookArgs(cmd);
                    OnFetchPre(args);
                    LoadCollection(cmd);
                    OnFetchPost(args);
                }
            }
        }
        protected void DataPortal_Fetch(Int16 type)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_Coll_gets_Type", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Type", type);
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
        /// Loads all <see cref="PhieuNhap_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(DT_LichGiangTheoLop_Info.GetDT_LichGiangTheoLop_Info(dr));
            }
            RaiseListChangedEvents = rlce;
            IsReadOnly = true;
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
