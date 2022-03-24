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
    public partial class Form_CQ_HocPhiChinhQuy : NETLINK.UI.Dictionary
    {
        private DT_ChinhQuy_HocVien item;

        private string fileUploaded;
        public Form_CQ_HocPhiChinhQuy(FormMode _formMode)
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
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_CQ_HocPhi_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_CQ_HocPhi_Edit });
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Chính quy - Học Phí học viên cmt:" + item.SoCMT);
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
                    item = DT_ChinhQuy_HocVien.GetDT_ChinhQuy_HocVien(formMode.Id);
                }
                else
                {
                    this.Close();
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
                    txtKhoa.Text = item.TenKhoaHoc;
                    txtMaHV.Text = item.MaHocVien;
                    txtNgaySinh.Value_String = item.NgaySinh;
                    txtTenHV.Text = item.HoTen;
                    txtTenLop.Text = item.TenLop;
                    gridViewHoaDon1.Value_AllInOne = item.AllInOneHoaDon;
                }
                else
                {
                    item.AllInOneHoaDon = gridViewHoaDon1.Value_AllInOne;
                    item.TongHocPhiDaDong = gridViewHoaDon1.Value_GetTongTien.ToString();
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
