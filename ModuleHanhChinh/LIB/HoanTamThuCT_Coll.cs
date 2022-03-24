using System;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable]
    public partial class HoanTamThuCT_Coll : BusinessBindingListBase<HoanTamThuCT_Coll, HoanTamThuCT_Info>
    {
        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="IP_HoanKyQuy_ChiTiet_Info"/> item from the collection.
        /// </summary>
        /// <param name="iDBienLaiKyQuy">The IDBienLaiKyQuy of the item to be removed.</param>
        public void Remove(Int64 iDBienLai)
        {
            foreach (var hoanTamThuCT_Info in this)
            {
                if (hoanTamThuCT_Info.IDBienLaiTamUng == iDBienLai)
                {
                    Remove(hoanTamThuCT_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="IP_HoanKyQuy_ChiTiet_Info"/> item is in the collection.
        /// </summary>
        /// <param name="iDBienLaiKyQuy">The IDBienLaiKyQuy of the item to search for.</param>
        /// <returns><c>true</c> if the IP_HoanKyQuy_ChiTiet_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 iDBienLai)
        {
            foreach (var hoanTamThuCT_Info in this)
            {
                if (hoanTamThuCT_Info.IDBienLaiTamUng == iDBienLai)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="IP_HoanKyQuy_ChiTiet_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="iDBienLaiKyQuy">The IDBienLaiKyQuy of the item to search for.</param>
        /// <returns><c>true</c> if the IP_HoanKyQuy_ChiTiet_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(Int64 iDBienLai)
        {
            foreach (var iP_HoanKyQuy_ChiTiet_Info in this.DeletedList)
            {
                if (iP_HoanKyQuy_ChiTiet_Info.IDBienLaiTamUng == iDBienLai)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> collection.</returns>
        internal static HoanTamThuCT_Coll NewHoanTamThuCT_Coll()
        {
            return DataPortal.CreateChild<HoanTamThuCT_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHoanTamThuCT_Coll(EventHandler<DataPortalResult<HoanTamThuCT_Coll>> callback)
        {
            DataPortal.BeginCreate<HoanTamThuCT_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> object.</returns>
        public static HoanTamThuCT_Coll GetHoanTamThuCT_Coll(SafeDataReader dr)
        {
            HoanTamThuCT_Coll obj = new HoanTamThuCT_Coll();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            return obj;
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> object.</returns>
        //public static IP_HoanKyQuy_ChiTiet_Coll GetIP_HoanKyQuy_ChiTiet_Coll(Int64 iDDieuTri)
        //{
        //    return DataPortal.Fetch<IP_HoanKyQuy_ChiTiet_Coll>(iDDieuTri);
        //}
        #endregion

         #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public HoanTamThuCT_Coll()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();

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
        /// Loads all <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(HoanTamThuCT_Info.GetHoanTamThuCT_Info(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Loads a <see cref="IP_KyQuy"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="iDBienLai">The IDBien Lai.</param>
        //protected void DataPortal_Fetch(Int64 iDDieuTri)
        //{
        //    using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
        //    {
        //        using (var cmd = new SqlCommand("dbo.IP_KyQuyChuaHoan_gets", ctx.Connection))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@IDDieuTri", iDDieuTri).DbType = DbType.Int64;
        //            var args = new DataPortalHookArgs(cmd, iDDieuTri);
        //            OnFetchPre(args);
        //            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
        //            {
        //                Fetch(dr);
        //            }
        //            OnFetchPost(args);
        //        }
        //    }
        //}

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
