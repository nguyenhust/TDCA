using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{
    [Serializable]
    public partial class TrangThaiCuaHocVien : BusinessBase<TrangThaiCuaHocVien>
    {
        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDTrangThaiProperty = RegisterProperty<Int64>(p => p.IDTrangThai, "IDTrangThai");
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 IDTrangThai
        {
            get { return GetProperty(IDTrangThaiProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Ten"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenTrangThaiProperty = RegisterProperty<string>(p => p.TenTrangThai, "TenTrangThai");
        /// <summary>
        /// Gets or sets the Ten.
        /// </summary>
        /// <value>The Ten.</value>
        public string TenTrangThai
        {
            get { return GetProperty(TenTrangThaiProperty); }
            set { SetProperty(TenTrangThaiProperty, value); }
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

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_ChucVu"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_ChucVu"/> object.</returns>
        public static TrangThaiCuaHocVien NewTrangThaiCuaHocVien()
        {
            return DataPortal.Create<TrangThaiCuaHocVien>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_ChucVu"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the DIC_ChucVu to fetch.</param>
        /// <returns>A reference to the fetched <see cref="DIC_ChucVu"/> object.</returns>
        public static TrangThaiCuaHocVien GetTrangThaiCuaHocVien(Int64 id)
        {
            return DataPortal.Fetch<TrangThaiCuaHocVien>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="DIC_ChucVu"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the DIC_ChucVu to delete.</param>
        public static void DeleteTrangThaiCuaHocVien(int id)
        {
            DataPortal.Delete<TrangThaiCuaHocVien>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_ChucVu"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewTrangThaiCuaHocVien(EventHandler<DataPortalResult<TrangThaiCuaHocVien>> callback)
        {
            DataPortal.BeginCreate<TrangThaiCuaHocVien>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DIC_ChucVu"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the DIC_ChucVu to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetTrangThaiCuaHocVien(int id, EventHandler<DataPortalResult<TrangThaiCuaHocVien>> callback)
        {
            DataPortal.BeginFetch<TrangThaiCuaHocVien>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="DIC_ChucVu"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the DIC_ChucVu to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteTrangThaiCuaHocVien(int id, EventHandler<DataPortalResult<TrangThaiCuaHocVien>> callback)
        {
            DataPortal.BeginDelete<TrangThaiCuaHocVien>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_ChucVu"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TrangThaiCuaHocVien()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DIC_ChucVu"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDTrangThaiProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(TenTrangThaiProperty, null);
            LoadProperty(GhiChuProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="DIC_ChucVu"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(Int64 id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DM_TrangThaiHocVien_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDTrangThai", id).DbType = DbType.Int64;
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
        /// Loads a <see cref="DIC_ChucVu"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDTrangThaiProperty, dr.GetInt64("IDTrangThai"));
            LoadProperty(TenTrangThaiProperty, dr.GetString("TenTrangThai"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DIC_ChucVu"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DM_TrangThaiHocVien_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDTrangThai", ReadProperty(IDTrangThaiProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@TenTrangThai", ReadProperty(TenTrangThaiProperty) == null ? (object)DBNull.Value : ReadProperty(TenTrangThaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDTrangThaiProperty, (Int64)cmd.Parameters["@IDTrangThai"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DIC_ChucVu"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DM_TrangThaiHocVien_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDTrangThai", ReadProperty(IDTrangThaiProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@TenTrangThai", ReadProperty(TenTrangThaiProperty) == null ? (object)DBNull.Value : ReadProperty(TenTrangThaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DIC_ChucVu"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(IDTrangThai);
        }

        /// <summary>
        /// Deletes the <see cref="DIC_ChucVu"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(Int64 id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DM_TrangThaiHocVien_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDTrangThai", id).DbType = DbType.Int64;
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
