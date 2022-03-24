//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DIC_BoPhan_Coll
// ObjectType:  DIC_BoPhan_Coll
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
    /// DIC_BoPhan_Coll (editable root list).<br/>
    /// This is a generated base class of <see cref="DIC_BoPhan_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="DIC_BoPhan_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class DIC_BoPhan_Coll : BusinessBindingListBase<DIC_BoPhan_Coll, DIC_BoPhan_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="DIC_BoPhan_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The ID of the item to be removed.</param>
        public void Remove(int id)
        {
            foreach (var dIC_BoPhan_Info in this)
            {
                if (dIC_BoPhan_Info.ID == id)
                {
                    Remove(dIC_BoPhan_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="DIC_BoPhan_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the DIC_BoPhan_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int id)
        {
            foreach (var dIC_BoPhan_Info in this)
            {
                if (dIC_BoPhan_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="DIC_BoPhan_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the DIC_BoPhan_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int id)
        {
            foreach (var dIC_BoPhan_Info in this.DeletedList)
            {
                if (dIC_BoPhan_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

       

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_BoPhan_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_BoPhan_Coll"/> collection.</returns>
        public static DIC_BoPhan_Coll NewDIC_BoPhan_Coll()
        {
            return DataPortal.Create<DIC_BoPhan_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_BoPhan_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="DIC_BoPhan_Coll"/> collection.</returns>
        public static DIC_BoPhan_Coll GetDIC_BoPhan_Coll()
        {
            return DataPortal.Fetch<DIC_BoPhan_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_BoPhan_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDIC_BoPhan_Coll(EventHandler<DataPortalResult<DIC_BoPhan_Coll>> callback)
        {
            DataPortal.BeginCreate<DIC_BoPhan_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DIC_BoPhan_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDIC_BoPhan_Coll(EventHandler<DataPortalResult<DIC_BoPhan_Coll>> callback)
        {
            DataPortal.BeginFetch<DIC_BoPhan_Coll>(callback);
        }
        //public static void Delete_Bophan_Coll(EventHandler<DataPortalResult<DIC_BoPhan_Coll>> callback)
        //{
        //    DataPortal.BeginDelete<DIC_BoPhan_Coll>(callback);
        //}
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_BoPhan_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_BoPhan_Coll()
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
        /// Loads a <see cref="DIC_BoPhan_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_BoPhan_Coll_Get", ctx.Connection))
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
        /// Loads all <see cref="DIC_BoPhan_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(DIC_BoPhan_Info.GetDIC_BoPhan_Info(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DIC_BoPhan_Coll"/> object.
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
