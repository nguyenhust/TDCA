//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    TT_BaiViet_Info
// ObjectType:  TT_BaiViet_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace TruyenThong.LIB
{

    /// <summary>
    /// TT_BaiViet_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="TT_BaiViet_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="TT_BaiViet_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class TT_BaiViet_Info : BusinessBase<TT_BaiViet_Info>
    {

        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDProperty = RegisterProperty<Int64>(p => p.ID, "ID");
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID
        {
            get { return GetProperty(IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TacGia"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TacGiaProperty = RegisterProperty<string>(p => p.TacGia, "Tac Gia");
        /// <summary>
        /// Gets or sets the Tac Gia.
        /// </summary>
        /// <value>The Tac Gia.</value>
        public string TacGia
        {
            get { return GetProperty(TacGiaProperty); }
            set { SetProperty(TacGiaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TieuDe"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TieuDeProperty = RegisterProperty<string>(p => p.TieuDe, "Tieu De");
        /// <summary>
        /// Gets or sets the Tieu De.
        /// </summary>
        /// <value>The Tieu De.</value>
        public string TieuDe
        {
            get { return GetProperty(TieuDeProperty); }
            set { SetProperty(TieuDeProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="LinkFile"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> LoaiProperty = RegisterProperty<string>(p => p.Loai, "Loai");
        /// <summary>
        /// Gets or sets the Link File.
        /// </summary>
        /// <value>The Link File.</value>
        public string Loai
        {
            get { return GetProperty(LoaiProperty); }
            set { SetProperty(LoaiProperty, value); }
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
        /// Maintains metadata about <see cref="IDLoai"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IDLoaiProperty = RegisterProperty<int?>(p => p.IDLoai, "IDLoai");
        /// <summary>
        /// Gets or sets the IDLoai.
        /// </summary>
        /// <value>The IDLoai.</value>
        public int? IDLoai
        {
            get { return GetProperty(IDLoaiProperty); }
            set { SetProperty(IDLoaiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianDang"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianDangProperty = RegisterProperty<SmartDate>(p => p.ThoiGianDang, "Thoi Gian Dang");
        /// <summary>
        /// Gets or sets the Thoi Gian Dang.
        /// </summary>
        /// <value>The Thoi Gian Dang.</value>
        public string ThoiGianDang
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianDangProperty); }
            set { SetPropertyConvert<SmartDate, String>(ThoiGianDangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianDuyet"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianDuyetProperty = RegisterProperty<SmartDate>(p => p.ThoiGianDuyet, "Thoi Gian Duyet");
        /// <summary>
        /// Gets or sets the Thoi Gian Duyet.
        /// </summary>
        /// <value>The Thoi Gian Duyet.</value>
        public string ThoiGianDuyet
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianDuyetProperty); }
            set { SetPropertyConvert<SmartDate, String>(ThoiGianDuyetProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NguoiDuyet"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NguoiDuyetProperty = RegisterProperty<string>(p => p.NguoiDuyet, "Nguoi Duyet");
        /// <summary>
        /// Gets or sets the Nguoi Duyet.
        /// </summary>
        /// <value>The Nguoi Duyet.</value>
        public string NguoiDuyet
        {
            get { return GetProperty(NguoiDuyetProperty); }
            set { SetProperty(NguoiDuyetProperty, value); }
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
        /// Maintains metadata about <see cref="DuongDan"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DuongDanProperty = RegisterProperty<string>(p => p.DuongDan, "Duong Dan");
        /// <summary>
        /// Gets or sets the Duong Dan.
        /// </summary>
        /// <value>The Duong Dan.</value>
        public string DuongDan
        {
            get { return GetProperty(DuongDanProperty); }
            set { SetProperty(DuongDanProperty, value); }
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
        public string LastEdited_Date
        {
            get { return GetPropertyConvert<SmartDate, String>(LastEdited_DateProperty); }
            set { SetPropertyConvert<SmartDate, String>(LastEdited_DateProperty, value); }
        }
        public DateTime DateDang
        {
            get { return GetProperty(ThoiGianDangProperty); }
        }
        public DateTime DateDuyet
        {
            get { return GetProperty(ThoiGianDuyetProperty); }
        }
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="TT_BaiViet_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="TT_BaiViet_Info"/> object.</returns>
        internal static TT_BaiViet_Info NewTT_BaiViet_Info()
        {
            return DataPortal.CreateChild<TT_BaiViet_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="TT_BaiViet_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewTT_BaiViet_Info(EventHandler<DataPortalResult<TT_BaiViet_Info>> callback)
        {
            DataPortal.BeginCreate<TT_BaiViet_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="TT_BaiViet_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="TT_BaiViet_Info"/> object.</returns>
        internal static TT_BaiViet_Info GetTT_BaiViet_Info(SafeDataReader dr)
        {
            TT_BaiViet_Info obj = new TT_BaiViet_Info();
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
        /// Initializes a new instance of the <see cref="TT_BaiViet_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TT_BaiViet_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="TT_BaiViet_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(TieuDeProperty, null);
            LoadProperty(ThoiGianDangProperty, null);
            LoadProperty(ThoiGianDuyetProperty, null);
            LoadProperty(NguoiDuyetProperty, null);
            LoadProperty(LinkProperty, null);
            LoadProperty(DuongDanProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(LoaiProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="TT_BaiViet_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
             LoadProperty(IDProperty, dr.GetInt64("ID"));
            LoadProperty(TacGiaProperty, dr.GetString("TacGia"));
            LoadProperty(TieuDeProperty, dr.GetString("TieuDe"));
            LoadProperty(NoiDungProperty, dr.GetString("NoiDung"));
            LoadProperty(IDLoaiProperty, dr.GetInt32("IDLoai"));
            LoadProperty(ThoiGianDangProperty, dr.GetDateTime("ThoiGianDang"));
            LoadProperty(ThoiGianDuyetProperty, dr.GetDateTime("ThoiGianDuyet"));
            LoadProperty(NguoiDuyetProperty, dr.GetString("NguoiDuyet"));
            LoadProperty(LinkProperty, dr.GetString("Link"));
            LoadProperty(DuongDanProperty, dr.GetString("DuongDan"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(LoaiProperty, dr.GetString("Loai"));
            LoadProperty(LastEdited_UserIDProperty, dr.GetInt64("LastEdited_UserID"));
            LoadProperty(LastEdited_DateProperty, dr.GetSmartDate("LastEdited_Date"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="TT_BaiViet_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_BaiViet_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@TacGia", ReadProperty(TacGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TieuDe", ReadProperty(TieuDeProperty) == null ? (object)DBNull.Value : ReadProperty(TieuDeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IDLoai", ReadProperty(IDLoaiProperty) == null ? (object)DBNull.Value : ReadProperty(IDLoaiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ThoiGianDang", ReadProperty(ThoiGianDangProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@ThoiGianDuyet", ReadProperty(ThoiGianDuyetProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NguoiDuyet", ReadProperty(NguoiDuyetProperty) == null ? (object)DBNull.Value : ReadProperty(NguoiDuyetProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Link", ReadProperty(LinkProperty) == null ? (object)DBNull.Value : ReadProperty(LinkProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DuongDan", ReadProperty(DuongDanProperty) == null ? (object)DBNull.Value : ReadProperty(DuongDanProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (long) cmd.Parameters["@ID"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="TT_BaiViet_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_BaiViet_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@TacGia", ReadProperty(TacGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TieuDe", ReadProperty(TieuDeProperty) == null ? (object)DBNull.Value : ReadProperty(TieuDeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IDLoai", ReadProperty(IDLoaiProperty) == null ? (object)DBNull.Value : ReadProperty(IDLoaiProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ThoiGianDang", ReadProperty(ThoiGianDangProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@ThoiGianDuyet", ReadProperty(ThoiGianDuyetProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NguoiDuyet", ReadProperty(NguoiDuyetProperty) == null ? (object)DBNull.Value : ReadProperty(NguoiDuyetProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Link", ReadProperty(LinkProperty) == null ? (object)DBNull.Value : ReadProperty(LinkProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DuongDan", ReadProperty(DuongDanProperty) == null ? (object)DBNull.Value : ReadProperty(DuongDanProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_UserID", ReadProperty(LastEdited_UserIDProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_UserIDProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="TT_BaiViet_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.TT_BaiViet_Info_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
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
