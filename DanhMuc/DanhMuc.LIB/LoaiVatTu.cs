using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{
    [Serializable]
    public partial class LoaiVatTu : BusinessBase <LoaiVatTu>
    {
        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

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
        /// Maintains metadata about <see cref="TenVatTu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenVatTuProperty = RegisterProperty<string>(p => p.TenVatTu, "Ten Vat Tu");
        /// <summary>
        /// Gets or sets the Ten Vat Tu.
        /// </summary>
        /// <value>The Ten Vat Tu.</value>
        public string TenVatTu
        {
            get { return GetProperty(TenVatTuProperty); }
            set { SetProperty(TenVatTuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MaVatTu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaVatTuProperty = RegisterProperty<string>(p => p.MaVatTu, "Ma Vat Tu");
        /// <summary>
        /// Gets or sets the Ma Vat Tu.
        /// </summary>
        /// <value>The Ma Vat Tu.</value>
        public string MaVatTu
        {
            get { return GetProperty(MaVatTuProperty); }
            set { SetProperty(MaVatTuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayNhan"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayNhanProperty = RegisterProperty<SmartDate>(p => p.NgayNhan, "Ngay Nhan");
        /// <summary>
        /// Gets or sets the Ngay Nhan.
        /// </summary>
        /// <value>The Ngay Nhan.</value>
        public string NgayNhan
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayNhanProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayNhanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HieuMay"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> HieuMayProperty = RegisterProperty<string>(p => p.HieuMay, "Hieu May");
        /// <summary>
        /// Gets or sets the Hieu May.
        /// </summary>
        /// <value>The Hieu May.</value>
        public string HieuMay
        {
            get { return GetProperty(HieuMayProperty); }
            set { SetProperty(HieuMayProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SerialMay"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SerialMayProperty = RegisterProperty<string>(p => p.SerialMay, "Serial May");
        /// <summary>
        /// Gets or sets the Serial May.
        /// </summary>
        /// <value>The Serial May.</value>
        public string SerialMay
        {
            get { return GetProperty(SerialMayProperty); }
            set { SetProperty(SerialMayProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NguonKinhPhi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NguonKinhPhiProperty = RegisterProperty<string>(p => p.NguonKinhPhi, "Nguon Kinh Phi");
        /// <summary>
        /// Gets or sets the Nguon Kinh Phi.
        /// </summary>
        /// <value>The Nguon Kinh Phi.</value>
        public string NguonKinhPhi
        {
            get { return GetProperty(NguonKinhPhiProperty); }
            set { SetProperty(NguonKinhPhiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TyLeKhauHao"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TyLeKhauHaoProperty = RegisterProperty<string>(p => p.TyLeKhauHao, "Ty Le Khau Hao");
        /// <summary>
        /// Gets or sets the Ty Le Khau Hao.
        /// </summary>
        /// <value>The Ty Le Khau Hao.</value>
        public string TyLeKhauHao
        {
            get { return GetProperty(TyLeKhauHaoProperty); }
            set { SetProperty(TyLeKhauHaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TinhTrang"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TinhTrangProperty = RegisterProperty<string>(p => p.TinhTrang, "Tinh Trang");
        /// <summary>
        /// Gets or sets the Tinh Trang.
        /// </summary>
        /// <value>The Tinh Trang.</value>
        public string TinhTrang
        {
            get { return GetProperty(TinhTrangProperty); }
            set { SetProperty(TinhTrangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="XuatXu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> XuatXuProperty = RegisterProperty<string>(p => p.XuatXu, "Xuat Xu");
        /// <summary>
        /// Gets or sets the Xuat Xu.
        /// </summary>
        /// <value>The Xuat Xu.</value>
        public string XuatXu
        {
            get { return GetProperty(XuatXuProperty); }
            set { SetProperty(XuatXuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayNhap"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NgayNhapProperty = RegisterProperty<string>(p => p.NgayNhap, "Ngay Nhap");
        /// <summary>
        /// Gets or sets the Ngay Nhap.
        /// </summary>
        /// <value>The Ngay Nhap.</value>
        public string NgayNhap
        {
            get { return GetProperty(NgayNhapProperty); }
            set { SetProperty(NgayNhapProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NhanVienQuanLy"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NhanVienQuanLyProperty = RegisterProperty<string>(p => p.NhanVienQuanLy, "Nhan Vien Quan Ly");
        /// <summary>
        /// Gets or sets the Nhan Vien Quan Ly.
        /// </summary>
        /// <value>The Nhan Vien Quan Ly.</value>
        public string NhanVienQuanLy
        {
            get { return GetProperty(NhanVienQuanLyProperty); }
            set { SetProperty(NhanVienQuanLyProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ViTriDatMay"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ViTriDatMayProperty = RegisterProperty<string>(p => p.ViTriDatMay, "Vi Tri Dat May");
        /// <summary>
        /// Gets or sets the Vi Tri Dat May.
        /// </summary>
        /// <value>The Vi Tri Dat May.</value>
        public string ViTriDatMay
        {
            get { return GetProperty(ViTriDatMayProperty); }
            set { SetProperty(ViTriDatMayProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLanHong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoLanHongProperty = RegisterProperty<string>(p => p.SoLanHong, "So Lan Hong");
        /// <summary>
        /// Gets or sets the So Lan Hong.
        /// </summary>
        /// <value>The So Lan Hong.</value>
        public string SoLanHong
        {
            get { return GetProperty(SoLanHongProperty); }
            set { SetProperty(SoLanHongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="PhuKien"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> PhuKienProperty = RegisterProperty<string>(p => p.PhuKien, "Phu Kien");
        /// <summary>
        /// Gets or sets the Phu Kien.
        /// </summary>
        /// <value>The Phu Kien.</value>
        public string PhuKien
        {
            get { return GetProperty(PhuKienProperty); }
            set { SetProperty(PhuKienProperty, value); }
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
        /// Maintains metadata about <see cref="idCanBoQuanLy"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IdCanBoQuanLyProperty = RegisterProperty<Int64?>(p => p.IdCanBoQuanLy, "id Can Bo Quan Ly");
        /// <summary>
        /// Gets or sets the id Can Bo Quan Ly.
        /// </summary>
        /// <value>The id Can Bo Quan Ly.</value>
        public Int64? IdCanBoQuanLy
        {
            get { return GetProperty(IdCanBoQuanLyProperty); }
            set { SetProperty(IdCanBoQuanLyProperty, value); }
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
        /// Maintains metadata about <see cref="Khoa"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> LastEdited_UserNameProperty = RegisterProperty<string>(p => p.LastEdited_UserName, "Last edited user name");
        /// <summary>
        /// Gets or sets the Khoa.
        /// </summary>
        /// <value>The Khoa.</value>
        public string LastEdited_UserName
        {
            get { return GetProperty(LastEdited_UserNameProperty); }
            set { SetProperty(LastEdited_UserNameProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="LastEdited_Date"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> LastEdited_DateProperty = RegisterProperty<SmartDate>(p => p.LastEdited_Date, "Last Edited Date");
        /// <summary>
        /// Gets or sets the Last Edited Date.
        /// </summary>
        /// <value>The Last Edited Date.</value>
        public SmartDate LastEdited_Date
        {
            get { return GetProperty(LastEdited_DateProperty); }
            set { SetProperty(LastEdited_DateProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="Type"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TypeProperty = RegisterProperty<string>(p => p.Type, "Type");
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        /// <value>The Type.</value>
        public string Type
        {
            get { return GetProperty(TypeProperty); }
            set { SetProperty(TypeProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Backup1"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Backup1Property = RegisterProperty<string>(p => p.Backup1, "Backup1");
        /// <summary>
        /// Gets or sets the Backup1.
        /// </summary>
        /// <value>The Backup1.</value>
        public string Backup1
        {
            get { return GetProperty(Backup1Property); }
            set { SetProperty(Backup1Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="backup2"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Backup2Property = RegisterProperty<string>(p => p.Backup2, "backup2");
        /// <summary>
        /// Gets or sets the backup2.
        /// </summary>
        /// <value>The backup2.</value>
        public string Backup2
        {
            get { return GetProperty(Backup2Property); }
            set { SetProperty(Backup2Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="backup3"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Backup3Property = RegisterProperty<string>(p => p.Backup3, "backup3");
        /// <summary>
        /// Gets or sets the backup3.
        /// </summary>
        /// <value>The backup3.</value>
        public string Backup3
        {
            get { return GetProperty(Backup3Property); }
            set { SetProperty(Backup3Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="backup4"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> Backup4Property = RegisterProperty<int?>(p => p.Backup4, "backup4");
        /// <summary>
        /// Gets or sets the backup4.
        /// </summary>
        /// <value>The backup4.</value>
        public int? Backup4
        {
            get { return GetProperty(Backup4Property); }
            set { SetProperty(Backup4Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DonVi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DonViProperty = RegisterProperty<string>(p => p.DonVi, "Don Vi");
        /// <summary>
        /// Gets or sets the Don Vi.
        /// </summary>
        /// <value>The Don Vi.</value>
        public string DonVi
        {
            get { return GetProperty(DonViProperty); }
            set { SetProperty(DonViProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NamDuaVaoSuDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> NamDuaVaoSuDungProperty = RegisterProperty<int?>(p => p.NamDuaVaoSuDung, "Nam Dua Vao Su Dung");
        /// <summary>
        /// Gets or sets the Nam Dua Vao Su Dung.
        /// </summary>
        /// <value>The Nam Dua Vao Su Dung.</value>
        public int? NamDuaVaoSuDung
        {
            get { return GetProperty(NamDuaVaoSuDungProperty); }
            set { SetProperty(NamDuaVaoSuDungProperty, value); }
        }
        //public static LoaiVatTu NewLoaiVatTu()
        //{
        //    return DataPortal.Create<LoaiVatTu>();
        //}

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="LoaiVatTu"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_VatTuTaiSan"/> object.</returns>
        public static LoaiVatTu NewLoaiVatTu()
        {
            return DataPortal.Create<LoaiVatTu>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_VatTuTaiSan"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the HC_VatTuTaiSan to fetch.</param>
        /// <returns>A reference to the fetched <see cref="HC_VatTuTaiSan"/> object.</returns>
        public static LoaiVatTu GetLoaiVatTu(int id)
        {
            return DataPortal.Fetch<LoaiVatTu>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="HC_VatTuTaiSan"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the HC_VatTuTaiSan to delete.</param>
        public static void DeleteLoaiVatTu(int id)
        {
            DataPortal.Delete<LoaiVatTu>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_VatTuTaiSan"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewLoaiVatTu(EventHandler<DataPortalResult<LoaiVatTu>> callback)
        {
            DataPortal.BeginCreate<LoaiVatTu>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="HC_VatTuTaiSan"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the HC_VatTuTaiSan to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetLoaiVatTu(int id, EventHandler<DataPortalResult<LoaiVatTu>> callback)
        {
            DataPortal.BeginFetch<LoaiVatTu>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="HC_VatTuTaiSan"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the HC_VatTuTaiSan to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteLoaiVatTu(int id, EventHandler<DataPortalResult<LoaiVatTu>> callback)
        {
            DataPortal.BeginDelete<LoaiVatTu>(id, callback);
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="HC_VatTuTaiSan"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(TenVatTuProperty, null);
            LoadProperty(MaVatTuProperty, null);
            LoadProperty(NgayNhanProperty, null);
            LoadProperty(HieuMayProperty, null);
            LoadProperty(SerialMayProperty, null);
            LoadProperty(NguonKinhPhiProperty, null);
            LoadProperty(TyLeKhauHaoProperty, null);
            LoadProperty(TinhTrangProperty, null);
            LoadProperty(XuatXuProperty, null);
            LoadProperty(NgayNhapProperty, null);
            LoadProperty(NhanVienQuanLyProperty, null);
            LoadProperty(ViTriDatMayProperty, null);
            LoadProperty(SoLanHongProperty, null);
            LoadProperty(PhuKienProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(LastEdited_UserNameProperty, null);
            LoadProperty(Backup1Property, null);
            LoadProperty(Backup2Property, null);
            LoadProperty(Backup3Property, null);
            LoadProperty(TypeProperty, null);
            LoadProperty(DonViProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="HC_VatTuTaiSan"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_VatTuTaiSan_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, id);
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

        /// <summary>
        /// Loads a <see cref="HC_VatTuTaiSan"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(TenVatTuProperty, dr.GetString("TenVatTu"));
            LoadProperty(MaVatTuProperty, dr.GetString("MaVatTu"));
            LoadProperty(NgayNhanProperty, dr.GetDateTime("NgayNhan"));
            LoadProperty(HieuMayProperty, dr.GetString("HieuMay"));
            LoadProperty(SerialMayProperty, dr.GetString("SerialMay"));
            LoadProperty(NguonKinhPhiProperty, dr.GetString("NguonKinhPhi"));
            LoadProperty(TyLeKhauHaoProperty, dr.GetString("TyLeKhauHao"));
            LoadProperty(TinhTrangProperty, dr.GetString("TinhTrang"));
            LoadProperty(XuatXuProperty, dr.GetString("XuatXu"));
            LoadProperty(NgayNhapProperty, dr.GetString("NgayNhap"));
            LoadProperty(NhanVienQuanLyProperty, dr.GetString("NhanVienQuanLy"));
            LoadProperty(ViTriDatMayProperty, dr.GetString("ViTriDatMay"));
            LoadProperty(SoLanHongProperty, dr.GetString("SoLanHong"));
            LoadProperty(PhuKienProperty, dr.GetString("PhuKien"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(IdNguonKinhPhiProperty, dr.GetInt32("IdNguonKinhPhi"));
            LoadProperty(IdCanBoQuanLyProperty, dr.GetInt64("IdCanBoQuanLy"));
            LoadProperty(LastEdited_UserIDProperty, dr.GetInt64("LastEdited_UserID"));
            LoadProperty(LastEdited_DateProperty, dr.GetDateTime("LastEdited_Date"));
            LoadProperty(LastEdited_UserNameProperty, dr.GetString("LastEdited_UserName"));
            LoadProperty(TypeProperty, dr.GetString("Type"));
            LoadProperty(Backup1Property, dr.GetString("Backup1"));
            LoadProperty(Backup2Property, dr.GetString("Backup2"));
            LoadProperty(Backup3Property, dr.GetString("Backup3"));
            LoadProperty(Backup4Property, dr.GetInt32("Backup4"));
            LoadProperty(DonViProperty, dr.GetString("DonVi"));
            LoadProperty(NamDuaVaoSuDungProperty, dr.GetInt32("NamDuaVaoSuDung"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="HC_VatTuTaiSan"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.LoaiVatTu_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@TenVatTu", ReadProperty(TenVatTuProperty) == null ? (object)DBNull.Value : ReadProperty(TenVatTuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaVatTu", ReadProperty(MaVatTuProperty) == null ? (object)DBNull.Value : ReadProperty(MaVatTuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayNhan", ReadProperty(NgayNhanProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@HieuMay", ReadProperty(HieuMayProperty) == null ? (object)DBNull.Value : ReadProperty(HieuMayProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SerialMay", ReadProperty(SerialMayProperty) == null ? (object)DBNull.Value : ReadProperty(SerialMayProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NguonKinhPhi", ReadProperty(NguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(NguonKinhPhiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TyLeKhauHao", ReadProperty(TyLeKhauHaoProperty) == null ? (object)DBNull.Value : ReadProperty(TyLeKhauHaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TinhTrang", ReadProperty(TinhTrangProperty) == null ? (object)DBNull.Value : ReadProperty(TinhTrangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatXu", ReadProperty(XuatXuProperty) == null ? (object)DBNull.Value : ReadProperty(XuatXuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayNhap", ReadProperty(NgayNhapProperty) == null ? (object)DBNull.Value : ReadProperty(NgayNhapProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NhanVienQuanLy", ReadProperty(NhanVienQuanLyProperty) == null ? (object)DBNull.Value : ReadProperty(NhanVienQuanLyProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ViTriDatMay", ReadProperty(ViTriDatMayProperty) == null ? (object)DBNull.Value : ReadProperty(ViTriDatMayProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoLanHong", ReadProperty(SoLanHongProperty) == null ? (object)DBNull.Value : ReadProperty(SoLanHongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@PhuKien", ReadProperty(PhuKienProperty) == null ? (object)DBNull.Value : ReadProperty(PhuKienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idCanBoQuanLy", ReadProperty(IdCanBoQuanLyProperty) == null ? (object)DBNull.Value : ReadProperty(IdCanBoQuanLyProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@Type", ReadProperty(TypeProperty) == null ? (object)DBNull.Value : ReadProperty(TypeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup1", ReadProperty(Backup1Property) == null ? (object)DBNull.Value : ReadProperty(Backup1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup2", ReadProperty(Backup2Property) == null ? (object)DBNull.Value : ReadProperty(Backup2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup3", ReadProperty(Backup3Property) == null ? (object)DBNull.Value : ReadProperty(Backup3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup4", ReadProperty(Backup4Property) == null ? (object)DBNull.Value : ReadProperty(Backup4Property).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DonVi", ReadProperty(DonViProperty) == null ? (object)DBNull.Value : ReadProperty(DonViProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NamDuaVaoSuDung", ReadProperty(NamDuaVaoSuDungProperty) == null ? (object)DBNull.Value : ReadProperty(NamDuaVaoSuDungProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (int)cmd.Parameters["@ID"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_VatTuTaiSan"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.LoaiVatTu_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TenVatTu", ReadProperty(TenVatTuProperty) == null ? (object)DBNull.Value : ReadProperty(TenVatTuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaVatTu", ReadProperty(MaVatTuProperty) == null ? (object)DBNull.Value : ReadProperty(MaVatTuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayNhan", ReadProperty(NgayNhanProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@HieuMay", ReadProperty(HieuMayProperty) == null ? (object)DBNull.Value : ReadProperty(HieuMayProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SerialMay", ReadProperty(SerialMayProperty) == null ? (object)DBNull.Value : ReadProperty(SerialMayProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NguonKinhPhi", ReadProperty(NguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(NguonKinhPhiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TyLeKhauHao", ReadProperty(TyLeKhauHaoProperty) == null ? (object)DBNull.Value : ReadProperty(TyLeKhauHaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TinhTrang", ReadProperty(TinhTrangProperty) == null ? (object)DBNull.Value : ReadProperty(TinhTrangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatXu", ReadProperty(XuatXuProperty) == null ? (object)DBNull.Value : ReadProperty(XuatXuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayNhap", ReadProperty(NgayNhapProperty) == null ? (object)DBNull.Value : ReadProperty(NgayNhapProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NhanVienQuanLy", ReadProperty(NhanVienQuanLyProperty) == null ? (object)DBNull.Value : ReadProperty(NhanVienQuanLyProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ViTriDatMay", ReadProperty(ViTriDatMayProperty) == null ? (object)DBNull.Value : ReadProperty(ViTriDatMayProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoLanHong", ReadProperty(SoLanHongProperty) == null ? (object)DBNull.Value : ReadProperty(SoLanHongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@PhuKien", ReadProperty(PhuKienProperty) == null ? (object)DBNull.Value : ReadProperty(PhuKienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idCanBoQuanLy", ReadProperty(IdCanBoQuanLyProperty) == null ? (object)DBNull.Value : ReadProperty(IdCanBoQuanLyProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@Type", ReadProperty(TypeProperty) == null ? (object)DBNull.Value : ReadProperty(TypeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup1", ReadProperty(Backup1Property) == null ? (object)DBNull.Value : ReadProperty(Backup1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup2", ReadProperty(Backup2Property) == null ? (object)DBNull.Value : ReadProperty(Backup2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup3", ReadProperty(Backup3Property) == null ? (object)DBNull.Value : ReadProperty(Backup3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup4", ReadProperty(Backup4Property) == null ? (object)DBNull.Value : ReadProperty(Backup4Property).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DonVi", ReadProperty(DonViProperty) == null ? (object)DBNull.Value : ReadProperty(DonViProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NamDuaVaoSuDung", ReadProperty(NamDuaVaoSuDungProperty) == null ? (object)DBNull.Value : ReadProperty(NamDuaVaoSuDungProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="HC_VatTuTaiSan"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="HC_VatTuTaiSan"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.LoaiVatTu_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, id);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
                ctx.Commit();
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
