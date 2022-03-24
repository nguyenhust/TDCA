//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    ADM_AdminTracker_Coll
// ObjectType:  ADM_AdminTracker_Coll
// CSLAType:    EditableRootCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{

    /// <summary>
    /// ADM_AdminTracker_Coll (editable root list).<br/>
    /// This is a generated base class of <see cref="ADM_AdminTracker_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="ADM_AdminTracker_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class ADM_AdminTracker_Coll : BusinessBindingListBase<ADM_AdminTracker_Coll, ADM_AdminTracker_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="ADM_AdminTracker_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The ID of the item to be removed.</param>
        public void Remove(Int64 id)
        {
            foreach (var aDM_AdminTracker_Info in this)
            {
                if (aDM_AdminTracker_Info.ID == id)
                {
                    Remove(aDM_AdminTracker_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="ADM_AdminTracker_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the ADM_AdminTracker_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 id)
        {
            foreach (var aDM_AdminTracker_Info in this)
            {
                if (aDM_AdminTracker_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="ADM_AdminTracker_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the ADM_AdminTracker_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(Int64 id)
        {
            foreach (var aDM_AdminTracker_Info in this.DeletedList)
            {
                if (aDM_AdminTracker_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="ADM_AdminTracker_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="ADM_AdminTracker_Coll"/> collection.</returns>
        public static ADM_AdminTracker_Coll NewADM_AdminTracker_Coll()
        {
            return DataPortal.Create<ADM_AdminTracker_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="ADM_AdminTracker_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="ADM_AdminTracker_Coll"/> collection.</returns>
        public static ADM_AdminTracker_Coll GetADM_AdminTracker_Coll()
        {
            return DataPortal.Fetch<ADM_AdminTracker_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="ADM_AdminTracker_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewADM_AdminTracker_Coll(EventHandler<DataPortalResult<ADM_AdminTracker_Coll>> callback)
        {
            DataPortal.BeginCreate<ADM_AdminTracker_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="ADM_AdminTracker_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetADM_AdminTracker_Coll(EventHandler<DataPortalResult<ADM_AdminTracker_Coll>> callback)
        {
            DataPortal.BeginFetch<ADM_AdminTracker_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ADM_AdminTracker_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private ADM_AdminTracker_Coll()
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
        /// Loads a <see cref="ADM_AdminTracker_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.ADM_AdminTracker_Coll_get", ctx.Connection))
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
        /// Loads all <see cref="ADM_AdminTracker_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(ADM_AdminTracker_Info.GetADM_AdminTracker_Info(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="ADM_AdminTracker_Coll"/> object.
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
