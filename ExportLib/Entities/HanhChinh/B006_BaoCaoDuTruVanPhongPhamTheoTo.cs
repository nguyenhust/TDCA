using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.HanhChinh
{
    public class B006_BaoCaoDuTruVanPhongPhamTheoTo
    {
        public List<VanPhongPham> ListVanPhongPham { get; set; }
        public string Nhom { get; set; }
        public string ThangDuTru { get; set; }
        public string NgayLapBaoCao { get; set; }
        public string NguoiDuTru { get; set; }
        public string NguoiNhan { get; set; }
        public string NhomTruong { get; set; }
        public string LanhDao { get; set; }
    }

    public class VanPhongPham
    {
        public string STT { get; set; }
        public string VatTuSanPham { get; set; }
        public string DonVi { get; set; }
        public string SoLuongDuTru { get; set; }
        public string GhiChu { get; set; }
    }
}
