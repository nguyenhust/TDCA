//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_CongVanDi_Coll
// ObjectType:  HC_CongVanDi_Coll
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
    /// HC_CongVanDi_Coll (editable root list).<br/>
    /// This is a generated base class of <see cref="HC_CongVanDi_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="HC_CongVanDi_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class HC_CongVanDi_Coll : BusinessBindingListBase<HC_CongVanDi_Coll, HC_CongVanDi_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="HC_CongVanDi_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The ID of the item to be removed.</param>
        public void Remove(int id)
        {
            foreach (var hC_CongVanDi_Info in this)
            {
                if (hC_CongVanDi_Info.ID == id)
                {
                    Remove(hC_CongVanDi_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="HC_CongVanDi_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the HC_CongVanDi_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int id)
        {
            foreach (var hC_CongVanDi_Info in this)
            {
                if (hC_CongVanDi_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="HC_CongVanDi_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the HC_CongVanDi_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int id)
        {
            foreach (var hC_CongVanDi_Info in this.DeletedList)
            {
                if (hC_CongVanDi_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_CongVanDi_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_CongVanDi_Coll"/> collection.</returns>
        public static HC_CongVanDi_Coll NewHC_CongVanDi_Coll()
        {
            return DataPortal.Create<HC_CongVanDi_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_CongVanDi_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="HC_CongVanDi_Coll"/> collection.</returns>
        public static HC_CongVanDi_Coll GetHC_CongVanDi_Coll(BusinessFunction function)
        {
            return DataPortal.Fetch<HC_CongVanDi_Coll>(function);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_CongVanDi_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHC_CongVanDi_Coll(EventHandler<DataPortalResult<HC_CongVanDi_Coll>> callback)
        {
            DataPortal.BeginCreate<HC_CongVanDi_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="HC_CongVanDi_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHC_CongVanDi_Coll(EventHandler<DataPortalResult<HC_CongVanDi_Coll>> callback)
        {
            DataPortal.BeginFetch<HC_CongVanDi_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HC_CongVanDi_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_CongVanDi_Coll()
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
        /// Loads a <see cref="HC_CongVanDi_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch(BusinessFunction function)
        {
            string store = "";
            switch (function.Mode)
            {
                case BusinessFunctionMode.GetDataForGridViewWithCondition:
                    store = "dbo.HC_CongVanDi_Coll_getForUserNhan";
                    break;
                default : store = "dbo.HC_CongVanDi_Coll_get";
                    break;
            }
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand(store, ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt64(function.Item)).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd);
                    OnFetchPre(args);
                    LoadCollection(cmd,function);
                    OnFetchPost(args);
                }
            }
        }

        private void LoadCollection(SqlCommand cmd, BusinessFunction function)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                Fetch(dr,function);
            }
        }

        /// <summary>
        /// Loads all <see cref="HC_CongVanDi_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr, BusinessFunction function)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(HC_CongVanDi_Info.GetHC_CongVanDi_Info(dr,function));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_CongVanDi_Coll"/> object.
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
