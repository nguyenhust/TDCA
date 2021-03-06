//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_ThietBiTienLamSang_Info
// ObjectType:  HC_ThietBiTienLamSang_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
namespace ModuleHanhChinh.LIB
{

    /// <summary>
    /// HC_ThietBiTienLamSang_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="HC_ThietBiTienLamSang_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="HC_ThietBiTienLamSang_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class HC_ThietBiTienLamSang_Info : BusinessBase<HC_ThietBiTienLamSang_Info>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IDProperty = RegisterProperty<int>(p => p.ID, "ID");
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public int ID
        {
            get { return GetProperty(IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TenThietBi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenThietBiProperty = RegisterProperty<string>(p => p.TenThietBi, "Ten Thiet Bi");
        /// <summary>
        /// Gets or sets the Ten Thiet Bi.
        /// </summary>
        /// <value>The Ten Thiet Bi.</value>
        public string TenThietBi
        {
            get { return GetProperty(TenThietBiProperty); }
            set { SetProperty(TenThietBiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NhapSoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> NhapSoLuongProperty = RegisterProperty<int?>(p => p.NhapSoLuong, "Nhap So Luong");
        /// <summary>
        /// Gets or sets the Nhap So Luong.
        /// </summary>
        /// <value>The Nhap So Luong.</value>
        public int? NhapSoLuong
        {
            get { return GetProperty(NhapSoLuongProperty); }
            set { SetProperty(NhapSoLuongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TinhTrang"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TinhTrangProperty = RegisterProperty<string>(p => p.TinhTrang, "Tinh Trang");
        /// <summary>
        /// Gets or sets the Tinh Trang.
        /// </summary>
        /// <value>The Tinh Trang.</value>
        public string TinhTrang
        {
            get { return GetProperty(TinhTrangProperty); }
            set { SetProperty(TinhTrangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="XuatSoLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> XuatSoLuongProperty = RegisterProperty<int?>(p => p.XuatSoLuong, "Xuat So Luong");
        /// <summary>
        /// Gets or sets the Xuat So Luong.
        /// </summary>
        /// <value>The Xuat So Luong.</value>
        public int? XuatSoLuong
        {
            get { return GetProperty(XuatSoLuongProperty); }
            set { SetProperty(XuatSoLuongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HangSanXuat"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> HangSanXuatProperty = RegisterProperty<string>(p => p.HangSanXuat, "Hang San Xuat");
        /// <summary>
        /// Gets or sets the Hang San Xuat.
        /// </summary>
        /// <value>The Hang San Xuat.</value>
        public string HangSanXuat
        {
            get { return GetProperty(HangSanXuatProperty); }
            set { SetProperty(HangSanXuatProperty, value); }
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
        /// Maintains metadata about <see cref="MaThietBi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaThietBiProperty = RegisterProperty<string>(p => p.MaThietBi, "Ma Thiet Bi");
        /// <summary>
        /// Gets or sets the Ma Thiet Bi.
        /// </summary>
        /// <value>The Ma Thiet Bi.</value>
        public string MaThietBi
        {
            get { return GetProperty(MaThietBiProperty); }
            set { SetProperty(MaThietBiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SerialThietBi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SerialThietBiProperty = RegisterProperty<string>(p => p.SerialThietBi, "Serial Thiet Bi");
        /// <summary>
        /// Gets or sets the Serial Thiet Bi.
        /// </summary>
        /// <value>The Serial Thiet Bi.</value>
        public string SerialThietBi
        {
            get { return GetProperty(SerialThietBiProperty); }
            set { SetProperty(SerialThietBiProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="SerialThietBi"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TongTonKhoProperty = RegisterProperty<string>(p => p.TongTonKho, "Tong Ton Kho");
        /// <summary>
        /// Gets or sets the Serial Thiet Bi.
        /// </summary>
        /// <value>The Serial Thiet Bi.</value>
        public string TongTonKho
        {
            get { return GetProperty(TongTonKhoProperty); }
            set { SetProperty(TongTonKhoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idNguonKinhPhi"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdNguonKinhPhiProperty = RegisterProperty<int?>(p => p.IdNguonKinhPhi, "id Nguon Kinh Phi");
        /// <summary>
        /// Gets or sets the id Nguon Kinh Phi.
        /// </summary>
        /// <value>The id Nguon Kinh Phi.</value>
        public int? IdNguonKinhPhi
        {
            get { return GetProperty(IdNguonKinhPhiProperty); }
            set { SetProperty(IdNguonKinhPhiProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_ThietBiTienLamSang_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_ThietBiTienLamSang_Info"/> object.</returns>
        internal static HC_ThietBiTienLamSang_Info NewHC_ThietBiTienLamSang_Info()
        {
            return DataPortal.CreateChild<HC_ThietBiTienLamSang_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_ThietBiTienLamSang_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewHC_ThietBiTienLamSang_Info(EventHandler<DataPortalResult<HC_ThietBiTienLamSang_Info>> callback)
        {
            DataPortal.BeginCreate<HC_ThietBiTienLamSang_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_ThietBiTienLamSang_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="HC_ThietBiTienLamSang_Info"/> object.</returns>
        internal static HC_ThietBiTienLamSang_Info GetHC_ThietBiTienLamSang_Info(SafeDataReader dr)
        {
            HC_ThietBiTienLamSang_Info obj = new HC_ThietBiTienLamSang_Info();
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
        /// Initializes a new instance of the <see cref="HC_ThietBiTienLamSang_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_ThietBiTienLamSang_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="HC_ThietBiTienLamSang_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(TenThietBiProperty, null);
            LoadProperty(TinhTrangProperty, null);
            LoadProperty(HangSanXuatProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(MaThietBiProperty, null);
            LoadProperty(SerialThietBiProperty, null);
            LoadProperty(TongTonKhoProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="HC_ThietBiTienLamSang_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(TenThietBiProperty, dr.GetString("TenThietBi"));
            LoadProperty(NhapSoLuongProperty, dr.GetInt32("NhapSoLuong"));
            LoadProperty(TinhTrangProperty, dr.GetString("TinhTrang"));
            LoadProperty(XuatSoLuongProperty, dr.GetInt32("XuatSoLuong"));
            LoadProperty(HangSanXuatProperty, dr.GetString("HangSanXuat"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(MaThietBiProperty, dr.GetString("MaThietBi"));
            LoadProperty(SerialThietBiProperty, dr.GetString("SerialThietBi"));
           // LoadProperty(TongTonKhoProperty, dr.GetString("TongTonKho"));
                   //LoadProperty(IdNguonKinhPhiProperty, dr.GetInt32("idNguonKinhPhi"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="HC_ThietBiTienLamSang_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_ThietBiTienLamSang_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@TenThietBi", ReadProperty(TenThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(TenThietBiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NhapSoLuong", ReadProperty(NhapSoLuongProperty) == null ? (object)DBNull.Value : ReadProperty(NhapSoLuongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TinhTrang", ReadProperty(TinhTrangProperty) == null ? (object)DBNull.Value : ReadProperty(TinhTrangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatSoLuong", ReadProperty(XuatSoLuongProperty) == null ? (object)DBNull.Value : ReadProperty(XuatSoLuongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@HangSanXuat", ReadProperty(HangSanXuatProperty) == null ? (object)DBNull.Value : ReadProperty(HangSanXuatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaThietBi", ReadProperty(MaThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(MaThietBiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SerialThietBi", ReadProperty(SerialThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(SerialThietBiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (int) cmd.Parameters["@ID"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_ThietBiTienLamSang_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_ThietBiTienLamSang_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TenThietBi", ReadProperty(TenThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(TenThietBiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NhapSoLuong", ReadProperty(NhapSoLuongProperty) == null ? (object)DBNull.Value : ReadProperty(NhapSoLuongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TinhTrang", ReadProperty(TinhTrangProperty) == null ? (object)DBNull.Value : ReadProperty(TinhTrangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@XuatSoLuong", ReadProperty(XuatSoLuongProperty) == null ? (object)DBNull.Value : ReadProperty(XuatSoLuongProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@HangSanXuat", ReadProperty(HangSanXuatProperty) == null ? (object)DBNull.Value : ReadProperty(HangSanXuatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaThietBi", ReadProperty(MaThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(MaThietBiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SerialThietBi", ReadProperty(SerialThietBiProperty) == null ? (object)DBNull.Value : ReadProperty(SerialThietBiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idNguonKinhPhi", ReadProperty(IdNguonKinhPhiProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguonKinhPhiProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="HC_ThietBiTienLamSang_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_ThietBiTienLamSang_Info_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
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
