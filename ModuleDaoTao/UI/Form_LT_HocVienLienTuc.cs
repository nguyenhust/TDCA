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
using System.Threading;
using System.Data.SqlClient;
using NETLINK.UI.Form;
using AForge.Video;
using AForge.Video.DirectShow;


namespace ModuleDaoTao.UI
{
    public partial class Form_LT_HocVienLienTuc : NETLINK.UI.Dictionary, IFtpHandle
    {
        #region khai bao bien

        private DT_LienTuc_HocVien objHocvien;
        private int idHocvien;
        private DT_LienTuc_HocVien_Coll listHocVien;
        private bool IsRunning = false;
        private int HocVienCount = 0;
        private System.Collections.Generic.Dictionary<string, DT_LienTuc_HocVien_Info> DicHocVien;      
        private string CacheSoCMT = string.Empty;
        private string urlPicture = string.Empty;
        private Thread downloadPic;
        private BienLaiColl obj;

        public static int _IDHocVien;
        public static int DieuKien;
        private int DK;
        private int SoLuong;
        private Decimal DonGia;
        private Decimal ThanhTien;
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        private string filename;
        private Int64 IDNguoiQuanLys;
        private string fileUploaded;

        #endregion


        bool hasModifyImage = false;
        FtpHelper ftpHelper = new FtpHelper();

        private string oldHinhThuc = string.Empty;

        public Form_LT_HocVienLienTuc(FormMode _formMode)
        {
            InitializeComponent();
            IFormatProvider culture = new System.Globalization.CultureInfo("vi-VN", true);
            this.formMode = _formMode;
            OnLoad_SettingForControl();
            ApplyAuthorizationRules();
            radButtonInTheHocVien.Enabled = true;
            radHoc.SelectedValue = "Phiếu thu học phí";
            radMau.Enabled = false;
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = true;
        }

        protected override void FormLoad()
        {
            try
            {
                //Bind data cho drop down list
                OnLoad_BindingDataForDropDownList();

                // Bind data dua theo form mode
                OnLoad_GetDataFormMode();

                Business_BindData(true);
                
                // Xu ly an hien button
                OnLoad_SettingStatusForStudent();
                 
                OnLoad_ThreadingProcess();
                this.radTextBoxCMT.Focus();
                radTextBoxCMT.Focus();
                Decimal HPhiCakhoa = Convert.ToDecimal(radHocPhi.Value);
                Decimal HPhiDaDong = Convert.ToDecimal(txtHPDaDong.Value);
                Decimal KetQua = HPhiCakhoa - HPhiDaDong;
                radSoTienDong.Value = Convert.ToInt32(KetQua);
                //radRadioButtonTheoLop.IsChecked = true;
                if (IDNguoiQuanLys == PTIdentity.IDNguoiDung)
                    btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }

        }

        private void Cam_NeuwFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureVideo.Image = bitmap;
        }


