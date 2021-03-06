//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_HoiChuan_BVThamGia_Coll
// ObjectType:  CDT_HoiChuan_BVThamGia_Coll
// CSLAType:    EditableRootCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleChiDaoTuyen.LIB
{

    /// <summary>
    /// CDT_HoiChuan_BVThamGia_Coll (editable root list).<br/>
    /// This is a generated base class of <see cref="CDT_HoiChuan_BVThamGia_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="CDT_HoiChuan_BVThamGia_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class CDT_HoiChuan_BVThamGia_Coll : BusinessBindingListBase<CDT_HoiChuan_BVThamGia_Coll, CDT_HoiChuan_BVThamGia_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="CDT_HoiChuan_BVThamGia_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The Id of the item to be removed.</param>
        public void Remove(int id)
        {
            foreach (var cDT_HoiChuan_BVThamGia_Info in this)
            {
                if (cDT_HoiChuan_BVThamGia_Info.Id == id)
                {
                    Remove(cDT_HoiChuan_BVThamGia_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="CDT_HoiChuan_BVThamGia_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The Id of the item to search for.</param>
        /// <returns><c>true</c> if the CDT_HoiChuan_BVThamGia_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int id)
        {
            foreach (var cDT_HoiChuan_BVThamGia_Info in this)
            {
                if (cDT_HoiChuan_BVThamGia_Info.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="CDT_HoiChuan_BVThamGia_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The Id of the item to search for.</param>
        /// <returns><c>true</c> if the CDT_HoiChuan_BVThamGia_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int id)
        {
            foreach (var cDT_HoiChuan_BVThamGia_Info in this.DeletedList)
            {
                if (cDT_HoiChuan_BVThamGia_Info.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_HoiChuan_BVThamGia_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_HoiChuan_BVThamGia_Coll"/> collection.</returns>
        public static CDT_HoiChuan_BVThamGia_Coll NewCDT_HoiChuan_BVThamGia_Coll()
        {
            return DataPortal.Create<CDT_HoiChuan_BVThamGia_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_HoiChuan_BVThamGia_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="CDT_HoiChuan_BVThamGia_Coll"/> collection.</returns>
        public static CDT_HoiChuan_BVThamGia_Coll GetCDT_HoiChuan_BVThamGia_Coll(int idHC)
        {
            return DataPortal.Fetch<CDT_HoiChuan_BVThamGia_Coll>(idHC);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_HoiChuan_BVThamGia_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_HoiChuan_BVThamGia_Coll(EventHandler<DataPortalResult<CDT_HoiChuan_BVThamGia_Coll>> callback)
        {
            DataPortal.BeginCreate<CDT_HoiChuan_BVThamGia_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_HoiChuan_BVThamGia_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_HoiChuan_BVThamGia_Coll(EventHandler<DataPortalResult<CDT_HoiChuan_BVThamGia_Coll>> callback)
        {
            DataPortal.BeginFetch<CDT_HoiChuan_BVThamGia_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_HoiChuan_BVThamGia_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_HoiChuan_BVThamGia_Coll()
        {
            // Prevent direct creation

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = true;
            AllowEdit = true;
            AllowRemove = true;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="CDT_HoiChuan_BVThamGia_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch(int idHC)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_BVThamGia_Coll_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("idHoiChuan", idHC).DbType = DbType.Int32;
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
        /// Loads all <see cref="CDT_HoiChuan_BVThamGia_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(CDT_HoiChuan_BVThamGia_Info.GetCDT_HoiChuan_BVThamGia_Info(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CDT_HoiChuan_BVThamGia_Coll"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                base.Child_Update();
                ctx.Commit();
            }
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
