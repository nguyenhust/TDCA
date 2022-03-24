using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{
    [Serializable]
    public partial class DT_LichGiangTheoLop_CT_Info : BusinessBase<DT_LichGiangTheoLop_CT_Info>
    {

        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDPhieuNhapCT"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDLichGiangCTProperty = RegisterProperty<Int64>(p => p.IDLichGiangCT, "IDLichGiangCT");
        /// <summary>
        /// Gets the IDPhieu Nhap CT.
        /// </summary>
        /// <value>The IDPhieu Nhap CT.</value>
        public Int64 IDLichGiangCT
        {
            get { return GetProperty(IDLichGiangCTProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDThuoc"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDLichGiangProperty = RegisterProperty<Int64>(p => p.IDLichGiang, "IDLichGiang");
        /// <summary>
        /// Gets or sets the IDThuoc.
        /// </summary>
        /// <value>The IDThuoc.</value>
        public Int64 IDLichGiang
        {
            get { return GetProperty(IDLichGiangProperty); }
            set { SetProperty(IDLichGiangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLo"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NgayGiangProperty = RegisterProperty<string>(p => p.NgayGiang, "NgayGiang");
        /// <summary>
        /// Gets or sets the So Lo.
        /// </summary>
        /// <value>The So Lo.</value>
        public string NgayGiang
        {
            get { return GetProperty(NgayGiangProperty); }
            set { SetProperty(NgayGiangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> BuoiGiangProperty = RegisterProperty<string>(p => p.BuoiGiang, "BuoiGiang");
        /// <summary>
        /// Gets or sets the So Luong.
        /// </summary>
        /// <value>The So Luong.</value>
        public string BuoiGiang
        {
            get { return GetProperty(BuoiGiangProperty); }
            set { SetProperty(BuoiGiangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DonGia"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDungGiangProperty = RegisterProperty<string>(p => p.NoiDungGiang, "NoiDungGiang");
        /// <summary>
        /// Gets or sets the Don Gia.
        /// </summary>
        /// <value>The Don Gia.</value>
        public string NoiDungGiang
        {
            get { return GetProperty(NoiDungGiangProperty); }
            set { SetProperty(NoiDungGiangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HanDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> LoaiDaoTaoProperty = RegisterProperty<string>(p => p.LoaiDaoTao, "LoaiDaoTao");
        /// <summary>
        /// Gets or sets the Han Dung.
        /// </summary>
        /// <value>The Han Dung.</value>
        public string LoaiDaoTao
        {
            get { return GetProperty(LoaiDaoTaoProperty); }
            set { SetProperty(LoaiDaoTaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChietKhau"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IDGiangVienProperty = RegisterProperty<Int64?>(p => p.IDGiangVien, "IDGiangVien");
        /// <summary>
        /// Gets or sets the Chiet Khau.
        /// </summary>
        /// <value>The Chiet Khau.</value>
        public Int64? IDGiangVien
        {
            get { return GetProperty(IDGiangVienProperty); }
            set { SetProperty(IDGiangVienProperty, value); }
        }

        public static readonly PropertyInfo<Int64?> IDNguoiDungProperty = RegisterProperty<Int64?>(p => p.IDNguoiDung, "IDNguoiDung");
        /// <summary>
        /// Gets or sets the Chiet Khau.
        /// </summary>
        /// <value>The Chiet Khau.</value>
        public Int64? IDNguoiDung
        {
            get { return GetProperty(IDNguoiDungProperty); }
            set { SetProperty(IDNguoiDungProperty, value); }
        }

        public static readonly PropertyInfo<string> NgayProperty = RegisterProperty<string>(p => p.Ngay, "Ngay");
      
        public string Ngay
        {
            get { return GetProperty(NgayProperty); }
            set { SetProperty(NgayProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PhieuNhapCT_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="PhieuNhapCT_Info"/> object.</returns>
        internal static DT_LichGiangTheoLop_CT_Info NewDT_LichGiangTheoLop_CT_Info()
        {
            return DataPortal.CreateChild<DT_LichGiangTheoLop_CT_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="PhieuNhapCT_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDT_LichGiangTheoLop_CT_Info(EventHandler<DataPortalResult<DT_LichGiangTheoLop_CT_Info>> callback)
        {
            DataPortal.BeginCreate<DT_LichGiangTheoLop_CT_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PhieuNhapCT_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PhieuNhapCT_Info"/> object.</returns>
        internal static DT_LichGiangTheoLop_CT_Info GetDT_LichGiangTheoLop_CT_Info(SafeDataReader dr)
        {
            DT_LichGiangTheoLop_CT_Info obj = new DT_LichGiangTheoLop_CT_Info();
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
        /// Initializes a new instance of the <see cref="PhieuNhapCT_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_LichGiangTheoLop_CT_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="PhieuNhapCT_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IDLichGiangCTProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(IDLichGiangProperty, null);
            LoadProperty(NgayGiangProperty, null);
            LoadProperty(BuoiGiangProperty, null);
            LoadProperty(NoiDungGiangProperty, null);
            LoadProperty(LoaiDaoTaoProperty, null);
            LoadProperty(IDGiangVienProperty, null);
            LoadProperty(IDNguoiDungProperty, Csla.ApplicationContext.GlobalContext["IDNguoiDung"]);
            LoadProperty(NgayProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="PhieuNhapCT_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDLichGiangCTProperty, dr.GetInt64("IDLichGiangCT"));
            LoadProperty(IDLichGiangProperty, dr.GetInt64("IDLichGiang"));
            LoadProperty(NgayGiangProperty, dr.GetString("NgayGiang"));
            LoadProperty(BuoiGiangProperty, dr.GetString("BuoiGiang"));
            LoadProperty(NoiDungGiangProperty, dr.GetString("NoiDungGiang"));
            LoadProperty(LoaiDaoTaoProperty, dr.GetString("LoaiDaoTao"));
            LoadProperty(IDGiangVienProperty, dr.GetInt64("IDGiangVien"));
            LoadProperty(IDNguoiDungProperty, dr.GetInt64("IDNguoiDung"));
            LoadProperty(NgayProperty, dr.GetString("Ngay"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="PhieuNhapCT_Info"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        private void Child_Insert(DT_LichGiangTheoLop parent)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_CT_Info_ins", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLichGiang", parent.IDLichGiang).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDLichGiangCT", ReadProperty(IDLichGiangCTProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@NgayGiang", ReadProperty(NgayGiangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@BuoiGiang", ReadProperty(BuoiGiangProperty) == null ? (object)DBNull.Value : ReadProperty(BuoiGiangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDungGiang", ReadProperty(NoiDungGiangProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungGiangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LoaiDaoTao", ReadProperty(LoaiDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(LoaiDaoTaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IDGiangVien", ReadProperty(IDGiangVienProperty) == null ? (object)DBNull.Value : ReadProperty(IDGiangVienProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDNguoiDung", ReadProperty(IDNguoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(IDNguoiDungProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@Ngay", ReadProperty(NgayProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDLichGiangCTProperty, (long)cmd.Parameters["@IDLichGiangCT"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="PhieuNhapCT_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_CT_Info_upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLichGiangCT", ReadProperty(IDLichGiangCTProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@NgayGiang", ReadProperty(NgayGiangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@BuoiGiang", ReadProperty(BuoiGiangProperty) == null ? (object)DBNull.Value : ReadProperty(BuoiGiangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDungGiang", ReadProperty(NoiDungGiangProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungGiangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LoaiDaoTao", ReadProperty(LoaiDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(LoaiDaoTaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@IDGiangVien", ReadProperty(IDGiangVienProperty) == null ? (object)DBNull.Value : ReadProperty(IDGiangVienProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDNguoiDung", ReadProperty(IDNguoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(IDNguoiDungProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@Ngay", ReadProperty(NgayProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="PhieuNhapCT_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_CT_Info_del", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLichGiangCT", ReadProperty(IDLichGiangCTProperty)).DbType = DbType.Int64;
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
