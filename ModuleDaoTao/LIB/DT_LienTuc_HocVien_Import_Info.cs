using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csla;
using Csla.Data;
using NETLINK.LIB;
using System.Data;
using System.Data.SqlClient;

namespace ModuleDaoTao.LIB
{
    [Serializable]
    public partial class DT_LienTuc_HocVien_Import_Info : BusinessBase<DT_LienTuc_HocVien_Import_Info>
    {
        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        public static readonly PropertyInfo<string> HoTenProperty = RegisterProperty<string>(p => p.HoTen, "Ho ten");
        public string HoTen
        {
            get { return GetProperty(HoTenProperty); }
        }

        public static readonly PropertyInfo<DateTime> NgaySinhProperty = RegisterProperty<DateTime>(p => p.NgaySinh, "Ngayf sinh");
        public DateTime NgaySinh
        {
            get { return GetProperty(NgaySinhProperty); }
        }

        public static readonly PropertyInfo<string> GioiTinhProperty = RegisterProperty<string>(p => p.GioiTinh, "GioiTinh");
        public string GioiTinh
        {
            get { return GetProperty(GioiTinhProperty); }
        }

        public static readonly PropertyInfo<string> CMNDProperty = RegisterProperty<string>(p => p.CMND, "CMND");
        public string CMND
        {
            get { return GetProperty(CMNDProperty); }
        }

        public static readonly PropertyInfo<SmartDate> NgayCapProperty = RegisterProperty<SmartDate>(p => p.NgayCap, "NgayCap");
        public SmartDate NgayCap
        {
            get { return GetProperty(NgayCapProperty); }
        }

        public static readonly PropertyInfo<string> TaiProperty = RegisterProperty<string>(p => p.Tai, "Tai");
        public string Tai
        {
            get { return GetProperty(TaiProperty); }
        }

        public static readonly PropertyInfo<string> TrinhDoProperty = RegisterProperty<string>(p => p.TrinhDo, "TrinhDo");
        public string TrinhDo
        {
            get { return GetProperty(TrinhDoProperty); }
        }

        public static readonly PropertyInfo<string> ChuyenNganhProperty = RegisterProperty<string>(p => p.ChuyenNganh, "ChuyenNganh");
        public string ChuyenNganh
        {
            get { return GetProperty(ChuyenNganhProperty); }
        }

        public static readonly PropertyInfo<string> TruongTotNghiepProperty = RegisterProperty<string>(p => p.TruongTotNghiep, "TruongTotNghiep");
        public string TruongTotNghiep
        {
            get { return GetProperty(TruongTotNghiepProperty); }
        }

        public static readonly PropertyInfo<string> SoBangProperty = RegisterProperty<string>(p => p.SoBang, "SoBang");
        public string SoBang
        {
            get { return GetProperty(SoBangProperty); }
        }

        public static readonly PropertyInfo<Int32> NamTotNghiepProperty = RegisterProperty<Int32>(p => p.NamTotNghiep, "NamTotNghiep");
        public Int32 NamTotNghiep
        {
            get { return GetProperty(NamTotNghiepProperty); }
        }

        public static readonly PropertyInfo<string> NoiCongTacProperty = RegisterProperty<string>(p => p.NoiCongTac, "NoiCongTac");
        public string NoiCongTac
        {
            get { return GetProperty(NoiCongTacProperty); }
        }

        public static readonly PropertyInfo<string> TinhThanhProperty = RegisterProperty<string>(p => p.TinhThanh, "TinhThanh");
        public string TinhThanh
        {
            get { return GetProperty(TinhThanhProperty); }
        }

        public static readonly PropertyInfo<string> DiaChiCoQuanProperty = RegisterProperty<string>(p => p.DiaChiCoQuan, "DiaChiCoQuan");
        public string DiaChiCoQuan
        {
            get { return GetProperty(DiaChiCoQuanProperty); }
        }

        public static readonly PropertyInfo<string> BoPhanQuanLyProperty = RegisterProperty<string>(p => p.BoPhanQuanLy, "BoPhanQuanLy");
        public string BoPhanQuanLy
        {
            get { return GetProperty(BoPhanQuanLyProperty); }
        }

        public static readonly PropertyInfo<string> HinhThucHocProperty = RegisterProperty<string>(p => p.HinhThucHoc, "HinhThucHoc");
        public string HinhThucHoc
        {
            get { return GetProperty(HinhThucHocProperty); }
        }

