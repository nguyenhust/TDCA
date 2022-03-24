using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI;
using NETLINK.LIB;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using System.IO;
using System.Diagnostics;
using Authoration.LIB;
using ModuleChiDaoTuyen.LIB;

namespace ModuleChiDaoTuyen.UI
{
    public partial class CanBoNhanCGKT : Dictionary
    {
        private CDT_CanBoNhanCGKT item;
        private CDT_HopDongCGKT itemCGKT;
        public CanBoNhanCGKT(FormMode _formMode)
        {
            InitializeComponent();
            AbatDau.MyName = "Ngày bắt đầu";
            bbatdau.MyName = "Ngày bắt đầu";
            Aketthuc.MyName = "Ngày kết thúc";
            bketthuc.MyName = "Ngày kết thúc";
            ngaysinh.MyName = "Ngày sinh";
            ngaycap.MyName = "Ngày cấp";
            this.formMode = _formMode;
            ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.CDT_HopDongKyThuat_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.CDT_HopDongKyThuat_Edit });
        
           // btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_BaiViet_Insert, TextMessages.RolePermission.TT_BaiViet_Edit });
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "CDT - Can Bo Nhan CGKT" + this.Text);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
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
                dropDownBenhVien1.FillData(1);
                dropDownChucVu1.FillData(1);
                dropDownChuyenNganh1.FillData(1);
                dropDownTrinhDo1.FillData(1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = CDT_CanBoNhanCGKT.GetCDT_CanBoNhanCGKT(formMode.Id);
                }
                else
                {
                    item = CDT_CanBoNhanCGKT.NewCDT_CanBoNhanCGKT();
                }
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
                    if (formMode.Item != null)
                    {
                        itemCGKT = (CDT_HopDongCGKT)formMode.Item;
                        radtxtMaHopDong.Text = itemCGKT.MaHopDong;
                        dropDownHopDongGoiKyThuat1.FillData(itemCGKT.ID);

                        GroupA.Text = string.Format("Chuyển giao tại {0}", itemCGKT.TenBenhVienA);
                        GroupB.Text = string.Format("Chuyển giao tại {0}", itemCGKT.TenBenhVienB);
                    }
                    else
                    {
                        GroupA.Text = "Chuyển giao tại bệnh viện A";
                        GroupB.Text = "Chuyển giao tại bệnh viện B";
                        radtxtMaHopDong.Text = item.TenMaHopDong;
                        if (item.IdHopDong != null)
                            dropDownHopDongGoiKyThuat1.FillData(Convert.ToInt32(item.IdHopDong));
                    }
                    dropDownChucVu1.Selected_ID = item.IdChucVu;
                    dropDownTrinhDo1.Selected_ID = item.IdTrinhDo;
                    if (item.IdHopDong != null)
                        dropDownHopDongGoiKyThuat1.Selected_IDGoiKT = item.IDHopDong_GoiKT;
                    dropDownBenhVien1.Selected_ID = item.IdBenhVien;
                    dropDownChuyenNganh1.Selected_ID = item.IdChuyenNganh;
                    txtCMT.Text = item.SoCMT;
                    txtDanhGiaTruocCG.Text = item.DiemTruocCG.ToString();
                    txtDiemChuyenGiaoA.Text = item.DiaDiemChuyenGiaoA;
                    txtDiemChuyenGiaoB.Text = item.DiaDiemChuyenGiaoB;
                    txtDiemLT.Text = item.Diem01.ToString();
                    txtDiemSauCG.Text = item.DiemSauCG.ToString();
                    txtDiemTH.Text = item.Diem02.ToString();
                    txtHinhThucHoc.Text = item.HinhThucHoc;
                    txtGhiChu.Text = item.GhiChu;
                    txtHoTen.Text = item.HoTen;
                    txtEmail.Text = item.Email;
                    txtDienThoai.Text = item.DienThoai;
                    txtLyDoKetLuan.Text = item.KetLuan_LyDo;
                    txtNamTotNghiep.Text = item.NamTotNghiep.ToString();
                    txtNoiDungHoc.Text = item.NoiDungHoc;
                    txtSoBang.Text = item.SoBang;
                    SoLanThucHanhKT.Text = item.SoLanThucHanhKT.ToString();
                    txtTruongTotNghiep.Text = item.TruongTotNghiep;
                    txtNoiCap.Text = item.NoiCap;
                    AbatDau.Value_String = item.A_NgayBatDau;
                    bbatdau.Value_String = item.B_NgayBatDau;
                    bketthuc.Value_String = item.B_NgayKetThuc;
                    Aketthuc.Value_String = item.A_NgayKetThuc;
                    ngaycap.Value_String = item.NgayCap;
                    ngaysinh.Value_String = item.Ngaysinh;
                    if (item.KetLuan == "Đạt")
                        rcDat.IsChecked = true;
                    else
                        rcChuaDat.IsChecked = true;
                }
                else
                {
                    if (formMode.IsInsert)
                    {
                        item.IdHopDong = itemCGKT.ID;
                    }
                    if (dropDownChucVu1.Selected_ID != null)
                        item.IdChucVu = Convert.ToInt32(dropDownChucVu1.Selected_ID);
                    if (dropDownTrinhDo1.Selected_ID != null)
                        item.IdTrinhDo = Convert.ToInt32(dropDownTrinhDo1.Selected_ID);
                    if (dropDownHopDongGoiKyThuat1.Selected_ID != null)
                        item.IDHopDong_GoiKT = Convert.ToInt32(dropDownHopDongGoiKyThuat1.Selected_IDGoiKT);
                    if (dropDownBenhVien1.Selected_ID != null)
                        item.IdBenhVien = Convert.ToInt64(dropDownBenhVien1.Selected_ID);
                    if (dropDownChuyenNganh1.Selected_ID != null)
                        item.IdChuyenNganh = Convert.ToInt32(dropDownChuyenNganh1.Selected_ID);
                    item.SoCMT = txtCMT.Text;
                    if (!string.IsNullOrEmpty(txtDanhGiaTruocCG.Text))
                        item.DiemTruocCG = Convert.ToInt32(txtDanhGiaTruocCG.Text);
                    item.DiaDiemChuyenGiaoA = txtDiemChuyenGiaoA.Text;
                    item.DiaDiemChuyenGiaoB = txtDiemChuyenGiaoB.Text;
                    if (!string.IsNullOrEmpty(txtDiemLT.Text))
                        item.Diem01 = Convert.ToInt32(txtDiemLT.Text);
                    if (!string.IsNullOrEmpty(txtDiemSauCG.Text))
                        item.DiemSauCG = Convert.ToInt32(txtDiemSauCG.Text);
                    if (!string.IsNullOrEmpty(txtDiemTH.Text))
                        item.Diem02 = Convert.ToInt32(txtDiemTH.Text);
                    item.HinhThucHoc = txtHinhThucHoc.Text;
                    item.GhiChu = txtGhiChu.Text;
                    item.HoTen = txtHoTen.Text;
                    item.Email = txtEmail.Text;
                    item.DienThoai = txtDienThoai.Text;
                    item.KetLuan_LyDo = txtLyDoKetLuan.Text;
                    if (!string.IsNullOrEmpty(txtNamTotNghiep.Text))
                        item.NamTotNghiep = Convert.ToInt32(txtNamTotNghiep.Text);
                    item.NoiDungHoc = txtNoiDungHoc.Text;
                    item.SoBang = txtSoBang.Text;
                    if (!string.IsNullOrEmpty(SoLanThucHanhKT.Text))
                        item.SoLanThucHanhKT = Convert.ToInt32(SoLanThucHanhKT.Text);
                    item.TruongTotNghiep = txtTruongTotNghiep.Text;
                    item.NoiCap = txtNoiCap.Text;
                    item.A_NgayBatDau = AbatDau.Value_String;
                    item.B_NgayBatDau = bbatdau.Value_String;
                    item.B_NgayKetThuc = bketthuc.Value_String;
                    item.A_NgayKetThuc = Aketthuc.Value_String;
                    item.NgayCap = ngaycap.Value_String;
                    item.Ngaysinh = ngaysinh.Value_String;
                    if (rcDat.IsChecked)
                        item.KetLuan = "Đạt";
                    else
                        item.KetLuan = "Chưa Đạt";
                    item.DiemSauCG = CaculateDiem();
                    item.LastEdited_Date = DateTime.Now;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                }
            }
        }
        private int CaculateDiem()
        {
            int DiemLT = 0;
            int DiemTH = 0;
            int.TryParse(txtDiemLT.Text, out DiemLT);
            int.TryParse(txtDiemTH.Text, out DiemTH);
            if (DiemLT == 0 && DiemTH == 0)
            {
                return 0;
            }
            else if(DiemLT == 0)
            {
                return DiemTH;
            }
            else if (DiemTH == 0)
            {
                return DiemLT;
            }
            else
            {
                return Convert.ToInt32((DiemLT + DiemTH) / 2);
            }
        }
        private void ProcessDiem()
        {
            int diem = CaculateDiem();
            if (diem < 5)
                rcChuaDat.IsChecked = true;
            else
                rcDat.IsChecked = true;
        }

        private bool ValidateDataBeforeSave()
        {
            if (!AbatDau.isDateTime && !AbatDau.isNull)
            {
                GlobalCommon.ShowErrorMessager(AbatDau.Value_Error);
                return false;
            }
            if (!bbatdau.isDateTime && !bbatdau.isNull)
            {
                GlobalCommon.ShowErrorMessager(bbatdau.Value_Error);
                return false;
            }
            if (!bketthuc.isDateTime && !bketthuc.isNull)
            {
                GlobalCommon.ShowErrorMessager(bketthuc.Value_Error);
                return false;
            }
            if (!Aketthuc.isDateTime && !Aketthuc.isNull)
            {
                GlobalCommon.ShowErrorMessager(Aketthuc.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] {ngaysinh.Text, txtHoTen.Text, dropDownBenhVien1.Selected_TextValue,dropDownHopDongGoiKyThuat1.Selected_TextValue, dropDownTrinhDo1.Selected_TextValue }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!string.IsNullOrEmpty(txtDienThoai.Text) && !GlobalCommon.Check_MustHasANumber(txtDienThoai.Text))
            {
                GlobalCommon.ShowErrorMessager("Định dạng điện thoại sai");
                return false;
            }
            if (!string.IsNullOrEmpty(txtEmail.Text) && !GlobalCommon.CheckEmail(txtEmail.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangEmailSai);
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(Aketthuc.Value_String, AbatDau.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, Aketthuc.MyName, AbatDau.MyName));
                return false;
            }
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(bketthuc.Value_String, bbatdau.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, bketthuc.MyName, bbatdau.MyName));
                return false;
            }
            return true;
        }

        private void txtDiemLT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (GlobalCommon.IsNumber(txtDiemLT.Text))
                {
                    ProcessDiem();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void txtDiemTH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (GlobalCommon.IsNumber(txtDiemTH.Text))
                {
                    ProcessDiem();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
