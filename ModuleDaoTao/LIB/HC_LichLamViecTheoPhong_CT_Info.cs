using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{
    [Serializable]
    public partial class HC_LichLamViecTheoPhong_CT_Info : BusinessBase<HC_LichLamViecTheoPhong_CT_Info>
    {

        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDPhieuNhapCT"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDLichChiTietProperty = RegisterProperty<Int64>(p => p.IDLichChiTiet, "IDLichChiTiet");
        /// <summary>
        /// Gets the IDPhieu Nhap CT.
        /// </summary>
        /// <value>The IDPhieu Nhap CT.</value>
        public Int64 IDLichChiTiet
        {
            get { return GetProperty(IDLichChiTietProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDThuoc"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDLichProperty = RegisterProperty<Int64>(p => p.IDLich, "IDLich");
        /// <summary>
        /// Gets or sets the IDThuoc.
        /// </summary>
        /// <value>The IDThuoc.</value>
        public Int64 IDLich
        {
            get { return GetProperty(IDLichProperty); }
            set { SetProperty(IDLichProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLo"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NgayThuProperty = RegisterProperty<string>(p => p.NgayThu, "NgayThu");
        /// <summary>
        /// Gets or sets the So Lo.
        /// </summary>
        /// <value>The So Lo.</value>
        public string NgayThu
        {
            get { return GetProperty(NgayThuProperty); }
            set { SetProperty(NgayThuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GioProperty = RegisterProperty<string>(p => p.Gio, "Gio");
        /// <summary>
        /// Gets or sets the So Luong.
        /// </summary>
        /// <value>The So Luong.</value>
        public string Gio
        {
            get { return GetProperty(GioProperty); }
            set { SetProperty(GioProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DonGia"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDungProperty = RegisterProperty<string>(p => p.NoiDung, "NoiDung");
        /// <summary>
        /// Gets or sets the Don Gia.
        /// </summary>
        /// <value>The Don Gia.</value>
        public string NoiDung
        {
            get { return GetProperty(NoiDungProperty); }
            set { SetProperty(NoiDungProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HanDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayTaoCTProperty = RegisterProperty<SmartDate>(p => p.NgayTaoCT, "NgayTaoCT");
        /// <summary>
        /// Gets or sets the Han Dung.
        /// </summary>
        /// <value>The Han Dung.</value>
        public SmartDate NgayTaoCT
        {
            get { return GetProperty(NgayTaoCTProperty); }
            set { SetProperty(NgayTaoCTProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChietKhau"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoLuongHocVienProperty = RegisterProperty<string>(p => p.SoLuongHocVien, "SoLuongHocVien");
        /// <summary>
        /// Gets or sets the Chiet Khau.
        /// </summary>
        /// <value>The Chiet Khau.</value>
        public string SoLuongHocVien
        {
            get { return GetProperty(SoLuongHocVienProperty); }
            set { SetProperty(SoLuongHocVienProperty, value); }
        }

        public static readonly PropertyInfo<string> DiaDiemProperty = RegisterProperty<string>(p => p.DiaDiem, "DiaDiem");
        /// <summary>
        /// Gets or sets the Chiet Khau.
        /// </summary>
        /// <value>The Chiet Khau.</value>
        public string DiaDiem
        {
            get { return GetProperty(DiaDiemProperty); }
            set { SetProperty(DiaDiemProperty, value); }
        }

        public static readonly PropertyInfo<bool> CoDangKyProperty = RegisterProperty<bool>(p => p.CoDangKy, "CoDangKy");
        /// <summary>
        /// Gets or sets the Chiet Khau.
        /// </summary>
        /// <value>The Chiet Khau.</value>
        public bool CoDangKy
        {
            get { return GetProperty(CoDangKyProperty); }
            set { SetProperty(CoDangKyProperty, value); }
        }

        public static readonly PropertyInfo<Int64?> IDCanBoPhuTrachProperty = RegisterProperty<Int64?>(p => p.IDCanBoPhuTrach, "IDCanBoPhuTrach");
        /// <summary>
        /// Gets or sets the Chiet Khau.
        /// </summary>
        /// <value>The Chiet Khau.</value>
        public Int64? IDCanBoPhuTrach
        {
            get { return GetProperty(IDCanBoPhuTrachProperty); }
            set { SetProperty(IDCanBoPhuTrachProperty, value); }
        }

        public static readonly PropertyInfo<string> NguonKinhPhiProperty = RegisterProperty<string>(p => p.NguonKinhPhi, "NguonKinhPhi");
      
        public string NguonKinhPhi
        {
            get { return GetProperty(NguonKinhPhiProperty); }
            set { SetProperty(NguonKinhPhiProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PhieuNhapCT_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="PhieuNhapCT_Info"/> object.</returns>
        internal static HC_LichLamViecTheoPhong_CT_Info NewHC_LichLamViecTheoPhong_CT_Info()
        {
            return DataPortal.CreateChild<HC_LichLamViecTheoPhong_CT_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="PhieuNhapCT_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewHC_LichLamViecTheoPhong_CT_Info(EventHandler<DataPortalResult<HC_LichLamViecTheoPhong_CT_Info>> callback)
        {
            DataPortal.BeginCreate<HC_LichLamViecTheoPhong_CT_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PhieuNhapCT_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PhieuNhapCT_Info"/> object.</returns>
        internal static HC_LichLamViecTheoPhong_CT_Info GetHC_LichLamViecTheoPhong_CT_Info(SafeDataReader dr)
        {
            HC_LichLamViecTheoPhong_CT_Info obj = new HC_LichLamViecTheoPhong_CT_Info();
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
        private HC_LichLamViecTheoPhong_CT_Info()
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
            LoadProperty(IDLichChiTietProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(IDLichProperty, null);
            LoadProperty(NgayThuProperty, null);
            LoadProperty(GioProperty, null);
            LoadProperty(NoiDungProperty, null);
            LoadProperty(NgayTaoCTProperty, null);
            LoadProperty(SoLuongHocVienProperty, null);
            LoadProperty(DiaDiemProperty, null);
            LoadProperty(CoDangKyProperty, null);
            LoadProperty(IDCanBoPhuTrachProperty, null);
            LoadProperty(NguonKinhPhiProperty, null);
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
            LoadProperty(IDLichChiTietProperty, dr.GetInt64("IDLichChiTiet"));
            LoadProperty(IDLichProperty, dr.GetInt64("IDLich"));
            LoadProperty(NgayThuProperty, dr.GetString("NgayThu"));
            LoadProperty(GioProperty, dr.GetString("Gio"));
            LoadProperty(NoiDungProperty, dr.GetString("NoiDung"));
            LoadProperty(NgayTaoCTProperty, dr.GetDateTime("NgayTaoCT"));
            LoadProperty(SoLuongHocVienProperty, dr.GetString("SoLuongHocVien"));
            LoadProperty(DiaDiemProperty, dr.GetString("DiaDiem"));
            LoadProperty(CoDangKyProperty, dr.GetBoolean("CoDangKy"));
            LoadProperty(IDCanBoPhuTrachProperty, dr.GetInt64("IDCanBoPhuTrach"));
            LoadProperty(NguonKinhPhiProperty, dr.GetString("NguonKinhPhi"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="PhieuNhapCT_Info"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        private void Child_Insert(HC_LichLamViecTheoPhong parent)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTheoPhong_CT_Info_ins", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLich", parent.IDLich).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDLichChiTiet", ReadProperty(IDLichChiTietProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@NgayThu", ReadProperty(NgayThuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Gio", ReadProperty(GioProperty) == null ? (object)DBNull.Value : ReadProperty(GioProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayTaoCT", ReadProperty(NgayTaoCTProperty) == null ? (object)DBNull.Value : ReadProperty(NgayTaoCTProperty)).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@SoLuongHocVien", ReadProperty(SoLuongHocVienProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongHocVienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DiaDiem", ReadProperty(DiaDiemProperty) == null ? (object)DBNull.Value : ReadProperty(DiaDiemProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CoDangKy", ReadProperty(CoDangKyProperty) == null ? (object)DBNull.Value : ReadProperty(CoDangKyProperty)).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@IDCanBoPhuTrach", ReadProperty(IDCanBoPhuTrachProperty) == null ? (object)DBNull.Value : ReadProperty(IDCanBoPhuTrachProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@NguonKinhPhi", ReadProperty(NguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(NguonKinhPhiProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDLichChiTietProperty, (long)cmd.Parameters["@IDLichChiTiet"].Value);
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
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTheoPhong_CT_Info_upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLichChiTiet", ReadProperty(IDLichChiTietProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@NgayThu", ReadProperty(NgayThuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Gio", ReadProperty(GioProperty) == null ? (object)DBNull.Value : ReadProperty(GioProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayTaoCT", ReadProperty(NgayTaoCTProperty) == null ? (object)DBNull.Value : ReadProperty(NgayTaoCTProperty)).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@SoLuongHocVien", ReadProperty(SoLuongHocVienProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongHocVienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DiaDiem", ReadProperty(DiaDiemProperty) == null ? (object)DBNull.Value : ReadProperty(DiaDiemProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CoDangKy", ReadProperty(CoDangKyProperty) == null ? (object)DBNull.Value : ReadProperty(CoDangKyProperty)).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@IDCanBoPhuTrach", ReadProperty(IDCanBoPhuTrachProperty) == null ? (object)DBNull.Value : ReadProperty(IDCanBoPhuTrachProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@NguonKinhPhi", ReadProperty(NguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(NguonKinhPhiProperty)).DbType = DbType.String;
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
                using (var cmd = new SqlCommand("dbo.HC_LichLamViecTheoPhong_CT_Info_del", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLichChiTiet", ReadProperty(IDLichChiTietProperty)).DbType = DbType.Int64;
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
