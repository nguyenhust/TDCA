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


namespace ModuleDaoTao.UI
{
    public partial class Form_CQ_KhenThuongKiLuat : NETLINK.UI.Dictionary
    {
        #region variables

        
        private int selectedID = -1;
        private DT_ChinhQuy_KhenThuongKyLuat_Coll item;

        #endregion

        public Form_CQ_KhenThuongKiLuat(FormMode _formMode)
        {
            InitializeComponent();
            RadGrid = radGridView;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DT_CQ_HocVien_Edit, TextMessages.RolePermission.DT_CQ_HocVien_Insert });
        }

        protected override void FormLoad()
        {
            try
            {
                
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
        private void LoadData()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllData);
            function.ItemID = formMode.Id;
            item = DT_ChinhQuy_KhenThuongKyLuat_Coll.GetDT_ChinhQuy_KhenThuongKyLuat_Coll(function);
        }

        protected override void Save()
        {
            try
            {
               
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
           
        }

        protected void LoadUs()
        {
            try
            {
                radbindingSource.DataSource = DT_ChinhQuy_KhenThuongKyLuat_Coll.GetDT_ChinhQuy_KhenThuongKyLuat_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected void Print()
        {
            LoadUs();
        }

        #endregion

        #region form's events

        private void Form_CQ_KhenThuongKiLuat_Load(object sender, EventArgs e)
        {
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DT_ChinhQuy_KhenThuongKyLuat itemInfo = DT_ChinhQuy_KhenThuongKyLuat.NewDT_ChinhQuy_KhenThuongKyLuat();
               //itemInfo.HinhThuc = rad
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
         
        }

        #endregion

        #region gridview's events

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

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    DT_ChinhQuy_KhenThuongKyLuat.DeleteDT_ChinhQuy_KhenThuongKyLuat(selectedID);
                    LoadUs();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
