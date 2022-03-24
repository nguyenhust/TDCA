﻿using NETLINK.LIB;
using DanhMuc.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleHanhChinh.LIB;
using Authoration.LIB;

namespace ModuleHanhChinh.UI
{
    public partial class Form_VanPhongPham_NhapXuat : NETLINK.UI.Dictionary
    {
        
        private HC_DuTruVanPhongPham_NhapXuat item;
        private LoaiXuatNhap nhapXuat = LoaiXuatNhap.PhieuNhap;
        private int MaxXuat = 0;
        public Form_VanPhongPham_NhapXuat(FormMode _formMode)
        {
            InitializeComponent();
            
            this.formMode = _formMode;
            if (formMode.Item != null)
                nhapXuat = (LoaiXuatNhap)formMode.Item;
            else
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.LoiChungChung);
                this.Close();
            }
            if (nhapXuat == LoaiXuatNhap.PhieuNhap)
            {
                netLink_DatePicker1.MyName = "Ngày nhập";
            }
            else
                netLink_DatePicker1.MyName = "Ngày xuất";
            ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            try
            {
                if (formMode.IsInsert)
                    btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_VanPhongPham_NhapXuat_Insert });
                else
                    btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_VanPhongPham_NhapXuat_Edit });
               
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
                this.Close();
            }
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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Văn phòng phẩm nhập xuất ID:" + item.ID);
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
                //dropDownBoPhan1.FillData();
                if (nhapXuat == LoaiXuatNhap.PhieuXuat)
                {
                    this.Text = "Quản lý xuất văn phòng phẩm";
                    this.lbDonGia.Visible = false;
                    this.lbNgayNhap.Text = "Ngày xuất :";
                    this.lbNguonNhap.Visible = false;
                    this.txtDonGia.Visible = false;
                    this.txtNguonNhap.Visible = false;
                    this.lbNguonKinhPhi.Visible = false;
                    this.dropDownNguonKinhPhi1.Visible = false;
                    dropDownBoPhan1.Visible = true;
                    lbPhong.Visible = true;
                    
                    dropDownBoPhan1.FillData(1);
                    dropDownVanPhongPham1.FillData();
                    if (formMode.ItemColl != null)
                    {
                        HC_DuTruVanPhongPham_NhapXuat_Coll itemCollNX = (HC_DuTruVanPhongPham_NhapXuat_Coll)formMode.ItemColl;
                        HC_DuTruVanPhongPham_Coll itemCollVPP = dropDownVanPhongPham1.GetListData();
                        HC_DuTruVanPhongPham_Coll itemCollVPP2 = HC_DuTruVanPhongPham_Coll.NewHC_DuTruVanPhongPham_Coll();
                        foreach(HC_DuTruVanPhongPham_Info itemInfoVPP in itemCollVPP)
                        {
                            foreach (HC_DuTruVanPhongPham_NhapXuat_Info itemInfo in itemCollNX)
                            {
                                if (itemInfoVPP.TenThietBi == itemInfo.TenThietBi)
                                {
                                    itemInfoVPP.XuatSoLuong = itemInfo.SoLuongTon;
                                    itemCollVPP2.Add(itemInfoVPP);
                                    break;
                                }
                            }
                        }
                        
                        dropDownVanPhongPham1.FillData(itemCollVPP2);
                    }
                   
                }
                else
                {
                    dropDownNguonKinhPhi1.FillData(1);
                    dropDownVanPhongPham1.FillData();
                    
                }
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_DuTruVanPhongPham_NhapXuat.GetHC_DuTruVanPhongPham_NhapXuat(formMode.Id);
                }
                else
                {
                    item = HC_DuTruVanPhongPham_NhapXuat.NewHC_DuTruVanPhongPham_NhapXuat();
                }

                BindData(true);
                dropDownVanPhongPham1.Focus();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void BindData(bool isLoad)
        {
            if (isLoad)
            {
                if (nhapXuat == LoaiXuatNhap.PhieuNhap)
                {
                    dropDownVanPhongPham1.Selected_ID = item.IdThietBi;
                    dropDownNguonKinhPhi1.Selected_ID = item.IdNguonKinhPhi;
                    txtDonGia.Text = item.NhapDonGia;
                    if (dropDownVanPhongPham1.Selected_Item != null)
                    {
                        HC_DuTruVanPhongPham_Info vpp = (HC_DuTruVanPhongPham_Info)dropDownVanPhongPham1.Selected_Item;
                        txtDonVi.Text = vpp.DonVi;
                    }
                    txtNguonNhap.Text = item.NhapNoiCungCap;
                    txtSoLuong.Text = item.NhapSoLuong.ToString();
                    netLink_DatePicker1.Value_String = item.NhapNgay;
                    richTextBoxWithBigEditor1.Text = item.GhiChu;
                }
                else
                {
                    netLink_DatePicker1.Value_String = item.XuatNgay;
                    dropDownVanPhongPham1.Selected_ID = item.IdThietBi;
                    txtSoLuong.Text = item.XuatSoLuong.ToString();
                    richTextBoxWithBigEditor1.Text = item.GhiChu;
                    dropDownBoPhan1.Selected_ID = item.IdBoPhan;
                    MaxXuat = Convert.ToInt32(item.XuatSoLuong);
                }

            }
            else
            {
                if (nhapXuat == LoaiXuatNhap.PhieuNhap)
                {
                    if (dropDownNguonKinhPhi1.Selected_ID != null)
                        item.IdNguonKinhPhi = Convert.ToInt32(dropDownNguonKinhPhi1.Selected_ID);
                    if (dropDownVanPhongPham1.Selected_ID != null)
                        item.IdThietBi = Convert.ToInt32(dropDownVanPhongPham1.Selected_ID);
                    item.NhapDonGia = txtDonGia.Text;
                    item.NhapSoLuong = Convert.ToInt32(txtSoLuong.Text);
                    item.NhapNoiCungCap = txtNguonNhap.Text;
                    item.NhapNgay = netLink_DatePicker1.Value_String;
                    item.GhiChu = richTextBoxWithBigEditor1.Text;
                    item.XuatSoLuong = 0;
                    
                }
                else
                {
                    if (dropDownVanPhongPham1.Selected_ID != null)
                        item.IdThietBi = Convert.ToInt32(dropDownVanPhongPham1.Selected_ID);
                    item.XuatNgay = netLink_DatePicker1.Value_String;
                    item.GhiChu = richTextBoxWithBigEditor1.Text;
                    item.XuatSoLuong = Convert.ToInt32(txtSoLuong.Text);
                    if (dropDownBoPhan1.Selected_ID != null)
                        item.IdBoPhan = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                    item.NhapSoLuong = 0;
                }
                item.Type = Convert.ToInt32(nhapXuat);
                item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                item.LastEdited_Date = DateTime.Now;
                //item.GhiChu = richTextBoxWithBigEditor1.Text;
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!netLink_DatePicker1.isDateTime && !netLink_DatePicker1.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePicker1.Value_Error);
                return false;
            }
            if (nhapXuat == LoaiXuatNhap.PhieuNhap)
            {
                if (GlobalCommon.CheckArrayTextIsNull(new object[] {dropDownVanPhongPham1.Selected_TextValue,dropDownNguonKinhPhi1.Selected_TextValue,netLink_DatePicker1.Value_String,txtSoLuong.Text }))
                {
                    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                    return false;
                }
            }
            else
            {
                if (GlobalCommon.CheckArrayTextIsNull(new object[] { dropDownVanPhongPham1.Selected_TextValue, dropDownBoPhan1.Text, netLink_DatePicker1.Value_String, txtSoLuong.Text }))
                {
                    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                    return false;
                }
            }
           
            if (!string.IsNullOrEmpty(txtDonGia.Text) && !GlobalCommon.CheckIsNumberLong(txtDonGia.Text))
            {
                GlobalCommon.ShowErrorMessager("Đơn giá phải là một số");
                return false;
            }
            if (!GlobalCommon.CheckIsNumberLong(txtSoLuong.Text))
            {
                GlobalCommon.ShowErrorMessager("Số lượng phải là một số");
                return false;
            }
            if (nhapXuat == LoaiXuatNhap.PhieuXuat && Convert.ToInt32(txtSoLuong.Text)>MaxXuat)
            {
                GlobalCommon.ShowErrorMessager("Bạn không thể xuất quá số lượng tồn kho");
                return false;
            }
            return true;
        }

        private void Form_VanPhongPham_Load(object sender, EventArgs e)
        {

        }

        private void Form_VanPhongPham_Load_1(object sender, EventArgs e)
        {

        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dropDownVanPhongPham1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropDownVanPhongPham1.Selected_Item != null)
                {
                    HC_DuTruVanPhongPham_Info itemIn = (HC_DuTruVanPhongPham_Info)dropDownVanPhongPham1.Selected_Item;
                    txtDonVi.Text = itemIn.DonVi;
                    if (nhapXuat == LoaiXuatNhap.PhieuXuat)
                    {
                        if (formMode.IsInsert)
                        {
                            MaxXuat = Convert.ToInt32(itemIn.XuatSoLuong);
                            
                        }
                        else if (formMode.IsEdit)
                        {
                            MaxXuat = Convert.ToInt32(itemIn.XuatSoLuong) + Convert.ToInt32(item.XuatSoLuong);
                            
                        }
                        lbSoLuong.Text = string.Format("Số lượng : (<={0})",MaxXuat.ToString());
                        if (MaxXuat == 0)
                        {
                            btnSave.Enabled = false;
                        }
                        else
                        {
                            btnSave.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }




    }
}
