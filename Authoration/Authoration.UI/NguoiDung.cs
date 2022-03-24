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
using Authoration.LIB;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using Csla.Windows;

namespace Authoration.UI
{
    public partial class NguoiDung : Dictionary
    {

        ADM_NguoiDung nguoidung;
        Int64 IDNguoiDungPara;
        ADM_ChucNang_Coll chucnang_coll = ADM_ChucNang_Coll.GetADM_ChucNang_Coll();
        RadGridView dt;
        ADM_NhomNguoiDung_Coll nhomnguoi_coll = ADM_NhomNguoiDung_Coll.GetADM_NhomNguoiDung_Coll();
        RadGridView dtparent;
        ADM_ThanhVien_Coll thanhvien_coll;
        ADM_QuyenNguoiDung_Coll quyennhomnguoidung_coll;
        string id;

        public NguoiDung(Int64 _IDnguoiDung)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            IDNguoiDungPara = _IDnguoiDung;
            RadGrid = radgChucNang;
            STT();
            RadGridChild = radgNhom;
            STTChild();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            dt = new RadGridView();
            dt.DataSource = chucnang_coll;
            dtparent = new RadGridView();
            dtparent.DataSource = nhomnguoi_coll;
            AddComboxToGrid(dt, "TenCN", "IDCN", "IDChucNang", "Combo_ChucNang", "Chức năng", 300,1);
            AddComboxToGridParent(dtparent, "TenNhom", "ID", "IDNhomNguoiDung", "Combo_NhomNguoiDung", "Nhóm người dùng", 400);
            radcombCanBo.Text = "";

            #region tao ra du lieu combox
            // find
            this.radcombCanBo.AutoFilter = true;
            // open with
            this.radcombCanBo.BestFitColumns(true, true);
            // open height
            this.radcombCanBo.AutoSizeDropDownToBestFit = true;
            // display on dropdwownlist
            this.radcombCanBo.DisplayMember = "HoTen";
            // creat gridview show with click dropdownlist
            SetUpGridComb();
            // find by displaymember
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.radcombCanBo.DisplayMember;
            // find type  contains
            filter.Operator = FilterOperator.Contains;
            this.radcombCanBo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            #endregion
        }

        public NguoiDung()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgChucNang;
            STT();
            RadGridChild = radgNhom;
            STTChild();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            dt = new RadGridView();
            dt.DataSource = chucnang_coll;
            dtparent = new RadGridView();
            dtparent.DataSource = nhomnguoi_coll;
            AddComboxToGrid(dt, "TenCN", "IDCN", "IDChucNang", "Combo_ChucNang", "Chức năng", 300,1);
            AddComboxToGridParent(dtparent, "TenNhom", "ID", "IDNhomNguoiDung", "Combo_NhomNguoiDung", "Nhóm người dùng", 400);

            nguoidung = ADM_NguoiDung.NewADM_NguoiDung();
            thanhvien_coll = ADM_ThanhVien_Coll.NewADM_ThanhVien_Coll();
            quyennhomnguoidung_coll = ADM_QuyenNguoiDung_Coll.NewADM_QuyenNguoiDung_Coll();
            bindNguoiDung.DataSource = nguoidung;
            bindChucNang.DataSource = quyennhomnguoidung_coll;
            bindNhom.DataSource = thanhvien_coll;
            radgChucNang.DataSource = quyennhomnguoidung_coll;
            radgNhom.DataSource = thanhvien_coll;

