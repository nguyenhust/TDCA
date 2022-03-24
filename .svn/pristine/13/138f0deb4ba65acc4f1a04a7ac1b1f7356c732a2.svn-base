using System;
using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UserControl;
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
    public partial class Form_LT_NhapDiemThi : NETLINK.UI.Dictionary
    {
        
        private DT_LienTuc_HocVien item;
        private int selectedID = -1;

        DT_Lientuc_HocVienSearch objHocVienSearch;

        public Form_LT_NhapDiemThi(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            objHocVienSearch = new DT_Lientuc_HocVienSearch();
            bindingSourceHocVienSearch.DataSource = objHocVienSearch;
        }

        private void radButtonTimKiem_Click(object sender, EventArgs e)
        {
            string malop = (string)dropDownLopHocLienTuc.Selected_ID;
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
            objHocVienSearch.MaLop = malop;
            objHocVienSearch.IsDongHocPhi = null;
            function.Item = objHocVienSearch;
            function.ItemID = (int)PTIdentity.IDNguoiDung;
            bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
        }


        #region Override

        protected override void ApplyAuthorizationRules()
        {
            /*this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            btnContinue.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            HopDong_Activated(this, EventArgs.Empty);*/
        }

        protected override void FormLoad()
        {
            try
            {
                dropDownLopHocLienTuc.FillData();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.Column.Name == "DiemThi" || 
                    e.Column.Name == "Lan1" || e.Column.Name == "Lan2" ||
                    e.Column.Name == "Lan3" || e.Column.Name == "Lan4")
                {
                    DT_LienTuc_HocVien_Coll coll = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
                    coll.Save();
                    
                }
            }
            catch (Exception ex)
            {
                radGridView1.CancelEdit();
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
