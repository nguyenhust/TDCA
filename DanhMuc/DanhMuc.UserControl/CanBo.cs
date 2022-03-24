using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using NETLINK.UI;

namespace DanhMuc.UserControl
{
    public partial class CanBo : NETLINK.UI.UsDictionary
    {
        public CanBo()
        {
            InitializeComponent();
            RadGrid = radGCanBo;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }
        DIC_CanBo_Coll  canbocoll;
        DIC_CanBo canbo;
        Int64 IDCanBo = 0;
        private void CanBo_Load(object sender, EventArgs e)
        {

        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuCanBo";
        }

        public override string ToString()
        {
            return "Danh Muc Cán Bộ";
        }
        protected override void MyClose()
        {
            this.Close();
        }

        protected override void Print()
        {
            try
            {
                radGCanBo.DataSource = DanhMuc.LIB.DIC_CanBo_Coll.GetDIC_CanBo_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }

            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_BenhVien_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_BenhVien_Print);
            bl_btnMyClose = true;
            //bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_BenhVien_Del);
        }
        protected override void Save()
        {
            try
            {
                DanhMuc.CanBoInfo frm = new DanhMuc.CanBoInfo();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex.Message, "Lỗi thêm mới");
            }
        }
        protected override void LoadUS()
        {
            try
            {
                radGCanBo.DataSource = DanhMuc.LIB.DIC_CanBo_Coll.GetDIC_CanBo_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            }

            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion


        #region Even
        
        
        
        
        private void MasterTemplate_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGCanBo.CurrentRow.Cells["ID"].Value != null)
                {
                    IDCanBo = Convert.ToInt64(radGCanBo.CurrentRow.Cells["ID"].Value);
                    CanBoInfo cb = new CanBoInfo(IDCanBo);
                    cb.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
            
        }
        private void CellFormatting(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        private void CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            try
            {
                canbocoll = (DIC_CanBo_Coll)radGCanBo.DataSource;
                if (canbo.IsDirty == true)
                    StateDirty();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        #endregion








    }
}
