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

namespace ModuleDaoTao.UI
{
    public partial class Form_CQ_HocVienChinhQuy : NETLINK.UI.Dictionary
    {
        #region variables

        
        private DT_ChinhQuy_HocVien item;
        private int selectedID = -1;

        #endregion

        public Form_CQ_HocVienChinhQuy(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            txtcapngay.MyName = "Ngày cấp CMT";
            txtngaydk.MyName = "Ngày đăng kí";
            txtngaysinh.MyName = "Ngày sinh";

        }

    

        #region loading and binding data



        // dành cho fill dữ liệu save
        private void BindData(bool isLoad)
        {
            if (isLoad)
            {
                txtHoTen.Text = item.HoTen;
                //DateTime ns = Convert.ToDateTime(item.NgaySinh);
                //txtngaysinh.Value_String = ns.ToString("dd/MM/yyyy");
                txtngaysinh.Value_String = item.NgaySinh;
                txtsocmt.Text = item.SoCMT;
                txtMaHV.Text = item.MaHocVien;
                dropDownGioiTinh1.SelectedText = item.GioiTinh;
                txtnamtotnghiep.Text = item.NamTotNghiep.ToString();
                txtsobang.Text = item.SoBang;
                txtnoicongtac.Text = item.NoiCongTac;
                txtnharieng.Text = item.DiaChiNhaRieng;
                txtNoiSinh.Text = item.DienThoaiNhaRieng;
                txtdtdd.Text = item.DiDong;
                txtemail.Text = item.Email;
                txtcapngay.Value_String = item.NgayCapCMT;
                txtcaptai.Text = item.NoiCapCMT;
                txtngaydk.Value_String = item.NgayDangKi;
                txtNoiSinh.Text = item.NoiSinh;
                checkMienThi1.Checked = item.MienThi1;
                checkMienThi2.Checked = item.MienThi2;
                checkMienThi3.Checked = item.MienThi3;
                checkMienThi4.Checked = item.MienThi4;
                checkMienThi5.Checked = item.MienThi5;
                txtdantoc.Text = item.DanToc;
                txttongiao.Text = item.TonGiao;
                txtqhgd.Text = item.QuanHeGiaDinh;
                txtlydo.Text = item.LyDoKhongDuocThiLai;
                radRadioButton1.IsChecked = Convert.ToBoolean(item.DuocPhepThiLai);
                dropDownTrinhDo1.Selected_ID = item.IdTrinhDo;
                dropDownChuyenNganh1.Selected_ID = item.IdChuyenNganh;
                dropDownGioiTinh1.Text = item.GioiTinh;
                if (formMode.IsInsert)
                {
                    txtmon1.Text = "Chuyên ngành";
                    txtdiem1.Text = "0";
                    txtdiem2.Text = "0";
                    txtmon2.Text = "Cơ sở";
                    txtdiem2.Text = "0";
                    txtmon3.Text = string.Empty;
                    txtdiem3.Text = "0";
                    txtmon4.Text = string.Empty;
                    txtdiem4.Text = "0";
                    txtmon5.Text = string.Empty;
                    txtdiem5.Text = "0";
                    txtmon6.Text = "Tổng điểm";
                    txtdiem6.Text = "0";
                    radRadioButton1.IsChecked = true;
                    
                }
                else
                {
                    txtmon1.Text = item.DauVaoMon1;
                    txtdiem1.Text = item.DauVaoDiem1.ToString();
                    txtmon2.Text = item.DauVaoMon2;
                    txtdiem2.Text = item.DauVaoDiem2.ToString();
                    txtmon3.Text = item.DauVaoMon3;
                    txtdiem3.Text = item.DauVaoDiem3.ToString();
                    txtmon4.Text = item.DauVaoMon4;
                    txtdiem4.Text = item.DauVaoDiem4.ToString();
                    txtmon5.Text = item.DauVaoMon5;
                    txtdiem5.Text = item.DauVaoDiem5.ToString();
                    txtmon6.Text = item.DauVaoMon6;
                    txtdiem6.Text = item.DauVaoDiem6.ToString();
                    
                }
                if (item.CapDoDuTuyen == DT_Common.CQ_LoaiDT_BSNT)
                {
                    txtRadioBSNT.IsChecked = true;
                }
                else if (item.CapDoDuTuyen == DT_Common.CQ_LoaiDT_CKII)
                {
                    txtRadioCKII.IsChecked = true;
                }
                else
                {
                    txtRadioCKI.IsChecked = true;
                }
                txtKhoa.Text = item.KhoaDuTuyen;
                txtNam.Text = item.NamDuTuyen.ToString();
                txtSBD.Text = item.SBD;
                dropDownChuyenNganh2.Selected_ID = item.IdChuyenNganhDuThi;
                txtdiem1.Text = item.MienThi1 == true ? "Miễn thi" : txtdiem1.Text;
                txtdiem2.Text = item.MienThi2 == true ? "Miễn thi" : txtdiem2.Text;
                txtdiem3.Text = item.MienThi3 == true ? "Miễn thi" : txtdiem3.Text;
                txtdiem4.Text = item.MienThi4 == true ? "Miễn thi" : txtdiem4.Text;
                txtdiem5.Text = item.MienThi5 == true ? "Miễn thi" : txtdiem5.Text;
            }
            else
            {
                item.MienThi1 = checkMienThi1.Checked;
                item.MienThi2 = checkMienThi2.Checked;
                item.MienThi3 = checkMienThi3.Checked;
                item.MienThi4 = checkMienThi4.Checked;
                item.MienThi5 = checkMienThi5.Checked;
                item.NoiSinh = txtNoiSinh.Text;
                item.HoTen = txtHoTen.Text;
                item.NgaySinh = txtngaysinh.Value_String;
                item.SoCMT = txtsocmt.Text;
                item.MaHocVien = txtMaHV.Text;
                item.GioiTinh = dropDownGioiTinh1.SelectedText;
                if (dropDownTrinhDo1.Selected_ID != null)
                    item.IdTrinhDo = Convert.ToInt64(dropDownTrinhDo1.Selected_ID);
                if (dropDownChuyenNganh1.Selected_ID != null)
                    item.IdChuyenNganh = Convert.ToInt32(dropDownChuyenNganh1.Selected_ID);
                if (!string.IsNullOrEmpty(txtnamtotnghiep.Text))
                    item.NamTotNghiep = Convert.ToInt32(txtnamtotnghiep.Text);
                item.SoBang = txtsobang.Text;
                item.NoiCongTac = txtnoicongtac.Text;
                item.DiaChiNhaRieng = txtnharieng.Text;
                item.DienThoaiNhaRieng = txtNoiSinh.Text;
                item.DiDong = txtdtdd.Text;
                item.Email = txtemail.Text;
                item.NgayCapCMT = txtcapngay.Value_String;
                item.NoiCapCMT = txtcaptai.Text;
                item.NgayDangKi = txtngaydk.Value_String;
                if (txtRadioBSNT.IsChecked)
                {
                    item.DauVaoMon3 = txtmon3.Text;
                    item.DauVaoDiem3 = ValidCheck.SetNumber(txtdiem3.Text);
                    item.DauVaoMon4 = txtmon4.Text;
                    item.DauVaoDiem4 = ValidCheck.SetNumber(txtdiem4.Text);
                    item.DauVaoMon5 = txtmon5.Text;
                    item.DauVaoDiem5 = ValidCheck.SetNumber(txtdiem5.Text);
                    item.CapDoDuTuyen = DT_Common.CQ_LoaiDT_BSNT;
                }
                else if (txtRadioCKI.IsChecked)
                {
                    item.CapDoDuTuyen = DT_Common.CQ_LoaiDT_CKI;
                }
                else
                {
                    item.CapDoDuTuyen = DT_Common.CQ_LoaiDT_CKII;
                }
                item.DauVaoMon1 = txtmon1.Text;
                item.DauVaoDiem1 = ValidCheck.SetNumber(txtdiem1.Text);
                item.DauVaoMon2 = txtmon2.Text;
                item.DauVaoDiem2 = ValidCheck.SetNumber(txtdiem2.Text);
                item.DauVaoMon6 = txtmon6.Text;
                item.DauVaoDiem6 = ValidCheck.SetNumber(txtdiem6.Text);
                if (dropDownChuyenNganh2.Selected_ID != null)
                    item.IdChuyenNganhDuThi = Convert.ToInt32(dropDownChuyenNganh2.Selected_ID);
                item.KhoaDuTuyen = txtKhoa.Text;
                if(!string.IsNullOrEmpty(txtNam.Text))
                item.NamDuTuyen = Convert.ToInt32(txtNam.Text);
                item.SBD = txtSBD.Text;
                item.DanToc = txtdantoc.Text;
                item.TonGiao = txttongiao.Text;
                item.QuanHeGiaDinh = txtqhgd.Text;
                item.DuocPhepThiLai = radRadioButton1.IsChecked;
                item.LyDoKhongDuocThiLai = txtlydo.Text;
                item.GioiTinh = dropDownGioiTinh1.Text;
            }
        }

