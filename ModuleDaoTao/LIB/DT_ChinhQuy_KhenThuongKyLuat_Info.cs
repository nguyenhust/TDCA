//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DT_ChinhQuy_KhenThuongKyLuat_Info
// ObjectType:  DT_ChinhQuy_KhenThuongKyLuat_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    /// <summary>
    /// DT_ChinhQuy_KhenThuongKyLuat_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DT_ChinhQuy_KhenThuongKyLuat_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DT_ChinhQuy_KhenThuongKyLuat_Info : BusinessBase<DT_ChinhQuy_KhenThuongKyLuat_Info>
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
        /// Factory method. Creates a new <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object.</returns>
        internal static DT_ChinhQuy_KhenThuongKyLuat_Info NewDT_ChinhQuy_KhenThuongKyLuat_Info()
        {
            return DataPortal.CreateChild<DT_ChinhQuy_KhenThuongKyLuat_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDT_ChinhQuy_KhenThuongKyLuat_Info(EventHandler<DataPortalResult<DT_ChinhQuy_KhenThuongKyLuat_Info>> callback)
        {
            DataPortal.BeginCreate<DT_ChinhQuy_KhenThuongKyLuat_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object.</returns>
        internal static DT_ChinhQuy_KhenThuongKyLuat_Info GetDT_ChinhQuy_KhenThuongKyLuat_Info(SafeDataReader dr)
        {
            DT_ChinhQuy_KhenThuongKyLuat_Info obj = new DT_ChinhQuy_KhenThuongKyLuat_Info();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_ChinhQuy_KhenThuongKyLuat_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(HinhThucProperty, null);
            LoadProperty(NgayProperty, null);
            LoadProperty(LyDoProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object from the given SafeDataReader.
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
        /// Inserts a new <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_KhenThuongKyLuat_Info_add", ctx.Connection))
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
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_KhenThuongKyLuat_Info_update", ctx.Connection))
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
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DT_ChinhQuy_KhenThuongKyLuat_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_KhenThuongKyLuat_Info_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
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
