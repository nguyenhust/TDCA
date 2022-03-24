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

    public partial class Form_LT_LopHocDiaDiemToChuc : Dictionary
    {

        private DT_LienTuc_LopHoc_DiaDiemToChuc item;
        public Form_LT_LopHocDiaDiemToChuc(FormMode _formMode)
        {
            InitializeComponent();

            this.formMode = _formMode;
            tungay.MyName = "Từ ngày";
            denngay.MyName = "Đến ngày"; 
            ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_LT_LopHoc_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_LT_LopHoc_Edit });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Lớp học - Địa điểm tổ chức:" + item.MaLop);
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
               
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = DT_LienTuc_LopHoc_DiaDiemToChuc.GetDT_LienTuc_LopHoc_DiaDiemToChuc(formMode.Id);
                }
                else
                {
                    item = DT_LienTuc_LopHoc_DiaDiemToChuc.NewDT_LienTuc_LopHoc_DiaDiemToChuc();
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
                    dropDownBenhVien1.Selected_ID = item.IdBenhVien;
                    radTextBox1.Text = item.DonViThamGia;
                    tungay.Value_String = item.TuNgay;
                    denngay.Value_String = item.DenNgay;
                }
                else
                {
                    if(dropDownBenhVien1.Selected_ID != null)
                    item.IdBenhVien = Convert.ToInt64(dropDownBenhVien1.Selected_ID);
                    item.DonViThamGia = radTextBox1.Text;
                    item.TuNgay = tungay.Value_String;
                    item.DenNgay = denngay.Value_String;
                    item.MaLop = formMode.Item.ToString();
                   // item.IdLopHoc = Convert.ToInt32(formMode.Id64);

                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!tungay.isDateTime && !tungay.isNull)
            {
                GlobalCommon.ShowErrorMessager(tungay.Value_Error);
                return false;
            }
            if (!denngay.isDateTime && !denngay.isNull)
            {
                GlobalCommon.ShowErrorMessager(denngay.Value_Error);
                return false;
            }
            //if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtAnPham.Text, dropDownLoai1.Selected_TextValue, radMaskedEditBox1.Text, tungay.Value_String, denngay.Value_String }))
            //{
            //    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
            //    return false;
            //}
            if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(denngay.Value_String, tungay.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, denngay.MyName, tungay.MyName));
                return false;
            }
            return true;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }

}
