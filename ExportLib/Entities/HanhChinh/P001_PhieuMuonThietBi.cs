using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportLib.Entities.HanhChinh
{
    public class P001_PhieuMuonThietBi
    {
        public List<NoiDungThietBi> ListNoiDungThietBi { get; set; }
        public string NgayVietPhieu { get; set; }
        public string DaiDienBenGiao { get; set; }
        public string NguoiGiao1 { get; set; }
        public string ChucVuGiao1 { get; set; }
        public string NguoiGiao2 { get; set; }
        public string ChucVuGiao2 { get; set; }
        public string NguoiGiao3 { get; set; }
        public string ChucVuGiao3 { get; set; }
        public string DaiDienBenMuon { get; set; }
        public string NguoiMuon1 { get; set; }
        public string ChucVuMuon1 { get; set; }
        public string NguoiMuon2 { get; set; }
        public string ChucVuMuon2 { get; set; }
        public string NguoiMuon3 { get; set; }
        public string ChucVuMuon3 { get; set; }
        public string DiaDiemMuon { get; set; }
        public string ThoiGianMuon { get; set; }
        public string KyDaiDienBenGiao { get; set; }
        public string KyDaiDienBenNhan { get; set; }
        public string TenBaoCao { get; set; }
        public string NhanOrMuon { get; set; }
        public string Warning { get; set; }
    }

    public class NoiDungThietBi
    {
        public string STT { get; set; }
        public string TenThietBi { get; set; }
        public string Serial { get; set; }
        public string XuatSu { get; set; }
        public string DonVi { get; set; }
        public string SoLuong { get; set; }
        public string GhiChu { get; set; }
    }   
}