        protected override void Save()
        {
            try
            {
                if (btnSave.Enabled && Business_ValidateDataBeforeSave())
                {
                    if (Business_UploadFile() && UploadFile())
                    {
                        Business_BindData(false);
                        if (Business_IsContinueSaveWithAnDuplicateItem())
                        {
                            if (formMode.IsInsert)
                            {
                                objHocvien.IdNguoiQuanLy = PTIdentity.IDNguoiDung;
                            }
                        
                            objHocvien.ApplyEdit();
                            DT_LienTuc_HocVien otemp = objHocvien.Clone();
                            objHocvien = otemp.Save();
                            DeleteFile();
                            GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Học Viên Liên Tục, Học viên số CMT :" + objHocvien.SoCMT);
                            GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                            objHocvien = DT_LienTuc_HocVien.NewDT_LienTuc_HocVien();

                            if(radRadioButtonTheoLop.IsChecked == true)
                            {
                                objHocvien.IdChuyenNganhDangKi = otemp.IdChuyenNganhDangKi;
                                objHocvien.IdKhungLopHoc = otemp.IdKhungLopHoc;
                                objHocvien.TrangThai = otemp.TrangThai;
                                objHocvien.IdTrinhDo = otemp.IdTrinhDo;
                                objHocvien.IdChuyenNganh = otemp.IdChuyenNganh;
                                objHocvien.TruongTotNghiep = otemp.TruongTotNghiep;
                                objHocvien.SoBang = otemp.SoBang;
                                objHocvien.NamTotNghiep = otemp.NamTotNghiep;
                                objHocvien.NoiCongTac = otemp.NoiCongTac;
                                objHocvien.IdTinhThanh = otemp.IdTinhThanh;
                                objHocvien.DiaChiCoQuan = otemp.DiaChiCoQuan;
                                objHocvien.DienThoaiCoQuan = otemp.DienThoaiCoQuan;
                                objHocvien.DiaChiNhaRieng = otemp.DiaChiNhaRieng;
                                objHocvien.DienThoaiNhaRieng = otemp.DienThoaiNhaRieng;
                                objHocvien.DiDong = otemp.DiDong;
                                objHocvien.Email = otemp.Email;
                                objHocvien.IdBoPhan = otemp.IdBoPhan;
                                objHocvien.NoiDungDaoTao = otemp.NoiCongTac;
                            }
                            Business_BindData(true);
                            if(radRadioButtonKemcap.IsChecked == true)
                            {
                                dropDownChuyenKhoa1.Selected_ID = 0;
                                dropDownChuyenKhoa1.Selected_TextValue = "Chọn chuyên khoa";
                                dropDownLopHocLienTucKhung.Selected_ID = null;
                                dropDownLopHocLienTucKhung.NullText = "Chọn nội dung học";
                            }
                            //this.Close();
                         }
                        
                    }
                    else
                    {
                        GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.FileUploadLoi);
                    }
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        public void OnFtpUpLoadSuccessFully()
        {
            //progressBar1.Visible = false;
            objHocvien.Anh = ftpHelper.OutputFile;
            objHocvien = objHocvien.Save();
            this.pictureBoxLoading.BeginInvoke(new Action(() =>
            {
                this.pictureBoxLoading.Visible = false;
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
            }));
        }

        public void OnFtpUpLoadFailed()
        {
            this.pictureBoxLoading.BeginInvoke(new Action(() =>
            {
                this.pictureBoxLoading.Visible = false;
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
            }));
            MessageBox.Show("Upload ảnh đại diện lỗi");
        }

        /// <summary>
        /// chon anh hien theo ket qua
        /// </summary>
        /// <param name="type">0 for nothing, 1 for kem cap, 2 xep lop,3 thu hanh</param>
        private void ChangeVisible(int type)
        {
            if (type == 0 || type == 2 || type==3)
            {
                radLabelNoidungDT.Visible = false;
                radTextBoxNoiDungDT.Visible = false;
                radLabelNgaybatdau.Visible = false;
                netLink_DatePickerNgayBatDau.Visible = false;
                radLabelKethuc.Visible = false;
                netLink_DatePickerKetThuc.Visible = false;
                radLabelHocphi.Visible = false;
                radHocPhi.Visible = false;
                txtHPDaDong.Visible = false;
                lblHPDaDong.Visible = false;
                radLabelChonLop.Visible = true;
                dropDownLopHocLienTucKhung.Visible = true;
                radSoTienDong.Visible = false;
                lblSTienDong.Visible = false;
                objHocvien.NgayBatDau = null;
                objHocvien.NgayKetThuc = null;

            //    radButtonGiayhen.Visible = false;
                radButtonGiaythuhocphi.Visible = false;
                radButtonTiepnhanHocvien.Visible = false;
                if (idHocvien > 0)
                {
               //     radButtonInChungNhan.Visible = true;
               //     radButtonInChungNhan.Text = "In chứng chỉ";
               //     radButtonInChungNhan2.Visible = true;
               //     radButtonInChungNhan2.Text = "In chứng chỉ M2";
               //     radButtonInChungNhan3.Visible = true;
               //     radButtonInChungNhan3.Text = "In chứng chỉ M3";
                  //  btnInHoaDon.Visible = true;
                }
            }
            else if (type == 1)
            {
                radLabelNoidungDT.Visible = true;
                radTextBoxNoiDungDT.Visible = true;
                radLabelNgaybatdau.Visible = true;
                netLink_DatePickerNgayBatDau.Visible = true;
                radLabelKethuc.Visible = true;
                netLink_DatePickerKetThuc.Visible = true;
                radLabelHocphi.Visible = true;
                radHocPhi.Visible = true;
                txtHPDaDong.Visible = true;
                lblHPDaDong.Visible = true;
                radLabelChonLop.Visible = false;
                dropDownLopHocLienTucKhung.Visible = false;
                dropDownLopHocLienTucKhung.SelectedIndex = -1;
                lblSTienDong.Visible = true;
                radSoTienDong.Visible = true;
                if (idHocvien > 0)
                {
                //    radButtonGiayhen.Visible = true;
                    radButtonGiaythuhocphi.Visible = true;
                    radButtonTiepnhanHocvien.Visible = true;
             
                }
            }
        }

        private void bindData(int type)
        {
            // binding data
            objHocvien.NgayCapCMT = netLink_DatePickerCapNgay.Value_String;
            if (type == 1)
            {
                objHocvien.NgayKetThuc = netLink_DatePickerKetThuc.Value_String;
                objHocvien.NgayBatDau = netLink_DatePickerNgayBatDau.Value_String;
            }
            objHocvien.NgayDangKi = netLink_DatePickerNgayDangKy.Value_String;
            objHocvien.NgaySinh = netLink_DatePickerNgaySinh.Value_String;

            objHocvien.IdBenhVienCongTac = dropDownBenhVien1.Selected_Item != null ? System.Convert.ToInt64(dropDownBenhVien1.Selected_ID) : -1;
        }



        private void radRadioButtonKemcap_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                if (radRadioButtonKemcap.IsChecked)
                {
                    Business_HideControlByHinhThucHoc(TextMessages.Itemvalue.HinhThucHoc_KemCap);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radRadioButtonTheoLop_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                if (radRadioButtonTheoLop.IsChecked)
                {
                    Business_HideControlByHinhThucHoc(TextMessages.Itemvalue.HinhThucHoc_TheoLop);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }


        private void dropDownChuyenKhoa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
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
               cloneObj.NoiCapCMT = dropDownTinhThanh1.Text;
                //objHocvien.TrangThai = (string)dropDownTrangThaiHocVien1.SelectedText;

                if (!radRadioButtonKemcap.IsChecked==false)
                {
                    if (dropDownLopHocLienTucKhung.Selected_ID != null)
                        cloneObj.IdKhungLopHoc = (int)dropDownLopHocLienTucKhung.Selected_ID;
                }
                else
                {
                    int count = DT_LienTuc_HocVien_Coll.DataPortal_FetchCountHocVienKemCap(Convert.ToDateTime(objHocvien.NgayBatDau));
                    cloneObj.MaHocVien = Business_CreateMaHocVienKemCap(count + 1);
                    cloneObj.STTHocVienKemCap = (count + 1).ToString();
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

                cloneObj.IdBenhVienCongTac = dropDownBenhVien1.Selected_Item != null ? System.Convert.ToInt64(dropDownBenhVien1.Selected_ID) : -1;
                cloneObj.IdBoPhan = dropDownBoPhan1.Selected_Item != null ? System.Convert.ToInt32(dropDownBoPhan1.Selected_ID) : -1;
                cloneObj.MaSoThue = objHocvien.MaSoThue;
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
            cloneObj.MaSoThue = objHocvien.MaSoThue;
            return cloneObj;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|jpeg files (*.jpeg)|*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string strFileName = openFileDialog.FileName;

                    if (strFileName == string.Empty)
                        return;

                    urlPicture = strFileName;
                    pictureBoxAnh.ImageLocation = strFileName;
                    pictureBoxAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                    hasModifyImage = true;
                    pictureBoxAnh.Visible = true;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonGiayhen_Click(object sender, EventArgs e)
        {
            try
            {
                G002_GiayHenTraTheHocVien trathe = new G002_GiayHenTraTheHocVien();
                if (dropDownChuyenKhoa1.Selected_Item != null)
                    trathe.DiaDiem = dropDownChuyenKhoa1.Selected_TextValue.ToString();
                trathe.GioiTinh = objHocvien.GioiTinh;
                trathe.HoTenHocVien = objHocvien.HoTen;
                trathe.NgaySinh = objHocvien.NgaySinh;

                trathe.NgayViet = GlobalCommon.StringProcess.ForReport.NgayThangNam(DateTime.Now);
                if (dropDownBenhVien1.Selected_Item != null)
                    trathe.NoiCongTac = dropDownBenhVien1.Selected_TextValue.ToString();
                trathe.NoiDungDangKy = objHocvien.NoiDungDaoTao;


                if (dropDownTrinhDo.Selected_Item != null)
                    trathe.TrinhDo = dropDownTrinhDo.Selected_TextValue.ToString();
                trathe.TongSoThoiGianHoc = GlobalCommon.StringProcess.ForReport.TongThoiGianHoc(Convert.ToDateTime(objHocvien.NgayBatDau).ToString("dd/MM/yyyy"), Convert.ToDateTime(objHocvien.NgayKetThuc).ToString("dd/MM/yyyy")); //objHocvien.SoTiet.ToString() + " tiết";
                trathe.ThoiGianTraThe1 = GlobalCommon.StringProcess.ForReport.NgayThangNam(DateTime.Now.AddDays(7));
                trathe.ThoiGianTraThe2 = GlobalCommon.StringProcess.ForReport.NgayThangNam(DateTime.Now.AddDays(14));
                ExportDaoTao daotao = new ExportDaoTao();


                ReportDocument doc = daotao.G002_GiayHenTraTheHocVien(new List<ExportLib.Entities.DaoTao.G002_GiayHenTraTheHocVien>() { trathe });
                FormMode newmode = new FormMode();
                newmode.Item = doc;
                NetLinkReport fr = new NetLinkReport(newmode);
                fr.Show();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonGiaythuhocphi_Click(object sender, EventArgs e)
        {
            string strSoThangHoc = GlobalCommon.StringProcess.ForReport.GetSoThangHoc(Convert.ToInt64(objHocvien.IdKhungLopHoc));
            strSoThangHoc = strSoThangHoc.Trim();
            int vt = strSoThangHoc.IndexOf(" ");
            try
            {
                if (radHP.IsChecked == true)
               {

                    G003_GiayDeNghiThuTienHocPhi denghithuhocphi = new G003_GiayDeNghiThuTienHocPhi();

                    denghithuhocphi.MaHocVienBarCode = (GlobalCommon.GetBarCode(Convert.ToString(objHocvien.Id), false, BarcodeLib.TYPE.CODE128, 420, 90));

                    if (dropDownChuyenKhoa1.Selected_Item != null)
                        denghithuhocphi.DiaDiemDangKy = dropDownChuyenKhoa1.Selected_TextValue.ToString();
                    denghithuhocphi.GioiTinh = objHocvien.GioiTinh;
                    if (objHocvien.HinhThucHoc.CompareTo(radRadioButtonTheoLop.Text) >0 && string.IsNullOrEmpty(objHocvien.MaLopHoc))
                    {
                        GlobalCommon.ShowErrorMessager("Học viên chưa được xếp lớp!");
                        return;
                    }                   
                    int month = GlobalCommon.DateTimeProcess.MinusDateTime_Month(objHocvien.NgayBatDau, objHocvien.NgayKetThuc);
                    if (!string.IsNullOrEmpty(strSoThangHoc))
                        month = Convert.ToInt32(strSoThangHoc.Substring(0,vt));
                    double sotienmoithang = 0;
                    if (!string.IsNullOrEmpty(objHocvien.TongHocPhi))
                        sotienmoithang = Convert.ToInt64(Convert.ToDouble(radSoTienDong.Value)) / month;            
                    if(DieuKien==1 || DieuKien==2)
                    {
                        FromNhapSoTien frm = new FromNhapSoTien();
                        frm.ShowDialog();                    
                        SoLuong = ModuleDaoTao.UI.FromNhapSoTien.soLuong;
                        DonGia = ModuleDaoTao.UI.FromNhapSoTien.donGia;
                        ThanhTien = ModuleDaoTao.UI.FromNhapSoTien.thanhTien;
                        string TongHocPhiStr1 = string.Format("Số lượng học viên :{0} x Đơn giá :{1} = {2} VND", GlobalCommon.ConvertMoney(SoLuong), GlobalCommon.ConvertMoney(DonGia), GlobalCommon.ConvertMoney(ThanhTien));
                        denghithuhocphi.BangChu = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(ThanhTien);
                        denghithuhocphi.TongTienHocPhi = TongHocPhiStr1;                    
                    }
                    else
                    {
                        string TongHocPhiStr4 = string.Empty;
                        if (sotienmoithang < 0)
                        {
                            TongHocPhiStr4 = "0 x 1 tháng = 0 VND";
                            denghithuhocphi.BangChu = "Không đồng";
                        }
                        else
                        {
                            TongHocPhiStr4 = string.Format("{0} x {1} = {2} VNĐ", GlobalCommon.ConvertMoney(sotienmoithang), month, GlobalCommon.ConvertMoney(Convert.ToDecimal(radSoTienDong.Value)));
                            denghithuhocphi.BangChu = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(Convert.ToDecimal(radSoTienDong.Value));
                        }
                                denghithuhocphi.TongTienHocPhi = TongHocPhiStr4;                                              
                    }                                  
                    denghithuhocphi.HoTenHocVien = objHocvien.HoTen;
                    denghithuhocphi.NgaySinh = objHocvien.NgaySinh;
                    denghithuhocphi.NgayViet = GlobalCommon.StringProcess.ForReport.NgayThangNam(DateTime.Now);
                    if (dropDownBenhVien1.Selected_Item != null)
                        denghithuhocphi.NoiCongTac = dropDownBenhVien1.Selected_TextValue.ToString();
                    denghithuhocphi.TongSoThoiGianHoc = GlobalCommon.StringProcess.ForReport.TongThoiGianHocHV(objHocvien.NgayBatDau, objHocvien.NgayKetThuc, GlobalCommon.StringProcess.ForReport.GetSoThangHoc(Convert.ToInt64(objHocvien.IdKhungLopHoc)));                    
                    if (dropDownTrinhDo.Selected_Item != null)
                        denghithuhocphi.TrinhDo = dropDownTrinhDo.Selected_TextValue.ToString();
                    denghithuhocphi.NoiDungHoc = objHocvien.NoiDungDaoTao;
                    denghithuhocphi.IDHocVien = objHocvien.Id;
                    ExportDaoTao daotao = new ExportDaoTao();

                    ReportDocument doc = daotao.G003_GiayDeNghiThuTienHocPhi(new List<ExportLib.Entities.DaoTao.G003_GiayDeNghiThuTienHocPhi>() { denghithuhocphi });
                    if (DieuKien == 0)
                    {
                        doc.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN HỌC PHÍ");
                        doc.SetParameterValue("prmNoiDung", "TCKT thu tiền học phí cho học viên với mức kinh phí là :");
                    }
                    if (DieuKien == 1)
                    {
                        doc.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM THẺ HỌC VIÊN");
                        doc.SetParameterValue("prmNoiDung", "TCKT thu tiền làm thẻ cho học viên với mức kinh phí là :");
                    }
                    if (DieuKien == 2)
                    {
                        doc.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM CHỨNG CHỈ");
                        doc.SetParameterValue("prmNoiDung", "TCKT thu tiền làm chứng chỉ cho học viên với mức kinh phí là :");
                    }
                    if(objHocvien.Id!=null)
                    {
                        doc.SetParameterValue("prmID", "IDHV");
                    }
                        FormMode newmode = new FormMode();
                        newmode.Item = doc;
                        if (DieuKien == 0  || DonGia != 0 && SoLuong != 0)
                    {
                        NetLinkReport fr = new NetLinkReport(newmode);
                        fr.Show();
                    }                               
                }
                else if (radRadioInThe.IsChecked == true)
                {
                    try
                    {
                        if (Business_ValidateDataBeforeSave())
                        {
                            objHocvien.CancelEdit();
                            if (Business_UploadFile())
                            {
                                if (!string.IsNullOrEmpty(urlPicture))
                                    objHocvien.Anh = urlPicture;
                                objHocvien.TongSoLanInThe = objHocvien.TongSoLanInThe + 1;
                                objHocvien.ApplyEdit();
                                objHocvien.Save();
                                GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Học Viên Liên Tục, Học viên số CMT :" + objHocvien.SoCMT);
                                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);

                                //Business_BindData(true);
                                //if (radRadioButtonKemcap.IsChecked == true)
                                //{
                                //    dropDownChuyenKhoa1.Selected_ID = 0;
                                //    dropDownChuyenKhoa1.Selected_TextValue = "Chọn chuyên khoa";
                                //    dropDownLopHocLienTucKhung.Selected_ID = null;
                                //    dropDownLopHocLienTucKhung.NullText = "Chọn nội dung học";
                                //}
                                ////this.Close();                        
                            }
                            else
                            {
                                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.FileUploadLoi);
                            }
                        }
                        if (downloadPic.IsAlive)
                        {
                            GlobalCommon.ShowMessageInformation("chưa download xong ảnh");
                            return;
                        }
                        // neu la hoc vien kem cap
                        string temp = Path.GetTempPath();
                        string imgFileName = objHocvien.MaHocVien + ".jpg";
                        imgFileName = Path.Combine(temp, imgFileName);
                        pictureBoxAnh.Image.Save(imgFileName);

                        DT_TheHocVienLienTuc lstHocvienLt = new DT_TheHocVienLienTuc();
                        lstHocvienLt.ListTheHocVienLienTuc = new List<TheHocVienLienTuc>();

                        TheHocVienLienTuc needPrint = new TheHocVienLienTuc();
                        needPrint.TenHocVien = GlobalCommon.StringProcess.ForReport.VietTatMotSoKiTu(objHocvien.HoTen);
                        needPrint.MaHocVien = objHocvien.MaHocVien;
                       
                        needPrint.AnhHocVien = temp + "\\" + objHocvien.MaHocVien + ".jpg";
                        if (dropDownTrinhDo.Selected_TextValue != null)
                        {
                            needPrint.TrinhDo = dropDownTrinhDo.Selected_TextValue.ToString();
                        }
                        needPrint.KhoaHoc = objHocvien.NoiDungDaoTao;
                        needPrint.ThoiGian = string.Format("{0} - {1}", objHocvien.NgayBatDau, objHocvien.NgayKetThuc);
                        needPrint.SoCMT = objHocvien.SoCMT;
                        needPrint.TruongHoc = objHocvien.TruongTotNghiep;
                        lstHocvienLt.ListTheHocVienLienTuc.Add(needPrint);
                        ExportDaoTao daotao = new ExportDaoTao();
                        daotao.ExportTheHocVienLienTuc(lstHocvienLt, Convert.ToInt32(radDropDoiTuongIn.SelectedIndex));

                        //GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.ExportSuccess);
                        int tslinthe = 0;
                        if (int.TryParse(objHocvien.TongSoLanInThe.ToString(), out tslinthe))
                        {
                            objHocvien.TongSoLanInThe = tslinthe++;
                            objHocvien.ApplyEdit();
                            objHocvien.Save();
                        }
                    }
                    catch (Exception ex)
                    {
                        GlobalCommon.ShowErrorMessager(ex);
                    }
                }
                else
                {
                    if (DK == 0)
                        InChungChi(1);
                    if (DK == 1)
                        InChungChi(2);
                    if (DK == 2)
                        InChungChi(3);
                    if (DK == 3)
                        InChungChi(4);                 
                }
            }

            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonTiepnhanHocvien_Click(object sender, EventArgs e)
        {
            try
            {
                if (objHocvien == null || string.IsNullOrEmpty(objHocvien.HoTen))
                {
                    GlobalCommon.ShowErrorMessager("Bạn phải lưu học viên trước khi in giấy");
                }
                else
                {
                    G004_GiayDeNghiTiepNhanHocVien giaytiepnhan = new G004_GiayDeNghiTiepNhanHocVien();
                    giaytiepnhan.GioiTinh = objHocvien.GioiTinh;
                    giaytiepnhan.HoTenHocVien = objHocvien.HoTen;
                    giaytiepnhan.NgaySinh = objHocvien.NgaySinh;
                    DateTime dt = Convert.ToDateTime(objHocvien.NgayBatDau);
                    if (objHocvien.HinhThucHoc == "Kèm cặp")
                        giaytiepnhan.NgayViet = " ngày " + dt.Day + " tháng " + dt.Month + " năm " + dt.Year;
                    else
                        giaytiepnhan.NgayViet = "ngày .......tháng.......năm 20......";
                    giaytiepnhan.NoiDungHoc = objHocvien.NoiDungDaoTao;
                    giaytiepnhan.DienThoai = objHocvien.DiDong;
                  
                    //giaytiepnhan.TongSoThoiGianHoc = GlobalCommon.StringProcess.ForReport.TongThoiGianHoc(objHocvien.NgayBatDau, objHocvien.NgayKetThuc);
                    giaytiepnhan.TongSoThoiGianHoc = GlobalCommon.StringProcess.ForReport.TongThoiGianHocHV(objHocvien.NgayBatDau, objHocvien.NgayKetThuc, GlobalCommon.StringProcess.ForReport.GetSoThangHoc(Convert.ToInt64(objHocvien.IdKhungLopHoc)));
                    if (dropDownTrinhDo.Selected_Item != null)
                        giaytiepnhan.TrinhDo = dropDownTrinhDo.Selected_TextValue.ToString();
                    if (dropDownChuyenKhoa1.Selected_Item != null)
                        giaytiepnhan.Khoa = dropDownChuyenKhoa1.Selected_TextValue.ToString();
                    giaytiepnhan.DiaDiemDangKy = giaytiepnhan.Khoa;
                    if (dropDownBenhVien1.Selected_Item != null)
                        giaytiepnhan.NoiCongTac = dropDownBenhVien1.Selected_TextValue.ToString();
                    ExportDaoTao daotao = new ExportDaoTao();
                    ReportDocument doc = daotao.G004_GiayDeNghiTiepNhanHocVien(new List<ExportLib.Entities.DaoTao.G004_GiayDeNghiTiepNhanHocVien>() { giaytiepnhan });
                    FormMode newmode = new FormMode();
                    newmode.Item = doc;
                    NetLinkReport fr = new NetLinkReport(newmode);
                    fr.Show();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonInChungchi_Click(object sender, EventArgs e)
        {
            //string strSoThangHoc = GlobalCommon.StringProcess.ForReport.GetSoThangHoc(Convert.ToInt64(objHocvien.IdKhungLopHoc));
            try
            {
                G001_GiayHenTraChungChiHocVien chungchi = new G001_GiayHenTraChungChiHocVien();

                chungchi.GioiTinh = objHocvien.GioiTinh;
                chungchi.HoTenHocVien = objHocvien.HoTen;
                chungchi.KetQuaHocTap = objHocvien.XepLoai;
                chungchi.NgaySinh = objHocvien.NgaySinh;
                chungchi.NgayViet = GlobalCommon.StringProcess.ForReport.NgayThangNam(DateTime.Now);
                chungchi.NoiDungDangKy = objHocvien.NoiDungDaoTao;
                chungchi.CanBoTiepNhan = PTIdentity.FullName;
                chungchi.ThoiGianTraThe1 = GlobalCommon.StringProcess.ForReport.NgayThangNam(DateTime.Now.AddDays(7));
                chungchi.ThoiGianTraThe2 = GlobalCommon.StringProcess.ForReport.NgayThangNam(DateTime.Now.AddDays(14));
                chungchi.TongSoThoiGianHoc = GlobalCommon.StringProcess.ForReport.TongThoiGianHocHV(objHocvien.NgayBatDau, objHocvien.NgayKetThuc,GlobalCommon.StringProcess.ForReport.GetSoThangHoc(Convert.ToInt64(objHocvien.IdKhungLopHoc)));
                if (dropDownBenhVien1.Selected_Item != null)
                    chungchi.NoiCongTac = dropDownBenhVien1.Selected_TextValue.ToString();
                if (dropDownTrinhDo.Selected_Item != null)
                    chungchi.TrinhDo = dropDownTrinhDo.Selected_TextValue.ToString();
                if (dropDownChuyenKhoa1.Selected_Item != null)
                    chungchi.DiaDiem = dropDownChuyenKhoa1.Selected_TextValue.ToString();

                ExportDaoTao daotao = new ExportDaoTao();
                ReportDocument doc = daotao.G001_GiayHenTraChungChiHocVien(new List<ExportLib.Entities.DaoTao.G001_GiayHenTraChungChiHocVien>() { chungchi });

                FormMode newmode = new FormMode();
                newmode.Item = doc;
                NetLinkReport fr = new NetLinkReport(newmode);
                fr.Show();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void dropDownBenhVien1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DIC_BenhVien_Info selectedItem = (DIC_BenhVien_Info)dropDownBenhVien1.Selected_Item;

                if (selectedItem != null)
                {
                    objHocvien.DiaChiCoQuan = selectedItem.DiaChi;
                    radTextBoxDiachiCoquan.Text = selectedItem.DiaChi;
                    dropDownTinhThanh.Selected_ID = selectedItem.IDTinh;
                    radTextBoxDienThoaiCoquan.Text = selectedItem.DienThoai;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonInTheHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (Business_ValidateDataBeforeSave())
                {
                    objHocvien.CancelEdit();
                    if (Business_UploadFile())
                    {
                            if (!string.IsNullOrEmpty(urlPicture))
                                objHocvien.Anh = urlPicture;
                        
                            objHocvien.ApplyEdit();
                            objHocvien.Save();
                            GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Học Viên Liên Tục, Học viên số CMT :" + objHocvien.SoCMT);
                            GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                            
                            Business_BindData(true);
                            if (radRadioButtonKemcap.IsChecked == true)
                            {
                                dropDownChuyenKhoa1.Selected_ID = 0;
                                dropDownChuyenKhoa1.Selected_TextValue = "Chọn chuyên khoa";
                                dropDownLopHocLienTucKhung.Selected_ID = null;
                                dropDownLopHocLienTucKhung.NullText = "Chọn nội dung học";
                            }
                            //this.Close();                        
                    }
                    else
                    {
                        GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.FileUploadLoi);
                    }
                }
                if (downloadPic.IsAlive)
                {
                    GlobalCommon.ShowMessageInformation("chưa download xong ảnh");
                    return;
                }
                // neu la hoc vien kem cap
                string temp = Path.GetTempPath();
                string imgFileName = objHocvien.MaHocVien + ".jpg";
                imgFileName = Path.Combine(temp, imgFileName);
                pictureBoxAnh.Image.Save(imgFileName);

                DT_TheHocVienLienTuc lstHocvienLt = new DT_TheHocVienLienTuc();
                lstHocvienLt.ListTheHocVienLienTuc = new List<TheHocVienLienTuc>();

                TheHocVienLienTuc needPrint = new TheHocVienLienTuc();
                needPrint.TenHocVien = GlobalCommon.StringProcess.ForReport.VietTatMotSoKiTu(objHocvien.HoTen);
                needPrint.MaHocVien = objHocvien.MaHocVien;
                needPrint.AnhHocVien = temp + "\\" + objHocvien.MaHocVien + ".jpg";
                if (dropDownTrinhDo.Selected_TextValue != null)
                {
                    needPrint.TrinhDo = dropDownTrinhDo.Selected_TextValue.ToString();
                }
                needPrint.KhoaHoc = objHocvien.NoiDungDaoTao;
                needPrint.ThoiGian = string.Format("{0} - {1}", objHocvien.NgayBatDau, objHocvien.NgayKetThuc);
                needPrint.SoCMT = objHocvien.SoCMT;
                lstHocvienLt.ListTheHocVienLienTuc.Add(needPrint);
                ExportDaoTao daotao = new ExportDaoTao();
                daotao.ExportTheHocVienLienTuc(lstHocvienLt, Convert.ToInt32(0));
                
                //GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.ExportSuccess);
                int tslinthe = 0;
                if (int.TryParse(objHocvien.TongSoLanInThe.ToString(), out tslinthe))
                {
                    objHocvien.TongSoLanInThe = tslinthe++;
                    objHocvien.ApplyEdit();
                    objHocvien.Save();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonInChungNhan_Click(object sender, EventArgs e)
        {
            InChungChi(1);
        }
        private void InChungChi(int tp)
        {
            try
            {
                int type = tp;
                DT_GiayChungChi chungchi = new DT_GiayChungChi();
                chungchi.ListChungChi = new List<ChungChi>();
                //string today = string.Format("{0}, Ngày {1} tháng {2} năm {3}", "Hà Nội", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                //DT_LienTuc_KhungLopHoc_Coll lstKhungLopHoc = dropDownLopHocLienTucKhung.GetListData();
                DateTime dt = Convert.ToDateTime(objHocvien.NgayKetThuc);
                string today = "Hà nội," + " ngày......." + "tháng......." + "năm........";
                string ngay = "Hà nội," + " ngày " + dt.Day + " tháng " + dt.Month + " năm " + dt.Year;
                DT_LienTuc_KhungLopHoc_Coll lstKhungLopHoc = dropDownLopHocLienTucKhung.GetListData();
                ChungChi objNeedPrint = new ChungChi();
                //if (objHocvien.HinhThucHoc == "Kèm cặp")
                //{
                    //objNeedPrint.ThongTin = today;
                    //objNeedPrint.SoTietHoc = objHocvien.SoTiet.ToString() + " tiết học/ hours";
                //}
                //else
                //{
                objNeedPrint.ThongTin = ngay;
                objNeedPrint.SoTietHoc = objHocvien.SoTietHoc.ToString() + " tiết học/ hours";
                //}
                ////ChungChi objNeedPrint = new ChungChi();
                objNeedPrint.HocVien = objHocvien.HoTen;
                objNeedPrint.KhoaHocHoanThanh = objHocvien.NoiDungDaoTao;
                objNeedPrint.NgayBatDau = objHocvien.NgayBatDau;
                objNeedPrint.NgayKetThuc = objHocvien.NgayKetThuc;
                objNeedPrint.NgaySinh = objHocvien.NgaySinh;
                objNeedPrint.TrinhDo = objHocvien.TenTrinhDo;
                if (dropDownBenhVien1.Selected_Item != null)
                    objNeedPrint.DonViCongTac = dropDownBenhVien1.Selected_TextValue.ToString();
                //objNeedPrint.MaHocVien = GlobalCommon.StringProcess.ForReport.RemoveSTTInMaHocVien(objHocvien.MaHocVien);
                objNeedPrint.MaHocVien = objHocvien.MaHocVien;
                objNeedPrint.CoVan = string.Empty;
                //if (type == 1)
                //{
                //    objNeedPrint.XepLoaiTitle = objNeedPrint.strXepLoaiTitle;
                //    objNeedPrint.XepLoai = objHocvien.XepLoai == "" ? "Hoàn thành khóa học" : objHocvien.XepLoai;
                //}
                //else if ((type == 3 || type == 2 || type == 4) && objHocvien.HinhThucHoc == "Theo lớp")
                //{
                //    if (type == 3)
                //    {
                //        objNeedPrint.XepLoaiTitle = objNeedPrint.strXepLoaiTitle;
                //        objNeedPrint.XepLoai = objHocvien.XepLoai == "" ? "Hoàn thành khóa học" : objHocvien.XepLoai;
                //        objNeedPrint.DuAn = objNeedPrint.strDuAnNorred;
                //    }
                //    else if (type == 4)
                //    {
                //        objNeedPrint.XepLoaiTitle = objNeedPrint.strXepLoaiTitle;
                //        objNeedPrint.XepLoai = objHocvien.XepLoai == "" ? "Hoàn thành khóa học" : objHocvien.XepLoai;
                //        objNeedPrint.DuAn = objNeedPrint.strDuAn;
                //    }
                //    else
                //    {
                //        //objNeedPrint.CoVan = objNeedPrint.strCoVan;
                //        objNeedPrint.XepLoaiTitle = string.Empty;
                //        objNeedPrint.DuAn = objNeedPrint.strDuAn;
                //    }
                //    //objNeedPrint.XepLoai = string.Empty;
                //}
                //else
                //{
                    objNeedPrint.XepLoai = string.Empty;
                    objNeedPrint.XepLoaiTitle = string.Empty;
                //}
                chungchi.ListChungChi.Add(objNeedPrint);
                ExportDaoTao daotao = new ExportDaoTao();
                if (type == 1)
                {
                    daotao.ExportGiayChungChi(chungchi);
                }
                //if((type == 3 || type == 2 || type == 4 )&& objHocvien.HinhThucHoc == "Theo lớp")
                //{
                //    daotao.ExportGiayChungNhanDA(chungchi);
                //}
                else
                {
                    daotao.ExportGiayChungNhan(chungchi);
                }
                int tongsolanin = 0;
                if (int.TryParse(objHocvien.TongSoLanInGiayChungNhan.ToString(), out tongsolanin))
                {
                    objHocvien.TongSoLanInGiayChungNhan = tongsolanin + 1;
                    objHocvien.TrangThai = DT_Common_value.TT_HocVien_DaCapChungChi;
                    objHocvien.ApplyEdit();
                    objHocvien.Save();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
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
        private void loadGUI()
        {
            if (!string.IsNullOrEmpty(Convert.ToString(objHocvien.Id)))
            {
       //     txtHPDaDong.Text = Convert.ToString(GlobalCommon.GetChiPhiHVDaDong(objHocvien.Id));
                txtHPDaDong.Value = Convert.ToString(objHocvien.SoTien);
            }
            dropDownLopHocLienTucKhung.Selected_ID = objHocvien.IdKhungLopHoc;
            dropDownChuyenNganh.Selected_ID = objHocvien.IdChuyenNganh;
            dropDownChuyenKhoa1.Selected_ID = objHocvien.IdChuyenNganhDangKi;
            dropDownTinhThanh.Selected_ID = objHocvien.IdTinhThanh;
            dropDownTrinhDo.Selected_ID = objHocvien.IdTrinhDo;
            dropDownBenhVien1.Selected_ID = objHocvien.IdBenhVienCongTac;
            dropDownTinhThanh1.Text = objHocvien.NoiCapCMT;
            netLink_DatePickerCapNgay.Value_String = objHocvien.NgayCapCMT;
            netLink_DatePickerKetThuc.Value_String = Convert.ToDateTime(objHocvien.NgayKetThuc).ToString("dd/MM/yyyy");
            netLink_DatePickerNgayBatDau.Value_String = Convert.ToDateTime(objHocvien.NgayBatDau).ToString("dd/MM/yyyy");
            netLink_DatePickerNgayDangKy.Value_String = objHocvien.NgayDangKi;
            netLink_DatePickerNgaySinh.Value_String = objHocvien.NgaySinh;
            radDropDownListTrangThai.Text = objHocvien.TrangThai;
            txtMaSoThue.Text = objHocvien.MaSoThue;
            //if (objHocvien.IdKhungLopHoc != null)
            //txtThoiGianHoc.Text = GlobalCommon.StringProcess.ForReport.GetSoThangHoc(Convert.ToInt64(objHocvien.IdKhungLopHoc));
            if (objHocvien.IdBoPhan > 0)
            {
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
                else if (objHocvien.HinhThucHoc.CompareTo(radThucHanh.Text) == 0)
                {
                    radThucHanh.IsChecked = true;
                    ChangeVisible(3);
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

        private void SetDontAllowEdit()
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            btnSave.Enabled = false;
            btnClose.Enabled = false;
            radButtonSaoluu.Enabled = false;
         //   btnInHoaDon.Enabled = false;
           
          
        }

        private void SetAllowEdit()
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            btnSave.Enabled = true;
            btnClose.Enabled = true;
            radButtonSaoluu.Enabled = true;
       //     btnInHoaDon.Enabled = true;
           
        }

        private bool EnableInChungNhan()
        {
            double tong = 0;
            int count = 0;

            if (objHocvien.Lan1 != null && objHocvien.Lan1 > 0.001)
            {
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

        ///// Quang BH////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void OnLoad_BindingDataForDropDownList()
        {
            dropDownTrinhDo.FillData(1);
            dropDownTinhThanh.FillData(1);
            dropDownChuyenNganh.FillData(1);
            dropDownChuyenKhoa1.FillData(1);
            dropDownBenhVien1.FillData(1);
            dropDownBoPhan1.FillData(1);
            dropDownLopHocLienTucKhung.FillData(1);
            dropDownLopHocLienTucKhung.FilterData(FilterColumn.IDKhoaNgoai64, -1);
            dropDownTinhThanh1.FillData(2);
            radDropDownListTrangThai.DataSource = TrangThaiCuaHocVien_Coll.GetTrangThaiCuaHocVien_Coll();
            radDropTruongTotNghiep.DataSource = DIC_TruongTotNghiep_Coll.GetDIC_TruongTotNghiep_Coll();
        }

        private void OnLoad_SettingForControl()
        {
            netLink_DatePickerKetThuc.MyName = "Ngày kết thúc";
            netLink_DatePickerNgayBatDau.MyName = "Ngày bắt đầu";
            netLink_DatePickerCapNgay.MyName = "Ngày cấp CMT";
            netLink_DatePickerNgayDangKy.MyName = "Ngày đăng kí";
            netLink_DatePickerNgaySinh.MyName = "Ngày sinh";
        }
        /// <summary>
        /// An hien cac button in an
        /// </summary>
        private void OnLoad_SettingStatusForStudent()
        {
            DateTime dateNgayKetThuc;
            //Kiem tra xem co phai la edit hay khong
            if (formMode.IsEdit && DateTime.TryParse(objHocvien.NgayKetThuc, out dateNgayKetThuc))
            {
                // Neu Hoc Vien da hoc xong
                if (DateTime.Compare(dateNgayKetThuc, DateTime.Now) <= 0)
                {
                    // Neu co quyen sua hoc vien da hoc
                    if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_DaHoc_Edit))
                    {
                        Business_HideControlByPermission(false);
                    }
                    else
                    {
                        Business_HideControlByPermission(true);
                    }
                }
                else
                {
                    if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_DaHoc_Edit) || objHocvien.IdNguoiQuanLy == PTIdentity.IDNguoiDung || GlobalCommon.CheckCanBoPhuTrach(PTIdentity.IDNguoiDung, objHocvien.IdKhungLopHoc))
                    {
                        Business_HideControlByPermission(false);
                    }
                    else
                    {
                        Business_HideControlByPermission(true);
                    }
                }
            }
            // neu la tao moi thi khong the sao luu
            if (formMode.IsInsert)
            {
                radButtonSaoluu.Enabled = false;
                //radDropDownListTrangThai.Text = TextMessages.Itemvalue.TrangThaiHoc_ChuaHoc;
                radDropDownListTrangThai.SelectedIndex = 0;
            }
            Business_HideControlByStudentStatus(formMode.IsInsert);
        }

        /// <summary>
        /// Nạp các thông tin từ FormMode
        /// </summary>
        private void OnLoad_GetDataFormMode()
        {
            if (formMode.IsInsert)
            {
                idHocvien = 0;
                objHocvien = DT_LienTuc_HocVien.NewDT_LienTuc_HocVien();
            }
            else
            {
                idHocvien = formMode.Id;
                objHocvien = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(idHocvien);
            }
            if (formMode.ItemColl != null)
            {
                DicHocVien = (Dictionary<string, DT_LienTuc_HocVien_Info>)formMode.ItemColl;
            }
        }

        private void OnLoad_ThreadingProcess()
        {
            try
            {
                if (formMode.IsInsert)
                {
                    Thread thread = new Thread(new ThreadStart(Thread_LoadMaHocVienLienTucKemCap));
                    thread.Start();
                    thread.Join();
                }
            }
            catch
            {
            }
        }

        private void Thread_LoadMaHocVienLienTucKemCap()
        {
            if (HocVienCount == 0)
                HocVienCount = DT_LienTuc_HocVien_Coll.DataPortal_FetchCountHocVienKemCap(DateTime.Now) + 1;
        }

        private void Business_BindData(bool isLoad, DT_LienTuc_HocVien obj)
        {
            if (isLoad)
            {
                radTextBoxHoTen.Text = obj.HoTen;
                dropDownGioiTinh.Text = obj.GioiTinh;
                radTextBoxCMT.Text = obj.SoCMT;
                dropDownTinhThanh1.Text= obj.NoiCapCMT;
                radDropTruongTotNghiep.Text = obj.TruongTotNghiep;
                radtxtSoBang.Text = obj.SoBang;
                radTextBoxDiachiCoquan.Text = obj.DiaChiCoQuan;
                radTextBoxDienThoaiCoquan.Text = obj.DienThoaiCoQuan;
                radTextBoxDiaChiNhaRieng.Text = obj.DiaChiNhaRieng;
                radTextBoxDienThoaiNhaRieng.Text = obj.DienThoaiNhaRieng;
                radTextBoxDiDong.Text = obj.DiDong;
                radTextBoxEmail.Text = obj.Email;
                radHocPhi.Value = obj.TongHocPhi;
                radTextBoxNoiDungDT.Text = obj.NoiDungDaoTao;
                radDropDownListTrangThai.Text = obj.TrangThai;
                txtMaSoThue.Text = obj.MaSoThue;
                //if (objHocvien.IdKhungLopHoc != null)
                //txtThoiGianHoc.Text = GlobalCommon.StringProcess.ForReport.GetSoThangHoc(Convert.ToInt64(objHocvien.IdKhungLopHoc));
                pictureBoxAnh.Image = ModuleDaoTao.Properties.Resources.face;
                pictureVideo.Image = null;
           //     radSoTienDong.Text = obj.TongHocPhi;
                if (obj.NamTotNghiep > 0)
                    radtxtNamTotNghiep.Text = obj.NamTotNghiep.ToString();
                else
                    radtxtNamTotNghiep.Text = string.Empty;
                netLink_DatePickerNgaySinh.Value_String = obj.NgaySinh == "" ? obj.NgaySinh : Convert.ToDateTime(obj.NgaySinh).ToString("dd/MM/yyyy");
                netLink_DatePickerCapNgay.Value_String = obj.NgayCapCMT == "" ? obj.NgayCapCMT : Convert.ToDateTime(obj.NgayCapCMT).ToString("dd/MM/yyyy");
                //Neu la them moi thi ngay dang ki se lay ngay he thong
                if (formMode.IsInsert || string.IsNullOrEmpty(obj.NgayDangKi))
                {
                    netLink_DatePickerNgayDangKy.Value = GlobalCommon.GetTimeServer();
                }
                else
                    netLink_DatePickerNgayDangKy.Value_String = obj.NgayDangKi == "" ? obj.NgayDangKi : Convert.ToDateTime(obj.NgayDangKi).ToString("dd/MM/yyyy"); 
                netLink_DatePickerNgayBatDau.Value_String = obj.NgayBatDau == "" ? obj.NgayBatDau : Convert.ToDateTime(obj.NgayBatDau).ToString("dd/MM/yyyy"); 
                netLink_DatePickerKetThuc.Value_String = obj.NgayKetThuc == "" ? obj.NgayKetThuc : Convert.ToDateTime(obj.NgayKetThuc).ToString("dd/MM/yyyy"); 
                dropDownTrinhDo.Selected_ID = obj.IdTrinhDo;
                dropDownChuyenNganh.Selected_ID = obj.IdChuyenNganh;
                dropDownBenhVien1.Selected_ID = obj.IdBenhVienCongTac;
                dropDownTinhThanh.Selected_ID = obj.IdTinhThanh;
                if (!string.IsNullOrEmpty(Convert.ToString(objHocvien.Id)))
                {
                  //  txtHPDaDong.Text = Convert.ToString(GlobalCommon.GetChiPhiHVDaDong(objHocvien.Id));
                    txtHPDaDong.Value =Convert.ToString(objHocvien.SoTien);
                }

                if (obj.HinhThucHoc == "Kèm cặp")
                {
                    dropDownBoPhan1.Selected_ID = obj.IdBoPhan == null ? 0 : obj.IdBoPhan;
                    dropDownChuyenKhoa1.Selected_ID = obj.IdChuyenNganhDangKi == null ? 0 : obj.IdChuyenNganhDangKi;
                    dropDownLopHocLienTucKhung.Selected_ID = obj.IdKhungLopHoc == null ? 0 : obj.IdKhungLopHoc;
                    radRadioButtonTheoLop.IsChecked = false;
                    radRadioButtonKemcap.IsChecked = true;
                    radThucHanh.IsChecked = false;
                }
                else if (obj.HinhThucHoc == "Thực hành")
                {
                    dropDownBoPhan1.Selected_ID = obj.IdBoPhan == null ? 0 : obj.IdBoPhan;
                    dropDownChuyenKhoa1.Selected_ID = obj.IdChuyenNganhDangKi == null ? 0 : obj.IdChuyenNganhDangKi;
                    dropDownLopHocLienTucKhung.Selected_ID = obj.IdKhungLopHoc == null ? 0 : obj.IdKhungLopHoc;
                    radRadioButtonTheoLop.IsChecked = false;
                    radRadioButtonKemcap.IsChecked = false;
                    radThucHanh.IsChecked = true;
                }
                else
                {
                    
                    dropDownBoPhan1.Selected_ID = obj.IdBoPhan == null ? 0 : obj.IdBoPhan;
                    dropDownChuyenKhoa1.Selected_ID = obj.IdChuyenNganhDangKi == null ? 0 : obj.IdChuyenNganhDangKi;
                    dropDownLopHocLienTucKhung.Selected_ID = obj.IdKhungLopHoc == null ? 0 : obj.IdKhungLopHoc;
                    radRadioButtonTheoLop.IsChecked = true;
                    radRadioButtonKemcap.IsChecked = false;
                    radThucHanh.IsChecked = false;
                }               
                Business_HideControlByHinhThucHoc(obj.HinhThucHoc);

                // Không cho phép chuyển trạng thái sau khi đã save
                if (formMode.IsEdit)
                {
                    radRadioButtonKemcap.Enabled = false;
                    radRadioButtonTheoLop.Enabled = false;
                    radThucHanh.Enabled = false;
                    if (PTIdentity.FullName == "System manager")
                    {
                        radRadioButtonTheoLop.Enabled = true;
                        radRadioButtonKemcap.Enabled = true;
                        radThucHanh.Enabled = true;
                    }
                    netLink_DatePickerNgayDangKy.Enabled = false;
                    // Nếu đã xếp lớp thì không được phép chuyển học viên sang ngành khác
                    if (obj.HinhThucHoc == TextMessages.Itemvalue.HinhThucHoc_TheoLop && !string.IsNullOrEmpty(obj.MaLopHoc))
                    {
                        dropDownChuyenKhoa1.Enabled = false;
                        dropDownLopHocLienTucKhung.Enabled = false;
                        
                    }
                    lbNguoiQuanLy.Text = obj.TenNguoiQuanLy;
                    IDNguoiQuanLys = Convert.ToInt64(obj.IdNguoiQuanLy);
                    lbLastEdited.Text = GlobalCommon.GenLastEditString(obj.TenLastEdited_UserName, obj.LastEdited_Date.ToString());
                }
                txtSoTiet.Text = obj.SoTiet.ToString();
                urlPicture = obj.Anh;
                downloadPic = new Thread(new ThreadStart(Business_DownloadFile));
                downloadPic.Start();
                downloadPic.Join();
                radBrowseEditor1.Value = obj.FileDinhKem;
                if (!string.IsNullOrEmpty(obj.MaLopHoc))
                {
                    dropDownChuyenKhoa1.Enabled = false;
                    dropDownLopHocLienTucKhung.Enabled = false;
                }
            }
            else
            {
                if (dropDownTrinhDo.Selected_ID != null)
                    obj.IdTrinhDo = Convert.ToInt32(dropDownTrinhDo.Selected_ID);
                else
                    obj.IdTrinhDo = -1;
                if (dropDownChuyenNganh.Selected_ID != null)
                    obj.IdChuyenNganh = Convert.ToInt32(dropDownChuyenNganh.Selected_ID);
                else
                    obj.IdChuyenNganh = -1;
                if (dropDownBenhVien1.Selected_ID != null)
                    obj.IdBenhVienCongTac = Convert.ToInt64(dropDownBenhVien1.Selected_ID);
                else
                    obj.IdBenhVienCongTac = -1;
                if (dropDownTinhThanh.Selected_ID != null)
                    obj.IdTinhThanh = Convert.ToInt64(dropDownTinhThanh.Selected_ID);
                else
                    obj.IdTinhThanh = -1;
               
                if (dropDownBoPhan1.Selected_ID != null)
                    obj.IdBoPhan = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                else
                    obj.IdBoPhan = -1;
                if (dropDownChuyenKhoa1.Selected_ID != null)
                    obj.IdChuyenNganhDangKi = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                if (dropDownLopHocLienTucKhung.Selected_ID != null)
                    obj.IdKhungLopHoc = Convert.ToInt32(dropDownLopHocLienTucKhung.Selected_ID);
                if (string.IsNullOrEmpty(dropDownBenhVien1.Text))
                    obj.IdBenhVienCongTac = -1;
                if (string.IsNullOrEmpty(dropDownTinhThanh.Text))
                    obj.IdTinhThanh = -1;
                if (string.IsNullOrEmpty(dropDownTrinhDo.Text))
                    obj.IdTrinhDo = -1;
                if (string.IsNullOrEmpty(dropDownChuyenNganh.Text))
                    obj.IdChuyenNganh = -1;
                if (string.IsNullOrEmpty(dropDownBoPhan1.Text))
                    obj.IdBoPhan = -1;
               
                obj.HoTen = radTextBoxHoTen.Text;
                obj.GioiTinh = dropDownGioiTinh.Text;
                obj.SoCMT = radTextBoxCMT.Text;
                obj.NoiCapCMT = dropDownTinhThanh1.Text;
                obj.TruongTotNghiep = radDropTruongTotNghiep.Text;
                obj.SoBang = radtxtSoBang.Text;
                obj.DiaChiCoQuan = radTextBoxDiachiCoquan.Text;
                obj.DienThoaiCoQuan = radTextBoxDienThoaiCoquan.Text;
                obj.DiaChiNhaRieng = radTextBoxDiaChiNhaRieng.Text;
                obj.DienThoaiNhaRieng = radTextBoxDienThoaiNhaRieng.Text;
                obj.DiDong = radTextBoxDiDong.Text;
                obj.Email = radTextBoxEmail.Text;
                obj.FileDinhKem = fileUploaded;
                obj.TongHocPhi =Convert.ToString(radHocPhi.Value);
                int vt = dropDownLopHocLienTucKhung.Text.IndexOf("(");
                obj.NoiDungDaoTao = dropDownLopHocLienTucKhung.Text;
                //if (vt >0)
                //    obj.NoiDungDaoTao = dropDownLopHocLienTucKhung.Text.Substring(0,vt);
                obj.TrangThai = radDropDownListTrangThai.Text;
             //   obj.TongHocPhi = radSoTienDong.Text;
                if (!string.IsNullOrEmpty(radtxtNamTotNghiep.Text))
                    obj.NamTotNghiep = Convert.ToInt32(radtxtNamTotNghiep.Text);
                obj.NgaySinh = netLink_DatePickerNgaySinh.Value_String == "" ? netLink_DatePickerNgaySinh.Value_String : netLink_DatePickerNgaySinh.Value.ToShortDateString();
                obj.NgayCapCMT = netLink_DatePickerCapNgay.Value_String == "" ? netLink_DatePickerCapNgay.Value_String : netLink_DatePickerCapNgay.Value.ToShortDateString();
                obj.NgayDangKi = netLink_DatePickerNgayDangKy.Value_String == "" ? netLink_DatePickerNgayDangKy.Value_String : netLink_DatePickerNgayDangKy.Value.ToShortDateString();
                obj.NgayBatDau = netLink_DatePickerNgayBatDau.Value_String == "" ? netLink_DatePickerNgayBatDau.Value_String : netLink_DatePickerNgayBatDau.Value.ToShortDateString();
                obj.NgayKetThuc = netLink_DatePickerKetThuc.Value_String == "" ? netLink_DatePickerKetThuc.Value_String : netLink_DatePickerKetThuc.Value.ToShortDateString();
                obj.DangKiTuCTT = false;
                obj.MaSoThue = txtMaSoThue.Text;
                //obj.ThoiGianHoc = txtThoiGianHoc.Text;
                if (radRadioButtonKemcap.IsChecked)
                {
                    obj.HinhThucHoc = TextMessages.Itemvalue.HinhThucHoc_KemCap;
                    if (radDropDownListTrangThai.Text != DT_Common_value.TT_HocVien_ChuaHoc && string.IsNullOrEmpty(obj.MaHocVien))
                    {
                        if (HocVienCount == 0)
                            HocVienCount = DT_LienTuc_HocVien_Coll.DataPortal_FetchCountHocVienKemCap(Convert.ToDateTime(obj.NgayBatDau)) + 1;
                        obj.MaHocVien = Business_CreateMaHocVienKemCap(HocVienCount);
                        obj.STTHocVienKemCap = HocVienCount.ToString();
                    }
                    
                }
                else if(radRadioButtonTheoLop.IsChecked)
                {
                    
                    obj.HinhThucHoc = TextMessages.Itemvalue.HinhThucHoc_TheoLop;
                }
                else if(radThucHanh.IsChecked)
                {
                    obj.HinhThucHoc = TextMessages.Itemvalue.HinhThucHoc_ThucHanh;
                }
                if (!string.IsNullOrEmpty(urlPicture))
                    obj.Anh = urlPicture;
                //obj.Backup05 = HocVienCount;

                if (!string.IsNullOrEmpty(txtSoTiet.Text) && obj.HinhThucHoc == TextMessages.Itemvalue.HinhThucHoc_KemCap)
                {
                    obj.SoTiet = Convert.ToInt32(txtSoTiet.Text);
                }
                else
                {
                    obj.SoTiet = 0;
                }
                obj.LastEdited_Date = DateTime.Now;
                obj.LastEdited_User = PTIdentity.IDNguoiDung;
                
                if (formMode.IsInsert)
                {
                    obj.DaDongHocPhi = false;
                    obj.TongSoLanInBangTotNghiep = 0;
                    obj.TongSoLanInGiayChungNhan = 0;
                    obj.TongSoLanInHoaDon = 0;
                    obj.TongSoLanInThe = 0;
                    obj.IdNguoiQuanLy = PTIdentity.IDNguoiDung;
                }
                string[] HTSplit = obj.HoTen.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (HTSplit.Length > 0)
                {
                    obj.Backup03 = HTSplit[HTSplit.Length - 1];
                }
               
            }
        }

        /// <summary>
        /// Bind Data for control
        /// </summary>
        /// <param name="isLoad"></param>
        private void Business_BindData(bool isLoad)
        {
            Business_BindData(isLoad, objHocvien);
        }

        private void Business_HideControlByHinhThucHoc(string HThoc)
        {
            netLink_DatePickerNgayBatDau.Visible = false;
            netLink_DatePickerKetThuc.Visible = false;
            radTextBoxNoiDungDT.Visible = false;
            radHocPhi.Visible = false;
            txtHPDaDong.Visible = false;
            lblHPDaDong.Visible = false;
            radLabelHocphi.Visible = false;
            radLabelChonLop.Visible = false;
            radLabelKethuc.Visible = false;
            radLabelNgaybatdau.Visible = false;
            radLabelNoidungDT.Visible = false;
            dropDownLopHocLienTucKhung.Visible = false;
            lbSoTiet.Visible = false;
            txtSoTiet.Visible = false;
            lblSTienDong.Visible = false;
            radSoTienDong.Visible = false;
            radSoTienDong1.Visible = false;
            btnChupAnh.Enabled = false;
            //if (GlobalCommon.GetTenDangNhap(PTIdentity.IDNguoiDung) == "sysman")
            //{
            //    txtThoiGianHoc.Visible = true;
            //    radLabel25.Visible = true;
            //}
        //    radSoTienDong.Visible = false;
            if (HThoc == TextMessages.Itemvalue.HinhThucHoc_KemCap || HThoc ==TextMessages.Itemvalue.HinhThucHoc_ThucHanh )
            {
                netLink_DatePickerNgayBatDau.Visible = true;
                netLink_DatePickerKetThuc.Visible = true;
                //radTextBoxNoiDungDT.Visible = true;
                radHocPhi.Visible = true;
                txtHPDaDong.Visible = true;
                lblHPDaDong.Visible = true;
                radLabelHocphi.Visible = true;
                radLabelKethuc.Visible = true;
                radLabelNgaybatdau.Visible = true;
                //radLabelNoidungDT.Visible = true;
                radLabelChonLop.Text = "Nội dung học :";
                dropDownLopHocLienTucKhung.NullText = "Chọn nội dung học";
                dropDownLopHocLienTucKhung.Visible = true;
                dropDownChuyenKhoa1.Selected_TextValue = "Chọn chuyên khoa học";
                radLabelChonLop.Visible = true;
                lbSoTiet.Visible = true;
                txtSoTiet.Visible = true;
                radHocPhi.Enabled = true;
                radSoTienDong.Enabled = false;
                radSoTienDong.Visible = true;
                netLink_DatePickerNgayBatDau.Enabled = true;
                netLink_DatePickerKetThuc.Enabled = true;
                lblSTienDong.Visible = true;
                txtSoTiet.Enabled = true;
            }
            else 
            {                
                netLink_DatePickerNgayBatDau.Visible = true;
                netLink_DatePickerKetThuc.Visible = true;
                txtHPDaDong.Visible = true;
                lblHPDaDong.Visible = true;
                radHocPhi.Visible = true;
                txtHPDaDong.Enabled = false;
                radSoTienDong.Enabled = false;
                radLabelHocphi.Visible = true;
                radLabelKethuc.Visible = true;
                radLabelNgaybatdau.Visible = true;
                radHocPhi.Enabled = false;
                netLink_DatePickerNgayBatDau.Enabled = false;
                netLink_DatePickerKetThuc.Enabled = false;
                ////////////////////

                dropDownLopHocLienTucKhung.Visible = true;
                radLabelChonLop.Visible = true;
                //radLabelChonLop.Text = "Chọn Lớp :";
                //dropDownLopHocLienTucKhung.NullText = "Chọn lớp học";
                radLabelChonLop.Visible = true;
                dropDownLopHocLienTucKhung.Visible = true;
                radSoTienDong.Visible = false;
                radSoTienDong.Visible = false;
                lblSTienDong.Visible = false;
                radSoTienDong1.Visible = false;
                lbSoTiet.Visible = true;
                txtSoTiet.Visible = true;
                txtSoTiet.Enabled = false;
                radSoTienDong.Enabled = false;
                radSoTienDong.Visible = true;
                lblSTienDong.Visible = true;
                txtMaSoThue.Visible = true;
                radLabel24.Visible = true;
            }
        }

        private void Business_HideControlByFormStatus(bool isInsert)
        {
            if (isInsert)
            {
              //  radButtonGiayhen.Visible = false;
                radButtonGiaythuhocphi.Visible = false;
                radButtonInTheHocVien.Visible = false;
                radButtonSaoluu.Visible = false;
                radButtonTiepnhanHocvien.Visible = false;
                btnInHoaDon.Visible = true;
          
            
               
            }
        }

        private void Business_HideControlByPermission(bool isHide)
        {
            btnSave.Enabled = !isHide;
         
        }

        private void Business_HideControlByStudentStatus(bool isInsert)
        {
            /*
             * 
             */
            if (GlobalCommon.IsHavePermission(string.Empty))
            {
                radButtonTiepnhanHocvien.Enabled = true;
                radButtonInTheHocVien.Enabled = true;
          
                radButtonGiaythuhocphi.Enabled = true;
         //       radButtonGiayhen.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            else
            {
                radButtonTiepnhanHocvien.Enabled = true;
                radButtonInTheHocVien.Enabled = true;
     
                radButtonGiaythuhocphi.Enabled = true;
                btnInHoaDon.Enabled = true;                           
                if (!isInsert && objHocvien != null)
                {
                    radButtonTiepnhanHocvien.Enabled = true;
       //             radButtonInHenChungchi.Enabled = true;
                    radButtonGiaythuhocphi.Enabled = true;
               
                    if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InThe_View))
                    {
                        radButtonInTheHocVien.Enabled = true;
                      //  btnInHoaDon.Enabled = true;
                    }
                    if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_View))
                    {
        
                        btnInHoaDon.Enabled = true;
                    }
                 

                }
                else
                {
                    if (objHocvien != null)
                    {
                        radButtonTiepnhanHocvien.Enabled = true;
                        
                        
                    }
                }
            }
        }

        private bool Business_ValidateDataBeforeSave()
        {
            string type = string.Empty;
            if (radRadioButtonKemcap.IsChecked)
                type = TextMessages.Itemvalue.HinhThucHoc_KemCap;
            else if (radRadioButtonTheoLop.IsChecked)
                type = TextMessages.Itemvalue.HinhThucHoc_TheoLop;
            else if (radThucHanh.IsChecked)
                type = TextMessages.Itemvalue.HinhThucHoc_ThucHanh;
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
            if (!netLink_DatePickerCapNgay.isDateTime && !netLink_DatePickerCapNgay.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerCapNgay.Value_Error);
                return false;
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

            if (GlobalCommon.CheckArrayTextIsNull(new object[] { radTextBoxHoTen.Text, netLink_DatePickerNgaySinh.Value_String, dropDownBoPhan1.Selected_TextValue, netLink_DatePickerNgayDangKy.Value_String, dropDownChuyenKhoa1.Selected_TextValue, dropDownLopHocLienTucKhung.Selected_TextValue, radDropDownListTrangThai.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (type == TextMessages.Itemvalue.HinhThucHoc_KemCap && GlobalCommon.CheckArrayTextIsNull(new object[] { netLink_DatePickerNgayBatDau.Value_String, netLink_DatePickerKetThuc.Value_String, radHocPhi.Value }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckIsAYear(radtxtNamTotNghiep.Text))
            {
                GlobalCommon.ShowErrorMessager("Định dạng năm tốt nghiệp không đúng");
                return false;
            }
            if (!string.IsNullOrEmpty(radTextBoxDienThoaiCoquan.Text) && !GlobalCommon.Check_MustHasANumber(radTextBoxDienThoaiCoquan.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangDienThoaiSai);
                return false;
            }
            if (!string.IsNullOrEmpty(radTextBoxDienThoaiNhaRieng.Text) && !GlobalCommon.Check_MustHasANumber(radTextBoxDienThoaiNhaRieng.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangDienThoaiSai);
                return false;
            }
            if (!string.IsNullOrEmpty(radTextBoxDiDong.Text) && !GlobalCommon.Check_MustHasANumber(radTextBoxDiDong.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangDienThoaiSai);
                return false;
            }
            if (!string.IsNullOrEmpty(radTextBoxEmail.Text) && !GlobalCommon.CheckEmail(radTextBoxEmail.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangEmailSai);
                return false;
            }
            if (!string.IsNullOrEmpty(radHocPhi.Text) && !GlobalCommon.CheckIsNumberLong(radHocPhi.Text))
            {
           //     GlobalCommon.ShowErrorMessager("Học phí phải là một số");
                return true;
            }
            if (type == TextMessages.Itemvalue.HinhThucHoc_KemCap && !GlobalCommon.CheckDateMustBeEarilierThanOther(netLink_DatePickerKetThuc.Value_String,netLink_DatePickerNgayBatDau.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, netLink_DatePickerKetThuc.MyName, netLink_DatePickerNgayBatDau.MyName));
                return false;
            }
            if (!string.IsNullOrEmpty(txtSoTiet.Text) && !GlobalCommon.CheckIsNumber(txtSoTiet.Text))
            {
                GlobalCommon.ShowErrorMessager("Số tiết học phải là một số");
                return false;
            }

            return true;
        }

        private bool Business_UploadFile()
        {
            if (!string.IsNullOrEmpty(urlPicture) && urlPicture!= objHocvien.Anh)
            {
                FtpUltilies ftp = new FtpUltilies();
                return ftp.UploadLargeFile(urlPicture, true, out urlPicture);                
            }
            return true;
        }

        private bool UploadFile()
        {
            if (radBrowseEditor1.Value != null && !string.IsNullOrEmpty(radBrowseEditor1.Value.ToString()) && radBrowseEditor1.Value != objHocvien.FileDinhKem)
            {
                FtpUltilies ftp = new FtpUltilies();
                if (!ftp.UploadLargeFile(radBrowseEditor1.Value, true, out fileUploaded))
                {
                    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.FileUploadLoi);
                    return false;
                }
            }
            return true;
        }
        

        private void Business_DownloadFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(urlPicture))
                {
                    FtpUltilies ftp = new FtpUltilies();
                    ftp.DownloadFile(urlPicture, Path.Combine(Environment.CurrentDirectory, "anhHV.jpg"));
                    pictureBoxAnh.ImageLocation = Path.Combine(Environment.CurrentDirectory, "anhHV.jpg");
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private string Business_CreateMaHocVienKemCap(int count)
        {
          
            string strCount = count.ToString();
            if (count < 10)
                strCount = string.Format("000{0}", count);
         
            else if (count < 100)
                strCount = string.Format("00{0}", count);
              
            else if (count < 1000)
                strCount = string.Format("0{0}", count);
            string  result = string.Format("{0}-KC-BM-{1}-B24", strCount,GlobalCommon.CutYear(Convert.ToDateTime(objHocvien.NgayBatDau).Year));
            return result;
        }

        private bool Business_IsContinueSaveWithAnDuplicateItem()
        {
            
            if (listHocVien != null)
            {
                DT_LienTuc_HocVien_Info itemHVInfo = null;
                foreach (DT_LienTuc_HocVien_Info itemInfo in listHocVien)
                {

                    if (itemInfo.HinhThucHoc == TextMessages.Itemvalue.HinhThucHoc_TheoLop)
                    {
                        // Nếu người dùng chọn theo lớp và đã tồn tại 1 bản ghi chưa được xếp lớp thì không cho phép nhập nữa
                        if (string.IsNullOrEmpty(itemInfo.MaLopHoc) && objHocvien.HinhThucHoc == TextMessages.Itemvalue.HinhThucHoc_TheoLop)
                        {
                            GlobalCommon.ShowErrorMessager("Hiện học viên này đã đăng kí học theo lớp nhưng chưa được xếp lớp \n Bạn không thể tạo mới bản ghi này cho đến khi học viên được xếp lớp");
                            return false;
                        }
                        else if (DateTime.Compare(itemInfo.DateNgayKetThuc, DateTime.Now) >= 0)
                        {
                            if (GlobalCommon.ShowInformation_YesNo(string.Format("Hiện học viên này đang học '{0}' \nTrong lớp '{1}' - Mã '{3}' \nNgày '{2}' mới kết thúc \nBạn có muốn lưu trùng không?", itemInfo.HinhThucHoc, itemInfo.NoiDungDaoTao, itemInfo.NgayKetThuc, itemInfo.MaLopHoc)))
                                return true;
                            else
                                return false;
                        }
                    }
                    if (itemInfo.HinhThucHoc == TextMessages.Itemvalue.HinhThucHoc_KemCap)
                    {
                        if (DateTime.Compare(itemInfo.DateNgayKetThuc, DateTime.Now) >= 0)
                        {
                            if (objHocvien.HinhThucHoc == TextMessages.Itemvalue.HinhThucHoc_KemCap)
                            {
                                if (GlobalCommon.ShowInformation_YesNo(string.Format("Hiện học viên này đang học '{0}' \nVới nội dung '{1}' \nNgày '{2}' mới kết thúc \nBạn có muốn lưu trùng không?", itemInfo.HinhThucHoc, itemInfo.NoiDungDaoTao, itemInfo.NgayKetThuc)))
                                    return true;
                                else
                                    return false;
                            }
                            else
                            {
                                itemHVInfo = itemInfo;
                            }
                        }
                    }

                }
                if (itemHVInfo != null)
                {
                    if (GlobalCommon.ShowInformation_YesNo(string.Format("Hiện học viên này đang học '{0}' \nVới nội dung '{1}' \nNgày '{2}' mới kết thúc \nBạn có muốn lưu trùng không?", itemHVInfo.HinhThucHoc, itemHVInfo.NoiDungDaoTao, itemHVInfo.NgayKetThuc)))
                        return true;
                    else
                        return false;
                }
            }
            return true;
        }

        private void dropDownChuyenKhoa1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dropDownChuyenKhoa1.Selected_ID != null)
                    dropDownLopHocLienTucKhung.FilterData(FilterColumn.IDKhoaNgoai64, dropDownChuyenKhoa1.Selected_ID);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radHocPhi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTienHoc.Text = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(Convert.ToDecimal(radHocPhi.Value));
              //  lbTienHoc.Text = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(Convert.ToString(radSoTienDong.Text));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radTextBoxCMT_Enter(object sender, EventArgs e)
        {
            try
            {
                CacheSoCMT = radTextBoxCMT.Text;
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radTextBoxCMT_Leave(object sender, EventArgs e)
        {

            try
            {
                if (radTextBoxCMT.Text != CacheSoCMT)
                {
                    BusinessFunction functionNew = new BusinessFunction(BusinessFunctionMode.GetDataBySoCMT);
                    functionNew.Item = radTextBoxCMT.Text;
                    listHocVien = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(functionNew);
                    if (listHocVien != null && listHocVien.Count > 0)
                    {
                        if (GlobalCommon.ShowInformation_YesNo("Học viên này hiện đã tồn tại. \nBạn có muốn sử dụng thông tin cũ để không phải nhập lại không?"))
                        {
                            DT_LienTuc_HocVien_Info obj = listHocVien[0];
                            radTextBoxHoTen.Text = obj.HoTen;
                            dropDownGioiTinh.Text = obj.GioiTinh;
                        //    radTextBoxNoiCapCMT.Text = obj.NoiCapCMT;
                            dropDownTinhThanh1.Text = obj.NoiCapCMT;
                            radDropTruongTotNghiep.Text = obj.TruongTotNghiep;
                            radtxtSoBang.Text = obj.SoBang;
                            radTextBoxDiachiCoquan.Text = obj.DiaChiCoQuan;
                            radTextBoxDienThoaiCoquan.Text = obj.DienThoaiCoQuan;
                            radTextBoxDiaChiNhaRieng.Text = obj.DiaChiNhaRieng;
                            radTextBoxDienThoaiNhaRieng.Text = obj.DienThoaiNhaRieng;
                            radTextBoxDiDong.Text = obj.DiDong;
                            radTextBoxEmail.Text = obj.Email;
                            radtxtNamTotNghiep.Text = obj.NamTotNghiep.ToString() == "0" ? "" : obj.NamTotNghiep.ToString() ;
                            netLink_DatePickerNgaySinh.Value_String = obj.NgaySinh;
                            netLink_DatePickerCapNgay.Value_String = obj.NgayCapCMT;
                            netLink_DatePickerNgayDangKy.Value = DateTime.Now;
                            dropDownTrinhDo.Selected_ID = obj.IdTrinhDo;
                            dropDownChuyenNganh.Selected_ID = obj.IdChuyenNganh;
                            dropDownBenhVien1.Selected_ID = obj.IdBenhVienCongTac;
                            dropDownTinhThanh.Selected_ID = obj.IdTinhThanh;
                            dropDownBoPhan1.Selected_ID = obj.IdBoPhan;
                            txtMaSoThue.Text = obj.MaSoThue;
                            dropDownTinhThanh1.Text = obj.NoiCapCMT;
                            pictureBoxAnh.Image = ModuleDaoTao.Properties.Resources.face;
                            urlPicture = obj.Anh;
                            objHocvien.Anh = urlPicture;
                            downloadPic = new Thread(new ThreadStart(Business_DownloadFile));
                            downloadPic.Start();
                            downloadPic.Join();
                        }
                    }
                    else
                    {
                        listHocVien = null;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
           
        }

        private void netLink_DatePickerKetThuc_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!netLink_DatePickerKetThuc.isDateTime && !netLink_DatePickerKetThuc.isNull)
                {
                    return;
                }
                if (!netLink_DatePickerNgayBatDau.isDateTime && !netLink_DatePickerNgayBatDau.isNull)
                {
                    return;
                }

                if (radDropDownListTrangThai.Text == TextMessages.Itemvalue.TrangThaiHoc_DangHoc || radDropDownListTrangThai.Text == TextMessages.Itemvalue.TrangThaiHoc_ChuaHoc || radDropDownListTrangThai.Text == TextMessages.Itemvalue.TrangThaiHoc_KT_ChuaCC)
                {
                    if (DateTime.Compare(netLink_DatePickerNgayBatDau.Value, DateTime.Now) <= 0 && DateTime.Compare(netLink_DatePickerKetThuc.Value, DateTime.Now) >= 0)
                    {
                        radDropDownListTrangThai.Text = TextMessages.Itemvalue.TrangThaiHoc_DangHoc;
                    }
                    else if (DateTime.Compare(netLink_DatePickerKetThuc.Value, DateTime.Now) < 0)
                    {
                        radDropDownListTrangThai.Text = TextMessages.Itemvalue.TrangThaiHoc_KT_ChuaCC;
                    }
                    else
                    {
                        radDropDownListTrangThai.Text = TextMessages.Itemvalue.TrangThaiHoc_ChuaHoc;
                    }

                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radTextBoxHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBoxHoTen_Leave(object sender, EventArgs e)
        {
            try
            {
                radTextBoxHoTen.Text = GlobalCommon.StringProcess.UpperFirstChar(radTextBoxHoTen.Text);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

       
        private void netLink_DatePickerNgayBatDau_Leave(object sender, EventArgs e)
        {
            if (netLink_DatePickerNgayBatDau.Text.Length == 10)
            {
                HocVienCount = DT_LienTuc_HocVien_Coll.DataPortal_FetchCountHocVienKemCap(netLink_DatePickerNgayBatDau.Value) + 1;
            }
        }

        private void netLink_DatePickerNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            if (netLink_DatePickerNgayBatDau.Text.Length == 10)
            {
                HocVienCount = DT_LienTuc_HocVien_Coll.DataPortal_FetchCountHocVienKemCap(netLink_DatePickerNgayBatDau.Value) + 1;
            }
        }

        

        private void btnInHoaDon_Click_1(object sender, EventArgs e)
        {                      
            ModuleDaoTao.UI.FormBienLai fm = new FormBienLai(objHocvien.Id);
            fm.ShowDialog();         
        }

        private void radHoc_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            DieuKien = radHoc.SelectedIndex;                     
        }

        private void radMau_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            DK = radMau.SelectedIndex;
        }

        private void radHP_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if(radHP.IsChecked==true)
            {
                radHoc.Items[0].Selected = true;
                radHoc.Enabled = true;
                radMau.Enabled = false;
                radMau.Text=string.Empty;
            }
            else
            {
                //radMau.Items[0].Selected = true;
                //radMau.Enabled = true;
                radHoc.Enabled = false;
                radHoc.Text = string.Empty;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnChup_Click(object sender, EventArgs e)
        {
            
        }

        private void radThucHanh_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                if (radThucHanh.IsChecked)
                {
                    Business_HideControlByHinhThucHoc(TextMessages.Itemvalue.HinhThucHoc_ThucHanh);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnChupAnh.Enabled = true;
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = new VideoCaptureDevice(cameras[0].MonikerString);
            cam.NewFrame += Cam_NeuwFrame;
            cam.Start();
        }

        private void btnChupAnh_Click(object sender, EventArgs e)
        {            
            pictureBoxAnh.Image = pictureVideo.Image;
            cam.Stop();
            SaveImageCapture(pictureBoxAnh.Image);
            btnChupAnh.Enabled = false;
        }

        public void SaveImageCapture(System.Drawing.Image image)
        {
            string FilePath = @"C:\Data";
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }
            string FileName = FilePath + @"\" + DateTime.Now.ToString("dd-MM-yyyy-HHmmss-");
            filename = FileName + ".Jpg";
            FileStream fstream = new FileStream(filename, FileMode.Create);
            image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
            urlPicture = filename;
            pictureBoxAnh.ImageLocation = filename;
            pictureBoxAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            hasModifyImage = true;
            pictureBoxAnh.Visible = true;
        }

        public void DeleteFile()
        {
            if (filename != null)
            {
                File.Delete(filename);
            }

        }

        private void radRadioInThe_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radRadioInThe.IsChecked == true)
            {
                radDropDoiTuongIn.Enabled = true;
                radHoc.Enabled = false;
                radMau.Enabled = false;
                radMau.Text = string.Empty;
                radHoc.Text = string.Empty;
                radDropDoiTuongIn.Items[0].Selected = true;
            }
            else
            {
                //radMau.Items[0].Selected = true;
                //radMau.Items[0].Selected = true;
                //radMau.Enabled = true;
                radDropDoiTuongIn.Enabled = false;
                radDropDoiTuongIn.Text = string.Empty;
            }
        }

        private void radIn_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radIn.IsChecked == true)
            {
                radMau.Enabled = true;
                radHoc.Enabled = false;
                radDropDoiTuongIn.Enabled = false;
                radDropDoiTuongIn.Text = string.Empty;
                radHoc.Text = string.Empty;
                radMau.Items[0].Selected = true;
            }
            else
            {
                //radMau.Items[0].Selected = true;
                //radMau.Items[0].Selected = true;
                //radMau.Enabled = true;
                radMau.Enabled = false;
                radMau.Text = string.Empty;
            }
        }

        private void dropDownLopHocLienTucKhung_Leave(object sender, EventArgs e)
        {
           // txtThoiGianHoc.Text = GlobalCommon.StringProcess.ForReport.GetSoThangHoc(Convert.ToInt64(objHocvien.IdKhungLopHoc));
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (formMode.IsEdit && !string.IsNullOrEmpty(objHocvien.FileDinhKem))
                {
                    FtpUltilies ftp = new FtpUltilies();
                    ftp.SaveDownloadedFile(objHocvien.FileDinhKem);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        ///// End Quang BH

    }
}
