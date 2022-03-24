using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Export.Entities.HanhChinh
{
    public class DataHanhChinh
    {
        public BaoCaoDuTruVanPhongPham GetDataBaoCaoDuTruVanPhongPham()
        {
            BaoCaoDuTruVanPhongPham data = new BaoCaoDuTruVanPhongPham();
            data.Khoan = "2";
            data.ThangNam = "6/2014";
            data.ThoiGian = "ngay 6/6/2014";
            List<VanPhongPham> listVpp = new List<VanPhongPham>();
            VanPhongPham vpp = new VanPhongPham();
            vpp.DanhMuc = "Danh Muc 1";
            vpp.DonVi = "Don Vi 1";
            vpp.GhiChu = "Ghi Chu 1";
            vpp.SoLuong = "So Luong 1";
            listVpp.Add(vpp);

            vpp = new VanPhongPham();
            vpp.DanhMuc = "Danh Muc 2";
            vpp.DonVi = "Don Vi 2";
            vpp.GhiChu = "Ghi Chu 2";
            vpp.SoLuong = "So Luong 2";
            listVpp.Add(vpp);

            data.listVanPhongPham = listVpp;
            return data;
        }

        public BaoCaoTonKhoThietBiLamSang GetDataBaoCaoTonKhoThietBiLamSang()
        {
            BaoCaoTonKhoThietBiLamSang data = new BaoCaoTonKhoThietBiLamSang();
            data.Loai = "Panh không có mấu 18 cm";
            List<ThietBi> listTB = new List<ThietBi>();

            for (int i = 0; i < 30; i++)
            {
                ThietBi tb = new ThietBi
                {
                    Ngay = "1/1/2014",
                    NoiDung = "Jica",
                    TinhTrang = "Tot",
                    Nhap = "5",
                    Xuat = string.Empty,
                    Ton = "5"
                };
                listTB.Add(tb);
            }

            data.listThietBi = listTB;
            return data;
        }
    }
}
