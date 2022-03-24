using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Authoration.LIB;
using CrystalDecisions.CrystalReports.Engine;
using DanhMuc.LIB;
using ExportLib;
using ExportLib.Entities.DaoTao;
using NETLINK.LIB;
using NETLINK.UI;
using System.Collections;

namespace ModuleDaoTao.LIB
{
    public static class DT_Common_value
    {
        public const string TT_HocVien_ChuaHoc = "Chưa bắt đầu học";
        public const string TT_HocVien_DangHoc = "Đang học";
        public const string TT_HocVien_ChuaCapChungChi = "Kết thúc - chưa cấp chứng chỉ";
        public const string TT_HocVien_DaCapChungChi = "Kết thúc - Đã cấp chứng chỉ";
        public const string TT_HocVien_BaoLuu = "Bảo Lưu";
        public const string TT_HocVien_DinhChi = "Đình chỉ";
        public const string TT_HocVien_ThoiHoc = "Thôi học";

    }
    public class DT_Common
    {

        public const string KemCap = "Kèm cặp";
        public const string TheoLop = "Theo lớp";


        public  const int HOCPHI_DADONG = 0;
        public  const int HOCPHI_CHUADONG = 1;
        public const int HOCPHI_HOANTIEN = 2;
        public const int HOCPHI_TOANBO = 3;

        public const int DIEM_THEOLOP = 0;
        public const int DIEM_KEMCAP = 1;

        public const int HEN_CHUNGCHIKEMCAP = 0;
        public const int HEN_CHUNGCHITHEOLOP = 1;
        public const int CHUNGCHI_KEMCAP = 2;
        public const int CHUNGCHI_THEOLOP = 3;


        // Danh sach Hoc Vien
        public const int DS_HOCVIEN_ALL             = 0;
        public const int DS_HOCVIEN_THEOLOP_DAHOC   = 1;
        public const int DS_HOCVIEN_THEOLOP_DANGHOC = 2;
        public const int DS_HOCVIEN_KEMCAP_DAHOC    = 3;
        public const int DS_HOCVIEN_KEMCAP_DANGHOC  = 4;
        public const int DS_HOCVIEN_KEMCAP_CHUAHOC = 7;
        public const int DS_HOCVIEN_CHOXEPLOP       = 5;
        public const int DS_HOCVIEN_DANGKITUCTT = 6;

        public const string CQ_LoaiDT_CKI = "CKI";
        public const string CQ_LoaiDT_CKII = "CKII";
        public const string CQ_LoaiDT_BSNT = "BSNT";

        public const int IN_ChuaCapChungChi = 10;
        public const int IN_DaCapChungChi = 11;
        public const int IN_ChuaInThe = 12;
        public const int IN_DaInThe = 13;

        public const int IN_ChungChi_All = 14;
        public const int IN_The_All = 15;
        public const int IN_ChuaXepLop = 16;
        public const int IN_DaXepLop = 17;
        public const int IN_XepLop_All = 18;

        public const string KC_DangHoc = "đang học";
        public const string KC_ChuaHoc = "chưa bắt đầu học";
        public const string KC_KetThucDCCC = "kết thúc - đã cấp chứng chỉ";
        public const string KC_KetThucCCCC = "Kết thúc - chưa cấp chứng chỉ";
        public const string KC_ThoiHoc = "Thôi học";
        public const string KC_All = "";

        

        public static string XepLoaiHV(DT_LienTuc_HocVien item)
        {
            return string.Empty;
        }

        public static double CQ_CaculateTongDiemTotNghiep(object diem1x, object diem2x, object diem3x)
        {

            double diem1 = 0;
            double diem2 = 0;
            double diem3 = 0;
            if (diem1x != null)
                double.TryParse(diem1x.ToString(), out diem1);
            if (diem2x != null)
                double.TryParse(diem2x.ToString(), out diem2);
            if (diem3x != null)
                double.TryParse(diem3x.ToString(), out diem3);
            double tong = 0;
            int count = 0;
            if (diem1 > 0)
            {
                tong += diem1;
                count++;
            }
            if (diem2 > 0)
            {
                tong += diem2;
                count++;
            }
            if (diem3 > 0)
            {
                tong += diem3;
                count++;
            }
            return tong / count;
        }
        public static double CQ_CaculateDiemXepLoai(object tongmon, object tongTN)
        {
            if (tongmon != null && !string.IsNullOrEmpty(tongmon.ToString()))
            {
                return (Convert.ToDouble(tongmon) + Convert.ToDouble(tongTN)) / 2;
            }
            return 0;
        }
        public static string CQ_XepLoai(object tongXL)
        {
            return string.Empty;
        }

