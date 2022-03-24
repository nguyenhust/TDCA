using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    [Serializable]
    public partial class DT_LichGiangTheoLop : BusinessBase<DT_LichGiangTheoLop>
    {

        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDLichGiang"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDLichGiangProperty = RegisterProperty<Int64>(p => p.IDLichGiang, "IDLichGiang");
        /// <summary>
        /// Gets the IDLichGiang.
        /// </summary>
        /// <value>The IDLichGiang.</value>
        public Int64 IDLichGiang
        {
            get { return GetProperty(IDLichGiangProperty); }
            set { SetProperty(IDLichGiangProperty, value); }
        }

        public static readonly PropertyInfo<string> MaLopProperty = RegisterProperty<string>(p => p.MaLop, "MaLop");
        public string MaLop
        {
            get { return GetProperty(MaLopProperty); }
            set { SetProperty(MaLopProperty, value); }
        }

        public static readonly PropertyInfo<string> TenLopProperty = RegisterProperty<string>(p => p.TenLop, "TenLop");
        public string TenLop
        {
            get { return GetProperty(TenLopProperty); }
            set { SetProperty(TenLopProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayNhapHoaDon"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayTaoProperty = RegisterProperty<SmartDate>(p => p.NgayTao, "NgayTao", DateTime.Today);
        /// <summary>
        /// Gets or sets the Ngay Nhap Hoa Don.
        /// </summary>
        /// <value>The Ngay Nhap Hoa Don.</value>
        public SmartDate NgayTao
        {
            get { return GetProperty(NgayTaoProperty); }
            set { SetProperty(NgayTaoProperty, value); }
        }

        public static readonly PropertyInfo<SmartDate> NgayBatDauProperty = RegisterProperty<SmartDate>(p => p.NgayBatDau, "NgayBatDau", DateTime.Today);

        public SmartDate NgayBatDau
        {
            get { return GetProperty(NgayBatDauProperty); }
            set { SetProperty(NgayBatDauProperty, value); }
        }

        public static readonly PropertyInfo<SmartDate> NgayKetThucProperty = RegisterProperty<SmartDate>(p => p.NgayKetThuc, "NgayKetThuc", DateTime.Today);

        public SmartDate NgayKetThuc
        {
            get { return GetProperty(NgayKetThucProperty); }
            set { SetProperty(NgayKetThucProperty, value); }
        }

        public static readonly PropertyInfo<int> SoTietLyThuyetProperty = RegisterProperty<int>(p => p.SoTietLyThuyet, "SoTietLyThuyet");

        public int SoTietLyThuyet
        {
            get { return GetProperty(SoTietLyThuyetProperty); }
            set { SetProperty(SoTietLyThuyetProperty, value); }
        }

        public static readonly PropertyInfo<int> SoTietThucHanhProperty = RegisterProperty<int>(p => p.SoTietThucHanh, "SoTietThucHanh");

        public int SoTietThucHanh
        {
            get { return GetProperty(SoTietThucHanhProperty); }
            set { SetProperty(SoTietThucHanhProperty, value); }
        }
       
        /// <summary>
        /// Maintains metadata about child <see cref="PhieuNhapCT_Coll"/> property.
        /// </summary>
        public static readonly PropertyInfo<DT_LichGiangTheoLop_CT_Coll> DT_LichGiangTheoLop_CT_CollProperty = RegisterProperty<DT_LichGiangTheoLop_CT_Coll>(p => p.DT_LichGiangTheoLop_CT_Coll, "Phieu Nhap CT Coll", RelationshipTypes.Child);
        /// <summary>
        /// Gets the Phieu Nhap CT Coll ("parent load" child property).
        /// </summary>
        /// <value>The Phieu Nhap CT Coll.</value>
        public DT_LichGiangTheoLop_CT_Coll DT_LichGiangTheoLop_CT_Coll
        {
            get { return GetProperty(DT_LichGiangTheoLop_CT_CollProperty); }
            private set { LoadProperty(DT_LichGiangTheoLop_CT_CollProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PhieuNhap"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="PhieuNhap"/> object.</returns>
        public static DT_LichGiangTheoLop NewDT_LichGiangTheoLop()
        {
            return DataPortal.Create<DT_LichGiangTheoLop>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PhieuNhap"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap parameter of the PhieuNhap to fetch.</param>
        /// <returns>A reference to the fetched <see cref="PhieuNhap"/> object.</returns>
        public static DT_LichGiangTheoLop GetDT_LichGiangTheoLop(string MaLop)
        {
            return DataPortal.Fetch<DT_LichGiangTheoLop>(MaLop);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="PhieuNhap"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap of the PhieuNhap to delete.</param>
        public static void DeleteDT_LichGiangTheoLop(Int64 iDLichGiang)
        {
            DataPortal.Delete<DT_LichGiangTheoLop>(iDLichGiang);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="PhieuNhap"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDT_LichGiangTheoLop(EventHandler<DataPortalResult<DT_LichGiangTheoLop>> callback)
        {
            DataPortal.BeginCreate<DT_LichGiangTheoLop>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="PhieuNhap"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap parameter of the PhieuNhap to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDT_LichGiangTheoLop(string MaLop, EventHandler<DataPortalResult<DT_LichGiangTheoLop>> callback)
        {
            DataPortal.BeginFetch<DT_LichGiangTheoLop>(MaLop, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="PhieuNhap"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuNhap">The IDPhieuNhap of the PhieuNhap to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteDT_LichGiangTheoLop(Int64 iDLichGiang, EventHandler<DataPortalResult<DT_LichGiangTheoLop>> callback)
        {
            DataPortal.BeginDelete<DT_LichGiangTheoLop>(iDLichGiang, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PhieuNhap"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_LichGiangTheoLop()
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
            LoadProperty(IDLichGiangProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(MaLopProperty, null);
            LoadProperty(TenLopProperty, null);
            LoadProperty(NgayBatDauProperty, null);
            LoadProperty(NgayKetThucProperty, null);
            LoadProperty(SoTietLyThuyetProperty, 0);
            LoadProperty(SoTietThucHanhProperty, 0);
            LoadProperty(DT_LichGiangTheoLop_CT_CollProperty, DataPortal.CreateChild<DT_LichGiangTheoLop_CT_Coll>());
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
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_get", ctx.Connection))
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
            LoadProperty(IDLichGiangProperty, dr.GetInt64("IDLichGiang"));
            LoadProperty(MaLopProperty, dr.GetString("MaLop"));
            LoadProperty(TenLopProperty, dr.GetString("TenLop"));
            LoadProperty(NgayBatDauProperty, dr.GetSmartDate("NgayBatDau"));
            LoadProperty(NgayKetThucProperty, dr.GetSmartDate("NgayKetThuc"));
            LoadProperty(NgayTaoProperty, dr.GetSmartDate("NgayTao"));
            LoadProperty(SoTietLyThuyetProperty, dr.GetInt32("SoTietLyThuyet"));
            LoadProperty(SoTietThucHanhProperty, dr.GetInt32("SoTietThucHanh"));
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
            LoadProperty(DT_LichGiangTheoLop_CT_CollProperty, DT_LichGiangTheoLop_CT_Coll.GetDT_LichGiangTheoLop_CT_Coll(dr));
        }

        /// <summary>
        /// Inserts a new <see cref="PhieuNhap"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_ins", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLichGiang", ReadProperty(IDLichGiangProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@MaLop", ReadProperty(MaLopProperty) == null ? (object)DBNull.Value : ReadProperty(MaLopProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenLop", ReadProperty(TenLopProperty) == null ? (object)DBNull.Value : ReadProperty(TenLopProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayBatDau", ReadProperty(NgayBatDauProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ReadProperty(NgayKetThucProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@SoTietLyThuyet", ReadProperty(SoTietLyThuyetProperty) == null ? (object)DBNull.Value : ReadProperty(SoTietLyThuyetProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoTietThucHanh", ReadProperty(SoTietThucHanhProperty) == null ? (object)DBNull.Value : ReadProperty(SoTietThucHanhProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NgayTao", ReadProperty(NgayTaoProperty).DBValue).DbType = DbType.DateTime;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDLichGiangProperty, (long)cmd.Parameters["@IDLichGiang"].Value);
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
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLichGiang", ReadProperty(IDLichGiangProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@MaLop", ReadProperty(MaLopProperty) == null ? (object)DBNull.Value : ReadProperty(MaLopProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenLop", ReadProperty(TenLopProperty) == null ? (object)DBNull.Value : ReadProperty(TenLopProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayBatDau", ReadProperty(NgayBatDauProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ReadProperty(NgayKetThucProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@SoTietLyThuyet", ReadProperty(SoTietLyThuyetProperty) == null ? (object)DBNull.Value : ReadProperty(SoTietLyThuyetProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoTietThucHanh", ReadProperty(SoTietThucHanhProperty) == null ? (object)DBNull.Value : ReadProperty(SoTietThucHanhProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NgayTao", ReadProperty(NgayTaoProperty).DBValue).DbType = DbType.DateTime;
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
            DataPortal_Delete(IDLichGiang);
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
                using (var cmd = new SqlCommand("dbo.DT_LichGiangTheoLop_del", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLichGiang", iDLichGiang).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd, iDLichGiang);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
                ctx.Commit();
            }
            // removes all previous references to children
            LoadProperty(DT_LichGiangTheoLop_CT_CollProperty, DataPortal.CreateChild<DT_LichGiangTheoLop_CT_Coll>());
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
        //protected override void AddBusinessRules()
        //{
        //    base.AddBusinessRules();
        //    BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(IDKhoNhapProperty, "Kho nhập không được bỏ trống! "));
        //    BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(IDNCCProperty, "Nhà cung cấp không được bỏ trống! "));
        //    BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(NgayNhapHoaDonProperty,"Ngày nhập hóa đơn không được bỏ trống! "));
        //    BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(NgayNhanHangProperty,"Ngày nhận hàng không được bỏ trống! "));
        //    BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(NhanVienNhanProperty, "Nhân viên nhận không được bỏ trống! "));
        //}

    }
}
