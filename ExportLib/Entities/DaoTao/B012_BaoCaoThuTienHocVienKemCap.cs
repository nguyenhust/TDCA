using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.DaoTao
{
    public class B012_BaoCaoThuTienHocVienKemCap
    {
        public List<ClassDanhSachHocVien> ListClassDanhSachHocVien { get; set; }
        public string KhoaDaoTao { get; set; }
        public string TongSoTien { get; set; }
        public string SoTienBangChu { get; set; }
        public string ThoiGianNhap { get; set; }
        public string NguoiLapBaoCao { get; set; }
    }

    public class ClassDanhSachHocVien
    {
        public string STT { get; set; }
        public string DanhSachHocVien { get; set; }
        public string SoTien { get; set; }
        public string DV { get; set; }
        public string ThoiGianHoc { get; set; }
        public string NoiDungDaoTao { get; set; }
        public string ChuyenKhoa { get; set; }
    }
}
