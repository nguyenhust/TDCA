using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable]
    public partial class HoanTamThu_Coll : ReadOnlyBindingListBase<HoanTamThu_Coll, HoanTamThuInfocs>
    {
        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="IP_HoanKyQuy_Info"/> item is in the collection.
        /// </summary>
        /// <param name="iDPhieuHoan">The IDPhieuHoan of the item to search for.</param>
        /// <returns><c>true</c> if the IP_HoanKyQuy_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 iDPhieuHoan)
        {
            foreach (var hoanTamThuInfocs in this)
            {
                if (hoanTamThuInfocs.IDPhieuHoan == iDPhieuHoan)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="IP_HoanKyQuy_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="IP_HoanKyQuy_Coll"/> collection.</returns>
        public static HoanTamThu_Coll GetHoanTamThu_Coll(Int64 iDHocVien)
        {
            return DataPortal.Fetch<HoanTamThu_Coll>(iDHocVien);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="IP_HoanKyQuy_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHoanTamThu_Coll(EventHandler<DataPortalResult<HoanTamThu_Coll>> callback)
        {
            DataPortal.BeginFetch<HoanTamThu_Coll>(callback);
        }
        //public static HoanTamThu_Coll GetIHoanTamThu_ChiTiet_Coll(Int64 iDHocVien)
        //{
        //    return DataPortal.Fetch<HoanTamThu_Coll>(iDHocVien);
        //}
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_HoanKyQuy_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HoanTamThu_Coll()
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
        /// Loads a <see cref="IP_HoanKyQuy_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch(Int64 iDHocVien)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HoanTamThu_gets", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDHocVien", iDHocVien);
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
        /// Loads all <see cref="IP_HoanKyQuy_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(HoanTamThuInfocs.GetHoanTamThuInfocs(dr));
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
