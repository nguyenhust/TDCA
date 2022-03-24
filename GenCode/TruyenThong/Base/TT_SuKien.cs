//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    TT_SuKien
// ObjectType:  TT_SuKien
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace TruyenThong
{

    /// <summary>
    /// TT_SuKien (editable root object).<br/>
    /// This is a generated base class of <see cref="TT_SuKien"/> business object.
    /// </summary>
    [Serializable]
    public partial class TT_SuKien : BusinessBase<TT_SuKien>
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
        /// Maintains metadata about <see cref="IDChuyenNganh"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IDChuyenNganhProperty = RegisterProperty<int>(p => p.IDChuyenNganh, "IDChuyen Nganh");
        /// <summary>
        /// Gets or sets the IDChuyen Nganh.
        /// </summary>
        /// <value>The IDChuyen Nganh.</value>
        public int IDChuyenNganh
        {
            get { return GetProperty(IDChuyenNganhProperty); }
            set { SetProperty(IDChuyenNganhProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DiaDiem"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DiaDiemProperty = RegisterProperty<string>(p => p.DiaDiem, "Dia Diem");
        /// <summary>
        /// Gets or sets the Dia Diem.
        /// </summary>
        /// <value>The Dia Diem.</value>
        public string DiaDiem
        {
            get { return GetProperty(DiaDiemProperty); }
            set { SetProperty(DiaDiemProperty, value); }
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
        /// Maintains metadata about <see cref="IDLoai"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IDLoaiProperty = RegisterProperty<int>(p => p.IDLoai, "IDLoai");
        /// <summary>
        /// Gets or sets the IDLoai.
        /// </summary>
        /// <value>The IDLoai.</value>
        public int IDLoai
        {
            get { return GetProperty(IDLoaiProperty); }
            set { SetProperty(IDLoaiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChuTri"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChuTriProperty = RegisterProperty<string>(p => p.ChuTri, "Chu Tri");
        /// <summary>
        /// Gets or sets the Chu Tri.
        /// </summary>
        /// <value>The Chu Tri.</value>
        public string ChuTri
        {
            get { return GetProperty(ChuTriProperty); }
            set { SetProperty(ChuTriProperty, value); }
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
        /// Factory method. Creates a new <see cref="TT_SuKien"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="TT_SuKien"/> object.</returns>
        public static TT_SuKien NewTT_SuKien()
        {
            return DataPortal.Create<TT_SuKien>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="TT_SuKien"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the TT_SuKien to fetch.</param>
        /// <returns>A reference to the fetched <see cref="TT_SuKien"/> object.</returns>
        public static TT_SuKien GetTT_SuKien(Int64 id)
        {
            return DataPortal.Fetch<TT_SuKien>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="TT_SuKien"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the TT_SuKien to delete.</param>
        public static void DeleteTT_SuKien(Int64 id)
        {
            DataPortal.Delete<TT_SuKien>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="TT_SuKien"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewTT_SuKien(EventHandler<DataPortalResult<TT_SuKien>> callback)
        {
            DataPortal.BeginCreate<TT_SuKien>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="TT_SuKien"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the TT_SuKien to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetTT_SuKien(Int64 id, EventHandler<DataPortalResult<TT_SuKien>> callback)
        {
            DataPortal.BeginFetch<TT_SuKien>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="TT_SuKien"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the TT_SuKien to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteTT_SuKien(Int64 id, EventHandler<DataPortalResult<TT_SuKien>> callback)
        {
            DataPortal.BeginDelete<TT_SuKien>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TT_SuKien"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TT_SuKien()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="TT_SuKien"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(DiaDiemProperty, null);
            LoadProperty(ThoiGianProperty, null);
            LoadProperty(ChuTriProperty, null);
            LoadProperty(GhiChuProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="TT_SuKien"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(Int64 id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_SuKien_Get", ctx.Connection))
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
        /// Loads a <see cref="TT_SuKien"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, data.ID);
            LoadProperty(TenProperty, data.Ten);
            LoadProperty(IDChuyenNganhProperty, data.IDChuyenNganh);
            LoadProperty(DiaDiemProperty, data.DiaDiem);
            LoadProperty(ThoiGianProperty, data.ThoiGian);
            LoadProperty(IDLoaiProperty, data.IDLoai);
            LoadProperty(ChuTriProperty, data.ChuTri);
            LoadProperty(GhiChuProperty, data.GhiChu);
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="TT_SuKien"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_SuKien_Add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IDChuyenNganh", ReadProperty(IDChuyenNganhProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DiaDiem", ReadProperty(DiaDiemProperty) == null ? (object)DBNull.Value : ReadProperty(DiaDiemProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiGian", ReadProperty(ThoiGianProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@IDLoai", ReadProperty(IDLoaiProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ChuTri", ReadProperty(ChuTriProperty) == null ? (object)DBNull.Value : ReadProperty(ChuTriProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="TT_SuKien"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_SuKien_Upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IDChuyenNganh", ReadProperty(IDChuyenNganhProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DiaDiem", ReadProperty(DiaDiemProperty) == null ? (object)DBNull.Value : ReadProperty(DiaDiemProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiGian", ReadProperty(ThoiGianProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@IDLoai", ReadProperty(IDLoaiProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ChuTri", ReadProperty(ChuTriProperty) == null ? (object)DBNull.Value : ReadProperty(ChuTriProperty)).DbType = DbType.String;
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
        /// Self deletes the <see cref="TT_SuKien"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="TT_SuKien"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(Int64 id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_SuKien_Delete", ctx.Connection))
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