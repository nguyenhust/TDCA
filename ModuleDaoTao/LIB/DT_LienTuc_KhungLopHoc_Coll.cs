//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DT_LienTuc_KhungLopHoc_Coll
// ObjectType:  DT_LienTuc_KhungLopHoc_Coll
// CSLAType:    EditableRootCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    /// <summary>
    /// DT_LienTuc_KhungLopHoc_Coll (editable root list).<br/>
    /// This is a generated base class of <see cref="DT_LienTuc_KhungLopHoc_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="DT_LienTuc_KhungLopHoc_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class DT_LienTuc_KhungLopHoc_Coll : BusinessBindingListBase<DT_LienTuc_KhungLopHoc_Coll, DT_LienTuc_KhungLopHoc_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="DT_LienTuc_KhungLopHoc_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The Id of the item to be removed.</param>
        public void Remove(int id)
        {
            foreach (var dT_LienTuc_KhungLopHoc_Info in this)
            {
                if (dT_LienTuc_KhungLopHoc_Info.Id == id)
                {
                    Remove(dT_LienTuc_KhungLopHoc_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="DT_LienTuc_KhungLopHoc_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The Id of the item to search for.</param>
        /// <returns><c>true</c> if the DT_LienTuc_KhungLopHoc_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int id)
        {
            foreach (var dT_LienTuc_KhungLopHoc_Info in this)
            {
                if (dT_LienTuc_KhungLopHoc_Info.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="DT_LienTuc_KhungLopHoc_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The Id of the item to search for.</param>
        /// <returns><c>true</c> if the DT_LienTuc_KhungLopHoc_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int id)
        {
            foreach (var dT_LienTuc_KhungLopHoc_Info in this.DeletedList)
            {
                if (dT_LienTuc_KhungLopHoc_Info.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DT_LienTuc_KhungLopHoc_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="DT_LienTuc_KhungLopHoc_Coll"/> collection.</returns>
        public static DT_LienTuc_KhungLopHoc_Coll NewDT_LienTuc_KhungLopHoc_Coll()
        {
            return DataPortal.Create<DT_LienTuc_KhungLopHoc_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DT_LienTuc_KhungLopHoc_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="DT_LienTuc_KhungLopHoc_Coll"/> collection.</returns>
        public static DT_LienTuc_KhungLopHoc_Coll GetDT_LienTuc_KhungLopHoc_Coll()
        {
            return DataPortal.Fetch<DT_LienTuc_KhungLopHoc_Coll>(new BusinessFunction(BusinessFunctionMode.GetAllData));
        }

        public static DT_LienTuc_KhungLopHoc_Coll GetDT_LienTuc_KhungLopHoc_Coll(BusinessFunction function)
        {
            return DataPortal.Fetch<DT_LienTuc_KhungLopHoc_Coll>(function);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DT_LienTuc_KhungLopHoc_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDT_LienTuc_KhungLopHoc_Coll(EventHandler<DataPortalResult<DT_LienTuc_KhungLopHoc_Coll>> callback)
        {
            DataPortal.BeginCreate<DT_LienTuc_KhungLopHoc_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DT_LienTuc_KhungLopHoc_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDT_LienTuc_KhungLopHoc_Coll(EventHandler<DataPortalResult<DT_LienTuc_KhungLopHoc_Coll>> callback)
        {
            DataPortal.BeginFetch<DT_LienTuc_KhungLopHoc_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DT_LienTuc_KhungLopHoc_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_LienTuc_KhungLopHoc_Coll()
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
        /// Loads a <see cref="DT_LienTuc_KhungLopHoc_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch(BusinessFunction function)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                string storeName = string.Empty;
                if (function.Mode == BusinessFunctionMode.GetAllData)
                    storeName = "dbo.DT_LienTuc_KhungLopHoc_Coll_get";
                else if (function.Mode == BusinessFunctionMode.GetDataForDropDownWithCondition)
                    storeName = "dbo.DT_LienTuc_KhungLopHoc_Coll_getByIdChuyenNganh";

                using (var cmd = new SqlCommand(storeName, ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (function.Mode == BusinessFunctionMode.GetDataForDropDownWithCondition) {
                        SqlParameter parameter = new SqlParameter("@idChuyenKhoa", SqlDbType.Int);
                        parameter.Value = function.ItemID;
                        cmd.Parameters.Add(parameter);
                    }

                    var args = new DataPortalHookArgs(cmd);
                    OnFetchPre(args);
                    LoadCollection(cmd, function);
                    OnFetchPost(args);
                }
            }
        }

        private void LoadCollection(SqlCommand cmd, BusinessFunction function)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                Fetch(dr, function);
            }
        }

        /// <summary>
        /// Loads all <see cref="DT_LienTuc_KhungLopHoc_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr, BusinessFunction function)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(DT_LienTuc_KhungLopHoc_Info.GetDT_LienTuc_KhungLopHoc_Info(dr, function));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DT_LienTuc_KhungLopHoc_Coll"/> object.
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