        public static void PrintHocPhi(DT_LienTuc_HocVien objHocvien, DIC_ChuyenNganh_Info chuyennganh, DIC_HocVi_Info trinhdo) 
        {
            G003_GiayDeNghiThuTienHocPhi denghithuhocphi = new G003_GiayDeNghiThuTienHocPhi();
            denghithuhocphi.DiaDiemDangKy = chuyennganh.Ten;
            denghithuhocphi.GioiTinh = objHocvien.GioiTinh;

            double month = 0;
            string TongHocPhiStr = string.Empty;
            if (objHocvien.HinhThucHoc.CompareTo(TheoLop) == 0)
            {
                if (string.IsNullOrEmpty(objHocvien.MaLopHoc))
                {
                    GlobalCommon.ShowErrorMessager("Học viên chưa được xếp lớp!");
                    return;
                }
                DT_LienTuc_LopHoc lophoc = DT_LienTuc_LopHoc.GetDT_LienTuc_LopHoc(objHocvien.MaLopHoc);
                if (lophoc == null)
                {
                    GlobalCommon.ShowErrorMessager("Lớp học không tồn tại!");
                    return;
                }

                DateTime startDate = System.Convert.ToDateTime(lophoc.NgayBatDau);
                DateTime endDate = System.Convert.ToDateTime(lophoc.NgayKetThuc);
                month = GlobalCommon.TotalMonths(startDate, endDate);
                TongHocPhiStr = lophoc.HocPhi;
            }
            else if (objHocvien.HinhThucHoc.CompareTo(KemCap) == 0)
            {

                DateTime startDate = System.Convert.ToDateTime(objHocvien.NgayBatDau);
                DateTime endDate = System.Convert.ToDateTime(objHocvien.NgayKetThuc);
                month = GlobalCommon.TotalMonths(startDate, endDate);
                TongHocPhiStr = objHocvien.TongHocPhi;
            }
          
            denghithuhocphi.HoTenHocVien = objHocvien.HoTen;
            denghithuhocphi.NgaySinh = objHocvien.NgaySinh;
            DateTime date = DateTime.Now;
            denghithuhocphi.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            denghithuhocphi.NoiCongTac = objHocvien.NoiCongTac;
            if (!string.IsNullOrEmpty(TongHocPhiStr))
            {
                TongHocPhiStr = GlobalCommon.ConvertMoney(Convert.ToInt64(TongHocPhiStr)) + " VNĐ";
                denghithuhocphi.BangChu = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(Convert.ToInt64(TongHocPhiStr));
            }
            else
            {
                TongHocPhiStr = "0 VNĐ";
                denghithuhocphi.BangChu = "";
            }

            denghithuhocphi.TongTienHocPhi = TongHocPhiStr;
          
            //DIC_HocVi_Info trinhdo = (DIC_HocVi_Info)dropDownTrinhDo.Selected_Item;
            denghithuhocphi.TrinhDo = trinhdo.TenHocVi;
            denghithuhocphi.NoiDungHoc = objHocvien.NoiDungDaoTao;
            ExportDaoTao daotao = new ExportDaoTao();

            ReportDocument doc = daotao.G003_GiayDeNghiThuTienHocPhi(new List<ExportLib.Entities.DaoTao.G003_GiayDeNghiThuTienHocPhi>() { denghithuhocphi });
            FormMode newmode = new FormMode();
            newmode.Item = doc;
            NetLinkReport fr = new NetLinkReport(newmode);
            fr.Show();
        }

