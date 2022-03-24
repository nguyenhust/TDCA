using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.DaoTao
{
    public class DT_TheHocVien
    {
        public List<TheHocVien> ListTheHocVien { get; set; }
    }

    public class TheHocVien
    {
        public string TenHocVien { get; set; }
        public string LopHoc { get; set; }
        public string ChuyenNganh { get; set; }
        public string KhoaHoc { get; set; }
        public string AnhHocVien { get; set; }
        public string MaHocVien { get; set; }
        public string ThoiGianHoc { get; set; }
        public string SoCMT { get; set; }
        public string TrinhDo{get;set;}
        public string ThoiGian { get; set; }
    }
}
