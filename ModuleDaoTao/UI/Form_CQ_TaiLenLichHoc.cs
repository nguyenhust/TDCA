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

namespace ModuleDaoTao.UI
{
    public partial class Form_CQ_TaiLenLichHoc : NETLINK.UI.Dictionary
    {
        
        private DT_ChinhQuy_ThoiKhoaBieu item;
        private string fileUploaded;
        public Form_CQ_TaiLenLichHoc(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = true;//GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_BieuMauISO_Insert, TextMessages.RolePermission.HC_BieuMauISO_Edit });
        }
        protected override void Save()
        {
            try
            {
                if (UploadFile())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
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
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = DT_ChinhQuy_ThoiKhoaBieu.GetDT_ChinhQuy_ThoiKhoaBieu(formMode.Id);
                }
                else
                {
                    item = DT_ChinhQuy_ThoiKhoaBieu.NewDT_ChinhQuy_ThoiKhoaBieu();
                }
                dropDownLopHocChinhQuy1.FillData();
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
                    radBrowseEditor1.Value = item.Link;
                }
                else
                {
                    try
                    {
                        item.IdLopHoc = Convert.ToInt32(dropDownLopHocChinhQuy1.Selected_ID);
                    }
                    catch
                    {
                    }
                    item.GhiChu = richTextBoxWithBigEditor1.Text;
                    item.TenHienThiTrenCTT = radTextBox1.Text;
                    item.Link = fileUploaded;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private bool UploadFile()
        {
            if (radBrowseEditor1.Value != null && !string.IsNullOrEmpty(radBrowseEditor1.Value.ToString()) && radBrowseEditor1.Value != item.Link)
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
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
