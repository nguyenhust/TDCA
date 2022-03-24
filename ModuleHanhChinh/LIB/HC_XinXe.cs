//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_XinXe
// ObjectType:  HC_XinXe
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
namespace ModuleHanhChinh.LIB
{

    /// <summary>
    /// HC_XinXe (editable root object).<br/>
    /// This is a generated base class of <see cref="HC_XinXe"/> business object.
    /// </summary>
    [Serializable]
    public partial class HC_XinXe : BusinessBase<HC_XinXe>
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
        /// Maintains metadata about <see cref="CanBoDangKi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> CanBoDangKiProperty = RegisterProperty<string>(p => p.CanBoDangKi, "Can Bo Dang Ki");
        /// <summary>
        /// Gets or sets the Can Bo Dang Ki.
        /// </summary>
        /// <value>The Can Bo Dang Ki.</value>
        public string CanBoDangKi
        {
            get { return GetProperty(CanBoDangKiProperty); }
            set { SetProperty(CanBoDangKiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idCanBoDangKi"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IdCanBoDangKiProperty = RegisterProperty<Int64?>(p => p.IdCanBoDangKi, "id Can Bo Dang Ki");
        /// <summary>
        /// Gets or sets the id Can Bo Dang Ki.
        /// </summary>
        /// <value>The id Can Bo Dang Ki.</value>
        public Int64? IdCanBoDangKi
        {
            get { return GetProperty(IdCanBoDangKiProperty); }
            set { SetProperty(IdCanBoDangKiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChucVu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChucVuProperty = RegisterProperty<string>(p => p.ChucVu, "Chuc Vu");
        /// <summary>
        /// Gets or sets the Chuc Vu.
        /// </summary>
        /// <value>The Chuc Vu.</value>
        public string ChucVu
        {
            get { return GetProperty(ChucVuProperty); }
            set { SetProperty(ChucVuProperty, value); }
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
        /// Maintains metadata about <see cref="Khoa"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> KhoaProperty = RegisterProperty<string>(p => p.Khoa, "Khoa");
        /// <summary>
        /// Gets or sets the Khoa.
        /// </summary>
        /// <value>The Khoa.</value>
        public string Khoa
        {
            get { return GetProperty(KhoaProperty); }
            set { SetProperty(KhoaProperty, value); }
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
        /// Maintains metadata about <see cref="idKhoa"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdKhoaProperty = RegisterProperty<int?>(p => p.IdKhoa, "id Khoa");
        /// <summary>
        /// Gets or sets the id Khoa.
        /// </summary>
        /// <value>The id Khoa.</value>
        public int? IdKhoa
        {
            get { return GetProperty(IdKhoaProperty); }
            set { SetProperty(IdKhoaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="BienSoXe"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> BienSoXeProperty = RegisterProperty<string>(p => p.BienSoXe, "Bien So Xe");
        /// <summary>
        /// Gets or sets the Bien So Xe.
        /// </summary>
        /// <value>The Bien So Xe.</value>
        public string BienSoXe
        {
            get { return GetProperty(BienSoXeProperty); }
            set { SetProperty(BienSoXeProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoChuyen"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoChuyenProperty = RegisterProperty<string>(p => p.SoChuyen, "So Chuyen");
        /// <summary>
        /// Gets or sets the So Chuyen.
        /// </summary>
        /// <value>The So Chuyen.</value>
        public string SoChuyen
        {
            get { return GetProperty(SoChuyenProperty); }
            set { SetProperty(SoChuyenProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NoiDen"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDenProperty = RegisterProperty<string>(p => p.NoiDen, "Noi Den");
        /// <summary>
        /// Gets or sets the Noi Den.
        /// </summary>
        /// <value>The Noi Den.</value>
        public string NoiDen
        {
            get { return GetProperty(NoiDenProperty); }
            set { SetProperty(NoiDenProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GioBatDau"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> GioBatDauProperty = RegisterProperty<SmartDate>(p => p.GioBatDau, "Gio Bat Dau");
        /// <summary>
        /// Gets or sets the Gio Bat Dau.
        /// </summary>
        /// <value>The Gio Bat Dau.</value>
        public string GioBatDau
        {
            get { return GetPropertyConvert<SmartDate, String>(GioBatDauProperty); }
            set { SetPropertyConvert<SmartDate, String>(GioBatDauProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GioTra"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> GioTraProperty = RegisterProperty<SmartDate>(p => p.GioTra, "Gio Tra");
        /// <summary>
        /// Gets or sets the Gio Tra.
        /// </summary>
        /// <value>The Gio Tra.</value>
        public string GioTra
        {
            get { return GetPropertyConvert<SmartDate, String>(GioTraProperty); }
            set { SetPropertyConvert<SmartDate, String>(GioTraProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GioTraThucTe"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> GioTraThucTeProperty = RegisterProperty<SmartDate>(p => p.GioTraThucTe, "Gio Tra Thuc Te");
        /// <summary>
        /// Gets or sets the Gio Tra Thuc Te.
        /// </summary>
        /// <value>The Gio Tra Thuc Te.</value>
        public string GioTraThucTe
        {
            get { return GetPropertyConvert<SmartDate, String>(GioTraThucTeProperty); }
            set { SetPropertyConvert<SmartDate, String>(GioTraThucTeProperty, value); }
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
        /// Maintains metadata about <see cref="NoiXuatPhat"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiXuatPhatProperty = RegisterProperty<string>(p => p.NoiXuatPhat, "Noi Xuat Phat");
        /// <summary>
        /// Gets or sets the Noi Xuat Phat.
        /// </summary>
        /// <value>The Noi Xuat Phat.</value>
        public string NoiXuatPhat
        {
            get { return GetProperty(NoiXuatPhatProperty); }
            set { SetProperty(NoiXuatPhatProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Duyet"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool?> DuyetProperty = RegisterProperty<bool?>(p => p.Duyet, "Duyet");
        /// <summary>
        /// Gets or sets the Duyet.
        /// </summary>
        /// <value><c>true</c> if Duyet; <c>false</c> if not Duyet; otherwise, <c>null</c>.</value>
        public bool? Duyet
        {
            get { return GetProperty(DuyetProperty); }
            set { SetProperty(DuyetProperty, value); }
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
        public SmartDate LastEdited_Date
        {
            get { return GetProperty(LastEdited_DateProperty); }
            set { SetProperty(LastEdited_DateProperty, value); }
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
        /// Maintains metadata about <see cref="idUserDuyet"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IdUserDuyetProperty = RegisterProperty<Int64?>(p => p.IdUserDuyet, "id User Duyet");
        /// <summary>
        /// Gets or sets the id User Duyet.
        /// </summary>
        /// <value>The id User Duyet.</value>
        public Int64? IdUserDuyet
        {
            get { return GetProperty(IdUserDuyetProperty); }
            set { SetProperty(IdUserDuyetProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="dateDuyet"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> DateDuyetProperty = RegisterProperty<SmartDate>(p => p.DateDuyet, "date Duyet");
        /// <summary>
        /// Gets or sets the date Duyet.
        /// </summary>
        /// <value>The date Duyet.</value>
        public string DateDuyet
        {
            get { return GetPropertyConvert<SmartDate, String>(DateDuyetProperty); }
            set { SetPropertyConvert<SmartDate, String>(DateDuyetProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="BoPhan"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> BoPhanProperty = RegisterProperty<string>(p => p.BoPhan, "Bo Phan");
        /// <summary>
        /// Gets or sets the Bo Phan.
        /// </summary>
        /// <value>The Bo Phan.</value>
        public string BoPhan
        {
            get { return GetProperty(BoPhanProperty); }
            set { SetProperty(BoPhanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idBoPhan"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdBoPhanProperty = RegisterProperty<int?>(p => p.IdBoPhan, "id Bo Phan");
        /// <summary>
        /// Gets or sets the id Bo Phan.
        /// </summary>
        /// <value>The id Bo Phan.</value>
        public int? IdBoPhan
        {
            get { return GetProperty(IdBoPhanProperty); }
            set { SetProperty(IdBoPhanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoNguoi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoNguoiProperty = RegisterProperty<string>(p => p.SoNguoi, "So Nguoi");
        /// <summary>
        /// Gets or sets the So Nguoi.
        /// </summary>
        /// <value>The So Nguoi.</value>
        public string SoNguoi
        {
            get { return GetProperty(SoNguoiProperty); }
            set { SetProperty(SoNguoiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoKM"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoKMProperty = RegisterProperty<string>(p => p.SoKM, "So KM");
        /// <summary>
        /// Gets or sets the So KM.
        /// </summary>
        /// <value>The So KM.</value>
        public string SoKM
        {
            get { return GetProperty(SoKMProperty); }
            set { SetProperty(SoKMProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NoiDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDungProperty = RegisterProperty<string>(p => p.NoiDung, "Noi Dung");
        /// <summary>
        /// Gets or sets the Noi Dung.
        /// </summary>
        /// <value>The Noi Dung.</value>
        public string NoiDung
        {
            get { return GetProperty(NoiDungProperty); }
            set { SetProperty(NoiDungProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idBenhVienNoiDen"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IdBenhVienNoiDenProperty = RegisterProperty<Int64?>(p => p.IdBenhVienNoiDen, "id Benh Vien Noi Den");
        /// <summary>
        /// Gets or sets the id Benh Vien Noi Den.
        /// </summary>
        /// <value>The id Benh Vien Noi Den.</value>
        public Int64? IdBenhVienNoiDen
        {
            get { return GetProperty(IdBenhVienNoiDenProperty); }
            set { SetProperty(IdBenhVienNoiDenProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_XinXe"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_XinXe"/> object.</returns>
        public static HC_XinXe NewHC_XinXe()
        {
            return DataPortal.Create<HC_XinXe>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_XinXe"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the HC_XinXe to fetch.</param>
        /// <returns>A reference to the fetched <see cref="HC_XinXe"/> object.</returns>
        public static HC_XinXe GetHC_XinXe(int id)
        {
            return DataPortal.Fetch<HC_XinXe>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="HC_XinXe"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the HC_XinXe to delete.</param>
        public static void DeleteHC_XinXe(int id)
        {
            DataPortal.Delete<HC_XinXe>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_XinXe"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHC_XinXe(EventHandler<DataPortalResult<HC_XinXe>> callback)
        {
            DataPortal.BeginCreate<HC_XinXe>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="HC_XinXe"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the HC_XinXe to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHC_XinXe(int id, EventHandler<DataPortalResult<HC_XinXe>> callback)
        {
            DataPortal.BeginFetch<HC_XinXe>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="HC_XinXe"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the HC_XinXe to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteHC_XinXe(int id, EventHandler<DataPortalResult<HC_XinXe>> callback)
        {
            DataPortal.BeginDelete<HC_XinXe>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HC_XinXe"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_XinXe()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="HC_XinXe"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(CanBoDangKiProperty, null);
            LoadProperty(ChucVuProperty, null);
            LoadProperty(KhoaProperty, null);
            LoadProperty(BienSoXeProperty, null);
            LoadProperty(SoChuyenProperty, null);
            LoadProperty(NoiDenProperty, null);
            LoadProperty(GioBatDauProperty, null);
            LoadProperty(GioTraProperty, null);
            LoadProperty(GioTraThucTeProperty, null);
            LoadProperty(TinhTrangProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(NoiXuatPhatProperty, null);
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(LastEdited_UserNameProperty, null);
            LoadProperty(DateDuyetProperty, null);
            LoadProperty(BoPhanProperty, null);
            LoadProperty(SoNguoiProperty, null);
            LoadProperty(SoKMProperty, null);
            LoadProperty(NoiDungProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="HC_XinXe"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_XinXe_get", ctx.Connection))
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
        /// Loads a <see cref="HC_XinXe"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(CanBoDangKiProperty, dr.GetString("CanBoDangKi"));
            LoadProperty(IdCanBoDangKiProperty, dr.GetInt64("IdCanBoDangKi"));
            LoadProperty(ChucVuProperty, dr.GetString("ChucVu"));
            LoadProperty(IdChucVuProperty, dr.GetInt32("IdChucVu"));
            LoadProperty(KhoaProperty, dr.GetString("Khoa"));
            LoadProperty(IdKhoaProperty, dr.GetInt32("IdKhoa"));
            LoadProperty(BienSoXeProperty, dr.GetString("BienSoXe"));
            LoadProperty(SoChuyenProperty, dr.GetString("SoChuyen"));
            LoadProperty(NoiDenProperty, dr.GetString("NoiDen"));
            LoadProperty(GioBatDauProperty, dr.GetDateTime("GioBatDau"));
            LoadProperty(GioTraProperty, dr.GetDateTime("GioTra"));
            LoadProperty(GioTraThucTeProperty, dr.GetDateTime("GioTraThucTe"));
            LoadProperty(TinhTrangProperty, dr.GetString("TinhTrang"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(NoiXuatPhatProperty, dr.GetString("NoiXuatPhat"));
            LoadProperty(DuyetProperty, dr.GetBoolean("Duyet"));
            LoadProperty(LastEdited_UserIDProperty, dr.GetInt64("LastEdited_UserID"));
            LoadProperty(LastEdited_DateProperty, dr.GetDateTime("LastEdited_Date"));
            LoadProperty(IdNguonKinhPhiProperty, dr.GetInt32("IdNguonKinhPhi"));
            LoadProperty(LastEdited_UserNameProperty, dr.GetString("LastEdited_UserName"));
            LoadProperty(DateDuyetProperty, dr.GetSmartDate("DateDuyet"));
            LoadProperty(BoPhanProperty, dr.GetString("BoPhan"));
            LoadProperty(IdBoPhanProperty, dr.GetInt32("IdBoPhan"));
            LoadProperty(SoNguoiProperty, dr.GetString("SoNguoi"));
            LoadProperty(SoKMProperty, dr.GetString("SoKM"));
            LoadProperty(NoiDungProperty, dr.GetString("NoiDung"));
            LoadProperty(IdUserDuyetProperty, dr.GetInt64("IdUserDuyet"));
			LoadProperty(IdBenhVienNoiDenProperty, dr.GetInt64("IdBenhVienNoiDen"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="HC_XinXe"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_XinXe_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@CanBoDangKi", ReadProperty(CanBoDangKiProperty) == null ? (object)DBNull.Value : ReadProperty(CanBoDangKiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idCanBoDangKi", ReadProperty(IdCanBoDangKiProperty) == null ? (object)DBNull.Value : ReadProperty(IdCanBoDangKiProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@ChucVu", ReadProperty(ChucVuProperty) == null ? (object)DBNull.Value : ReadProperty(ChucVuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idChucVu", ReadProperty(IdChucVuProperty) == null ? (object)DBNull.Value : ReadProperty(IdChucVuProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Khoa", ReadProperty(KhoaProperty) == null ? (object)DBNull.Value : ReadProperty(KhoaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idKhoa", ReadProperty(IdKhoaProperty) == null ? (object)DBNull.Value : ReadProperty(IdKhoaProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@BienSoXe", ReadProperty(BienSoXeProperty) == null ? (object)DBNull.Value : ReadProperty(BienSoXeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoChuyen", ReadProperty(SoChuyenProperty) == null ? (object)DBNull.Value : ReadProperty(SoChuyenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDen", ReadProperty(NoiDenProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GioBatDau", ReadProperty(GioBatDauProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GioTra", ReadProperty(GioTraProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GioTraThucTe", ReadProperty(GioTraThucTeProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@TinhTrang", ReadProperty(TinhTrangProperty) == null ? (object)DBNull.Value : ReadProperty(TinhTrangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiXuatPhat", ReadProperty(NoiXuatPhatProperty) == null ? (object)DBNull.Value : ReadProperty(NoiXuatPhatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Duyet", ReadProperty(DuyetProperty) == null ? (object)DBNull.Value : ReadProperty(DuyetProperty).Value).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@idNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idUserDuyet", ReadProperty(IdUserDuyetProperty) == null ? (object)DBNull.Value : ReadProperty(IdUserDuyetProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@dateDuyet", ReadProperty(DateDuyetProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@BoPhan", ReadProperty(BoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(BoPhanProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idBoPhan", ReadProperty(IdBoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(IdBoPhanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoNguoi", ReadProperty(SoNguoiProperty) == null ? (object)DBNull.Value : ReadProperty(SoNguoiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoKM", ReadProperty(SoKMProperty) == null ? (object)DBNull.Value : ReadProperty(SoKMProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idBenhVienNoiDen", ReadProperty(IdBenhVienNoiDenProperty) == null ? (object)DBNull.Value : ReadProperty(IdBenhVienNoiDenProperty).Value).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (int) cmd.Parameters["@ID"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_XinXe"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_XinXe_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CanBoDangKi", ReadProperty(CanBoDangKiProperty) == null ? (object)DBNull.Value : ReadProperty(CanBoDangKiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idCanBoDangKi", ReadProperty(IdCanBoDangKiProperty) == null ? (object)DBNull.Value : ReadProperty(IdCanBoDangKiProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@ChucVu", ReadProperty(ChucVuProperty) == null ? (object)DBNull.Value : ReadProperty(ChucVuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idChucVu", ReadProperty(IdChucVuProperty) == null ? (object)DBNull.Value : ReadProperty(IdChucVuProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Khoa", ReadProperty(KhoaProperty) == null ? (object)DBNull.Value : ReadProperty(KhoaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idKhoa", ReadProperty(IdKhoaProperty) == null ? (object)DBNull.Value : ReadProperty(IdKhoaProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@BienSoXe", ReadProperty(BienSoXeProperty) == null ? (object)DBNull.Value : ReadProperty(BienSoXeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoChuyen", ReadProperty(SoChuyenProperty) == null ? (object)DBNull.Value : ReadProperty(SoChuyenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDen", ReadProperty(NoiDenProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GioBatDau", ReadProperty(GioBatDauProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GioTra", ReadProperty(GioTraProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GioTraThucTe", ReadProperty(GioTraThucTeProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@TinhTrang", ReadProperty(TinhTrangProperty) == null ? (object)DBNull.Value : ReadProperty(TinhTrangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiXuatPhat", ReadProperty(NoiXuatPhatProperty) == null ? (object)DBNull.Value : ReadProperty(NoiXuatPhatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Duyet", ReadProperty(DuyetProperty) == null ? (object)DBNull.Value : ReadProperty(DuyetProperty).Value).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@idNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idUserDuyet", ReadProperty(IdUserDuyetProperty) == null ? (object)DBNull.Value : ReadProperty(IdUserDuyetProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@dateDuyet", ReadProperty(DateDuyetProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@BoPhan", ReadProperty(BoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(BoPhanProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idBoPhan", ReadProperty(IdBoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(IdBoPhanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoNguoi", ReadProperty(SoNguoiProperty) == null ? (object)DBNull.Value : ReadProperty(SoNguoiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoKM", ReadProperty(SoKMProperty) == null ? (object)DBNull.Value : ReadProperty(SoKMProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idBenhVienNoiDen", ReadProperty(IdBenhVienNoiDenProperty) == null ? (object)DBNull.Value : ReadProperty(IdBenhVienNoiDenProperty).Value).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="HC_XinXe"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="HC_XinXe"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_XinXe_delete", ctx.Connection))
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
