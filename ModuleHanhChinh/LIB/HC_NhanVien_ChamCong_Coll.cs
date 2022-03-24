//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_NhanVien_ChamCong_Coll
// ObjectType:  HC_NhanVien_ChamCong_Coll
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
    /// HC_NhanVien_ChamCong_Coll (editable root list).<br/>
    /// This is a generated base class of <see cref="HC_NhanVien_ChamCong_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="HC_NhanVien_ChamCong_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class HC_NhanVien_ChamCong_Coll : BusinessBindingListBase<HC_NhanVien_ChamCong_Coll, HC_NhanVien_ChamCong_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="HC_NhanVien_ChamCong_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The Id of the item to be removed.</param>
        public void Remove(int id)
        {
            foreach (var hC_NhanVien_ChamCong_Info in this)
            {
                if (hC_NhanVien_ChamCong_Info.Id == id)
                {
                    Remove(hC_NhanVien_ChamCong_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="HC_NhanVien_ChamCong_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The Id of the item to search for.</param>
        /// <returns><c>true</c> if the HC_NhanVien_ChamCong_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int id)
        {
            foreach (var hC_NhanVien_ChamCong_Info in this)
            {
                if (hC_NhanVien_ChamCong_Info.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="HC_NhanVien_ChamCong_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The Id of the item to search for.</param>
        /// <returns><c>true</c> if the HC_NhanVien_ChamCong_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int id)
        {
            foreach (var hC_NhanVien_ChamCong_Info in this.DeletedList)
            {
                if (hC_NhanVien_ChamCong_Info.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_NhanVien_ChamCong_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_NhanVien_ChamCong_Coll"/> collection.</returns>
        public static HC_NhanVien_ChamCong_Coll NewHC_NhanVien_ChamCong_Coll()
        {
            return DataPortal.Create<HC_NhanVien_ChamCong_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_NhanVien_ChamCong_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="HC_NhanVien_ChamCong_Coll"/> collection.</returns>
        public static HC_NhanVien_ChamCong_Coll GetHC_NhanVien_ChamCong_Coll()
        {
            return DataPortal.Fetch<HC_NhanVien_ChamCong_Coll>(new BusinessFunction(BusinessFunctionMode.GetAllData));
        }

        public static HC_NhanVien_ChamCong_Coll GetHC_NhanVien_ChamCong_Coll(BusinessFunction function)
        {
            return DataPortal.Fetch<HC_NhanVien_ChamCong_Coll>(function);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_NhanVien_ChamCong_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHC_NhanVien_ChamCong_Coll(EventHandler<DataPortalResult<HC_NhanVien_ChamCong_Coll>> callback)
        {
            DataPortal.BeginCreate<HC_NhanVien_ChamCong_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="HC_NhanVien_ChamCong_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHC_NhanVien_ChamCong_Coll(EventHandler<DataPortalResult<HC_NhanVien_ChamCong_Coll>> callback)
        {
            DataPortal.BeginFetch<HC_NhanVien_ChamCong_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HC_NhanVien_ChamCong_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_NhanVien_ChamCong_Coll()
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
        /// Loads a <see cref="HC_NhanVien_ChamCong_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch(BusinessFunction function)
        {
            string storedName = string.Empty;

            if (function.Mode == BusinessFunctionMode.GetAllData)
                storedName = "dbo.HC_NhanVien_ChamCong_Coll_get";
            else if (function.Mode == BusinessFunctionMode.GetDataForGridViewWithCondition) {
                storedName = "dbo.HC_NhanVien_ChamCong_Coll_getByMonthYearMaNhanVien";
            }

            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand(storedName, ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (function.Mode == BusinessFunctionMode.GetDataForGridViewWithCondition) {
                        HC_ChamCongSearchObject obj = (HC_ChamCongSearchObject)function.Item;
                        SqlParameter parameter = new SqlParameter("@month", SqlDbType.Int);
                        parameter.Value = obj.Month;
                        cmd.Parameters.Add(parameter);

                        SqlParameter parameter1 = new SqlParameter("@year", SqlDbType.Int);
                        parameter1.Value = obj.Year;
                        cmd.Parameters.Add(parameter1);

                        SqlParameter parameter2 = new SqlParameter("@MaNhanVien", SqlDbType.NVarChar);
                        parameter2.Value = obj.MaNhanVien;
                        cmd.Parameters.Add(parameter2);
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
        /// Loads all <see cref="HC_NhanVien_ChamCong_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(HC_NhanVien_ChamCong_Info.GetHC_NhanVien_ChamCong_Info(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_NhanVien_ChamCong_Coll"/> object.
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