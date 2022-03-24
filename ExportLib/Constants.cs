using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportLib
{
    public class Constants
    {
        public enum ExportType
        { 
            Doc,
            Pdf,
            Excel
        }

        public class Html
        {
            public const string Header = "<!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01//EN' 'http://www.w3.org/TR/html4/strict.dtd'>" +
                                    "<html>"+
                                    "<head>"+
                                        "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>"+
                                        "<meta http-equiv='X-UA-Compatible' content='IE=8'>"+
                                        "<title></title>"+
                                    "</head>"+
                                    "<body>";
            public const string Footer = "</body></html>";

        }

        public class TemplatePath
        {
            public const string P003_PhieuThuLT = @"Templates\DaoTao\P003_PhieuThuLT.rpt";
            public const string G001_GiayHenTraChungChiHocVien = @"Templates\DaoTao\G001_GiayHenTraChungChiHocVien.rpt";
            public const string G002_GiayHenTraTheHocVien = @"Templates\DaoTao\G002_GiayHenTraTheHocVien.rpt";
            public const string G003_GiayDeNghiThuTienHocPhi = @"Templates\DaoTao\G003_GiayDeNghiThuTienHocPhi.rpt";
            public const string G003_GiayDeNghiThuTienTheVaChungChi = @"Templates\DaoTao\G003_GiayDeNghiThuTienTheVaChungChi.rpt";
            public const string G004_GiayDeNghiTiepNhanHocVien = @"Templates\DaoTao\G004_GiayDeNghiTiepNhanHocVien.rpt";
            public const string P_PhieuThuLT = @"Templates\DaoTao\P_PhieuThuLT.html";
            public const string TheHocVien = @"Templates\DaoTao\TheHocVien.html";
            public const string BangTheoDoiChiTieuThucHanh = @"Templates\DaoTao\BangTheoDoiChiTieuThucHanh.html";
            public const string BangTongHopKetQuaHoanThanhChiTieuThucHanh = @"Templates\DaoTao\BangTongHopKetQuaHoanThanhChiTieuThucHanh.html";
            public const string TheHocVienLienTuc = @"Templates\DaoTao\TheHocVienLienTuc.html";
            public const string GiayChungChi01 = @"Templates\DaoTao\GiayChungChi01.html";
            public const string GiayChungChi01Content = @"Templates\DaoTao\MauChungChi01Content.html";
            //public const string GiayChungChi03Content = @"Templates\DaoTao\MauChungChi03.html";
            public const string GiayChungChi02 = @"Templates\DaoTao\GiayChungChi02.html";
            public const string GiayChungChi02Content = @"Templates\DaoTao\MauChungChi02Content.html";
            public const string B001_BangDiemDanhTheoLop = @"Templates\DaoTao\B001_BangDiemDanhTheoLop.html";
            public const string B001_BangDiemDanhTheoLopRpt = @"Templates\DaoTao\B001_BangDiemDanhTheoLop.rpt";
            public const string D001_DanhSachKhoaHoc = @"Templates\DaoTao\D001_DanhSachKhoaHoc.html";
            public const string D001_DanhSachKhoaHocRpt = @"Templates\DaoTao\D001_DanhSachKhoaHoc.rpt";
            public const string L001_LichLopHocLichGiang = @"Templates\DaoTao\L001_LichLopHocLichGiangLyThuyet.html";
            public const string B011_BaoCaoSoLuongHocVienTheoTrinhDo = @"Templates\DaoTao\B011_BaoCaoSoLuongHocVienTheoTrinhDo.rpt";
            public const string B012_BaoCaoThuTienHocVienKemCap = @"Templates\DaoTao\B012_BaoCaoThuTienHocVienKemCap.rpt";
            public const string B014_BaoCaoTongKetKhoaDaoTao = @"Templates\DaoTao\B014_BaoCaoTongKetKhoaDaoTao.rpt";
            public const string B015_BaoCaoThongKeHocVienTheoLop = @"Templates\DaoTao\B015_BaoCaoThongKeHocVienTheoLop.rpt";
            public const string D002_DanhSachHocVienNhanGiayChungNhan = @"Templates\DaoTao\D002_DanhSachHocVienNhanGiayChungNhan.rpt";
            public const string D003_DanhSachLopHoc2 = @"Templates\DaoTao\D003_DanhSachLopHoc2.rpt";
            public const string D004_DanhSachThuTienTaiTDC = @"Templates\DaoTao\D004_DanhSachThuTienTaiTDC.rpt";
            public const string T001_Khung = @"Templates\DaoTao\khungtheolop.jpg";
            public const string T001_Back = @"Templates\DaoTao\backtheolop.jpg";
            public const string B101_PhieuXinXe = @"Templates\HanhChinh\B101_PhieuXinXe.html";
            public const string P001_PhieuMuonThietBi = @"Templates\HanhChinh\P001_PhieuMuonThietBi.rpt";
            public const string P100_PhieuMuon = @"Templates\HanhChinh\P100_PhieuMuon.html";
            public const string B002_BaoCaoChamCong = @"Templates\HanhChinh\B002_BaoCaoChamCong.html";
            public const string B003_BaoCaoCongVanDen = @"Templates\HanhChinh\B003_BaoCaoCongVanDen.rpt";
            public const string B004_BaoCaoCongVanDi = @"Templates\HanhChinh\B004_BaoCaoCongVanDi.rpt";
            public const string B005_BaoCaoDangKiGiangDuongPhongHoc = @"Templates\HanhChinh\B005_BaoCaoDangKiGiangDuongPhongHoc.rpt";
            public const string B006_BaoCaoDuTruVanPhongPhamTheoTo = @"Templates\HanhChinh\B006_BaoCaoDuTruVanPhongPhamTheoTo.rpt";
            public const string B007_BaoCaoDuTruVanPhongPham = @"Templates\HanhChinh\B007_BaoCaoDuTruVanPhongPham.html";
            public const string B008_BaoCaoTonKhoThietBiLamSang = @"Templates\HanhChinh\B008_BaoCaoTonKhoThietBiLamSang.html";
            public const string B009_BaoCaoTonKhoThietBiTienLamSang = @"Templates\HanhChinh\B009_BaoCaoTonKhoThietBiTienLamSang.rpt";
            public const string B010_BaoCaoTrangThietBi = @"Templates\HanhChinh\B010_BaoCaoTrangThietBi.rpt";
            public const string P005_PhieuDangKiGiangDuongPhongHoc = @"Templates\HanhChinh\P005_PhieuDangKiGiangDuongPhongHoc.rpt";
            public const string BaoCaoXinXe = @"Templates\HanhChinh\BaoCaoXinXe.html";

            public const string B011_BaiVietTruyenThong = @"Templates\TruyenThong\B011_BaiVietTruyenThong.html";
            public const string B011_BaiVietTruyenThongRpt = @"Templates\TruyenThong\B011_BaiVietTruyenThong.rpt";
            public const string B012_BaoCaoQuanLyAnhCungCap = @"Templates\TruyenThong\B012_BaoCaoQuanLyAnhCungCap.html";
            public const string B012_BaoCaoQuanLyAnhCungCapRpt = @"Templates\TruyenThong\B012_BaoCaoQuanLyAnhCungCap.rpt";

            public const string B013_BaoCaoKetQuaDaoTaoHoiChan = @"Templates\ChiDaoTuyen\B013_BaoCaoKetQuaDaoTaoHoiChan.html";
            public const string B013_BaoCaoKetQuaDaoTaoHoiChanRpt = @"Templates\ChiDaoTuyen\B013_BaoCaoKetQuaDaoTaoHoiChan.rpt";
            public const string B100_BaoCaoChung = @"Templates\HanhChinh\B100_BaoCaoChung.html";
            public const string B020_SoTheoDoiHocTap = @"Templates\HanhChinh\B020_SoTheoDoiHocTap.html";
            public const string B103_HVduoccapchungchitheolop = @"Templates\HanhChinh\B103_HVduoccapchungchitheolop.html";

        }

        public class FileName
        {
            public class DaoTao
            {
                public const string G003_GiayDeNghiThuTienHocPhi = "Giay de nghi thu tien hoc phi";
                public const string G003_GiayDeNghiThuTienTheVaChungChi = "Giay de nghi thu tien thẻ và chúng chỉ";
                public const string G004_GiayDeNghiTiepNhanHocVien = "Giay de nghi tiep nhan hoc vien";
                public const string G002_GiayHenTraTheHocVien = "Giay hen tra the hoc vien";
                public const string D001_DanhSachKhoaHoc = "danh sach khoa hoc";
                public const string G001_GiayHenTraChungChiHocVien = "giay hen tra chung chi hoc vien";
                public const string P003_PhieuThuLTNhieuHocVien = "phieu thu LT nhieu hoc vien";
                public const string B001_BangDiemDanhTheoLop = "Bang diem danh  theo lop";
                public const string BangDiemDanhTheoNhom = "Bang diem danh  theo nhom";
                public const string P001_PhieuThuLTKemCap = "phieu thu LT kem cap";
                public const string P002_PhieuThuLTTheoLop = "phieu thu LT theo lop";
                public const string L001_LichLopHocLichGiangLyThuyet = "lich lop hoc _ lich giang ly thuyet";
                public const string L002_LichLopHocLichGiangThucHanh = "lich lop hoc _ lich giang thuc hanh";
                public const string SoTheoDoiHocTap = "so theo doi hoc tap";
                public const string TheHocVien = "the_hoc_vien";
                public const string BangTheoDoiChiTieuThucHanh = "bang_theo_doi_chi_tieu_thuc_hanh";
                public const string BangTongHopKetQuaHoanThanhChiTieuThucHanh = "bang_tong_hop_ket_qua_hoan_thanh_chi_tieu_thuc_hanh";
                public const string TheHocVienLienTuc = "the_hoc_vien_lien_tuc";
                public const string GiayChungNhan = "giay_chung_nhan";
                public const string GiayChungChi = "giay_chung_chi";
                public const string B011_BaoCaoSoLuongHocVienTheoTrinhDo = "bao cao so luong hoc vien xep theo trinh do";
                public const string B012_BaoCaoThuTienHocVienKemCap = "bao cao thu tien hoc vien kem cap";
                public const string B014_BaoCaoTongKetKhoaDaoTao = "bao cao tong ket khoa dao tao";
                public const string B015_BaoCaoThongKeHocVienTheoLop = "bao cao thong ke hoc vien theo lop";
                public const string D002_DanhSachHocVienNhanGiayChungNhan = "danh sach hoc vien nhan giay chung nhan";
                public const string D003_DanhSachLopHoc2 = "danh sach lop hoc 2";
                public const string D004_DanhSachThuTienTaiTDC = "danh sach thu tien tai TDC";
            }

            public class HanhChinh
            {
                public const string B003_BaoCaoCongVanDen = "bao cao cong van den";
                public const string B004_BaoCaoCongVanDi = "bao cao cong van di";
                public const string B002_BaoCaoChamCong = "bao cao cham cong";
                public const string B005_BaoCaoDangKiGiangDuongPhongHoc = "phieu dang ki giang duong phong hoc";
                public const string P001_PhieuMuonThietBi = "phieu muon thiet bi";
                public const string B009_BaoCaoTonKhoThietBiTienLamSang = "bao cao ton kho thiet bi tien lam sang _ 01";
                public const string B010_BaoCaoTrangThietBi = "bao cao trang thiet bi";
                public const string BaoCaoDangKyGiangDuongTruongHoc = "bao cao dang ki giang duong phong hoc";
                public const string B006_BaoCaoDuTruVanPhongPhamTheoTo = "bao cao du tru van phong pham _theo to";
                public const string B007_BaoCaoDuTruVanPhongPham = "bao cao du tru van phong pham";
                public const string B008_BaoCaoTonKhoThietBiLamSang = "Bao cao ton kho thiet bi lam sang  _ the kho";
                public const string P005_PhieuDangKiGiangDuongPhongHoc = "phieu dang ki giang duong phong hoc";
                public const string B100_BaoCaoChung = "Bao cao";
                public const string B020_SoTheoDoiHocTap = "B020_SoTheoDoiHocTap";
                public const string B101_PhieuXinXe = "Bao cao phieu xin xe";
                public const string BaoCaoXinXe = "Bao cao xin xe";
                public const string B103_HVduoccapchungchitheolop = "B103_HVduoccapchungchitheolop";
            }

            public class TruyenThong
            {
                public const string B011_BaiVietTruyenThong = "bai viet truyen thong";
                public const string B012_BaoCaoQuanLyAnhCungCap = "bao cao quan ly anh cung cap";
            }

            public class ChiDaoTuyen
            {
                public const string B013_BaoCaoKetQuaDaoTaoHoiChan = "Bao cao ket qua dao tao hoi chan";
            }
        }

        public class EmptyData
        {
            public const string ThoiGianTraThe = "........................, thứ ......, ngày ....../........./.......... ";
            public const string NgayViet = "ngày ...... tháng ...... năm 20 ...... ";
            public const string LongEmpty = ". . . . . . . . . . . . . . . . . . .";
        }
        public class BaoCaoChung
        {
            public const string TenTrungTam = "Văn phòng trung tâm";

        }

        public class Common
        {
            public const string Title_LichGiangLyThuyet = "BẢNG THEO DÕI LỊCH GIẢNG LÝ THUYẾT";
            public const string Title_LichGiangThucHanh = "BẢNG THEO DÕI LỊCH GIẢNG THỰC HÀNH";
        }
    }
}
