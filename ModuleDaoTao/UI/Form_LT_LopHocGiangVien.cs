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

    public partial class Form_LT_LopHocGiangVien : Dictionary
    {

        private DT_LienTuc_GiangVien item;
        public Form_LT_LopHocGiangVien(FormMode _formMode)
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Lớp học - giáo viên:" + item.IdLopHoc);
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
                //dropDownCanBo1.DataSource = DIC_GiangVien_Coll.GetDIC_GiangVien_Coll();
                //dropDownGiangVien1.FillData();
                radDropChuyenKhoa.DataSource = DIC_ChuyenKhoa_Coll.GetDIC_ChuyenKhoa_Coll();               
                radDropGiangVien.DataSource = DIC_GiangVien_Coll.GetDIC_GiangVien_Coll();
                radDropGiangVien.Text = null;
                radDropChuyenKhoa.Text = null;
                //dropDownCanBo1.FillData(LoaiCanBo.GiaoVien, 1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = DT_LienTuc_GiangVien.GetDT_LienTuc_GiangVien(formMode.Id);
                }
                else
                {
                    item = DT_LienTuc_GiangVien.NewDT_LienTuc_GiangVien();
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
                    radDropGiangVien.SelectedValue = item.IdGiangVien;
                    //if (item.SoTietDuKien.HasValue)
                    //    radTextBox1.Text = item.SoTietDuKien.ToString();

                    //if (item.SoTietThucTe.HasValue)
                    //    radTextBox2.Text = item.SoTietThucTe.ToString();
                    richTextBoxWithBigEditor1.Text = item.Backup01;
                }
                else
                {
                    item.IdLopHoc = formMode.Item.ToString();
                    if (radDropGiangVien.SelectedValue != null)
                        item.IdGiangVien = Convert.ToInt64(radDropGiangVien.SelectedValue.ToString());
                    item.GiangVien = radDropGiangVien.Text;
                    item.SoTietDuKien = Convert.ToInt32(0);
                    item.SoTietThucTe = Convert.ToInt32(0);
                    item.Backup01 = richTextBoxWithBigEditor1.Text;
                    item.LastEdited_Date = DateTime.Now.ToString();
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

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void radDropChuyenKhoa_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (radDropChuyenKhoa.Text != null && radDropChuyenKhoa.Text != "")
            {
                
                string inta = radDropChuyenKhoa.SelectedValue.ToString();
                radDropGiangVien.DataSource = DIC_GiangVien_Coll.GetDIC_GiangVien_Coll_GiangVien(Convert.ToInt64(radDropChuyenKhoa.SelectedValue.ToString()));
                radDropGiangVien.Text = null;
            }
        }
    }

}