        public static readonly PropertyInfo<SmartDate> NgayDangKyProperty = RegisterProperty<SmartDate>(p => p.NgayDangKy, "NgayDangKy");
        public SmartDate NgayDangKy
        {
            get { return GetProperty(NgayDangKyProperty); }
        }

        public static readonly PropertyInfo<string> ChuyenKhoaDKProperty = RegisterProperty<string>(p => p.ChuyenKhoaDK, "ChuyenKhoaDK");
        public string ChuyenKhoaDK
        {
            get { return GetProperty(ChuyenKhoaDKProperty); }
        }

        public static readonly PropertyInfo<string> NoiDungHocProperty = RegisterProperty<string>(p => p.NoiDungHoc, "NoiDungHoc");
        public string NoiDungHoc
        {
            get { return GetProperty(NoiDungHocProperty); }
        }

        public static readonly PropertyInfo<string> TrangThaiProperty = RegisterProperty<string>(p => p.TrangThai, "TrangThai");
        public string TrangThai
        {
            get { return GetProperty(TrangThaiProperty); }
        }

        public static readonly PropertyInfo<SmartDate> NgayBatDauProperty = RegisterProperty<SmartDate>(p => p.NgayBatDau, "NgayBatDau");
        public SmartDate NgayBatDau
        {
            get { return GetProperty(NgayBatDauProperty); }
        }

        public static readonly PropertyInfo<SmartDate> NgayKetThucProperty = RegisterProperty<SmartDate>(p => p.NgayKetThuc, "NgayKetThuc");
        public SmartDate NgayKetThuc
        {
            get { return GetProperty(NgayKetThucProperty); }
        }

        public static readonly PropertyInfo<string> SoTienProperty = RegisterProperty<string>(p => p.SoTien, "SoTien");
        public string SoTien
        {
            get { return GetProperty(SoTienProperty); }
        }

        #endregion

