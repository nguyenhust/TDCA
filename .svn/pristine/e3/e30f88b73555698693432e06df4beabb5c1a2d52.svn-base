
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable]
    public partial class BienLaiLopHocInfo : BusinessBase<BienLaiLopHocInfo>
    {
        #region Validation

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            BusinessRules.AddRule(new ValidationCheck.ValiNumber(SoTienProperty, "Số tiền phải lớn không", 1));
        }
        #endregion
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
        /// Maintains metadata about <see cref="MaBienLai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaBienLaiProperty = RegisterProperty<string>(p => p.MaBienLai, "Ma Bien Lai");
        /// <summary>
        /// Gets or sets the Ma Bien Lai.
        /// </summary>
        /// <value>The Ma Bien Lai.</value>
        public string MaBienLai
        {
            get { return GetProperty(MaBienLaiProperty); }
            set { SetProperty(MaBienLaiProperty, value); }
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
        public static readonly PropertyInfo<DateTime> NgayThuProperty = RegisterProperty<DateTime>(p => p.NgayThu, "Ngay Ky Quy");
        /// <summary>
        /// Gets or sets the Ngay Ky Quy.
        /// </summary>
        /// <value>The Ngay Ky Quy.</value>
        public DateTime NgayThu
        {
            get { return GetProperty(NgayThuProperty); }
            set { SetProperty(NgayThuProperty, value); }
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
        /// Maintains metadata about <see cref="IDNguoiKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int32> IDLopHocProperty = RegisterProperty<Int32>(p => p.IDLopHoc, "IDNguoi Ky Quy");
        /// <summary>
        /// ID nguoi thu ky quy
        /// </summary>
        /// <value>The IDNguoi Ky Quy.</value>
        public Int32 IDLopHoc
        {
            get { return GetProperty(IDLopHocProperty); }
            set { SetProperty(IDLopHocProperty, value); }
        }
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

        private decimal _decThanhTien;
        public decimal ThanhTien
        {
            get { return _decThanhTien; }

        }

        public static readonly PropertyInfo<string> NguoiThuProperty = RegisterProperty<string>(p => p.NguoiThu, "Ten nguoi Thu");

        public string NguoiThu
        {
            get { return GetProperty(NguoiThuProperty); }
            set { SetProperty(NguoiThuProperty, value); }
        }
        public static readonly PropertyInfo<bool> XuatHDProperty = RegisterProperty<bool>(p => p.XuatHD, "Trang thai XuatHD");

        public bool XuatHD
        {
            get { return GetProperty(XuatHDProperty); }
            set { SetProperty(XuatHDProperty, value); }
        }
        public static readonly PropertyInfo<bool> HuyProperty = RegisterProperty<bool>(p => p.Huy, "Trang thai Huy");

        public bool Huy
        {
            get { return GetProperty(HuyProperty); }
            set { SetProperty(HuyProperty, value); }
        }

        public static readonly PropertyInfo<byte?> LoaiPhieuProperty = RegisterProperty<byte?>(p => p.LoaiPhieu, "Hinh Thuc Thanh Toan");
        /// <summary>
        /// Gets or sets the Hinh Thuc Thanh Toan.
        /// </summary>
        /// <value>The Hinh Thuc Thanh Toan.</value>
        public byte? LoaiPhieu
        {
            get { return GetProperty(LoaiPhieuProperty); }
            set { SetProperty(LoaiPhieuProperty, value); }
        }

                
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="IP_KyQuy_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="IP_KyQuy_Info"/> object.</returns>
        public static  BienLaiLopHocInfo NewBienLaiLopHocInfo()
        {
            //if (!CanAddObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền thêm mới ký quỹ");
            return DataPortal.CreateChild< BienLaiLopHocInfo>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="IP_KyQuy_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewBienLaiLopHocInfo(EventHandler<DataPortalResult< BienLaiLopHocInfo>> callback)
        {
            //if (!CanAddObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền thêm mới ký quỹ");
            DataPortal.BeginCreate<BienLaiLopHocInfo>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_KyQuy_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_KyQuy_Info"/> object.</returns>
        internal static BienLaiLopHocInfo GetBienLaiTamThuInfo(SafeDataReader dr)
        {
            BienLaiLopHocInfo obj = new BienLaiLopHocInfo();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }
        internal static BienLaiLopHocInfo GetBienLaiLopHocInfoKQBD(SafeDataReader dr)
        {
            BienLaiLopHocInfo obj = new BienLaiLopHocInfo();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.FetchKQBD(dr);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }
        internal static BienLaiLopHocInfo GetBienLaiLopHocInfoHKQ(SafeDataReader dr)
        {
            BienLaiLopHocInfo obj = new BienLaiLopHocInfo();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.FetchHoanKyQuy(dr);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }
        #endregion
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_KyQuy_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private BienLaiLopHocInfo()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="IP_KyQuy_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            //LoadProperty(IDBienLaiProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(Reference_CodeProperty, string.Empty);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        private void FetchHoanKyQuy(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDBienLaiProperty, dr.GetInt64("IDBienLai"));
            LoadProperty(IDLopHocProperty, dr.GetInt32("IDLopHoc"));
            LoadProperty(MaBienLaiProperty, dr.GetString("MaBienLai"));
            LoadProperty(NgayThuProperty, dr.GetSmartDate("NgayThu"));
            LoadProperty(SoTienProperty, dr.GetDecimal("SoTien"));
            LoadProperty(IDNguoiThuProperty, dr.GetInt64("IDNguoiThu"));
            LoadProperty(NguoiThuProperty, dr.GetString("NguoiThu"));
            LoadProperty(SoLanProperty, dr.GetByte("SoLan"));
            LoadProperty(NguoiDongProperty, dr.GetString("NguoiDong"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }
        private void Fetch(SafeDataReader dr)
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
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }
        /// <summary>
        /// Loads a <see cref="IP_KyQuy_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void FetchKQBD(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDBienLaiProperty, dr.GetInt64("IDBienLai"));
            LoadProperty(MaBienLaiProperty, dr.GetString("MaBienLai"));
            LoadProperty(SoLanProperty, dr.GetByte("SoLan"));
            LoadProperty(SoTienProperty, dr.GetDecimal("SoTien"));
            LoadProperty(NgayThuProperty, Convert.ToDateTime(dr.GetString("NgayThu")));
            LoadProperty(NguoiThuProperty, dr.GetString("NguoiThu"));
            LoadProperty(IDNguoiThuProperty, dr.GetInt64("IDNguoiThu"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="IP_KyQuy_Info"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        //private void Child_Insert(IP_DieuTri_Info parent)
        //{
        //    try
        //    {
        //        using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
        //        {
        //            using (var cmd = new SqlCommand("dbo.IP_KyQuyBanDau_ins", ctx.Connection))
        //            {
        //                cmd.Transaction = ctx.Transaction;
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@IDDieuTri", parent.IDDieuTri).DbType = DbType.Int64;
        //                cmd.Parameters.AddWithValue("@IDBienLai", ReadProperty(IDBienLaiProperty)).Direction = ParameterDirection.Output;
        //                //cmd.Parameters.AddWithValue("@MaBienLai", ReadProperty(MaBienLaiProperty)).Direction = ParameterDirection.Output;
        //                cmd.Parameters.Add(new SqlParameter("@MaBienLai", SqlDbType.VarChar, 12, ParameterDirection.Output, false, 0, 12, "MaBienLai", DataRowVersion.Default, null));
        //                cmd.Parameters.AddWithValue("@SoLan", ReadProperty(SoLanProperty)).DbType = DbType.Byte;
        //                cmd.Parameters.AddWithValue("@SoTien", ReadProperty(SoTienProperty)).DbType = DbType.Decimal;
        //                cmd.Parameters.AddWithValue("@NgayKyQuy", ReadProperty(NgayKyQuyProperty)).DbType = DbType.DateTime;
        //                cmd.Parameters.AddWithValue("@NguoiThu", ReadProperty(NguoiKyQuyProperty)).DbType = DbType.String;
        //                cmd.Parameters.AddWithValue("@IDNguoiThu", ReadProperty(IDNguoiKyQuyProperty)).DbType = DbType.Int64;
        //                //cmd.Parameters.AddWithValue("@HinhThucThanhToan", ReadProperty(HinhThucThanhToanProperty) == null ? (object)DBNull.Value : ReadProperty(HinhThucThanhToanProperty).Value).DbType = DbType.Byte;
        //                //cmd.Parameters.AddWithValue("@Reference_Code", ReadProperty(Reference_CodeProperty) == null ? (object)DBNull.Value : ReadProperty(Reference_CodeProperty)).DbType = DbType.String;
        //                var args = new DataPortalHookArgs(cmd);
        //                OnInsertPre(args);
        //                cmd.ExecuteNonQuery();
        //                OnInsertPost(args);
        //                LoadProperty(IDBienLaiProperty, (long)cmd.Parameters["@IDBienLai"].Value);
        //                LoadProperty(MaBienLaiProperty, (string)cmd.Parameters["@MaBienLai"].Value);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        GlobalCommon.ShowErrorMessager(ex);
        //    }
        //}

        ///// <summary>
        ///// Updates in the database all changes made to the <see cref="IP_KyQuy_Info"/> object.
        ///// </summary>
        //private void Child_Update()
        //{
        //    //if (!IsDirty)
        //    //    return;
        //    //try
        //    //{
        //    //    using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
        //    //    {
        //    //        using (var cmd = new SqlCommand("dbo.IP_KyQuyBanDau_Upd", ctx.Connection))
        //    //        {
        //    //            cmd.Transaction = ctx.Transaction;
        //    //            cmd.CommandType = CommandType.StoredProcedure;
        //    //            cmd.Parameters.AddWithValue("@IDBienLai", ReadProperty(IDBienLaiProperty)).DbType = DbType.Int64;
        //    //            cmd.Parameters.AddWithValue("@MaBienLai", ReadProperty(MaBienLaiProperty)).DbType = DbType.String;
        //    //            cmd.Parameters.AddWithValue("@SoLan", ReadProperty(SoLanProperty)).DbType = DbType.Byte;
        //    //            cmd.Parameters.AddWithValue("@SoTien", ReadProperty(SoTienProperty)).DbType = DbType.Decimal;
        //    //            cmd.Parameters.AddWithValue("@NgayKyQuy", ReadProperty(NgayKyQuyProperty)).DbType = DbType.DateTime;
        //    //            cmd.Parameters.AddWithValue("@NguoiKyQuy", ReadProperty(NguoiKyQuyProperty)).DbType = DbType.String;
        //    //            cmd.Parameters.AddWithValue("@IDNguoiKyQuy", ReadProperty(IDNguoiKyQuyProperty)).DbType = DbType.Int64;
        //    //            cmd.Parameters.AddWithValue("@HinhThucThanhToan", ReadProperty(HinhThucThanhToanProperty) == null ? (object)DBNull.Value : ReadProperty(HinhThucThanhToanProperty).Value).DbType = DbType.Byte;
        //    //            cmd.Parameters.AddWithValue("@Reference_Code", ReadProperty(Reference_CodeProperty) == null ? (object)DBNull.Value : ReadProperty(Reference_CodeProperty)).DbType = DbType.String;
        //    //            var args = new DataPortalHookArgs(cmd);
        //    //            OnUpdatePre(args);
        //    //            cmd.ExecuteNonQuery();
        //    //            OnUpdatePost(args);
        //    //        }
        //    //    }
        //   // }
        //    //catch (Exception ex)
        //    //{
        //    //    GlobalCommon.ShowErrorMessager(ex);
        //    //}
        //}
        //private void Child_Update(IP_DieuTri_Info parent)
        //{
        //    //if (!IsDirty)
        //    //    return;
        //    //try
        //    //{
        //    //    using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
        //    //    {
        //    //        using (var cmd = new SqlCommand("dbo.IP_KyQuyBanDau_Upd", ctx.Connection))
        //    //        {
        //    //            cmd.Transaction = ctx.Transaction;
        //    //            cmd.CommandType = CommandType.StoredProcedure;
        //    //            cmd.Parameters.AddWithValue("@IDBienLai", ReadProperty(IDBienLaiProperty)).DbType = DbType.Int64;
        //    //            cmd.Parameters.AddWithValue("@IDDieuTri", parent.IDDieuTri);
        //    //            cmd.Parameters.AddWithValue("@MaBienLai", ReadProperty(MaBienLaiProperty)).DbType = DbType.String;
        //    //            cmd.Parameters.AddWithValue("@SoLan", ReadProperty(SoLanProperty)).DbType = DbType.Byte;
        //    //            cmd.Parameters.AddWithValue("@SoTien", ReadProperty(SoTienProperty)).DbType = DbType.Decimal;
        //    //            cmd.Parameters.AddWithValue("@NgayKyQuy", ReadProperty(NgayKyQuyProperty)).DbType = DbType.DateTime;
        //    //            cmd.Parameters.AddWithValue("@NguoiThu", ReadProperty(NguoiKyQuyProperty)).DbType = DbType.String;
        //    //            cmd.Parameters.AddWithValue("@IDNguoiThu", ReadProperty(IDNguoiKyQuyProperty)).DbType = DbType.Int64;
        //    //            var args = new DataPortalHookArgs(cmd);
        //    //            OnUpdatePre(args);
        //    //            cmd.ExecuteNonQuery();
        //    //            OnUpdatePost(args);
        //    //        }
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    GlobalCommon.ShowErrorMessager(ex);
        //    //}
        //}
        ///// <summary>
        ///// Self deletes the <see cref="IP_KyQuy_Info"/> object from database.
        ///// </summary>
        //private void Child_DeleteSelf()
        //{
        //    try
        //    {
        //        using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
        //        {
        //            using (var cmd = new SqlCommand("dbo.IP_KyQuyBanDau_del", ctx.Connection))
        //            {
        //                cmd.Transaction = ctx.Transaction;
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.AddWithValue("@IDBienLai", ReadProperty(IDBienLaiProperty)).DbType = DbType.Int64;
        //                var args = new DataPortalHookArgs(cmd);
        //                OnDeletePre(args);
        //                cmd.ExecuteNonQuery();
        //                OnDeletePost(args);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        GlobalCommon.ShowErrorMessager(ex);
        //    }
        //}

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

    }
}
