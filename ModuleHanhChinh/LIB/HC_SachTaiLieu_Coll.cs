//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_SachTaiLieu_Coll
// ObjectType:  HC_SachTaiLieu_Coll
// CSLAType:    EditableRootCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;
namespace ModuleHanhChinh.LIB
{

    /// <summary>
    /// HC_SachTaiLieu_Coll (editable root list).<br/>
    /// This is a generated base class of <see cref="HC_SachTaiLieu_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="HC_SachTaiLieu_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class HC_SachTaiLieu_Coll : BusinessBindingListBase<HC_SachTaiLieu_Coll, HC_SachTaiLieu_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="HC_SachTaiLieu_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The ID of the item to be removed.</param>
        public void Remove(int id)
        {
            foreach (var hC_SachTaiLieu_Info in this)
            {
                if (hC_SachTaiLieu_Info.ID == id)
                {
                    Remove(hC_SachTaiLieu_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="HC_SachTaiLieu_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the HC_SachTaiLieu_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int id)
        {
            foreach (var hC_SachTaiLieu_Info in this)
            {
                if (hC_SachTaiLieu_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="HC_SachTaiLieu_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the HC_SachTaiLieu_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int id)
        {
            foreach (var hC_SachTaiLieu_Info in this.DeletedList)
            {
                if (hC_SachTaiLieu_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_SachTaiLieu_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_SachTaiLieu_Coll"/> collection.</returns>
        public static HC_SachTaiLieu_Coll NewHC_SachTaiLieu_Coll()
        {
            return DataPortal.Create<HC_SachTaiLieu_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_SachTaiLieu_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="HC_SachTaiLieu_Coll"/> collection.</returns>
        public static HC_SachTaiLieu_Coll GetHC_SachTaiLieu_Coll()
        {
            return DataPortal.Fetch<HC_SachTaiLieu_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_SachTaiLieu_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHC_SachTaiLieu_Coll(EventHandler<DataPortalResult<HC_SachTaiLieu_Coll>> callback)
        {
            DataPortal.BeginCreate<HC_SachTaiLieu_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="HC_SachTaiLieu_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHC_SachTaiLieu_Coll(EventHandler<DataPortalResult<HC_SachTaiLieu_Coll>> callback)
        {
            DataPortal.BeginFetch<HC_SachTaiLieu_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HC_SachTaiLieu_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_SachTaiLieu_Coll()
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
        /// Loads a <see cref="HC_SachTaiLieu_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_SachTaiLieu_Coll_get", ctx.Connection))
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
        /// Loads all <see cref="HC_SachTaiLieu_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(HC_SachTaiLieu_Info.GetHC_SachTaiLieu_Info(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_SachTaiLieu_Coll"/> object.
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