            #region tao ra du lieu combox
            // find
            this.radcombCanBo.AutoFilter = true;
            // open with
            this.radcombCanBo.BestFitColumns(true, true);
            // open height
            this.radcombCanBo.AutoSizeDropDownToBestFit = true;
            // display on dropdwownlist
            this.radcombCanBo.DisplayMember = "HoTen";
            // creat gridview show with click dropdownlist
            SetUpGridComb();
            // find by displaymember
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.radcombCanBo.DisplayMember;
            // find type  contains
            filter.Operator = FilterOperator.Contains;
            this.radcombCanBo.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            #endregion
        }

        #region set combox phân hệ
        private void SetUpGridComb()
        {
            RadGridView gridViewControl = this.radcombCanBo.EditorControl;
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDownWithCondition);
            function.Item = LoaiCanBo.CanBoThuocTrungTamCDT;
            radcombCanBo.EditorControl.DataSource = DanhMuc.LIB.DIC_CanBo_Coll.GetDIC_CanBo_Coll(function);
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            foreach (GridViewColumn cl in gridViewControl.Columns)
            {
                if (cl.Name == "HoTen")
                    cl.HeaderText = "Họ Tên";
                else
                    cl.IsVisible = false;
            }
           // gridViewControl.Columns["ID"].IsVisible = false;
           // //gridViewControl.Columns["IDGioiTinh"].IsVisible = false;
           // gridViewControl.Columns["HoTen"].HeaderText = "Họ Tên";
           // gridViewControl.Columns["NgaySinh"].IsVisible = false;
           // gridViewControl.Columns["IDTinh"].IsVisible = false;
           // gridViewControl.Columns["ChoOHienNay"].IsVisible = false;
           //// gridViewControl.Columns["IDQuocGia"].IsVisible = false;
           // gridViewControl.Columns["NgayVaoDang"].IsVisible = false;
           // gridViewControl.Columns["TrinhDoCM"].IsVisible = false;
           // gridViewControl.Columns["IDCoQuan"].IsVisible = false;
           // gridViewControl.Columns["IDChucVu"].IsVisible = false;
           // gridViewControl.Columns["QTDaoTao"].IsVisible = false;
           // gridViewControl.Columns["QTCongTac"].IsVisible = false;
           // gridViewControl.Columns["KinhNghiemNN"].IsVisible = false;
           // gridViewControl.Columns["NghienCuuTGia"].IsVisible = false;
           // gridViewControl.Columns["NgoaiNguTinHoc"].IsVisible = false;
           // gridViewControl.Columns["KhenThuongKyLuat"].IsVisible = false;
           // gridViewControl.Columns["HTapNCuuNNgoai"].IsVisible = false;
           // gridViewControl.Columns["IDBoPhan"].IsVisible = false;
           // gridViewControl.Columns["TenGioiTinh"].IsVisible = false;
           // gridViewControl.Columns["TenCoQuan"].IsVisible = false;
           // gridViewControl.Columns["TenTinhThanh"].IsVisible = false;
           // gridViewControl.Columns["TenChucVu"].IsVisible = false;
        }
        #endregion

        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("NguoiDung:I")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"
                || Csla.ApplicationContext.User.IsInRole("NguoiDung:U"));
            //this.btnDelete.Enabled = (Csla.ApplicationContext.User.IsInRole("NguoiDung:D")
            //    || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            this.btnClose.Enabled = true;
        }

        protected override void Save()
        {
            try
            {
                if (radcombCanBo.Text.Trim() == "")
                {
                   string id =null;
                   nguoidung.IDCanBo = 0;
                    
                }
                nguoidung.QuyenNguoiDungColl = quyennhomnguoidung_coll;
                nguoidung.ThanhVienColl = thanhvien_coll;
                nguoidung.ApplyEdit();
                nguoidung.Save();
                GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Other, "Form Người dùng");
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                this.Close();
            }
            catch(Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void FormLoad()
        {
            try
            {
                if (IDNguoiDungPara != 0)
                {
                    
                    nguoidung = ADM_NguoiDung.GetADM_NguoiDung(IDNguoiDungPara);
                    if (nguoidung.IDCanBo == 0)
                        radcombCanBo.Text = "";
                    bindNguoiDung.DataSource = nguoidung;
                    quyennhomnguoidung_coll = nguoidung.QuyenNguoiDungColl;
                    bindChucNang.DataSource = quyennhomnguoidung_coll;
                    thanhvien_coll = nguoidung.ThanhVienColl;
                    bindNhom.DataSource = thanhvien_coll;
                    
                }
                else
                    radcombCanBo.Text = "";
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        private void CellFormattingNhom(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void CellFormattingChucNang(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void NguoiDung_Activated(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nguoidung.IDNguoiDung > 0)
            {
                if (GlobalCommon.AcceptDelete())
                {
                    ADM_NguoiDung.DeleteADM_NguoiDung(nguoidung.IDNguoiDung);
                    this.Close();
                }
            }
            else
                GlobalCommon.ShowError("Người dùng không tồn tại để xóa", "Dữ liệu lỗi");
        }
    }
}
