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
using ModuleChiDaoTuyen.LIB;
using ModuleChiDaoTuyen.UI;

namespace ModuleChiDaoTuyen.UserControl
{
    public partial class GridPhieuKhaoSat : UsDictionary
    {
        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        public GridPhieuKhaoSat()
        {
            InitializeComponent();
            RadGrid = radGridView;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Override

        public override object GetIdValue()
        {
            return "CDT_PhieuKhaoSat";//TextMessages.ControlID.CDT_PhieuKhaoSat;
        }

        public override string ToString()
        {
            return "Phiếu khảo sát";//TextMessages.FormTitle.CDT_PhieuKhaoSat;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"); //TextMessages.RolePermission.SystemAdmin);
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");//TextMessages.RolePermission.SystemAdmin);
            bl_btnMyClose = true;
            bl_btnDelete = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");//TextMessages.RolePermission.SystemAdmin);
        }

        protected override void Save()
        {

            formMode.IsInsert = true;
            PhieuKhaoSat pks = new PhieuKhaoSat(formMode);
            pks.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radbindingSource.DataSource = CDT_PhieuKhaoSat_Coll.GetCDT_PhieuKhaoSat_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                radbindingSource.DataSource = CDT_PhieuKhaoSat_Coll.GetCDT_PhieuKhaoSat_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    if (GlobalCommon.AcceptDelete())
                    {
                        CDT_PhieuKhaoSat.DeleteCDT_PhieuKhaoSat(selectedID);
                        LoadUS();
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex); 
            }
        }

        protected override void MyClose()
        {
            base.MyClose();
        }

        #endregion

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    PhieuKhaoSat pks = new PhieuKhaoSat(formMode);
                    pks.ShowDialog();
                    LoadUS();
                }


            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridView_Click(object sender, EventArgs e)
        {







        }

        private void radGridView_CellDoubleClick_1(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    PhieuKhaoSat pks = new PhieuKhaoSat(formMode);
                    pks.ShowDialog();
                    LoadUS();
                }


            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
