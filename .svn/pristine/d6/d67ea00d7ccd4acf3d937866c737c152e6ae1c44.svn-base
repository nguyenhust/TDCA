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
using ModuleHanhChinh.LIB;

namespace ModuleHanhChinh.UI
{
    public partial class Form_GiangDuongPhongHop_PhieuDangKi : NETLINK.UI.Dictionary
    {
        
        private HC_GiangDuong_PhieuDangKi item;
        private HC_GiangDuong_PhieuDangKi_Coll items;
        private HC_GiangDuong_PhieuDangKi_Info itemInfo;
        private int selectedID;
        public Form_GiangDuongPhongHop_PhieuDangKi(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            btnSave.Text = "Xác nhận";
            btnSave.Enabled = false;
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_GiangDuong_Phong_Edit, TextMessages.RolePermission.HC_GiangDuong_Phong_Insert });
        }
        protected override void Save()
        {
            try
            {
                if (GlobalCommon.AcceptUpdate())
                {
                    item.DaDuocDuyet = true;
                    item.ApplyEdit();
                    item.Save();
                    itemInfo.DaDuocDuyet = true;
                    btnSave.Enabled = false;
                    
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
                items = HC_GiangDuong_PhieuDangKi_Coll.GetHC_GiangDuong_PhieuDangKi_Coll();
                radBindingSourceList.DataSource = items;
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

                }
                else
                {
                }
            }
        }
        private void BindMainData(bool isLoad)
        {
            if (item != null)
            {
                if (isLoad)
                {
                    radcbBangButViet.Checked = Convert.ToBoolean(item.BangButViet);
                    radcbBanhKeo.Checked = Convert.ToBoolean(item.BanhKeo);
                    radcbButLazer.Checked = Convert.ToBoolean(item.ButLazer);
                    radcbHoaTuoi.Checked = Convert.ToBoolean(item.HoaTuoi);
                    radcbKhanTraiBan.Checked = Convert.ToBoolean(item.KhanTraiBan);
                    radcbManChieu.Checked = Convert.ToBoolean(item.ManChieu);
                    radcbMayChieu.Checked = Convert.ToBoolean(item.MayChieu);
                    radcbMicro.Checked = Convert.ToBoolean(item.Micro);
                    radcbNuocChoGiangVien.Checked = Convert.ToBoolean(item.NuocChoGiangVien);
                    radcbNuocChoHV.Checked = Convert.ToBoolean(item.NuocChoHocVien);
                    radcbPhongHoiTruong.Checked = Convert.ToBoolean(item.PhongHoiTruong);
                    radcbTraiCay.Checked = Convert.ToBoolean(item.TraiCay);
                    radtxtKhac.Text = item.Khac;
                    radtxtNoiDung.Text = item.NoiDungSuDung;
                }
                else
                {
                    item.BangButViet = radcbBangButViet.Checked;
                    item.BanhKeo = radcbBanhKeo.Checked;
                    item.ButLazer = radcbButLazer.Checked;
                    item.HoaTuoi = radcbHoaTuoi.Checked;
                    item.KhanTraiBan = radcbKhanTraiBan.Checked;
                    item.ManChieu = radcbManChieu.Checked;
                    item.MayChieu = radcbMayChieu.Checked;
                    item.Micro = radcbMicro.Checked;
                    item.NuocChoGiangVien = radcbNuocChoGiangVien.Checked;
                    item.NuocChoHocVien = radcbNuocChoHV.Checked;
                    item.PhongHoiTruong = radcbPhongHoiTruong.Checked;
                    item.TraiCay = radcbTraiCay.Checked;
                    item.Khac = radtxtKhac.Text;
                    item.NoiDungSuDung = radtxtNoiDung.Text;
                }
            }
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    itemInfo = (HC_GiangDuong_PhieuDangKi_Info)e.Row.DataBoundItem;
                    item = HC_GiangDuong_PhieuDangKi.GetHC_GiangDuong_PhieuDangKi(selectedID);
                    BindMainData(true);
                    btnSave.Enabled = !Convert.ToBoolean(item.DaDuocDuyet);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex);
            }
        }
    }
}
