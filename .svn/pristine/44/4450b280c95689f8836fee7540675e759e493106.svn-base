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
    public partial class BienLaiTamThu : BusinessBase<BienLaiTamThu>
    {
        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDBienLai"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDBienLaiProperty = RegisterProperty<Int64>(p => p.IDBienLai, "IDBien Lai");
        /// <summary>
        /// Gets the IDBien Lai.
        /// </summary>
        /// <value>The IDBien Lai.</value>
        public Int64 IDBienLai
        {
            get { return GetProperty(IDBienLaiProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDDieuTri"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDHocVienProperty = RegisterProperty<Int64>(p => p.IDHocVien, "IDHocVien");
        /// <summary>
        /// Gets or sets the IDDieu Tri.
        /// </summary>
        /// <value>The IDDieu Tri.</value>
        public Int64 IDHocVien
        {
            get { return GetProperty(IDHocVienProperty); }
            set { SetProperty(IDHocVienProperty, value); }
        }

        public static readonly PropertyInfo<Int64> IDPhieHuyProperty = RegisterProperty<Int64>(p => p.IDPhieuHuy, "IDPhieuHuy");
        /// <summary>
        /// Gets or sets the IDDieu Tri.
        /// </summary>
        /// <value>The IDDieu Tri.</value>
        public Int64 IDPhieuHuy
        {
            get { return GetProperty(IDPhieHuyProperty); }
            set { SetProperty(IDPhieHuyProperty, value); }
        }

        //public static readonly PropertyInfo<Int64> IDPhieuHoanProperty = RegisterProperty<Int64>(p => p.IDPhieuHoan, "IDPhieuHoan");
        ///// <summary>
        ///// Gets or sets the IDDieu Tri.
        ///// </summary>
        ///// <value>The IDDieu Tri.</value>
        //public Int64 IDPhieuHoan
        //{
        //    get { return GetProperty(IDPhieuHoanProperty); }
        //    set { SetProperty(IDPhieuHoanProperty, value); }
        //}
        //public static readonly PropertyInfo<Int64> IDHoaDonProperty = RegisterProperty<Int64>(p => p.IDHoaDon, "IDHoaDon");
        ///// <summary>
        ///// Gets or sets the IDDieu Tri.
        ///// </summary>
        ///// <value>The IDDieu Tri.</value>
        //public Int64 IDHoaDon
        //{
        //    get { return GetProperty(IDHoaDonProperty); }
        //    set { SetProperty(IDHoaDonProperty, value); }
        //}

        /// <summary>
        /// Maintains metadata about <see cref="MaBienLai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaBienLaiProperty = RegisterProperty<string>(p => p.MaBienLai, "Mã biên lai", "Tự sinh");
        /// <summary>
        /// Gets or sets the Ma Bien Lai.
        /// </summary>
        /// <value>The Ma Bien Lai.</value>
        public string MaBienLai
        {
            get { return GetProperty(MaBienLaiProperty); }
            set { SetProperty(MaBienLaiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLan"/> property.
        /// </summary>
        public static readonly PropertyInfo<byte> SoLanProperty = RegisterProperty<byte>(p => p.SoLan, "So Lan");
        /// <summary>
        /// Gets or sets the So Lan.
        /// </summary>
        /// <value>The So Lan.</value>
        public byte SoLan
        {
            get { return GetProperty(SoLanProperty); }
            set { SetProperty(SoLanProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="SoLan"/> property.
        /// </summary>
        public static readonly PropertyInfo<byte> SoLanInProperty = RegisterProperty<byte>(p => p.SoLanIn, "So Lan In");
        /// <summary>
        /// Gets or sets the So Lan.
        /// </summary>
        /// <value>The So Lan.</value>
        public byte SoLanIn
        {
            get { return GetProperty(SoLanInProperty); }
            set { SetProperty(SoLanInProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="SoTien"/> property.
        /// </summary>
        public static readonly PropertyInfo<Decimal> SoTienProperty = RegisterProperty<Decimal>(p => p.SoTien, "So Tien");
        /// <summary>
        /// Gets or sets the So Tien.
        /// </summary>
        /// <value>The So Tien.</value>
        public Decimal SoTien
        {
            get { return GetProperty(SoTienProperty); }
            set { SetProperty(SoTienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayThuProperty = RegisterProperty<SmartDate>(p => p.NgayThu, "Ngay Ky Quy");
        /// <summary>
        /// Gets or sets the Ngay Ky Quy.
        /// </summary>
        /// <value>The Ngay Ky Quy.</value>
        public string NgayThu
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayThuProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayThuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NguoiKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NguoiDongProperty = RegisterProperty<string>(p => p.NguoiDong, "Nguoi Ky Quy");
        /// <summary>
        /// Nguoi dong tien ky quy
        /// </summary>
        /// <value>The Nguoi Ky Quy.</value>
        public string NguoiDong
        {
            get { return GetProperty(NguoiDongProperty); }
            set { SetProperty(NguoiDongProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="NguoiKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NguoiThuProperty = RegisterProperty<string>(p => p.NguoiThu, "Nguoi Thu");
        /// <summary>
        /// Nguoi dong tien ky quy
        /// </summary>
        /// <value>The Nguoi Ky Quy.</value>
        public string NguoiThu
        {
            get { return GetProperty(NguoiThuProperty); }
            set { SetProperty(NguoiThuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDNguoiKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDNguoiThuProperty = RegisterProperty<Int64>(p => p.IDNguoiThu, "IDNguoi Thu");
        /// <summary>
        /// ID nguoi thu ky quy
        /// </summary>
        /// <value>The IDNguoi Ky Quy.</value>
        public Int64 IDNguoiThu
        {
            get { return GetProperty(IDNguoiThuProperty); }
            set { SetProperty(IDNguoiThuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HinhThucThanhToan"/> property.
        /// </summary>
        public static readonly PropertyInfo<byte?> HinhThucThuProperty = RegisterProperty<byte?>(p => p.HinhThucThu, "Hinh Thuc Thanh Toan");
        /// <summary>
        /// Gets or sets the Hinh Thuc Thanh Toan.
        /// </summary>
        /// <value>The Hinh Thuc Thanh Toan.</value>
        public byte? HinhThucThu
        {
            get { return GetProperty(HinhThucThuProperty); }
            set { SetProperty(HinhThucThuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Reference_Code"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Reference_CodeProperty = RegisterProperty<string>(p => p.Reference_Code, "Reference Code");
        /// <summary>
        /// Gets or sets the Reference Code.
        /// </summary>
        /// <value>The Reference Code.</value>
        public string Reference_Code
        {
            get { return GetProperty(Reference_CodeProperty); }
            set { SetProperty(Reference_CodeProperty, value); }
        }
        public static readonly PropertyInfo<bool?> XuatHDProperty = RegisterProperty<bool?>(p => p.XuatHD, "Trạng thái xuat HD");
        /// <summary>
        /// Gets or sets the Hinh Thuc Thanh Toan.
        /// </summary>
        /// <value>The Hinh Thuc Thanh Toan.</value>
        public bool? XuatHD
        {
            get { return GetProperty(XuatHDProperty); }
            set { SetProperty(XuatHDProperty, value); }
        }
        public static readonly PropertyInfo<bool?> HuyProperty = RegisterProperty<bool?>(p => p.Huy, "Trạng thái hủy");
        /// <summary>
        /// Gets or sets the Hinh Thuc Thanh Toan.
        /// </summary>
        /// <value>The Hinh Thuc Thanh Toan.</value>
        public bool? Huy
        {
            get { return GetProperty(HuyProperty); }
            set { SetProperty(HuyProperty, value); }
        }

        public static readonly PropertyInfo<byte?> LoaiPhieuProperty=RegisterProperty<byte?>(p=> p.LoaiPhieu,"LoaiPhieu");

            ///<summary>
            /// Gets or sets the Hinh Thuc Thanh Toan.
            ///</summary>
            ///<value>The Hinh Thuc Thanh Toan.</value>
            public byte? LoaiPhieu
        {
            get { return GetProperty(LoaiPhieuProperty); }
            set { SetProperty(LoaiPhieuProperty, value); }
        }

            public static readonly PropertyInfo<string> TenCanBoNgoaiProperty = RegisterProperty<string>(p => p.TenCanBoNgoai, "Nguoi Thu");
            /// <summary>
            /// Nguoi dong tien ky quy
            /// </summary>
            /// <value>The Nguoi Ky Quy.</value>
            public string TenCanBoNgoai
            {
                get { return GetProperty(TenCanBoNgoaiProperty); }
                set { SetProperty(TenCanBoNgoaiProperty, value); }
            }
            public static readonly PropertyInfo<string> TenCanBoTrongProperty = RegisterProperty<string>(p => p.TenCanBoTrong, "Nguoi Thu");
            /// <summary>
            /// Nguoi dong tien ky quy
            /// </summary>
            /// <value>The Nguoi Ky Quy.</value>
            public string TenCanBoTrong
            {
                get { return GetProperty(TenCanBoTrongProperty); }
                set { SetProperty(TenCanBoTrongProperty, value); }
            }
            public static readonly PropertyInfo<string> SoHoaDonProperty = RegisterProperty<string>(p => p.SoHoaDon, "So Hoa Don");
            /// <summary>
            /// Gets or sets the Ma Bien Lai.
            /// </summary>
            /// <value>The Ma Bien Lai.</value>
            public string SoHoaDon
            {
                get { return GetProperty(SoHoaDonProperty); }
                set { SetProperty(SoHoaDonProperty, value); }
            }

        #endregion

        #region Criteria

        [Serializable()]
        public class Criteria
        {
            /// <summary>
            /// ID Biên lai hủy
            /// </summary>
            private long _lngIDBienLai;
            /// <summary>
            /// ID người hủy
            /// </summary>
            private long _lngIDNguoiHuy;
            /// <summary>
            /// Người hủy
            /// </summary>
            private string _strNguoiHuy = string.Empty;

            /// <summary>
            /// Lý do hủy
            /// </summary>
            private string _strLyDoHuy = string.Empty;

            private Int64 _intIDHocVien;
            /// <summary>
            /// ID Biên lai
            /// </summary>
            public long IDBienLai
            {
                get { return _lngIDBienLai; }
            }

            /// <summary>
            /// ID người hủy
            /// </summary>
            public long IDNguoiHuy
            {
                get
                {
                    return _lngIDNguoiHuy;
                }
            }

            /// <summary>
            /// Người hủy
            /// </summary>
            public string NguoiHuy
            {
                get
                {
                    return _strNguoiHuy;
                }
            }
            /// <summary>
            /// Lý do hủy
            /// </summary>
            public string LyDoHuy
            {
                get
                {
                    return _strLyDoHuy;
                }
            }
            public long IDHocVien
            {
                get { return _intIDHocVien; }
            }

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="lngIDBienLai"></param>
            /// <param name="lngIDNgoiHuy"></param>
            /// <param name="strNguoiHuy"></param>
            public Criteria(long lngIDBienLai, long lngIDNgoiHuy, string strNguoiHuy)
            {
                _lngIDBienLai = lngIDBienLai;
                _lngIDNguoiHuy = lngIDNgoiHuy;
                _strNguoiHuy = strNguoiHuy;
            }
            public Criteria(long lngIDBienLai, long lngIDNgoiHuy, string strNguoiHuy, string strLyDoHuy)
            {
                _lngIDBienLai = lngIDBienLai;
                _lngIDNguoiHuy = lngIDNgoiHuy;
                _strNguoiHuy = strNguoiHuy;
                _strLyDoHuy = strLyDoHuy;
            }
            public  Criteria(long lngIDHocVien)
            {
                _intIDHocVien = lngIDHocVien;
            }
            }

        #endregion

        #region Validation

        protected override void AddBusinessRules()
        {
            //base.AddBusinessRules();
            //BusinessRules.AddRule(new ValidationCheck.ValiNumber(SoTienProperty, "Số tiền phải lơn hơn 1.000 đồng", 1000));
        }

        #endregion

        #region Authorization Rules
        //public static bool CanGetObject()
        //{
        //    bool result = false;
        //    if (Csla.ApplicationContext.User.IsInRole(GlobalCommon.FUNCTION_ID + "IP_BIENLAIKYQUY:S")
        //        || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
        //        result = true;
        //    return result;
        //}

        //public static bool CanAddObject()
        //{
        //    bool result = false;
        //    if (Csla.ApplicationContext.User.IsInRole(GlobalCommon.FUNCTION_ID + "IP_BIENLAIKYQUY:I")
        //        || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
        //        result = true;
        //    return result;
        //}

        //public static bool CanEditObject()
        //{
        //    bool result = false;
        //    if (Csla.ApplicationContext.User.IsInRole(GlobalCommon.FUNCTION_ID + "IP_BIENLAIKYQUY:U")
        //        || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
        //        result = true;
        //    return result;
        //}

        //public static bool CanDeleteObject()
        //{
        //    bool result = false;
        //    if (Csla.ApplicationContext.User.IsInRole(GlobalCommon.FUNCTION_ID + "IP_BIENLAIKYQUY:D")
        //        || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
        //        result = true;
        //    return result;
        //}

        //public static bool CanPayment()
        //{
        //    bool result = false;
        //    if (Csla.ApplicationContext.User.IsInRole(GlobalCommon.FUNCTION_ID + "IP_THANHTOAN_ONLINE:I")
        //        || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
        //        result = true;
        //    return result;
        //}
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="IP_KyQuy"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="IP_KyQuy"/> object.</returns>
        public static BienLaiTamThu NewBienLaiTamThu()
        {
            //if (!CanAddObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền thêm mới ký quỹ");
            return DataPortal.Create<BienLaiTamThu>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_KyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai parameter of the IP_KyQuy to fetch.</param>
        /// <returns>A reference to the fetched <see cref="IP_KyQuy"/> object.</returns>
        public static BienLaiTamThu GetBienLaiTamThu(Int64 iDBienLai)
        {
            //if (!CanGetObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền xem biên lai ký quỹ");
            return DataPortal.Fetch<BienLaiTamThu>(iDBienLai);
        }
        public static BienLaiTamThu GetBienLaiTamThu_KQ(Int64 idHocVien)
        {
            //if (!CanGetObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền xem biên lai ký quỹ");
            return DataPortal.Fetch<BienLaiTamThu>(new Criteria(idHocVien));
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="IP_KyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the IP_KyQuy to delete.</param>
        public static void DeleteIP_KyQuy(long lngIDBienLai, long lngIDNguoiHuy, string strNguoiHuy, string strLyDoHuy)
        {
            //if (!CanDeleteObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền xóa ký quỹ");
            DataPortal.Delete<BienLaiTamThu>(new Criteria(lngIDBienLai, lngIDNguoiHuy, strNguoiHuy, strLyDoHuy));
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="IP_KyQuy"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewBienLaiTamThu(EventHandler<DataPortalResult<BienLaiTamThu>> callback)
        {
            DataPortal.BeginCreate<BienLaiTamThu>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="IP_KyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai parameter of the IP_KyQuy to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetBienLaiTamThu(Int64 iDBienLai, EventHandler<DataPortalResult<BienLaiTamThu>> callback)
        {
            DataPortal.BeginFetch<BienLaiTamThu>(iDBienLai, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="IP_KyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDBienLai">The IDBienLai of the IP_KyQuy to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteBienLaiTamThu(Int64 iDBienLai, EventHandler<DataPortalResult<BienLaiTamThu>> callback)
        {
            DataPortal.BeginDelete<BienLaiTamThu>(iDBienLai, callback);
        }

        public override BienLaiTamThu Save()
        {
            //if (this.IsDirty)
                //if (!CanEditObject())
                //    throw new System.Security.SecurityException("Bạn không có quyền sửa ký quỹ");
            return base.Save();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_KyQuy"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public BienLaiTamThu()
        {
            // Prevent direct creation
        }

        #endregion
        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="IP_KyQuy"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            //LoadProperty(IDBienLaiProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(Reference_CodeProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="IP_KyQuy"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="iDBienLai">The IDBien Lai.</param>
        protected void DataPortal_Fetch(Int64 iDBienLai)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.BienLaiTamThu_Gets", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDBienLai", iDBienLai).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd, iDBienLai);
                    OnFetchPre(args);
                    Fetch(cmd);
                    OnFetchPost(args);
                }
            }
            // check all object rules and property rules
            BusinessRules.CheckRules();
        }

        private void Fetch(SqlCommand cmd)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                }
            }
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
            Fetch_KQ(criteria.IDHocVien);
        }
        private void Fetch_KQ(Int64 intIDHocVien)
        {
           // this.RaiseListChangedEvents = false;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "BienLaiTamThu_Get_Test";
                    cm.Parameters.AddWithValue("@IDHocVien", intIDHocVien);
                    cm.CommandType = CommandType.StoredProcedure;
                    using (SafeDataReader dr = new SafeDataReader(cm.ExecuteReader()))
                    {
                        //this.IsReadOnly = false;
                        while (dr.Read())
                        {
                            Fetch_KQ(dr);
                        }
                        //this.IsReadOnly = true;
                    }
                }
            }
          //  this.RaiseListChangedEvents = true;
        }
        //private void Fetch_KQ(SqlCommand cmd)
        //{
        //    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
        //    {
        //        if (dr.Read())
        //        {
        //            Fetch_KQ(dr);
        //        }
        //    }
        //}
        /// <summary>
        /// Loads a <see cref="IP_KyQuy"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDBienLaiProperty, dr.GetInt64("IDBienLai"));
            LoadProperty(IDHocVienProperty, dr.GetInt64("IDHocVien"));
            LoadProperty(IDPhieHuyProperty, dr.GetInt64("IDPhieuHuy"));
            LoadProperty(MaBienLaiProperty, dr.GetString("MaBienLai"));
            LoadProperty(SoLanProperty, dr.GetByte("SoLan"));
            LoadProperty(SoTienProperty, dr.GetDecimal("SoTien"));
            LoadProperty(NgayThuProperty, dr.GetDateTime("NgayThu"));
            LoadProperty(NguoiDongProperty, dr.GetString("TenNguoiDong"));
            LoadProperty(IDNguoiThuProperty, dr.GetInt64("IDNguoiThu"));
            LoadProperty(NguoiThuProperty, dr.GetString("TenNguoiThu"));
            LoadProperty(HinhThucThuProperty, dr.GetByte("HinhThucThu"));
            LoadProperty(XuatHDProperty, dr.GetBoolean("XuatHD"));
            LoadProperty(HuyProperty, dr.GetBoolean("Huy"));
            LoadProperty(LoaiPhieuProperty, dr.GetByte("LoaiPhieu"));
            
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        private void Fetch_KQ(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDBienLaiProperty, dr.GetInt64("IDBienLai"));
            LoadProperty(MaBienLaiProperty, dr.GetString("MaBienLai"));
            LoadProperty(SoLanProperty, dr.GetByte("SoLan"));
            LoadProperty(SoTienProperty, dr.GetDecimal("SoTien"));
            LoadProperty(NgayThuProperty, Convert.ToDateTime(dr.GetDateTime("NgayThu")));
            LoadProperty(NguoiThuProperty, dr.GetString("NguoiThu"));
            LoadProperty(IDNguoiThuProperty, dr.GetInt64("IDNguoiThu"));
            LoadProperty(HinhThucThuProperty, dr.GetByte("HinhThucThu"));
            LoadProperty(XuatHDProperty, dr.GetBoolean("XuatHD"));
            LoadProperty(HuyProperty, dr.GetBoolean("Huy"));
            LoadProperty(SoLanInProperty, dr.GetByte("SoLanIn"));
            LoadProperty(SoHoaDonProperty, dr.GetString("SoHoaDon"));
            LoadProperty(HinhThucThuProperty, dr.GetByte("LoaiPhieu"));
            LoadProperty(TenCanBoNgoaiProperty, dr.GetString("TenCanBoNgoai"));
            LoadProperty(TenCanBoTrongProperty, dr.GetString("TenCanBoTrong"));
            //LoadProperty(Reference_CodeProperty, dr.GetString("Reference_Code"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }
        /// <summary>
        /// Inserts a new <see cref="IP_KyQuy"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.BienLaiTamThu_ins", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IDHocVien", ReadProperty(IDHocVienProperty)).DbType = DbType.Int64;
                    
                    cmd.Parameters.AddWithValue("@IDBienLai", ReadProperty(IDBienLaiProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@MaBienLai", ReadProperty(MaBienLaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoLan", ReadProperty(SoLanProperty)).DbType = DbType.Byte;
                    cmd.Parameters.AddWithValue("@SoTien", ReadProperty(SoTienProperty)).DbType = DbType.Decimal;
                    cmd.Parameters.AddWithValue("@NgayThu", ReadProperty(NgayThuProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NguoiThu", ReadProperty(NguoiThuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NguoiDong", ReadProperty(NguoiDongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IDNguoiThu", ReadProperty(IDNguoiThuProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@HinhThucThu", ReadProperty(HinhThucThuProperty) == null ? (object)DBNull.Value : ReadProperty(HinhThucThuProperty).Value).DbType = DbType.Byte;
                    cmd.Parameters.AddWithValue("@LoaiPhieu", ReadProperty(LoaiPhieuProperty) == null ? (object)DBNull.Value : ReadProperty(LoaiPhieuProperty).Value).DbType = DbType.Byte;
                    //cmd.Parameters.AddWithValue("@XuatHD", ReadProperty(XuatHDProperty) == null ? (object)DBNull.Value : ReadProperty(XuatHDProperty).Value).DbType = DbType.Boolean;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDBienLaiProperty, (long) cmd.Parameters["@IDBienLai"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="IP_KyQuy"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.BienLaiTamThu_Upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDHocVien", ReadProperty(IDHocVienProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDBienLai", ReadProperty(IDBienLaiProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@MaBienLai", ReadProperty(MaBienLaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoLan", ReadProperty(SoLanProperty)).DbType = DbType.Byte;
                    cmd.Parameters.AddWithValue("@SoTien", ReadProperty(SoTienProperty)).DbType = DbType.Decimal;
                    cmd.Parameters.AddWithValue("@NgayThu", ReadProperty(NgayThuProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NguoiThu", ReadProperty(NguoiThuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NguoiDong", ReadProperty(NguoiDongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IDNguoiThu", ReadProperty(IDNguoiThuProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@HinhThucThu", ReadProperty(HinhThucThuProperty) == null ? (object)DBNull.Value : ReadProperty(HinhThucThuProperty).Value).DbType = DbType.Byte;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="IP_KyQuy"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new Criteria(0, 0, "", ""));
        }

        /// <summary>
        /// Deletes the <see cref="IP_KyQuy"/> object from database.
        /// </summary>
        /// <param name="iDBienLai">The delete criteria.</param>
        protected void DataPortal_Delete(Criteria criteria)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.IP_KyQuy_destroy", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDBienLai", criteria.IDBienLai);
                    cmd.Parameters.AddWithValue("@IDNguoiHuy", criteria.IDNguoiHuy);
                    cmd.Parameters.AddWithValue("@NguoiHuy", criteria.NguoiHuy);
                    cmd.Parameters.AddWithValue("@GhiChu", criteria.LyDoHuy);
                    var args = new DataPortalHookArgs(cmd, criteria);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
                ctx.Commit();
            }
        }

        #endregion
        #region Create MaBienLai 2
        /// <summary>
        /// Tạo mã biên lai
        /// </summary>
        /// <param name="lngid">ID Điều trị</param>
        /// <returns>Mã biên lai</returns>
        public static string CreateMaBienLaiFunc(int intid, string strMaHocVien)
        {
            CreateMaBLFunc _result;
            _result = DataPortal.Execute<CreateMaBLFunc>(new CreateMaBLFunc(intid,strMaHocVien));
            return _result.MaBienLai;
        }
        [Serializable()]
        private class CreateMaBLFunc //: CommandBase
        {
            private int _intid;
            private string _strMaHocVien;
            private string _strMabl;

            public string MaBienLai
            {
                get { return _strMabl; }
            }
            public CreateMaBLFunc(int intid, string strMaHocVien)
            {
                _intid = intid;
                _strMaHocVien = strMaHocVien;
            }

            //protected override void DataPortal_Execute()
            //{
            //    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            //    {
            //        cn.Open();
            //        using (SqlCommand cm = cn.CreateCommand())
            //        {
            //            cm.CommandType = CommandType.StoredProcedure;
            //            cm.CommandText = "fn_taoSBL_TamThu";
            //            SqlParameter param = new SqlParameter("@year", _intid);
            //            SqlParameter parameter = new SqlParameter("@MaHocVien", _strMaHocVien);
            //            param.Direction = ParameterDirection.Input;
            //            cm.Parameters.Add(param);
            //            SqlParameter ret = new SqlParameter("@tmsoblt", SqlDbType.VarChar);
            //            ret.Direction = ParameterDirection.ReturnValue;
            //            cm.Parameters.Add(ret);
            //            cm.ExecuteNonQuery();
            //            _strMabl = cm.Parameters["@tmsoblt"].Value.ToString();
            //        }
            //    }
            //}
        }
        #endregion
        

        #region Pseudo Events

        /// <summary>
        /// Occurs after setting all defaults for object creation.
        /// </summary>
        partial void OnCreate(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after setting query parameters and before the delete operation.
        /// </summary>
        partial void OnDeletePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after the delete operation, before Commit().
        /// </summary>
        partial void OnDeletePost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the update operation.
        /// </summary>
        partial void OnUpdatePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the update operation, before setting back row identifiers (RowVersion) and Commit().
        /// </summary>
        partial void OnUpdatePost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after setting query parameters and before the insert operation.
        /// </summary>
        partial void OnInsertPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the insert operation, before setting back row identifiers (ID and RowVersion) and Commit().
        /// </summary>
        partial void OnInsertPost(DataPortalHookArgs args);

        #endregion

        #region Static Methods

        ///// <summary>
        ///// Tạo mã ký quỹ
        ///// </summary>
        ///// <param name="strKyHieu"></param>
        ///// <returns></returns>
        //public static string TaoMaKyQuy(string strKyHieu)
        //{
        //    string strMaKyQuy;
        //    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
        //    {
        //        //Open connection
        //        cn.Open();
        //        using (SqlCommand cm = cn.CreateCommand())
        //        {
        //            cm.CommandText = "select dbo.fn_TaoMaKyQuy(@strKyHieu)";
        //            cm.Parameters.AddWithValue("@strKyHieu", strKyHieu).DbType = DbType.String;
        //            cm.CommandType = CommandType.Text;
        //            strMaKyQuy = cm.ExecuteScalar().ToString();  
        //        }
        //    }
        //    ChenMaKyQuy(strMaKyQuy);
        //    return strMaKyQuy;
        //}

        ///// <summary>
        ///// Chèn mã ký quỹ vừa được tạo để chiếm chỗ
        ///// </summary>
        ///// <param name="strMaKyQuy"></param>
        //public static void ChenMaKyQuy(string strMaKyQuy)
        //{
        //    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
        //    {
        //        cn.Open();
        //        using (SqlCommand cm = cn.CreateCommand())
        //        {
        //            cm.CommandText = "IP_ChenMaKyQuy";
        //            cm.CommandType = CommandType.StoredProcedure; cm.CommandTimeout = int.Parse(NETLINK.LIB.AppConfig.GetKeyAppSetting("CommandTimeout"));
        //            cm.Parameters.AddWithValue("@MaBienLai", strMaKyQuy);
        //            cm.ExecuteNonQuery();
        //        }
        //    }
        //}

        ///// <summary>
        ///// Xóa mã ký quỹ trong bảng OP_TempMaKyQuy
        ///// </summary>
        ///// <param name="strMaKyQuy"></param>
        //public static void XoaMaKyQuy(string strMaKyQuy)
        //{
        //    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
        //    {
        //        //Open connection
        //        cn.Open();
        //        using (SqlCommand cm = cn.CreateCommand())
        //        {
        //            cm.CommandText = "IP_XoaMaKyQuy";
        //            cm.CommandType = CommandType.StoredProcedure; cm.CommandTimeout = int.Parse(NETLINK.LIB.AppConfig.GetKeyAppSetting("CommandTimeout"));
        //            cm.Parameters.AddWithValue("@MaBienLai", strMaKyQuy);
        //            cm.ExecuteNonQuery();
        //        }
        //    }
        //}

        ///// <summary>
        ///// Kiểm tra xem phiếu thu ký quỹ đã được hoàn hay chưa
        ///// </summary>
        ///// <param name="lngIDBienLai"></param>
        ///// <returns></returns>
        //public static bool KyQuyDaDuocHoan(long lngIDBienLai)
        //{
        //    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
        //    {
        //        //Open connection
        //        cn.Open();
        //        using (SqlCommand cm = cn.CreateCommand())
        //        {
        //            cm.CommandText = "select dbo.fn_CheckDeleteKyQuy(@lngIDBienLai)";
        //            cm.Parameters.AddWithValue("@lngIDBienLai", lngIDBienLai).DbType = DbType.Int64;
        //            cm.CommandType = CommandType.Text;
        //            int intCount = Convert.ToInt32(cm.ExecuteScalar());
        //            return (intCount == 0 ? false : true);
        //        }
        //    }
        //}

        #endregion
    }
    //}
}
