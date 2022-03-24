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
    public partial class GridHopDongGoiKT : UsDictionary
    {
        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        public GridHopDongGoiKT()
        {
            InitializeComponent();
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid = radGridView;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
               try
            {
                string Id = radGridView.CurrentRow.Cells["IdHopDong"].Value.ToString();
                if(!string.IsNullOrEmpty(Id))
                {
                    formMode.StringId = Id;
                    formMode.IsEdit = true;
                    Form_HopDongCGKT fr = new Form_HopDongCGKT(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }

                    
                
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.CDT_HopDongKyThuat;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.CDT_HopDongKyThuat;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");//TextMessages.RolePermission.SystemAdmin);
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");//TextMessages.RolePermission.SystemAdmin);
            bl_btnMyClose = true;
            bl_btnDelete = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");//TextMessages.RolePermission.SystemAdmin);
        }

        protected override void Save()
        {

            formMode.IsInsert = true;
            Form_HopDongCGKT fr = new Form_HopDongCGKT(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radbindingSource.DataSource = CDT_HopDong_GoiKT_Coll.GetCDT_HopDong_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                radbindingSource.DataSource = CDT_HopDong_GoiKT_Coll.GetCDT_HopDong_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(),out selectedID) && GlobalCommon.AcceptDelete())
                {
                    CDT_HopDong_GoiKT.DeleteCDT_HopDong_GoiKT(selectedID);
                    LoadUS();
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
    }
}
