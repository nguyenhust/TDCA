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
    public partial class Form_CQ_MonHoc : NETLINK.UI.Dictionary
    {
       private DT_ChinhQuy_MonHoc item;
        private string fileUploaded;
        public Form_CQ_MonHoc(FormMode _formMode)
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
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_CQ_MonHoc_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_CQ_MonHoc_Edit });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Chính quy - Môn học:"+item.Ten);
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
                dropDownChuyenKhoa1.FillData(1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = DT_ChinhQuy_MonHoc.GetDT_ChinhQuy_MonHoc(formMode.Id);
                }
                else
                {
                    item = DT_ChinhQuy_MonHoc.NewDT_ChinhQuy_MonHoc();
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
                    txtdanhmuctailieu.Text = item.TaiLieuHocTap;
                    txtghichu.Text = item.GhiChu;
                    txtmonhoc.Text = item.Ten;
                    txtsohoctrinh.Text = item.SoHocTrinh.ToString();
                    dropDownChuyenKhoa1.Selected_ID = item.IdChuyenKhoa;
                }
                else
                {
                    if (dropDownChuyenKhoa1.Selected_ID != null)
                        item.IdChuyenKhoa = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                    item.SoHocTrinh = Convert.ToInt32(txtsohoctrinh.Text);
                    item.Ten = txtmonhoc.Text;
                    item.GhiChu = txtghichu.Text;
                    item.TaiLieuHocTap = txtdanhmuctailieu.Text;
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
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtmonhoc.Text,txtsohoctrinh.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            if (!GlobalCommon.CheckIsNumber(txtsohoctrinh.Text))
            {
                GlobalCommon.ShowErrorMessager("Số học trình phải là một số");
                return false;
            }
            //if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(denngay.Value_String, tungay.Value_String))
            //{
            //    GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, denngay.MyName, tungay.MyName));
            //    return false;
            //}
            return true;
        }

        private void UploadFile()
        {
            //if (!string.IsNullOrEmpty(radBrowseEditor1.Value) && radBrowseEditor1.Value != item.LinkFile)
            //{
            //    FtpUltilies ftp = new FtpUltilies();
            //    ftp.UploadLargeFile(radBrowseEditor1.Value, true, out fileUploaded);
            //}
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                //{
                //    FtpUltilies ftp = new FtpUltilies();
                //    ftp.SaveDownloadedFile(item.LinkFile);
                //}
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
