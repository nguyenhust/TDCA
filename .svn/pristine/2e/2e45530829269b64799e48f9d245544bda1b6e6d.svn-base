using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI;
using NETLINK.LIB;
using Authoration.LIB;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace Authoration.UI
{
    public partial class NhomChucNang : NETLINK.UI.ParentChild
    {
        ADM_NhomChucNang nhomchucnang;
        ADM_ChucNang_Coll chucnang_Coll;
        ADM_PhanHe_Coll phanhe_coll = ADM_PhanHe_Coll.GetADM_PhanHe_Coll();

        public NhomChucNang()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgChucNang;
            STT();
            RadGridChild = radgNhomChucNang;
            STTChild();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            bindPhanHe.DataSource = phanhe_coll;

            #region tao ra du lieu combox
            // find
            this.radmccPhanHe.AutoFilter = true;
            // open with
            this.radmccPhanHe.BestFitColumns(true, true);
            // open height
            this.radmccPhanHe.AutoSizeDropDownToBestFit = true;
            // display on dropdwownlist
            this.radmccPhanHe.DisplayMember = "TenPhanHe";
            // creat gridview show with click dropdownlist
            SetUpGridComb();
            // find by displaymember
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.radmccPhanHe.DisplayMember;
            // find type  contains
            filter.Operator = FilterOperator.Contains;
            this.radmccPhanHe.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            #endregion
        }
        public NhomChucNang(Int64 _ID)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgChucNang;
            STT();
            RadGridChild = radgNhomChucNang;
            STTChild();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            bindPhanHe.DataSource = phanhe_coll;

            #region tao ra du lieu combox
            // find
            this.radmccPhanHe.AutoFilter = true;
            // open with
            this.radmccPhanHe.BestFitColumns(true, true);
            // open height
            this.radmccPhanHe.AutoSizeDropDownToBestFit = true;
            // display on dropdwownlist
            this.radmccPhanHe.DisplayMember = "TenPhanHe";
            // creat gridview show with click dropdownlist
            SetUpGridComb();
            // find by displaymember
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.radmccPhanHe.DisplayMember;
            // find type  contains
            filter.Operator = FilterOperator.Contains;
            this.radmccPhanHe.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            #endregion
        }
        #region set combox phân hệ
        private void SetUpGridComb()
        {
            RadGridView gridViewControl = this.radmccPhanHe.EditorControl;
            radmccPhanHe.EditorControl.DataSource = ADM_PhanHe_Coll.GetADM_PhanHe_Coll();
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridViewControl.Columns["ID"].IsVisible = false;
            gridViewControl.Columns["Ma"].IsVisible = false;
            gridViewControl.Columns["TenPhanHe"].HeaderText = "Phân hệ";
            gridViewControl.Columns["MoTa"].IsVisible = false;
        }
        #endregion
       
        #region Override

        protected override void ApplyAuthorizationRules()
        {
            //this.btnNew.Enabled = (Csla.ApplicationContext.User.IsInRole("NhomChucNang:I")
            //|| Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            this.btnDelete.Enabled = (Csla.ApplicationContext.User.IsInRole("NhomChucNang:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("NhomChucNang:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"
            || Csla.ApplicationContext.User.IsInRole("NhomChucNang:U"));
        }

        protected override void New()
        {
            try
            {
                nhomchucnang = ADM_NhomChucNang.NewADM_NhomChucNang();
                nhomchucnang.IDPhanHe = Convert.ToInt32(radmccPhanHe.SelectedValue);
                chucnang_Coll = ADM_ChucNang_Coll.NewADM_ChucNang_Coll();
                this.bindNhomChucNang.DataSource = nhomchucnang;
                this.bindChucNang.DataSource = chucnang_Coll;
                radgChucNang.DataSource = chucnang_Coll;
            }
            catch (Exception ex)
            {
                btnSave.Enabled = false;
                GlobalCommon.ShowErrorMessager(ex);
            } 
        }

        protected override void Save()
        {
            try
            {
                nhomchucnang.IDNhomCN = chucnang_Coll;
                nhomchucnang.ApplyEdit();
                nhomchucnang.Save();
                GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Other, "Form Nhóm chức năng");
                this.bindNhomChucNangList.DataSource = ADM_NhomChucNang_Coll.GetADM_NhomChucNang_Coll();
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
                ADM_NhomChucNang.DeleteADM_NhomChucNang(nhomchucnang.ID);
                this.bindNhomChucNangList.DataSource = ADM_NhomChucNang_Coll.GetADM_NhomChucNang_Coll();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Cancel()
        {
            this.Close();
        }

        protected override void FormLoad()
        {
            bindNhomChucNangList.DataSource = ADM_NhomChucNang_Coll.GetADM_NhomChucNang_Coll();
        }

        #endregion

        private void CellClick_radgNhomChucNang(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radgNhomChucNang.CurrentRow.Cells["ID"].Value != null)
                {
                    chucnang_Coll = ADM_NhomChucNang.GetADM_NhomChucNang(Convert.ToInt32(radgNhomChucNang.CurrentRow.Cells["ID"].Value)).IDNhomCN;
                    this.radgChucNang.DataSource = chucnang_Coll;
                    nhomchucnang = ADM_NhomChucNang.GetADM_NhomChucNang(Convert.ToInt32(radgNhomChucNang.CurrentRow.Cells["ID"].Value));
                    this.bindNhomChucNang.DataSource = nhomchucnang;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void CellFormattingParent(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void CellFormattingChild(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
    }
}
