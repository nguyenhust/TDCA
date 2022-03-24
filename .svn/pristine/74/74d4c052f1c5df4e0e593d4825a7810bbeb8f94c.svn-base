using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using ModuleHanhChinh.LIB;
using DanhMuc.LIB;
using ExportLib;
using Authoration.LIB;


namespace ModuleHanhChinh.UI
{
    public partial class Form_HCReportExport : Telerik.WinControls.UI.RadForm
    {
        private FormMode _mode;
        public Form_HCReportExport(FormMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

       
        private void Export_HC_CongVanDi()
        {
            HC_CongVanDi_Coll listItem = HC_CongVanDi_Coll.GetHC_CongVanDi_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView, PTIdentity.IDNguoiDung));
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B004_BaoCaoCongVanDi cv = new ExportLib.Entities.HanhChinh.B004_BaoCaoCongVanDi();
            cv.ListCongVanDi = new List<ExportLib.Entities.HanhChinh.CongVanDi>();
            DateTime startDate = new DateTime(2050, 1, 1);
            DateTime endDate = new DateTime(1900, 1, 1);
            int count = 0;
            foreach (HC_CongVanDi_Info itemInfo in listItem)
            {
                ExportLib.Entities.HanhChinh.CongVanDi item = new ExportLib.Entities.HanhChinh.CongVanDi();
                try
                {
                    item.NgayNhan = (GlobalCommon.FixDate(Convert.ToDateTime(itemInfo.NgayGui))).ToShortDateString();
                }
                catch
                {
                }
                item.NoiGui = itemInfo.NoiGui;
                item.SoCongVan = itemInfo.SoCongVan;
                item.VeViec = itemInfo.VeVanDe;
                item.ViTriLuu = itemInfo.LuuTruTai;
                if (0 == 0)
                {
                    try
                    {
                        startDate = GlobalCommon.CompareDate_Earlier(Convert.ToDateTime(itemInfo.NgayGui), startDate);
                        endDate = GlobalCommon.CompareDate_Later(Convert.ToDateTime(itemInfo.NgayGui), endDate);
                    }
                    catch
                    {
                    }
                }

                cv.ListCongVanDi.Add(item);
                count++;

            }
            cv.NgayBatDau = GlobalCommon.FixDate_Return(startDate);
            cv.NgayKetThuc = GlobalCommon.FixDate_Return(endDate);
            //cv.TongSoCongVanDen = count.ToString();
            cv.NgayLapBaoCao = GlobalCommon.BC_HaNoiNgayThangNam(DateTime.Now);
            cv.NguoiLapBaoCao = PTIdentity.FullName;
            ex.B004_BaoCaoCongVanDi(cv);
        }
        private void Export_HC_CongVanDen()
        {
            HC_CongVanDi_Coll listItem = HC_CongVanDi_Coll.GetHC_CongVanDi_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition, PTIdentity.IDNguoiDung));
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B003_BaoCaoCongVanDen cv = new ExportLib.Entities.HanhChinh.B003_BaoCaoCongVanDen();
            cv.ListCongVanDen = new List<ExportLib.Entities.HanhChinh.CongVanDen>();
            DateTime startDate = new DateTime(2050, 1, 1);
            DateTime endDate = new DateTime(1900, 1, 1);
            int count = 0;
            foreach (HC_CongVanDi_Info itemInfo in listItem)
            {

                ExportLib.Entities.HanhChinh.CongVanDen item = new ExportLib.Entities.HanhChinh.CongVanDen();
                try
                {
                    item.NgayNhan = (GlobalCommon.FixDate(Convert.ToDateTime(itemInfo.NgayGui))).ToShortDateString();
                }
                catch
                {
                }
                item.NoiGui = itemInfo.NoiGui;
                item.SoCongVan = itemInfo.SoCongVan;
                item.VeViec = itemInfo.VeVanDe;
                item.ViTriLuu = itemInfo.LuuTruTai;
                if (0 == 0)
                {
                    try
                    {
                        startDate = GlobalCommon.CompareDate_Earlier(Convert.ToDateTime(itemInfo.NgayGui), startDate);
                        endDate = GlobalCommon.CompareDate_Later(Convert.ToDateTime(itemInfo.NgayGui), endDate);
                    }
                    catch
                    {
                    }
                }

                cv.ListCongVanDen.Add(item);
                count++;

            }
            cv.NgayBatDau = GlobalCommon.FixDate_Return(startDate);
            cv.NgayKetThuc = GlobalCommon.FixDate_Return(endDate);
            cv.TongSoCongVanDen = count.ToString();
            cv.NgayLapBaoCao = GlobalCommon.BC_HaNoiNgayThangNam(DateTime.Now);
            cv.NguoiLapBaoCao = PTIdentity.FullName;
            ex.B003_BaoCaoCongVanDen(cv);
        }
        private void Export_HC_DangKiGiangDuongPhongHoc()
        {
            HC_GiangDuong_PhieuDangKi_Coll listItem = HC_GiangDuong_PhieuDangKi_Coll.GetHC_GiangDuong_PhieuDangKi_Coll();
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B005_BaoCaoDangKiGiangDuongPhongHoc cv = new ExportLib.Entities.HanhChinh.B005_BaoCaoDangKiGiangDuongPhongHoc();
            cv.ListDangKy = new List<ExportLib.Entities.HanhChinh.DangKy>();
            DateTime startDate = new DateTime(2050, 1, 1);
            DateTime endDate = new DateTime(1900, 1, 1);
            int count = 0;
            foreach (HC_GiangDuong_PhieuDangKi_Info itemInfo in listItem)
            {

                ExportLib.Entities.HanhChinh.DangKy item = new ExportLib.Entities.HanhChinh.DangKy();
                item.CanBoDangKy = itemInfo.NguoiGuiYeuCau;
                item.NoiDung = itemInfo.NoiDungSuDung;
                //item.YKienKhac = itemInfo.Khac;
                item.GDPH = itemInfo.ChuTri;
                if (0 == 0)
                {
                    try
                    {
                        startDate = GlobalCommon.CompareDate_Earlier(Convert.ToDateTime(itemInfo.NgayGuiPhieu), startDate);
                        endDate = GlobalCommon.CompareDate_Later(Convert.ToDateTime(itemInfo.NgayGuiPhieu), endDate);
                    }
                    catch
                    {
                    }
                }

                cv.ListDangKy.Add(item);
                count++;

            }
            cv.NgayBatDau = GlobalCommon.FixDate_Return(startDate);
            cv.NgayKetThuc = GlobalCommon.FixDate_Return(endDate);
            //cv.NgayLapDangKy = GlobalCommon.BC_HaNoiNgayThangNam(DateTime.Now);
            ex.B005_BaoCaoDangKiGiangDuongPhongHoc(cv);
        }
        private void Export_DuTruVanPhongPham()
        {
            HC_DuTruVanPhongPham_Coll listItem = HC_DuTruVanPhongPham_Coll.GetHC_DuTruVanPhongPham_Coll();
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B007_BaoCaoDuTruVanPhongPham cv = new ExportLib.Entities.HanhChinh.B007_BaoCaoDuTruVanPhongPham();
            cv.ListVanPhongPham = new List<ExportLib.Entities.HanhChinh.VanPhongPham>();
            DateTime startDate = new DateTime(2050, 1, 1);
            DateTime endDate = new DateTime(1900, 1, 1);
            int count = 0;
            foreach (HC_DuTruVanPhongPham_Info itemInfo in listItem)
            {

                ExportLib.Entities.HanhChinh.VanPhongPham item = new ExportLib.Entities.HanhChinh.VanPhongPham();
                item.DonVi = itemInfo.DonVi;
                ////item.SoLuongDuTru = itemInfo.SoLuongDuyet.ToString();
                ////item.VatTuSanPham = itemInfo.Ten;
                //if (0 == 0)
                //{
                //    try
                //    {
                //        startDate = GlobalCommon.CompareDate_Earlier(Convert.ToDateTime(itemInfo.NgayGuiPhieu), startDate);
                //        endDate = GlobalCommon.CompareDate_Later(Convert.ToDateTime(itemInfo.NgayGuiPhieu), endDate);
                //    }
                //    catch
                //    {
                //    }
                //}

                cv.ListVanPhongPham.Add(item);
                count++;

            }
            //cv.NgayBatDau = GlobalCommon.FixDate_Return(startDate);
            //cv.NgayKetThuc = GlobalCommon.FixDate_Return(endDate);
            cv.NgayLapBaoCao = GlobalCommon.BC_HaNoiNgayThangNam(DateTime.Now);
            ex.B007_BaoCaoDuTruVanPhongPham(cv);
        }
        private void Export_TrangThietBi()
        {
            HC_VatTuTaiSan_Coll listItem = HC_VatTuTaiSan_Coll.GetHC_VatTuTaiSan_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B010_BaoCaoTrangThietBi cv = new ExportLib.Entities.HanhChinh.B010_BaoCaoTrangThietBi();
            cv.ListTrangThietBi = new List<ExportLib.Entities.HanhChinh.TrangThietBi>();
            DateTime startDate = new DateTime(2050, 1, 1);
            DateTime endDate = new DateTime(1900, 1, 1);
            int count = 0;
            foreach (HC_VatTuTaiSan_Info itemInfo in listItem)
            {

                ExportLib.Entities.HanhChinh.TrangThietBi item = new ExportLib.Entities.HanhChinh.TrangThietBi();
                item.GhiChu = itemInfo.GhiChu;
                item.MaQuanLy = itemInfo.MaVatTu;
                item.NgayNhap = GlobalCommon.FixDate_Return(itemInfo.NgayNhap);
                item.Serial = itemInfo.SerialMay;
                item.TenThietBi = itemInfo.TenVatTu;
                item.ViTriDatThietBi = itemInfo.ViTriDatMay;
                item.Xuatsu = itemInfo.XuatXu;
                if (0 == 0)
                {
                    try
                    {
                        startDate = GlobalCommon.CompareDate_Earlier(Convert.ToDateTime(itemInfo.NgayNhap), startDate);
                        endDate = GlobalCommon.CompareDate_Later(Convert.ToDateTime(itemInfo.NgayNhap), endDate);
                    }
                    catch
                    {
                    }
                }

                cv.ListTrangThietBi.Add(item);
                count++;

            }
            cv.NgayBatDau = GlobalCommon.FixDate_Return(startDate);
            cv.NgayKetThuc = GlobalCommon.FixDate_Return(endDate);
            //cv.NgayLapDangKy = GlobalCommon.BC_HaNoiNgayThangNam(DateTime.Now);
            ex.B010_BaoCaoTrangThietBi(cv);
        }

        private void Form_HCReportExport_Load(object sender, EventArgs e)
        {
            if (_mode.Item != null)
            {
                CDTReport report = (CDTReport)_mode.Item;
                switch (report)
                {
                    case CDTReport.HC_CongVanDen:
                        Export_HC_CongVanDen();
                        break;
                    case CDTReport.HC_CongVanDi:
                        Export_HC_CongVanDi();
                        break;
                    case CDTReport.HC_DangKiGiangDuong:
                        Export_HC_DangKiGiangDuongPhongHoc();
                        break;
                    case CDTReport.HC_DuTruVanPhongPham:
                        Export_DuTruVanPhongPham();
                        break;
                    case CDTReport.HC_TrangThietBi:
                        Export_TrangThietBi();
                        break;
                    default: break;
                }
            }
            this.Close();
        }

    }
}
