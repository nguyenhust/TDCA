using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.HanhChinh
{
    public class B003_BaoCaoCongVanDen
    {
        public List<CongVanDen> ListCongVanDen { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string TongSoCongVanDen { get; set; }
        public string NgayLapBaoCao { get; set; }
        public string NguoiLapBaoCao { get; set; }
    }

    public class CongVanDen
    {
        public string STT { get; set; }
        public string SoCongVan { get; set; }
        public string NgayNhan { get; set; }
        public string VeViec { get; set; }
        public string NoiGui { get; set; }
        public string ViTriLuu { get; set; }
    }
}
