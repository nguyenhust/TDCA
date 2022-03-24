using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.HanhChinh
{
    public class B005_BaoCaoDangKiGiangDuongPhongHoc
    {
        public List<DangKy> ListDangKy { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string TongSoDangKy { get; set; }
        public string NgayLapBaoCao { get; set; }
        public string NguoiLapBaoCao { get; set; }
    }

    public class DangKy
    {
        public string STT { get; set; }
        public string NgayDangKy { get; set; }
        public string NoiDung { get; set; }
        public string GDPH { get; set; }
        public string CanBoDangKy { get; set; }
        public string ChatLuong { get; set; }
        public string YKienKhac { get; set; }
    }
}
