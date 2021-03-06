using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{
    /// <summary>
    /// DIC_LoaiTrangThietBi (editable root object).<br/>
    /// This is a generated base class of <see cref="DIC_Loai"/> business object.
    /// </summary>
    [Serializable]
    public partial class DIC_LoaiTrangThietBi : BusinessBase<DIC_LoaiTrangThietBi>
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
        /// Maintains metadata about <see cref="Ma"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaProperty = RegisterProperty<string>(p => p.Ma, "Ma");
        /// <summary>
        /// Gets or sets the Ma.
        /// </summary>
        /// <value>The Ma.</value>
        public string Ma
        {
            get { return GetProperty(MaProperty); }
            set { SetProperty(MaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Ten"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenProperty = RegisterProperty<string>(p => p.Ten, "Ten");
        /// <summary>
        /// Gets or sets the Ten.
        /// </summary>
        /// <value>The Ten.</value>
        public string Ten
        {
            get { return GetProperty(TenProperty); }
            set { SetProperty(TenProperty, value); }
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
        /// Maintains metadata about <see cref="SuDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool?> SuDungProperty = RegisterProperty<bool?>(p => p.SuDung, "Su Dung");
        /// <summary>
        /// Gets or sets the Su Dung.
        /// </summary>
        /// <value><c>true</c> if Su Dung; <c>false</c> if not Su Dung; otherwise, <c>null</c>.</value>
        public bool? SuDung
        {
            get { return GetProperty(SuDungProperty); }
            set { SetProperty(SuDungProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_Loai"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_Loai"/> object.</returns>
        public static DIC_LoaiTrangThietBi NewDIC_LoaiTrangThietBi()
        {
            return DataPortal.Create<DIC_LoaiTrangThietBi>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_Loai"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the DIC_Loai to fetch.</param>
        /// <returns>A reference to the fetched <see cref="DIC_Loai"/> object.</returns>
        public static DIC_LoaiTrangThietBi GetDIC_LoaiTrangThietBi(int id)
        {
            return DataPortal.Fetch<DIC_LoaiTrangThietBi>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="DIC_Loai"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the DIC_Loai to delete.</param>
        public static void DeleteDIC_LoaiTrangThietBi(int id)
        {
            DataPortal.Delete<DIC_LoaiTrangThietBi>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_Loai"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDIC_LoaiTrangThietBi(EventHandler<DataPortalResult<DIC_LoaiTrangThietBi>> callback)
        {
            DataPortal.BeginCreate<DIC_LoaiTrangThietBi>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DIC_Loai"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the DIC_Loai to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDIC_LoaiTrangThietBi(int id, EventHandler<DataPortalResult<DIC_LoaiTrangThietBi>> callback)
        {
            DataPortal.BeginFetch<DIC_LoaiTrangThietBi>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="DIC_Loai"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the DIC_Loai to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteDIC_LoaiTrangThietBi(int id, EventHandler<DataPortalResult<DIC_LoaiTrangThietBi>> callback)
        {
            DataPortal.BeginDelete<DIC_LoaiTrangThietBi>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_Loai"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_LoaiTrangThietBi()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DIC_Loai"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(MaProperty, null);
            LoadProperty(GhiChuProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="DIC_Loai"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_LoaiTrangThietBi_get", ctx.Connection))
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
        /// Loads a <see cref="DIC_Loai"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(MaProperty, dr.GetString("Ma"));
            LoadProperty(TenProperty, dr.GetString("Ten"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(SuDungProperty, dr.GetBoolean("SuDung"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DIC_Loai"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_LoaiTrangThietBi_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@Ma", ReadProperty(MaProperty) == null ? (object)DBNull.Value : ReadProperty(MaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SuDung", ReadProperty(SuDungProperty) == null ? (object)DBNull.Value : ReadProperty(SuDungProperty).Value).DbType = DbType.Boolean;
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
        /// Updates in the database all changes made to the <see cref="DIC_Loai"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_LoaiTrangThietBi_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Ma", ReadProperty(MaProperty) == null ? (object)DBNull.Value : ReadProperty(MaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SuDung", ReadProperty(SuDungProperty) == null ? (object)DBNull.Value : ReadProperty(SuDungProperty).Value).DbType = DbType.Boolean;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DIC_Loai"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="DIC_Loai"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_LoaiTrangThietBi_delete", ctx.Connection))
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
