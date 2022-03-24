//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CTAC_TUYEN_CTIET_COLL
// ObjectType:  CTAC_TUYEN_CTIET_COLL
// CSLAType:    EditableRootCollection

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
    /// CTAC_TUYEN_CTIET_COLL (editable root list).<br/>
    /// This is a generated base class of <see cref="CTAC_TUYEN_CTIET_COLL"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="CTAC_TUYEN_CTIET_INFO"/> objects.
    /// </remarks>
    [Serializable]
    public partial class CTAC_TUYEN_CTIET_COLL : BusinessBindingListBase<CTAC_TUYEN_CTIET_COLL, CTAC_TUYEN_CTIET_INFO>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="CTAC_TUYEN_CTIET_INFO"/> item from the collection.
        /// </summary>
        public void Remove()
        {
            foreach (var cTAC_TUYEN_CTIET_INFO in this)
            {
             
                    Remove(cTAC_TUYEN_CTIET_INFO);
                    break;
                
            }
        }

        /// <summary>
        /// Determines whether a <see cref="CTAC_TUYEN_CTIET_INFO"/> item is in the collection.
        /// </summary>
        /// <returns><c>true</c> if the CTAC_TUYEN_CTIET_INFO is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains()
        {
            foreach (var cTAC_TUYEN_CTIET_INFO in this)
            {
             
                    return true;
             
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="CTAC_TUYEN_CTIET_INFO"/> item is in the collection's DeletedList.
        /// </summary>
        /// <returns><c>true</c> if the CTAC_TUYEN_CTIET_INFO is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted()
        {
            foreach (var cTAC_TUYEN_CTIET_INFO in this.DeletedList)
            {
           
                    return true;
                
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CTAC_TUYEN_CTIET_COLL"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="CTAC_TUYEN_CTIET_COLL"/> collection.</returns>
        public static CTAC_TUYEN_CTIET_COLL NewCTAC_TUYEN_CTIET_COLL()
        {
            return DataPortal.Create<CTAC_TUYEN_CTIET_COLL>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CTAC_TUYEN_CTIET_COLL"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="CTAC_TUYEN_CTIET_COLL"/> collection.</returns>
        public static CTAC_TUYEN_CTIET_COLL GetCTAC_TUYEN_CTIET_COLL()
        {
            return DataPortal.Fetch<CTAC_TUYEN_CTIET_COLL>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CTAC_TUYEN_CTIET_COLL"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCTAC_TUYEN_CTIET_COLL(EventHandler<DataPortalResult<CTAC_TUYEN_CTIET_COLL>> callback)
        {
            DataPortal.BeginCreate<CTAC_TUYEN_CTIET_COLL>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CTAC_TUYEN_CTIET_COLL"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCTAC_TUYEN_CTIET_COLL(EventHandler<DataPortalResult<CTAC_TUYEN_CTIET_COLL>> callback)
        {
            DataPortal.BeginFetch<CTAC_TUYEN_CTIET_COLL>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CTAC_TUYEN_CTIET_COLL"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CTAC_TUYEN_CTIET_COLL()
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
        /// Loads a <see cref="CTAC_TUYEN_CTIET_COLL"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.CTAC_TUYEN_CTIET_COLL_get", ctx.Connection))
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
        /// Loads all <see cref="CTAC_TUYEN_CTIET_COLL"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(CTAC_TUYEN_CTIET_INFO.GetCTAC_TUYEN_CTIET_INFO(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CTAC_TUYEN_CTIET_COLL"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
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
