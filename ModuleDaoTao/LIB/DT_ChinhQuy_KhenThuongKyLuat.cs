//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DT_ChinhQuy_KhenThuongKyLuat
// ObjectType:  DT_ChinhQuy_KhenThuongKyLuat
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    /// <summary>
    /// DT_ChinhQuy_KhenThuongKyLuat (editable root object).<br/>
    /// This is a generated base class of <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> business object.
    /// </summary>
    [Serializable]
    public partial class DT_ChinhQuy_KhenThuongKyLuat : BusinessBase<DT_ChinhQuy_KhenThuongKyLuat>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="id"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(p => p.Id, "id");
        /// <summary>
        /// Gets the id.
        /// </summary>
        /// <value>The id.</value>
        public int Id
        {
            get { return GetProperty(IdProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idHocVien"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdHocVienProperty = RegisterProperty<int?>(p => p.IdHocVien, "id Hoc Vien");
        /// <summary>
        /// Gets or sets the id Hoc Vien.
        /// </summary>
        /// <value>The id Hoc Vien.</value>
        public int? IdHocVien
        {
            get { return GetProperty(IdHocVienProperty); }
            set { SetProperty(IdHocVienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HinhThuc"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> HinhThucProperty = RegisterProperty<string>(p => p.HinhThuc, "Hinh Thuc");
        /// <summary>
        /// Gets or sets the Hinh Thuc.
        /// </summary>
        /// <value>The Hinh Thuc.</value>
        public string HinhThuc
        {
            get { return GetProperty(HinhThucProperty); }
            set { SetProperty(HinhThucProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Ngay"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayProperty = RegisterProperty<SmartDate>(p => p.Ngay, "Ngay");
        /// <summary>
        /// Gets or sets the Ngay.
        /// </summary>
        /// <value>The Ngay.</value>
        public string Ngay
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="LyDo"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> LyDoProperty = RegisterProperty<string>(p => p.LyDo, "Ly Do");
        /// <summary>
        /// Gets or sets the Ly Do.
        /// </summary>
        /// <value>The Ly Do.</value>
        public string LyDo
        {
            get { return GetProperty(LyDoProperty); }
            set { SetProperty(LyDoProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object.</returns>
        public static DT_ChinhQuy_KhenThuongKyLuat NewDT_ChinhQuy_KhenThuongKyLuat()
        {
            return DataPortal.Create<DT_ChinhQuy_KhenThuongKyLuat>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the DT_ChinhQuy_KhenThuongKyLuat to fetch.</param>
        /// <returns>A reference to the fetched <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object.</returns>
        public static DT_ChinhQuy_KhenThuongKyLuat GetDT_ChinhQuy_KhenThuongKyLuat(int id)
        {
            return DataPortal.Fetch<DT_ChinhQuy_KhenThuongKyLuat>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the DT_ChinhQuy_KhenThuongKyLuat to delete.</param>
        public static void DeleteDT_ChinhQuy_KhenThuongKyLuat(int id)
        {
            DataPortal.Delete<DT_ChinhQuy_KhenThuongKyLuat>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDT_ChinhQuy_KhenThuongKyLuat(EventHandler<DataPortalResult<DT_ChinhQuy_KhenThuongKyLuat>> callback)
        {
            DataPortal.BeginCreate<DT_ChinhQuy_KhenThuongKyLuat>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the DT_ChinhQuy_KhenThuongKyLuat to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDT_ChinhQuy_KhenThuongKyLuat(int id, EventHandler<DataPortalResult<DT_ChinhQuy_KhenThuongKyLuat>> callback)
        {
            DataPortal.BeginFetch<DT_ChinhQuy_KhenThuongKyLuat>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the DT_ChinhQuy_KhenThuongKyLuat to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteDT_ChinhQuy_KhenThuongKyLuat(int id, EventHandler<DataPortalResult<DT_ChinhQuy_KhenThuongKyLuat>> callback)
        {
            DataPortal.BeginDelete<DT_ChinhQuy_KhenThuongKyLuat>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_ChinhQuy_KhenThuongKyLuat()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(HinhThucProperty, null);
            LoadProperty(NgayProperty, null);
            LoadProperty(LyDoProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The id.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_KhenThuongKyLuat_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id).DbType = DbType.Int32;
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
        /// Loads a <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdHocVienProperty, dr.GetInt32("IdHocVien"));
            LoadProperty(HinhThucProperty, dr.GetString("HinhThuc"));
            LoadProperty(NgayProperty, dr.GetDateTime("Ngay"));
            LoadProperty(LyDoProperty, dr.GetString("LyDo"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_KhenThuongKyLuat_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idHocVien", ReadProperty(IdHocVienProperty) == null ? (object)DBNull.Value : ReadProperty(IdHocVienProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@HinhThuc", ReadProperty(HinhThucProperty) == null ? (object)DBNull.Value : ReadProperty(HinhThucProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Ngay", ReadProperty(NgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@LyDo", ReadProperty(LyDoProperty) == null ? (object)DBNull.Value : ReadProperty(LyDoProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IdProperty, (int) cmd.Parameters["@id"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_KhenThuongKyLuat_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idHocVien", ReadProperty(IdHocVienProperty) == null ? (object)DBNull.Value : ReadProperty(IdHocVienProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@HinhThuc", ReadProperty(HinhThucProperty) == null ? (object)DBNull.Value : ReadProperty(HinhThucProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Ngay", ReadProperty(NgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@LyDo", ReadProperty(LyDoProperty) == null ? (object)DBNull.Value : ReadProperty(LyDoProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(Id);
        }

        /// <summary>
        /// Deletes the <see cref="DT_ChinhQuy_KhenThuongKyLuat"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_KhenThuongKyLuat_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id).DbType = DbType.Int32;
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
