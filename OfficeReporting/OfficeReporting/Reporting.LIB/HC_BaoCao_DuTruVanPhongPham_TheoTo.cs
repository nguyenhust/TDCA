using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reporting.LIB
{
    public class HC_BaoCao_DuTruVanPhongPham_TheoTo
    {
        public string NhomPhong { get; set; }
        public string ThangBaoCao { get; set; }
        public List<VanPhongPham> DanhSachVanPhongPham { get; set; }
        public string ThoiGianTaoBaoCao { get; set; }
        public string ChuKy_LanhDao { get; set; }
        public string Chuky_NhomTruong { get; set; }
        public string Chuky_NguoiNhan { get; set; }
        public string Chuky_nguoiDuTru { get; set; }
    }
}
