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


namespace ModuleDaoTao.UserControls
{
    public partial class GridNghienCuuKhoaHoc : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridNghienCuuKhoaHoc()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
            RadGrid.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid.CellFormatting += radGridView_CellFormatting;
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_NghienCuuKhoaHoc;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_NghienCuuKhoaHoc;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_NghienCuuKhoaHoc_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_NghienCuuKhoaHoc_View);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_NghienCuuKhoaHoc_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_NCKH_NghienCuuKhoaHoc fr = new Form_NCKH_NghienCuuKhoaHoc(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_NghienCuuKhoaHoc_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    radbindingSource.DataSource = DT_NghienCuuKhoaHoc_Coll.GetDT_NghienCuuKhoaHoc_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            LoadUS();
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DT_NghienCuuKhoaHoc.DeleteDT_NghienCuuKhoaHoc(selectedID);
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

        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_NghienCuuKhoaHoc_Edit))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_NCKH_NghienCuuKhoaHoc fr = new Form_NCKH_NghienCuuKhoaHoc(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
