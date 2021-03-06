//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    NHAN_VIEN_COLL
// ObjectType:  NHAN_VIEN_COLL
// CSLAType:    ReadOnlyCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace oldSoft
{

    /// <summary>
    /// NHAN_VIEN_COLL (read only list).<br/>
    /// This is a generated base class of <see cref="NHAN_VIEN_COLL"/> business object.
    /// This class is a root collection.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="NHAN_VIEN_INFO"/> objects.
    /// </remarks>
    [Serializable]
    public partial class NHAN_VIEN_COLL : ReadOnlyBindingListBase<NHAN_VIEN_COLL, NHAN_VIEN_INFO>
    {

        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="NHAN_VIEN_INFO"/> item is in the collection.
        /// </summary>
        /// <param name="nHAN_VIEN_ID">The NHAN_VIEN_ID of the item to search for.</param>
        /// <returns><c>true</c> if the NHAN_VIEN_INFO is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int nHAN_VIEN_ID)
        {
            foreach (var nHAN_VIEN_INFO in this)
            {
                if (nHAN_VIEN_INFO.NHAN_VIEN_ID == nHAN_VIEN_ID)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="NHAN_VIEN_COLL"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="NHAN_VIEN_COLL"/> collection.</returns>
        public static NHAN_VIEN_COLL GetNHAN_VIEN_COLL()
        {
            return DataPortal.Fetch<NHAN_VIEN_COLL>();
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="NHAN_VIEN_COLL"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetNHAN_VIEN_COLL(EventHandler<DataPortalResult<NHAN_VIEN_COLL>> callback)
        {
            DataPortal.BeginFetch<NHAN_VIEN_COLL>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NHAN_VIEN_COLL"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private NHAN_VIEN_COLL()
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
        /// Loads a <see cref="NHAN_VIEN_COLL"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.NHAN_VIEN_COLL_get", ctx.Connection))
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
        /// Loads all <see cref="NHAN_VIEN_COLL"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(NHAN_VIEN_INFO.GetNHAN_VIEN_INFO(dr));
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
