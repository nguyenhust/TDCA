//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    TT_PhongVan
// ObjectType:  TT_PhongVan
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace TruyenThong
{

    /// <summary>
    /// TT_PhongVan (editable root object).<br/>
    /// This is a generated base class of <see cref="TT_PhongVan"/> business object.
    /// </summary>
    [Serializable]
    public partial class TT_PhongVan : BusinessBase<TT_PhongVan>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDProperty = RegisterProperty<Int64>(p => p.ID, "ID");
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID
        {
            get { return GetProperty(IDProperty); }
            set { SetProperty(IDProperty, value); }
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
        /// Maintains metadata about <see cref="CoQuanCT"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> CoQuanCTProperty = RegisterProperty<string>(p => p.CoQuanCT, "Co Quan CT");
        /// <summary>
        /// Gets or sets the Co Quan CT.
        /// </summary>
        /// <value>The Co Quan CT.</value>
        public string CoQuanCT
        {
            get { return GetProperty(CoQuanCTProperty); }
            set { SetProperty(CoQuanCTProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="KhoaLamViec"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> KhoaLamViecProperty = RegisterProperty<string>(p => p.KhoaLamViec, "Khoa Lam Viec");
        /// <summary>
        /// Gets or sets the Khoa Lam Viec.
        /// </summary>
        /// <value>The Khoa Lam Viec.</value>
        public string KhoaLamViec
        {
            get { return GetProperty(KhoaLamViecProperty); }
            set { SetProperty(KhoaLamViecProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoGiayGioiThieu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoGiayGioiThieuProperty = RegisterProperty<string>(p => p.SoGiayGioiThieu, "So Giay Gioi Thieu");
        /// <summary>
        /// Gets or sets the So Giay Gioi Thieu.
        /// </summary>
        /// <value>The So Giay Gioi Thieu.</value>
        public string SoGiayGioiThieu
        {
            get { return GetProperty(SoGiayGioiThieuProperty); }
            set { SetProperty(SoGiayGioiThieuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoDienThoai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoDienThoaiProperty = RegisterProperty<string>(p => p.SoDienThoai, "So Dien Thoai");
        /// <summary>
        /// Gets or sets the So Dien Thoai.
        /// </summary>
        /// <value>The So Dien Thoai.</value>
        public string SoDienThoai
        {
            get { return GetProperty(SoDienThoaiProperty); }
            set { SetProperty(SoDienThoaiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGian"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianProperty = RegisterProperty<SmartDate>(p => p.ThoiGian, "Thoi Gian");
        /// <summary>
        /// Gets or sets the Thoi Gian.
        /// </summary>
        /// <value>The Thoi Gian.</value>
        public string ThoiGian
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianProperty); }
            set { SetPropertyConvert<SmartDate, String>(ThoiGianProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Ghichu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GhichuProperty = RegisterProperty<string>(p => p.Ghichu, "Ghichu");
        /// <summary>
        /// Gets or sets the Ghichu.
        /// </summary>
        /// <value>The Ghichu.</value>
        public string Ghichu
        {
            get { return GetProperty(GhichuProperty); }
            set { SetProperty(GhichuProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="TT_PhongVan"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="TT_PhongVan"/> object.</returns>
        public static TT_PhongVan NewTT_PhongVan()
        {
            return DataPortal.Create<TT_PhongVan>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="TT_PhongVan"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the TT_PhongVan to fetch.</param>
        /// <returns>A reference to the fetched <see cref="TT_PhongVan"/> object.</returns>
        public static TT_PhongVan GetTT_PhongVan(Int64 id)
        {
            return DataPortal.Fetch<TT_PhongVan>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="TT_PhongVan"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the TT_PhongVan to delete.</param>
        public static void DeleteTT_PhongVan(Int64 id)
        {
            DataPortal.Delete<TT_PhongVan>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="TT_PhongVan"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewTT_PhongVan(EventHandler<DataPortalResult<TT_PhongVan>> callback)
        {
            DataPortal.BeginCreate<TT_PhongVan>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="TT_PhongVan"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the TT_PhongVan to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetTT_PhongVan(Int64 id, EventHandler<DataPortalResult<TT_PhongVan>> callback)
        {
            DataPortal.BeginFetch<TT_PhongVan>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="TT_PhongVan"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the TT_PhongVan to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteTT_PhongVan(Int64 id, EventHandler<DataPortalResult<TT_PhongVan>> callback)
        {
            DataPortal.BeginDelete<TT_PhongVan>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TT_PhongVan"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TT_PhongVan()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="TT_PhongVan"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(SoGiayGioiThieuProperty, null);
            LoadProperty(SoDienThoaiProperty, null);
            LoadProperty(GhichuProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="TT_PhongVan"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(Int64 id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_PhongVan_Get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id).DbType = DbType.Int64;
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
        /// Loads a <see cref="TT_PhongVan"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, data.ID);
            LoadProperty(NoiDungProperty, data.NoiDung);
            LoadProperty(CoQuanCTProperty, data.CoQuanCT);
            LoadProperty(KhoaLamViecProperty, data.KhoaLamViec);
            LoadProperty(SoGiayGioiThieuProperty, data.SoGiayGioiThieu);
            LoadProperty(SoDienThoaiProperty, data.SoDienThoai);
            LoadProperty(ThoiGianProperty, data.ThoiGian);
            LoadProperty(GhichuProperty, data.Ghichu);
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="TT_PhongVan"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_PhongVan_Add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CoQuanCT", ReadProperty(CoQuanCTProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@KhoaLamViec", ReadProperty(KhoaLamViecProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoGiayGioiThieu", ReadProperty(SoGiayGioiThieuProperty) == null ? (object)DBNull.Value : ReadProperty(SoGiayGioiThieuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoDienThoai", ReadProperty(SoDienThoaiProperty) == null ? (object)DBNull.Value : ReadProperty(SoDienThoaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiGian", ReadProperty(ThoiGianProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@Ghichu", ReadProperty(GhichuProperty) == null ? (object)DBNull.Value : ReadProperty(GhichuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="TT_PhongVan"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_PhongVan_Upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CoQuanCT", ReadProperty(CoQuanCTProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@KhoaLamViec", ReadProperty(KhoaLamViecProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoGiayGioiThieu", ReadProperty(SoGiayGioiThieuProperty) == null ? (object)DBNull.Value : ReadProperty(SoGiayGioiThieuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoDienThoai", ReadProperty(SoDienThoaiProperty) == null ? (object)DBNull.Value : ReadProperty(SoDienThoaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiGian", ReadProperty(ThoiGianProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@Ghichu", ReadProperty(GhichuProperty) == null ? (object)DBNull.Value : ReadProperty(GhichuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="TT_PhongVan"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="TT_PhongVan"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(Int64 id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_PhongVan_Delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id).DbType = DbType.Int64;
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
