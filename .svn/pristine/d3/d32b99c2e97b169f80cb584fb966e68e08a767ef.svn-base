using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
using Csla.Core;

namespace ModuleHanhChinh.LIB
{
     [Serializable]
    public partial class   SeachHocVien_Coll:BusinessBindingListBase<SeachHocVien_Coll,SeachHocVien_Info>
    {
         public static int So;

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="IP_KyQuy_Info"/> item from the collection.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the item to be removed.</param>
        public void Remove(string maHocVien)
        {
            foreach (var seachHocVien_Info in this)
            {
                if (seachHocVien_Info.MaHocVien == maHocVien)
                {
                    Remove(seachHocVien_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="IP_KyQuy_Info"/> item is in the collection.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the item to search for.</param>
        /// <returns><c>true</c> if the IP_KyQuy_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(string maHocVien)
        {
            foreach (var seachHocVien_Info in this)
            {
                if (seachHocVien_Info.MaHocVien == maHocVien)
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
        public SeachHocVien_Info ContainsReturnObject(string maHocVien)
        {
            foreach (var seachHocVien_Info in this)
            {
                if (seachHocVien_Info.MaHocVien == maHocVien)
                {
                    return seachHocVien_Info;
                }
            }
            return SeachHocVien_Info.NewSeachHocVien_Info();
        }

        /// <summary>
        /// Determines whether a <see cref="IP_KyQuy_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the item to search for.</param>
        /// <returns><c>true</c> if the IP_KyQuy_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(string maHocVien)
        {
            foreach (var seachHocVien_Info in this.DeletedList)
            {
                if (seachHocVien_Info.MaHocVien == maHocVien)
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
        public static SeachHocVien_Coll NewSeachHocVien_Coll()
        {
            return DataPortal.CreateChild<SeachHocVien_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="IP_KyQuy_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewSeachHocVien_Coll(EventHandler<DataPortalResult<SeachHocVien_Coll>> callback)
        {
            DataPortal.BeginCreate<SeachHocVien_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_KyQuy_Coll"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_KyQuy_Coll"/> object.</returns>
        internal static SeachHocVien_Coll GetSeachHocVien_Coll(SafeDataReader dr)
        {
            SeachHocVien_Coll obj = new SeachHocVien_Coll();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            return obj;
        }
     
     
       
        internal static SeachHocVien_Coll GetSeachHocVien_Coll4(SafeDataReader dr)
        {
            SeachHocVien_Coll obj = new SeachHocVien_Coll();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.FetchDSDHP(dr);
            return obj;
        }
        
        public static SeachHocVien_Coll GetSeachHocVien_Coll_NgayBatDau(Int32 TimKiem, Int32 TrangThaiDHP, string MaHocVien, DateTime NgayBatDau, DateTime NgayKetThuc, Int32 IDChuyenKhoa, Int32 IDKhungLop, Int32 LoaiHinhDaoTao)
        {
            return DataPortal.Fetch<SeachHocVien_Coll>(new Criteria(TimKiem, TrangThaiDHP, MaHocVien, NgayBatDau, NgayKetThuc, IDChuyenKhoa, IDKhungLop, LoaiHinhDaoTao));
        }
        #endregion
         #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_KyQuy_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private SeachHocVien_Coll()
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
            protected string _stringmaHocVien;
            protected Int32 _intIDChuyenKhoa;
            protected DateTime _datengayBatDau;
            protected DateTime _datengayKetThuc;
            protected Int32 _intIdKhungLopHoc;
            protected Int32 _intLoaiHinhDaoTao;
            protected Int32 _intdieuKien;
            protected Int32 _intTimKiem;
            protected Int32 _intTrangThaiDHP;
               
            #endregion

            #region Public Properties
            public DateTime NgayBatDau
            {
                get { return _datengayBatDau; }
            }
            public DateTime NgayKetThuc
            {
                get { return _datengayKetThuc; }
            }
            public Int32 IDChuyenKhoa
            {
                get { return _intIDChuyenKhoa; }
            }
            public string MaHocVien
            {
                get
                {
                    return _stringmaHocVien;
                }
            }

            public Int32 IDKhungLopHoc
            {
                get { return _intIdKhungLopHoc; }
            }
            public  Int32 LoaiHinhDaoTao
            {
                get { return _intLoaiHinhDaoTao; }
            }

            public  Int32 DieuKien
            {
                get { return _intdieuKien; }
            }
            public Int32 TimKiem
            {
                get { return _intTimKiem; }
            }

            public Int32 TrangThaiDHP
            {
                get { return _intTrangThaiDHP; }
            }
            #endregion
             public Criteria(Int32 TimKiem,Int32 TrangThaiDHP,string MaHocVien,DateTime NgayBatDau,DateTime NgayKetThuc,Int32 IDChuyenKhoa,Int32 IDKhungLop,Int32 LoaiHinhDaoTao)
            {
                _intTimKiem = TimKiem;
                _intTrangThaiDHP = TrangThaiDHP;
                _stringmaHocVien = MaHocVien;
                _datengayBatDau = NgayBatDau;
                _datengayKetThuc = NgayKetThuc;
                _intIDChuyenKhoa = IDChuyenKhoa;
                _intIdKhungLopHoc = IDKhungLop;
                _intLoaiHinhDaoTao = LoaiHinhDaoTao;

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
            
                if (So == 0)
                {
                    FetchDSDHP(criteria.TimKiem, criteria.TrangThaiDHP, criteria.MaHocVien, criteria.NgayBatDau, criteria.NgayKetThuc, criteria.IDChuyenKhoa, criteria.IDKhungLopHoc, criteria.LoaiHinhDaoTao);
                }
            else if (So==1)
            {
                FetchDSDHP(criteria.TimKiem, criteria.TrangThaiDHP, criteria.MaHocVien, criteria.NgayBatDau, criteria.NgayKetThuc, criteria.IDChuyenKhoa, criteria.IDKhungLopHoc, criteria.LoaiHinhDaoTao);
            }
                else if (So == 2)
                {
                    FetchDSDHP(criteria.TimKiem, criteria.TrangThaiDHP, criteria.MaHocVien, criteria.NgayBatDau, criteria.NgayKetThuc, criteria.IDChuyenKhoa, criteria.IDKhungLopHoc, criteria.LoaiHinhDaoTao);
                }
                 }
        

        private void FetchDSDHP(Int32 TimKiem, Int32 TrangThaiDHP, string MaHocVien, DateTime NgayBatDau, DateTime NgayKetThuc, Int32 IDChuyenKhoa, Int32 IDKhungLop, Int32 LoaiHinhDT)
        {
            this.RaiseListChangedEvents = false;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "dbo.SeachHocVien_Get";
                    cm.Parameters.AddWithValue("@TimKiem", TimKiem);
                    cm.Parameters.AddWithValue("@TrangThaiDHP", TrangThaiDHP);
                    cm.Parameters.AddWithValue("@MaHocVien", MaHocVien);
                    cm.Parameters.AddWithValue("@TuNgay", NgayBatDau);
                    cm.Parameters.AddWithValue("@DenNgay", NgayKetThuc);
                    cm.Parameters.AddWithValue("@IDChuyenKhoa", IDChuyenKhoa);
                    cm.Parameters.AddWithValue("@IDKhungLop", IDKhungLop);
                    cm.Parameters.AddWithValue("@LoaiHinhDT", LoaiHinhDT);
                    cm.CommandType = CommandType.StoredProcedure;
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        //this.IsReadOnly = false;
                        while (dr.Read())
                        {
                            Add(SeachHocVien_Info.GetSeachHocVien_Info(dr));
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
                Add(SeachHocVien_Info.GetSeachHocVien_Info(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
        }    
        private void FetchDSDHP(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(SeachHocVien_Info.GetSeachHocVien_Info(dr));
            }
            OnFetchPost(args);
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
