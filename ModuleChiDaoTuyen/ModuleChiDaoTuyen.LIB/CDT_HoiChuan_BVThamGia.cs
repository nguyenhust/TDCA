//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_HoiChuan_BVThamGia
// ObjectType:  CDT_HoiChuan_BVThamGia
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
    /// CDT_HoiChuan_BVThamGia (editable root object).<br/>
    /// This is a generated base class of <see cref="CDT_HoiChuan_BVThamGia"/> business object.
    /// </summary>
    [Serializable]
    public partial class CDT_HoiChuan_BVThamGia : BusinessBase<CDT_HoiChuan_BVThamGia>
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
        /// Maintains metadata about <see cref="idBenhVien"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IdBenhVienProperty = RegisterProperty<Int64?>(p => p.IdBenhVien, "id Benh Vien");
        /// <summary>
        /// Gets or sets the id Benh Vien.
        /// </summary>
        /// <value>The id Benh Vien.</value>
        public Int64? IdBenhVien
        {
            get { return GetProperty(IdBenhVienProperty); }
            set { SetProperty(IdBenhVienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idHoiChuan"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdHoiChuanProperty = RegisterProperty<int?>(p => p.IdHoiChuan, "id Hoi Chuan");
        /// <summary>
        /// Gets or sets the id Hoi Chuan.
        /// </summary>
        /// <value>The id Hoi Chuan.</value>
        public int? IdHoiChuan
        {
            get { return GetProperty(IdHoiChuanProperty); }
            set { SetProperty(IdHoiChuanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuongThamDu"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SoLuongThamDuProperty = RegisterProperty<int?>(p => p.SoLuongThamDu, "So Luong Tham Du");
        /// <summary>
        /// Gets or sets the So Luong Tham Du.
        /// </summary>
        /// <value>The So Luong Tham Du.</value>
        public int? SoLuongThamDu
        {
            get { return GetProperty(SoLuongThamDuProperty); }
            set { SetProperty(SoLuongThamDuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuongBaoCao"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SoLuongBaoCaoProperty = RegisterProperty<int?>(p => p.SoLuongBaoCao, "So Luong Bao Cao");
        /// <summary>
        /// Gets or sets the So Luong Bao Cao.
        /// </summary>
        /// <value>The So Luong Bao Cao.</value>
        public int? SoLuongBaoCao
        {
            get { return GetProperty(SoLuongBaoCaoProperty); }
            set { SetProperty(SoLuongBaoCaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TenBenhVien"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenBenhVienProperty = RegisterProperty<string>(p => p.TenBenhVien, "Ten Benh Vien");
        /// <summary>
        /// Gets or sets the Ten Benh Vien.
        /// </summary>
        /// <value>The Ten Benh Vien.</value>
        public string TenBenhVien
        {
            get { return GetProperty(TenBenhVienProperty); }
            set { SetProperty(TenBenhVienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TinhThanh"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TinhThanhProperty = RegisterProperty<string>(p => p.TinhThanh, "Tinh Thanh");
        /// <summary>
        /// Gets or sets the Tinh Thanh.
        /// </summary>
        /// <value>The Tinh Thanh.</value>
        public string TinhThanh
        {
            get { return GetProperty(TinhThanhProperty); }
            set { SetProperty(TinhThanhProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CoBaoCao"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool?> CoBaoCaoProperty = RegisterProperty<bool?>(p => p.CoBaoCao, "Co Bao Cao");
        /// <summary>
        /// Gets or sets the Co Bao Cao.
        /// </summary>
        /// <value><c>true</c> if Co Bao Cao; <c>false</c> if not Co Bao Cao; otherwise, <c>null</c>.</value>
        public bool? CoBaoCao
        {
            get { return GetProperty(CoBaoCaoProperty); }
            set { SetProperty(CoBaoCaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idTinhThanh"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IdTinhThanhProperty = RegisterProperty<Int64?>(p => p.IdTinhThanh, "id Tinh Thanh");
        /// <summary>
        /// Gets or sets the id Tinh Thanh.
        /// </summary>
        /// <value>The id Tinh Thanh.</value>
        public Int64? IdTinhThanh
        {
            get { return GetProperty(IdTinhThanhProperty); }
            set { SetProperty(IdTinhThanhProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_HoiChuan_BVThamGia"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_HoiChuan_BVThamGia"/> object.</returns>
        public static CDT_HoiChuan_BVThamGia NewCDT_HoiChuan_BVThamGia()
        {
            return DataPortal.Create<CDT_HoiChuan_BVThamGia>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_HoiChuan_BVThamGia"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the CDT_HoiChuan_BVThamGia to fetch.</param>
        /// <returns>A reference to the fetched <see cref="CDT_HoiChuan_BVThamGia"/> object.</returns>
        public static CDT_HoiChuan_BVThamGia GetCDT_HoiChuan_BVThamGia(int id)
        {
            return DataPortal.Fetch<CDT_HoiChuan_BVThamGia>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="CDT_HoiChuan_BVThamGia"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the CDT_HoiChuan_BVThamGia to delete.</param>
        public static void DeleteCDT_HoiChuan_BVThamGia(int id)
        {
            DataPortal.Delete<CDT_HoiChuan_BVThamGia>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_HoiChuan_BVThamGia"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_HoiChuan_BVThamGia(EventHandler<DataPortalResult<CDT_HoiChuan_BVThamGia>> callback)
        {
            DataPortal.BeginCreate<CDT_HoiChuan_BVThamGia>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_HoiChuan_BVThamGia"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the CDT_HoiChuan_BVThamGia to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_HoiChuan_BVThamGia(int id, EventHandler<DataPortalResult<CDT_HoiChuan_BVThamGia>> callback)
        {
            DataPortal.BeginFetch<CDT_HoiChuan_BVThamGia>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="CDT_HoiChuan_BVThamGia"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the CDT_HoiChuan_BVThamGia to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteCDT_HoiChuan_BVThamGia(int id, EventHandler<DataPortalResult<CDT_HoiChuan_BVThamGia>> callback)
        {
            DataPortal.BeginDelete<CDT_HoiChuan_BVThamGia>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_HoiChuan_BVThamGia"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_HoiChuan_BVThamGia()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_HoiChuan_BVThamGia"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(TenBenhVienProperty, null);
            LoadProperty(TinhThanhProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_HoiChuan_BVThamGia"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The id.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_BVThamGia_get", ctx.Connection))
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
        /// Loads a <see cref="CDT_HoiChuan_BVThamGia"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdBenhVienProperty, dr.GetInt64("IdBenhVien"));
            LoadProperty(TenBenhVienProperty, dr.GetString("TenBenhVien"));
            LoadProperty(IdHoiChuanProperty, dr.GetInt32("IdHoiChuan"));
            LoadProperty(SoLuongThamDuProperty, dr.GetInt32("SoLuongThamDu"));
            LoadProperty(SoLuongBaoCaoProperty, dr.GetInt32("SoLuongBaoCao"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_HoiChuan_BVThamGia"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_BVThamGia_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idBenhVien", ReadProperty(IdBenhVienProperty) == null ? (object)DBNull.Value : ReadProperty(IdBenhVienProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@idHoiChuan", ReadProperty(IdHoiChuanProperty) == null ? (object)DBNull.Value : ReadProperty(IdHoiChuanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongThamDu", ReadProperty(SoLuongThamDuProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongThamDuProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongBaoCao", ReadProperty(SoLuongBaoCaoProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongBaoCaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TenBenhVien", ReadProperty(TenBenhVienProperty) == null ? (object)DBNull.Value : ReadProperty(TenBenhVienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TinhThanh", ReadProperty(TinhThanhProperty) == null ? (object)DBNull.Value : ReadProperty(TinhThanhProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CoBaoCao", ReadProperty(CoBaoCaoProperty) == null ? (object)DBNull.Value : ReadProperty(CoBaoCaoProperty).Value).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@idTinhThanh", ReadProperty(IdTinhThanhProperty) == null ? (object)DBNull.Value : ReadProperty(IdTinhThanhProperty).Value).DbType = DbType.Int64;
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
        /// Updates in the database all changes made to the <see cref="CDT_HoiChuan_BVThamGia"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_BVThamGia_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idBenhVien", ReadProperty(IdBenhVienProperty) == null ? (object)DBNull.Value : ReadProperty(IdBenhVienProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@idHoiChuan", ReadProperty(IdHoiChuanProperty) == null ? (object)DBNull.Value : ReadProperty(IdHoiChuanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongThamDu", ReadProperty(SoLuongThamDuProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongThamDuProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongBaoCao", ReadProperty(SoLuongBaoCaoProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongBaoCaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TenBenhVien", ReadProperty(TenBenhVienProperty) == null ? (object)DBNull.Value : ReadProperty(TenBenhVienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TinhThanh", ReadProperty(TinhThanhProperty) == null ? (object)DBNull.Value : ReadProperty(TinhThanhProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CoBaoCao", ReadProperty(CoBaoCaoProperty) == null ? (object)DBNull.Value : ReadProperty(CoBaoCaoProperty).Value).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@idTinhThanh", ReadProperty(IdTinhThanhProperty) == null ? (object)DBNull.Value : ReadProperty(IdTinhThanhProperty).Value).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_HoiChuan_BVThamGia"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(Id);
        }

        /// <summary>
        /// Deletes the <see cref="CDT_HoiChuan_BVThamGia"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_BVThamGia_delete", ctx.Connection))
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