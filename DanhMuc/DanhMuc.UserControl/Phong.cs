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
    public partial class Phong : NETLINK.UI.UsDictionary
    {
        private int selectedID = -1;
        private FormMode formMode = new FormMode();

        public Phong()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgPhong;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Overide

        public override object GetIdValue()
        {
            return "mnuPhong";
        }

        public override string ToString()
        {
            return "Quản lý danh mục phòng";
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Phong_Insert);
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Phong_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Phong_Del);
        }

        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                PhongInfo fr = new PhongInfo(formMode);
                fr.ShowDialog();
                LoadUS();
            }
            catch (Exception ex)
            {
                NETLINK.LIB.GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        protected override void Print()
        {
            try
            {
                LoadUS();
            }
            catch (Exception ex)
            {
                NETLINK.LIB.GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void LoadUS()
        {
            #region SetColumnIDCanBo
            DIC_CanBo_Coll canbo;
            canbo = DIC_CanBo_Coll.GetDIC_CanBo_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
            GridViewComboBoxColumn CanBo = new GridViewComboBoxColumn("IDCanBo");
            CanBo.Name = "CanBo";
            CanBo.DisplayMember = "HoTen";
            CanBo.FieldName = "IDCanBo";
            CanBo.ValueMember = "ID";
            CanBo.HeaderText = "Cán bộ";
            CanBo.Width = 200;
            CanBo.MaxWidth = 200;
            CanBo.MinWidth = 200;
            CanBo.DataSource = canbo;
            CanBo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            radgPhong.Columns.Add(CanBo);

            this.radgPhong.ShowGroupPanel = true;
            this.radgPhong.MasterTemplate.AllowAddNewRow = true;
            this.radgPhong.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            //this.radgPhong.Columns["IDCanBo"].IsVisible = false;
            this.radgPhong.EnableFiltering = true;
            this.radgPhong.Columns.Move(this.radgPhong.Columns["CanBo"].Index, 4);
            #endregion
            try
            {
                radgPhong.DataSource = DanhMuc.LIB.DIC_Phong_Coll.GetDIC_Phong_Coll();
            }

            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DIC_Phong.DeleteDIC_Phong(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void CellFormatting(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radgPhong_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_Phong_Edit))
                {
                    if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                    {
                        formMode.IsEdit = true;
                        formMode.Id = selectedID;
                        PhongInfo fr = new PhongInfo(formMode);
                        fr.ShowDialog();
                        LoadUS();
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        
    }
}
