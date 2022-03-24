//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    TT_PhieuDangKyThietKe_Coll
// ObjectType:  TT_PhieuDangKyThietKe_Coll
// CSLAType:    ReadOnlyCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;

namespace TruyenThong
{

    /// <summary>
    /// TT_PhieuDangKyThietKe_Coll (read only list).<br/>
    /// This is a generated base class of <see cref="TT_PhieuDangKyThietKe_Coll"/> business object.
    /// This class is a root collection.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="TT_PhieuDangKyThietKe_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class TT_PhieuDangKyThietKe_Coll : ReadOnlyBindingListBase<TT_PhieuDangKyThietKe_Coll, TT_PhieuDangKyThietKe_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="TT_PhieuDangKyThietKe_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the TT_PhieuDangKyThietKe_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 id)
        {
            foreach (var tT_PhieuDangKyThietKe_Info in this)
            {
                if (tT_PhieuDangKyThietKe_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="TT_PhieuDangKyThietKe_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="TT_PhieuDangKyThietKe_Coll"/> collection.</returns>
        public static TT_PhieuDangKyThietKe_Coll GetTT_PhieuDangKyThietKe_Coll()
        {
            return DataPortal.Fetch<TT_PhieuDangKyThietKe_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="TT_PhieuDangKyThietKe_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetTT_PhieuDangKyThietKe_Coll(EventHandler<DataPortalResult<TT_PhieuDangKyThietKe_Coll>> callback)
        {
            DataPortal.BeginFetch<TT_PhieuDangKyThietKe_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TT_PhieuDangKyThietKe_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TT_PhieuDangKyThietKe_Coll()
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
        /// Loads a <see cref="TT_PhieuDangKyThietKe_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_PhieuDangKyThietKe_Coll_Get", ctx.Connection))
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
        /// Loads all <see cref="TT_PhieuDangKyThietKe_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(TT_PhieuDangKyThietKe_Info.GetTT_PhieuDangKyThietKe_Info(dr));
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
