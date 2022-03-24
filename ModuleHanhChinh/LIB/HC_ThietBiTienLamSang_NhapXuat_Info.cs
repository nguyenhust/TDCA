//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_ThietBiTienLamSang_NhapXuat_Info
// ObjectType:  HC_ThietBiTienLamSang_NhapXuat_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{

    /// <summary>
    /// HC_ThietBiTienLamSang_NhapXuat_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="HC_ThietBiTienLamSang_NhapXuat_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class HC_ThietBiTienLamSang_NhapXuat_Info : BusinessBase<HC_ThietBiTienLamSang_NhapXuat_Info>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="NhapSoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> NhapSoLuongProperty = RegisterProperty<int?>(p => p.NhapSoLuong, "Nhap So Luong");
        /// <summary>
        /// Gets or sets the Nhap So Luong.
        /// </summary>
        /// <value>The Nhap So Luong.</value>
        public int? NhapSoLuong
        {
            get { return GetProperty(NhapSoLuongProperty); }
            set { SetProperty(NhapSoLuongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NhapNgay"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NhapNgayProperty = RegisterProperty<SmartDate>(p => p.NhapNgay, "Nhap Ngay");
        /// <summary>
        /// Gets or sets the Nhap Ngay.
        /// </summary>
        /// <value>The Nhap Ngay.</value>
        public string NhapNgay
        {
            get { return GetPropertyConvert<SmartDate, String>(NhapNgayProperty); }
            set { SetPropertyConvert<SmartDate, String>(NhapNgayProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="XuatNgay"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> XuatNgayProperty = RegisterProperty<SmartDate>(p => p.XuatNgay, "Xuat Ngay");
        /// <summary>
        /// Gets or sets the Xuat Ngay.
        /// </summary>
        /// <value>The Xuat Ngay.</value>
        public string XuatNgay
        {
            get { return GetPropertyConvert<SmartDate, String>(XuatNgayProperty); }
            set { SetPropertyConvert<SmartDate, String>(XuatNgayProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idNguonKinhPhi"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdNguonKinhPhiProperty = RegisterProperty<int?>(p => p.IdNguonKinhPhi, "id Nguon Kinh Phi");
        /// <summary>
        /// Gets or sets the id Nguon Kinh Phi.
        /// </summary>
        /// <value>The id Nguon Kinh Phi.</value>
        public int? IdNguonKinhPhi
        {
            get { return GetProperty(IdNguonKinhPhiProperty); }
            set { SetProperty(IdNguonKinhPhiProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="NhapNguonKinhPhi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenThietBiProperty = RegisterProperty<string>(p => p.TenThietBi, "Ten Thiet Bi");
        /// <summary>
        /// Gets or sets the Nhap Nguon Kinh Phi.
        /// </summary>
        /// <value>The Nhap Nguon Kinh Phi.</value>
        public string TenThietBi
        {
            get { return GetProperty(TenThietBiProperty); }
            set { SetProperty(TenThietBiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NhapNoiCungCap"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NhapNoiCungCapProperty = RegisterProperty<string>(p => p.NhapNoiCungCap, "Nhap Noi Cung Cap");
        /// <summary>
        /// Gets or sets the Nhap Noi Cung Cap.
        /// </summary>
        /// <value>The Nhap Noi Cung Cap.</value>
        public string NhapNoiCungCap
        {
            get { return GetProperty(NhapNoiCungCapProperty); }
            set { SetProperty(NhapNoiCungCapProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NhapDonGia"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NhapDonGiaProperty = RegisterProperty<string>(p => p.NhapDonGia, "Nhap Don Gia");
        /// <summary>
        /// Gets or sets the Nhap Don Gia.
        /// </summary>
        /// <value>The Nhap Don Gia.</value>
        public string NhapDonGia
        {
            get { return GetProperty(NhapDonGiaProperty); }
            set { SetProperty(NhapDonGiaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="XuatSoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> XuatSoLuongProperty = RegisterProperty<int?>(p => p.XuatSoLuong, "Xuat So Luong");
        /// <summary>
        /// Gets or sets the Xuat So Luong.
        /// </summary>
        /// <value>The Xuat So Luong.</value>
        public int? XuatSoLuong
        {
            get { return GetProperty(XuatSoLuongProperty); }
            set { SetProperty(XuatSoLuongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="XuatLyDo"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> XuatLyDoProperty = RegisterProperty<string>(p => p.XuatLyDo, "Xuat Ly Do");
        /// <summary>
        /// Gets or sets the Xuat Ly Do.
        /// </summary>
        /// <value>The Xuat Ly Do.</value>
        public string XuatLyDo
        {
            get { return GetProperty(XuatLyDoProperty); }
            set { SetProperty(XuatLyDoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="XuatDoiTuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> XuatDoiTuongProperty = RegisterProperty<string>(p => p.XuatDoiTuong, "Xuat Doi Tuong");
        /// <summary>
        /// Gets or sets the Xuat Doi Tuong.
        /// </summary>
        /// <value>The Xuat Doi Tuong.</value>
        public string XuatDoiTuong
        {
            get { return GetProperty(XuatDoiTuongProperty); }
            set { SetProperty(XuatDoiTuongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="XuatDonGia"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> XuatDonGiaProperty = RegisterProperty<string>(p => p.XuatDonGia, "Xuat Don Gia");
        /// <summary>
        /// Gets or sets the Xuat Don Gia.
        /// </summary>
        /// <value>The Xuat Don Gia.</value>
        public string XuatDonGia
        {
            get { return GetProperty(XuatDonGiaProperty); }
            set { SetProperty(XuatDonGiaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IDProperty = RegisterProperty<int>(p => p.ID, "ID");
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public int ID
        {
            get { return GetProperty(IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idThietBi"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdThietBiProperty = RegisterProperty<int?>(p => p.IdThietBi, "id Thiet Bi");
        /// <summary>
        /// Gets or sets the id Thiet Bi.
        /// </summary>
        /// <value>The id Thiet Bi.</value>
        public int? IdThietBi
        {
            get { return GetProperty(IdThietBiProperty); }
            set { SetProperty(IdThietBiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="LastEdited_UserID"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> LastEdited_UserIDProperty = RegisterProperty<Int64?>(p => p.LastEdited_UserID, "Last Edited User ID");
        /// <summary>
        /// Gets or sets the Last Edited User ID.
        /// </summary>
        /// <value>The Last Edited User ID.</value>
        public Int64? LastEdited_UserID
        {
            get { return GetProperty(LastEdited_UserIDProperty); }
            set { SetProperty(LastEdited_UserIDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="LastEdited_Date"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> LastEdited_DateProperty = RegisterProperty<SmartDate>(p => p.LastEdited_Date, "Last Edited Date");
        /// <summary>
        /// Gets or sets the Last Edited Date.
        /// </summary>
        /// <value>The Last Edited Date.</value>
        public string LastEdited_Date
        {
            get { return GetPropertyConvert<SmartDate, String>(LastEdited_DateProperty); }
            set { SetPropertyConvert<SmartDate, String>(LastEdited_DateProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Backup01"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Backup01Property = RegisterProperty<string>(p => p.Backup01, "Backup01");
        /// <summary>
        /// Gets or sets the Backup01.
        /// </summary>
        /// <value>The Backup01.</value>
        public string Backup01
        {
            get { return GetProperty(Backup01Property); }
            set { SetProperty(Backup01Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Backup02"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Backup02Property = RegisterProperty<string>(p => p.Backup02, "Backup02");
        /// <summary>
        /// Gets or sets the Backup02.
        /// </summary>
        /// <value>The Backup02.</value>
        public string Backup02
        {
            get { return GetProperty(Backup02Property); }
            set { SetProperty(Backup02Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Backup03"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> Backup03Property = RegisterProperty<int?>(p => p.Backup03, "Backup03");
        /// <summary>
        /// Gets or sets the Backup03.
        /// </summary>
        /// <value>The Backup03.</value>
        public int? Backup03
        {
            get { return GetProperty(Backup03Property); }
            set { SetProperty(Backup03Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Backup04"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> Backup04Property = RegisterProperty<int?>(p => p.Backup04, "Backup04");
        /// <summary>
        /// Gets or sets the Backup04.
        /// </summary>
        /// <value>The Backup04.</value>
        public int? Backup04
        {
            get { return GetProperty(Backup04Property); }
            set { SetProperty(Backup04Property, value); }
        }

        public DateTime DateNgayNhap
        {
            get { return GetProperty(NhapNgayProperty); }
        }
        public DateTime DateNgayXuat
        {
            get { return GetProperty(XuatNgayProperty); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="XuatSoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SoLuongTonProperty = RegisterProperty<int?>(p => p.SoLuongTon, "So Luong Ton");
        /// <summary>
        /// Gets or sets the Xuat So Luong.
        /// </summary>
        /// <value>The Xuat So Luong.</value>
        public int? SoLuongTon
        {
            get { return GetProperty(SoLuongTonProperty); }
            set { SetProperty(SoLuongTonProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="XuatSoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> TongNhapProperty = RegisterProperty<int?>(p => p.TongNhap, "Tong Nhap");
        /// <summary>
        /// Gets or sets the Xuat So Luong.
        /// </summary>
        /// <value>The Xuat So Luong.</value>
        public int? TongNhap
        {
            get { return GetProperty(TongNhapProperty); }
            set { SetProperty(TongNhapProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="XuatSoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> TongXuatProperty = RegisterProperty<int?>(p => p.TongXuat, "Tong Xuat");
        /// <summary>
        /// Gets or sets the Xuat So Luong.
        /// </summary>
        /// <value>The Xuat So Luong.</value>
        public int? TongXuat
        {
            get { return GetProperty(TongXuatProperty); }
            set { SetProperty(TongXuatProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="XuatDoiTuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenNguonKinhPhiProperty = RegisterProperty<string>(p => p.TenNguonKinhPhi, "Ten Nguon Kinh Phi");
        /// <summary>
        /// Gets or sets the Xuat Doi Tuong.
        /// </summary>
        /// <value>The Xuat Doi Tuong.</value>
        public string TenNguonKinhPhi
        {
            get { return GetProperty(TenNguonKinhPhiProperty); }
            set { SetProperty(TenNguonKinhPhiProperty, value); }
        }
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object.</returns>
        internal static HC_ThietBiTienLamSang_NhapXuat_Info NewHC_ThietBiTienLamSang_NhapXuat_Info()
        {
            return DataPortal.CreateChild<HC_ThietBiTienLamSang_NhapXuat_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewHC_ThietBiTienLamSang_NhapXuat_Info(EventHandler<DataPortalResult<HC_ThietBiTienLamSang_NhapXuat_Info>> callback)
        {
            DataPortal.BeginCreate<HC_ThietBiTienLamSang_NhapXuat_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object.</returns>
        internal static HC_ThietBiTienLamSang_NhapXuat_Info GetHC_ThietBiTienLamSang_NhapXuat_Info(SafeDataReader dr,BusinessFunction function)
        {
            HC_ThietBiTienLamSang_NhapXuat_Info obj = new HC_ThietBiTienLamSang_NhapXuat_Info();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr,function);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_ThietBiTienLamSang_NhapXuat_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(NhapNgayProperty, null);
            LoadProperty(XuatNgayProperty, null);
            LoadProperty(NhapNoiCungCapProperty, null);
            LoadProperty(NhapDonGiaProperty, null);
            LoadProperty(XuatLyDoProperty, null);
            LoadProperty(XuatDoiTuongProperty, null);
            LoadProperty(XuatDonGiaProperty, null);
            LoadProperty(TenThietBiProperty, null);
            LoadProperty(TenNguonKinhPhiProperty, null);
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(Backup01Property, null);
            LoadProperty(Backup02Property, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr, BusinessFunction function)
        {
            if (function.Mode == BusinessFunctionMode.GetDataForGridViewWithCondition3)
            {

                LoadProperty(TenThietBiProperty, dr.GetString("TenThietBi"));
                LoadProperty(SoLuongTonProperty, dr.GetInt32("SoLuong"));
                LoadProperty(TongNhapProperty, dr.GetInt32("TongNhap"));
                LoadProperty(TongXuatProperty, dr.GetInt32("TongXuat"));
            }
            else
            {
                // Value properties
                LoadProperty(NhapSoLuongProperty, dr.GetInt32("NhapSoLuong"));
                LoadProperty(NhapNgayProperty, dr.GetSmartDate("NhapNgay"));
                LoadProperty(XuatNgayProperty, dr.GetSmartDate("XuatNgay"));
                LoadProperty(IdNguonKinhPhiProperty, dr.GetInt32("idNguonKinhPhi"));
                LoadProperty(NhapNoiCungCapProperty, dr.GetString("NhapNoiCungCap"));
                LoadProperty(NhapDonGiaProperty, dr.GetString("NhapDonGia"));
                LoadProperty(XuatSoLuongProperty, dr.GetInt32("XuatSoLuong"));
                LoadProperty(XuatLyDoProperty, dr.GetString("XuatLyDo"));
                LoadProperty(XuatDoiTuongProperty, dr.GetString("XuatDoiTuong"));
                LoadProperty(XuatDonGiaProperty, dr.GetString("XuatDonGia"));
                LoadProperty(IDProperty, dr.GetInt32("ID"));
                LoadProperty(IdThietBiProperty, dr.GetInt32("IdThietBi"));
                LoadProperty(LastEdited_UserIDProperty, dr.GetInt64("LastEdited_UserID"));
                LoadProperty(LastEdited_DateProperty, dr.GetSmartDate("LastEdited_Date"));
                LoadProperty(Backup01Property, dr.GetString("Backup01"));
                LoadProperty(Backup02Property, dr.GetString("Backup02"));
                LoadProperty(Backup03Property, dr.GetInt32("Backup03"));
                LoadProperty(Backup04Property, dr.GetInt32("Backup04"));
                LoadProperty(TenNguonKinhPhiProperty, dr.GetString("TenNguonKinhPhi"));
                LoadProperty(TenThietBiProperty, dr.GetString("TenThietBi"));
            }
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_ThietBiTienLamSang_NhapXuat_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NhapSoLuong", ReadProperty(NhapSoLuongProperty) == null ? (object)DBNull.Value : ReadProperty(NhapSoLuongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NhapNgay", ReadProperty(NhapNgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@XuatNgay", ReadProperty(XuatNgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@idNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NhapNoiCungCap", ReadProperty(NhapNoiCungCapProperty) == null ? (object)DBNull.Value : ReadProperty(NhapNoiCungCapProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NhapDonGia", ReadProperty(NhapDonGiaProperty) == null ? (object)DBNull.Value : ReadProperty(NhapDonGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatSoLuong", ReadProperty(XuatSoLuongProperty) == null ? (object)DBNull.Value : ReadProperty(XuatSoLuongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@XuatLyDo", ReadProperty(XuatLyDoProperty) == null ? (object)DBNull.Value : ReadProperty(XuatLyDoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatDoiTuong", ReadProperty(XuatDoiTuongProperty) == null ? (object)DBNull.Value : ReadProperty(XuatDoiTuongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatDonGia", ReadProperty(XuatDonGiaProperty) == null ? (object)DBNull.Value : ReadProperty(XuatDonGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idThietBi", ReadProperty(IdThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(IdThietBiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@Backup01", ReadProperty(Backup01Property) == null ? (object)DBNull.Value : ReadProperty(Backup01Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup02", ReadProperty(Backup02Property) == null ? (object)DBNull.Value : ReadProperty(Backup02Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup03", ReadProperty(Backup03Property) == null ? (object)DBNull.Value : ReadProperty(Backup03Property).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Backup04", ReadProperty(Backup04Property) == null ? (object)DBNull.Value : ReadProperty(Backup04Property).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (int) cmd.Parameters["@ID"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_ThietBiTienLamSang_NhapXuat_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NhapSoLuong", ReadProperty(NhapSoLuongProperty) == null ? (object)DBNull.Value : ReadProperty(NhapSoLuongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NhapNgay", ReadProperty(NhapNgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@XuatNgay", ReadProperty(XuatNgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@idNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NhapNoiCungCap", ReadProperty(NhapNoiCungCapProperty) == null ? (object)DBNull.Value : ReadProperty(NhapNoiCungCapProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NhapDonGia", ReadProperty(NhapDonGiaProperty) == null ? (object)DBNull.Value : ReadProperty(NhapDonGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatSoLuong", ReadProperty(XuatSoLuongProperty) == null ? (object)DBNull.Value : ReadProperty(XuatSoLuongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@XuatLyDo", ReadProperty(XuatLyDoProperty) == null ? (object)DBNull.Value : ReadProperty(XuatLyDoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatDoiTuong", ReadProperty(XuatDoiTuongProperty) == null ? (object)DBNull.Value : ReadProperty(XuatDoiTuongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatDonGia", ReadProperty(XuatDonGiaProperty) == null ? (object)DBNull.Value : ReadProperty(XuatDonGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idThietBi", ReadProperty(IdThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(IdThietBiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@Backup01", ReadProperty(Backup01Property) == null ? (object)DBNull.Value : ReadProperty(Backup01Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup02", ReadProperty(Backup02Property) == null ? (object)DBNull.Value : ReadProperty(Backup02Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup03", ReadProperty(Backup03Property) == null ? (object)DBNull.Value : ReadProperty(Backup03Property).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Backup04", ReadProperty(Backup04Property) == null ? (object)DBNull.Value : ReadProperty(Backup04Property).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="HC_ThietBiTienLamSang_NhapXuat_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_ThietBiTienLamSang_NhapXuat_Info_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
            }
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

    }
}
