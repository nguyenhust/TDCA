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

    public partial class Form_CQ_LopHocMonHocGiangVien : Dictionary
    {

        private DT_ChinhQuy_GiangVienMonHoc item;
        private string fileUploaded;
        public Form_CQ_LopHocMonHocGiangVien(FormMode _formMode)
        {
            InitializeComponent();

            this.formMode = _formMode;
            //tungay.MyName = "Từ ngày";
            //denngay.MyName = "Đến ngày"; 
            ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_CQ_HocVien_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_CQ_HocVien_Edit });
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave())
                {
                    UploadFile();
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Lớp học - giáo viên - môn học :" + item.IdLopHoc);
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
                dropDownCanBo1.FillData(LoaiCanBo.GiaoVien, 1);
                dropDownMonHocChinhQuy1.FillData(1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = DT_ChinhQuy_GiangVienMonHoc.GetDT_ChinhQuy_GiangVienMonHoc(formMode.Id);
                }
                else
                {
                    item = DT_ChinhQuy_GiangVienMonHoc.NewDT_ChinhQuy_GiangVienMonHoc();
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
                    dropDownCanBo1.Selected_ID = item.IdGiangVien;
                    dropDownMonHocChinhQuy1.Selected_ID = item.IdMonHoc;
                    radTextBox1.Text = item.TongSoTietDuKien.ToString();
                    radTextBox2.Text = item.TongSoTietThucTe.ToString();
                    richTextBoxWithBigEditor1.Text = item.Backup01;
                }
                else
                {
                    item.IdLopHoc = Convert.ToInt32(formMode.Item);
                    if (dropDownCanBo1.Selected_ID != null)
                        item.IdGiangVien = Convert.ToInt64(dropDownCanBo1.Selected_ID);
                    if (dropDownMonHocChinhQuy1.Selected_ID != null)
                        item.IdMonHoc = Convert.ToInt32(dropDownMonHocChinhQuy1.Selected_ID);
                    item.TongSoTietDuKien = Convert.ToInt32(radTextBox1.Text);
                    item.TongSoTietThucTe = Convert.ToInt32(radTextBox2.Text);
                    item.Backup01 = richTextBoxWithBigEditor1.Text;
                    item.LastEdited_Date = DateTime.Now;
                    item.LastEdited_User = PTIdentity.IDNguoiDung;

                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            //if (!tungay.isDateTime && !tungay.isNull)
            //{
            //    GlobalCommon.ShowErrorMessager(tungay.Value_Error);
            //    return false;
            //}
            //if (!denngay.isDateTime && !denngay.isNull)
            //{
            //    GlobalCommon.ShowErrorMessager(denngay.Value_Error);
            //    return false;
            //}
            //if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtAnPham.Text, dropDownLoai1.Selected_TextValue, radMaskedEditBox1.Text, tungay.Value_String, denngay.Value_String }))
            //{
            //    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
            //    return false;
            //}
            //if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(denngay.Value_String, tungay.Value_String))
            //{
            //    GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, denngay.MyName, tungay.MyName));
            //    return false;
            //}
            return true;
        }

        private void UploadFile()
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }
    }

}
