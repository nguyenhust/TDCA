//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_KinhPhiCGKT
// ObjectType:  CDT_KinhPhiCGKT
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
    /// CDT_KinhPhiCGKT (editable root object).<br/>
    /// This is a generated base class of <see cref="CDT_KinhPhiCGKT"/> business object.
    /// </summary>
    [Serializable]
    public partial class CDT_KinhPhiCGKT : BusinessBase<CDT_KinhPhiCGKT>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="idHopDong"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdHopDongProperty = RegisterProperty<int?>(p => p.IdHopDong, "id Hop Dong");
        /// <summary>
        /// Gets or sets the id Hop Dong.
        /// </summary>
        /// <value>The id Hop Dong.</value>
        public int? IdHopDong
        {
            get { return GetProperty(IdHopDongProperty); }
            set { SetProperty(IdHopDongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="noidung"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoidungProperty = RegisterProperty<string>(p => p.Noidung, "noidung");
        /// <summary>
        /// Gets or sets the noidung.
        /// </summary>
        /// <value>The noidung.</value>
        public string Noidung
        {
            get { return GetProperty(NoidungProperty); }
            set { SetProperty(NoidungProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThanhTien"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> ThanhTienProperty = RegisterProperty<Int64?>(p => p.ThanhTien, "Thanh Tien");
        /// <summary>
        /// Gets or sets the Thanh Tien.
        /// </summary>
        /// <value>The Thanh Tien.</value>
        public Int64? ThanhTien
        {
            get { return GetProperty(ThanhTienProperty); }
            set { SetProperty(ThanhTienProperty, value); }
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
        /// Maintains metadata about <see cref="LoaiKinhPhi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> LoaiKinhPhiProperty = RegisterProperty<string>(p => p.LoaiKinhPhi, "Loai Kinh Phi");
        /// <summary>
        /// Gets or sets the Loai Kinh Phi.
        /// </summary>
        /// <value>The Loai Kinh Phi.</value>
        public string LoaiKinhPhi
        {
            get { return GetProperty(LoaiKinhPhiProperty); }
            set { SetProperty(LoaiKinhPhiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IdNguonKinhPhi"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdNguonKinhPhiProperty = RegisterProperty<int?>(p => p.IdNguonKinhPhi, "Id Nguon Kinh Phi");
        /// <summary>
        /// Gets or sets the Id Nguon Kinh Phi.
        /// </summary>
        /// <value>The Id Nguon Kinh Phi.</value>
        public int? IdNguonKinhPhi
        {
            get { return GetProperty(IdNguonKinhPhiProperty); }
            set { SetProperty(IdNguonKinhPhiProperty, value); }
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
        /// Maintains metadata about <see cref="backup01"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Backup01Property = RegisterProperty<string>(p => p.Backup01, "backup01");
        /// <summary>
        /// Gets or sets the backup01.
        /// </summary>
        /// <value>The backup01.</value>
        public string Backup01
        {
            get { return GetProperty(Backup01Property); }
            set { SetProperty(Backup01Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="backup02"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> Backup02Property = RegisterProperty<string>(p => p.Backup02, "backup02");
        /// <summary>
        /// Gets or sets the backup02.
        /// </summary>
        /// <value>The backup02.</value>
        public string Backup02
        {
            get { return GetProperty(Backup02Property); }
            set { SetProperty(Backup02Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayChi"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayChiProperty = RegisterProperty<SmartDate>(p => p.NgayChi, "Ngay Chi");
        /// <summary>
        /// Gets or sets the Ngay Chi.
        /// </summary>
        /// <value>The Ngay Chi.</value>
        public string NgayChi
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayChiProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayChiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MaHoaDon"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaHoaDonProperty = RegisterProperty<string>(p => p.MaHoaDon, "Ma Hoa Don");
        /// <summary>
        /// Gets or sets the Ma Hoa Don.
        /// </summary>
        /// <value>The Ma Hoa Don.</value>
        public string MaHoaDon
        {
            get { return GetProperty(MaHoaDonProperty); }
            set { SetProperty(MaHoaDonProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayHoaDon"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayHoaDonProperty = RegisterProperty<SmartDate>(p => p.NgayHoaDon, "Ngay Hoa Don");
        /// <summary>
        /// Gets or sets the Ngay Hoa Don.
        /// </summary>
        /// <value>The Ngay Hoa Don.</value>
        public string NgayHoaDon
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayHoaDonProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayHoaDonProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TienTrenHoaDon"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TienTrenHoaDonProperty = RegisterProperty<string>(p => p.TienTrenHoaDon, "Tien Tren Hoa Don");
        /// <summary>
        /// Gets or sets the Tien Tren Hoa Don.
        /// </summary>
        /// <value>The Tien Tren Hoa Don.</value>
        public string TienTrenHoaDon
        {
            get { return GetProperty(TienTrenHoaDonProperty); }
            set { SetProperty(TienTrenHoaDonProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TenDonViXuat"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenDonViXuatProperty = RegisterProperty<string>(p => p.TenDonViXuat, "Ten Don Vi Xuat");
        /// <summary>
        /// Gets or sets the Ten Don Vi Xuat.
        /// </summary>
        /// <value>The Ten Don Vi Xuat.</value>
        public string TenDonViXuat
        {
            get { return GetProperty(TenDonViXuatProperty); }
            set { SetProperty(TenDonViXuatProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TenNguoiLay"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenNguoiLayProperty = RegisterProperty<string>(p => p.TenNguoiLay, "Ten Nguoi Lay");
        /// <summary>
        /// Gets or sets the Ten Nguoi Lay.
        /// </summary>
        /// <value>The Ten Nguoi Lay.</value>
        public string TenNguoiLay
        {
            get { return GetProperty(TenNguoiLayProperty); }
            set { SetProperty(TenNguoiLayProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_KinhPhiCGKT"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_KinhPhiCGKT"/> object.</returns>
        public static CDT_KinhPhiCGKT NewCDT_KinhPhiCGKT()
        {
            return DataPortal.Create<CDT_KinhPhiCGKT>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_KinhPhiCGKT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the CDT_KinhPhiCGKT to fetch.</param>
        /// <returns>A reference to the fetched <see cref="CDT_KinhPhiCGKT"/> object.</returns>
        public static CDT_KinhPhiCGKT GetCDT_KinhPhiCGKT(int id)
        {
            return DataPortal.Fetch<CDT_KinhPhiCGKT>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="CDT_KinhPhiCGKT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the CDT_KinhPhiCGKT to delete.</param>
        public static void DeleteCDT_KinhPhiCGKT(int id)
        {
            DataPortal.Delete<CDT_KinhPhiCGKT>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_KinhPhiCGKT"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_KinhPhiCGKT(EventHandler<DataPortalResult<CDT_KinhPhiCGKT>> callback)
        {
            DataPortal.BeginCreate<CDT_KinhPhiCGKT>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_KinhPhiCGKT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the CDT_KinhPhiCGKT to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_KinhPhiCGKT(int id, EventHandler<DataPortalResult<CDT_KinhPhiCGKT>> callback)
        {
            DataPortal.BeginFetch<CDT_KinhPhiCGKT>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="CDT_KinhPhiCGKT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the CDT_KinhPhiCGKT to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteCDT_KinhPhiCGKT(int id, EventHandler<DataPortalResult<CDT_KinhPhiCGKT>> callback)
        {
            DataPortal.BeginDelete<CDT_KinhPhiCGKT>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_KinhPhiCGKT"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_KinhPhiCGKT()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_KinhPhiCGKT"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(NoidungProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(LoaiKinhPhiProperty, null);
            LoadProperty(LinkFileProperty, null);
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(Backup01Property, null);
            LoadProperty(Backup02Property, null);
            LoadProperty(NgayChiProperty, null);
            LoadProperty(MaHoaDonProperty, null);
            LoadProperty(NgayHoaDonProperty, null);
            LoadProperty(TienTrenHoaDonProperty, null);
            LoadProperty(TenDonViXuatProperty, null);
            LoadProperty(TenNguoiLayProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_KinhPhiCGKT"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_KinhPhiCGKT_get", ctx.Connection))
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
        /// Loads a <see cref="CDT_KinhPhiCGKT"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdHopDongProperty, dr.GetInt32("idHopDong"));
            LoadProperty(NoidungProperty, dr.GetString("Noidung"));
            LoadProperty(ThanhTienProperty, dr.GetInt64("ThanhTien"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
			LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(LoaiKinhPhiProperty, dr.GetString("LoaiKinhPhi"));
            LoadProperty(IdNguonKinhPhiProperty, dr.GetInt32("IdNguonKinhPhi"));
            LoadProperty(LastEdited_UserIDProperty, dr.GetInt64("LastEdited_UserID"));
            LoadProperty(LastEdited_DateProperty, dr.GetSmartDate("LastEdited_Date"));
            LoadProperty(Backup01Property, dr.GetString("Backup01"));
            LoadProperty(Backup02Property, dr.GetString("Backup02"));
  LoadProperty(NgayChiProperty, dr.GetSmartDate("NgayChi"));
            LoadProperty(MaHoaDonProperty, dr.GetString("MaHoaDon"));
            LoadProperty(NgayHoaDonProperty, dr.GetSmartDate("NgayHoaDon"));
            LoadProperty(TienTrenHoaDonProperty, dr.GetString("TienTrenHoaDon"));
            LoadProperty(TenDonViXuatProperty, dr.GetString("TenDonViXuat"));
            LoadProperty(TenNguoiLayProperty, dr.GetString("TenNguoiLay"));
            LoadProperty(LinkFileProperty, dr.GetString("LinkFile"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_KinhPhiCGKT"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_KinhPhiCGKT_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHopDong", ReadProperty(IdHopDongProperty) == null ? (object)DBNull.Value : ReadProperty(IdHopDongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@noidung", ReadProperty(NoidungProperty) == null ? (object)DBNull.Value : ReadProperty(NoidungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThanhTien", ReadProperty(ThanhTienProperty) == null ? (object)DBNull.Value : ReadProperty(ThanhTienProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@LoaiKinhPhi", ReadProperty(LoaiKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(LoaiKinhPhiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IdNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@LinkFile", ReadProperty(LinkFileProperty) == null ? (object)DBNull.Value : ReadProperty(LinkFileProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@backup01", ReadProperty(Backup01Property) == null ? (object)DBNull.Value : ReadProperty(Backup01Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup02", ReadProperty(Backup02Property) == null ? (object)DBNull.Value : ReadProperty(Backup02Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayChi", ReadProperty(NgayChiProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@MaHoaDon", ReadProperty(MaHoaDonProperty) == null ? (object)DBNull.Value : ReadProperty(MaHoaDonProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayHoaDon", ReadProperty(NgayHoaDonProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@TienTrenHoaDon", ReadProperty(TienTrenHoaDonProperty) == null ? (object)DBNull.Value : ReadProperty(TienTrenHoaDonProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenDonViXuat", ReadProperty(TenDonViXuatProperty) == null ? (object)DBNull.Value : ReadProperty(TenDonViXuatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenNguoiLay", ReadProperty(TenNguoiLayProperty) == null ? (object)DBNull.Value : ReadProperty(TenNguoiLayProperty)).DbType = DbType.String;
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
        /// Updates in the database all changes made to the <see cref="CDT_KinhPhiCGKT"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_KinhPhiCGKT_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHopDong", ReadProperty(IdHopDongProperty) == null ? (object)DBNull.Value : ReadProperty(IdHopDongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@noidung", ReadProperty(NoidungProperty) == null ? (object)DBNull.Value : ReadProperty(NoidungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThanhTien", ReadProperty(ThanhTienProperty) == null ? (object)DBNull.Value : ReadProperty(ThanhTienProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@LoaiKinhPhi", ReadProperty(LoaiKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(LoaiKinhPhiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IdNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@LinkFile", ReadProperty(LinkFileProperty) == null ? (object)DBNull.Value : ReadProperty(LinkFileProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@backup01", ReadProperty(Backup01Property) == null ? (object)DBNull.Value : ReadProperty(Backup01Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup02", ReadProperty(Backup02Property) == null ? (object)DBNull.Value : ReadProperty(Backup02Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayChi", ReadProperty(NgayChiProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@MaHoaDon", ReadProperty(MaHoaDonProperty) == null ? (object)DBNull.Value : ReadProperty(MaHoaDonProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayHoaDon", ReadProperty(NgayHoaDonProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@TienTrenHoaDon", ReadProperty(TienTrenHoaDonProperty) == null ? (object)DBNull.Value : ReadProperty(TienTrenHoaDonProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenDonViXuat", ReadProperty(TenDonViXuatProperty) == null ? (object)DBNull.Value : ReadProperty(TenDonViXuatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenNguoiLay", ReadProperty(TenNguoiLayProperty) == null ? (object)DBNull.Value : ReadProperty(TenNguoiLayProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_KinhPhiCGKT"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="CDT_KinhPhiCGKT"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_KinhPhiCGKT_delete", ctx.Connection))
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
