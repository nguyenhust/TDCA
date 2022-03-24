using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{
    public partial class HC_LichLamViecTheoPhong : BusinessBase<HC_LichLamViecTheoPhong>
    {
         #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDLichGiang"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDLichProperty = RegisterProperty<Int64>(p => p.IDLich, "IDLich");
        /// <summary>
        /// Gets the IDLichGiang.
        /// </summary>
        /// <value>The IDLichGiang.</value>
        public Int64 IDLich
        {
            get { return GetProperty(IDLichProperty); }
            set { SetProperty(IDLichProperty, value); }
        }

        public static readonly PropertyInfo<Int64> IDNguoiDungProperty = RegisterProperty<Int64>(p => p.IDNguoiDung, "IDNguoiDung");
        /// <summary>
        /// Gets the IDLichGiang.
        /// </summary>
        /// <value>The IDLichGiang.</value>
        public Int64 IDNguoiDung
        {
            get { return GetProperty(IDNguoiDungProperty); }
            set { SetProperty(IDNguoiDungProperty, value); }
        }

        public static readonly PropertyInfo<string> TenPhongProperty = RegisterProperty<string>(p => p.TenPhong, "TenPhong");
        public string TenPhong
        {
            get { return GetProperty(TenPhongProperty); }
            set { SetProperty(TenPhongProperty, value); }
        }
       

        /// <summary>
        /// Maintains metadata about <see cref="NgayNhapHoaDon"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayTaoProperty = RegisterProperty<SmartDate>(p => p.NgayTao, "NgayTao");
        /// <summary>
        /// Gets or sets the Ngay Nhap Hoa Don.
        /// </summary>
        /// <value>The Ngay Nhap Hoa Don.</value>
        public SmartDate NgayTao
        {
            get { return GetProperty(NgayTaoProperty); }
            set { SetProperty(NgayTaoProperty, value); }
        }

        public static readonly PropertyInfo<SmartDate> TuNgayProperty = RegisterProperty<SmartDate>(p => p.TuNgay, "TuNgay", DateTime.Today);

        public SmartDate TuNgay
        {
            get { return GetProperty(TuNgayProperty); }
            set { SetProperty(TuNgayProperty, value); }
        }

        public static readonly PropertyInfo<SmartDate> DenNgayProperty = RegisterProperty<SmartDate>(p => p.DenNgay, "DenNgay", DateTime.Today);

        public SmartDate DenNgay
        {
            get { return GetProperty(DenNgayProperty); }
            set { SetProperty(DenNgayProperty, value); }
        }

        public static readonly PropertyInfo<string> GhiChuProperty = RegisterProperty<string>(p => p.GhiChu, "GhiChu");

        public string GhiChu
        {
            get { return GetProperty(GhiChuProperty); }
            set { SetProperty(GhiChuProperty, value); }
        }
       
        /// <summary>
        /// Maintains metadata about child <see cref="PhieuNhapCT_Coll"/> property.
        /// </summary>
        public static readonly PropertyInfo<HC_LichLamViecTheoPhong_CT_Coll> HC_LichLamViecTheoPhong_CT_CollProperty = RegisterProperty<HC_LichLamViecTheoPhong_CT_Coll>(p => p.HC_LichLamViecTheoPhong_CT_Coll, "HC_LichLamViecTheoPhong_CT_Coll", RelationshipTypes.Child);
        /// <summary>
        /// Gets the Phieu Nhap CT Coll ("parent load" child property).
        /// </summary>
        /// <value>The Phieu Nhap CT Coll.</value>
        public HC_LichLamViecTheoPhong_CT_Coll HC_LichLamViecTheoPhong_CT_Coll
        {
            get { return GetProperty(HC_LichLamViecTheoPhong_CT_CollProperty); }
            private set { LoadProperty(HC_LichLamViecTheoPhong_CT_CollProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PhieuNhap"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="PhieuNhap"/> object.</returns>
        public static HC_LichLamViecTheoPhong NewHC_LichLamViecTheoPhong()
        {
            return DataPortal.Create<HC_LichLamViecTheoPhong>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PhieuNhap"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap parameter of the PhieuNhap to fetch.</param>
        /// <returns>A reference to the fetched <see cref="PhieuNhap"/> object.</returns>
        public static HC_LichLamViecTheoPhong GetHC_LichLamViecTheoPhong(Int64 IDLich)
        {
            return DataPortal.Fetch<HC_LichLamViecTheoPhong>(IDLich);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="PhieuNhap"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap of the PhieuNhap to delete.</param>
        public static void DeleteHC_LichLamViecTheoPhong(Int64 iDLich)
        {
            DataPortal.Delete<HC_LichLamViecTheoPhong>(iDLich);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="PhieuNhap"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHC_LichLamViecTheoPhong(EventHandler<DataPortalResult<HC_LichLamViecTheoPhong>> callback)
        {
            DataPortal.BeginCreate<HC_LichLamViecTheoPhong>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="PhieuNhap"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap parameter of the PhieuNhap to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHC_LichLamViecTheoPhong(Int64 IDLich, EventHandler<DataPortalResult<HC_LichLamViecTheoPhong>> callback)
        {
            DataPortal.BeginFetch<HC_LichLamViecTheoPhong>(IDLich, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="PhieuNhap"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap of the PhieuNhap to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteHC_LichLamViecTheoPhong(Int64 iDLich, EventHandler<DataPortalResult<HC_LichLamViecTheoPhong>> callback)
        {
            DataPortal.BeginDelete<HC_LichLamViecTheoPhong>(iDLich, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PhieuNhap"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_LichLamViecTheoPhong()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="PhieuNhap"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDLichProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(IDNguoiDungProperty, null);
            LoadProperty(TenPhongProperty, null);
            LoadProperty(NgayTaoProperty, null);
            LoadProperty(TuNgayProperty, null);
            LoadProperty(DenNgayProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(HC_LichLamViecTheoPhong_CT_CollProperty, DataPortal.CreateChild<HC_LichLamViecTheoPhong_CT_Coll>());
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="PhieuNhap"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieu Nhap.</param>
        protected void DataPortal_Fetch(string MaLop)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTheoPhong_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaLop", MaLop).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd, MaLop);
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
                    FetchChildren(dr);
                }
            }
        }

        /// <summary>
        /// Loads a <see cref="PhieuNhap"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDLichProperty, dr.GetInt64("IDLich"));
            LoadProperty(IDNguoiDungProperty, dr.GetInt64("IDNguoiDung"));
            LoadProperty(TenPhongProperty, dr.GetString("TenPhong"));
            LoadProperty(NgayTaoProperty, dr.GetSmartDate("NgayTao"));
            LoadProperty(TuNgayProperty, dr.GetSmartDate("TuNgay"));
            LoadProperty(DenNgayProperty, dr.GetSmartDate("DenNgay"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Loads child objects from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void FetchChildren(SafeDataReader dr)
        {
            dr.NextResult();
            LoadProperty(HC_LichLamViecTheoPhong_CT_CollProperty, HC_LichLamViecTheoPhong_CT_Coll.GetHC_LichLamViecTheoPhong_CT_Coll(dr));
        }

        /// <summary>
        /// Inserts a new <see cref="PhieuNhap"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTheoPhong_ins", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLich", ReadProperty(IDLichProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@IDNguoiDung", ReadProperty(IDNguoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(IDNguoiDungProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@TenPhong", ReadProperty(TenPhongProperty) == null ? (object)DBNull.Value : ReadProperty(TenPhongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayTao", ReadProperty(NgayTaoProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@TuNgay", ReadProperty(TuNgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@DenNgay", ReadProperty(DenNgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDLichProperty, (long)cmd.Parameters["@IDLich"].Value);
                }
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="PhieuNhap"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTheoPhong_upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLich", ReadProperty(IDLichProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDNguoiDung", ReadProperty(IDNguoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(IDNguoiDungProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@TenPhong", ReadProperty(TenPhongProperty) == null ? (object)DBNull.Value : ReadProperty(TenPhongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayTao", ReadProperty(NgayTaoProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@TuNgay", ReadProperty(TuNgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@DenNgay", ReadProperty(DenNgayProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="PhieuNhap"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(IDLich);
        }

        /// <summary>
        /// Deletes the <see cref="PhieuNhap"/> object from database.
        /// </summary>
        /// <param name="iDPhieuNhap">The delete criteria.</param>
        protected void DataPortal_Delete(Int64 iDLichGiang)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTheoPhong_del", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLich", iDLichGiang).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd, iDLichGiang);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
                ctx.Commit();
            }
            // removes all previous references to children
            LoadProperty(HC_LichLamViecTheoPhong_CT_CollProperty, DataPortal.CreateChild<HC_LichLamViecTheoPhong_CT_Coll>());
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
