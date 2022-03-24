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
using ExportLib;
using Authoration.LIB;

namespace ModuleDaoTao.UserControls
{
    public partial class GridLopHoc : UsDictionary
    {
        #region variables

        private int selectedID = -1;
        private int _theolop = 99;
        #endregion
        public GridLopHoc()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            mode = new FormMode();
            mode.IsInsert = true;
            //LoadUS();
            ShowPrint2 = true;
            TextPrint2 = "In Thông tin lớp";
            TextPrint = "In Danh sách lớp";
            raddropDNam.FillData();
            raddropDNam.Text = GlobalCommon.GetTimeServer().Year.ToString();
            
            raddropDownBoPhan.Visible = false;
            radLabel2.Visible = false;
        }
        public GridLopHoc( int theolop)
        {
            InitializeComponent();
            RadGrid = radGridView1;
            this._theolop = theolop;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            mode = new FormMode();
            mode.IsInsert = true;
            //LoadUS();
            ShowPrint2 = true;
            TextPrint2 = "In Thông tin lớp";
            TextPrint = "In Danh sách lớp";
            raddropDNam.FillData();
            raddropDNam.Text = GlobalCommon.GetTimeServer().Year.ToString();
            
            raddropDownBoPhan.Visible = false;
        }

        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_LopHoc;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_LopHoc;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_HocVien_Delete);
        }

        protected override void Save()
        {
            
            try
            {
                Form_LT_LopHoc fr = new Form_LT_LopHoc(mode);
                fr.ShowDialog();
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
                DT_LienTuc_LopHoc_Coll ListLopHoc = DT_LienTuc_LopHoc_Coll.GetDT_LienTuc_LopHoc_CollNamAndPhong(int.Parse(raddropDNam.Text == "Tất cả"? "0": raddropDNam.Text));
                bindingSourceLophoc.DataSource = ListLopHoc;
                TotalRecordValue = ListLopHoc.Count.ToString();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Print2()
        {
            try
            {

                if (radGridView1.CurrentRow.DataBoundItem != null)
                {
                    FormMode _mode = new FormMode();
                    _mode.Item = radGridView1.CurrentRow.DataBoundItem;
                    Form_LT_LopHoc_Print fr = new Form_LT_LopHoc_Print(_mode);
                    fr.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Print()
        {
            //DT_LienTuc_LopHoc_Coll lstLopHoc = (DT_LienTuc_LopHoc_Coll)bindingSourceLophoc.DataSource;
            //foreach (DT_LienTuc_LopHoc_Info lophoc in lstLopHoc) {
            //    if (lophoc.Checked)
            //        DT_Common.InBangDiemDanh(lophoc);
            //}
            //LoadUS();
            try
            {
                PrintToHTML();
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
                if (radGridView1.CurrentRow.Cells["MaLop"].Value != null)
                {
                    string malop = radGridView1.CurrentRow.Cells["MaLop"].Value.ToString();
                    BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllData);
                    function.Item = malop;
                    if (DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVienByMaLopHoc_Coll_Count(function) <= 0 && GlobalCommon.AcceptDelete())
                    {
                        DT_LienTuc_LopHoc.DeleteDT_LienTuc_LopHoc(malop);
                        //DT_ChinhQuy_MonHoc.DeleteDT_ChinhQuy_MonHoc(selectedID);
                        LoadUS();
                    }
                    else
                    {
                        GlobalCommon.ShowErrorMessager("Bạn không thể xóa lớp khi lớp đang có chứa học viên");
                    }
                }
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

        #endregion

        private void radGridView1_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
           
        }
        private void PrintToHTML()
        {

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Tên Lớp", "Khóa", "Đối tượng", "Ngày bắt đầu", "Ngày kết thúc" };
            cv.E_FilterExpression = this.FilterExpression;

            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_LienTuc_LopHoc_Info itemInfo = (DT_LienTuc_LopHoc_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.TenLop, itemInfo.KhoaHoc, itemInfo.DoiTuong, itemInfo.NgayBatDau, itemInfo.NgayKetThuc };
                    cv.E_Content.Add(cvItem);

                }
            }
            cv.E_TieuDeBaoCao = "Danh sách Lớp học";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = "Trung tâm TDC";
            cv.ProcessTuNgayDenNgay(3); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (radGridView1.CurrentRow.Cells["MaLop"].Value != null)
            {
                string MaLop = radGridView1.CurrentRow.Cells["MaLop"].Value.ToString();
                FormMode _mode = new FormMode();
                _mode.IsEdit = true;
                _mode.StringId = MaLop;
                Form_LT_LopHoc fr = new Form_LT_LopHoc(_mode);
                fr.ShowDialog();
                LoadUS();
            }
        }

        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void raddropDNam_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            LoadUS();
            
            
        }
    }
}
