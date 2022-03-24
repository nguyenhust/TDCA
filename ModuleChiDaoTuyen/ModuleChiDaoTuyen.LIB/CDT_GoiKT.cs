//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_GoiKT
// ObjectType:  CDT_GoiKT
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleChiDaoTuyen.LIB
{

    /// <summary>
    /// CDT_GoiKT (editable root object).<br/>
    /// This is a generated base class of <see cref="CDT_GoiKT"/> business object.
    /// </summary>
    [Serializable]
    public partial class CDT_GoiKT : BusinessBase<CDT_GoiKT>
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
        /// Maintains metadata about <see cref="TenGoiKT"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenGoiKTProperty = RegisterProperty<string>(p => p.TenGoiKT, "Ten Goi KT");
        /// <summary>
        /// Gets or sets the Ten Goi KT.
        /// </summary>
        /// <value>The Ten Goi KT.</value>
        public string TenGoiKT
        {
            get { return GetProperty(TenGoiKTProperty); }
            set { SetProperty(TenGoiKTProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IdGoiKT_Parent"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdGoiKT_ParentProperty = RegisterProperty<int?>(p => p.IdGoiKT_Parent, "Id Goi KT Parent");
        /// <summary>
        /// Gets or sets the Id Goi KT Parent.
        /// </summary>
        /// <value>The Id Goi KT Parent.</value>
        public int? IdGoiKT_Parent
        {
            get { return GetProperty(IdGoiKT_ParentProperty); }
            set { SetProperty(IdGoiKT_ParentProperty, value); }
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
        /// Maintains metadata about <see cref="MucTieuKienThuc"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MucTieuKienThucProperty = RegisterProperty<string>(p => p.MucTieuKienThuc, "Muc Tieu Kien Thuc");
        /// <summary>
        /// Gets or sets the Muc Tieu Kien Thuc.
        /// </summary>
        /// <value>The Muc Tieu Kien Thuc.</value>
        public string MucTieuKienThuc
        {
            get { return GetProperty(MucTieuKienThucProperty); }
            set { SetProperty(MucTieuKienThucProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MucTieuKyNang"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MucTieuKyNangProperty = RegisterProperty<string>(p => p.MucTieuKyNang, "Muc Tieu Ky Nang");
        /// <summary>
        /// Gets or sets the Muc Tieu Ky Nang.
        /// </summary>
        /// <value>The Muc Tieu Ky Nang.</value>
        public string MucTieuKyNang
        {
            get { return GetProperty(MucTieuKyNangProperty); }
            set { SetProperty(MucTieuKyNangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MucTieuThaiDo"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MucTieuThaiDoProperty = RegisterProperty<string>(p => p.MucTieuThaiDo, "Muc Tieu Thai Do");
        /// <summary>
        /// Gets or sets the Muc Tieu Thai Do.
        /// </summary>
        /// <value>The Muc Tieu Thai Do.</value>
        public string MucTieuThaiDo
        {
            get { return GetProperty(MucTieuThaiDoProperty); }
            set { SetProperty(MucTieuThaiDoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MoTaKyThuatChuyenGiao"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MoTaKyThuatChuyenGiaoProperty = RegisterProperty<string>(p => p.MoTaKyThuatChuyenGiao, "Mo Ta Ky Thuat Chuyen Giao");
        /// <summary>
        /// Gets or sets the Mo Ta Ky Thuat Chuyen Giao.
        /// </summary>
        /// <value>The Mo Ta Ky Thuat Chuyen Giao.</value>
        public string MoTaKyThuatChuyenGiao
        {
            get { return GetProperty(MoTaKyThuatChuyenGiaoProperty); }
            set { SetProperty(MoTaKyThuatChuyenGiaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TieuChuanGoiKT"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TieuChuanGoiKTProperty = RegisterProperty<string>(p => p.TieuChuanGoiKT, "Tieu Chuan Goi KT");
        /// <summary>
        /// Gets or sets the Tieu Chuan Goi KT.
        /// </summary>
        /// <value>The Tieu Chuan Goi KT.</value>
        public string TieuChuanGoiKT
        {
            get { return GetProperty(TieuChuanGoiKTProperty); }
            set { SetProperty(TieuChuanGoiKTProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NoiDungChuyenGiao"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDungChuyenGiaoProperty = RegisterProperty<string>(p => p.NoiDungChuyenGiao, "Noi Dung Chuyen Giao");
        /// <summary>
        /// Gets or sets the Noi Dung Chuyen Giao.
        /// </summary>
        /// <value>The Noi Dung Chuyen Giao.</value>
        public string NoiDungChuyenGiao
        {
            get { return GetProperty(NoiDungChuyenGiaoProperty); }
            set { SetProperty(NoiDungChuyenGiaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChiTieuDanhGia"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChiTieuDanhGiaProperty = RegisterProperty<string>(p => p.ChiTieuDanhGia, "Chi Tieu Danh Gia");
        /// <summary>
        /// Gets or sets the Chi Tieu Danh Gia.
        /// </summary>
        /// <value>The Chi Tieu Danh Gia.</value>
        public string ChiTieuDanhGia
        {
            get { return GetProperty(ChiTieuDanhGiaProperty); }
            set { SetProperty(ChiTieuDanhGiaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TaiLieuHocTap_BS"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TaiLieuHocTap_BSProperty = RegisterProperty<string>(p => p.TaiLieuHocTap_BS, "Tai Lieu Hoc Tap BS");
        /// <summary>
        /// Gets or sets the Tai Lieu Hoc Tap BS.
        /// </summary>
        /// <value>The Tai Lieu Hoc Tap BS.</value>
        public string TaiLieuHocTap_BS
        {
            get { return GetProperty(TaiLieuHocTap_BSProperty); }
            set { SetProperty(TaiLieuHocTap_BSProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TaiLieuHocTap_DD"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TaiLieuHocTap_DDProperty = RegisterProperty<string>(p => p.TaiLieuHocTap_DD, "Tai Lieu Hoc Tap DD");
        /// <summary>
        /// Gets or sets the Tai Lieu Hoc Tap DD.
        /// </summary>
        /// <value>The Tai Lieu Hoc Tap DD.</value>
        public string TaiLieuHocTap_DD
        {
            get { return GetProperty(TaiLieuHocTap_DDProperty); }
            set { SetProperty(TaiLieuHocTap_DDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TaiLieuHocTap_Khac"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TaiLieuHocTap_KhacProperty = RegisterProperty<string>(p => p.TaiLieuHocTap_Khac, "Tai Lieu Hoc Tap Khac");
        /// <summary>
        /// Gets or sets the Tai Lieu Hoc Tap Khac.
        /// </summary>
        /// <value>The Tai Lieu Hoc Tap Khac.</value>
        public string TaiLieuHocTap_Khac
        {
            get { return GetProperty(TaiLieuHocTap_KhacProperty); }
            set { SetProperty(TaiLieuHocTap_KhacProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Backup04"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Backup04Property = RegisterProperty<string>(p => p.Backup04, "Backup04");
        /// <summary>
        /// Gets or sets the Backup04.
        /// </summary>
        /// <value>The Backup04.</value>
        public string Backup04
        {
            get { return GetProperty(Backup04Property); }
            set { SetProperty(Backup04Property, value); }
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
        public static readonly PropertyInfo<string> Backup03Property = RegisterProperty<string>(p => p.Backup03, "Backup03");
        /// <summary>
        /// Gets or sets the Backup03.
        /// </summary>
        /// <value>The Backup03.</value>
        public string Backup03
        {
            get { return GetProperty(Backup03Property); }
            set { SetProperty(Backup03Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="LinkFile"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> LinkFileProperty = RegisterProperty<string>(p => p.LinkFile, "Link File");
        /// <summary>
        /// Gets or sets the Link File.
        /// </summary>
        /// <value>The Link File.</value>
        public string LinkFile
        {
            get { return GetProperty(LinkFileProperty); }
            set { SetProperty(LinkFileProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_GoiKT"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_GoiKT"/> object.</returns>
        public static CDT_GoiKT NewCDT_GoiKT()
        {
            return DataPortal.Create<CDT_GoiKT>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_GoiKT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the CDT_GoiKT to fetch.</param>
        /// <returns>A reference to the fetched <see cref="CDT_GoiKT"/> object.</returns>
        public static CDT_GoiKT GetCDT_GoiKT(int id)
        {
            return DataPortal.Fetch<CDT_GoiKT>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="CDT_GoiKT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the CDT_GoiKT to delete.</param>
        public static void DeleteCDT_GoiKT(int id)
        {
            DataPortal.Delete<CDT_GoiKT>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_GoiKT"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_GoiKT(EventHandler<DataPortalResult<CDT_GoiKT>> callback)
        {
            DataPortal.BeginCreate<CDT_GoiKT>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_GoiKT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the CDT_GoiKT to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_GoiKT(int id, EventHandler<DataPortalResult<CDT_GoiKT>> callback)
        {
            DataPortal.BeginFetch<CDT_GoiKT>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="CDT_GoiKT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the CDT_GoiKT to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteCDT_GoiKT(int id, EventHandler<DataPortalResult<CDT_GoiKT>> callback)
        {
            DataPortal.BeginDelete<CDT_GoiKT>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_GoiKT"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_GoiKT()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_GoiKT"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(TenGoiKTProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(MucTieuKienThucProperty, null);
            LoadProperty(MucTieuKyNangProperty, null);
            LoadProperty(MucTieuThaiDoProperty, null);
            LoadProperty(MoTaKyThuatChuyenGiaoProperty, null);
            LoadProperty(TieuChuanGoiKTProperty, null);
            LoadProperty(NoiDungChuyenGiaoProperty, null);
            LoadProperty(ChiTieuDanhGiaProperty, null);
            LoadProperty(TaiLieuHocTap_BSProperty, null);
            LoadProperty(TaiLieuHocTap_DDProperty, null);
            LoadProperty(TaiLieuHocTap_KhacProperty, null);
            LoadProperty(Backup04Property, null);
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(Backup01Property, null);
            LoadProperty(Backup02Property, null);
            LoadProperty(Backup03Property, null);
            LoadProperty(LinkFileProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_GoiKT"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_GoiKT_get", ctx.Connection))
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
        /// Loads a <see cref="CDT_GoiKT"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("id"));
            LoadProperty(TenGoiKTProperty, dr.GetString("TenGoiKT"));
            LoadProperty(IdGoiKT_ParentProperty, dr.GetInt32("IdGoiKT_Parent"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(MucTieuKienThucProperty, dr.GetString("MucTieuKienThuc"));
            LoadProperty(MucTieuKyNangProperty, dr.GetString("MucTieuKyNang"));
            LoadProperty(MucTieuThaiDoProperty, dr.GetString("MucTieuThaiDo"));
            LoadProperty(MoTaKyThuatChuyenGiaoProperty, dr.GetString("MoTaKyThuatChuyenGiao"));
            LoadProperty(TieuChuanGoiKTProperty, dr.GetString("TieuChuanGoiKT"));
            LoadProperty(NoiDungChuyenGiaoProperty, dr.GetString("NoiDungChuyenGiao"));
            LoadProperty(ChiTieuDanhGiaProperty, dr.GetString("ChiTieuDanhGia"));
            LoadProperty(TaiLieuHocTap_BSProperty, dr.GetString("TaiLieuHocTap_BS"));
            LoadProperty(TaiLieuHocTap_DDProperty, dr.GetString("TaiLieuHocTap_DD"));
            LoadProperty(TaiLieuHocTap_KhacProperty, dr.GetString("TaiLieuHocTap_Khac"));
            LoadProperty(Backup04Property, dr.GetString("Backup04"));
            LoadProperty(LastEdited_UserIDProperty, dr.GetInt64("LastEdited_UserID"));
            LoadProperty(LastEdited_DateProperty, dr.GetSmartDate("LastEdited_Date"));
            LoadProperty(Backup01Property, dr.GetString("Backup01"));
            LoadProperty(Backup02Property, dr.GetString("Backup02"));
            LoadProperty(Backup03Property, dr.GetString("Backup03"));
            LoadProperty(LinkFileProperty, dr.GetString("LinkFile"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_GoiKT"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_GoiKT_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@TenGoiKT", ReadProperty(TenGoiKTProperty) == null ? (object)DBNull.Value : ReadProperty(TenGoiKTProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IdGoiKT_Parent", ReadProperty(IdGoiKT_ParentProperty) == null ? (object)DBNull.Value : ReadProperty(IdGoiKT_ParentProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MucTieuKienThuc", ReadProperty(MucTieuKienThucProperty) == null ? (object)DBNull.Value : ReadProperty(MucTieuKienThucProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MucTieuKyNang", ReadProperty(MucTieuKyNangProperty) == null ? (object)DBNull.Value : ReadProperty(MucTieuKyNangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MucTieuThaiDo", ReadProperty(MucTieuThaiDoProperty) == null ? (object)DBNull.Value : ReadProperty(MucTieuThaiDoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MoTaKyThuatChuyenGiao", ReadProperty(MoTaKyThuatChuyenGiaoProperty) == null ? (object)DBNull.Value : ReadProperty(MoTaKyThuatChuyenGiaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TieuChuanGoiKT", ReadProperty(TieuChuanGoiKTProperty) == null ? (object)DBNull.Value : ReadProperty(TieuChuanGoiKTProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDungChuyenGiao", ReadProperty(NoiDungChuyenGiaoProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungChuyenGiaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChiTieuDanhGia", ReadProperty(ChiTieuDanhGiaProperty) == null ? (object)DBNull.Value : ReadProperty(ChiTieuDanhGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TaiLieuHocTap_BS", ReadProperty(TaiLieuHocTap_BSProperty) == null ? (object)DBNull.Value : ReadProperty(TaiLieuHocTap_BSProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TaiLieuHocTap_DD", ReadProperty(TaiLieuHocTap_DDProperty) == null ? (object)DBNull.Value : ReadProperty(TaiLieuHocTap_DDProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TaiLieuHocTap_Khac", ReadProperty(TaiLieuHocTap_KhacProperty) == null ? (object)DBNull.Value : ReadProperty(TaiLieuHocTap_KhacProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup04", ReadProperty(Backup04Property) == null ? (object)DBNull.Value : ReadProperty(Backup04Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@Backup01", ReadProperty(Backup01Property) == null ? (object)DBNull.Value : ReadProperty(Backup01Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup02", ReadProperty(Backup02Property) == null ? (object)DBNull.Value : ReadProperty(Backup02Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup03", ReadProperty(Backup03Property) == null ? (object)DBNull.Value : ReadProperty(Backup03Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LinkFile", ReadProperty(LinkFileProperty) == null ? (object)DBNull.Value : ReadProperty(LinkFileProperty)).DbType = DbType.String;
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
        /// Updates in the database all changes made to the <see cref="CDT_GoiKT"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_GoiKT_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TenGoiKT", ReadProperty(TenGoiKTProperty) == null ? (object)DBNull.Value : ReadProperty(TenGoiKTProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IdGoiKT_Parent", ReadProperty(IdGoiKT_ParentProperty) == null ? (object)DBNull.Value : ReadProperty(IdGoiKT_ParentProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MucTieuKienThuc", ReadProperty(MucTieuKienThucProperty) == null ? (object)DBNull.Value : ReadProperty(MucTieuKienThucProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MucTieuKyNang", ReadProperty(MucTieuKyNangProperty) == null ? (object)DBNull.Value : ReadProperty(MucTieuKyNangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MucTieuThaiDo", ReadProperty(MucTieuThaiDoProperty) == null ? (object)DBNull.Value : ReadProperty(MucTieuThaiDoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MoTaKyThuatChuyenGiao", ReadProperty(MoTaKyThuatChuyenGiaoProperty) == null ? (object)DBNull.Value : ReadProperty(MoTaKyThuatChuyenGiaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TieuChuanGoiKT", ReadProperty(TieuChuanGoiKTProperty) == null ? (object)DBNull.Value : ReadProperty(TieuChuanGoiKTProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDungChuyenGiao", ReadProperty(NoiDungChuyenGiaoProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungChuyenGiaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChiTieuDanhGia", ReadProperty(ChiTieuDanhGiaProperty) == null ? (object)DBNull.Value : ReadProperty(ChiTieuDanhGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TaiLieuHocTap_BS", ReadProperty(TaiLieuHocTap_BSProperty) == null ? (object)DBNull.Value : ReadProperty(TaiLieuHocTap_BSProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TaiLieuHocTap_DD", ReadProperty(TaiLieuHocTap_DDProperty) == null ? (object)DBNull.Value : ReadProperty(TaiLieuHocTap_DDProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TaiLieuHocTap_Khac", ReadProperty(TaiLieuHocTap_KhacProperty) == null ? (object)DBNull.Value : ReadProperty(TaiLieuHocTap_KhacProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup04", ReadProperty(Backup04Property) == null ? (object)DBNull.Value : ReadProperty(Backup04Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@Backup01", ReadProperty(Backup01Property) == null ? (object)DBNull.Value : ReadProperty(Backup01Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup02", ReadProperty(Backup02Property) == null ? (object)DBNull.Value : ReadProperty(Backup02Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Backup03", ReadProperty(Backup03Property) == null ? (object)DBNull.Value : ReadProperty(Backup03Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LinkFile", ReadProperty(LinkFileProperty) == null ? (object)DBNull.Value : ReadProperty(LinkFileProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_GoiKT"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="CDT_GoiKT"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_GoiKT_delete", ctx.Connection))
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
