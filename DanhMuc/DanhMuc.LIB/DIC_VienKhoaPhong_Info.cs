//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DIC_VienKhoaPhong_Info
// ObjectType:  DIC_VienKhoaPhong_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{

    /// <summary>
    /// DIC_VienKhoaPhong_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="DIC_VienKhoaPhong_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DIC_VienKhoaPhong_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DIC_VienKhoaPhong_Info : BusinessBase<DIC_VienKhoaPhong_Info>
    {

        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDKhoa"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDKhoaProperty = RegisterProperty<Int64>(p => p.IDKhoa, "IDKhoa");
        /// <summary>
        /// Gets the IDKhoa.
        /// </summary>
        /// <value>The IDKhoa.</value>
        public Int64 IDKhoa
        {
            get { return GetProperty(IDKhoaProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MaKhoa"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int16> MaKhoaProperty = RegisterProperty<Int16>(p => p.MaKhoa, "Ma Khoa");
        /// <summary>
        /// Gets or sets the Ma Khoa.
        /// </summary>
        /// <value>The Ma Khoa.</value>
        public Int16 MaKhoa
        {
            get { return GetProperty(MaKhoaProperty); }
            set { SetProperty(MaKhoaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TenKhoa"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenKhoaProperty = RegisterProperty<string>(p => p.TenKhoa, "Ten Khoa");
        /// <summary>
        /// Gets or sets the Ten Khoa.
        /// </summary>
        /// <value>The Ten Khoa.</value>
        public string TenKhoa
        {
            get { return GetProperty(TenKhoaProperty); }
            set { SetProperty(TenKhoaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MaNhanDang"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaNhanDangProperty = RegisterProperty<string>(p => p.MaNhanDang, "Ma Nhan Dang");
        /// <summary>
        /// Gets or sets the Ma Nhan Dang.
        /// </summary>
        /// <value>The Ma Nhan Dang.</value>
        public string MaNhanDang
        {
            get { return GetProperty(MaNhanDangProperty); }
            set { SetProperty(MaNhanDangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YTaTruong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YTaTruongProperty = RegisterProperty<string>(p => p.YTaTruong, "YTa Truong");
        /// <summary>
        /// Gets or sets the YTa Truong.
        /// </summary>
        /// <value>The YTa Truong.</value>
        public string YTaTruong
        {
            get { return GetProperty(YTaTruongProperty); }
            set { SetProperty(YTaTruongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TruongKhoa"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TruongKhoaProperty = RegisterProperty<string>(p => p.TruongKhoa, "Truong Khoa");
        /// <summary>
        /// Gets or sets the Truong Khoa.
        /// </summary>
        /// <value>The Truong Khoa.</value>
        public string TruongKhoa
        {
            get { return GetProperty(TruongKhoaProperty); }
            set { SetProperty(TruongKhoaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TenTat"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenTatProperty = RegisterProperty<string>(p => p.TenTat, "Ten Tat");
        /// <summary>
        /// Gets or sets the Ten Tat.
        /// </summary>
        /// <value>The Ten Tat.</value>
        public string TenTat
        {
            get { return GetProperty(TenTatProperty); }
            set { SetProperty(TenTatProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SuDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> SuDungProperty = RegisterProperty<bool>(p => p.SuDung, "Su Dung");
        /// <summary>
        /// Gets or sets the Su Dung.
        /// </summary>
        /// <value><c>true</c> if Su Dung; otherwise, <c>false</c>.</value>
        public bool SuDung
        {
            get { return GetProperty(SuDungProperty); }
            set { SetProperty(SuDungProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_VienKhoaPhong_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_VienKhoaPhong_Info"/> object.</returns>
        internal static DIC_VienKhoaPhong_Info NewDIC_VienKhoaPhong_Info()
        {
            return DataPortal.CreateChild<DIC_VienKhoaPhong_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_VienKhoaPhong_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDIC_VienKhoaPhong_Info(EventHandler<DataPortalResult<DIC_VienKhoaPhong_Info>> callback)
        {
            DataPortal.BeginCreate<DIC_VienKhoaPhong_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_VienKhoaPhong_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DIC_VienKhoaPhong_Info"/> object.</returns>
        internal static DIC_VienKhoaPhong_Info GetDIC_VienKhoaPhong_Info(SafeDataReader dr)
        {
            DIC_VienKhoaPhong_Info obj = new DIC_VienKhoaPhong_Info();
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
        /// Initializes a new instance of the <see cref="DIC_VienKhoaPhong_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public DIC_VienKhoaPhong_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DIC_VienKhoaPhong_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IDKhoaProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(MaNhanDangProperty, null);
            LoadProperty(YTaTruongProperty, null);
            LoadProperty(TruongKhoaProperty, null);
            LoadProperty(TenTatProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="DIC_VienKhoaPhong_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDKhoaProperty, dr.GetInt64("IDKhoa"));
            LoadProperty(MaKhoaProperty, dr.GetInt16("MaKhoa"));
            LoadProperty(TenKhoaProperty, dr.GetString("TenKhoa"));
            LoadProperty(MaNhanDangProperty, dr.GetString("MaNhanDang"));
            LoadProperty(YTaTruongProperty, dr.GetString("YTaTruong"));
            LoadProperty(TruongKhoaProperty, dr.GetString("TruongKhoa"));
            LoadProperty(TenTatProperty, dr.GetString("TenTat"));
            LoadProperty(SuDungProperty, dr.GetBoolean("SuDung"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DIC_VienKhoaPhong_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_VienKhoaPhong_Info_Add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDKhoa", ReadProperty(IDKhoaProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@MaKhoa", ReadProperty(MaKhoaProperty)).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@TenKhoa", ReadProperty(TenKhoaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaNhanDang", ReadProperty(MaNhanDangProperty) == null ? (object)DBNull.Value : ReadProperty(MaNhanDangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YTaTruong", ReadProperty(YTaTruongProperty) == null ? (object)DBNull.Value : ReadProperty(YTaTruongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TruongKhoa", ReadProperty(TruongKhoaProperty) == null ? (object)DBNull.Value : ReadProperty(TruongKhoaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenTat", ReadProperty(TenTatProperty) == null ? (object)DBNull.Value : ReadProperty(TenTatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SuDung", ReadProperty(SuDungProperty)).DbType = DbType.Boolean;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDKhoaProperty, (long) cmd.Parameters["@IDKhoa"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DIC_VienKhoaPhong_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_VienKhoaPhong_Info_Upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDKhoa", ReadProperty(IDKhoaProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@MaKhoa", ReadProperty(MaKhoaProperty)).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@TenKhoa", ReadProperty(TenKhoaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaNhanDang", ReadProperty(MaNhanDangProperty) == null ? (object)DBNull.Value : ReadProperty(MaNhanDangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YTaTruong", ReadProperty(YTaTruongProperty) == null ? (object)DBNull.Value : ReadProperty(YTaTruongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TruongKhoa", ReadProperty(TruongKhoaProperty) == null ? (object)DBNull.Value : ReadProperty(TruongKhoaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenTat", ReadProperty(TenTatProperty) == null ? (object)DBNull.Value : ReadProperty(TenTatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SuDung", ReadProperty(SuDungProperty)).DbType = DbType.Boolean;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DIC_VienKhoaPhong_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_VienKhoaPhong_Info_Delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDKhoa", ReadProperty(IDKhoaProperty)).DbType = DbType.Int64;
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
