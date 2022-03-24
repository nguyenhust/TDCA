//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    MA_TPHO_COLL
// ObjectType:  MA_TPHO_COLL
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
    /// MA_TPHO_COLL (editable root list).<br/>
    /// This is a generated base class of <see cref="MA_TPHO_COLL"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="MA_TPHO_INFO"/> objects.
    /// </remarks>
    [Serializable]
    public partial class MA_TPHO_COLL : BusinessBindingListBase<MA_TPHO_COLL, MA_TPHO_INFO>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="MA_TPHO_INFO"/> item from the collection.
        /// </summary>
        public void Remove()
        {
            foreach (var mA_TPHO_INFO in this)
            {
            
                    Remove(mA_TPHO_INFO);
                    break;
                
            }
        }

        /// <summary>
        /// Determines whether a <see cref="MA_TPHO_INFO"/> item is in the collection.
        /// </summary>
        /// <returns><c>true</c> if the MA_TPHO_INFO is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains()
        {
            foreach (var mA_TPHO_INFO in this)
            {
              
                    return true;
                
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="MA_TPHO_INFO"/> item is in the collection's DeletedList.
        /// </summary>
        /// <returns><c>true</c> if the MA_TPHO_INFO is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted()
        {
            foreach (var mA_TPHO_INFO in this.DeletedList)
            {
               
                    return true;
                
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="MA_TPHO_COLL"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="MA_TPHO_COLL"/> collection.</returns>
        public static MA_TPHO_COLL NewMA_TPHO_COLL()
        {
            return DataPortal.Create<MA_TPHO_COLL>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="MA_TPHO_COLL"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="MA_TPHO_COLL"/> collection.</returns>
        public static MA_TPHO_COLL GetMA_TPHO_COLL()
        {
            return DataPortal.Fetch<MA_TPHO_COLL>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="MA_TPHO_COLL"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewMA_TPHO_COLL(EventHandler<DataPortalResult<MA_TPHO_COLL>> callback)
        {
            DataPortal.BeginCreate<MA_TPHO_COLL>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="MA_TPHO_COLL"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetMA_TPHO_COLL(EventHandler<DataPortalResult<MA_TPHO_COLL>> callback)
        {
            DataPortal.BeginFetch<MA_TPHO_COLL>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MA_TPHO_COLL"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private MA_TPHO_COLL()
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
        /// Loads a <see cref="MA_TPHO_COLL"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.MA_TPHO_COLL_get", ctx.Connection))
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
        /// Loads all <see cref="MA_TPHO_COLL"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(MA_TPHO_INFO.GetMA_TPHO_INFO(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="MA_TPHO_COLL"/> object.
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