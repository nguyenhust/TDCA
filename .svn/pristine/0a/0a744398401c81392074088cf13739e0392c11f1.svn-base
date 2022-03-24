using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{
    [Serializable]
    public partial class TrangThaiCuaHocVien_Coll : ReadOnlyListBase<TrangThaiCuaHocVien_Coll, TrangThaiCuaHocVien_Info>
    {
        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="DIC_ChucVu_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The ID of the item to be removed.</param>
        public void Remove(Int64 id)
        {
            foreach (var TrangThaiCuaHocVien_Info in this)
            {
                if (TrangThaiCuaHocVien_Info.IDTrangThai == id)
                {
                    Remove(TrangThaiCuaHocVien_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="DIC_ChucVu_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the DIC_ChucVu_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int id)
        {
            foreach (var TrangThaiCuaHocVien_Info in this)
            {
                if (TrangThaiCuaHocVien_Info.IDTrangThai == id)
                {
                    return true;
                }
            }
            return false;
        }

        ///// <summary>
        ///// Determines whether a <see cref="DIC_ChucVu_Info"/> item is in the collection's DeletedList.
        ///// </summary>
        ///// <param name="id">The ID of the item to search for.</param>
        ///// <returns><c>true</c> if the DIC_ChucVu_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        //public bool ContainsDeleted(int id)
        //{
        //    foreach (var TrangThaiCuaHocVien_Info in this.DeletedList)
        //    {
        //        if (TrangThaiCuaHocVien_Info.IDTrangThai == id)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        #endregion



        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_ChucVu_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_ChucVu_Coll"/> collection.</returns>
        public static TrangThaiCuaHocVien_Coll NewTrangThaiCuaHocVien_Coll()
        {

            return DataPortal.Create<TrangThaiCuaHocVien_Coll>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_ChucVu_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="DIC_ChucVu_Coll"/> collection.</returns>
        public static TrangThaiCuaHocVien_Coll GetTrangThaiCuaHocVien_Coll()
        {

            return DataPortal.Fetch<TrangThaiCuaHocVien_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_ChucVu_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewTrangThaiCuaHocVien_Coll(EventHandler<DataPortalResult<TrangThaiCuaHocVien_Coll>> callback)
        {

            DataPortal.BeginCreate<TrangThaiCuaHocVien_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DIC_ChucVu_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void GetTrangThaiCuaHocVien_Coll(EventHandler<DataPortalResult<TrangThaiCuaHocVien_Coll>> callback)
        {

            DataPortal.BeginFetch<TrangThaiCuaHocVien_Coll>(callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_ChucVu_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public TrangThaiCuaHocVien_Coll()
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
        /// Loads a <see cref="DIC_ChucVu_Coll"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TrangThaiCuaHocVien_Coll_Get", ctx.Connection))
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
        /// Loads all <see cref="DIC_ChucVu_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(TrangThaiCuaHocVien_Info.GetTrangThaiCuaHocVien_Info(dr));
            }
            RaiseListChangedEvents = rlce;
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
