using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.DaoTao
{
    public class D001_DanhSachKhoaHoc
    {
        public List<KhoaDaoTao> ListKhoaHoc { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string NgayLapBaoCao { get; set; }
        public string NguoiLapBaoCao { get; set; }
    }

    public class KhoaDaoTao 
    {
        public string STT { get; set; }
        public string TenKhoaHoc { get; set; }
        public string DonViDaoTao { get; set; }
        public string ThoiGian { get; set; }
        public string NguonKP { get; set; }
        public string CBPhuTrach { get; set; }
        public string SoHV { get; set; }
        public string TrangThai { get; set; }
    }
}
