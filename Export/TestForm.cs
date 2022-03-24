using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Export.Entities.DaoTao;
using System.IO;

namespace Export
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.GiayDeNghiThuTienHocPhi);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.GiayDeNghiTiepNhanHocVien);
            cbDaoTao.Items.Add(Constants.FileName.DaoTao.GiayHenTraTheHocVien);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.DanhSachKhoaHoc);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.GiayHenTraChungChiHocVien);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.PhieuThuLTNhieuHocVien);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.BangDiemDanhTheoLop);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.BangDiemDanhTheoNhom);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.PhieuThuLTKemCap);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.PhieuThuLTTheoLop);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.LichLopHoc_LichGiangLyThuyet);
            //cbDaoTao.Items.Add(Constants.FileName.DaoTao.LichLopHoc_LichGiangThucHanh);
            cbDaoTao.Items.Add(Constants.FileName.DaoTao.SoTheoDoiHocTap);


            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoCongVanDen);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoCongVanDi);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoChamCong01);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.PhieuDangKyGiangDuongTruongHoc);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.PhieuMuonThietBi02);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.PhieuMuonThietBi01);
            cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoTonKhoThietBiLamSang01);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoChamCong02);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoTrangThietBiCuaTdc);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoTrangThietBi);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoDangKyGiangDuongTruongHoc);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoDuTruVanPhongPham_TheTo);
            cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoDuTruVanPhongPham);
            //cbHanhChinh.Items.Add(Constants.FileName.HanhChinh.BaoCaoTonKhoThietBiLamSang_TheKho);
        }

        private void btnDaoTao_Click(object sender, EventArgs e)
        {
            MainExport main = new MainExport();
            switch (cbDaoTao.SelectedItem.ToString())
            {
                case Constants.FileName.DaoTao.GiayHenTraTheHocVien: main.ExportGIayHenTraThe(); break;
                case Constants.FileName.DaoTao.SoTheoDoiHocTap: main.ExportSoTheoDoiHocTap(); break;
            };

        }

        private void btnHanhChinh_Click(object sender, EventArgs e)
        {
            MainExport main = new MainExport();
            switch (cbHanhChinh.SelectedItem.ToString())
            {
                case Constants.FileName.HanhChinh.BaoCaoDuTruVanPhongPham: main.ExportBaoCaoDuTruVanPhongPham(); break;
                case Constants.FileName.HanhChinh.BaoCaoTonKhoThietBiLamSang01: main.ExportBaoTonKhoThietBiLamSang(); break;
            };
        }
    }
}
