using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
using Csla.Core;


namespace ModuleDaoTao.LIB
{
    [Serializable]
    public partial class BienLaiColl : BusinessBindingListBase<BienLaiColl,BienLaiInfo>
    {
        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="IP_KyQuy_Info"/> item from the collection.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the item to be removed.</param>
        public void Remove(Int64 iDBienLai)
        {
            foreach (var bienLaiTamThuInfo in this)
            {
                if (bienLaiTamThuInfo.IDBienLai == iDBienLai)
                {
                    Remove(bienLaiTamThuInfo);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="IP_KyQuy_Info"/> item is in the collection.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the item to search for.</param>
        /// <returns><c>true</c> if the IP_KyQuy_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 iDBienLai)
        {
            foreach (var bienLaiTamThuInfo in this)
            {
                if (bienLaiTamThuInfo.IDBienLai == iDBienLai)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="IP_KyQuy_Info"/> item is in the collection.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the item to search for.</param>
        /// <returns><c>true</c> if the IP_KyQuy_Info is a collection item; otherwise, <c>false</c>.</returns>
        public BienLaiInfo ContainsReturnObject(Int64 iDBienLai)
        {
            foreach (var bienLaiTamThuInfo in this)
            {
                if (bienLaiTamThuInfo.IDBienLai == iDBienLai)
                {
                    return bienLaiTamThuInfo;
                }
            }
            return BienLaiInfo.NewBienLaiTamThuInfo();
        }

        /// <summary>
        /// Determines whether a <see cref="IP_KyQuy_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the item to search for.</param>
        /// <returns><c>true</c> if the IP_KyQuy_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(Int64 iDBienLai)
        {
            foreach (var bienLaiTamThuInfo in this.DeletedList)
            {
                if (bienLaiTamThuInfo.IDBienLai == iDBienLai)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="IP_KyQuy_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="IP_KyQuy_Coll"/> collection.</returns>
        public static BienLaiColl NewBienLaiTamThuColl()
        {
            return DataPortal.CreateChild<BienLaiColl>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="IP_KyQuy_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewBienLaiTamThuColl(EventHandler<DataPortalResult<BienLaiColl>> callback)
        {
            DataPortal.BeginCreate<BienLaiColl>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_KyQuy_Coll"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_KyQuy_Coll"/> object.</returns>
        internal static BienLaiColl GetBienLaiTamThuColl(SafeDataReader dr)
        {
            BienLaiColl obj = new BienLaiColl();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            return obj;
        }
        internal static BienLaiColl GetBienLaiTamThuCollKQBD(SafeDataReader dr)
        {
            BienLaiColl obj = new BienLaiColl();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.FetchKQBD(dr);
            return obj;
        }
        public static BienLaiColl GetBienLaiTamThuColl(Int32 iDHocVien)
        {
            return DataPortal.Fetch<BienLaiColl>(new Criteria(iDHocVien));

        }
        /// <summary>
        /// Factory method. Loads a <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_HoanKyQuy_ChiTiet_Coll"/> object.</returns>
        public static BienLaiColl GetHoanTamThu_ChiTiet_Coll(Int64 IDHocVien)
        {
            return DataPortal.Fetch<BienLaiColl>(IDHocVien);
        }
        #endregion
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_KyQuy_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private BienLaiColl()
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

        #region Criteria
        [Serializable()]
        private class Criteria
        {
            #region Protected Var
            /// <summary>
            /// ID điều trị
            /// </summary>
            protected Int32 _intIDHocVien;
            #endregion

            #region Public Properties
            public Int32 IDHocVien
            {
                get
                {
                    return _intIDHocVien;
                }
            }
            #endregion

            public Criteria(Int32 intIDHocVien)
            {
                _intIDHocVien = intIDHocVien;
            }

        }
        #endregion
        #region Data Access

        /// <summary>
        /// Loads all <see cref="IP_KyQuy_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// 
        private void DataPortal_Fetch(Criteria criteria)
        {
            Fetch(criteria.IDHocVien);
        }
        private void Fetch(Int32 intIDHocVien)
        {
            this.RaiseListChangedEvents = false;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "BienLai_Get";
                    cm.Parameters.AddWithValue("@IDHocVien", intIDHocVien);
                    cm.CommandType = CommandType.StoredProcedure;
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        //this.IsReadOnly = false;
                        while (dr.Read())
                        {
                            Add(BienLaiInfo.GetBienLaiTamThuInfo(dr));
                        }
                        //this.IsReadOnly = true;
                    }
                }
            }
            this.RaiseListChangedEvents = true;
        }
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(BienLaiInfo.GetBienLaiTamThuInfo(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
        }
        private void FetchKQBD(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(BienLaiInfo.GetBienLaiTamThuInfoKQBD(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
        }
        private void FetchHoanTamThu(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(BienLaiInfo.GetBienLaiTamThuInfoHKQ(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Loads a <see cref="IP_KyQuy"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="iDBienLai">The IDBien Lai.</param>
        protected void DataPortal_Fetch(Int64 idHocVien)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TamThuChuaHoan_gets", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDHocVien", idHocVien).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd, idHocVien);
                    OnFetchPre(args);
                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        FetchHoanTamThu(dr);
                    }
                    OnFetchPost(args);
                }
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
