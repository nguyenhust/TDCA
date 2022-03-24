using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.DaoTao
{
    public class DT_TheHocVienLienTuc
    {
        public List<TheHocVienLienTuc> ListTheHocVienLienTuc { get; set; }
    }

    public class TheHocVienLienTuc
    {
        public string TenHocVien { get; set; }
        public string KhoaHoc { get; set; }
        public string TruongHoc { get; set; }
        public string ThoiGian { get; set; }
        public string AnhHocVien { get; set; }
        public string MaHocVien { get; set; }
        public string SoCMT { get; set; }
        public string TrinhDo { get; set; }
        public int IDTrinhDo { get; set; }
      
    }
}
