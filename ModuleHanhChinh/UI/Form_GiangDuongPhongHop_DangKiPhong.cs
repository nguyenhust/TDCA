using NETLINK.LIB;
using DanhMuc.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleHanhChinh.LIB;
using Authoration.LIB;
using ExportLib;
using CrystalDecisions.CrystalReports.Engine;
using NETLINK.UI;

namespace ModuleHanhChinh.UI
{
    public partial class Form_GiangDuongPhongHop_DangKiPhong : NETLINK.UI.Dictionary
    {
        
        private HC_GiangDuong_PhieuDangKi item;
        private int selectedID;
        private int Expand = 955;
        private int Normal = 512;
        public Form_GiangDuongPhongHop_DangKiPhong(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            txtTuNgay.MyName = "Từ ngày";
            txtDenNgay.MyName = "Đến ngày";
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_GiangDuong_Phong_Edit, TextMessages.RolePermission.HC_GiangDuong_Phong_Insert });
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave())
                {
                    BindData(false);
                    item.IdPhong = Convert.ToInt32(dropDownGiangDuong.Selected_ID);
                    item.DaDuocDuyet = false;
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Đăng kí giảng đường ID số:" + item.IdPhong);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    PrintPhieu();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void FormLoad()
        {
            try
            {
                if (formMode.IsInsert)
                {
                    item = HC_GiangDuong_PhieuDangKi.NewHC_GiangDuong_PhieuDangKi();
                    printButton1.Enabled = false;
                }
                else
                {
                    item = HC_GiangDuong_PhieuDangKi.GetHC_GiangDuong_PhieuDangKi(formMode.Id);
                    printButton1.Enabled = true;
                }
                radBindingSourceMain.DataSource = item;
                dropDownGiangDuong.FillData();
                BindData(true);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void BindData(bool isLoad)
        {
            if (item != null)
            {
                if (isLoad)
                {
                    groupTrangThaiYeuCau.Visible = false;
                    this.Width = Normal;
                    if (formMode.IsEdit)
                    {
                       // groupTrangThaiYeuCau.Visible = true;
                       // this.Width = Expand;
                    }
                    radcbBangButViet.Checked = Convert.ToBoolean(item.BangButViet);
                    radcbBanhKeo.Checked = Convert.ToBoolean(item.BanhKeo);
                    radcbButLazer.Checked = Convert.ToBoolean(item.ButLazer);
                    radcbHoaTuoi.Checked = Convert.ToBoolean(item.HoaTuoi);
                    radcbKhanTraiBan.Checked = Convert.ToBoolean(item.KhanTraiBan);
                    radcbManChieu.Checked = Convert.ToBoolean(item.ManChieu);
                    radcbMayChieu.Checked = Convert.ToBoolean(item.MayChieu);
                    radcbMicro.Checked = Convert.ToBoolean(item.Micro);
                    radcbNuocChoGiangVien.Checked = Convert.ToBoolean(item.NuocChoGiangVien);
                    radcbNuocChoHV.Checked = Convert.ToBoolean(item.NuocChoHocVien);
                    radcbPhongHoiTruong.Checked = Convert.ToBoolean(item.PhongHoiTruong);
                    radcbTraiCay.Checked = Convert.ToBoolean(item.TraiCay);
                    txtKhac.Text = item.Khac;
                    txtNoiDung.Text = item.NoiDungSuDung;
                    txtChuTri.Text = item.ChuTri;
                    txtLyDo.Text = item.LyDoDuyet;
                    txtNguoiThamGia.Text = item.SoNguoiThamGia.ToString();
                    txtNguoiYeuCau.Text = item.NguoiGuiYeuCau;
                    txtTrangThaiYeuCau.Text = item.TrangThaiDuyet;
                    txtTuNgay.Value_String = item.NgayBatDau == "" ? item.NgayBatDau : Convert.ToDateTime(item.NgayBatDau).ToString("dd/MM/yyyy");
                    txtDenNgay.Value_String = item.NgayKetThuc == "" ? item.NgayKetThuc : Convert.ToDateTime(item.NgayKetThuc).ToString("dd/MM/yyyy");
                    radTimeTu.Value = item.GioBatDau;
                    radTimeDen.Value = item.GioKetThuc;
                    dropDownGiangDuong.Selected_ID = item.IdPhong;
                    

                }
                else
                {
                    item.BangButViet = radcbBangButViet.Checked;
                    item.BanhKeo = radcbBanhKeo.Checked;
                    item.ButLazer = radcbButLazer.Checked;
                    item.HoaTuoi = radcbHoaTuoi.Checked;
                    item.KhanTraiBan = radcbKhanTraiBan.Checked;
                    item.ManChieu = radcbManChieu.Checked;
                    item.MayChieu = radcbMayChieu.Checked;
                    item.Micro = radcbMicro.Checked;
                    item.NuocChoGiangVien = radcbNuocChoGiangVien.Checked;
                    item.NuocChoHocVien = radcbNuocChoHV.Checked;
                    item.PhongHoiTruong = radcbPhongHoiTruong.Checked;
                    item.TraiCay = radcbTraiCay.Checked;
                    item.Khac = txtKhac.Text;
                    item.NoiDungSuDung = txtNoiDung.Text;
                    item.ChuTri = txtChuTri.Text;
                    if (!string.IsNullOrEmpty(txtNguoiThamGia.Text))
                        item.SoNguoiThamGia = Convert.ToInt32(txtNguoiThamGia.Text);
                    item.NguoiGuiYeuCau = txtNguoiYeuCau.Text;
                    if (formMode.IsInsert)
                    {
                        item.IdNguoiGuiYeuCau = PTIdentity.IDNguoiDung;
                    }
                    if (dropDownGiangDuong.Selected_ID != null)
                        item.IdPhong = Convert.ToInt32(dropDownGiangDuong.Selected_ID);
                    item.NgayBatDau = txtTuNgay.Value_String == "" ? txtTuNgay.Value_String : Convert.ToDateTime(txtTuNgay.Value_String, new System.Globalization.CultureInfo("vi-VN")).ToShortDateString();
                    item.NgayKetThuc = txtDenNgay.Value_String == "" ? txtDenNgay.Value_String : Convert.ToDateTime(txtDenNgay.Value_String, new System.Globalization.CultureInfo("vi-VN")).ToShortDateString();
                    item.GioBatDau = radTimeTu.Value;
                    item.GioKetThuc = radTimeDen.Value;
                    if (formMode.IsInsert)
                        item.NgayGuiPhieu = DateTime.Now.ToShortDateString();
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!txtTuNgay.isDateTime && !txtTuNgay.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtTuNgay.Value_Error);
                return false;
            }
            if (!txtDenNgay.isDateTime && !txtDenNgay.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtDenNgay.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { txtDenNgay.Value_String, txtTuNgay.Value_String, txtNguoiYeuCau.Text, txtNoiDung.Text, dropDownGiangDuong.Selected_TextValue.ToString() }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(txtDenNgay.Value_String, txtTuNgay.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, txtDenNgay.MyName, txtTuNgay.MyName));
                return false;
            }
            if (!string.IsNullOrEmpty(txtNguoiThamGia.Text) && !GlobalCommon.CheckIsNumber(txtNguoiThamGia.Text))
            {
                GlobalCommon.ShowErrorMessager("Số người tham gia bắt buộc là số");
                return false;
            }
            return true;
        }
        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radLabel6_Click(object sender, EventArgs e)
        {

        }

        private void printButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PrintPhieu();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void PrintPhieu()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.P005_PhieuDangKiGiangDuongPhongHoc cv = new ExportLib.Entities.HanhChinh.P005_PhieuDangKiGiangDuongPhongHoc();
            cv.CanBoDangKy = item.NguoiGuiYeuCau;
            cv.CanBoQuanLy = string.Empty;
            cv.NguoiChuTri = item.ChuTri;
            
            cv.NoiDungSuDung = item.NoiDungSuDung;
            if (dropDownGiangDuong.Selected_Item != null)
            {
                HC_GiangDuong_Phong_Info phongItem = (HC_GiangDuong_Phong_Info)dropDownGiangDuong.Selected_Item;
                cv.PhongDangKy = string.Format("{0} ( {1} )", phongItem.TenPhong, phongItem.DiaDiem);
            }
            cv.SoNguoiThamDu = item.SoNguoiThamGia.ToString();
            cv.ThoiGianSuDung = string.Format("{0} đến {2} - từ {1} đến {3}", item.GioBatDau.ToString("HH:mm"), item.NgayBatDau, item.GioKetThuc.ToString("HH:mm"), item.NgayKetThuc);
            cv.YeuCauKhac = item.Khac;
            cv.ThoiGianNhap = GlobalCommon.BC_NgayThangNam(GlobalCommon.GetTimeServer());
            
            ReportDocument doc = ex.P005_PhieuDangKiGiangDuongPhongHoc(cv);
            doc.SetParameterValue("nuoc_gv",item.NuocChoGiangVien == true? "X" : "");
            doc.SetParameterValue("nuoc_hv", item.NuocChoHocVien == true ? "X" : "");
            doc.SetParameterValue("hoatuoi", item.HoaTuoi == true ? "X" : "");
            doc.SetParameterValue("traicay", item.TraiCay == true ? "X" : "");
            doc.SetParameterValue("banhkeo", item.BanhKeo == true ? "X" : "");
            doc.SetParameterValue("khantraiban", item.KhanTraiBan == true ? "X" : "");
            doc.SetParameterValue("phonghoitruong", item.PhongHoiTruong == true ? "X" : "");
            doc.SetParameterValue("micro", item.Micro == true ? "X" : "");
            doc.SetParameterValue("manchieu", item.ManChieu == true ? "X" : "");
            doc.SetParameterValue("maychieu", item.MayChieu == true ? "X" : "");
            doc.SetParameterValue("bangbutviet", item.BangButViet == true ? "X" : "");
            doc.SetParameterValue("butlaze", item.ButLazer == true ? "X" : "");
            FormMode newmode = new FormMode();
            newmode.Item = doc;
            NetLinkReport fr = new NetLinkReport(newmode);
            fr.Show();
        }
    }
}
