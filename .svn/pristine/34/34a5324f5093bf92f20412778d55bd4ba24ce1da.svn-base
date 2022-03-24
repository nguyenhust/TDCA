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
using ExportLib.Entities.DaoTao;
using ExportLib;

namespace ModuleDaoTao.UI
{
    public partial class Form_CQ_NhapDiemThi : NETLINK.UI.Dictionary
    {
        #region variables

        
        private DT_ChinhQuy_HocVienSearch _hocvienSearch;

        #endregion

        public Form_CQ_NhapDiemThi(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            _hocvienSearch = new DT_ChinhQuy_HocVienSearch();
            bindingSourceSearch.DataSource = _hocvienSearch;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == TextMessages.RolePermission.SystemAdmin
            || Csla.ApplicationContext.User.IsInRole("GoiKyThuat:U"));
        }

        protected override void FormLoad()
        {
            try
            {
                dropDownMonHocChinhQuy1.FillData(1);
                if (radRadioButton1.IsChecked)
                    dropDownLopHocChinhQuy1.FillData();
                LoadData();

            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {

            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void LoadUS()
        {
            try
            {
               // bindingSource.DataSource = DT_ChinhQuy_DiemThi_Coll.GetDT_ChinhQuy_DiemThi_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }


        protected override void Delete()
        {
            base.Delete();
        }

        #endregion

        #region loading and binding data

        private void LoadData()
        {
            if (radRadioButton1.IsChecked) // lớp học
            {
                dropDownLopHocChinhQuy1.Enabled = true;
                radDropDownList2.Enabled = false;
            }
            else
            {
                dropDownLopHocChinhQuy1.Enabled = false;
                radDropDownList2.Enabled = true;
            }
        }

        #endregion

        #region form's events

        private void Form_CQ_NhapDiemThi_Load(object sender, EventArgs e)
        {
            
        }

        // tim kiem
        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
                _hocvienSearch.MonThi = Convert.ToInt32(dropDownMonHocChinhQuy1.Selected_ID);
                function.Item = _hocvienSearch;
                function.ItemID = (int)PTIdentity.IDNguoiDung;
                bindingSource.DataSource = DT_ChinhQuy_HocVien_Coll.GetDT_ChinhQuy_HocVien_Coll(function);
                
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        private void radRadioButton1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radRadioButton1.IsChecked)
            {
                dropDownLopHocChinhQuy1.Enabled = true;
                radDropDownList2.Enabled = false;
            }
            else
            {
                radDropDownList2.Enabled = true;
                dropDownLopHocChinhQuy1.Enabled = false;
            }
        }

        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void radButtonHennhanchungchi_Click(object sender, EventArgs e)
        {
            if (bindingSource.DataSource != null)
            {
                DT_ChinhQuy_HocVien_Coll lstHv = (DT_ChinhQuy_HocVien_Coll)bindingSource.DataSource;
                if (lstHv != null) {
                    foreach (var hv in lstHv) {
                        G001_GiayHenTraChungChiHocVien chungchi = new G001_GiayHenTraChungChiHocVien();

                        chungchi.GioiTinh = hv.GioiTinh;
                        chungchi.HoTenHocVien = hv.HoTen;
                        chungchi.KetQuaHocTap = "Đạt";
                        chungchi.NgaySinh = hv.NgaySinh;
                        DateTime date = DateTime.Now;
                        chungchi.NgayViet = "ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
                        chungchi.NoiCongTac = hv.NoiCongTac;
                        chungchi.NoiDungDangKy = hv.NoiCongTac;

                        //chungchi.TrinhDo = hv.TrinhDo;


                        DIC_ChuyenNganh_Coll chuyennganh = DIC_ChuyenNganh_Coll.GetDIC_ChuyenNganh_Coll();
                        foreach (var item in chuyennganh) {
                            if (item.ID == hv.IdChuyenNganh) {
                                chungchi.DiaDiem = item.Ten;
                                break;
                            }
                        }
                        ExportDaoTao daotao = new ExportDaoTao();
                        daotao.G001_GiayHenTraChungChiHocVien(new List<ExportLib.Entities.DaoTao.G001_GiayHenTraChungChiHocVien>(){chungchi}, Constants.ExportType.Pdf);
                    }
                }
            }
        }


    }
}
