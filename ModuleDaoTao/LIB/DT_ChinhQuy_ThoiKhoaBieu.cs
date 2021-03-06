//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DT_ChinhQuy_ThoiKhoaBieu
// ObjectType:  DT_ChinhQuy_ThoiKhoaBieu
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    /// <summary>
    /// DT_ChinhQuy_ThoiKhoaBieu (editable root object).<br/>
    /// This is a generated base class of <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> business object.
    /// </summary>
    [Serializable]
    public partial class DT_ChinhQuy_ThoiKhoaBieu : BusinessBase<DT_ChinhQuy_ThoiKhoaBieu>
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
        /// Factory method. Creates a new <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object.</returns>
        public static DT_ChinhQuy_ThoiKhoaBieu NewDT_ChinhQuy_ThoiKhoaBieu()
        {
            return DataPortal.Create<DT_ChinhQuy_ThoiKhoaBieu>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the DT_ChinhQuy_ThoiKhoaBieu to fetch.</param>
        /// <returns>A reference to the fetched <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object.</returns>
        public static DT_ChinhQuy_ThoiKhoaBieu GetDT_ChinhQuy_ThoiKhoaBieu(int id)
        {
            return DataPortal.Fetch<DT_ChinhQuy_ThoiKhoaBieu>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the DT_ChinhQuy_ThoiKhoaBieu to delete.</param>
        public static void DeleteDT_ChinhQuy_ThoiKhoaBieu(int id)
        {
            DataPortal.Delete<DT_ChinhQuy_ThoiKhoaBieu>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDT_ChinhQuy_ThoiKhoaBieu(EventHandler<DataPortalResult<DT_ChinhQuy_ThoiKhoaBieu>> callback)
        {
            DataPortal.BeginCreate<DT_ChinhQuy_ThoiKhoaBieu>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the DT_ChinhQuy_ThoiKhoaBieu to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDT_ChinhQuy_ThoiKhoaBieu(int id, EventHandler<DataPortalResult<DT_ChinhQuy_ThoiKhoaBieu>> callback)
        {
            DataPortal.BeginFetch<DT_ChinhQuy_ThoiKhoaBieu>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the DT_ChinhQuy_ThoiKhoaBieu to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteDT_ChinhQuy_ThoiKhoaBieu(int id, EventHandler<DataPortalResult<DT_ChinhQuy_ThoiKhoaBieu>> callback)
        {
            DataPortal.BeginDelete<DT_ChinhQuy_ThoiKhoaBieu>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_ChinhQuy_ThoiKhoaBieu()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(LinkProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(TenHienThiTrenCTTProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The id.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_ThoiKhoaBieu_get", ctx.Connection))
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
        /// Loads a <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object from the given SafeDataReader.
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
        /// Inserts a new <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_ThoiKhoaBieu_add", ctx.Connection))
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
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_ThoiKhoaBieu_update", ctx.Connection))
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
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(Id);
        }

        /// <summary>
        /// Deletes the <see cref="DT_ChinhQuy_ThoiKhoaBieu"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_ChinhQuy_ThoiKhoaBieu_delete", ctx.Connection))
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
