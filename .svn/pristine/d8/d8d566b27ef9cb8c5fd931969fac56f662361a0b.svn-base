using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
namespace DanhMuc.LIB
{
    [Serializable]
   public partial  class DIC_GiangVien_Coll:BusinessBindingListBase<DIC_GiangVien_Coll,DIC_GiangVien_Info>
    {
          #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="DIC_CanBo_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The ID of the item to be removed.</param>
        public void Remove(Int64 id)
        {
            foreach (var dIC_GiangVien_Info in this)
            {
                if (dIC_GiangVien_Info.IDGiangVien == id)
                {
                    Remove(dIC_GiangVien_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="DIC_CanBo_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the DIC_CanBo_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 id)
        {
            foreach (var dIC_GiangVien_Info in this)
            {
                if (dIC_GiangVien_Info.IDGiangVien == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="DIC_CanBo_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the DIC_CanBo_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(Int64 id)
        {
            foreach (var dIC_GiangVien_Info in this.DeletedList)
            {
                if (dIC_GiangVien_Info.IDGiangVien == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Criteria

        [Serializable()]        
        public class CriteriaFilter
        {
            private Int64 _intIDChuyenKhoa;
            public long IDChuyenKhoa { get { return _intIDChuyenKhoa; } }
            public CriteriaFilter(Int64 intIDChuyenKhoa)
            {
                _intIDChuyenKhoa = intIDChuyenKhoa;
            }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_CanBo_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_CanBo_Coll"/> collection.</returns>
        public static DIC_GiangVien_Coll NewDIC_GiangVien_Coll()
        {
            return DataPortal.Create<DIC_GiangVien_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_CanBo_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="DIC_CanBo_Coll"/> collection.</returns>
        public static DIC_GiangVien_Coll GetDIC_GiangVien_Coll(BusinessFunction function)
        {
            return DataPortal.Fetch<DIC_GiangVien_Coll>(function);
        }

        public static DIC_GiangVien_Coll GetDIC_GiangVien_Coll()
        {
          //  BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
          //  function.Item = LoaiCanBo.CanBoThuocTrungTamCDT;
            return DataPortal.Fetch<DIC_GiangVien_Coll>();
        }

        public static DIC_GiangVien_Coll GetDIC_GiangVien_Coll(string MaLop)
        {
            //  BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
            //  function.Item = LoaiCanBo.CanBoThuocTrungTamCDT;
            return DataPortal.Fetch<DIC_GiangVien_Coll>(MaLop);
        }

        public static DIC_GiangVien_Coll GetDIC_GiangVien_Coll_GiangVien(Int64 intIDChuyenKhoa)
        {
            return DataPortal.Fetch<DIC_GiangVien_Coll>(new CriteriaFilter(intIDChuyenKhoa));
        }
        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_CanBo_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDIC_GiangVien_Coll(EventHandler<DataPortalResult<DIC_GiangVien_Coll>> callback)
        {
            DataPortal.BeginCreate<DIC_GiangVien_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DIC_CanBo_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDIC_GiangVien_Coll(EventHandler<DataPortalResult<DIC_GiangVien_Coll>> callback)
        {
            DataPortal.BeginFetch<DIC_GiangVien_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_CanBo_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_GiangVien_Coll()
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
        /// Loads a <see cref="DIC_CanBo_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {

            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
               
                    using (var cmd = new SqlCommand("dbo.DIC_GiangVien_Coll_Get", ctx.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                     //   cmd.Parameters.AddWithValue("@Type", Convert.ToInt32(function.Item)).DbType = DbType.Int32;
                        var args = new DataPortalHookArgs(cmd);
                        OnFetchPre(args);
                        LoadCollection(cmd);
                        OnFetchPost(args);
                    }
              
            }
        }

        protected void DataPortal_Fetch( string MaLop)
        {

            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {

                using (var cmd = new SqlCommand("dbo.DIC_GiangVien_Coll_Gets", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", MaLop).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnFetchPre(args);
                    LoadCollection(cmd);
                    OnFetchPost(args);
                }

            }
        }

        protected void DataPortal_Fetch(CriteriaFilter criteria)
        {

            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {

                using (var cmd = new SqlCommand("dbo.DIC_GiangVien_Coll_Gets_ChuyenKhoa", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDChuyenkhoa", criteria.IDChuyenKhoa).DbType = DbType.Int64;
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
        /// Loads all <see cref="DIC_CanBo_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(DIC_GiangVien_Info.GetDIC_GiangVien_Info(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DIC_CanBo_Coll"/> object.
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
