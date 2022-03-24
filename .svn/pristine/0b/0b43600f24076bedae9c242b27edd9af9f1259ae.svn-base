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
using ModuleHanhChinh.UI;
using ModuleHanhChinh.LIB;
using Authoration.LIB;


namespace ModuleHanhChinh.UserControl
{
    public partial class Grid_HC_BieuMauISO : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        //private NETLINK_Permission Permission = new NETLINK_Permission();
        private int selectedID = -1;
        #endregion

        public Grid_HC_BieuMauISO()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            PrintToShow();
            SaveToNew();
        }

        private void LoadPermission()
        {

        }

        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.HC_BieuMauISO;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.HC_BieuMauISO;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_BieuMauISO_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_BieuMauISO_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_BieuMauISO_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_BieuMauISO fr = new Form_BieuMauISO(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radbindingSource.DataSource = HC_BieuMauISO_Coll.GetHC_BieuMauISO_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView, PTIdentity.IDNguoiDung));
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
                Int64 x;
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && Int64.TryParse(radGridView.CurrentRow.Cells["IdUserUp"].Value.ToString(), out x))
                {

                    if (x == PTIdentity.IDNguoiDung)
                    {
                        if (GlobalCommon.AcceptDelete())
                        {
                            
                            HC_BieuMauISO.DeleteHC_BieuMauISO(selectedID);

                            GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Xóa biểu mẫu ISO: " + radGridView.CurrentRow.Cells["Ten"].Value.ToString());
                        }
                        LoadUS();
                    }
                    else
                    {
                        GlobalCommon.ShowErrorMessager("Bạn không phải là người tạo nên không có quyền xóa biểu mẫu này");
                    }
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
            if (e.CellElement.ColumnInfo.Name == "xem" && string.IsNullOrEmpty(e.CellElement.Text))
            {
                e.CellElement.Text = "Mở file";
                //e.CellElement.Click += CellElement_Click;
            }
        }

        void CellElement_Click(object sender, EventArgs e)
        {
            try
            {
                HC_BieuMauISO_Info itemInfo = (HC_BieuMauISO_Info)RadGrid.CurrentRow.DataBoundItem;
                FtpUltilies ftp = new FtpUltilies();
                ftp.SaveDownloadedFile(itemInfo.Link);
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_BieuMauISO_Edit))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_BieuMauISO fr = new Form_BieuMauISO(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (radGridView.CurrentCell.Text == "Mở file")
            {
                HC_BieuMauISO_Info itemInfo = (HC_BieuMauISO_Info)RadGrid.CurrentRow.DataBoundItem;
                FtpUltilies ftp = new FtpUltilies();
                ftp.SaveDownloadedFile(itemInfo.Link);
            }
        }
    }
}
