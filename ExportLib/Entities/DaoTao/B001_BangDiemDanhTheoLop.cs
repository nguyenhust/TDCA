using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.DaoTao
{
    public class B001_BangDiemDanhTheoLop
    {
        public List<DanhSachLop> ListHocVien { get; set; }
        public string KhoaDaoTao { get; set; }
        public string TenLop { get; set; }
        public string NgayBatDau { get; set; }
        public string NgayKetThuc { get; set; }
        public string TuanBatDau { get; set; }
        public string TuanKetThuc { get; set; }
        public string ThoiGianNhap { get; set; }
        public string CanBoPhuTrachLop { get; set; }
        public string NhomTruong { get; set; }
    }

    public class DanhSachLop 
    {

        // khoi tao khong tham so
        public DanhSachLop() { 
        
        }

        public DanhSachLop(string stt, string tenhocvien) {
            STT = stt;
            TenHocVien = tenhocvien;
        }

        public string STT { get; set; }
        public string TenHocVien { get; set; }


    }
}
