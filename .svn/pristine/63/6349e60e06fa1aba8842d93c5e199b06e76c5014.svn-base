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
using DanhMuc.LIB;
using System.Data.SqlClient;
namespace DanhMuc.UI
{
    public partial class Form_CanBoCDT : NETLINK.UI.Dictionary
    {
        
        private DIC_CanBo item;
        public Form_CanBoCDT(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            radNgaySinh.MyName = "Ngày sinh";
            radNgayCap.MyName = "Ngày cấp CMT";
            radngayVaoDang.MyName = "Ngày vào đảng";
            //radMaNV.Enabled = false;
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DM_CanBoCDT_Edit, TextMessages.RolePermission.DM_CanBoCDT_Insert });
        }
        protected override void Save()
        {
            try
            {
                //if (kiemtratontai() )
                //{
                //    GlobalCommon.ShowError("Tên cán bộ đã tồn tại", "Thông báo");
                //}
                //else
                //{
                    if (ValidateDataBeforeSave())
                    {
                        BindData(false);
                        item.ApplyEdit();
                        item.Save();
                        GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                        this.Close();
                    }
                //}
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
                LoadDataForDropDownList();
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = DIC_CanBo.GetDIC_CanBo(formMode.Id);
                }
                else
                {
                    item = DIC_CanBo.NewDIC_CanBo();
                }
                radBindingSource.DataSource = item;
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
                    if (formMode.IsEdit)
                    {
                        radQuaTrinhCongTac.Text = item.QTCongTac;
                        radQuaTrinhDaoTao.Text = item.QTDaoTao;
                        radNghienCuuKhoaHoc.Text = item.NghienCuuTGia;
                        radTrinhDoNgoaiNgu.Text = item.NgoaiNguTinHoc;
                        radKhenThuongKiLuat.Text = item.KhenThuongKyLuat;
                        radKinhNghiem.Text = item.KinhNghiemNN;
                        dropDownBoPhan1.Selected_ID = item.IDBoPhan;
                        dropDownChucVu1.Selected_ID = item.IDChucVu;
                        dropDownTinhThanh1.Selected_ID = item.IDTinh;
                        dropDownTrinhDo1.Selected_ID = item.IDTrinhDo;
                        richTextBoxWithBigEditor1.Text = item.GhiChu;
                        if (GlobalCommon.CheckDate(item.NgayCap))
                            radNgayCap.Value_String = item.NgayCap;
                        if (GlobalCommon.CheckDate(item.NgaySinh))
                            radNgaySinh.Value_String = item.NgaySinh;
                        if (GlobalCommon.CheckDate(item.NgayVaoDang))
                            radngayVaoDang.Value_String = item.NgayVaoDang;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(formMode.StringId))
                        {
                            radMaNV.Text = "TDC001";
                        }
                        else
                        {
                            radMaNV.Text = string.Format("TDC{0}", formMode.StringId);
                        }
                    }
                }
                else
                {
                    item.KinhNghiemNN = radKinhNghiem.Text;
                    item.LoaiCanBo = Convert.ToInt32(LoaiCanBo.CanBoThuocTrungTamCDT);
                    item.QTCongTac = radQuaTrinhCongTac.Text;
                    item.QTDaoTao = radQuaTrinhDaoTao.Text;
                    item.NghienCuuTGia = radNghienCuuKhoaHoc.Text;
                    item.NgoaiNguTinHoc = radTrinhDoNgoaiNgu.Text;
                    item.KhenThuongKyLuat = radKhenThuongKiLuat.Text;
                    item.NgaySinh = radNgaySinh.Value_String;
                    item.NgayVaoDang = radngayVaoDang.Value_String;
                    item.NgayCap = radNgayCap.Value_String;
                    item.IDBoPhan = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                    item.IDChucVu = Convert.ToInt32(dropDownChucVu1.Selected_ID);
                    item.IDTinh = Convert.ToInt32(dropDownTinhThanh1.Selected_ID);
                    item.IDTrinhDo = Convert.ToInt32(dropDownTrinhDo1.Selected_ID);
                    item.GhiChu = richTextBoxWithBigEditor1.Text;
                }
            }
        }
        private void LoadDataForDropDownList()
        {
            dropDownBoPhan1.FillData(1);
            dropDownChucVu1.FillData(1);
            dropDownDanToc1.FillData();
            dropDownGioiTinh1.FillData();
            dropDownQuocGia1.FillData();
            dropDownTinhThanh1.FillData(1);
            dropDownTrinhDo1.FillData(1);
        }
        private bool ValidateDataBeforeSave()
        {
            if (!GlobalCommon.CheckFullName(radHoTen.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangHoTenSai);
                return false;
            }
            if (string.IsNullOrEmpty(radCMT.Text) || !GlobalCommon.Check_MustHasANumber(radCMT.Text))
            {
                GlobalCommon.ShowErrorMessager("Định dạng Chứng minh thư sai");
                return false;
            }
            if (string.IsNullOrEmpty(radDienThoai.Text) || !GlobalCommon.Check_MustHasANumber(radDienThoai.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangDienThoaiSai);
                return false;
            }
            if (!string.IsNullOrEmpty(radEmail.Text) && !GlobalCommon.CheckEmail(radEmail.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DinhDangEmailSai);
                return false; 
            }
            if (!radNgaySinh.isDateTime && !radNgaySinh.isNull)
            {
                GlobalCommon.ShowErrorMessager(radNgaySinh.Value_Error);
                return false;
            }
            if (!radNgayCap.isDateTime && !radNgayCap.isNull)
            {
                GlobalCommon.ShowErrorMessager(radNgayCap.Value_Error);
                return false;
            }
            if (!radngayVaoDang.isDateTime && !radngayVaoDang.isNull)
            {
                GlobalCommon.ShowErrorMessager(radngayVaoDang.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { dropDownGioiTinh1.Text, radMaNV.Text, dropDownChucVu1.Selected_TextValue.ToString(), dropDownTrinhDo1.Selected_TextValue.ToString(),radNgaySinh.Value_String }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if(!GlobalCommon.CheckDateMustBeEarilierThanOther(DateTime.Now,radNgaySinh.Value))
            {
                GlobalCommon.ShowErrorMessager(string.Format("'{0}' phải là một ngày trong quá khứ", radNgaySinh.MyName));
                return false;
            }
            

            return true;
        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maso = radHoTen.Text;
            SqlConnection con = new SqlConnection(DBConnection.Connection);
            SqlCommand cmd = new SqlCommand("Select  HoTen from DIC_CanBo", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (maso == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }  
    }
}
