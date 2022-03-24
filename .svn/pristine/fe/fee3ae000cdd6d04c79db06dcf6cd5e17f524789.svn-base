using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UI;

namespace DanhMuc.UserControl
{
    public partial class ChucVu :NETLINK.UI.UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion
        
        public ChucVu()
        {
            InitializeComponent();
            RadGrid = radgChucVu;// gan grid mac dinh thanh grid minh keo vao
            STT();// them stt vao grid
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            ApplyAuthorizationRules();// apply phan quyen
            SaveToNew(); // ham nay chuyen text tu save thanh them moi
            PrintToShow(); // ham nay chuyen Print thanh liet ke
        }

        #region Overide

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DM_ChucVu;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DM_ChucVu;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ChucVu_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ChucVu_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ChucVu_Del);
        }

        /// <summary>
        /// Nut save da bi chuyen thanh nut them moi
        /// </summary>
        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                ChucvuInfo fr = new ChucvuInfo(formMode);
                fr.ShowDialog();
                LoadUS();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        /// <summary>
        /// Nut print bi chuyen thanh nut liet ke
        /// </summary>
        protected override void Print()
        {
            try
            {
                LoadUS();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void LoadUS()
        {
            try
            {
                RadGrid.DataSource = DIC_ChucVu_Coll.GetDIC_ChucVu_Coll();
            }
            catch (Exception ex)
            { 
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DIC_ChucVu.DeleteDIC_ChucVu(selectedID);
                    LoadUS();
                }

            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        #endregion

        private void CellFormatting(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radgChucVu_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_ChucVu_Edit))
                {
                    if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                    {
                        formMode.Id = selectedID;
                        formMode.IsEdit = true;
                        ChucvuInfo fr = new ChucvuInfo(formMode);
                        fr.ShowDialog();
                        LoadUS();
                    }
                }
                else
                {
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToEditForm);
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }


    }
}