        public static void PrintHocPhi(DT_LienTuc_HocVien_Info objHocvien, DIC_ChuyenNganh_Info chuyennganh, DIC_HocVi_Info trinhdo)
        {
            G003_GiayDeNghiThuTienHocPhi denghithuhocphi = new G003_GiayDeNghiThuTienHocPhi();
            denghithuhocphi.DiaDiemDangKy = chuyennganh.Ten;
            denghithuhocphi.GioiTinh = objHocvien.GioiTinh;

            double month = 0;
            string TongHocPhiStr = string.Empty;
            if (objHocvien.HinhThucHoc.CompareTo(TheoLop) == 0)
            {
                if (string.IsNullOrEmpty(objHocvien.MaLopHoc))
                {
                    GlobalCommon.ShowErrorMessager("Học viên chưa được xếp lớp!");
                    return;
                }
                DT_LienTuc_LopHoc lophoc = DT_LienTuc_LopHoc.GetDT_LienTuc_LopHoc(objHocvien.MaLopHoc);
                if (lophoc == null)
                {
                    GlobalCommon.ShowErrorMessager("Lớp học không tồn tại!");
                    return;
                }

                DateTime startDate = System.Convert.ToDateTime(lophoc.NgayBatDau);
                DateTime endDate = System.Convert.ToDateTime(lophoc.NgayKetThuc);
                month = GlobalCommon.TotalMonths(startDate, endDate);
                TongHocPhiStr = lophoc.HocPhi;
            }
            else if (objHocvien.HinhThucHoc.CompareTo(KemCap) == 0)
            {

                DateTime startDate = System.Convert.ToDateTime(objHocvien.NgayBatDau);
                DateTime endDate = System.Convert.ToDateTime(objHocvien.NgayKetThuc);
                month = GlobalCommon.TotalMonths(startDate, endDate);
                TongHocPhiStr = objHocvien.TongHocPhi;
            }
            int tonghopPhi = (int)(System.Convert.ToInt32(TongHocPhiStr) / month);
            if (!string.IsNullOrEmpty(TongHocPhiStr))
            {
                TongHocPhiStr = GlobalCommon.ConvertMoney(Convert.ToInt64(TongHocPhiStr)) + " VNĐ";
                denghithuhocphi.BangChu = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(Convert.ToInt64(TongHocPhiStr));
            }
            else
            {
                TongHocPhiStr = "0 VNĐ";
                denghithuhocphi.BangChu = "";
            }
            denghithuhocphi.HoTenHocVien = objHocvien.HoTen;
            denghithuhocphi.NgaySinh = objHocvien.NgaySinh;
            DateTime date = DateTime.Now;
            denghithuhocphi.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            denghithuhocphi.NoiCongTac = objHocvien.NoiCongTac;


            denghithuhocphi.TongTienHocPhi = TongHocPhiStr;
           
            denghithuhocphi.TrinhDo = trinhdo.TenHocVi;
            denghithuhocphi.NoiDungHoc = objHocvien.NoiDungDaoTao;
            ExportDaoTao daotao = new ExportDaoTao();

            ReportDocument doc = daotao.G003_GiayDeNghiThuTienHocPhi(new List<ExportLib.Entities.DaoTao.G003_GiayDeNghiThuTienHocPhi>() { denghithuhocphi });
            FormMode newmode = new FormMode();
            newmode.Item = doc;
            NetLinkReport fr = new NetLinkReport(newmode);
            fr.Show();
        }

        public static void InBangDiemDanh(DT_LienTuc_LopHoc_Info objLophoc)
        {
            B001_BangDiemDanhTheoLop bangdiemdanh = new B001_BangDiemDanhTheoLop();

            DT_LienTuc_KhungLopHoc khunglopHoc = DT_LienTuc_KhungLopHoc.GetDT_LienTuc_KhungLopHoc((int)objLophoc.IdKhungLopHoc);

            if (khunglopHoc != null)
            {
                bangdiemdanh.KhoaDaoTao = khunglopHoc.ChuyenKhoa;
            }
            else
                bangdiemdanh.KhoaDaoTao = "";

            bangdiemdanh.NgayBatDau = objLophoc.NgayBatDau;
            bangdiemdanh.NgayKetThuc = objLophoc.NgayKetThuc;
            bangdiemdanh.ThoiGianNhap = DateTime.Now.ToString();
            bangdiemdanh.ListHocVien = new List<DanhSachLop>();

            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);

