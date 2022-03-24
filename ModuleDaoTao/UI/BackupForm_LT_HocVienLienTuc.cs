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
using System.Threading.Tasks;
using System.IO;
using ExportLib.Entities.DaoTao;
using ExportLib;
using CrystalDecisions.CrystalReports.Engine;
using System.Diagnostics;

namespace ModuleDaoTao.UI
{
    public partial class BackupForm_LT_HocVienLienTuc : NETLINK.UI.Dictionary, IFtpHandle
    {
        #region khai bao bien

        DT_LienTuc_HocVien objHocvien;

        int idHocvien;

        #endregion
        

        bool hasModifyImage = false;
        FtpHelper ftpHelper = new FtpHelper();

        private string oldHinhThuc = string.Empty;

        public BackupForm_LT_HocVienLienTuc(FormMode _formMode)
        {
            
            
            InitializeComponent();
            
            ApplyAuthorizationRules();
            
            this.formMode = _formMode;

            if (_formMode.IsInsert)
            {
                objHocvien = DT_LienTuc_HocVien.NewDT_LienTuc_HocVien();
                idHocvien = 0;
             
            }
            else
            {
                idHocvien = _formMode.Id;
                objHocvien = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(idHocvien);
            }
            
            //bindingSourceHocVien.DataSource = objHocvien;
            this.btnSave.CausesValidation = false;
            
        }


        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = true;

        }

