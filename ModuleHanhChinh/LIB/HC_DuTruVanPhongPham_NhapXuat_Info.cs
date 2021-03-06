//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_DuTruVanPhongPham_NhapXuat_Info
// ObjectType:  HC_DuTruVanPhongPham_NhapXuat_Info
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
    /// HC_DuTruVanPhongPham_NhapXuat_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="HC_DuTruVanPhongPham_NhapXuat_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class HC_DuTruVanPhongPham_NhapXuat_Info : BusinessBase<HC_DuTruVanPhongPham_NhapXuat_Info>
    {

        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDProperty = RegisterProperty<Int64>(p => p.ID, "ID");
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID
        {
            get { return GetProperty(IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuongYeuCau"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SoLuongYeuCauProperty = RegisterProperty<int?>(p => p.SoLuongYeuCau, "So Luong Yeu Cau");
        /// <summary>
        /// Gets or sets the So Luong Yeu Cau.
        /// </summary>
        /// <value>The So Luong Yeu Cau.</value>
        public int? SoLuongYeuCau
        {
            get { return GetProperty(SoLuongYeuCauProperty); }
            set { SetProperty(SoLuongYeuCauProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idCanBoGuiYeuCau"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IdCanBoGuiYeuCauProperty = RegisterProperty<Int64?>(p => p.IdCanBoGuiYeuCau, "id Can Bo Gui Yeu Cau");
        /// <summary>
        /// Gets or sets the id Can Bo Gui Yeu Cau.
        /// </summary>
        /// <value>The id Can Bo Gui Yeu Cau.</value>
        public Int64? IdCanBoGuiYeuCau
        {
            get { return GetProperty(IdCanBoGuiYeuCauProperty); }
            set { SetProperty(IdCanBoGuiYeuCauProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idChucVu"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdChucVuProperty = RegisterProperty<int?>(p => p.IdChucVu, "id Chuc Vu");
        /// <summary>
        /// Gets or sets the id Chuc Vu.
        /// </summary>
        /// <value>The id Chuc Vu.</value>
        public int? IdChucVu
        {
            get { return GetProperty(IdChucVuProperty); }
            set { SetProperty(IdChucVuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NoiDungSuDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDungSuDungProperty = RegisterProperty<string>(p => p.NoiDungSuDung, "Noi Dung Su Dung");
        /// <summary>
        /// Gets or sets the Noi Dung Su Dung.
        /// </summary>
        /// <value>The Noi Dung Su Dung.</value>
        public string NoiDungSuDung
        {
            get { return GetProperty(NoiDungSuDungProperty); }
            set { SetProperty(NoiDungSuDungProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GhiChu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GhiChuProperty = RegisterProperty<string>(p => p.GhiChu, "Ghi Chu");
        /// <summary>
        /// Gets or sets the Ghi Chu.
        /// </summary>
        /// <value>The Ghi Chu.</value>
        public string GhiChu
        {
            get { return GetProperty(GhiChuProperty); }
            set { SetProperty(GhiChuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DaDuocCap"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool?> DaDuocCapProperty = RegisterProperty<bool?>(p => p.DaDuocCap, "Da Duoc Cap");
        /// <summary>
        /// Gets or sets the Da Duoc Cap.
        /// </summary>
        /// <value><c>true</c> if Da Duoc Cap; <c>false</c> if not Da Duoc Cap; otherwise, <c>null</c>.</value>
        public bool? DaDuocCap
        {
            get { return GetProperty(DaDuocCapProperty); }
            set { SetProperty(DaDuocCapProperty, value); }
        }

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
        public DateTime DateNhap
        {
            get { return GetProperty(NhapNgayProperty); }
        }
        public DateTime DateXuat
        {
            get { return GetProperty(XuatNgayProperty); }
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
        /// Maintains metadata about <see cref="XuatDoiTuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenThietBiProperty = RegisterProperty<string>(p => p.TenThietBi, "Ten Thiet Bi");
        /// <summary>
        /// Gets or sets the Xuat Doi Tuong.
        /// </summary>
        /// <value>The Xuat Doi Tuong.</value>
        public string TenThietBi
        {
            get { return GetProperty(TenThietBiProperty); }
            set { SetProperty(TenThietBiProperty, value); }
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
        /// <summary>
        /// Maintains metadata about <see cref="XuatDoiTuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenBoPhanProperty = RegisterProperty<string>(p => p.TenBoPhan, "Ten Bo Phan");
        /// <summary>
        /// Gets or sets the Xuat Doi Tuong.
        /// </summary>
        /// <value>The Xuat Doi Tuong.</value>
        public string TenBoPhan
        {
            get { return GetProperty(TenBoPhanProperty); }
            set { SetProperty(TenBoPhanProperty, value); }
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
        /// Maintains metadata about <see cref="IdBoPhan"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdBoPhanProperty = RegisterProperty<int?>(p => p.IdBoPhan, "Id Bo Phan");
        /// <summary>
        /// Gets or sets the Id Bo Phan.
        /// </summary>
        /// <value>The Id Bo Phan.</value>
        public int? IdBoPhan
        {
            get { return GetProperty(IdBoPhanProperty); }
            set { SetProperty(IdBoPhanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="type"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> TypeProperty = RegisterProperty<int?>(p => p.Type, "type");
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public int? Type
        {
            get { return GetProperty(TypeProperty); }
            set { SetProperty(TypeProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object.</returns>
        internal static HC_DuTruVanPhongPham_NhapXuat_Info NewHC_DuTruVanPhongPham_NhapXuat_Info()
        {
            return DataPortal.CreateChild<HC_DuTruVanPhongPham_NhapXuat_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewHC_DuTruVanPhongPham_NhapXuat_Info(EventHandler<DataPortalResult<HC_DuTruVanPhongPham_NhapXuat_Info>> callback)
        {
            DataPortal.BeginCreate<HC_DuTruVanPhongPham_NhapXuat_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object.</returns>
        internal static HC_DuTruVanPhongPham_NhapXuat_Info GetHC_DuTruVanPhongPham_NhapXuat_Info(SafeDataReader dr, BusinessFunction function)
        {
            HC_DuTruVanPhongPham_NhapXuat_Info obj = new HC_DuTruVanPhongPham_NhapXuat_Info();
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
        /// Initializes a new instance of the <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_DuTruVanPhongPham_NhapXuat_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(NoiDungSuDungProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(NhapNgayProperty, null);
            LoadProperty(XuatNgayProperty, null);
            LoadProperty(NhapNoiCungCapProperty, null);
            LoadProperty(NhapDonGiaProperty, null);
            LoadProperty(XuatLyDoProperty, null);
            LoadProperty(XuatDoiTuongProperty, null);
            LoadProperty(XuatDonGiaProperty, null);
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(TenThietBiProperty, null);
            LoadProperty(TenBoPhanProperty, null);
            LoadProperty(TenNguonKinhPhiProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr,BusinessFunction function)
        {
            // Value properties
            if (function.Mode == BusinessFunctionMode.GetDataForGridViewWithCondition3)
            {

                LoadProperty(TenThietBiProperty, dr.GetString("TenThietBi"));
                LoadProperty(SoLuongTonProperty, dr.GetInt32("SoLuong"));
                LoadProperty(TongNhapProperty, dr.GetInt32("TongNhap"));
                LoadProperty(TongXuatProperty, dr.GetInt32("TongXuat"));
            }
            else
            {
                LoadProperty(IDProperty, dr.GetInt64("ID"));
                LoadProperty(SoLuongYeuCauProperty, dr.GetInt32("SoLuongYeuCau"));
                LoadProperty(IdCanBoGuiYeuCauProperty, dr.GetInt64("IdCanBoGuiYeuCau"));
                LoadProperty(IdChucVuProperty, dr.GetInt32("IdChucVu"));
                LoadProperty(NoiDungSuDungProperty, dr.GetString("NoiDungSuDung"));
                LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
                LoadProperty(DaDuocCapProperty, dr.GetBoolean("DaDuocCap"));
                LoadProperty(NhapSoLuongProperty, dr.GetInt32("NhapSoLuong"));
                LoadProperty(NhapNgayProperty, dr.GetSmartDate("NhapNgay"));
                LoadProperty(XuatNgayProperty, dr.GetSmartDate("XuatNgay"));
                LoadProperty(IdNguonKinhPhiProperty, dr.GetInt32("IdNguonKinhPhi"));
                LoadProperty(NhapNoiCungCapProperty, dr.GetString("NhapNoiCungCap"));
                LoadProperty(NhapDonGiaProperty, dr.GetString("NhapDonGia"));
                LoadProperty(XuatSoLuongProperty, dr.GetInt32("XuatSoLuong"));
                LoadProperty(XuatLyDoProperty, dr.GetString("XuatLyDo"));
                LoadProperty(XuatDoiTuongProperty, dr.GetString("XuatDoiTuong"));
                LoadProperty(XuatDonGiaProperty, dr.GetString("XuatDonGia"));
                LoadProperty(IdThietBiProperty, dr.GetInt32("IdThietBi"));
                LoadProperty(LastEdited_UserIDProperty, dr.GetInt64("LastEdited_UserID"));
                LoadProperty(LastEdited_DateProperty, dr.GetSmartDate("LastEdited_Date"));
                LoadProperty(IdBoPhanProperty, dr.GetInt32("IdBoPhan"));
                LoadProperty(TypeProperty, dr.GetInt32("Type"));
                LoadProperty(TenBoPhanProperty, dr.GetString("TenBoPhan"));
                LoadProperty(TenNguonKinhPhiProperty, dr.GetString("TenNguonKinhPhi"));
                LoadProperty(TenThietBiProperty, dr.GetString("TenThietBi"));
            }
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_DuTruVanPhongPham_NhapXuat_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@SoLuongYeuCau", ReadProperty(SoLuongYeuCauProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongYeuCauProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idCanBoGuiYeuCau", ReadProperty(IdCanBoGuiYeuCauProperty) == null ? (object)DBNull.Value : ReadProperty(IdCanBoGuiYeuCauProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@idChucVu", ReadProperty(IdChucVuProperty) == null ? (object)DBNull.Value : ReadProperty(IdChucVuProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NoiDungSuDung", ReadProperty(NoiDungSuDungProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungSuDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DaDuocCap", ReadProperty(DaDuocCapProperty) == null ? (object)DBNull.Value : ReadProperty(DaDuocCapProperty).Value).DbType = DbType.Boolean;
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
                    cmd.Parameters.AddWithValue("@idThietBi", ReadProperty(IdThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(IdThietBiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@IdBoPhan", ReadProperty(IdBoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(IdBoPhanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@type", ReadProperty(TypeProperty) == null ? (object)DBNull.Value : ReadProperty(TypeProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (long) cmd.Parameters["@ID"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_DuTruVanPhongPham_NhapXuat_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@SoLuongYeuCau", ReadProperty(SoLuongYeuCauProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongYeuCauProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idCanBoGuiYeuCau", ReadProperty(IdCanBoGuiYeuCauProperty) == null ? (object)DBNull.Value : ReadProperty(IdCanBoGuiYeuCauProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@idChucVu", ReadProperty(IdChucVuProperty) == null ? (object)DBNull.Value : ReadProperty(IdChucVuProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NoiDungSuDung", ReadProperty(NoiDungSuDungProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungSuDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DaDuocCap", ReadProperty(DaDuocCapProperty) == null ? (object)DBNull.Value : ReadProperty(DaDuocCapProperty).Value).DbType = DbType.Boolean;
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
                    cmd.Parameters.AddWithValue("@idThietBi", ReadProperty(IdThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(IdThietBiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@IdBoPhan", ReadProperty(IdBoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(IdBoPhanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@type", ReadProperty(TypeProperty) == null ? (object)DBNull.Value : ReadProperty(TypeProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="HC_DuTruVanPhongPham_NhapXuat_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_DuTruVanPhongPham_NhapXuat_Info_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
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
