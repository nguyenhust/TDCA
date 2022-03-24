using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.DaoTao
{
    public class DanhSachBangTheoDoiChiTieuThucHanh
    {
        public List<BangTheoDoiChiTieuThucHanh> list { get; set; }
    }

    public class BangTheoDoiChiTieuThucHanh
    {
        public string TenKhoaDaoTao { get; set; }
        public string TenLop { get; set; }
        public string ThoiGianBatDau { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public string HoTenHocVien { get; set; }
        public string DonViCongTac { get; set; }
    }
}