        protected override void FormLoad()
        {
            try
            {

                // binding for trinh do
                dropDownTrinhDo.FillData(1);

                dropDownTinhThanh.FillData(1);

                //dropDownLopHocLienTucKhung.FillData();
                dropDownChuyenNganh.FillData(1);


                dropDownChuyenKhoa1.FillData(1);

                dropDownBenhVien.FillData(1);

                dropDownBoPhan1.FillData(1);

                //DIC_CanBo canbo = DIC_CanBo.GetDIC_CanBo(PTIdentity.IDNguoiDung);

                //if (canbo != null)
                 //   dropDownBoPhan1.Selected_ID = canbo.IDBoPhan;

                netLink_DatePickerKetThuc.MyName = "Ngày kết thúc";
                netLink_DatePickerNgayBatDau.MyName = "Ngày bắt đầu";

                //if (idHocvien != 0)
                //{
                //    loadGUI();
                //}
                //else
                //{
                //    netLink_DatePickerNgayDangKy.Value = DateTime.Now;
                //    ChangeVisible(0);
                //    radButtonInChungNhan.Visible = false;
                //}
                BindData(true);
                // set permission here
                if (idHocvien != 0 && !string.IsNullOrEmpty(objHocvien.NgayKetThuc))
                {
                    DateTime dt = System.Convert.ToDateTime(objHocvien.NgayKetThuc);
                    if (dt < DateTime.Now)
                    {
                        if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_DaHoc_Edit)
                            || GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Edit)
                            )
                        {
                            SetAllowEdit();
                        }
                        else
                        {
                            SetDontAllowEdit();
                        }
                    }
                    else
                    {
                        SetAllowEdit();
                    }
                }

                bool enableChungchi = EnableInChungNhan();
                radButtonInChungchi.Enabled = enableChungchi;
                radButtonInChungNhan.Enabled = enableChungchi;

            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }

        }
        private void HideControlByHinhThucHoc(string HThoc)
        {
            netLink_DatePickerNgayBatDau.Visible = false;
            netLink_DatePickerKetThuc.Visible = false;
            radTextBoxNoiDungDT.Visible = false;
            radHocPhi.Visible = false;
            radLabelHocphi.Visible = false;
            radLabelChonLop.Visible = false;
            radLabelKethuc.Visible = false;
            radLabelNgaybatdau.Visible = false;
            radLabelNoidungDT.Visible = false;
            dropDownLopHocLienTucKhung.Visible = false;
            if (HThoc == TextMessages.Itemvalue.HinhThucHoc_KemCap)
            {
                netLink_DatePickerNgayBatDau.Visible = true;
                netLink_DatePickerKetThuc.Visible = true;
                radTextBoxNoiDungDT.Visible = true;
                radHocPhi.Visible = true;
                radLabelHocphi.Visible = true;
                radLabelKethuc.Visible = true;
                radLabelNgaybatdau.Visible = true;
                radLabelNoidungDT.Visible = true;
            }
            else
            {
                dropDownLopHocLienTucKhung.Visible = true;
                radLabelChonLop.Visible = true;
            }
        }
        private void HideControlByFormStatus(bool isInsert)
        {
            if (isInsert)
            {
                radButtonGiayhen.Visible = false;
                radButtonGiaythuhocphi.Visible = false;
                radButtonInChungchi.Visible = false;
                radButtonInChungNhan.Visible = false;
                radButtonInTheHocVien.Visible = false;
                radButtonSaoluu.Visible = false;
                radButtonTiepnhanHocvien.Visible = false;
            }
        }
        private void BindData(bool isLoad)
        {
            if (isLoad)
            {
                radTextBoxHoTen.Text = objHocvien.HoTen;
                dropDownGioiTinh.Text = objHocvien.GioiTinh;
                radTextBoxCMT.Text = objHocvien.SoCMT;
                radTextBoxNoiCapCMT.Text = objHocvien.NoiCapCMT;
                radtxtTruongTotNghiep.Text = objHocvien.TruongTotNghiep;
                radtxtSoBang.Text = objHocvien.SoBang;
                radTextBoxDiachiCoquan.Text = objHocvien.DiaChiCoQuan;
                radTextBoxDienThoaiCoquan.Text = objHocvien.DienThoaiCoQuan;
                radTextBoxDiaChiNhaRieng.Text = objHocvien.DiaChiNhaRieng;
                radTextBoxDienThoaiNhaRieng.Text = objHocvien.DienThoaiNhaRieng;
                radTextBoxDiDong.Text = objHocvien.DiDong;
                radTextBoxEmail.Text = objHocvien.Email;
                radHocPhi.Text = objHocvien.TongHocPhi;
                radTextBoxNoiDungDT.Text = objHocvien.NoiDungDaoTao;
                radDropDownListTrangThai.Text = objHocvien.TrangThai;
                radtxtNamTotNghiep.Text = objHocvien.NamTotNghiep.ToString();
                netLink_DatePickerNgaySinh.Value_String = objHocvien.NgaySinh;
                netLink_DatePickerCapNgay.Value_String = objHocvien.NgayCapCMT;
                //Neu la them moi thi ngay dang ki se lay ngay he thong
                if (formMode.IsInsert)
                    netLink_DatePickerNgayDangKy.Value = DateTime.Now;
                else
                    netLink_DatePickerNgayDangKy.Value_String = objHocvien.NgayDangKi;
                netLink_DatePickerNgayBatDau.Value_String = objHocvien.NgayBatDau;
                netLink_DatePickerKetThuc.Value_String = objHocvien.NgayKetThuc;
                dropDownTrinhDo.Selected_ID = objHocvien.IdTrinhDo;
                dropDownChuyenNganh.Selected_ID = objHocvien.IdChuyenNganh;
                dropDownBenhVien.Selected_ID = objHocvien.IdBenhVienCongTac;
                dropDownTinhThanh.Selected_ID = objHocvien.IdTinhThanh;
                dropDownBoPhan1.Selected_ID = objHocvien.IdBoPhan;
                dropDownChuyenKhoa1.Selected_ID = objHocvien.IdChuyenNganhDangKi;
                dropDownLopHocLienTucKhung.Selected_ID = objHocvien.IdKhungLopHoc;
                if (objHocvien.HinhThucHoc == TextMessages.Itemvalue.HinhThucHoc_KemCap)
                {
                    radRadioButtonKemcap.IsChecked = true;
                }
                else
                {
                    radRadioButtonTheoLop.IsChecked = true;

                }
                HideControlByHinhThucHoc(objHocvien.HinhThucHoc);

                // Không cho phép chuyển trạng thái sau khi đã save
                if (formMode.IsEdit)
                {
                    radRadioButtonKemcap.Enabled = false;
                    radRadioButtonTheoLop.Enabled = false;
                    netLink_DatePickerNgayDangKy.Enabled = false;
                    // Nếu đã xếp lớp thì không được phép chuyển học viên sang ngành khác
                    if (objHocvien.HinhThucHoc == TextMessages.Itemvalue.HinhThucHoc_TheoLop && !string.IsNullOrEmpty(objHocvien.MaLopHoc))
                    {
                        dropDownChuyenKhoa1.Enabled = false;
                        dropDownLopHocLienTucKhung.Enabled = false;
                    }
                }


            }
            else
            {
                if (dropDownTrinhDo.Selected_ID != null)
                    objHocvien.IdTrinhDo = Convert.ToInt32(dropDownTrinhDo.Selected_ID);
                if (dropDownChuyenNganh.Selected_ID != null)
                    objHocvien.IdChuyenNganh = Convert.ToInt32(dropDownChuyenNganh.Selected_ID);
                if (dropDownBenhVien.Selected_ID != null)
                    objHocvien.IdBenhVienCongTac = Convert.ToInt64(dropDownBenhVien.Selected_ID);
                if (dropDownTinhThanh.Selected_ID != null)
                    objHocvien.IdTinhThanh = Convert.ToInt64(dropDownTinhThanh.Selected_ID);
                if (dropDownBoPhan1.Selected_ID != null)
                    objHocvien.IdBoPhan = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                if (dropDownChuyenKhoa1.Selected_ID != null)
                    objHocvien.IdChuyenNganhDangKi = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                if (dropDownLopHocLienTucKhung.Selected_ID != null)
                    objHocvien.IdKhungLopHoc = Convert.ToInt32(dropDownLopHocLienTucKhung.Selected_ID);
                objHocvien.HoTen = radTextBoxHoTen.Text;
                objHocvien.GioiTinh = dropDownGioiTinh.Text;
                objHocvien.SoCMT = radTextBoxCMT.Text;
                objHocvien.NoiCapCMT = radTextBoxNoiCapCMT.Text;
                objHocvien.TruongTotNghiep = radtxtTruongTotNghiep.Text;
                objHocvien.SoBang = radtxtSoBang.Text;
                objHocvien.DiaChiCoQuan = radTextBoxDiachiCoquan.Text;
                objHocvien.DienThoaiCoQuan = radTextBoxDienThoaiCoquan.Text;
                objHocvien.DiaChiNhaRieng = radTextBoxDiaChiNhaRieng.Text;
                objHocvien.DienThoaiNhaRieng = radTextBoxDienThoaiNhaRieng.Text;
                objHocvien.DiDong = radTextBoxDiDong.Text;
                objHocvien.Email = radTextBoxEmail.Text;
                objHocvien.TongHocPhi = radHocPhi.Text;
                objHocvien.NoiDungDaoTao = radTextBoxNoiDungDT.Text;
                objHocvien.TrangThai = radDropDownListTrangThai.Text;
                if (!string.IsNullOrEmpty(radtxtNamTotNghiep.Text))
                    objHocvien.NamTotNghiep = Convert.ToInt32(radtxtNamTotNghiep.Text);
                objHocvien.NgaySinh = netLink_DatePickerNgaySinh.Value_String;
                objHocvien.NgayCapCMT = netLink_DatePickerCapNgay.Value_String;
                objHocvien.NgayDangKi = netLink_DatePickerNgayDangKy.Value_String;
                objHocvien.NgayBatDau = netLink_DatePickerNgayBatDau.Value_String;
                objHocvien.NgayKetThuc = netLink_DatePickerKetThuc.Value_String;
                objHocvien.LastEdited_Date = DateTime.Now;
                objHocvien.LastEdited_User = PTIdentity.IDNguoiDung;
                if (radRadioButtonKemcap.IsChecked)
                {
                    objHocvien.HinhThucHoc = TextMessages.Itemvalue.HinhThucHoc_KemCap;
                }
                else
                {
                    objHocvien.HinhThucHoc = TextMessages.Itemvalue.HinhThucHoc_TheoLop;
                }
            }
        }


        protected override void Save()
        {
            try
            {
                BindData(false);
                btnSave.Focus();
                int type = 0;
                 if (radRadioButtonKemcap.IsChecked)
                        objHocvien.HinhThucHoc = radRadioButtonKemcap.Text;
                    else if (radRadioButtonTheoLop.IsChecked)
                        objHocvien.HinhThucHoc = radRadioButtonTheoLop.Text;
                 if (string.IsNullOrEmpty(objHocvien.HinhThucHoc)) {
                     GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                     return;
                 }
                if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonKemcap.Text) == 0)
                {
                    type = 1;
                }
                else if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonTheoLop.Text) == 0)
                {
                    type = 2;
                }

                if (ValidateData(type))
                {
                    if (dropDownTinhThanh.Selected_ID != null)
                        objHocvien.IdTinhThanh = (long)dropDownTinhThanh.Selected_ID;
                    if (dropDownChuyenNganh.Selected_ID != null)
                        objHocvien.IdChuyenNganh = (int)dropDownChuyenNganh.Selected_ID;

                    if (dropDownChuyenKhoa1.Selected_ID != null)
                        objHocvien.IdChuyenNganhDangKi = (int)dropDownChuyenKhoa1.Selected_ID;
                    if (radDropDownListTrangThai.SelectedItem != null)
                        objHocvien.TrangThai = radDropDownListTrangThai.SelectedItem.ToString();

                    if (!radRadioButtonKemcap.IsChecked)
                    {
                        if (dropDownLopHocLienTucKhung.Selected_ID != null)
                            objHocvien.IdKhungLopHoc = (int)dropDownLopHocLienTucKhung.Selected_ID;
                    }
                    objHocvien.IdTrinhDo = System.Convert.ToInt32(dropDownTrinhDo.Selected_ID);

                    objHocvien.IdBoPhan = System.Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                    objHocvien.IdNguoiQuanLy = PTIdentity.IDNguoiDung;
                    objHocvien.TrangThai = radDropDownListTrangThai.Text;
                    bindData(type);

                    // just generate mahocvien when kem cap 
                    if (type == 1 && (formMode.IsInsert || string.IsNullOrEmpty(oldHinhThuc) || oldHinhThuc.CompareTo(radRadioButtonTheoLop.Text) == 0))
                    {
                        int count = DT_LienTuc_HocVien_Coll.DataPortal_FetchCountHocVienKemCap(Convert.ToDateTime(objHocvien.NgayBatDau));
                        objHocvien.MaHocVien = CreateMaHocVienKemCap(count + 1);
                    }

                    objHocvien.ApplyEdit();

                    if (hasModifyImage)
                    {
                        //bw.RunWorkerAsync();
                        //progressBar1.Visible = true;
                        pictureBoxLoading.Visible = true;
                        if (!string.IsNullOrEmpty(radTextBoxFilePath.Text))
                        {
                            
                            ftpHelper.FtpHandle = this;
                            ftpHelper.InpuFile = radTextBoxFilePath.Text;
                            ftpHelper.progressBar = progressBar1;
                            ftpHelper.StartUploadFile();
                        }
                        /*Task t = Task.Factory.StartNew(() =>
                        {
                            if (!string.IsNullOrEmpty(radTextBoxFilePath.Text))
                            {
                                string ftpFile = string.Empty;
                                bool isSuccess = ftp.UploadLargeFile(radTextBoxFilePath.Text, true, out ftpFile);
                                if (isSuccess)
                                {
                                    //BeginInvoke();
                                    //this.Close();
                                    //EndInvoke();
                                    //string fName = Path.GetFileName(radTextBoxFilePath.Text);
                                    objHocvien.Anh = ftpFile;
                                    objHocvien = objHocvien.Save();
                                }
                                else
                                {
                                    MessageBox.Show("Upload ảnh đại diện lỗi");
                                }

                                this.pictureBoxLoading.BeginInvoke(new Action(() =>
                                {
                                    this.pictureBoxLoading.Visible = false;
                                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                                }));
                            }
                        });
                        t.ContinueWith((Success) =>
                        {
                            //this.Close();
                        }, TaskContinuationOptions.NotOnFaulted);
                        t.ContinueWith((Fail) =>
                        {
                            //log the exception i.e.: Fail.Exception.InnerException);
                        }, TaskContinuationOptions.OnlyOnFaulted);*/

                    }


                    objHocvien = objHocvien.Save();
                    if (!hasModifyImage)
                        GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    //this.Close();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        public void OnFtpUpLoadSuccessFully() {
            //progressBar1.Visible = false;
            objHocvien.Anh = ftpHelper.OutputFile;
            objHocvien = objHocvien.Save();
            this.pictureBoxLoading.BeginInvoke(new Action(() =>
            {
                this.pictureBoxLoading.Visible = false;
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
            }));
        }

        public void OnFtpUpLoadFailed() {
            this.pictureBoxLoading.BeginInvoke(new Action(() =>
            {
                this.pictureBoxLoading.Visible = false;
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
            }));
            MessageBox.Show("Upload ảnh đại diện lỗi");
        }

        #endregion

        #region form's events

        private void radDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        private void radTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void radLabel20_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*try
            {
                foreach (Control control in this.Controls)
                {
                    control.Focus();
                    if (Validate())
                    {
                        DialogResult = System.Windows.Forms.DialogResult.None;
                        return;
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }*/
        }

        #region validating events

     

        /// <summary>
        /// chon anh hien theo ket qua
        /// </summary>
        /// <param name="type">0 for nothing, 1 for kem cap, 2 xep lop</param>
        private void ChangeVisible(int type) {
            if (type == 0 || type == 2) {
                radLabelNoidungDT.Visible = false;
                radTextBoxNoiDungDT.Visible = false;
                radLabelNgaybatdau.Visible = false;
                netLink_DatePickerNgayBatDau.Visible = false;
                radLabelKethuc.Visible = false;
                netLink_DatePickerKetThuc.Visible = false;
                radLabelHocphi.Visible = false;
                radHocPhi.Visible = false;
                radLabelChonLop.Visible = true;
                dropDownLopHocLienTucKhung.Visible = true;

                objHocvien.NgayBatDau = null;
                objHocvien.NgayKetThuc = null;

                radButtonGiayhen.Visible = false;
                radButtonGiaythuhocphi.Visible = false;
                radButtonTiepnhanHocvien.Visible = false;
                if (idHocvien > 0)
                {
                    radButtonInChungNhan.Visible = true;
                    radButtonInChungNhan.Text = "In chứng chỉ";
                }
            }
            else if (type == 1) {
                radLabelNoidungDT.Visible = true;
                radTextBoxNoiDungDT.Visible = true;
                radLabelNgaybatdau.Visible = true;
                netLink_DatePickerNgayBatDau.Visible = true;
                radLabelKethuc.Visible = true;
                netLink_DatePickerKetThuc.Visible = true;
                radLabelHocphi.Visible = true;
                radHocPhi.Visible = true;   
                radLabelChonLop.Visible = false;
                dropDownLopHocLienTucKhung.Visible = false;
                dropDownLopHocLienTucKhung.SelectedIndex = -1;

                if (idHocvien > 0)
                {
                    radButtonGiayhen.Visible = true;
                    radButtonGiaythuhocphi.Visible = true;
                    radButtonTiepnhanHocvien.Visible = true;
                    radButtonInChungNhan.Visible = true;
                    radButtonInChungNhan.Text = "In chứng nhận";
                }
            }
        }

        private void bindData(int type) {
            // binding data
            objHocvien.NgayCapCMT = netLink_DatePickerCapNgay.Value_String;
            if (type == 1)
            {
                objHocvien.NgayKetThuc = netLink_DatePickerKetThuc.Value_String;
                objHocvien.NgayBatDau = netLink_DatePickerNgayBatDau.Value_String;
            }
            objHocvien.NgayDangKi = netLink_DatePickerNgayDangKy.Value_String;
            objHocvien.NgaySinh = netLink_DatePickerNgaySinh.Value_String;

            objHocvien.IdBenhVienCongTac = dropDownBenhVien.Selected_Item != null ? System.Convert.ToInt64(dropDownBenhVien.Selected_ID) : -1;
        }

        private bool ValidateData(int type)
        {
            if (type == 1) 
            {
                if (!netLink_DatePickerKetThuc.isDateTime && !netLink_DatePickerKetThuc.isNull)
                {
                    GlobalCommon.ShowErrorMessager(netLink_DatePickerKetThuc.Value_Error);
                    return false;
                }
                if (!netLink_DatePickerNgayBatDau.isDateTime && !netLink_DatePickerNgayBatDau.isNull)
                {
                    GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayBatDau.Value_Error);
                    return false;
                }
            }

            if (!netLink_DatePickerNgayDangKy.isDateTime && !netLink_DatePickerNgayDangKy.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayDangKy.Value_Error);
                return false;
            }
            if (!netLink_DatePickerNgaySinh.isDateTime && !netLink_DatePickerNgaySinh.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgaySinh.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radTextBoxHoTen.Text, radTextBoxCMT.Text, netLink_DatePickerNgayDangKy.Text, netLink_DatePickerNgaySinh .Text}))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }

            if (type == 1)
            {
                if (GlobalCommon.CheckArrayTextIsNull(new string[] { netLink_DatePickerKetThuc.Text, netLink_DatePickerNgayBatDau.Text}))
                {
                    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                    return false;
                }

                if (!GlobalCommon.CheckDateMustBeEarilierThanOther(netLink_DatePickerKetThuc.Value_String, netLink_DatePickerNgayBatDau.Value_String))
                {
                    GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, netLink_DatePickerKetThuc.MyName, netLink_DatePickerNgayBatDau.MyName));
                    return false;
                }
            }

            return true;
        }

        #endregion

        private string CreateMaHocVienKemCap(int count) {
            string strCount = count.ToString();
            if (count < 10)
                strCount = string.Format("00{0}", count);
            else if (count < 100)
                strCount = string.Format("0{0}", count);
            string result = string.Format("{0}-KC-BM-{1}-B24", strCount, GlobalCommon.CutYear(DateTime.Now.Year));
            return result;
        }

        private void radRadioButtonKemcap_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radRadioButtonKemcap.IsChecked)
                ChangeVisible(1);
        }

        private void radRadioButtonTheoLop_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radRadioButtonTheoLop.IsChecked)
                ChangeVisible(2);
        }

        private void dropDownChuyenKhoa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)dropDownChuyenKhoa1.Selected_ID;
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDownWithCondition);
            function.ItemID = id;
            DT_LienTuc_KhungLopHoc_Coll coll = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll(function);
            dropDownLopHocLienTucKhung.FillData(coll);

            if (coll == null || coll.Count == 0)
            {
                dropDownLopHocLienTucKhung.SelectedIndex = -1;
                dropDownLopHocLienTucKhung.Selected_TextValue = "";
            }
            
            
        }

        private void radButtonSaoluu_Click(object sender, EventArgs e)
        {
            try
            {
                DT_LienTuc_HocVien cloneObj = DT_LienTuc_HocVien.NewDT_LienTuc_HocVien();

                cloneObj.IdTinhThanh = (long)dropDownTinhThanh.Selected_ID;
                cloneObj.IdChuyenNganh = (int)dropDownChuyenNganh.Selected_ID;
                cloneObj.IdChuyenNganhDangKi = (int)dropDownChuyenKhoa1.Selected_ID;
                cloneObj.TrangThai = radDropDownListTrangThai.SelectedItem.ToString();
                //objHocvien.TrangThai = (string)dropDownTrangThaiHocVien1.SelectedText;

                if (!radRadioButtonKemcap.IsChecked)
                {
                    if (dropDownLopHocLienTucKhung.Selected_ID != null)
                        cloneObj.IdKhungLopHoc = (int)dropDownLopHocLienTucKhung.Selected_ID;
                }
                else { 
                     int count = DT_LienTuc_HocVien_Coll.DataPortal_FetchCountHocVienKemCap(Convert.ToDateTime(objHocvien.NgayBatDau));
                     cloneObj.MaHocVien = CreateMaHocVienKemCap(count + 1);
                }
                cloneObj.IdTrinhDo = System.Convert.ToInt32(dropDownTrinhDo.Selected_ID);

                if (radRadioButtonKemcap.IsChecked)
                    cloneObj.HinhThucHoc = radRadioButtonKemcap.Text;
                else if (radRadioButtonTheoLop.IsChecked)
                    cloneObj.HinhThucHoc = radRadioButtonTheoLop.Text;
                cloneObj.IdNguoiQuanLy = PTIdentity.IDNguoiDung;

                cloneObj.Anh = objHocvien.Anh;
                cloneObj.DaDongHocPhi = false;
                cloneObj.DiaChiCoQuan = objHocvien.DiaChiCoQuan;
                cloneObj.DiaChiNhaRieng = objHocvien.DiaChiNhaRieng;
                cloneObj.DiDong = objHocvien.DiDong;
                cloneObj.DienThoaiCoQuan = objHocvien.DienThoaiCoQuan;
                cloneObj.DienThoaiNhaRieng = objHocvien.DienThoaiNhaRieng;
                cloneObj.Email = objHocvien.Email;
                cloneObj.GioiTinh = objHocvien.GioiTinh;
                cloneObj.HoTen = objHocvien.HoTen;
                cloneObj.IdTinhThanh = objHocvien.IdTinhThanh;
                cloneObj.NamTotNghiep = objHocvien.NamTotNghiep;
                cloneObj.NgayBatDau = objHocvien.NgayBatDau;
                cloneObj.NgayCapCMT = objHocvien.NgayCapCMT;
                cloneObj.NgayDangKi = objHocvien.NgayDangKi;
                cloneObj.NgayKetThuc = objHocvien.NgayKetThuc;
                cloneObj.NgaySinh = objHocvien.NgaySinh;
                cloneObj.NoiCapCMT = objHocvien.NoiCapCMT;
                cloneObj.NoiCongTac = objHocvien.NoiCongTac;
                cloneObj.NoiDungDaoTao = objHocvien.NoiDungDaoTao;
                cloneObj.SoBang = objHocvien.SoBang;
                cloneObj.SoCMT = objHocvien.SoCMT;
                cloneObj.TongHocPhi = objHocvien.TongHocPhi;
                cloneObj.TruongTotNghiep = objHocvien.TruongTotNghiep;
                cloneObj.XepLoai = objHocvien.XepLoai;

                cloneObj.DaDongHocPhi = false;
                cloneObj.TongTienHoc = string.Empty;
                cloneObj.TongChiPhiKhac = string.Empty;
                cloneObj.TongSoLanInBangTotNghiep = 0;
                cloneObj.TongSoLanInGiayChungNhan = 0;
                cloneObj.TongSoLanInHoaDon = 0;
                cloneObj.TongSoLanInThe = 0;

                cloneObj.IdBenhVienCongTac = dropDownBenhVien.Selected_Item != null ? System.Convert.ToInt64(dropDownBenhVien.Selected_ID) : -1;
                cloneObj.IdBoPhan = dropDownBoPhan1.Selected_Item != null ? System.Convert.ToInt32(dropDownBoPhan1.Selected_ID) : -1;
                cloneObj.Save();

                this.Close();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private DT_LienTuc_HocVien GetClone(DT_LienTuc_HocVien objHocvien)
        {
            DT_LienTuc_HocVien cloneObj = DT_LienTuc_HocVien.NewDT_LienTuc_HocVien();
            cloneObj.IdTinhThanh = objHocvien.IdTinhThanh;
            cloneObj.IdChuyenNganh = objHocvien.IdChuyenNganh;
            cloneObj.IdChuyenNganhDangKi = objHocvien.IdChuyenNganhDangKi;
            cloneObj.TrangThai = objHocvien.TrangThai;
            //objHocvien.TrangThai = (string)dropDownTrangThaiHocVien1.SelectedText;

            cloneObj.IdTrinhDo = objHocvien.IdTrinhDo;

            cloneObj.IdNguoiQuanLy = PTIdentity.IDNguoiDung;

            cloneObj.Anh = objHocvien.Anh;
            cloneObj.DaDongHocPhi = false;
            cloneObj.DiaChiCoQuan = objHocvien.DiaChiCoQuan;
            cloneObj.DiaChiNhaRieng = objHocvien.DiaChiNhaRieng;
            cloneObj.DiDong = objHocvien.DiDong;
            cloneObj.DienThoaiCoQuan = objHocvien.DienThoaiCoQuan;
            cloneObj.DienThoaiNhaRieng = objHocvien.DienThoaiNhaRieng;
            cloneObj.Email = objHocvien.Email;
            cloneObj.GioiTinh = objHocvien.GioiTinh;
            cloneObj.HoTen = objHocvien.HoTen;
            cloneObj.IdTinhThanh = objHocvien.IdTinhThanh;
            cloneObj.NamTotNghiep = objHocvien.NamTotNghiep;
            cloneObj.NgayBatDau = objHocvien.NgayBatDau;
            cloneObj.NgayCapCMT = objHocvien.NgayCapCMT;
            cloneObj.NgayDangKi = objHocvien.NgayDangKi;
            cloneObj.NgayKetThuc = objHocvien.NgayKetThuc;
            cloneObj.NgaySinh = objHocvien.NgaySinh;
            cloneObj.NoiCapCMT = objHocvien.NoiCapCMT;
            cloneObj.NoiCongTac = objHocvien.NoiCongTac;
            cloneObj.NoiDungDaoTao = objHocvien.NoiDungDaoTao;
            cloneObj.SoBang = objHocvien.SoBang;
            cloneObj.SoCMT = objHocvien.SoCMT;
            cloneObj.TongHocPhi = objHocvien.TongHocPhi;
            cloneObj.TruongTotNghiep = objHocvien.TruongTotNghiep;
            cloneObj.XepLoai = objHocvien.XepLoai;

            cloneObj.DaDongHocPhi = false;
            cloneObj.TongTienHoc = string.Empty;
            cloneObj.TongChiPhiKhac = string.Empty;
            cloneObj.TongSoLanInBangTotNghiep = 0;
            cloneObj.TongSoLanInGiayChungNhan = 0;
            cloneObj.TongSoLanInHoaDon = 0;
            cloneObj.TongSoLanInThe = 0;
            cloneObj.Lan5 = 0;
            cloneObj.LyDoHoanTien = string.Empty;
            cloneObj.Nhom = 0;
            cloneObj.SoTienHoan = string.Empty;

            cloneObj.IdBenhVienCongTac = objHocvien.IdBenhVienCongTac;
            cloneObj.IdBoPhan = dropDownBoPhan1.Selected_Item != null ? System.Convert.ToInt32(dropDownBoPhan1.Selected_ID) : -1;

            return cloneObj;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strFileName = openFileDialog.FileName;

                if (strFileName == string.Empty)
                    return;

                radTextBoxFilePath.Text = strFileName;
                pictureBoxAnh.ImageLocation = strFileName;
                hasModifyImage = true;
                pictureBoxAnh.Visible = true;
            }

        }

        private void radButtonGiayhen_Click(object sender, EventArgs e)
        {
            G002_GiayHenTraTheHocVien trathe = new G002_GiayHenTraTheHocVien();

            DIC_ChuyenNganh_Info chuyennganh = (DIC_ChuyenNganh_Info)dropDownChuyenNganh.Selected_Item; 
            trathe.DiaDiem = chuyennganh.Ten;
            trathe.GioiTinh = objHocvien.GioiTinh;
            trathe.HoTenHocVien = objHocvien.HoTen;
            trathe.NgaySinh = objHocvien.NgaySinh;
            DateTime date = DateTime.Now;
            trathe.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            trathe.NoiCongTac = objHocvien.NoiCongTac;
            trathe.NoiDungDangKy = objHocvien.NoiDungDaoTao;
            

            DIC_HocVi_Info trinhdo = (DIC_HocVi_Info)dropDownTrinhDo.Selected_Item;
            trathe.TrinhDo = trinhdo.TenHocVi;
            trathe.TongSoThoiGianHoc = objHocvien.NgayBatDau + " đến " + objHocvien.NgayKetThuc;

            ExportDaoTao daotao = new ExportDaoTao();


            ReportDocument doc = daotao.G002_GiayHenTraTheHocVien(new List<ExportLib.Entities.DaoTao.G002_GiayHenTraTheHocVien>(){trathe});
            FormMode newmode = new FormMode();
            newmode.Item = doc;
            NetLinkReport fr = new NetLinkReport(newmode);
            fr.Show();
        }

        private void radButtonGiaythuhocphi_Click(object sender, EventArgs e)
        {
            G003_GiayDeNghiThuTienHocPhi denghithuhocphi = new G003_GiayDeNghiThuTienHocPhi();
            DIC_ChuyenNganh_Info chuyennganh = (DIC_ChuyenNganh_Info)dropDownChuyenNganh.Selected_Item;
            denghithuhocphi.DiaDiemDangKy = chuyennganh.Ten;
            denghithuhocphi.GioiTinh = objHocvien.GioiTinh;

            double month = 0;
            string TongHocPhiStr = string.Empty;
            if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonTheoLop.Text) == 0)
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
                TongHocPhiStr = lophoc.HocPhi;
            }
            else if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonKemcap.Text) == 0)
            {

                DateTime startDate = System.Convert.ToDateTime(objHocvien.NgayBatDau);
                DateTime endDate = System.Convert.ToDateTime(objHocvien.NgayKetThuc);
                month = GlobalCommon.TotalMonths(startDate, endDate);
                TongHocPhiStr = objHocvien.TongHocPhi;
            }
            int tonghopPhi = (int)(System.Convert.ToInt32(TongHocPhiStr) / month);
            
            denghithuhocphi.HoTenHocVien = objHocvien.HoTen;
            denghithuhocphi.NgaySinh = objHocvien.NgaySinh;
            DateTime date = DateTime.Now;
            denghithuhocphi.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            denghithuhocphi.NoiCongTac = objHocvien.NoiCongTac;
           
            
            denghithuhocphi.TongTienHocPhi = TongHocPhiStr;
            
            DIC_HocVi_Info trinhdo = (DIC_HocVi_Info)dropDownTrinhDo.Selected_Item;
            denghithuhocphi.TrinhDo = trinhdo.TenHocVi;
            denghithuhocphi.NoiDungHoc = objHocvien.NoiDungDaoTao;
            ExportDaoTao daotao = new ExportDaoTao();
            
            ReportDocument doc  = daotao.G003_GiayDeNghiThuTienHocPhi(new List<ExportLib.Entities.DaoTao.G003_GiayDeNghiThuTienHocPhi>(){denghithuhocphi});
            FormMode newmode = new FormMode();
            newmode.Item = doc;
            NetLinkReport fr = new NetLinkReport(newmode);
            fr.Show();

        }

        private void radButtonTiepnhanHocvien_Click(object sender, EventArgs e)
        {
            G004_GiayDeNghiTiepNhanHocVien giaytiepnhan = new G004_GiayDeNghiTiepNhanHocVien();
            DIC_ChuyenNganh_Info chuyennganh = (DIC_ChuyenNganh_Info)dropDownChuyenNganh.Selected_Item;
            giaytiepnhan.DiaDiemDangKy = chuyennganh.Ten;
            giaytiepnhan.GioiTinh = objHocvien.GioiTinh;
            giaytiepnhan.HoTenHocVien = objHocvien.HoTen;
            giaytiepnhan.NgaySinh = objHocvien.NgaySinh;
            DateTime date = DateTime.Now;
            giaytiepnhan.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            giaytiepnhan.NoiCongTac = objHocvien.NoiCongTac;
            giaytiepnhan.NoiDungHoc = objHocvien.NoiDungDaoTao;

            double month = 0;
            if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonTheoLop.Text) == 0)
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
            }
            else if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonKemcap.Text) == 0)
            {

                DateTime startDate = System.Convert.ToDateTime(objHocvien.NgayBatDau);
                DateTime endDate = System.Convert.ToDateTime(objHocvien.NgayKetThuc);
                month = GlobalCommon.TotalMonths(startDate, endDate);
            }
            giaytiepnhan.TongSoThoiGianHoc = month + " tháng";
             DIC_HocVi_Info trinhdo = (DIC_HocVi_Info)dropDownTrinhDo.Selected_Item;
             giaytiepnhan.TrinhDo = trinhdo.TenHocVi;
             ExportDaoTao daotao = new ExportDaoTao();
             ReportDocument doc = daotao.G004_GiayDeNghiTiepNhanHocVien(new List<ExportLib.Entities.DaoTao.G004_GiayDeNghiTiepNhanHocVien>(){giaytiepnhan});

             FormMode newmode = new FormMode();
             newmode.Item = doc;
             NetLinkReport fr = new NetLinkReport(newmode);
             fr.Show();
        }

        private void radButtonInChungchi_Click(object sender, EventArgs e)
        {
            G001_GiayHenTraChungChiHocVien chungchi = new G001_GiayHenTraChungChiHocVien();

            chungchi.GioiTinh = objHocvien.GioiTinh;
            chungchi.HoTenHocVien = objHocvien.HoTen;
            chungchi.KetQuaHocTap = "Đạt";
            chungchi.NgaySinh = objHocvien.NgaySinh;
            DateTime date = DateTime.Now;
            chungchi.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            chungchi.NoiCongTac = objHocvien.NoiCongTac;
            chungchi.NoiDungDangKy = objHocvien.NoiCongTac;
            DIC_HocVi_Info trinhdo = (DIC_HocVi_Info)dropDownTrinhDo.Selected_Item;
            chungchi.TrinhDo = trinhdo.TenHocVi;
            DIC_ChuyenNganh_Info chuyennganh = (DIC_ChuyenNganh_Info)dropDownChuyenNganh.Selected_Item;
            chungchi.DiaDiem = chuyennganh.Ten;

            ExportDaoTao daotao = new ExportDaoTao();
            ReportDocument doc = daotao.G001_GiayHenTraChungChiHocVien(new List<ExportLib.Entities.DaoTao.G001_GiayHenTraChungChiHocVien>(){chungchi});

            FormMode newmode = new FormMode();
            newmode.Item = doc;
            NetLinkReport fr = new NetLinkReport(newmode);
            fr.Show();
        }

        private void dropDownBenhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DIC_BenhVien_Info selectedItem = (DIC_BenhVien_Info)dropDownBenhVien.Selected_Item;

            if (selectedItem != null)
            {
                objHocvien.DiaChiCoQuan = selectedItem.DiaChi;
                radTextBoxDiachiCoquan.Text = selectedItem.DiaChi;
                dropDownTinhThanh.Selected_ID = selectedItem.IDTinh;
                radTextBoxDienThoaiCoquan.Text = selectedItem.DienThoai;
            }
        }

        private void radButtonInTheHocVien_Click(object sender, EventArgs e)
        {
            if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonTheoLop.Text) == 0)
            {
                if (string.IsNullOrEmpty(objHocvien.MaLopHoc)){
                    GlobalCommon.ShowErrorMessager("Không thẻ in thẻ học viên. Học viên chưa được xếp lớp!");
                    return;
                }
                DT_LienTuc_LopHoc lophoc = DT_LienTuc_LopHoc.GetDT_LienTuc_LopHoc(objHocvien.MaLopHoc);
                if (lophoc == null) {
                    GlobalCommon.ShowErrorMessager("Lớp học không tồn tại!");
                    return;
                }
                
                // neu la hoc vien lien tuc
                string temp =  Path.GetTempPath();
                string imgFileName = objHocvien.MaHocVien + ".jpg";
                imgFileName = Path.Combine(temp, imgFileName);
                pictureBoxAnh.Image.Save(imgFileName);

                DT_TheHocVien lstHocvien = new DT_TheHocVien();

                lstHocvien.ListTheHocVien = new List<TheHocVien>();
                TheHocVien needPrint = new TheHocVien();
                needPrint.TenHocVien = objHocvien.HoTen;
                needPrint.MaHocVien = objHocvien.MaHocVien;
                needPrint.KhoaHoc = lophoc.KhoaHoc;

                DIC_ChuyenNganh_Coll lstChuyenNganh = dropDownChuyenNganh.GetListData();
                foreach (DIC_ChuyenNganh_Info chuyennganh in lstChuyenNganh) 
                {
                    if (chuyennganh.ID == objHocvien.IdChuyenNganh)
                    {
                        needPrint.ChuyenNganh = "Chuyên ngành: " + chuyennganh.Ten;
                        needPrint.ChuyenNganh = needPrint.ChuyenNganh.ToUpper();
                        break;
                    }
                }

                DT_LienTuc_KhungLopHoc_Coll lstKhungLopHoc = dropDownLopHocLienTucKhung.GetListData();
                foreach (DT_LienTuc_KhungLopHoc_Info khunglophoc in lstKhungLopHoc)
                {
                    if (objHocvien.IdKhungLopHoc == khunglophoc.Id)
                    {
                        needPrint.LopHoc = khunglophoc.TenLop;
                        break;
                    }
                }

                //needPrint.LopHoc =  string.Format("Lớp {0}", objHocvien.NoiDungDaoTao);

                needPrint.AnhHocVien = temp + "\\" + objHocvien.MaHocVien + ".jpg";
                lstHocvien.ListTheHocVien.Add(needPrint);

                ExportDaoTao daotao = new ExportDaoTao();
                daotao.ExportTheHocVien(lstHocvien);
            }
            else { 
               // neu la hoc vien kem cap
                string temp = Path.GetTempPath();
                string imgFileName = objHocvien.MaHocVien + ".jpg";
                imgFileName = Path.Combine(temp, imgFileName);
                pictureBoxAnh.Image.Save(imgFileName);

                DT_TheHocVienLienTuc lstHocvienLt = new DT_TheHocVienLienTuc();
                lstHocvienLt.ListTheHocVienLienTuc = new List<TheHocVienLienTuc>();

                TheHocVienLienTuc needPrint = new TheHocVienLienTuc();
                needPrint.TenHocVien = objHocvien.HoTen;
                needPrint.MaHocVien = objHocvien.MaHocVien;
                needPrint.AnhHocVien = temp + "\\" + objHocvien.MaHocVien + ".jpg";
                if(dropDownTrinhDo.Selected_TextValue != null)
                needPrint.TrinhDo = dropDownTrinhDo.Selected_TextValue.ToString();
                needPrint.KhoaHoc = objHocvien.NoiDungDaoTao;
                needPrint.ThoiGian = string.Format("{0} - {1}", objHocvien.NgayBatDau, objHocvien.NgayKetThuc);
                needPrint.SoCMT = objHocvien.SoCMT;
                lstHocvienLt.ListTheHocVienLienTuc.Add(needPrint);
                ExportDaoTao daotao = new ExportDaoTao();
                daotao.ExportTheHocVienLienTuc(lstHocvienLt , Convert.ToInt32(0));
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.ExportSuccess);
            }
        }

        private void radButtonInChungNhan_Click(object sender, EventArgs e)
        {
            ////if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonTheoLop.Text) == 0)
            ////{
            ////    if (string.IsNullOrEmpty(objHocvien.MaLopHoc))
            ////    {
            ////        GlobalCommon.ShowErrorMessager("Không thẻ in thẻ học viên. Học viên chưa được xếp lớp!");
            ////        return;
            ////    }
            ////    DT_LienTuc_LopHoc lophoc = DT_LienTuc_LopHoc.GetDT_LienTuc_LopHoc(objHocvien.MaLopHoc);
            ////    if (lophoc == null)
            ////    {
            ////        GlobalCommon.ShowErrorMessager("Lớp học không tồn tại!");
            ////        return;
            ////    }

            ////    // neu la hoc vien lien tuc theo lop
            ////    DT_GiayChungChi chungchi = new DT_GiayChungChi();
            ////    chungchi.ListChungChi = new List<ChungChi>();
            ////    ChungChi objNeedPrint = new ChungChi();

            ////    objNeedPrint.ThongTin = string.Format("{0}, Ngày {1} tháng {2} năm {3}", "Hà Nội", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            ////    objNeedPrint.HocVien = objHocvien.HoTen;

            ////     DT_LienTuc_KhungLopHoc_Coll lstKhungLopHoc = dropDownLopHocLienTucKhung.GetListData();
            ////    foreach (DT_LienTuc_KhungLopHoc_Info khunglophoc in lstKhungLopHoc)
            ////    {
            ////        if (objHocvien.IdKhungLopHoc == khunglophoc.Id)
            ////        {
            ////            objNeedPrint.KhoaHocHoanThanh = string.Format("{0} {1}", "lớp", khunglophoc.TenLop);
            ////            break;
            ////        }
            ////    }

            ////    objNeedPrint.NgayBatDau = lophoc.NgayBatDau;
            ////    objNeedPrint.NgayKetThuc = lophoc.NgayKetThuc;
            ////    objNeedPrint.NgaySinh = objHocvien.NgaySinh;
            ////    objNeedPrint.SoTietHoc = "150 tiết";

            ////    DIC_HocVi_Coll lstTrinhDo = dropDownTrinhDo.GetListData();
            ////    foreach (DIC_HocVi_Info trinhdo in lstTrinhDo) {
            ////        if (trinhdo.ID == objHocvien.IdTrinhDo) {
            ////            objNeedPrint.TrinhDo = trinhdo.TenHocVi;
            ////            break;
            ////        }
            ////    }
            ////    DIC_BenhVien_Coll lstBenhVien = dropDownBenhVien.GetListData();
            ////    foreach (DIC_BenhVien_Info bv in lstBenhVien) 
            ////    {
            ////        if (bv.ID == objHocvien.IdBenhVienCongTac) 
            ////        {
            ////            objNeedPrint.DonViCongTac = bv.Ten;
            ////        }
            ////    }

            ////    chungchi.ListChungChi.Add(objNeedPrint);
            ////    ExportDaoTao daotao = new ExportDaoTao();
            ////    daotao.ExportGiayChungChi(chungchi);
            ////}
            ////else { 
            ////    // neu la hoc vien kem cap
            ////    // neu la hoc vien lien tuc theo lop
            ////    DT_GiayChungNhan chungnhan = new DT_GiayChungNhan();
            ////    chungnhan.ListChungNhan = new List<ChungNhan>();
            ////    ChungNhan objNeedPrint = new ChungNhan();

            ////    objNeedPrint.ThongTin = string.Format("{0}, Ngày {1} tháng {2} năm {3}", "Hà Nội", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            ////    objNeedPrint.HocVien = objHocvien.HoTen;

            ////    objNeedPrint.KhoaHocHoanThanh = objHocvien.NoiDungDaoTao;

            ////    objNeedPrint.NgayBatDau = objHocvien.NgayBatDau;
            ////    objNeedPrint.NgayKetThuc = objHocvien.NgayKetThuc;
            ////    objNeedPrint.NgaySinh = objHocvien.NgaySinh;
            ////    objNeedPrint.SoTietHoc = "150 tiết";

            ////    DIC_HocVi_Coll lstTrinhDo = dropDownTrinhDo.GetListData();
            ////    foreach (DIC_HocVi_Info trinhdo in lstTrinhDo)
            ////    {
            ////        if (trinhdo.ID == objHocvien.IdTrinhDo)
            ////        {
            ////            objNeedPrint.TrinhDo = trinhdo.TenHocVi;
            ////            break;
            ////        }
            ////    }
            ////    DIC_BenhVien_Coll lstBenhVien = dropDownBenhVien.GetListData();
            ////    foreach (DIC_BenhVien_Info bv in lstBenhVien)
            ////    {
            ////        if (bv.ID == objHocvien.IdBenhVienCongTac)
            ////        {
            ////            objNeedPrint.DonViCongTac = bv.Ten;
            ////        }
            ////    }

            ////    chungnhan.ListChungNhan.Add(objNeedPrint);
            ////    ExportDaoTao daotao = new ExportDaoTao();
            ////    daotao.ExportGiayChungNhan(chungnhan);
            ////}
        }

        private void radTextBoxHoTen_Leave(object sender, EventArgs e)
        {
        }

        private void radTextBoxCMT_Leave(object sender, EventArgs e)
        {
            int id = DT_LienTuc_HocVien_Coll.DaTonTaiChungCMT(radTextBoxCMT.Text);
            if (id > 0) {
                if (NotifyHocVienExist()) {
                    DT_LienTuc_HocVien obj = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(id);
                    if (obj != null)
                    {
                        objHocvien = GetClone(obj);
                        loadGUI();
                    }
                }
            }
        }

        private bool NotifyHocVienExist()
        {
            string strMessge = "Học viên đã tồn tại. Bạn có muốn nhập thông tin có sẵn ?";
            string strCaption = "Xác nhận lại hành động";

            if (MessageBox.Show(strMessge, strCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                return true;
            else
                return false;
        }

        private void loadGUI() {
            dropDownLopHocLienTucKhung.Selected_ID = objHocvien.IdKhungLopHoc;
            dropDownChuyenNganh.Selected_ID = objHocvien.IdChuyenNganh;
            dropDownChuyenKhoa1.Selected_ID = objHocvien.IdChuyenNganhDangKi;
            dropDownTinhThanh.Selected_ID = objHocvien.IdTinhThanh;
            dropDownTrinhDo.Selected_ID = objHocvien.IdTrinhDo;
            dropDownBenhVien.Selected_ID = objHocvien.IdBenhVienCongTac;

            netLink_DatePickerCapNgay.Value_String = objHocvien.NgayCapCMT;
            netLink_DatePickerKetThuc.Value_String = objHocvien.NgayKetThuc;
            netLink_DatePickerNgayBatDau.Value_String = objHocvien.NgayBatDau;
            netLink_DatePickerNgayDangKy.Value_String = objHocvien.NgayDangKi;
            netLink_DatePickerNgaySinh.Value_String = objHocvien.NgaySinh;
            radDropDownListTrangThai.Text = objHocvien.TrangThai;
            if (objHocvien.IdBoPhan > 0) {
                dropDownBoPhan1.Selected_ID = objHocvien.IdBoPhan;
            }

            oldHinhThuc = objHocvien.HinhThucHoc;

            if (!string.IsNullOrEmpty(objHocvien.HinhThucHoc))
            {
                if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonKemcap.Text) == 0)
                {
                    radRadioButtonKemcap.IsChecked = true;

                    ChangeVisible(1);
                }
                else if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonTheoLop.Text) == 0)
                {
                    radRadioButtonTheoLop.IsChecked = true;
                    ChangeVisible(2);
                }
            }
            else
            {
                ChangeVisible(0);
            }

            radDropDownListTrangThai.SelectedValue = objHocvien.TrangThai;


            string url = string.Empty;
            if (!string.IsNullOrEmpty(objHocvien.Anh))
            {
                url = string.Format("ftp://{0}:{1}@{2}/{3}", FtpUltilies.USENAME, FtpUltilies.PASSWORD, FtpUltilies.SERVER, objHocvien.Anh);
                pictureBoxAnh.ImageLocation = url;
                pictureBoxAnh.Visible = true;
            }
            else
            {
                pictureBoxAnh.ImageLocation = "";
                pictureBoxAnh.Visible = false;
            }

            pictureBoxLoading.Visible = false;
        }

        private void SetDontAllowEdit() {
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            radButtonSaoluu.Enabled = false;
        }

        private void SetAllowEdit() {
            groupBox2.Enabled = true;
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            radButtonSaoluu.Enabled = true;   
        }

        private bool EnableInChungNhan() { 
            double tong = 0;
            int count = 0;
            
            if (objHocvien.Lan1 != null && objHocvien.Lan1 > 0.001) {
                tong += (double)objHocvien.Lan1;
                count++;
            }

            if (objHocvien.Lan2 != null && objHocvien.Lan2 > 0.001)
            {
                tong += (double)objHocvien.Lan2;
                count++;
            }


            if (objHocvien.Lan3 != null && objHocvien.Lan3 > 0.001)
            {
                tong += (double)objHocvien.Lan3;
                count++;
            }

            if (objHocvien.Lan4 != null && objHocvien.Lan4 > 0.001)
            {
                tong += (double)objHocvien.Lan4;
                count++;
            }

            if (objHocvien.Lan5 != null && objHocvien.Lan5 > 0.001)
            {
                tong += (double)objHocvien.Lan5;
                count++;
            }

            if (objHocvien.DiemThi != null && objHocvien.DiemThi > 0.001)
            {
                tong += (double)objHocvien.DiemThi;
                count++;
            }

            if (count > 0)
            {
                double dtb = Math.Round(tong / count, 2);
                if (dtb > 4)
                    return true;
            }

            return false;

        }

        private void netLink_DatePickerNgayDangKy_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
