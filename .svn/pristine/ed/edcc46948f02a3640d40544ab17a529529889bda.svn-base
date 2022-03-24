using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
namespace ModuleHanhChinh.LIB
{
    [Serializable]
    public partial class HoanTamThu : BusinessBase<HoanTamThu>
    {
        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDPhieuHoan"/> property.
        /// </summary>
        //public static readonly PropertyInfo<Int64> IDPhieuHoanProperty = RegisterProperty<Int64>(p => p.IDPhieuHoan, "IDPhieu Hoan");
        ///// <summary>
        ///// Gets the IDPhieu Hoan.
        ///// </summary>
        ///// <value>The IDPhieu Hoan.</value>
        //public Int64 IDPhieuHoan
        //{
        //    get { return GetProperty(IDPhieuHoanProperty); }
        //}

        /// <summary>
        /// Maintains metadata about <see cref="IDDieuTri"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDHocVienProperty = RegisterProperty<Int64>(p => p.IDHocVien, "ID Học viên");
        /// <summary>
        /// ID dieu tri ma benh nhan dang nam dieu tri thuc hien hoan
        /// </summary>
        /// <value>The IDDieu Tri.</value>
        public Int64 IDHocVien
        {
            get { return GetProperty(IDHocVienProperty); }
            set { SetProperty(IDHocVienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoPhieuHoan"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoPhieuHoanProperty = RegisterProperty<string>(p => p.SoPhieuHoan, "So Phieu Hoan");
        /// <summary>
        /// So phieu hoan ky quy: yymmdd-99999
        /// </summary>
        /// <value>The So Phieu Hoan.</value>
        public string SoPhieuHoan
        {
            get { return GetProperty(SoPhieuHoanProperty); }
            set { SetProperty(SoPhieuHoanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoTien"/> property.
        /// </summary>
        public static readonly PropertyInfo<Decimal> SoTienProperty = RegisterProperty<Decimal>(p => p.SoTien, "So Tien");
        /// <summary>
        /// Gets or sets the So Tien.
        /// </summary>
        /// <value>The So Tien.</value>
        public Decimal SoTien
        {
            get { return GetProperty(SoTienProperty); }
            set { SetProperty(SoTienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayHoan"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayHoanProperty = RegisterProperty<SmartDate>(p => p.NgayHoan, "Ngay Hoan");
        /// <summary>
        /// Gets or sets the Ngay Hoan.
        /// </summary>
        /// <value>The Ngay Hoan.</value>
        public string NgayHoan
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayHoanProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayHoanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDNguoiHoan"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDNguoiHoanProperty = RegisterProperty<Int64>(p => p.IDNguoiHoan, "IDNguoi Hoan");
        /// <summary>
        /// ID nguoi su dung hoan ky quy
        /// </summary>
        /// <value>The IDNguoi Hoan.</value>
        public Int64 IDNguoiHoan
        {
            get { return GetProperty(IDNguoiHoanProperty); }
            set { SetProperty(IDNguoiHoanProperty, value); }
        }


        /// <summary>
        /// Maintains metadata about <see cref="NguoiNhan"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NguoiNhanProperty = RegisterProperty<string>(p => p.NguoiNhan, "Nguoi Nhan");
        /// <summary>
        /// Gets or sets the Nguoi Nhan.
        /// </summary>
        /// <value>The Nguoi Nhan.</value>
        public string NguoiNhan
        {
            get { return GetProperty(NguoiNhanProperty); }
            set { SetProperty(NguoiNhanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NguoiThu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NguoiThuProperty = RegisterProperty<string>(p => p.NguoiThu, "Nguoi Nhan");
        /// <summary>
        /// Gets or sets the Nguoi Nhan.
        /// </summary>
        /// <value>The Nguoi Nhan.</value>
        public string NguoiThu
        {
            get { return GetProperty(NguoiThuProperty); }
            set { SetProperty(NguoiThuProperty, value); }
        }

        ///// <summary>
        ///// Maintains metadata about child <see cref="IP_HoanKyQuy_ChiTiet_Child"/> property.
        ///// </summary>
        //public static readonly PropertyInfo<HoanTamThuCT_Coll> HoanTamThuCT_ChildProperty = RegisterProperty<HoanTamThuCT_Coll>(p => p.HoanTamThuCT_Child, "IP Hoan Tam Ung Chi Tiet Child", RelationshipTypes.Child);
        ///// <summary>
        ///// Gets the IP Hoan Ky Quy Chi Tiet Child ("parent load" child property).
        ///// </summary>
        ///// <value>The IP Hoan Ky Quy Chi Tiet Child.</value>
        //public HoanTamThuCT_Coll HoanTamThuCT_Child
        //{
        //    get { return GetProperty(HoanTamThuCT_ChildProperty); }
        //    set { LoadProperty(HoanTamThuCT_ChildProperty, value); }
        //}

        /// <summary>
        /// Maintains metadata about child <see cref="Lydo"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> LydoProperty = RegisterProperty<string>(p => p.Lydo, "Lý do ký quỹ", RelationshipTypes.Child);
        /// <summary>
        /// Gets the IP Hoan Ky Quy Chi Tiet Child ("parent load" child property).
        /// </summary>
        /// <value>The IP Hoan Ky Quy Chi Tiet Child.</value>
        public string Lydo
        {
            get { return GetProperty(LydoProperty); }
            set { LoadProperty(LydoProperty, value); }
        }

        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            //Số tiêng không thể nhỏ hơn 1.000
            BusinessRules.AddRule(new ValidationCheck.ValiNumber(SoTienProperty, "Số tiền lớn hơn 1.000 đồng", 1000));
            base.AddBusinessRules();
        }
        #endregion

        #region Criteria

        [Serializable()]
        public class Criteria
        {
            private long _lngidbienlai;
            /// <summary>
            /// Ngày hủy hoàn kỹ quỹ
            /// </summary>
            private SmartDate _dteNgayhuy;
            /// <summary>
            /// Lý do hủy hoàn ký quỹ
            /// </summary>
            private string _strLydo;
            /// <summary>
            /// Người hủy hoàn kỹ quỹ
            /// </summary>
            private long _lngIdNguoihuy;
            public long IDBienLai { get { return _lngidbienlai; } }
            public SmartDate NgayHuy
            {
                get
                {
                    return _dteNgayhuy;
                }
            }

            public long IDNguoiHuy
            {
                get
                {
                    return _lngIdNguoihuy;
                }
            }


            public string LyDo
            {
                get
                {
                    return _strLydo;
                }
            }

            public Criteria(long lngidbienlai)
            {
                _lngidbienlai = lngidbienlai;
            }

            public Criteria(long lngidbienlai, string strNgayhuy, string strLydo, long lngIDNguoihuy)
            {
                _lngidbienlai = lngidbienlai;
                _dteNgayhuy.Text = strNgayhuy;
                _strLydo = strLydo;
                _lngIdNguoihuy = lngIDNguoihuy;
            }
        }

        #endregion 

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="IP_HoanKyQuy"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="IP_HoanKyQuy"/> object.</returns>
        public static HoanTamThu NewHoanTamThu()
        {
            //if (!CanAddObject())
            //    throw new SystemException("Bạn không có quyền tạo mới phiếu hoàn");
            return DataPortal.Create<HoanTamThu>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_HoanKyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuHoan">The IDPhieuHoan parameter of the IP_HoanKyQuy to fetch.</param>
        /// <returns>A reference to the fetched <see cref="IP_HoanKyQuy"/> object.</returns>
        public static HoanTamThu GetHoanTamThu(Int64 iDPhieuHoan)
        {
            //if (!CanGetObject())
            //    throw new SystemException("Bạn không có quyền xem phiếu hoàn");
            return DataPortal.Fetch<HoanTamThu>(iDPhieuHoan);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="IP_HoanKyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuHoan">The IDPhieuHoan of the IP_HoanKyQuy to delete.</param>
        public static void DeleteHoanTamThu(long lngid, string strNgayhuy, string strLydo, long lngIDNguoihuy)
        {
            //if (!CanDeleteObject())
            //    throw new SystemException("Bạn không có quyền xóa phiếu hoàn");
            DataPortal.Delete<HoanTamThu>(new Criteria(lngid, strNgayhuy, strLydo, lngIDNguoihuy));
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="IP_HoanKyQuy"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHoanTamThu(EventHandler<DataPortalResult<HoanTamThu>> callback)
        {
            DataPortal.BeginCreate<HoanTamThu>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="IP_HoanKyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuHoan">The IDPhieuHoan parameter of the IP_HoanKyQuy to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHoanTamThu(Int64 iDPhieuHoan, EventHandler<DataPortalResult<HoanTamThu>> callback)
        {
            DataPortal.BeginFetch<HoanTamThu>(iDPhieuHoan, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="IP_HoanKyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuHoan">The IDPhieuHoan of the IP_HoanKyQuy to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteHoanTamThu(Int64 iDPhieuHoan, EventHandler<DataPortalResult<HoanTamThu>> callback)
        {
            DataPortal.BeginDelete<HoanTamThu>(iDPhieuHoan, callback);
        }
        public override HoanTamThu Save()
        {
            //if (this.IsDirty)
            //if (!CanEditObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền sửa ký quỹ");
            return base.Save();
        }
        #endregion

         #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_HoanKyQuy"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HoanTamThu()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="IP_HoanKyQuy"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            ////LoadProperty(IDPhieuHoanProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            //LoadProperty(IP_HoanKyQuy_ChiTiet_ChildProperty, DataPortal.CreateChild<IP_HoanKyQuy_ChiTiet_Coll>());
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="IP_HoanKyQuy"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="iDPhieuHoan">The IDPhieu Hoan.</param>
        protected void DataPortal_Fetch(Int64 iDPhieuHoan)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HoanTamThu_Get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDPhieuHoan", iDPhieuHoan).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd, iDPhieuHoan);
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
                    //FetchChildren(dr);
                }
            }
        }

        /// <summary>
        /// Loads a <see cref="IP_HoanKyQuy"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            //LoadProperty(IDPhieuHoanProperty, dr.GetInt64("IDPhieuHoan"));
            LoadProperty(IDHocVienProperty, dr.GetInt64("IDHocVien"));
            LoadProperty(SoPhieuHoanProperty, dr.GetString("SoPhieuHoan"));
            LoadProperty(SoTienProperty, dr.GetDecimal("SoTien"));
            LoadProperty(NgayHoanProperty, dr.GetDateTime("NgayHoan"));
            LoadProperty(IDNguoiHoanProperty, dr.GetInt64("IDNguoiHoan"));
            LoadProperty(NguoiNhanProperty, dr.GetString("NguoiNhan"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        ///// <summary>
        ///// Loads child objects from the given SafeDataReader.
        ///// </summary>
        ///// <param name="dr">The SafeDataReader to use.</param>
        //private void FetchChildren(SafeDataReader dr)
        //{
        //    dr.NextResult();
        //    LoadProperty(IP_HoanKyQuy_ChiTiet_ChildProperty, IP_HoanKyQuy_ChiTiet_Coll.GetIP_HoanKyQuy_ChiTiet_Coll(dr));
        //}

        /// <summary>
        /// Inserts a new <see cref="IP_HoanKyQuy"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HoanTamThu_ins", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@IDPhieuHoan", ReadProperty(IDPhieuHoanProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@IDHocVien", ReadProperty(IDHocVienProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@SoPhieuHoan", ReadProperty(SoPhieuHoanProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoTien", ReadProperty(SoTienProperty)).DbType = DbType.Decimal;
                    cmd.Parameters.AddWithValue("@NgayHoan", ReadProperty(NgayHoanProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@IDNguoiHoan", ReadProperty(IDNguoiHoanProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@NguoiNhan", ReadProperty(NguoiNhanProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    //LoadProperty(IDPhieuHoanProperty, (long)cmd.Parameters["@IDPhieuHoan"].Value);
                }
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="IP_HoanKyQuy"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HoanTamThu_upd", ctx.Connection))
                {
                    //cmd.Transaction = ctx.Transaction;
                    //cmd.CommandType = CommandType.StoredProcedure;
                    ////cmd.Parameters.AddWithValue("@IDPhieuHoan", ReadProperty(IDPhieuHoanProperty)).DbType = DbType.Int64;
                    //cmd.Parameters.AddWithValue("@IDHocVien", ReadProperty(IDHocVienProperty)).DbType = DbType.Int64;q
                    //cmd.Parameters.AddWithValue("@SoPhieuHoan", ReadProperty(SoPhieuHoanProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoTien", ReadProperty(SoTienProperty)).DbType = DbType.Decimal;
                    cmd.Parameters.AddWithValue("@NgayHoan", ReadProperty(NgayHoanProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@IDNguoiHoan", ReadProperty(IDNguoiHoanProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@NguoiNhan", ReadProperty(NguoiNhanProperty)).DbType = DbType.String;
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
        /// Self deletes the <see cref="IP_HoanKyQuy"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            //DataPortal_Delete(new Criteria(IDPhieuHoan, NgayHoan, Lydo, IDNguoiHoan));
        }

        /// <summary>
        /// Deletes the <see cref="IP_HoanKyQuy"/> object from database.
        /// </summary>
        /// <param name="iDPhieuHoan">The delete criteria.</param>
        protected void DataPortal_Delete(Criteria criteria)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
                using (var cmd = new SqlCommand("dbo.HoanTamThu_destroy", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDPhieuHoan", criteria.IDBienLai);
                    cmd.Parameters.AddWithValue("@NgayHuy", criteria.NgayHuy.DBValue);
                    cmd.Parameters.AddWithValue("@LyDo", criteria.LyDo);
                    cmd.Parameters.AddWithValue("@IDNguoiHuy", criteria.IDNguoiHuy);
                    var args = new DataPortalHookArgs(cmd, criteria);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
                ctx.Commit();
            }
            // removes all previous references to children
            //LoadProperty(IP_HoanKyQuy_ChiTiet_ChildProperty, DataPortal.CreateChild<IP_HoanKyQuy_ChiTiet_Coll>());
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

        #region Create MaBienLai
        /// <summary>
        /// Tạo mã biên lai
        /// </summary>
        /// <param name="intyear">yyMMdd</param>
        /// <returns>Mã biên lai</returns>
        public static string CreateMaBienLai(int intyear)
        {
            string _strMabl = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "fn_taoSBL_HoanTamThu";
                    SqlParameter param = new SqlParameter("@year", intyear);
                    param.Direction = ParameterDirection.Input;
                    cm.Parameters.Add(param);
                    SqlParameter ret = new SqlParameter("@tmsoblt", SqlDbType.VarChar);
                    ret.Direction = ParameterDirection.ReturnValue;
                    cm.Parameters.Add(ret);
                    cm.ExecuteNonQuery();
                    _strMabl = cm.Parameters["@tmsoblt"].Value.ToString();
                }
            }
            return _strMabl;
        }

        #endregion

    }
}
