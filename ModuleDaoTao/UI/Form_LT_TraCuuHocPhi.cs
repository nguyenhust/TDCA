using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleDaoTao.LIB;
using Authoration.LIB;
using ExportLib.Entities.DaoTao;
using ExportLib;
using CrystalDecisions.CrystalReports.Engine;


namespace ModuleDaoTao.UI
{
    public partial class Form_LT_TraCuuHocPhi : NETLINK.UI.Dictionary
    {
        #region variables

        

        DT_Lientuc_HocVienSearch objHocVienSearch;
        #endregion

        public Form_LT_TraCuuHocPhi(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;

            objHocVienSearch = new DT_Lientuc_HocVienSearch();
            bindingSourceHocVienSearch.DataSource = objHocVienSearch;
        }


        private void radGridViewHocVien_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.Column.Name == "DaDongHocPhi")
                {
                    DT_LienTuc_HocVien_Coll coll = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
                    coll.Save();

                }
            }
            catch (Exception ex)
            {
                radGridViewHocVien.CancelEdit();
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonTimKiem_Click(object sender, EventArgs e)
        {
            string malop = (string)dropDownLopHocLienTuc.Selected_ID;
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
            objHocVienSearch.MaLop = malop;

            if (radCheckBoxChuaNopHocPhi.Checked)
            {
                if (radCheckBoxDaNopHocPhi.Checked)
                    objHocVienSearch.IsDongHocPhi = null;
                else
                    objHocVienSearch.IsDongHocPhi = false;
            }
            else {
                if (radCheckBoxDaNopHocPhi.Checked)
                    objHocVienSearch.IsDongHocPhi = true;
                else
                    objHocVienSearch.IsDongHocPhi = null;
            }

            objHocVienSearch.HinhThucHoc = string.Empty;
            if (radCheckBoxKemCap.Checked)
            {
                if (!radCheckBoxTheoLop.Checked)
                {
                    objHocVienSearch.HinhThucHoc = "Kèm cặp";
                    objHocVienSearch.MaLop = string.Empty;
                }
            }
            else {
                if (radCheckBoxTheoLop.Checked)
                    objHocVienSearch.HinhThucHoc = "Theo lớp";
                else
                    objHocVienSearch.HinhThucHoc = string.Empty;
            }

            function.Item = objHocVienSearch;
            function.ItemID = (int)PTIdentity.IDNguoiDung;
            bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
        }

        #region Override

        protected override void ApplyAuthorizationRules()
        {
            /*this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            btnContinue.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            HopDong_Activated(this, EventArgs.Empty);*/
        }

        protected override void FormLoad()
        {
            try
            {
                dropDownLopHocLienTuc.FillData();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (bindingSourceHocVien.DataSource != null)
            {
                DT_LienTuc_HocVien_Coll coll = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;

                foreach (var objHocvien in coll)
                {
                    /*G003_GiayDeNghiThuTienHocPhi denghithuhocphi = new G003_GiayDeNghiThuTienHocPhi();
                    DIC_ChuyenNganh_Coll lstchuyennganh = DIC_ChuyenNganh_Coll.GetDIC_ChuyenNganh_Coll();

                    denghithuhocphi.DiaDiemDangKy = objHocvien.ChuyenNganh;
                    denghithuhocphi.GioiTinh = objHocvien.GioiTinh;
                    denghithuhocphi.HocPhiThang = objHocvien.TongHocPhi;
                    denghithuhocphi.HoTenHocVien = objHocvien.HoTen;
                    denghithuhocphi.NgaySinh = objHocvien.NgaySinh;
                    DateTime date = DateTime.Now;
                    denghithuhocphi.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
                    denghithuhocphi.NoiCongTac = objHocvien.NoiCongTac;
                    
                    denghithuhocphi.TongTienHocPhi = objHocvien.TongHocPhi;
                    denghithuhocphi.SoThangHoc = "3 tháng";
                    denghithuhocphi.TrinhDo = objHocvien.TrinhDo;
                    denghithuhocphi.NoiDungHoc = objHocvien.NoiDungDaoTao;
                    ExportDaoTao daotao = new ExportDaoTao();
                    ReportDocument doc = daotao.G003_GiayDeNghiThuTienHocPhi(denghithuhocphi);

                    FormMode newmode = new FormMode();
                    newmode.Item = doc;
                    NetLinkReport fr = new NetLinkReport(newmode);
                    fr.Show();*/
                    G003_GiayDeNghiThuTienHocPhi denghithuhocphi = new G003_GiayDeNghiThuTienHocPhi();
                    denghithuhocphi.DiaDiemDangKy = objHocvien.TenChuyenNganh;
                    denghithuhocphi.GioiTinh = objHocvien.GioiTinh;

                    double month = 0;
                    string TongHopPhiStr = string.Empty;
                    if (objHocvien.HinhThucHoc.CompareTo("Theo lớp") == 0) 
                    {
                        if (string.IsNullOrEmpty(objHocvien.MaLopHoc))
                        {
                            GlobalCommon.ShowErrorMessager("Học viên chưa được xếp lớp!");
                            return;
                        }
                        DT_LienTuc_LopHoc lophoc = DT_LienTuc_LopHoc.GetDT_LienTuc_LopHoc(objHocvien.MaLopHoc);
                        if (lophoc == null)
                        {
                            GlobalCommon.ShowErrorMessager("Lớp học không tồn tại!");
                            return;
                        }

                        DateTime startDate = System.Convert.ToDateTime(lophoc.NgayBatDau);
                        DateTime endDate = System.Convert.ToDateTime(lophoc.NgayKetThuc);
                        month = GlobalCommon.TotalMonths(startDate, endDate);
                        TongHopPhiStr = lophoc.HocPhi;
                    }
                    else if (objHocvien.HinhThucHoc.CompareTo("Kèm cặp") == 0)
                    {

                        DateTime startDate = System.Convert.ToDateTime(objHocvien.NgayBatDau);
                        DateTime endDate = System.Convert.ToDateTime(objHocvien.NgayKetThuc);
                        month = GlobalCommon.TotalMonths(startDate, endDate);
                        TongHopPhiStr = objHocvien.TongHocPhi;
                    }
                   
                   
                    denghithuhocphi.HoTenHocVien = objHocvien.HoTen;
                    denghithuhocphi.NgaySinh = objHocvien.NgaySinh;
                    DateTime date = DateTime.Now;
                    denghithuhocphi.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
                    denghithuhocphi.NoiCongTac = objHocvien.NoiCongTac;
                    if (!string.IsNullOrEmpty(TongHopPhiStr))
                    {
                        TongHopPhiStr = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(Convert.ToInt64(TongHopPhiStr)) + " VNĐ";
                        denghithuhocphi.BangChu = GlobalCommon.StringProcess.NumberToString.ConvertToString(Convert.ToInt64(TongHopPhiStr)) + " VNĐ";
                    }
                    else
                    {
                        TongHopPhiStr = "0 VNĐ";
                        denghithuhocphi.BangChu = "";
                    }
                    denghithuhocphi.TongTienHocPhi = TongHopPhiStr;
                   // denghithuhocphi.SoThangHoc = month.ToString();
                    denghithuhocphi.TrinhDo = objHocvien.TenTrinhDo;
                    denghithuhocphi.NoiDungHoc = objHocvien.NoiDungDaoTao;
                    ExportDaoTao daotao = new ExportDaoTao();

                    ReportDocument doc = daotao.G003_GiayDeNghiThuTienHocPhi(new List<ExportLib.Entities.DaoTao.G003_GiayDeNghiThuTienHocPhi>(){denghithuhocphi});
                    FormMode newmode = new FormMode();
                    newmode.Item = doc;
                    NetLinkReport fr = new NetLinkReport(newmode);
                    fr.Show();
                }
            }
        }
    }
}
