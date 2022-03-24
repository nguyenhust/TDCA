using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
using Csla.Rules.CommonRules;

namespace DanhMuc.LIB
{
    [Serializable]
   public partial class   DIC_GiangVien:BusinessBase<DIC_GiangVien>
    {
            #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDProperty = RegisterProperty<Int64>(p => p.IDGiangVien, "ID");
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 IDGiangVien
        {
            get { return GetProperty(IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HoTen"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> HoTenProperty = RegisterProperty<string>(p => p.HoTen, "Ho Ten");
        /// <summary>
        /// Gets or sets the Ho Ten.
        /// </summary>
        /// <value>The Ho Ten.</value>
        public string HoTen
        {
            get { return GetProperty(HoTenProperty); }
            set { SetProperty(HoTenProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GioiTinh"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GioiTinhProperty = RegisterProperty<string>(p => p.GioiTinh, "Gioi Tinh");
        /// <summary>
        /// Gets or sets the Gioi Tinh.
        /// </summary>
        /// <value>The Gioi Tinh.</value>
        public string GioiTinh
        {
            get { return GetProperty(GioiTinhProperty); }
            set { SetProperty(GioiTinhProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgaySinh"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgaySinhProperty = RegisterProperty<SmartDate>(p => p.NgaySinh, "Ngay Sinh");
        /// <summary>
        /// Gets or sets the Ngay Sinh.
        /// </summary>
        /// <value>The Ngay Sinh.</value>
        public string NgaySinh
        {
            get { return GetPropertyConvert<SmartDate, String>(NgaySinhProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgaySinhProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDTinh"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IDTinhProperty = RegisterProperty<Int64?>(p => p.IDTinh, "IDTinh");
        /// <summary>
        /// Gets or sets the IDTinh.
        /// </summary>
        /// <value>The IDTinh.</value>
        public Int64? IDTinh
        {
            get { return GetProperty(IDTinhProperty); }
            set { SetProperty(IDTinhProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChoOHiennay"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChoOHiennayProperty = RegisterProperty<string>(p => p.ChoOHiennay, "Cho OHiennay");
        /// <summary>
        /// Gets or sets the Cho OHiennay.
        /// </summary>
        /// <value>The Cho OHiennay.</value>
        public string ChoOHiennay
        {
            get { return GetProperty(ChoOHiennayProperty); }
            set { SetProperty(ChoOHiennayProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="QuocGia"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> QuocGiaProperty = RegisterProperty<string>(p => p.QuocGia, "Quoc Gia");
        /// <summary>
        /// Gets or sets the Quoc Gia.
        /// </summary>
        /// <value>The Quoc Gia.</value>
        public string QuocGia
        {
            get { return GetProperty(QuocGiaProperty); }
            set { SetProperty(QuocGiaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayVaoDang"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayVaoDangProperty = RegisterProperty<SmartDate>(p => p.NgayVaoDang, "Ngay Vao Dang");
        /// <summary>
        /// Gets or sets the Ngay Vao Dang.
        /// </summary>
        /// <value>The Ngay Vao Dang.</value>
        public string NgayVaoDang
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayVaoDangProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayVaoDangProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDTrinhDo"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IDTrinhDoProperty = RegisterProperty<int?>(p => p.IDTrinhDo, "IDTrinh Do");
        /// <summary>
        /// Gets or sets the IDTrinh Do.
        /// </summary>
        /// <value>The IDTrinh Do.</value>
        public int? IDTrinhDo
        {
            get { return GetProperty(IDTrinhDoProperty); }
            set { SetProperty(IDTrinhDoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDCoQuan"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IDCoQuanProperty = RegisterProperty<int?>(p => p.IDCoQuan, "IDCo Quan");
        /// <summary>
        /// Gets or sets the IDCo Quan.
        /// </summary>
        /// <value>The IDCo Quan.</value>
        public int? IDCoQuan
        {
            get { return GetProperty(IDCoQuanProperty); }
            set { SetProperty(IDCoQuanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDChucVu"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IDChucVuProperty = RegisterProperty<int?>(p => p.IDChucVu, "IDChuc Vu");
        /// <summary>
        /// Gets or sets the IDChuc Vu.
        /// </summary>
        /// <value>The IDChuc Vu.</value>
        public int? IDChucVu
        {
            get { return GetProperty(IDChucVuProperty); }
            set { SetProperty(IDChucVuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="QTDaoTao"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> QTDaoTaoProperty = RegisterProperty<string>(p => p.QTDaoTao, "QTDao Tao");
        /// <summary>
        /// Gets or sets the QTDao Tao.
        /// </summary>
        /// <value>The QTDao Tao.</value>
        public string QTDaoTao
        {
            get { return GetProperty(QTDaoTaoProperty); }
            set { SetProperty(QTDaoTaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="QTCongTac"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> QTCongTacProperty = RegisterProperty<string>(p => p.QTCongTac, "QTCong Tac");
        /// <summary>
        /// Gets or sets the QTCong Tac.
        /// </summary>
        /// <value>The QTCong Tac.</value>
        public string QTCongTac
        {
            get { return GetProperty(QTCongTacProperty); }
            set { SetProperty(QTCongTacProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="KinhNghiemNN"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> KinhNghiemNNProperty = RegisterProperty<string>(p => p.KinhNghiemNN, "Kinh Nghiem NN");
        /// <summary>
        /// Gets or sets the Kinh Nghiem NN.
        /// </summary>
        /// <value>The Kinh Nghiem NN.</value>
        public string KinhNghiemNN
        {
            get { return GetProperty(KinhNghiemNNProperty); }
            set { SetProperty(KinhNghiemNNProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NghienCuuTGia"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NghienCuuTGiaProperty = RegisterProperty<string>(p => p.NghienCuuTGia, "Nghien Cuu TGia");
        /// <summary>
        /// Gets or sets the Nghien Cuu TGia.
        /// </summary>
        /// <value>The Nghien Cuu TGia.</value>
        public string NghienCuuTGia
        {
            get { return GetProperty(NghienCuuTGiaProperty); }
            set { SetProperty(NghienCuuTGiaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgoaiNguTinHoc"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NgoaiNguTinHocProperty = RegisterProperty<string>(p => p.NgoaiNguTinHoc, "Ngoai Ngu Tin Hoc");
        /// <summary>
        /// Gets or sets the Ngoai Ngu Tin Hoc.
        /// </summary>
        /// <value>The Ngoai Ngu Tin Hoc.</value>
        public string NgoaiNguTinHoc
        {
            get { return GetProperty(NgoaiNguTinHocProperty); }
            set { SetProperty(NgoaiNguTinHocProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="KhenThuongKyLuat"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> KhenThuongKyLuatProperty = RegisterProperty<string>(p => p.KhenThuongKyLuat, "Khen Thuong Ky Luat");
        /// <summary>
        /// Gets or sets the Khen Thuong Ky Luat.
        /// </summary>
        /// <value>The Khen Thuong Ky Luat.</value>
        public string KhenThuongKyLuat
        {
            get { return GetProperty(KhenThuongKyLuatProperty); }
            set { SetProperty(KhenThuongKyLuatProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HTapNCuuNNgoai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> HTapNCuuNNgoaiProperty = RegisterProperty<string>(p => p.HTapNCuuNNgoai, "HTap NCuu NNgoai");
        /// <summary>
        /// Gets or sets the HTap NCuu NNgoai.
        /// </summary>
        /// <value>The HTap NCuu NNgoai.</value>
        public string HTapNCuuNNgoai
        {
            get { return GetProperty(HTapNCuuNNgoaiProperty); }
            set { SetProperty(HTapNCuuNNgoaiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDBoPhan"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IDBoPhanProperty = RegisterProperty<int?>(p => p.IDBoPhan, "IDBo Phan");
        /// <summary>
        /// Gets or sets the IDBo Phan.
        /// </summary>
        /// <value>The IDBo Phan.</value>
        public int? IDBoPhan
        {
            get { return GetProperty(IDBoPhanProperty); }
            set { SetProperty(IDBoPhanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MaNhanVien"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaNhanVienProperty = RegisterProperty<string>(p => p.MaNhanVien, "Ma Nhan Vien");
        /// <summary>
        /// Gets or sets the Ma Nhan Vien.
        /// </summary>
        /// <value>The Ma Nhan Vien.</value>
        public string MaNhanVien
        {
            get { return GetProperty(MaNhanVienProperty); }
            set { SetProperty(MaNhanVienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MaNhanVienTheoMayCC"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaNhanVienTheoMayCCProperty = RegisterProperty<string>(p => p.MaNhanVienTheoMayCC, "Ma Nhan Vien Theo May CC");
        /// <summary>
        /// Gets or sets the Ma Nhan Vien Theo May CC.
        /// </summary>
        /// <value>The Ma Nhan Vien Theo May CC.</value>
        public string MaNhanVienTheoMayCC
        {
            get { return GetProperty(MaNhanVienTheoMayCCProperty); }
            set { SetProperty(MaNhanVienTheoMayCCProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DienThoai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DienThoaiProperty = RegisterProperty<string>(p => p.DienThoai, "Dien Thoai");
        /// <summary>
        /// Gets or sets the Dien Thoai.
        /// </summary>
        /// <value>The Dien Thoai.</value>
        public string DienThoai
        {
            get { return GetProperty(DienThoaiProperty); }
            set { SetProperty(DienThoaiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Email"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> EmailProperty = RegisterProperty<string>(p => p.Email, "Email");
        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        /// <value>The Email.</value>
        public string Email
        {
            get { return GetProperty(EmailProperty); }
            set { SetProperty(EmailProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="LoaiCanBo"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> LoaiCanBoProperty = RegisterProperty<int?>(p => p.LoaiCanBo, "Loai Can Bo");
        /// <summary>
        /// Gets or sets the Loai Can Bo.
        /// </summary>
        /// <value>The Loai Can Bo.</value>
        public int? LoaiCanBo
        {
            get { return GetProperty(LoaiCanBoProperty); }
            set { SetProperty(LoaiCanBoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DanToc"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DanTocProperty = RegisterProperty<string>(p => p.DanToc, "Dan Toc");
        /// <summary>
        /// Gets or sets the Dan Toc.
        /// </summary>
        /// <value>The Dan Toc.</value>
        public string DanToc
        {
            get { return GetProperty(DanTocProperty); }
            set { SetProperty(DanTocProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoCMT"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SoCMTProperty = RegisterProperty<string>(p => p.SoCMT, "So CMT");
        /// <summary>
        /// Gets or sets the So CMT.
        /// </summary>
        /// <value>The So CMT.</value>
        public string SoCMT
        {
            get { return GetProperty(SoCMTProperty); }
            set { SetProperty(SoCMTProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayCap"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayCapProperty = RegisterProperty<SmartDate>(p => p.NgayCap, "Ngay Cap");
        /// <summary>
        /// Gets or sets the Ngay Cap.
        /// </summary>
        /// <value>The Ngay Cap.</value>
        public string NgayCap
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayCapProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayCapProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NoiCap"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiCapProperty = RegisterProperty<string>(p => p.NoiCap, "Noi Cap");
        /// <summary>
        /// Gets or sets the Noi Cap.
        /// </summary>
        /// <value>The Noi Cap.</value>
        public string NoiCap
        {
            get { return GetProperty(NoiCapProperty); }
            set { SetProperty(NoiCapProperty, value); }
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
        /// Maintains metadata about <see cref="idChuyenNganh"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdChuyenNganhProperty = RegisterProperty<int?>(p => p.IdChuyenNganh, "id Chuyen Nganh");
        /// <summary>
        /// Gets or sets the id Chuyen Nganh.
        /// </summary>
        /// <value>The id Chuyen Nganh.</value>
        public int? IdChuyenNganh
        {
            get { return GetProperty(IdChuyenNganhProperty); }
            set { SetProperty(IdChuyenNganhProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idChuyenKhoa"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdChuyenKhoaProperty = RegisterProperty<int?>(p => p.IdChuyenKhoa, "id Chuyen Khoa");
        /// <summary>
        /// Gets or sets the id Chuyen Khoa.
        /// </summary>
        /// <value>The id Chuyen Khoa.</value>
        public int? IdChuyenKhoa
        {
            get { return GetProperty(IdChuyenKhoaProperty); }
            set { SetProperty(IdChuyenKhoaProperty, value); }
        }

      public static readonly PropertyInfo<int?> IdHocHamProperty = RegisterProperty<int?>(p => p.IdHocHam, "id Chuyen Khoa");
        /// <summary>
        /// Gets or sets the id Chuyen Khoa.
        /// </summary>
        /// <value>The id Chuyen Khoa.</value>
        public int? IdHocHam
        {
            get { return GetProperty(IdHocHamProperty); }
            set { SetProperty(IdHocHamProperty, value); }
        }

        public static readonly PropertyInfo<string> ChungChiProperty = RegisterProperty<string>(p => p.ChungChi, "id Chuyen Khoa");
        /// <summary>
        /// Gets or sets the id Chuyen Khoa.
        /// </summary>
        /// <value>The id Chuyen Khoa.</value>
        public string ChungChi
        {
            get { return GetProperty(ChungChiProperty); }
            set { SetProperty(ChungChiProperty, value); }
        }

        public static readonly PropertyInfo<int?> NamBatDauProperty = RegisterProperty<int?>(p => p.NamBatDau, "id Chuyen Khoa");
        /// <summary>
        /// Gets or sets the id Chuyen Khoa.
        /// </summary>
        /// <value>The id Chuyen Khoa.</value>
        public int? NamBatDau
        {
            get { return GetProperty(NamBatDauProperty); }
            set { SetProperty(NamBatDauProperty, value); }
        }
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_CanBo"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_CanBo"/> object.</returns>
        public static DIC_GiangVien NewDIC_GiangVien()
        {
            return DataPortal.Create<DIC_GiangVien>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_CanBo"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the DIC_CanBo to fetch.</param>
        /// <returns>A reference to the fetched <see cref="DIC_CanBo"/> object.</returns>
        public static DIC_GiangVien GetDIC_GiangVien(Int64 id)
        {
            return DataPortal.Fetch<DIC_GiangVien>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="DIC_CanBo"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the DIC_CanBo to delete.</param>
        public static void DeleteDIC_GiangVien(Int64 id)
        {
            DataPortal.Delete<DIC_GiangVien>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_CanBo"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewDIC_GiangVien(EventHandler<DataPortalResult<DIC_GiangVien>> callback)
        {
            DataPortal.BeginCreate<DIC_GiangVien>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="DIC_CanBo"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the DIC_CanBo to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetDIC_GiangVien(Int64 id, EventHandler<DataPortalResult<DIC_GiangVien>> callback)
        {
            DataPortal.BeginFetch<DIC_GiangVien>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="DIC_CanBo"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the DIC_CanBo to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteDIC_GiangVien(Int64 id, EventHandler<DataPortalResult<DIC_GiangVien>> callback)
        {
            DataPortal.BeginDelete<DIC_GiangVien>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_CanBo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_GiangVien()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DIC_CanBo"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(HoTenProperty, null);
            LoadProperty(GioiTinhProperty, null);
            LoadProperty(NgaySinhProperty, null);
            LoadProperty(ChoOHiennayProperty, null);
            LoadProperty(QuocGiaProperty, null);
            LoadProperty(NgayVaoDangProperty, null);
            LoadProperty(QTDaoTaoProperty, null);
            LoadProperty(QTCongTacProperty, null);
            LoadProperty(KinhNghiemNNProperty, null);
            LoadProperty(NghienCuuTGiaProperty, null);
            LoadProperty(NgoaiNguTinHocProperty, null);
            LoadProperty(KhenThuongKyLuatProperty, null);
            LoadProperty(HTapNCuuNNgoaiProperty, null);
            LoadProperty(MaNhanVienProperty, null);
            LoadProperty(MaNhanVienTheoMayCCProperty, null);
            LoadProperty(DienThoaiProperty, null);
            LoadProperty(EmailProperty, null);
            LoadProperty(DanTocProperty, null);
            LoadProperty(SoCMTProperty, null);
            LoadProperty(NgayCapProperty, null);
            LoadProperty(NoiCapProperty, null);
            LoadProperty(GhiChuProperty, null);
          
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="DIC_CanBo"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(Int64 id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_GiangVien_Get", ctx.Connection))
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
        /// Loads a <see cref="DIC_CanBo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt64("ID"));
            LoadProperty(HoTenProperty, dr.GetString("HoTen"));
            LoadProperty(GioiTinhProperty, dr.GetString("GioiTinh"));
            LoadProperty(NgaySinhProperty, dr.GetSmartDate("NgaySinh"));
            LoadProperty(IDTinhProperty, dr.GetInt64("IDTinh"));
            LoadProperty(ChoOHiennayProperty, dr.GetString("ChoOHiennay"));
            LoadProperty(QuocGiaProperty, dr.GetString("QuocGia"));
            LoadProperty(NgayVaoDangProperty, dr.GetSmartDate("NgayVaoDang"));
            
            LoadProperty(IDCoQuanProperty, dr.GetInt32("IDCoQuan"));
            LoadProperty(IDChucVuProperty, dr.GetInt32("IDChucVu"));
            LoadProperty(QTDaoTaoProperty, dr.GetString("QTDaoTao"));
            LoadProperty(QTCongTacProperty, dr.GetString("QTCongTa"));
            LoadProperty(KinhNghiemNNProperty, dr.GetString("KinhNghiemNN"));
            LoadProperty(NghienCuuTGiaProperty, dr.GetString("NghienCuuTGia"));
            LoadProperty(NgoaiNguTinHocProperty, dr.GetString("NgoaiNguTinHoc"));
            LoadProperty(KhenThuongKyLuatProperty, dr.GetString("KhenThuongKyLuat"));
            LoadProperty(HTapNCuuNNgoaiProperty, dr.GetString("HTapNCuuNNgoai"));
          //  LoadProperty(IDBoPhanProperty, dr.GetInt32("IDBoPhan"));
            LoadProperty(MaNhanVienProperty, dr.GetString("MaNhanVien"));
            LoadProperty(MaNhanVienTheoMayCCProperty, dr.GetString("MaNhanVienTheoMayCC"));
            LoadProperty(DienThoaiProperty, dr.GetString("DienThoai"));
            LoadProperty(EmailProperty, dr.GetString("Email"));
            LoadProperty(LoaiCanBoProperty, dr.GetInt32("LoaiCanBo"));
            LoadProperty(DanTocProperty, dr.GetString("DanToc"));
            LoadProperty(SoCMTProperty, dr.GetString("SoCMT"));
            LoadProperty(NgayCapProperty, dr.GetSmartDate("NgayCap"));
            LoadProperty(NoiCapProperty, dr.GetString("NoiCap"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(IdChuyenNganhProperty, dr.GetInt32("IdChuyenNganh"));
            LoadProperty(IdChuyenKhoaProperty, dr.GetInt32("IdChuyenKhoa"));
            LoadProperty(IdHocHamProperty, dr.GetInt32("IdHocHam"));
            LoadProperty(IDTrinhDoProperty, dr.GetInt32("IDTrinhDo"));
            LoadProperty(ChungChiProperty, dr.GetString("ChungChi"));
            LoadProperty(NamBatDauProperty, dr.GetInt32("NamBatDau"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DIC_CanBo"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_GiangVien_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@HoTen", ReadProperty(HoTenProperty) == null ? (object)DBNull.Value : ReadProperty(HoTenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GioiTinh", ReadProperty(GioiTinhProperty) == null ? (object)DBNull.Value : ReadProperty(GioiTinhProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgaySinh", ReadProperty(NgaySinhProperty).DBValue).DbType = DbType.Date;
                    cmd.Parameters.AddWithValue("@IDTinh", ReadProperty(IDTinhProperty) == null ? (object)DBNull.Value : ReadProperty(IDTinhProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@ChoOHiennay", ReadProperty(ChoOHiennayProperty) == null ? (object)DBNull.Value : ReadProperty(ChoOHiennayProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@QuocGia", ReadProperty(QuocGiaProperty) == null ? (object)DBNull.Value : ReadProperty(QuocGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayVaoDang", ReadProperty(NgayVaoDangProperty).DBValue).DbType = DbType.Date;
                    
                    cmd.Parameters.AddWithValue("@IDCoQuan", ReadProperty(IDCoQuanProperty) == null ? (object)DBNull.Value : ReadProperty(IDCoQuanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@IDChucVu", ReadProperty(IDChucVuProperty) == null ? (object)DBNull.Value : ReadProperty(IDChucVuProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@QTDaoTao", ReadProperty(QTDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(QTDaoTaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@QTCongTac", ReadProperty(QTCongTacProperty) == null ? (object)DBNull.Value : ReadProperty(QTCongTacProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@KinhNghiemNN", ReadProperty(KinhNghiemNNProperty) == null ? (object)DBNull.Value : ReadProperty(KinhNghiemNNProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NghienCuuTGia", ReadProperty(NghienCuuTGiaProperty) == null ? (object)DBNull.Value : ReadProperty(NghienCuuTGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgoaiNguTinHoc", ReadProperty(NgoaiNguTinHocProperty) == null ? (object)DBNull.Value : ReadProperty(NgoaiNguTinHocProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@KhenThuongKyLuat", ReadProperty(KhenThuongKyLuatProperty) == null ? (object)DBNull.Value : ReadProperty(KhenThuongKyLuatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@HTapNCuuNNgoai", ReadProperty(HTapNCuuNNgoaiProperty) == null ? (object)DBNull.Value : ReadProperty(HTapNCuuNNgoaiProperty)).DbType = DbType.String;
                  //  cmd.Parameters.AddWithValue("@IDBoPhan", ReadProperty(IDBoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(IDBoPhanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@MaNhanVien", ReadProperty(MaNhanVienProperty) == null ? (object)DBNull.Value : ReadProperty(MaNhanVienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaNhanVienTheoMayCC", ReadProperty(MaNhanVienTheoMayCCProperty) == null ? (object)DBNull.Value : ReadProperty(MaNhanVienTheoMayCCProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DienThoai", ReadProperty(DienThoaiProperty) == null ? (object)DBNull.Value : ReadProperty(DienThoaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Email", ReadProperty(EmailProperty) == null ? (object)DBNull.Value : ReadProperty(EmailProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LoaiCanBo", ReadProperty(LoaiCanBoProperty) == null ? (object)DBNull.Value : ReadProperty(LoaiCanBoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DanToc", ReadProperty(DanTocProperty) == null ? (object)DBNull.Value : ReadProperty(DanTocProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoCMT", ReadProperty(SoCMTProperty) == null ? (object)DBNull.Value : ReadProperty(SoCMTProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayCap", ReadProperty(NgayCapProperty).DBValue).DbType = DbType.Date;
                    cmd.Parameters.AddWithValue("@NoiCap", ReadProperty(NoiCapProperty) == null ? (object)DBNull.Value : ReadProperty(NoiCapProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idChuyenNganh", ReadProperty(IdChuyenNganhProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuyenNganhProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idChuyenKhoa", ReadProperty(IdChuyenKhoaProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuyenKhoaProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idHocHam", ReadProperty(IdHocHamProperty) == null ? (object)DBNull.Value : ReadProperty(IdHocHamProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@IDTrinhDo", ReadProperty(IDTrinhDoProperty) == null ? (object)DBNull.Value : ReadProperty(IDTrinhDoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ChungChi", ReadProperty(ChungChiProperty) == null ? (object)DBNull.Value : ReadProperty(ChungChiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NamBatDau", ReadProperty(NamBatDauProperty) == null ? (object)DBNull.Value : ReadProperty(NamBatDauProperty).Value).DbType = DbType.Int32;
                
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (long) cmd.Parameters["@ID"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DIC_CanBo"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_GiangVien_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@HoTen", ReadProperty(HoTenProperty) == null ? (object)DBNull.Value : ReadProperty(HoTenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GioiTinh", ReadProperty(GioiTinhProperty) == null ? (object)DBNull.Value : ReadProperty(GioiTinhProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgaySinh", ReadProperty(NgaySinhProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@IDTinh", ReadProperty(IDTinhProperty) == null ? (object)DBNull.Value : ReadProperty(IDTinhProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@ChoOHiennay", ReadProperty(ChoOHiennayProperty) == null ? (object)DBNull.Value : ReadProperty(ChoOHiennayProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@QuocGia", ReadProperty(QuocGiaProperty) == null ? (object)DBNull.Value : ReadProperty(QuocGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayVaoDang", ReadProperty(NgayVaoDangProperty).DBValue).DbType = DbType.DateTime;
                  
                    cmd.Parameters.AddWithValue("@IDCoQuan", ReadProperty(IDCoQuanProperty) == null ? (object)DBNull.Value : ReadProperty(IDCoQuanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@IDChucVu", ReadProperty(IDChucVuProperty) == null ? (object)DBNull.Value : ReadProperty(IDChucVuProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@QTDaoTao", ReadProperty(QTDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(QTDaoTaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@QTCongTac", ReadProperty(QTCongTacProperty) == null ? (object)DBNull.Value : ReadProperty(QTCongTacProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@KinhNghiemNN", ReadProperty(KinhNghiemNNProperty) == null ? (object)DBNull.Value : ReadProperty(KinhNghiemNNProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NghienCuuTGia", ReadProperty(NghienCuuTGiaProperty) == null ? (object)DBNull.Value : ReadProperty(NghienCuuTGiaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgoaiNguTinHoc", ReadProperty(NgoaiNguTinHocProperty) == null ? (object)DBNull.Value : ReadProperty(NgoaiNguTinHocProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@KhenThuongKyLuat", ReadProperty(KhenThuongKyLuatProperty) == null ? (object)DBNull.Value : ReadProperty(KhenThuongKyLuatProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@HTapNCuuNNgoai", ReadProperty(HTapNCuuNNgoaiProperty) == null ? (object)DBNull.Value : ReadProperty(HTapNCuuNNgoaiProperty)).DbType = DbType.String;
                //    cmd.Parameters.AddWithValue("@IDBoPhan", ReadProperty(IDBoPhanProperty) == null ? (object)DBNull.Value : ReadProperty(IDBoPhanProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@MaNhanVien", ReadProperty(MaNhanVienProperty) == null ? (object)DBNull.Value : ReadProperty(MaNhanVienProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaNhanVienTheoMayCC", ReadProperty(MaNhanVienTheoMayCCProperty) == null ? (object)DBNull.Value : ReadProperty(MaNhanVienTheoMayCCProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DienThoai", ReadProperty(DienThoaiProperty) == null ? (object)DBNull.Value : ReadProperty(DienThoaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Email", ReadProperty(EmailProperty) == null ? (object)DBNull.Value : ReadProperty(EmailProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LoaiCanBo", ReadProperty(LoaiCanBoProperty) == null ? (object)DBNull.Value : ReadProperty(LoaiCanBoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DanToc", ReadProperty(DanTocProperty) == null ? (object)DBNull.Value : ReadProperty(DanTocProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SoCMT", ReadProperty(SoCMTProperty) == null ? (object)DBNull.Value : ReadProperty(SoCMTProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NgayCap", ReadProperty(NgayCapProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@NoiCap", ReadProperty(NoiCapProperty) == null ? (object)DBNull.Value : ReadProperty(NoiCapProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idChuyenNganh", ReadProperty(IdChuyenNganhProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuyenNganhProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idChuyenKhoa", ReadProperty(IdChuyenKhoaProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuyenKhoaProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idHocHam", ReadProperty(IdHocHamProperty) == null ? (object)DBNull.Value : ReadProperty(IdHocHamProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@IDTrinhDo", ReadProperty(IDTrinhDoProperty) == null ? (object)DBNull.Value : ReadProperty(IDTrinhDoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ChungChi", ReadProperty(ChungChiProperty) == null ? (object)DBNull.Value : ReadProperty(ChungChiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NamBatDau", ReadProperty(NamBatDauProperty) == null ? (object)DBNull.Value : ReadProperty(NamBatDauProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DIC_CanBo"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(IDGiangVien);
        }

        /// <summary>
        /// Deletes the <see cref="DIC_CanBo"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(Int64 id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_GiangVien_delete", ctx.Connection))
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
