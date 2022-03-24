//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DT_ChinhQuy_HocVien_Coll
// ObjectType:  DT_ChinhQuy_HocVien_Coll
// CSLAType:    EditableRootCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    /// <summary>
    /// DT_ChinhQuy_HocVien_Coll (editable root list).<br/>
    /// This is a generated base class of <see cref="DT_ChinhQuy_HocVien_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="DT_ChinhQuy_HocVien_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class DT_ChinhQuy_HocVien_Coll : BusinessBindingListBase<DT_ChinhQuy_HocVien_Coll, DT_ChinhQuy_HocVien_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="DT_ChinhQuy_HocVien_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The Id of the item to be removed.</param>
        public void Remove(int id)
        {
            foreach (var dT_ChinhQuy_HocVien_Info in this)
            {
                if (dT_ChinhQuy_HocVien_Info.Id == id)
                {
                    Remove(dT_ChinhQuy_HocVien_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="DT_ChinhQuy_HocVien_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The Id of the item to search for.</param>
        /// <returns><c>true</c> if the DT_ChinhQuy_HocVien_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int id)
        {
            foreach (var dT_ChinhQuy_HocVien_Info in this)
            {
                if (dT_ChinhQuy_HocVien_Info.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="DT_ChinhQuy_HocVien_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The Id of the item to search for.</param>
        /// <returns><c>true</c> if the DT_ChinhQuy_HocVien_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int id)
        {
            foreach (var dT_ChinhQuy_HocVien_Info in this.DeletedList)
            {
                if (dT_ChinhQuy_HocVien_Info.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DT_ChinhQuy_HocVien_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="DT_ChinhQuy_HocVien_Coll"/> collection.</returns>
        public static DT_ChinhQuy_HocVien_Coll NewDT_ChinhQuy_HocVien_Coll()
        {
            return DataPortal.Create<DT_ChinhQuy_HocVien_Coll>(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition));
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DT_ChinhQuy_HocVien_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="DT_ChinhQuy_HocVien_Coll"/> collection.</returns>
        public static DT_ChinhQuy_HocVien_Coll GetDT_ChinhQuy_HocVien_Coll(BusinessFunction function)
        {
            return DataPortal.Fetch<DT_ChinhQuy_HocVien_Coll>(function);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DT_ChinhQuy_HocVien_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDT_ChinhQuy_HocVien_Coll(EventHandler<DataPortalResult<DT_ChinhQuy_HocVien_Coll>> callback)
        {
            DataPortal.BeginCreate<DT_ChinhQuy_HocVien_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DT_ChinhQuy_HocVien_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDT_ChinhQuy_HocVien_Coll(EventHandler<DataPortalResult<DT_ChinhQuy_HocVien_Coll>> callback)
        {
            DataPortal.BeginFetch<DT_ChinhQuy_HocVien_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DT_ChinhQuy_HocVien_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_ChinhQuy_HocVien_Coll()
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
        /// Loads a <see cref="DT_ChinhQuy_HocVien_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch(BusinessFunction function)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                string store = string.Empty;
                switch (function.Mode)
                {
                    case BusinessFunctionMode.GetAllDataWithCondition:
                        store = "dbo.DT_ChinhQuy_HocVien_Coll_getByIDLopHoc";
                        break;
                    case BusinessFunctionMode.GetAllDataWithCondition2:
                        store = "dbo.DT_ChinhQuy_HocVien_Coll_getByIDLopHocNull";
                        break;
                    case BusinessFunctionMode.GetDataForGridViewWithCondition:
                        store = "dbo.DT_ChinhQuy_HocVien_Coll_getByCapDoHoc";
                        break;
                    default:
                        store = "dbo.DT_ChinhQuy_HocVien_Coll_get";
                        break;
                }
                
                using (var cmd = new SqlCommand(store, ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (function.Mode == BusinessFunctionMode.GetAllDataWithCondition)
                    {
                        SqlParameter param = new SqlParameter("@idLopHoc", SqlDbType.Int);
                        param.Value = Convert.ToInt32(function.Item);
                        cmd.Parameters.Add(param);
                    }
                    else if (function.Mode == BusinessFunctionMode.GetDataForGridViewWithCondition)
                    {
                        SqlParameter param = new SqlParameter("@capdohoc", SqlDbType.NVarChar);
                        param.Value = function.Item.ToString();
                        cmd.Parameters.Add(param);
                    }
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
        /// Loads all <see cref="DT_ChinhQuy_HocVien_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(DT_ChinhQuy_HocVien_Info.GetDT_ChinhQuy_HocVien_Info(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DT_ChinhQuy_HocVien_Coll"/> object.
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