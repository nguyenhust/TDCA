using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using DanhMuc.LIB;
using ModuleChiDaoTuyen.LIB;
using NETLINK.UI;

namespace ModuleChiDaoTuyen.UI
{
    public partial class HoiChuanTrucTuyen : Dictionary
    {
        private CDT_HoiChuan item;
        private CDT_HoiChuan_BVThamGia_Coll itemSubList;
        private CDT_HoiChuan_BVThamGia itemSubList_New;
        private FormMode mode;
        private FormMode mode_BVThamGia;
        private int selectedID;
        public HoiChuanTrucTuyen(FormMode formMode)
        {
            InitializeComponent();
            mode = formMode;
            mode_BVThamGia = new FormMode();
        }
        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("AnhVideo:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"
            || Csla.ApplicationContext.User.IsInRole("AnhVideo:U"));
        }

        protected override void FormLoad()
        {
            try
            {
                dropDownBenhVien.FillData();
                ProcessFormMode();
                FillDataToControl();
                LoadData();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                LogicProcessBeforeSave();
                item.ApplyEdit();
                item = item.Save();
                mode.Id = item.Id;
                radBindingSource_HoiThao.DataSource = item;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        #region Business Processing

        private void LoadData()
        {
            if (mode == null || mode.Id < 0)
                itemSubList = CDT_HoiChuan_BVThamGia_Coll.NewCDT_HoiChuan_BVThamGia_Coll();
            else
                itemSubList = CDT_HoiChuan_BVThamGia_Coll.GetCDT_HoiChuan_BVThamGia_Coll(mode.Id);
            radBindingSource_BVthamgiaList.DataSource = itemSubList;
        }

        private void ProcessFormMode()
        {
            if (mode.IsEdit)
            {
                if (mode.Item == null)
                {
                    item = CDT_HoiChuan.GetCDT_HoiChuan(mode.Id);
                }
                else
                {
                    item = (CDT_HoiChuan)mode.Item;
                }
            }
            else
            {
                item = CDT_HoiChuan.NewCDT_HoiChuan();
            }
            radBindingSource_HoiThao.DataSource = item;
        }

        private void FillDataToControl()
        {
            raddateNgay.Value = Convert.ToDateTime(item.NgayDienRa);
            radtxtBC1.Text = item.BaoCaoVienBM1;
            radtxtBC1ChucVu.Text = item.ChucVuBCV1;
            radtxtBC2.Text = item.BaoCaoVienBM2;
            radtxtBC2ChucVu.Text = item.ChucVuBCV2;
            radtxtChuTriBM.Text = item.ChuTriBM;
            radtxtChucVuBM.Text = item.ChucVuThuKy;
            radtxtChucVuChuTri.Text = item.ChucVuChuTri;
            radtxtMaDK.Text = item.MaDK;
            radtxtNoiDung.Text = item.NoiDung;
            radtxtGhiChu.Text = item.GhiChu;
            radtxtSoLuongBM.Text = item.SoLuongCBBMThamDu.ToString();
            radtxtThuKyBM.Text = item.ThuKyBM;
        }

        /// <summary>
        /// Xử lý các thao tác ẩn hiện control theo logi
        /// </summary>
        private void LogicProcess()
        {
            if (string.IsNullOrEmpty(radtxtChuTriBM.Text))
                radtxtChucVuChuTri.Enabled = false;
            else
                radtxtChucVuChuTri.Enabled = true;
            if (string.IsNullOrEmpty(radtxtThuKyBM.Text))
                radtxtChucVuBM.Enabled = false;
            else
                radtxtChucVuBM.Enabled = true;
            if (string.IsNullOrEmpty(radtxtBC1.Text))
                radtxtBC1ChucVu.Enabled = false;
            else
                radtxtBC1ChucVu.Enabled = true;
            if (string.IsNullOrEmpty(radtxtBC2.Text))
                radtxtBC2ChucVu.Enabled = false;
            else
                radtxtBC2ChucVu.Enabled = true;
        }

        /// <summary>
        /// Xu ly cac yeu cau logic truoc khi save
        /// </summary>
        private void LogicProcessBeforeSave()
        {
            if (string.IsNullOrEmpty(radtxtChuTriBM.Text))
                radtxtChucVuChuTri.Text = string.Empty;
            if (string.IsNullOrEmpty(radtxtThuKyBM.Text))
                radtxtChucVuBM.Text = string.Empty;
            if (string.IsNullOrEmpty(radtxtBC1.Text))
                radtxtBC1ChucVu.Text = string.Empty;
            if (string.IsNullOrEmpty(radtxtBC2.Text))
                radtxtBC2ChucVu.Text = string.Empty;
        }

        private Boolean CheckDupilcateData(long idBenhVien)
        {
            if (itemSubList != null && mode_BVThamGia.IsInsert)
            {
                foreach (CDT_HoiChuan_BVThamGia_Info itemInfo in itemSubList)
                {
                    if (Convert.ToInt64(itemInfo.IdBenhVien) == idBenhVien)
                        return true;
                }
            }
            return false;
        }

        #endregion

        #region Event Handler
        private void radbtnInsertList_Click(object sender, EventArgs e)
        {
            itemSubList_New = CDT_HoiChuan_BVThamGia.NewCDT_HoiChuan_BVThamGia();
            radBindingSource_BVthamGiaInfo.DataSource = itemSubList_New;
            radtxtSoLuongBVkhac.Text = "0";
            radRaKhong.IsChecked = true;
            radbtnEditList.Enabled = true;
            radbtnDelList.Enabled = true;
            mode_BVThamGia.IsInsert = true;
        }

        private void radbtnEditList_Click(object sender, EventArgs e)
        {
            try
            {
                itemSubList_New.IdBenhVien = Convert.ToInt64(dropDownBenhVien.Selected_ID);
                if (CheckDupilcateData(Convert.ToInt64(itemSubList_New.IdBenhVien)))
                    GlobalCommon.ShowErrorMessager(ErrorMessage.CDT_HoiChuan_BenhVienDuplicate);
                else
                {
                    itemSubList_New.SoLuongThamDu = Convert.ToInt32(radtxtSoLuongBVkhac.Text);
                    itemSubList_New.IdHoiChuan = mode.Id;
                    itemSubList_New.CoBaoCao = radRaCo.IsChecked;
                    itemSubList_New.IdTinhThanh = ((DIC_BenhVien_Info)dropDownBenhVien.Selected_Item).IDTinh;
                    itemSubList_New.ApplyEdit();
                    itemSubList_New.Save();
                    LoadData();
                    radbtnDelList.Enabled = false;
                    radbtnEditList.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radbtnDelList_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    if (GlobalCommon.AcceptDelete())
                    {
                        CDT_HoiChuan_BVThamGia.DeleteCDT_HoiChuan_BVThamGia(selectedID);
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex, ErrorMessage.GridView_BanChuaChonDoiTuongCanThaoTac);
            }
        }


        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    itemSubList_New = CDT_HoiChuan_BVThamGia.GetCDT_HoiChuan_BVThamGia(selectedID);
                    radBindingSource_BVthamGiaInfo.DataSource = itemSubList_New;
                    radRaCo.IsChecked = Convert.ToBoolean(itemSubList_New.CoBaoCao);
                    radRaKhong.IsChecked = !radRaCo.IsChecked;
                    mode_BVThamGia.IsEdit = true;
                    radbtnEditList.Enabled = true;
                    radbtnDelList.Enabled = true;
                }


            }
            catch (Exception ex)
            {

                GlobalCommon.ShowErrorMessager(ex, ErrorMessage.GridView_BanChuaChonDoiTuongCanThaoTac);
            }
        }

        private void radtxtChuTriBM_TextChanged(object sender, EventArgs e)
        {
            LogicProcess(); btnSave.Enabled = true;
        }

        private void radtxtThuKyBM_TextChanged(object sender, EventArgs e)
        {
            LogicProcess(); btnSave.Enabled = true;
        }

        private void radtxtBC1_TextChanged(object sender, EventArgs e)
        {
            LogicProcess(); btnSave.Enabled = true;
        }

        private void radtxtBC2_TextChanged(object sender, EventArgs e)
        {
            LogicProcess(); btnSave.Enabled = true;
        }



        #endregion



        




    }
}
