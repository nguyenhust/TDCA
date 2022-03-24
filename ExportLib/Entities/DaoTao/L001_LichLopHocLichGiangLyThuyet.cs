using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.DaoTao
{
    public class L001_LichLopHocLichGiang
    {
        public List<LichGiang> ListLichGiang { get; set; }
        public string KhoaDaoTao { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
    }

    public class LichGiang
    {
        public string Thoigian { get; set; }
        public string NoiDungGiang { get; set; }
        public string SoTiet { get; set; }
    }
}
