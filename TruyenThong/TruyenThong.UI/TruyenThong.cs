using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using NETLINK.UI;
using TruyenThong.LIB;
using DanhMuc.LIB;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;

namespace TruyenThong.UI
{
    public partial class DoanPhongVien : NETLINK.UI.ParentChild
    {
        DIC_CoQuan_Coll coquan_coll = DIC_CoQuan_Coll.GetDIC_CoQuan_Coll();
        TT_PhongVanCT_Coll phongvanct_coll;
        TT_PhongVan_Coll phongvan_coll;
        TT_PhongVan phongvan;
        DIC_ChucVu_Coll chucvu_coll = DIC_ChucVu_Coll.GetDIC_ChucVu_Coll();
        RadGridView datacomb;

        public DoanPhongVien()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgNhanVat;
            RadGridChild = radgDoanPhongVien;
            STT();
            STTChild();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            datacomb = new RadGridView();
            datacomb.DataSource = chucvu_coll;
            AddComboxToGrid(datacomb, "Ten", "ID", "IDChucVu", "Combo_ChucVu", "Chức vụ", 300,3);

            #region tao ra du lieu combox co quan
            // find
            this.radcombCoQuan.AutoFilter = true;
            // open with
            this.radcombCoQuan.BestFitColumns(true, true);
            // open height
            this.radcombCoQuan.AutoSizeDropDownToBestFit = true;
            // display on dropdwownlist
            this.radcombCoQuan.DisplayMember = "Ten";
            // creat gridview show with click dropdownlist
            SetUpGridComb();
            // find by displaymember
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.radcombCoQuan.DisplayMember;
            // find type  contains
            filter.Operator = FilterOperator.Contains;
            this.radcombCoQuan.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            #endregion

            #region tao ra du lieu combox khoa
            // find
            this.radcombKhoa.AutoFilter = true;
            // open with
            this.radcombKhoa.BestFitColumns(true, true);
            // open height
            this.radcombKhoa.AutoSizeDropDownToBestFit = true;
            // display on dropdwownlist
            this.radcombKhoa.DisplayMember = "TenKhoa";
            // creat gridview show with click dropdownlist
            SetUpGridCombKhoa();
            // find by displaymember
            FilterDescriptor filter1 = new FilterDescriptor();
            filter1.PropertyName = this.radcombKhoa.DisplayMember;
            // find type  contains
            filter1.Operator = FilterOperator.Contains;
            this.radcombKhoa.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);
            #endregion
        }

        #region set combox phân hệ
        private void SetUpGridComb()
        {
            RadGridView gridViewControl = this.radcombCoQuan.EditorControl;
            radcombCoQuan.EditorControl.DataSource = DIC_CoQuan_Coll.GetDIC_CoQuan_Coll();
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridViewControl.Columns["ID"].IsVisible = false;
            gridViewControl.Columns["Ten"].HeaderText = "Cơ quan";
            gridViewControl.Columns["DiaChi"].IsVisible = false;
            gridViewControl.Columns["SuDung"].IsVisible = false;
            gridViewControl.Columns["GhiChu"].IsVisible = false;
        }

        private void SetUpGridCombKhoa()
        {
            RadGridView gridViewControl = this.radcombKhoa.EditorControl;
            radcombKhoa.EditorControl.DataSource = DIC_VienKhoaPhong_Coll.GetDIC_VienKhoaPhong_Coll();
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridViewControl.Columns["IDKhoa"].IsVisible = false;
            gridViewControl.Columns["TenKhoa"].HeaderText = "Khoa Phòng";
            gridViewControl.Columns["MaKhoa"].IsVisible = false;
            gridViewControl.Columns["MaNhanDang"].IsVisible = false;
            gridViewControl.Columns["YTaTruong"].IsVisible = false;
            gridViewControl.Columns["TruongKhoa"].IsVisible = false;
            gridViewControl.Columns["TenTat"].IsVisible = false;
            gridViewControl.Columns["SuDung"].IsVisible = false;
        }
        #endregion

        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("PhongVan:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"
            || Csla.ApplicationContext.User.IsInRole("PhongVan:U"));
            this.btnNew.Enabled = (Csla.ApplicationContext.User.IsInRole("PhongVan:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            this.btnDelete.Enabled = (Csla.ApplicationContext.User.IsInRole("PhongVan:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }

        protected override void Save()
        {
            try
            {
                phongvan.PhongVanCTColl = phongvanct_coll;
                phongvan.ApplyEdit();
                phongvan.Save();
                this.bindPhongVanColl.DataSource = TT_PhongVan_Coll.GetTT_PhongVan_Coll();
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Cancel()
        {
            base.Cancel();
        }

        protected override void Delete()
        {
            try
            {
                if (GlobalCommon.AcceptDelete())
                {
                    TT_PhongVan.DeleteTT_PhongVan(phongvan.ID);
                    this.bindPhongVanColl.DataSource = TT_PhongVan_Coll.GetTT_PhongVan_Coll();
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void New()
        {
            try
            {
                btnSave.Enabled = true;
                phongvan = TT_PhongVan.NewTT_PhongVan();
                radcombKhoa.Text = "Chọn khoa...";
                radcombCoQuan.Text = "Chọn cơ quan...";
                phongvan.KhoaLamViec = Convert.ToInt64(radcombKhoa.SelectedValue);
                phongvan.IDCoQuanCT = Convert.ToInt32(radcombCoQuan.SelectedValue);
                phongvanct_coll = TT_PhongVanCT_Coll.NewTT_PhongVanCT_Coll();
                this.bindPhongVan.DataSource = phongvan;
                this.bindPhongVanCTColl.DataSource = phongvanct_coll;
                radgNhanVat.DataSource = phongvanct_coll;
            }
            catch (Exception ex)
            {
                btnSave.Enabled = false;
                GlobalCommon.ShowErrorMessager(ex);
            } 
        }
        
        protected override void FormLoad()
        {
            try
            {
                bindPhongVanColl.DataSource = TT_PhongVan_Coll.GetTT_PhongVan_Coll();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }            
        }

        #endregion

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void CellFormattingChild(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radgDoanPhongVien.CurrentRow.Cells["ID"].Value != null)
                {
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                    phongvanct_coll = TT_PhongVan.GetTT_PhongVan(Convert.ToInt32(radgDoanPhongVien.CurrentRow.Cells["ID"].Value)).PhongVanCTColl;
                    this.radgNhanVat.DataSource = phongvanct_coll;
                    phongvan = TT_PhongVan.GetTT_PhongVan(Convert.ToInt32(radgDoanPhongVien.CurrentRow.Cells["ID"].Value));
                    this.bindPhongVan.DataSource = phongvan;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
