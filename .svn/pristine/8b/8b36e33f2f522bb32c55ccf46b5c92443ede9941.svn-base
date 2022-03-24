using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI;
using ModuleDaoTao.LIB;
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using Telerik.WinControls.Data;
using NETLINK.LIB;
using Authoration.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_LT_NhapHocPhi : Dictionary
    {

        private DT_LienTuc_HocVien item;
        private string fileUploaded;
        private int Mode;
        public Form_LT_NhapHocPhi(FormMode _formMode)
        {
            InitializeComponent();

            this.formMode = _formMode;
            if (formMode.Item != null)
                Mode = Convert.ToInt32(formMode.Item); 
             ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Edit });
        }
        protected override void Save()
        {
            try
            {
                BindData(false);
                if (ValidateDataBeforeSave())
                {
                    UploadFile();
                   
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form học phí | Học Viên số CMT:" + item.SoCMT);
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
                
                if (formMode.Id > 0)
                {
                    item = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(formMode.Id);
                }
                else
                {
                    GlobalCommon.ShowErrorMessager("Có lỗi xảy ra");
                    this.Close();
                }
                BindData(true);
                if (!string.IsNullOrEmpty(item.HoaDonHocPhi))
                {
                    gridViewHoaDon1.Enabled = true;
                    lydoHoanTien.Enable = true;
                    netLink_DatePicker1.Enabled = true;
                    groupBox1.Enabled = true;
                    txtSoTienHoan.Enabled = true;
                    grouphoantien.Enabled = true;
                }
                else
                {
                    long sotienhoan;
                    if (Int64.TryParse(item.SoTienHoan, out sotienhoan))
                    {
                        if (sotienhoan > 0)
                        {
                            btnSave.Enabled = false;
                            gridViewHoaDon1.Enabled = false;
                        }
                    }

                }
                if (GlobalCommon.IsHavePermission(string.Empty))
                {
                    btnSave.Enabled = true;
                }
                     
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
                    txtLoaiHinh.Text = item.HinhThucHoc;
                    txtMaHV.Text = item.MaHocVien;
                    txtHoTen.Text = item.HoTen;
                    txtNgaySinh.Text = item.NgaySinh;
                    txtSoCMT.Text = item.SoCMT;
                    txtTrangThai.Text = item.TrangThai;
                    txtMaLop.Text = item.MaLopHoc;
                    txtTenLop.Text = item.TenLopHoc;
                    txtChuyenKhoa.Text = item.TenChuyenKhoaLopHoc;
                    txtKhoa.Text = item.TenKhoaHoc;
                    txtThoiGianHoc.Text = string.Format("{0} - {1}", item.NgayBatDau, item.NgayKetThuc);
                    if (!string.IsNullOrEmpty(item.TongHocPhi))
                    {
                        lbTongTienPhaiNop.Text = GlobalCommon.ConvertMoney(Convert.ToInt64(item.TongHocPhi));
                        lbTongTienPhaiNopText.Text = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(item.TongHocPhi);
                    }
                    gridViewHoaDon1.Value_AllInOne = item.Backup01;
                    txtSoTienHoan.Text = item.SoTienHoan;
                    netLink_DatePicker1.Value_String = item.NgayDong;
                    lydoHoanTien.Text = item.LyDoHoanTien;
                }
                else
                {

                    if (gridViewHoaDon1.Value_AllInOne != null)
                    {
                        item.HoaDonHocPhi = gridViewHoaDon1.Value_MaHoaDon;
                        item.SoTienDongDetail = gridViewHoaDon1.Value_TienTrenHoaDon;
                        item.NgayDongDetail = gridViewHoaDon1.Value_NgayHoaDon;
                        item.TongTienHoc = gridViewHoaDon1.Value_GetTongTien.ToString();
                        item.Backup01 = gridViewHoaDon1.Value_AllInOne;
                    }
                    item.LastEdited_User = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                    if (string.IsNullOrEmpty(item.TongHocPhi))
                        item.TongHocPhi = "0";
                    if (string.IsNullOrEmpty(item.TongTienHoc))
                        item.TongTienHoc = "0";
                    item.LyDoHoanTien = lydoHoanTien.Text;
                    item.SoTienHoan = txtSoTienHoan.Text;
                    item.NgayDong = netLink_DatePicker1.Value_String;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            long hp = 0;
            long tongtien = 0;
            
            if (long.TryParse(item.TongHocPhi, out hp) && long.TryParse(item.TongTienHoc, out tongtien))
            {
                if (hp < tongtien)
                {
                    GlobalCommon.ShowErrorMessager("Tổng số tiền trên hóa đơn không thể vượt quá số tiền phải nộp");
                    return false;
                }
            }
            else
            {
                return false;
            }
               
            return true;
        }

        private void UploadFile()
        {
            
        }

       
    }
}
