using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.ChiDaoTuyen
{
    public class B013_BaoCaoKetQuaDaoTaoHoiChan
    {
        public List<SoLieuThongKe> ListSoLieuThongKe { get; set; }
        public string NgayTienHanh { get; set; }
        public string NoiDung { get; set; }
        public string ChuTri { get; set; }
        public string ChucVuChuTri { get; set; }
        public string KhoaChuTri { get; set; }
        public string ThuKy1 { get; set; }
        public string ThuKy2 { get; set; }
        public string DeMuc1 { get; set; }
        public string DeMuc2 { get; set; }
        public string DeMuc3 { get; set; }
        public string NgayLapBaoCao { get; set; }
        public string PhongChiDaoTuyen { get; set; }
        public string NguoiLamBaoCao { get; set; }
    }

    public class SoLieuThongKe
    {
        public string TenBVThamGia { get; set; }
        public string SoLuongThamGia { get; set; }
        public string BaoCaoBA { get; set; }
    }
}