        #endregion

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DT_CQ_HocVien_Insert, TextMessages.RolePermission.DT_CQ_HocVien_Edit });
        }

        protected override void FormLoad()
        {
            try
            {
                dropDownChuyenNganh1.FillData(1);
                dropDownChuyenNganh2.FillData(2);
                dropDownTrinhDo1.FillData(1);
                dropDownGioiTinh1.FillData();
                if (formMode.IsInsert) // thêm mới
                {
                    selectedID = 0;
                    item = DT_ChinhQuy_HocVien.NewDT_ChinhQuy_HocVien();
                }
                else // chỉnh sửa
                {
                    selectedID = formMode.Id;
                    item = DT_ChinhQuy_HocVien.GetDT_ChinhQuy_HocVien(selectedID);
                }
                BindData(true);
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                if (ValidateBeforeSave())
                { 
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Chính quy - hoc vien" + item.MaHocVien);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private bool ValidateBeforeSave()
        {
            if (!txtcapngay.isDateTime && !txtcapngay.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtcapngay.Value_Error);
                return false;
            }
            if (!txtngaydk.isDateTime && !txtngaydk.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtngaydk.Value_Error);
                return false;
            }
            if (!txtngaysinh.isDateTime && !txtngaysinh.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtngaysinh.Value_Error);
                return false;
            }
            if (!GlobalCommon.CheckIsNumber(txtnamtotnghiep.Text))
            {
                GlobalCommon.ShowErrorMessager("Năm tốt nghiệp phải là một số");
                return false;
            }
            if (!GlobalCommon.CheckIsNumber(txtNam.Text))
            {
                GlobalCommon.ShowErrorMessager("Năm dự thi phải là một số");
                return false;
            }
            if(checkMienThi1.Checked == false)
                if (!GlobalCommon.CheckIsDiem(new string[] { txtdiem1.Text == "Miễn thi" ? "0" : txtdiem1.Text, txtdiem2.Text == "Miễn thi" ? "0" : txtdiem2.Text, txtdiem3.Text == "Miễn thi" ? "0" : txtdiem3.Text, txtdiem4.Text == "Miễn thi" ? "0" : txtdiem4.Text, txtdiem5.Text == "Miễn thi" ? "0" : txtdiem5.Text }))
            {
                GlobalCommon.ShowErrorMessager("Điểm phải là số >=0 và <= 10");
                return false;
            }
            //if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtAnPham.Text, dropDownLoai1.Selected_TextValue, radMaskedEditBox1.Text, tungay.Value_String, denngay.Value_String }))
            //{
            //    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
            //    return false;
            //}
        
            return true;
        }

        #endregion

        #region business

        private void CaculateTotal()
        {
            double total = 0;
            double diem = 0;
            if (txtRadioBSNT.IsChecked)
            {
                if (double.TryParse(txtdiem1.Text, out diem))
                {
                    total += diem;
                    diem = 0;
                }
                if (double.TryParse(txtdiem2.Text, out diem))
                {
                    total += diem;
                    diem = 0;
                }
                if (double.TryParse(txtdiem3.Text, out diem))
                {
                    total += diem;
                    diem = 0;
                }
                if (double.TryParse(txtdiem4.Text, out diem))
                {
                    total += diem;
                    diem = 0;
                }
            }
            else
            {
                if (double.TryParse(txtdiem1.Text, out diem))
                {
                    total += diem;
                    diem = 0;
                }
                if (double.TryParse(txtdiem2.Text, out diem))
                {
                    total += diem;
                    diem = 0;
                }
            }
            txtdiem6.Text = total.ToString();
        }

        private void ChangeHiddenStatus()
        {
            if (txtRadioBSNT.IsChecked)
            {
                txtmon1.Text = "Toán thống kê";
                txtmon2.Text = "Cơ sở";
                txtmon3.Text = "Chuyên ngành 1";
                txtmon4.Text = "Chuyên ngành 2";
                txtmon5.Text = "Ngoại ngữ";
            }
            else
            {
                txtmon1.Text = "Chuyên ngành";
                txtmon2.Text = "Cơ sở";
                txtmon3.Text = string.Empty;
                txtmon4.Text = string.Empty;
                txtmon5.Text = string.Empty;
            }
            CaculateTotal();
           
        }


        #endregion

        #region form's events

        private void txtdiem1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CaculateTotal();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void txtdiem2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CaculateTotal();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void txtdiem3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CaculateTotal();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void txtdiem4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CaculateTotal();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void txtdiem5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CaculateTotal();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void txtRadioCKI_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                ChangeHiddenStatus();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
           
        }

        private void txtRadioCKII_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                ChangeHiddenStatus();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
          
        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                txtlydo.Visible = !radRadioButton1.IsChecked;
                radLabel26.Visible = !radRadioButton1.IsChecked;
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
          
        }



        private void radButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Form_CQ_TamTru fr = new Form_CQ_TamTru(new FormMode());
                fr.ShowDialog();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
          
          
        }

        #endregion

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkMienThi_CheckedChanged(object sender, EventArgs e)
        {
                txtdiem1.Enabled = checkMienThi1.Checked == true ? false : true;
                txtdiem1.Text = checkMienThi1.Checked == true ? "Miễn thi" : txtdiem1.Text == "Miễn thi" ? "0" : txtdiem1.Text;
                txtdiem2.Enabled = checkMienThi2.Checked == true ? false : true;
                txtdiem2.Text = checkMienThi2.Checked == true ? "Miễn thi" : txtdiem2.Text == "Miễn thi" ? "0" : txtdiem2.Text;
                txtdiem3.Enabled = checkMienThi3.Checked == true ? false : true;
                txtdiem3.Text = checkMienThi3.Checked == true ? "Miễn thi" : txtdiem3.Text == "Miễn thi" ? "0" : txtdiem3.Text;
                txtdiem4.Enabled = checkMienThi4.Checked == true ? false : true;
                txtdiem4.Text = checkMienThi4.Checked == true ? "Miễn thi" : txtdiem4.Text == "Miễn thi" ? "0" : txtdiem4.Text;
                txtdiem5.Enabled = checkMienThi5.Checked == true ? false : true;
                txtdiem5.Text = checkMienThi5.Checked == true ? "Miễn thi" : txtdiem5.Text == "Miễn thi" ? "0" : txtdiem5.Text;
        }

      

     

        
    }
}
