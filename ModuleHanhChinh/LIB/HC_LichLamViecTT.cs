//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_LichLamViecTT
// ObjectType:  HC_LichLamViecTT
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
    /// HC_LichLamViecTT (editable root object).<br/>
    /// This is a generated base class of <see cref="HC_LichLamViecTT"/> business object.
    /// </summary>
    [Serializable]
    public partial class HC_LichLamViecTT : BusinessBase<HC_LichLamViecTT>
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
        /// Maintains metadata about <see cref="NgayBatDau"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayBatDauProperty = RegisterProperty<SmartDate>(p => p.NgayBatDau, "Ngay Bat Dau");
        /// <summary>
        /// Gets or sets the Ngay Bat Dau.
        /// </summary>
        /// <value>The Ngay Bat Dau.</value>
        public string NgayBatDau
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayBatDauProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayBatDauProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayKetThuc"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayKetThucProperty = RegisterProperty<SmartDate>(p => p.NgayKetThuc, "Ngay Ket Thuc");
        /// <summary>
        /// Gets or sets the Ngay Ket Thuc.
        /// </summary>
        /// <value>The Ngay Ket Thuc.</value>
        public string NgayKetThuc
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayKetThucProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayKetThucProperty, value); }
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
        /// Maintains metadata about <see cref="Link"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> LinkProperty = RegisterProperty<string>(p => p.Link, "Link");
        /// <summary>
        /// Gets or sets the Link.
        /// </summary>
        /// <value>The Link.</value>
        public string Link
        {
            get { return GetProperty(LinkProperty); }
            set { SetProperty(LinkProperty, value); }
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
        /// Maintains metadata about <see cref="TenCanBoThucHien"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenCanBoThucHienProperty = RegisterProperty<string>(p => p.TenCanBoThucHien, "Ten Can Bo Thuc Hien");
        /// <summary>
        /// Gets or sets the Ten Can Bo Thuc Hien.
        /// </summary>
        /// <value>The Ten Can Bo Thuc Hien.</value>
        public string TenCanBoThucHien
        {
            get { return GetProperty(TenCanBoThucHienProperty); }
            set { SetProperty(TenCanBoThucHienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NoiDungThucHien"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDungThucHienProperty = RegisterProperty<string>(p => p.NoiDungThucHien, "Noi Dung Thuc Hien");
        /// <summary>
        /// Gets or sets the Noi Dung Thuc Hien.
        /// </summary>
        /// <value>The Noi Dung Thuc Hien.</value>
        public string NoiDungThucHien
        {
            get { return GetProperty(NoiDungThucHienProperty); }
            set { SetProperty(NoiDungThucHienProperty, value); }
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
        /// Maintains metadata about <see cref="backupid"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> BackupidProperty = RegisterProperty<int?>(p => p.Backupid, "backupid");
        /// <summary>
        /// Gets or sets the backupid.
        /// </summary>
        /// <value>The backupid.</value>
        public int? Backupid
        {
            get { return GetProperty(BackupidProperty); }
            set { SetProperty(BackupidProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_LichLamViecTT"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_LichLamViecTT"/> object.</returns>
        public static HC_LichLamViecTT NewHC_LichLamViecTT()
        {
            return DataPortal.Create<HC_LichLamViecTT>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_LichLamViecTT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the HC_LichLamViecTT to fetch.</param>
        /// <returns>A reference to the fetched <see cref="HC_LichLamViecTT"/> object.</returns>
        public static HC_LichLamViecTT GetHC_LichLamViecTT(int id)
        {
            return DataPortal.Fetch<HC_LichLamViecTT>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="HC_LichLamViecTT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the HC_LichLamViecTT to delete.</param>
        public static void DeleteHC_LichLamViecTT(int id)
        {
            DataPortal.Delete<HC_LichLamViecTT>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_LichLamViecTT"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHC_LichLamViecTT(EventHandler<DataPortalResult<HC_LichLamViecTT>> callback)
        {
            DataPortal.BeginCreate<HC_LichLamViecTT>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="HC_LichLamViecTT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the HC_LichLamViecTT to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHC_LichLamViecTT(int id, EventHandler<DataPortalResult<HC_LichLamViecTT>> callback)
        {
            DataPortal.BeginFetch<HC_LichLamViecTT>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="HC_LichLamViecTT"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the HC_LichLamViecTT to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteHC_LichLamViecTT(int id, EventHandler<DataPortalResult<HC_LichLamViecTT>> callback)
        {
            DataPortal.BeginDelete<HC_LichLamViecTT>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HC_LichLamViecTT"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_LichLamViecTT()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="HC_LichLamViecTT"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(NgayBatDauProperty, null);
            LoadProperty(NgayKetThucProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(LinkProperty, null);
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(TenCanBoThucHienProperty, null);
            LoadProperty(NoiDungThucHienProperty, null);
            LoadProperty(Backup01Property, null);
            LoadProperty(Backup02Property, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="HC_LichLamViecTT"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTT_get", ctx.Connection))
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
        /// Loads a <see cref="HC_LichLamViecTT"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(NgayBatDauProperty, dr.GetDateTime("NgayBatDau"));
            LoadProperty(NgayKetThucProperty, dr.GetDateTime("NgayKetThuc"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(LinkProperty, dr.GetString("Link"));
            LoadProperty(LastEdited_UserIDProperty, dr.GetInt64("LastEdited_UserID"));
            LoadProperty(LastEdited_DateProperty, dr.GetDateTime("LastEdited_Date"));
            LoadProperty(IdBoPhanProperty, dr.GetInt32("IdBoPhan"));
            LoadProperty(TenCanBoThucHienProperty, dr.GetString("TenCanBoThucHien"));
            LoadProperty(NoiDungThucHienProperty, dr.GetString("NoiDungThucHien"));
            LoadProperty(Backup01Property, dr.GetString("Backup01"));
            LoadProperty(Backup02Property, dr.GetString("Backup02"));
            LoadProperty(BackupidProperty, dr.GetInt32("Backupid"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="HC_LichLamViecTT"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTT_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@NgayBatDau", ReadProperty(NgayBatDauProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ReadProperty(NgayKetThucProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Link", ReadProperty(LinkProperty) == null ? (object)DBNull.Value : ReadProperty(LinkProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@idBoPhan", ReadProperty(IdBoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(IdBoPhanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TenCanBoThucHien", ReadProperty(TenCanBoThucHienProperty) == null ? (object)DBNull.Value : ReadProperty(TenCanBoThucHienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDungThucHien", ReadProperty(NoiDungThucHienProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungThucHienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup01", ReadProperty(Backup01Property) == null ? (object)DBNull.Value : ReadProperty(Backup01Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup02", ReadProperty(Backup02Property) == null ? (object)DBNull.Value : ReadProperty(Backup02Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backupid", ReadProperty(BackupidProperty) == null ? (object)DBNull.Value : ReadProperty(BackupidProperty).Value).DbType = DbType.Int32;
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
        /// Updates in the database all changes made to the <see cref="HC_LichLamViecTT"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTT_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NgayBatDau", ReadProperty(NgayBatDauProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ReadProperty(NgayKetThucProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Link", ReadProperty(LinkProperty) == null ? (object)DBNull.Value : ReadProperty(LinkProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@idBoPhan", ReadProperty(IdBoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(IdBoPhanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TenCanBoThucHien", ReadProperty(TenCanBoThucHienProperty) == null ? (object)DBNull.Value : ReadProperty(TenCanBoThucHienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDungThucHien", ReadProperty(NoiDungThucHienProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungThucHienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup01", ReadProperty(Backup01Property) == null ? (object)DBNull.Value : ReadProperty(Backup01Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backup02", ReadProperty(Backup02Property) == null ? (object)DBNull.Value : ReadProperty(Backup02Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@backupid", ReadProperty(BackupidProperty) == null ? (object)DBNull.Value : ReadProperty(BackupidProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="HC_LichLamViecTT"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="HC_LichLamViecTT"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTT_delete", ctx.Connection))
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