            DT_Lientuc_HocVienSearch objSearch = new DT_Lientuc_HocVienSearch();
            objSearch.MaLop = objLophoc.MaLop;
            objSearch.KhungLophoc = (int)objLophoc.IdKhungLopHoc;

            function.ItemID = (int)PTIdentity.IDNguoiDung;
            function.Item = objSearch;

            DT_LienTuc_HocVien_Coll collHocVien = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            int count = 1;
            foreach (DT_LienTuc_HocVien_Info hv in collHocVien)
            {
                if (!string.IsNullOrEmpty(hv.MaHocVien) && !string.IsNullOrEmpty(hv.MaLopHoc))
                {
                    bangdiemdanh.ListHocVien.Add(new DanhSachLop(count.ToString(), hv.HoTen));
                }
                count++;
            }

            ExportDaoTao daotao = new ExportDaoTao();
            daotao.B001_BangDiemDanhTheoLop(bangdiemdanh);
        }

        public static void InBangDiemDanhLopNhom(DT_LienTuc_LopHoc_Info objLophoc, string nhomList)
        {
            B001_BangDiemDanhTheoLop bangdiemdanh = new B001_BangDiemDanhTheoLop();

            DT_LienTuc_KhungLopHoc khunglopHoc = DT_LienTuc_KhungLopHoc.GetDT_LienTuc_KhungLopHoc((int)objLophoc.IdKhungLopHoc);

            if (khunglopHoc != null)
            {
                bangdiemdanh.KhoaDaoTao = khunglopHoc.ChuyenKhoa;
            }
            bangdiemdanh.NgayBatDau = objLophoc.NgayBatDau;
            bangdiemdanh.NgayKetThuc = objLophoc.NgayKetThuc;
            bangdiemdanh.ThoiGianNhap = DateTime.Now.ToString();
            bangdiemdanh.ListHocVien = new List<DanhSachLop>();

            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataByNhom);

            DT_Lientuc_HocVienSearch objSearch = new DT_Lientuc_HocVienSearch();
            objSearch.MaLop = objLophoc.MaLop;
            objSearch.ListNhom = nhomList;

            function.ItemID = (int)PTIdentity.IDNguoiDung;
            function.Item = objSearch;

            DT_LienTuc_HocVien_Coll collHocVien = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            Hashtable hashNhom = new Hashtable();
            
            foreach (DT_LienTuc_HocVien_Info hv in collHocVien)
            {
                if (!string.IsNullOrEmpty(hv.MaHocVien) && !string.IsNullOrEmpty(hv.MaLopHoc))
                {
                    if (hv.Nhom != null)
                    {
                        if (hashNhom.ContainsKey(hv.Nhom))
                        {
                            List<DT_LienTuc_HocVien_Info> lstHoc = (List<DT_LienTuc_HocVien_Info>)hashNhom[hv.Nhom];
                            lstHoc.Add(hv);
                        }
                        else {
                            List<DT_LienTuc_HocVien_Info> lstHoc = new List<DT_LienTuc_HocVien_Info>();
                            lstHoc.Add(hv);
                            hashNhom[hv.Nhom] = lstHoc;
                        }
                    }
                }
            }

            foreach (DictionaryEntry entry in hashNhom)
            {
                int count = 1;
                bangdiemdanh.ListHocVien.Clear();

                foreach (DT_LienTuc_HocVien_Info hv in (List<DT_LienTuc_HocVien_Info>)entry.Value){
                    bangdiemdanh.ListHocVien.Add(new DanhSachLop(count.ToString(), hv.HoTen));
                    count++;
                }

                ExportDaoTao daotao = new ExportDaoTao();
                daotao.B001_BangDiemDanhTheoLop(bangdiemdanh);
            }

            
        }
    }
}
