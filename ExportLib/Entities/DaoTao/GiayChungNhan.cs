using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.DaoTao
{
    public class DT_GiayChungNhan
    {
        public List<ChungNhan> ListChungNhan { get; set; }
    }

    public class ChungNhan
    {
        public string HocVien { get; set; }
        public string NgaySinh { get; set; }
        public string TrinhDo { get; set; }
        public string DonViCongTac { get; set; }
        public string KhoaHocHoanThanh { get; set; }
        public string SoTietHoc { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string ThongTin { get; set; }
    }
}
