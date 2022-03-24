using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reporting.LIB
{
    public class BC_KQDT_HoiChuanTrucTuyen
    {
        public DateTime NgayTienHanh { get; set; }
        public string NguoiChuTri { get; set; }
        public string ThuKy { get; set; }
        public List<KQDT_HoiChuanTrucTuyen> SoLieuThongKe { get; set; }
        public string[] CongTacChuanBi { get; set; }
        public string[] QuaTrinhDaoTao { get; set; }
        public string NhanXetVaDeXuat { get; set; }
        public string ThoiGianKetThuc { get; set; }
        public string DiaDiem { get; set; }
    }
}
