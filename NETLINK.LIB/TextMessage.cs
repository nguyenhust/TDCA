using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETLINK.LIB
{
    public static class TextMessages
    {
        public static class SoftwareInformation
        {
            public static readonly string Version = "04/06/2014 - 00:00";
            public static readonly string PC = "Unit test";

        }

        public static class Config
        {
            public static readonly string DateAndTimeFormat = "dd/MM/yyyy HH:mm:ss";
            public static readonly string Separte01 = "|";
            public static readonly string LinkToSaveImgFile = "";
        }
        public static class CacheID
        {
            public static readonly string DIC_BoPhan = "DICBoPhan";
            public static readonly string DIC_ChucVu = "DICChucVu";
            public static readonly string DIC_ChuyenNganh = "DICChuyenNganh";
            public static readonly string DIC_ChuyenKhoa = "DICChuyenKhoa";
            public static readonly string DIC_CanBo = "DICCanBo";
            public static readonly string DIC_GiangVien = "DICGiangVien";
            public static readonly string DIC_BenhVien = "DICBenhVien";
            public static readonly string DIC_Tinh = "DICTinh";
            public static readonly string DIC_CoQuan = "DICCoQuan";
            public static readonly string DIC_DanToc = "DICDanToc";
            public static readonly string DIC_TrinhDo = "DICTrinhDo";
            public static readonly string DIC_HocHam = "DICHocHam";
            public static readonly string DIC_Loai = "DICLoai";
            public static readonly string DIC_NguonKinhPhi = "DICNguonKinhPhi";
            public static readonly string CDT_GoiKT = "CDTGoiKT";
            public static readonly string DT_KhungLopHoc = "DTKhungLopHoc";
            public static readonly string DT_MonHocCQ = "DTMonHocCQ";
            public static readonly string DIC_LoaiVatTu = "DICLoaiVatTu";
            public static readonly string DIC_LoaiTrangThietBi = "DICLoaiTrangThietBi";
            public static readonly string DIC_TinhThanh = "DICTinhThanh";
            public static readonly string DIC_QuanHuyen = "DICQuanHuyen";
            public static readonly string DIC_XaPhuong = "DICXaPhuong";
  

        }
        public static class InfoMessage
        {
            public static readonly string HC_VanPhongPham_SaveSucess = "Bạn đã lưu thành công. Bạn có muốn tiếp tục thêm mới không?";
            public static readonly string SaveSuccess = "Lưu thành công";
            public static readonly string UpLoadSuccessfully = "Tải ảnh thành công";
            public static readonly string InsertSuccess = "Thêm mới thành công";
            public static readonly string MessageBox_Title = "Thông báo từ hệ thống";
            public static readonly string DangTaiDanhSach = "Đang tải danh sách! Xin vui lòng đợi...";
            public static readonly string ExportSuccess = "Xuất báo cáo thành công";
            public static readonly string Editsuccessfully = "Sửa thành công";
            public static readonly string Deletesuccessfully = "Xoá thành công";
            public static readonly string Hidesuccessfully = "Ẩn thành công";
        }
        public static class ErrorMessage
        {
            public static readonly string DinhDangDienThoaiSai = "Định dạng số điện thoại bị sai";
            public static readonly string DinhDangHoTenSai = "Định dạng họ tên sai (ít nhất phải có 2 từ cách nhau bởi dấu cách)";
            public static readonly string DinhDangEmailSai = "Định dạng email bạn nhập vào bị sai (email đúng có dang: abc@123.456";
            public static readonly string UserChuaNhapDayDuThongTin = "Các ô được đánh dấu đỏ không được bỏ trống";
            public static readonly string GridView_BanChuaChonDoiTuongCanThaoTac = "Bạn chưa chọn bản ghi muốn thao tác";
            public static readonly string Save = "Hệ thống gặp lỗi không thể cập nhập, vui lòng thử lại";
            public static readonly string CDT_HoiChuan_BenhVienDuplicate = "Thông tin cho bệnh viện này đã tồn tại, vui lòng chọn trong list để sửa";
            public static readonly string CDT_HoiChuan_SoLuongThamGiaPhaiLonHon0 = "Số lượng cán bộ tham gia phải lớn hơn 0";
            public static readonly string CDT_HoiChuan_SoLuongThamGiaCoGiaTri = "Trường 'Số lượng cán bộ tham gia' phải có giá trị là một số > 0";
            public static readonly string Title = "";
            public static readonly string DontHavePermissionToViewForm = "Bạn không có quyền xem form này. Liên hệ người quản trị để khắc phục!";
            public static readonly string DontHavePermissionToEditForm = "Bạn không có quyền sửa bản ghi. Liên hệ người quản trị để khắc phục!";
            public static readonly string DontHavePermissionToNewForm = "Bạn không có quyền thêm mới bản ghi. Liên hệ người quản trị để khắc phục!";
            public static readonly string DontHavePermissionToDeleteForm = "Bạn không có quyền xóa bản ghi. Liên hệ người quản trị để khắc phục!";
            public static readonly string DontHavePermissionToPrintForm = "Bạn không có quyền in. Liên hệ người quản trị để khắc phục!";
            public static readonly string LoiKhiTaiDanhSach = "Lỗi khi tải danh sách! Liên hệ với Admin để khắc phục";
            public static readonly string LoiChungChung = "Có lỗi hệ thống, form sẽ tự đóng lại";
            public static readonly string PhaiCungNgayHoacMuonHon = "'{0}' phải cùng ngày hoặc là ngày muộn hơn '{1}'";
            public static readonly string FileUploadLoi = "Lưu bị lỗi: Không thể upload file /n Lưu ý tên file không dài quá 50 kí tự và phải viết không dấu";
        }
        public static class FormTitle
        {
            public static readonly string DM_AdminTracker = "Quản lý lưu vết phần mềm";
		    public static readonly string DM_BenhVien = "Quản lý danh sách bệnh viện";
			public static readonly string DM_BoPhan = "Quản lý danh mục bộ phận";
			public static readonly string DM_CanBo = "Quản lý danh mục cán bộ";
            public static readonly string DM_CanBoCDT = "Quản lý danh mục cán bộ thuộc biên chế trung tâm chỉ đạo tuyến";
            public static readonly string DM_CanBoNgoaiCDT = "Quản lý danh mục cán bộ không thuộc biên chế trung tâm chỉ đạo tuyến";
            public static readonly string DM_CanBoGiangVien = "Quản lý danh mục cán bộ giảng viên";
			public static readonly string DM_ChucVu = "Quản lý danh mục chức vụ";
			public static readonly string DM_ChuyenKhoa = "Quản lý danh mục chuyên khoa";
			public static readonly string DM_ChuyenNganh = "Quản lý danh mục chuyên ngành";
			public static readonly string DM_CoQuan = "Quản lý danh mục cơ quan";
			public static readonly string DM_DanToc = "Quản lý danh mục dân tộc";
			public static readonly string DM_DonViTinh = "Quản lý danh mục đơn vị tính";
			public static readonly string DM_GioiTinh = "Quản lý danh mục giới tính";
			public static readonly string DM_HocHam = "Quản lý danh mục học hàm";
			public static readonly string DM_HocVi = "Quản lý danh mục học vị";
			public static readonly string DM_KhoaPhong = "Quản lý danh mục khoa phòng";
			public static readonly string DM_Loai = "Quản lý danh mục loại";
			public static readonly string DM_NguonKinhPhi = "Quản lý danh mục nguồn kinh phí";
			public static readonly string DM_Phong = "Quản lý danh mục phòng";
			public static readonly string DM_QuocGia = "Quản lý danh mục quốc gia";
			public static readonly string DM_TinhThanh = "Quản lý danh mục tỉnh thành";
            public static readonly string DM_LoaiTrangThietBi = "Quản lý danh mục loại trang thiết bị";
            public static readonly string CDT_CDTReport = "In báo cáo";
            public static readonly string CDT_PhieuKhaoSat = "Quản lý phiếu khảo sát";
            public static readonly string CDT_HopDongKyThuat = "Quản lý hợp đồng chuyển giao kỹ thuật";
            public static readonly string CDT_GoiKyThuat = "Quản lý gói kỹ thuật";
            public static readonly string CDT_HoiChuanTrucTuyen = "Quản lý danh sách hội chuẩn trực tuyến";
            public static readonly string CDT_CanBoNhanChuyenGiaoKT = "Quản lý danh sách cán bộ nhận chuyển giao kỹ thuật";
            public static readonly string CDT_GiangVien = "Quản lý danh sách giảng viên chuyển giao kỹ thuật";
            public static readonly string CDT_CanBoDiTinh = "Quản lý danh sách cán bộ đi tỉnh";
            public static readonly string CDT_KinhPhi = "Quản lý danh sách kinh phí đã chi";
            public static readonly string CDT_HopDongCGKT = "Quản lý hợp đồng chuyển giao kỹ thuật";
            public static readonly string HC_XinXe = "Quản lý xin xe đi công tác";
            public static readonly string HC_CongVanDen = "Quản lý Công văn đến";
            public static readonly string HC_CongVanDi = "Quản lý Công văn đi";
            public static readonly string HC_ThietBiVatTu = "Quản lý vật tư thiết bị";
            public static readonly string HC_VanPhongPham = "Quản lý yêu cầu dự trù văn phòng phẩm";
            public static readonly string HC_GiaoViec = "Quản lý giao việc";
            public static readonly string HC_GiangDuong_Phong = "Quản lý cho mượn giảng đường - phòng họp";
            public static readonly string HC_GiangDuong_Phong_PhieuMuon = "Quản lý cho mượn giảng đường - phòng họp";
            public static readonly string HC_PhieuGiaoViec = "Quản lý công việc cá nhân";
            public static readonly string HC_LichLamViec = "Quản lý lịch làm viêc";
            public static readonly string HC_ThietBiTienLamSang = "Quản lý thiết bị tiền lâm sàng";
            public static readonly string HC_ThietBiTienLamSang_NhapXuat = "Quản lý nhập xuất thiết bị tiền lâm sàng";
            public static readonly string HC_DuTruVanPhongPham_NhapXuat = "Quản lý bàn giao văn phòng phẩm";
            public static readonly string HC_ChamCong = "Quản lý chấm công cán bộ TDC";
            public static readonly string DT_HocVienChinhQuy = "Quản lý học viên chính quy";
            public static readonly string DT_HocVienLienTuc = "Quản lý học viên liên tục";
            public static readonly string DT_LopHoc = "Quản lý lớp học";
            public static readonly string DT_MonHoc = "Quản lý môn học";
            public static readonly string DT_NghienCuuKhoaHoc = "Quản lý nghiên cứu khoa học";
            public static readonly string DT_DuAn = "Quản lý dự án";
            public static readonly string Template = "Hệ thống quản lý - Trung tâm chỉ đạo tuyến - bệnh viện Bạch Mai";
            public static readonly string HC_BieuMauISO = "Quản lý hệ thống văn bản - biểu mẫu theo chuẩn ISO";
            public static readonly string TT_DangKiThietKe = "Quản lý phiếu đăng kí thiết kế";
            public static readonly string TT_AnPham = "Quản lý Ấn Phẩm";
            public static readonly string TT_BaiViet = "Quản lý bài viết";
            public static readonly string TT_AnhVideo = "Quản lý ảnh video";

            public static readonly string TT_SuKien = "Quản lý sự kiện";
            public static readonly string DT_HocVienLienTuc_DiemKemCap = "Quản lý học viên liên tục - Nhập điểm kèm cặp";
            public static readonly string DT_HocVienLienTuc_DiemTheoLop = "Quản lý học viên liên tục - Nhập điểm theo lớp";
            public static readonly string DT_HocVienLienTuc_HocPhiDaDong = "Quản lý học viên liên tục - Học viên đã hoàn thành học phí";
            public static readonly string DT_HocVienLienTuc_HocPhiChuaDong = "Quản lý học viên liên tục - Hoc viên chưa hoàn thành học phí";
            public static readonly string DT_HocVienLienTuc_HocPhiHoanTien = "Quản lý học viên liên tục - phần hoàn tiền học phí";
            public static readonly string DT_HocVienLienTuc_HocPhiToanBo = "Quản lý học viên liên tục - Tình trạng học phí toàn bộ học viên";
            public static readonly string DT_HocVienLienTuc_ChoXepLop = "Quản lý học viên liên tục - Học viên chờ xếp lớp";
            public static readonly string DT_HocVienLienTuc_KemCap_DaHoc = "Quản lý học viên liên tục - Học viên kèm cặp đã học";
            public static readonly string DT_HocVienLienTuc_KemCap_DangHoc = "Quản lý học viên liên tục - Học viên kèm cặp đang học";
            public static readonly string DT_HocVienLienTuc_TheoLopDaHoc = "Quản lý học viên liên tục - Học viên theo lớp đã học";
            public static readonly string DT_HocVienLienTuc_TheoLopDangHoc = "Quản lý học viên liên tục - Học viên theo lớp đang học";
            public static readonly string DT_HocVienLienTuc_KemCap_ChuaHoc = "Quản lý học viên liên tục - Học viên kèm cặp chưa học";
            public static readonly string DT_HocVienLienTucCTT = "Danh sách học viên đăng kí từ CTT";
            public static readonly string TT_PhongVan = "Quản lý nội dung buổi phỏng vấn";

            public static readonly string DT_HocVienLienTuc_HenChungChiKemCap = "Quản lý học viên liên tục - Giấy hẹn chứng chỉ kèm cặp";
            public static readonly string DT_HocVienLienTuc_HenChungChiTheoLop = "Quản lý học viên liên tục - Giấy hẹn chứng chỉ theo lớp";
            public static readonly string DT_HocVienLienTuc_ChungChiKemCap = "Quản lý học viên liên tục - In chứng chỉ kèm cặp";
            public static readonly string DT_HocVienLienTuc_ChungChiTheoLop = "Quản lý học viên liên tục - In chứng chỉ theo lớp";

            public static readonly string DT_HocVienLienTucThongKe = "Thống kê dữ liệu học viên";

            public static readonly string DT_HocVienLienTuc_DaInChungChi = "Danh sách học viên liên tục đã cấp chứng chỉ";
            public static readonly string DT_HocVienLienTuc_DuDieuKienCapChungChi = "Danh sách học viên liên tục đủ điều kiện cấp chứng chỉ (chưa cấp)";

            public static readonly string DT_HocVienLienTuc_ChuaInThe = "Danh sách học viên chưa in thẻ";
            public static readonly string DT_HocVienLienTuc_DaInThe = "Danh sách học viên đã in thẻ";

            public static readonly string DT_ChinhQuy_LopHoc = "Quản lý lớp học";
            public static readonly string DT_ChinhQuy_MonHoc = "Quản lý Môn học";
            public static readonly string DT_ChinhQuy_DiemThiTheoLop = "Quản lý điểm thi theo lớp";
            public static readonly string DT_ChinhQuy_DiemThiHocVien = "Quản lý điểm thi theo học viên";
            public static readonly string DT_ChinhQuy_HocPhi = "Quản lý học phí";
            public static readonly string DT_ChinhQuy_HocVienAll = "Danh sách học viên chính quy";
            public static readonly string DT_KhungLopHoc = "Quản lý danh mục lớp học";
            public static readonly string DT_HocVienChinhQuyDiemDauvao = "Thống kê điểm đầu vào";
            public static readonly string DT_HocVienChinhQuyDiemDauvaoCKI = "Thống kê điểm đầu vào cấp CKI";
            public static readonly string DT_HocVienChinhQuyDiemDauvaoCKII = "Thống kê điểm đầu vào cấp CKII";
            public static readonly string DT_HocVienChinhQuyDiemDauvaoBSNT = "Thống kê điểm đầu vào Bác sĩ nội trú";

            public static readonly string TT_TamThu = "Thanh toán học phí";
            public static readonly string TT_HoanTamThu = "Hoàn thanh toán học phí";
        }
        public static class ControlID
        {

            public static readonly string DM_AdminTracker = "DMAT";
		    public static readonly string DM_BenhVien = "DMBV";
			public static readonly string DM_BoPhan = "DMBP";
			public static readonly string DM_CanBo = "DMCB";
            public static readonly string DM_CanBoCDT = "DMCBCDT";
            public static readonly string DM_CanBoNgoaiCDT = "DMCBNCDT";
            public static readonly string DM_CanBoGiangVien = "DMCBGV";
			public static readonly string DM_ChucVu = "DMCV";
			public static readonly string DM_ChuyenKhoa = "DMCK";
			public static readonly string DM_ChuyenNganh = "DMCN";
			public static readonly string DM_CoQuan = "DMCQ";
			public static readonly string DM_DanToc = "DMDT";
			public static readonly string DM_DonViTinh = "DMDVT";
			public static readonly string DM_GioiTinh = "DMGT";
			public static readonly string DM_HocHam = "DMHH";
			public static readonly string DM_HocVi = "DMHV";
			public static readonly string DM_KhoaPhong = "DMKP";
			public static readonly string DM_Loai = "DML";
			public static readonly string DM_NguonKinhPhi = "DMNKP";
			public static readonly string DM_Phong = "DMP";
			public static readonly string DM_QuocGia = "DMQG";
			public static readonly string DM_TinhThanh = "DMTT";
            public static readonly string DM_LoaiTrangThietBi = "DMLTTB";
            public static readonly string Template = "Tem";

            public static readonly string CDT_CDTReport = "CDTReport";
            public static readonly string CDT_CanBoNhanChuyenGiaoKT = "CanBoNhanCGKT";
            public static readonly string CDT_PhieuKhaoSat = "PhieuKhaoSat";
            public static readonly string CDT_HopDongKyThuat = "HopDongKyThuat";
            public static readonly string CDT_HopDongCGKT = "HopDongCGKT";
            public static readonly string CDT_GoiKyThuat = "GoiKyThuat";
            public static readonly string CDT_HoiChuanTrucTuyen = "HoiChuanTrucTuyen";
            public static readonly string CDT_GiangVien = "CDTGiangVien";
            public static readonly string CDT_CanBoDiTinh = "CDTCanBoDiTinh";
            public static readonly string CDT_KinhPhi = "CDTKinhPhi";

            public static readonly string HC_BieuMauISO = "HCBieumauiso";
            public static readonly string HC_XinXe = "HCXinXe";
            public static readonly string HC_CongVanDen = "HCCongVanDen";
            public static readonly string HC_CongVanDi = "HCCongVanDi";
            public static readonly string HC_ThietBiVatTu = "HCThietBiVatTu";
            public static readonly string HC_VanPhongPham = "HCVanPhongPham";
            public static readonly string HC_GiaoViec = "HCGiaoViec";
            public static readonly string HC_GiangDuong_Phong = "HCGiangDuongPhong";
            public static readonly string HC_GiangDuong_Phong_PhieuMuon = "HCGiangDuongPhongPhieuMuon";
            public static readonly string HC_PhieuGiaoViec = "HCPhieuGiaoViec";
            public static readonly string HC_LichLamViec = "HCLichLamViec";
            public static readonly string HC_ThietBiTienLamSang = "HCThietBiTienLamSang";
            public static readonly string HC_ThietBiTienLamSang_NhapXuat = "HCThietBiTienLamSangNhapXuat";
            public static readonly string HC_DuTruVanPhongPham_NhapXuat = "HCDTVPP";
            public static readonly string HC_ChamCong = "HCCC";

            public static readonly string DT_ChinhQuy_LopHoc = "DTCQLH";
            public static readonly string DT_ChinhQuy_MonHoc = "DTCQMH";
            public static readonly string DT_ChinhQuy_DiemThiTheoLop = "DTCQDTTL";
            public static readonly string DT_ChinhQuy_DiemThiHocVien = "DTCQDTHV";
            public static readonly string DT_ChinhQuy_HocPhi = "DTCQHP";
            public static readonly string DT_ChinhQuy_HocVienAll = "DTCQHVAll";

            public static readonly string DT_HocVienChinhQuy = "DTHVCQ";
            public static readonly string DT_HocVienChinhQuyDiemDauvao = "DTHVCQDDV";
            public static readonly string DT_HocVienChinhQuyDiemDauvaoCKI = "DTHVCQDDVCKI";
            public static readonly string DT_HocVienChinhQuyDiemDauvaoCKII = "DTHVCQDDVCKII";
            public static readonly string DT_HocVienChinhQuyDiemDauvaoBSNT = "DTHVCQDDVBSNT";
            public static readonly string DT_HocVienLienTuc = "DTHVLT";
            public static readonly string DT_HocVienLienTucThongKe = "DTHVLTTK";
            public static readonly string DT_HocVienLienTucCTT = "DTHVLTCTT";
            public static readonly string DT_LopHoc = "DTLH";
            public static readonly string DT_MonHoc = "DTMH";
            public static readonly string DT_NghienCuuKhoaHoc = "DTNCKH";
            public static readonly string DT_DuAn = "DTDA";
            public static readonly string DT_HocVienLientTuc_HocPhi_HoanTien = "DTHVLTHPHT";
            public static readonly string DT_HocVienLienTuc_HocPhiDaDong = "DTHVLTHPDD";
            public static readonly string DT_HocVienLienTuc_HocPhiChuaDong = "DTHVLTHPCD";
            public static readonly string DT_HocVienLienTuc_HocPhiHoanTien = "DTHVLTHPHT";
            public static readonly string DT_HocVienLienTuc_HocPhiToanBo = "DTHVLTHPDDTB";
            public static readonly string DT_HocVienLienTuc_DiemKemCap = "DTHVLTDKC";
            public static readonly string DT_HocVienLienTuc_DiemTheoLop = "DTHVLTDTL";
            public static readonly string DT_HocVienLienTuc_ChoXepLop = "DTHVLTCXL";
            public static readonly string DT_HocVienLienTuc_KemCap_DaHoc = "DTHVLTKCDAH";
            public static readonly string DT_HocVienLienTuc_KemCap_DangHoc = "DTHVLTKCDANGH";
            public static readonly string DT_HocVienLienTuc_KemCap_ChuaHoc = "DTHVLTKCCHUAH";
            public static readonly string DT_HocVienLienTuc_TheoLop_DaHoc = "DTHVLTTLDAH";
            public static readonly string DT_HocVienLienTuc_TheoLop_DangHoc = "DTHVLTTLDANGH";
            public static readonly string DT_HocVienLienTuc_HenChungChiTheoLop = "DTHVLTHCCTL";
            public static readonly string DT_HocVienLienTuc_HenChungChiKemCap = "DTHVLTHCCKC";
            public static readonly string DT_HocVienLienTuc_ChungChiTheoLop = "DTHVLTCCTL";
            public static readonly string DT_HocVienLienTuc_ChungChiKemCap = "DTHVLTCCKC";

            public static readonly string DT_HocVienLienTuc_DaInChungChi = "DTHVLTDINCC";
            public static readonly string DT_HocVienLienTuc_DuDieuKienCapChungChi = "DTHVLTDDKCCC";

            public static readonly string DT_HocVienLienTuc_ChuaInThe = "DTHVLTCIT";
            public static readonly string DT_HocVienLienTuc_DaInThe = "DTHVLTDIT";

            public static readonly string DT_KhungLopHoc = "DTKLH";


            public static readonly string TT_SuKien = "TTDKSK";
            public static readonly string TT_DangKiThietKe = "TTDKTK";
            public static readonly string TT_PhongVan = "TTPV";
            public static readonly string TT_AnPham = "TTAP";
            public static readonly string TT_BaiViet = "TTBV";
            public static readonly string TT_AnhVideo = "TTAVO";

            public static readonly string TT_TamThu = "TTBLTT";
            public static readonly string TT_HoanTamThu = "TTHBLTT";
           

        }
        public static class RolePermission
        {
            public static readonly string SystemAdmin = "SYSMAN";

            #region Danh Muc

            public static readonly string DM_CanBoNgoaiCDT_Edit = "CanBoNgoaiCDT:U";
            public static readonly string DM_CanBoNgoaiCDT_Del = "CanBoNgoaiCDT:D";
            public static readonly string DM_CanBoNgoaiCDT_Insert = "CanBoNgoaiCDT:I";
            public static readonly string DM_CanBoNgoaiCDT_Print = "CanBoNgoaiCDT:P";
            public static readonly string DM_CanBoNgoaiCDT_View = "CanBoNgoaiCDT:S";

            public static readonly string DM_CanBoCDT_Edit = "CanBoCDT:U";
            public static readonly string DM_CanBoCDT_Del = "CanBoCDT:D";
            public static readonly string DM_CanBoCDT_Insert = "CanBoCDT:I";
            public static readonly string DM_CanBoCDT_Print = "CanBoCDT:P";
            public static readonly string DM_CanBoCDT_View = "CanBoCDT:S";

            public static readonly string DM_ChucVu_Edit = "ChucVu:U";
            public static readonly string DM_ChucVu_Del = "ChucVu:D";
            public static readonly string DM_ChucVu_Insert = "ChucVu:I";
            public static readonly string DM_ChucVu_Print = "ChucVu:P";
            public static readonly string DM_ChucVu_View = "ChucVu:S";

            public static readonly string DM_BenhVien_Edit = "BenhVien:U";
            public static readonly string DM_BenhVien_Del ="BenhVien:D";
            public static readonly string DM_BenhVien_Insert = "BenhVien:I";
            public static readonly string DM_BenhVien_Print = "BenhVien:P";
            public static readonly string DM_BenhVien_View = "BenhVien:S";

            public static readonly string DM_ChuyenKhoa_Edit = "ChuyenKhoa:U";
            public static readonly string DM_ChuyenKhoa_Del = "ChuyenKhoa:D";
            public static readonly string DM_ChuyenKhoa_Insert = "ChuyenKhoa:I";
            public static readonly string DM_ChuyenKhoa_Print = "ChuyenKhoa:P";
            public static readonly string DM_ChuyenKhoa_View = "ChuyenKhoa:S";

            public static readonly string DM_ChuyenNganh_Edit = "ChuyenNganh:U";
            public static readonly string DM_ChuyenNganh_Del = "ChuyenNganh:D";
            public static readonly string DM_ChuyenNganh_Insert = "ChuyenNganh:I";
            public static readonly string DM_ChuyenNganh_Print = "ChuyenNganh:P";
            public static readonly string DM_ChuyenNganh_View = "ChuyenNganh:S";

            public static readonly string DM_CoQuan_Edit = "CoQuan:U";
            public static readonly string DM_CoQuan_Del = "CoQuan:D";
            public static readonly string DM_CoQuan_Insert = "CoQuan:I";
            public static readonly string DM_CoQuan_Print = "CoQuan:P";
            public static readonly string DM_CoQuan_View = "CoQuan:S";

            public static readonly string DM_HocHam_Edit = "HocHam:U";
            public static readonly string DM_HocHam_Del = "HocHam:D";
            public static readonly string DM_HocHam_Insert = "HocHam:I";
            public static readonly string DM_HocHam_Print = "HocHam:P";
            public static readonly string DM_HocHam_View = "HocHam:S";

            public static readonly string DM_HocVi_Edit = "HocVi:U";
            public static readonly string DM_HocVi_Del = "HocVi:D";
            public static readonly string DM_HocVi_Insert = "HocVi:I";
            public static readonly string DM_HocVi_Print = "HocVi:P";
            public static readonly string DM_HocVi_View = "HocVi:S";

            public static readonly string DM_Loai_Edit = "Loai:U";
            public static readonly string DM_Loai_Del = "Loai:D";
            public static readonly string DM_Loai_Insert = "Loai:I";
            public static readonly string DM_Loai_Print = "Loai:P";
            public static readonly string DM_Loai_View = "Loai:S";

            public static readonly string DM_LopHoc_Edit = "LopHocK:U";
            public static readonly string DM_LopHoc_Del = "LopHocK:D";
            public static readonly string DM_LopHoc_Insert = "LopHocK:I";
            public static readonly string DM_LopHoc_Print = "LopHocK:S";
            public static readonly string DM_LopHoc_View = "LopHocK:S";

            public static readonly string DM_MonHoc_Edit = "MonHoc:U";
            public static readonly string DM_MonHoc_Del = "MonHoc:D";
            public static readonly string DM_MonHoc_Insert = "MonHoc:I";
            public static readonly string DM_MonHoc_Print = "MonHoc:P";
            public static readonly string DM_MonHoc_View = "MonHoc:S";

            public static readonly string DM_NguonKinhPhi_Edit = "NguonKinhPhi:U";
            public static readonly string DM_NguonKinhPhi_Del = "NguonKinhPhi:D";
            public static readonly string DM_NguonKinhPhi_Insert = "NguonKinhPhi:I";
            public static readonly string DM_NguonKinhPhi_Print = "NguonKinhPhi:P";
            public static readonly string DM_NguonKinhPhi_View = "NguonKinhPhi:S";

            public static readonly string DM_Phong_Edit = "Phong:U";
            public static readonly string DM_Phong_Del = "Phong:D";
            public static readonly string DM_Phong_Insert = "Phong:I";
            public static readonly string DM_Phong_Print = "Phong:P";
            public static readonly string DM_Phong_View = "Phong:S";

            public static readonly string DM_KhoaPhong_Edit = "";
            public static readonly string DM_KhoaPhong_Del = "";
            public static readonly string DM_KhoaPhong_Insert = "";
            public static readonly string DM_KhoaPhong_Print = "";
            public static readonly string DM_KhoaPhong_View = "";

            public static readonly string DM_VanPhongPham_Edit = "DMVanPhongPham:U";
            public static readonly string DM_VanPhongPham_Del = "DMVanPhongPham:D";
            public static readonly string DM_VanPhongPham_Insert = "DMVanPhongPham:I";
            public static readonly string DM_VanPhongPham_Print = "DMVanPhongPham:S";
            public static readonly string DM_VanPhongPham_View = "DMVanPhongPham:S";

            public static readonly string DM_ThietBiTienLamSang_Edit = "DMThietBiTienLamSang:U";
            public static readonly string DM_ThietBiTienLamSang_Del = "DMThietBiTienLamSang:D";
            public static readonly string DM_ThietBiTienLamSang_Insert = "DMThietBiTienLamSang:I";
            public static readonly string DM_ThietBiTienLamSang_Print = "DMThietBiTienLamSang:S";
            public static readonly string DM_ThietBiTienLamSang_View = "DMThietBiTienLamSang:S";

            public static readonly string DM_PhongHopTDC_Edit = "DMPhongHop:U";
            public static readonly string DM_PhongHopTDC_Del = "DMPhongHop:D";
            public static readonly string DM_PhongHopTDC_Insert = "DMPhongHop:I";
            public static readonly string DM_PhongHopTDC_Print = "DMPhongHop:S";
            public static readonly string DM_PhongHopTDC_View = "DMPhongHop:S";

            public static readonly string DM_LoaiVatTu_Edit = "LoaiVatTu:U";
            public static readonly string DM_LoaiVatTu_Del = "LoaiVatTu:D";
            public static readonly string DM_LoaiVatTu_Insert = "LoaiVatTu:I";
            public static readonly string DM_LoaiVatTu_Print = "LoaiVatTu:P";
            public static readonly string DM_LoaiVatTu = "LoaiVatTu:S";

            public static readonly string DM_LyDoHuy_Edit = "LyDoHuy:U";
            public static readonly string DM_LyDoHuy_Del = "LyDoHuy:D";
            public static readonly string DM_LyDoHuy_Insert = "LyDoHuy:I";
            public static readonly string DM_LyDoHuy_Print = "LyDoHuy:P";
            public static readonly string DM_LyDoHuy_View = "LyDoHuy:S";

            public static readonly string DM_LoaiTrangThietBi_Edit = "LoaiLoaiTrangThietBi:U";
            public static readonly string DM_LoaiTrangThietBi_Del = "LoaiTrangThietBi:D";
            public static readonly string DM_LoaiTrangThietBi_Insert = "LoaiTrangThietBi:I";
            public static readonly string DM_LoaiTrangThietBi_Print = "LoaiTrangThietBi:P";
            public static readonly string DM_LoaiTrangThietBi_View = "LoaiTrangThietBi:S";

            #endregion

            #region Chi dao tuyen

            public static readonly string CDT_GoiKyThuat_Insert = "GoiKyThuat:I";
            public static readonly string CDT_GoiKyThuat_Edit = "GoiKyThuat:U";
            public static readonly string CDT_GoiKyThuat_Delete = "GoiKyThuat:D";
            public static readonly string CDT_GoiKyThuat_View = "GoiKyThuat:S";
            public static readonly string CDT_GoiKyThuat_Print = "GoiKyThuat:S";

            public static readonly string CDT_PhieuKhaoSat_View = "PhieuKhaoSat:S";
            public static readonly string CDT_PhieuKhaoSat_Edit = "PhieuKhaoSat:U";
            public static readonly string CDT_PhieuKhaoSat_Delete = "PhieuKhaoSat:D";
            public static readonly string CDT_PhieuKhaoSat_Print = "PhieuKhaoSat:S";
            public static readonly string CDT_PhieuKhaoSat_Insert = "PhieuKhaoSat:I";

            public static readonly string CDT_HopDongKyThuat_Insert = "HopDongKyThuat:I";
            public static readonly string CDT_HopDongKyThuat_Edit = "HopDongKyThuat:U";
            public static readonly string CDT_HopDongKyThuat_Delete = "HopDongKyThuat:D";
            public static readonly string CDT_HopDongKyThuat_Print = "HopDongKyThuat:S";
            public static readonly string CDT_HopDongKyThuat_View = "HopDongKyThuat:S";

            public static readonly string CDT_HoiChuan_View = "HoiChuan:S";
            public static readonly string CDT_HoiChuan_Insert = "HoiChuan:I";
            public static readonly string CDT_HoiChuan_Delete = "HoiChuan:D";
            public static readonly string CDT_HoiChuan_Print = "HoiChuan:S";
            public static readonly string CDT_HoiChuan_Edit = "HoiChuan:U";

            public static readonly string CDT_CanBoNhanCGKT_Edit = "CanBoNhanCGKT:U";
            public static readonly string CDT_CanBoNhanCGKT_Insert = "CanBoNhanCGKT:I";
            public static readonly string CDT_CanBoNhanCGKT_Delete = "CanBoNhanCGKT:D";
            public static readonly string CDT_CanBoNhanCGKT_View = "CanBoNhanCGKT:S";
            public static readonly string CDT_CanBoNhanCGKT_Print = "CanBoNhanCGKT:S";

            public static readonly string CDT_CanBoDiTinh_Edit = "CanBoDiTinh:U";
            public static readonly string CDT_CanBoDiTinh_Insert = "CanBoDiTinh:I";
            public static readonly string CDT_CanBoDiTinh_Delete = "CanBoDiTinh:D";
            public static readonly string CDT_CanBoDiTinh_View = "CanBoDiTinh:S";
            public static readonly string CDT_CanBoDiTinh_Print = "CanBoDiTinh:S";

            #endregion

            #region Dao Tao

            public static readonly string DT_LT_HocVien_Edit = "LTHocVien:U";
            public static readonly string DT_LT_HocVien_Insert = "LTHocVien:I";
            public static readonly string DT_LT_HocVien_Delete = "LTHocVien:D";
            public static readonly string DT_LT_HocVien_View = "LTHocVien:S";
            public static readonly string DT_LT_HocVien_Print = "LTHocVien:S";

            public static readonly string DT_LT_HocVien_DaHoc_View = "LTHocVienDaHoc:S";
            public static readonly string DT_LT_HocVien_DaHoc_Edit = "LTHocVienDaHoc:U";
            public static readonly string DT_LT_HocVien_DaHoc_Delete = "LTHocVienDaHoc:D";
            public static readonly string DT_LT_HocVien_DaHoc_Print = "LTHocVienDaHoc:S";

            public static readonly string DT_LT_LopHoc_Edit = "LTLopHoc:U";
            public static readonly string DT_LT_LopHoc_Delete = "LTLopHoc:D";
            public static readonly string DT_LT_LopHoc_Insert = "LTLopHoc:I";
            public static readonly string DT_LT_LopHoc_View = "LTLopHoc:S";
            public static readonly string DT_LT_LopHoc_Print = "LTLopHoc:S";

            public static readonly string DT_LT_ChuyenGiaoHocVien_Edit = "LTChuyenGiaoHocVien:U";
            public static readonly string DT_LT_ChuyenGiaoHocVien_Insert = "LTChuyenGiaoHocVien:I";
            public static readonly string DT_LT_ChuyenGiaoHocVien_View = "LTChuyenGiaoHocVien:S";
            public static readonly string DT_LT_ChuyenGiaoHocVien_Print = "LTChuyenGiaoHocVien:S";
            public static readonly string DT_LT_ChuyenGiaoHocVien_Delete = "LTChuyenGiaoHocVien:D";

            public static readonly string DT_LT_QuanLyDiem_Edit = "LTDiem:U";
            public static readonly string DT_LT_QuanLyDiem_Insert = "LTDiem:I";
            public static readonly string DT_LT_QuanLyDiem_View = "LTDiem:S";
            public static readonly string DT_LT_QuanLyDiem_Print = "LTDiem:S";
            public static readonly string DT_LT_QuanLyDiem_Delete = "LTDiem:D";

            public static readonly string DT_LT_TraCuuHocPhi_Edit = "LTHocPhi:U";
            public static readonly string DT_LT_TraCuuHocPhi_View = "LTHocPhi:S";
            public static readonly string DT_LT_TraCuuHocPhi_Insert = "LTHocPhi:I";
            public static readonly string DT_LT_TraCuuHocPhi_Delete = "LTHocPhi:D";
            public static readonly string DT_LT_TraCuuHocPhi_Print = "LTHocPhi:S";

            public static readonly string DT_NghienCuuKhoaHoc_View = "NghienCuuKhoaHoc:S";
            public static readonly string DT_NghienCuuKhoaHoc_Edit = "NghienCuuKhoaHoc:U";
            public static readonly string DT_NghienCuuKhoaHoc_Del = "NghienCuuKhoaHoc:D";
            public static readonly string DT_NghienCuuKhoaHoc_Insert = "NghienCuuKhoaHoc:I";
            public static readonly string DT_NghienCuuKhoaHoc_Print = "NghienCuuKhoaHoc:S";

            public static readonly string DT_LT_InPhieuThuHocPhi_View = "InPhieuThuHocPhi:S";
            public static readonly string DT_LT_InPhieuThuHocPhi_Edit = "InPhieuThuHocPhi:U";
            public static readonly string DT_LT_InPhieuThuHocPhi_Del = "InPhieuThuHocPhi:D";
            public static readonly string DT_LT_InPhieuThuHocPhi_Insert = "InPhieuThuHocPhi:I";
            public static readonly string DT_LT_InPhieuThuHocPhi_Print = "InPhieuThuHocPhi:S";

            public static readonly string DT_LT_InChungChi_View = "InChungChi:S";
            public static readonly string DT_LT_InChungChi_Edit = "InChungChi:U";
            public static readonly string DT_LT_InChungChi_Del = "InChungChi:D";
            public static readonly string DT_LT_InChungChi_Insert = "InChungChi:I";
            public static readonly string DT_LT_InChungChi_Print = "InChungChi:S";

            public static readonly string DT_LT_InThe_View = "InThe:S";
            public static readonly string DT_LT_InThe_Edit = "InThe:U";
            public static readonly string DT_LT_InThe_Del = "InThe:D";
            public static readonly string DT_LT_InThe_Insert = "InThe:I";
            public static readonly string DT_LT_InThe_Print = "InThe:S";

            public static readonly string DT_CQ_HocVien_View = "CQHocVien:S";
            public static readonly string DT_CQ_HocVien_Edit = "CQHocVien:U";
            public static readonly string DT_CQ_HocVien_Del = "CQHocVien:D";
            public static readonly string DT_CQ_HocVien_Insert = "CQHocVien:I";
            public static readonly string DT_CQ_HocVien_Print = "CQHocVien:S";

            public static readonly string DT_CQ_HocPhi_View = "CQHocPhi:S";
            public static readonly string DT_CQ_HocPhi_Edit = "CQHocPhi:U";
            public static readonly string DT_CQ_HocPhi_Del = "CQHocPhi:D";
            public static readonly string DT_CQ_HocPhi_Insert = "CQHocPhi:I";
            public static readonly string DT_CQ_HocPhi_Print = "CQHocPhi:S";

            public static readonly string DT_CQ_MonHoc_View = "CQMonHoc:S";
            public static readonly string DT_CQ_MonHoc_Edit = "CQMonHoc:U";
            public static readonly string DT_CQ_MonHoc_Del = "CQMonHoc:D";
            public static readonly string DT_CQ_MonHoc_Insert = "CQMonHoc:I";
            public static readonly string DT_CQ_MonHoc_Print = "CQMonHoc:S";

            public static readonly string DT_CQ_KhenThuongKiLuat_Insert = "CQKhenThuongKiLuat:I";
            public static readonly string DT_CQ_KhenThuongKiLuat_Print = "CQKhenThuongKiLuat:S";
            public static readonly string DT_CQ_KhenThuongKiLuat_View = "CQKhenThuongKiLuat:S";
            public static readonly string DT_CQ_KhenThuongKiLuat_Edit = "CQKhenThuongKiLuat:U";
            public static readonly string DT_CQ_KhenThuongKiLuat_Del = "CQKhenThuongKiLuat:D";

            public static readonly string DT_CQ_QuanLyDiem_Insert = "CQDiem:I";
            public static readonly string DT_CQ_QuanLyDiem_Del = "CQDiem:D";
            public static readonly string DT_CQ_QuanLyDiem_Edit = "CQDiem:U";
            public static readonly string DT_CQ_QuanLyDiem_View = "CQDiem:S";
            public static readonly string DT_CQ_QuanLyDiem_Print = "CQDiem:S";

            public static readonly string DT_CQ_LichHoc_Insert = "CQLichHoc:I";
            public static readonly string DT_CQ_LichHoc_Edit = "CQLichHoc:U";
            public static readonly string DT_CQ_LichHoc_Del = "CQLichHoc:D";
            public static readonly string DT_CQ_LichHoc_View = "CQLichHoc:S";
            public static readonly string DT_CQ_LichHoc_Print = "CQLichHoc:S";

            public static readonly string DT_CQ_DSLop_Insert = "CQDSLop:I";
            public static readonly string DT_CQ_DSLop_Edit = "CQDSLop:U";
            public static readonly string DT_CQ_DSLop_Del = "CQDSLop:D";
            public static readonly string DT_CQ_DSLop_View = "CQDSLop:S";
            public static readonly string DT_CQ_DSLop_Print = "CQDSLop:S";

            public static readonly string DT_MonHocChinhQuy_Insert = "CQMonHoc:I";
            public static readonly string DT_MonHocChinhQuy_Print = "CQMonHoc:S";
            public static readonly string DT_MonHocChinhQuy_View = "CQMonHoc:S";
            public static readonly string DT_MonHocChinhQuy_Edit = "CQMonHoc:U";
            public static readonly string DT_MonHocChinhQuy_Del = "CQMonHoc:D";

            public static readonly string DT_QuanLyDuAn_Insert = "QuanLyDuAn:I";
            public static readonly string DT_QuanLyDuAn_View = "QuanLyDuAn:S";
            public static readonly string DT_QuanLyDuAn_Print = "QuanLyDuAn:S";
            public static readonly string DT_QuanLyDuAn_Edit = "QuanLyDuAn:U";
            public static readonly string DT_QuanLyDuAn_Del = "QuanLyDuAn:D";

            #endregion

            #region hanh chinh

            public static readonly string HC_PhieuMuonThietBi_View = "HCMuonThietBi:S";
            public static readonly string HC_PhieuMuonThietBi_Edit = "HCMuonThietBi:U";
            public static readonly string HC_PhieuMuonThietBi_Del = "HCMuonThietBi:D";
            public static readonly string HC_PhieuMuonThietBi_Insert = "HCMuonThietBi:I";
            public static readonly string HC_PhieuMuonThietBi_Print = "HCMuonThietBi:S";

            public static readonly string HC_BieuMauISO_View = "HCBieuMauISO:S";
            public static readonly string HC_BieuMauISO_Edit = "HCBieuMauISO:U";
            public static readonly string HC_BieuMauISO_Del = "HCBieuMauISO:D";
            public static readonly string HC_BieuMauISO_Insert = "HCBieuMauISO:I";
            public static readonly string HC_BieuMauISO_Print = "HCBieuMauISO:S";

            public static readonly string HC_LichLamViec_View = "HCLichLamViec:S";
            public static readonly string HC_LichLamViec_Edit = "HCLichLamViec:U";
            public static readonly string HC_LichLamViec_Del = "HCLichLamViec:D";
            public static readonly string HC_LichLamViec_Insert = "HCLichLamViec:I";
            public static readonly string HC_LichLamViec_Print = "HCLichLamViec:S";

            public static readonly string HC_PhieuGiaoViec_View = "HCPhieuGiaoViec:S";
            public static readonly string HC_PhieuGiaoViec_Edit = "HCPhieuGiaoViec:U";
            public static readonly string HC_PhieuGiaoViec_Del = "HCPhieuGiaoViec:D";
            public static readonly string HC_PhieuGiaoViec_Insert = "HCPhieuGiaoViec:I";
            public static readonly string HC_PhieuGiaoViec_Print = "HCPhieuGiaoViec:S";

            public static readonly string HC_SachTaiLieu_View = "HCTaiLieu:S";
            public static readonly string HC_SachTaiLieu_Edit = "HCTaiLieu:U";
            public static readonly string HC_SachTaiLieu_Del = "HCTaiLieu:D";
            public static readonly string HC_SachTaiLieu_Insert = "HCTaiLieu:I";
            public static readonly string HC_SachTaiLieu_Print = "HCTaiLieu:S";

            public static readonly string HC_ThietBiTienLamSang_View = "HCLamSang:S";
            public static readonly string HC_ThietBiTienLamSang_Edit = "HCLamSang:U";
            public static readonly string HC_ThietBiTienLamSang_Del = "HCLamSang:D";
            public static readonly string HC_ThietBiTienLamSang_Insert = "HCLamSang:I";
            public static readonly string HC_ThietBiTienLamSang_Print = "HCLamSang:S";

            public static readonly string HC_ThietBiTienLamSang_NhapXuat_View = "HCLamSangNhapXuat:S";
            public static readonly string HC_ThietBiTienLamSang_NhapXuat_Edit = "HCLamSangNhapXuat:U";
            public static readonly string HC_ThietBiTienLamSang_NhapXuat_Del = "HCLamSangNhapXuat:D";
            public static readonly string HC_ThietBiTienLamSang_NhapXuat_Insert = "HCLamSangNhapXuat:I";
            public static readonly string HC_ThietBiTienLamSang_NhapXuat_Print = "HCLamSangNhapXuat:S";

            public static readonly string HC_ChamCong_View = "HCChamCong:S";
            public static readonly string HC_ChamCong_Edit = "HCChamCong:U";
            public static readonly string HC_ChamCong_Del = "HCChamCong:D";
            public static readonly string HC_ChamCong_Insert = "HCChamCong:I";
            public static readonly string HC_ChamCong_Print = "HCChamCong:S";

            public static readonly string HC_GiaoViec_View = "HCGiaoViec:S";
            public static readonly string HC_GiaoViec_Edit = "HCGiaoViec:U";
            public static readonly string HC_GiaoViec_Del = "HCGiaoViec:D";
            public static readonly string HC_GiaoViec_Insert = "HCGiaoViec:I";
            public static readonly string HC_GiaoViec_Print = "HCGiaoViec:S";

            public static readonly string HC_ThietBiVatTu_View = "ThietBiVatTu:S";
            public static readonly string HC_ThietBiVatTu_Edit = "ThietBiVatTu:U";
            public static readonly string HC_ThietBiVatTu_Del = "ThietBiVatTu:D";
            public static readonly string HC_ThietBiVatTu_Insert = "ThietBiVatTu:I";
            public static readonly string HC_ThietBiVatTu_Print = "ThietBiVatTu:S";

            public static readonly string HC_CongVanDen_View = "CongVanDen:S";
            public static readonly string HC_CongVanDen_Del = "CongVanDen:D";
            public static readonly string HC_CongVanDen_Edit = "CongVanDen:U";
            public static readonly string HC_CongVanDen_Insert = "CongVanDen:I";
            public static readonly string HC_CongVanDen_Print = "CongVanDen:S";

            public static readonly string HC_CongVanDi_View = "CongVanDi:S";
            public static readonly string HC_CongVanDi_Del = "CongVanDi:D";
            public static readonly string HC_CongVanDi_Edit = "CongVanDi:U";
            public static readonly string HC_CongVanDi_Print = "CongVanDi:S";
            public static readonly string HC_CongVanDi_Insert = "CongVanDi:I";

            public static readonly string HC_XinXe_Insert = "XinXe:I";
            public static readonly string HC_XinXe_Edit = "XinXe:U";
            public static readonly string HC_XinXe_Delete = "XinXe:D";
            public static readonly string HC_XinXe_Print = "XinXe:S";
            public static readonly string HC_XinXe_View = "XinXe:S";

            public static readonly string HC_GiangDuong_Phong_View = "GiangDuongPhongHop:S";
            public static readonly string HC_GiangDuong_Phong_Edit = "GiangDuongPhongHop:U";
            public static readonly string HC_GiangDuong_Phong_Insert = "GiangDuongPhongHop:I";
            public static readonly string HC_GiangDuong_Phong_Delete = "GiangDuongPhongHop:D";
            public static readonly string HC_GiangDuong_Phong_Print = "GiangDuongPhongHop:S";

            public static readonly string HC_VanPhongPham_View = "VanPhongPham:S";
            public static readonly string HC_VanPhongPham_Edit = "VanPhongPham:U";
            public static readonly string HC_VanPhongPham_Insert = "VanPhongPham:I";
            public static readonly string HC_VanPhongPham_Delete = "VanPhongPham:D";
            public static readonly string HC_VanPhongPham_Print = "VanPhongPham:S";

            public static readonly string HC_VanPhongPham_NhapXuat_View = "VanPhongPhamNhapXuat:S";
            public static readonly string HC_VanPhongPham_NhapXuat_Edit = "VanPhongPhamNhapXuat:U";
            public static readonly string HC_VanPhongPham_NhapXuat_Insert = "VanPhongPhamNhapXuat:I";
            public static readonly string HC_VanPhongPham_NhapXuat_Delete = "VanPhongPhamNhapXuat:D";
            public static readonly string HC_VanPhongPham_NhapXuat_Print = "VanPhongPhamNhapXuat:S";

            #endregion

            #region System

            public static readonly string Sys_NguoiDung_View = "NguoiDung:S";
            public static readonly string Sys_NguoiDung_Edit = "NguoiDung:U";
            public static readonly string Sys_NguoiDung_Insert = "NguoiDung:I";
            public static readonly string Sys_NguoiDung_Delete = "NguoiDung:D";
            public static readonly string Sys_NguoiDung_Print = "NguoiDung:S";

            public static readonly string Sys_NhomNguoiDung_View = "NhomNguoiDung:S";
            public static readonly string Sys_NhomNguoiDung_Edit = "NhomNguoiDung:U";
            public static readonly string Sys_NhomNguoiDung_Insert = "NhomNguoiDung:I";
            public static readonly string Sys_NhomNguoiDung_Delete = "NhomNguoiDung:D";
            public static readonly string Sys_NhomNguoiDung_Print = "NhomNguoiDung:S";

            public static readonly string Sys_ErrorLog_View = "ErrorLog:S";
            public static readonly string Sys_ErrorLog_Edit = "ErrorLog:U";
            public static readonly string Sys_ErrorLog_Insert = "ErrorLog:I";
            public static readonly string Sys_ErrorLog_Delete = "ErrorLog:D";
            public static readonly string Sys_ErrorLog_Print = "ErrorLog:S";

            #endregion

            #region Truyen Thong

            public static readonly string TT_AnhVideo_Edit = "AnhVideo:U";
            public static readonly string TT_AnhVideo_View = "AnhVideo:S";
            public static readonly string TT_AnhVideo_Del = "AnhVideo:D";
            public static readonly string TT_AnhVideo_Print = "AnhVideo:S";
            public static readonly string TT_AnhVideo_Insert = "AnhVideo:I";

            public static readonly string TT_AnPham_Edit = "AnPham:U";
            public static readonly string TT_AnPham_View = "AnPham:S";
            public static readonly string TT_AnPham_Del = "AnPham:D";
            public static readonly string TT_AnPham_Print = "AnPham:S";
            public static readonly string TT_AnPham_Insert = "AnPham:I";

            public static readonly string TT_BaiViet_Edit = "BaiViet:U";
            public static readonly string TT_BaiViet_View = "BaiViet:S";
            public static readonly string TT_BaiViet_Del = "BaiViet:D";
            public static readonly string TT_BaiViet_Print = "BaiViet:S";
            public static readonly string TT_BaiViet_Insert = "BaiViet:I";

            public static readonly string TT_PhieuDangKyThietKe_Edit = "PhieuDangKyThietKe:U";
            public static readonly string TT_PhieuDangKyThietKe_View = "PhieuDangKyThietKe:S";
            public static readonly string TT_PhieuDangKyThietKe_Del = "PhieuDangKyThietKe:D";
            public static readonly string TT_PhieuDangKyThietKe_Print = "PhieuDangKyThietKe:S";
            public static readonly string TT_PhieuDangKyThietKe_Insert = "PhieuDangKyThietKe:I";

            public static readonly string TT_DuyetPhieuDangKyThietKe_Edit = "DuyetPhieuDangKyThietKe:U";
            public static readonly string TT_DuyetPhieuDangKyThietKe_View = "DuyetPhieuDangKyThietKe:S";
            public static readonly string TT_DuyetPhieuDangKyThietKe_Del = "DuyetPhieuDangKyThietKe:D";
            public static readonly string TT_DuyetPhieuDangKyThietKe_Print = "DuyetPhieuDangKyThietKe:S";
            public static readonly string TT_DuyetPhieuDangKyThietKe_Insert = "DuyetPhieuDangKyThietKe:I";

            public static readonly string TT_PhongVan_Edit = "PhongVan:U";
            public static readonly string TT_PhongVan_View = "PhongVan:S";
            public static readonly string TT_PhongVan_Del = "PhongVan:D";
            public static readonly string TT_PhongVan_Print = "PhongVan:S";
            public static readonly string TT_PhongVan_Insert = "PhongVan:I";

            public static readonly string TT_SuKien_Edit = "SuKien:U";
            public static readonly string TT_SuKien_View = "SuKien:S";
            public static readonly string TT_SuKien_Del = "SuKien:D";
            public static readonly string TT_SuKien_Print = "SuKien:S";
            public static readonly string TT_SuKien_Insert = "SuKien:I";

            #endregion

            #region Thanh toan

            public static readonly string TT_TamThu_Edit = "TCKTThanhToan:U";
            public static readonly string TT_TamThu_View = "TCKTThanhToan:S";
            public static readonly string TT_TamThu_Del = "TCKTThanhToan:D";
            public static readonly string TT_TamThu_Print = "TCKTThanhToan:S";
            public static readonly string TT_TamThu_Insert = "TCKTThanhToan:I";

            public static readonly string TT_HoanTamThu_Edit = "TCKTHoanBienLaiTT:U";
            public static readonly string TT_HoanTamThu_View = "TCKTHoanBienLaiTT:S";
            public static readonly string TT_HoanTamThu_Del = "TCKTHoanBienLaiTT:D";
            public static readonly string TT_HoanTamThu_Print = "TCKTHoanBienLaiTT:S";
            public static readonly string TT_HoanTamThu_Insert = "TCKTHoanBienLaiTT:I";
            #endregion
        }
        public static class Itemvalue
        {
            public static readonly string HinhThucHoc_KemCap = "Kèm cặp";
            public static readonly string HinhThucHoc_TheoLop = "Theo lớp";
            public static readonly string HinhThucHoc_ThucHanh = "Thực hành";
            public static readonly string TrangThaiHoc_DangHoc = "Đang học";
            public static readonly string TrangThaiHoc_ChuaHoc = "Chưa bắt đầu học";
            public static readonly string TrangThaiHoc_KT_ChuaCC = "Kết thúc - chưa cấp chứng chỉ";
            public static readonly string TrangThaiHoc_KT_DaCC = "Kết thúc - Đã cấp chứng chỉ";
            public static readonly string TrangThaiHoc_BaoLuu = "Bảo Lưu";
            public static readonly string TrangThaiHoc_DinhChi = "Đình chỉ";
            public static readonly string TrangThaiHoc_ThoiHoc = "Thôi Học";
            public static readonly string RemoveSimblo = "[$..";
            public static readonly string HTMLSpace = "&nbsp;";
            public static readonly string HinhThuc_TatCa = "Tất cả học viên";
            public static readonly string HocPhi_TatCa = "Toàn bộ";
            
        }

        public static class HocVienXepLoai 
        {
            public static readonly string XepLoai_XSac = "Xuất sắc";
            public static readonly string XepLoai_Gioi      = "Giỏi";
            public static readonly string XepLoai_Kha       = "Khá";
            public static readonly string XepLoai_TrungBinh = "Trung bình";
            public static readonly string XepLoai_TrungBinhKha = "Trung bình Khá";
            public static readonly string XepLoai_Yeu = "Yếu";
        }

        public static class HocVienXepLoaiValue 
        {
            public static readonly float XepLoai_XSac = 9.0f;
            public static readonly float XepLoai_Gioi = 8.0f;
            public static readonly float XepLoai_Kha = 7.0f;
            public static readonly float XepLoai_TrungBinhKha = 6.0f;
            public static readonly float XepLoai_TrungBinh = 5.0f;
        }
    }
}