         #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PhieuXuatBnCTInfo"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="PhieuXuatBnCTInfo"/> object.</returns>
        internal static DT_LienTuc_HocVien_Import_Info NewDT_LienTuc_HocVien_Import_Info()
        {
            //if (!CanAddObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền thêm ");
            return DataPortal.CreateChild<DT_LienTuc_HocVien_Import_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="PhieuXuatBnCTInfo"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDT_LienTuc_HocVien_Import_Info(EventHandler<DataPortalResult<DT_LienTuc_HocVien_Import_Info>> callback)
        {
            DataPortal.BeginCreate<DT_LienTuc_HocVien_Import_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PhieuXuatBnCTInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PhieuXuatBnCTInfo"/> object.</returns>
        internal static DT_LienTuc_HocVien_Import_Info GetDT_LienTuc_HocVien_Import_Info(SafeDataReader dr)
        {
            DT_LienTuc_HocVien_Import_Info obj = new DT_LienTuc_HocVien_Import_Info();
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
        /// Initializes a new instance of the <see cref="PhieuXuatBnCTInfo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public DT_LienTuc_HocVien_Import_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="PhieuXuatBnCTInfo"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            //LoadProperty(IDPhieuXuatKHCTProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            //LoadProperty(HanDungProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="PhieuXuatBnCTInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {

            // Value properties
            LoadProperty(HoTenProperty, !dr.IsDBNull("HoTen") ? dr.GetString("HoTen") : null);
            LoadProperty(NgaySinhProperty, dr.GetSmartDate("NgaySinh"));
            LoadProperty(GioiTinhProperty, !dr.IsDBNull("GioiTinh") ? dr.GetString("GioiTinh") : null);
            LoadProperty(CMNDProperty, !dr.IsDBNull("SoCMT") ? dr.GetString("SoCMT") : null);
            LoadProperty(NgayCapProperty, dr.GetSmartDate("NgayCap"));
            LoadProperty(TaiProperty, !dr.IsDBNull("Tai") ? dr.GetString("Tai") : null);
            LoadProperty(TrinhDoProperty, !dr.IsDBNull("TrinhDo") ? dr.GetString("TrinhDo") : null);
            LoadProperty(ChuyenNganhProperty, !dr.IsDBNull("ChuyenNganh") ? dr.GetString("ChuyenNganh") : null);
            LoadProperty(TruongTotNghiepProperty, !dr.IsDBNull("TruongTotNghiep") ? dr.GetString("TruongTotNghiep") : null);
            LoadProperty(SoBangProperty, !dr.IsDBNull("SoBang") ? dr.GetString("SoBang") : null);
            LoadProperty(NamTotNghiepProperty, dr.GetInt32("NamTotNghiep"));
            LoadProperty(NoiCongTacProperty, !dr.IsDBNull("NoiCongTac") ? dr.GetString("NoiCongTac") : null);
            LoadProperty(TinhThanhProperty, !dr.IsDBNull("TinhThanh") ? dr.GetString("TinhThanh") : null);
            LoadProperty(DiaChiCoQuanProperty, !dr.IsDBNull("DiaChiCoQuan") ? dr.GetString("DiaChiCoQuan") : null);
            LoadProperty(BoPhanQuanLyProperty, !dr.IsDBNull("BoPhanQuanLy") ? dr.GetString("BoPhanQuanLy") : null);
            LoadProperty(HinhThucHocProperty, !dr.IsDBNull("HinhThucHoc") ? dr.GetString("HinhThucHoc") : null);
            LoadProperty(NgayDangKyProperty, dr.GetSmartDate("NgayDangKy"));
            LoadProperty(ChuyenKhoaDKProperty, !dr.IsDBNull("ChuyenKhoa") ? dr.GetString("ChuyenKhoa") : null);
            LoadProperty(NoiDungHocProperty, !dr.IsDBNull("NoiDungHoc") ? dr.GetString("NoiDungHoc") : null);
            LoadProperty(TrangThaiProperty, !dr.IsDBNull("TrangThai") ? dr.GetString("TrangThai") : null);
            LoadProperty(NgayBatDauProperty, dr.GetSmartDate("NgayBatDau"));
            LoadProperty(NgayKetThucProperty, dr.GetSmartDate("NgayKetThuc"));
            LoadProperty(SoTienProperty, !dr.IsDBNull("SoTien") ? dr.GetString("SoTien") : null);
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="PhieuXuatBnCTInfo"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection", true))
            {
                using (var cmd = new SqlCommand("dbo.DT_LienTuc_HocVien_Import_Info_ins", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HoTen", ReadProperty(HoTenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgaySinh", ReadProperty(NgaySinhProperty)).DbType = DbType.Date;
                    cmd.Parameters.AddWithValue("@GioiTinh", ReadProperty(GioiTinhProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoCMT", ReadProperty(CMNDProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayCap", ReadProperty(NgayCapProperty)).DbType = DbType.Date;
                    cmd.Parameters.AddWithValue("@NoiCap", ReadProperty(TaiProperty) == null ? (object)DBNull.Value : ReadProperty(TaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TrinhDo", ReadProperty(TrinhDoProperty) == null ? (object)DBNull.Value : ReadProperty(TrinhDoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChuyenNganh", ReadProperty(ChuyenNganhProperty) == null ? (object)DBNull.Value : ReadProperty(ChuyenNganhProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TruongTotNghiep", ReadProperty(TruongTotNghiepProperty) == null ? (object)DBNull.Value : ReadProperty(TruongTotNghiepProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoBang", ReadProperty(SoBangProperty) == null ? (object)DBNull.Value : ReadProperty(SoBangProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NamTotNghiep", ReadProperty(NamTotNghiepProperty) == null ? (object)DBNull.Value : ReadProperty(NamTotNghiepProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NoiCongTac", ReadProperty(NoiCongTacProperty) == null ? (object)DBNull.Value : ReadProperty(NoiCongTacProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TinhThanh", ReadProperty(TinhThanhProperty) == null ? (object)DBNull.Value : ReadProperty(TinhThanhProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DiaChiCoQuan", ReadProperty(DiaChiCoQuanProperty) == null ? (object)DBNull.Value : ReadProperty(DiaChiCoQuanProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@BoPhanQuanLy", ReadProperty(BoPhanQuanLyProperty) == null ? (object)DBNull.Value : ReadProperty(BoPhanQuanLyProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@HinhThucHoc", ReadProperty(HinhThucHocProperty) == null ? (object)DBNull.Value : ReadProperty(HinhThucHocProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayDangKy", ReadProperty(NgayDangKyProperty)).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@ChuyenKhoa", ReadProperty(ChuyenKhoaDKProperty) == null ? (object)DBNull.Value : ReadProperty(ChuyenKhoaDKProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDungHoc", ReadProperty(NoiDungHocProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungHocProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TrangThai", ReadProperty(TrangThaiProperty) == null ? (object)DBNull.Value : ReadProperty(TrangThaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayBatDau", ReadProperty(NgayBatDauProperty)).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ReadProperty(NgayKetThucProperty)).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@SoTien", ReadProperty(SoTienProperty) == null ? (object)DBNull.Value : ReadProperty(SoTienProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
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
