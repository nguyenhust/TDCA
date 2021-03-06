//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DT_ChinhQuy_ThoiKhoaBieu_Info
// ObjectType:  DT_ChinhQuy_ThoiKhoaBieu_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    /// <summary>
    /// DT_ChinhQuy_ThoiKhoaBieu_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DT_ChinhQuy_ThoiKhoaBieu_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DT_ChinhQuy_ThoiKhoaBieu_Info : BusinessBase<DT_ChinhQuy_ThoiKhoaBieu_Info>
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
        /// Maintains metadata about <see cref="idLopHoc"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdLopHocProperty = RegisterProperty<int?>(p => p.IdLopHoc, "id Lop Hoc");
        /// <summary>
        /// Gets or sets the id Lop Hoc.
        /// </summary>
        /// <value>The id Lop Hoc.</value>
        public int? IdLopHoc
        {
            get { return GetProperty(IdLopHocProperty); }
            set { SetProperty(IdLopHocProperty, value); }
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
        /// Maintains metadata about <see cref="TenHienThiTrenCTT"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenHienThiTrenCTTProperty = RegisterProperty<string>(p => p.TenHienThiTrenCTT, "Ten Hien Thi Tren CTT");
        /// <summary>
        /// Gets or sets the Ten Hien Thi Tren CTT.
        /// </summary>
        /// <value>The Ten Hien Thi Tren CTT.</value>
        public string TenHienThiTrenCTT
        {
            get { return GetProperty(TenHienThiTrenCTTProperty); }
            set { SetProperty(TenHienThiTrenCTTProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object.</returns>
        internal static DT_ChinhQuy_ThoiKhoaBieu_Info NewDT_ChinhQuy_ThoiKhoaBieu_Info()
        {
            return DataPortal.CreateChild<DT_ChinhQuy_ThoiKhoaBieu_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDT_ChinhQuy_ThoiKhoaBieu_Info(EventHandler<DataPortalResult<DT_ChinhQuy_ThoiKhoaBieu_Info>> callback)
        {
            DataPortal.BeginCreate<DT_ChinhQuy_ThoiKhoaBieu_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object.</returns>
        internal static DT_ChinhQuy_ThoiKhoaBieu_Info GetDT_ChinhQuy_ThoiKhoaBieu_Info(SafeDataReader dr)
        {
            DT_ChinhQuy_ThoiKhoaBieu_Info obj = new DT_ChinhQuy_ThoiKhoaBieu_Info();
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
        /// Initializes a new instance of the <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_ChinhQuy_ThoiKhoaBieu_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(LinkProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(TenHienThiTrenCTTProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdLopHocProperty, dr.GetInt32("IdLopHoc"));
            LoadProperty(LinkProperty, dr.GetString("Link"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(TenHienThiTrenCTTProperty, dr.GetString("TenHienThiTrenCTT"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_ThoiKhoaBieu_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idLopHoc", ReadProperty(IdLopHocProperty) == null ? (object)DBNull.Value : ReadProperty(IdLopHocProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Link", ReadProperty(LinkProperty) == null ? (object)DBNull.Value : ReadProperty(LinkProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenHienThiTrenCTT", ReadProperty(TenHienThiTrenCTTProperty) == null ? (object)DBNull.Value : ReadProperty(TenHienThiTrenCTTProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IdProperty, (int) cmd.Parameters["@id"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_ThoiKhoaBieu_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idLopHoc", ReadProperty(IdLopHocProperty) == null ? (object)DBNull.Value : ReadProperty(IdLopHocProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Link", ReadProperty(LinkProperty) == null ? (object)DBNull.Value : ReadProperty(LinkProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenHienThiTrenCTT", ReadProperty(TenHienThiTrenCTTProperty) == null ? (object)DBNull.Value : ReadProperty(TenHienThiTrenCTTProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DT_ChinhQuy_ThoiKhoaBieu_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_ThoiKhoaBieu_Info_delete", ctx.Connection))
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
