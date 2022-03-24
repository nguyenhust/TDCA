using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Export.Entities.HanhChinh
{
    public class BaoCaoDuTruVanPhongPham
    {
        public List<VanPhongPham> listVanPhongPham { get; set; }
        public string ThangNam { get; set; }
        public string Khoan { get; set; }
        public string ThoiGian { get; set; }
    }

    public class VanPhongPham
    {
        public string DanhMuc { get; set; }
        public string DonVi { get; set; }
        public string SoLuong { get; set; }
        public string GhiChu { get; set; }
    }
}
