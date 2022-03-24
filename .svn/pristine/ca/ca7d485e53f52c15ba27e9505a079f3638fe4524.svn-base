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
    public partial class Form_CanBo_NgoaiCDT : NETLINK.UI.Dictionary
    {
        
        private DIC_GiangVien item;
        public static string ChuyenKhoa = string.Empty;
        public Form_CanBo_NgoaiCDT(FormMode _formMode)
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
            //    if (kiemtratontai())
            //    {
            //        GlobalCommon.ShowError("Tên giảng viên đã tồn tại", "Thông báo");
            //    }
            //    else
            //    {

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
                 //   item = DIC_CanBo.GetDIC_CanBo(formMode.Id);
                    item = DIC_GiangVien.GetDIC_GiangVien(formMode.Id);
                }
                else
                {
                 //   item = DIC_CanBo.NewDIC_CanBo();
                    item = DIC_GiangVien.NewDIC_GiangVien();
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
                        dropDownChucVu1.Selected_ID = item.IDChucVu;
                        dropDownTinhThanh1.Selected_ID = item.IDTinh;
                        dropDownTinhThanh2.Selected_TextValue = item.NoiCap;
                        dropDownTrinhDo1.Selected_ID = item.IDTrinhDo;
                        richTextBoxWithBigEditor1.Text = item.GhiChu;
                        dropHocHam1.Selected_ID = item.IdHocHam;
                        dropDownChuyenNganh1.Selected_ID = item.IdChuyenNganh;
                        if (GlobalCommon.CheckDate(item.NgayCap))
                            radNgayCap.Value_String = item.NgayCap;
                        if (GlobalCommon.CheckDate(item.NgaySinh))
                            radNgaySinh.Value_String = item.NgaySinh;
                        if (GlobalCommon.CheckDate(item.NgayVaoDang))
                            radngayVaoDang.Value_String = item.NgayVaoDang;
                        dropDownChuyenKhoa1.Selected_ID = item.IdChuyenKhoa;
                        txtChungChi.Text = item.ChungChi;
                        radNam.Text =Convert.ToString(item.NamBatDau);

                    }
                  
                }
                else
                {
                    item.KinhNghiemNN = radKinhNghiem.Text;
                    item.LoaiCanBo = Convert.ToInt32(LoaiCanBo.GiaoVien);
                    item.QTCongTac = radQuaTrinhCongTac.Text;
                    item.QTDaoTao = radQuaTrinhDaoTao.Text;
                    item.NghienCuuTGia = radNghienCuuKhoaHoc.Text;
                    item.NgoaiNguTinHoc = radTrinhDoNgoaiNgu.Text;
                    item.KhenThuongKyLuat = radKhenThuongKiLuat.Text;
             
                    item.NgaySinh = radNgaySinh.Value_String;
                    item.NgayVaoDang = radngayVaoDang.Value_String;
                    item.NgayCap = radNgayCap.Value_String;
                   // item.NoiCap = dropDownTinhThanh2.Selected_TextValue.ToString();
                    item.IDChucVu = Convert.ToInt32(dropDownChucVu1.Selected_ID);
                    item.IDTinh = Convert.ToInt32(dropDownTinhThanh1.Selected_ID);
                    item.IDTrinhDo = Convert.ToInt32(dropDownTrinhDo1.Selected_ID);
                   
                    item.IdHocHam = Convert.ToInt32(dropHocHam1.Selected_ID);
                    item.IdChuyenNganh = Convert.ToInt32(dropDownChuyenNganh1.Selected_ID);
                    item.GhiChu = richTextBoxWithBigEditor1.Text;
                    item.ChungChi = txtChungChi.Text;
                    item.IdChuyenKhoa = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                    item.NamBatDau = Convert.ToInt32(radNam.Text);

                }
            }
        }
        private void LoadDataForDropDownList()
        {
            dropDownChucVu1.FillData(1);
            dropDownDanToc1.FillData();
            dropDownGioiTinh1.FillData();
            dropDownQuocGia1.FillData();
            dropDownTinhThanh1.FillData(1);
            dropDownTrinhDo1.FillData(1);
            dropDownChuyenNganh1.FillData(1);
            dropHocHam1.FillData(1);
          //  dropDownChuyenNganh1.FillData(1);
            dropDownTinhThanh2.FillData(2);
            dropDownChuyenKhoa1.FillData(1);
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
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { dropDownGioiTinh1.Text, dropDownChucVu1.Selected_TextValue.ToString(), dropDownTrinhDo1.Selected_TextValue.ToString(),radNgaySinh.Value_String ,dropHocHam1.Selected_TextValue.ToString(),dropDownChuyenNganh1.Selected_TextValue.ToString(),radNam.Text,dropDownChuyenKhoa1.Selected_TextValue.ToString(),txtChungChi.Text}))
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

        private void Form_CanBo_NgoaiCDT_Load(object sender, EventArgs e)
        {

        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maso = radHoTen.Text;
            SqlConnection con = new SqlConnection(DBConnection.Connection);
            SqlCommand cmd = new SqlCommand("select HoTen from DIC_GiangVien", con);
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
