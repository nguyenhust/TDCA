using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using NETLINK.LIB;
using ModuleDaoTao.UI;
using ModuleDaoTao.LIB;
using Authoration.LIB;
using DanhMuc.LIB;

namespace ModuleDaoTao.UserControls
{
    public partial class GridHocVienLienTucInHenChungNhan : UsDictionary
    {
        #region variables
        
        private FormMode formMode = new FormMode();
        private int selectedID = -1;

        private int Mode; // da dong hoc phi hay chua

        #endregion

        public GridHocVienLienTucInHenChungNhan(int mode)
        {
            this.Mode = mode;
           
            InitializeComponent();
            RadGrid = radGridView1;
            STT();
            SaveToNew();
            PrintToShow();

            if (this.Mode == DT_Common.HEN_CHUNGCHITHEOLOP)
            {
                radLabelChonLop.Visible = true;
                dropDownLopHocLienTuc1.Visible = true;
            }
            else
            {
                radLabelChonLop.Visible = false;
                dropDownLopHocLienTuc1.Visible = false;
            }
        }
        #region Override

        public override object GetIdValue()
        {
            if (Mode == DT_Common.HEN_CHUNGCHITHEOLOP)
                return TextMessages.ControlID.DT_HocVienLienTuc_HenChungChiTheoLop;
            else if (Mode == DT_Common.HEN_CHUNGCHIKEMCAP)
                return TextMessages.ControlID.DT_HocVienLienTuc_HenChungChiKemCap;
            else if (Mode == DT_Common.CHUNGCHI_THEOLOP)
                return TextMessages.ControlID.DT_HocVienLienTuc_ChungChiTheoLop;
            else if (Mode == DT_Common.CHUNGCHI_KEMCAP)
                return TextMessages.ControlID.DT_HocVienLienTuc_ChungChiKemCap;
            return -1;
        }

        public override string ToString()
        {
            if (Mode == DT_Common.HEN_CHUNGCHIKEMCAP)
                return TextMessages.FormTitle.DT_HocVienLienTuc_HenChungChiKemCap;
            else if (Mode == DT_Common.HEN_CHUNGCHITHEOLOP)
                return TextMessages.FormTitle.DT_HocVienLienTuc_HenChungChiTheoLop;
            else if (Mode == DT_Common.CHUNGCHI_KEMCAP)
                return TextMessages.FormTitle.DT_HocVienLienTuc_ChungChiKemCap;
            else if (Mode == DT_Common.CHUNGCHI_THEOLOP)
                return TextMessages.FormTitle.DT_HocVienLienTuc_ChungChiTheoLop;
            return string.Empty;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            dropDownLopHocLienTuc1.FillData();
            try
            {
                bl_btnDelete = false;
                bl_btnPrint = false;
                bl_btnSave = false;
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    BusinessFunction function = null;
                    if (Mode == DT_Common.HEN_CHUNGCHITHEOLOP || Mode == DT_Common.CHUNGCHI_THEOLOP)
                    {
                        function = new BusinessFunction(BusinessFunctionMode.GetDataHenChungChiTheoLop);
                        function.Item = null;
                    }
                    else if (Mode == DT_Common.HEN_CHUNGCHIKEMCAP || Mode == DT_Common.CHUNGCHI_KEMCAP)
                        function = new BusinessFunction(BusinessFunctionMode.GetDataHenChungChiKemCap);
                    function.ItemID = (int)PTIdentity.IDNguoiDung;
                    bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                }

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_Print))
                    bl_btnPrint = true;

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_InChungChi_Del))
                    bl_btnDelete = true;
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DT_LienTuc_HocVien.DeleteDT_LienTuc_HocVien(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        #endregion

        private void radGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.DT_LT_InChungChi_View,TextMessages.RolePermission.DT_LT_InChungChi_Edit}))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void dropDownLopHocLienTuc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DT_LienTuc_LopHoc_Info lophoc = (DT_LienTuc_LopHoc_Info)dropDownLopHocLienTuc1.Selected_Item;
            if (lophoc != null) {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataHenChungChiTheoLop);
                function.ItemID = (int)PTIdentity.IDNguoiDung;
                function.Item = lophoc.MaLop;
                bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            }
        }

        private void radGridView1_CellEndEdit_1(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                // just save when HoaDonHocPhi
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_QuanLyDiem_Edit))
                {
                    DT_LienTuc_HocVien_Info item = (DT_LienTuc_HocVien_Info)e.Row.DataBoundItem;
                    DT_LienTuc_HocVien_Coll hocVienColl = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
                    hocVienColl.Save();
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
