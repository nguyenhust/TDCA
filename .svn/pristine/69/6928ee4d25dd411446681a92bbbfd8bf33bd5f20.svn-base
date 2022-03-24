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
using ModuleChiDaoTuyen.LIB;
using ModuleChiDaoTuyen.UI;
using ExportLib;
using Authoration.LIB;

namespace ModuleChiDaoTuyen.UserControl
{
    public partial class GridHoiThaoTrucTuyen : UsDictionary
    {
        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        public GridHoiThaoTrucTuyen()
        {
            InitializeComponent();
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid = radGridView;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
            ShowPrint2 = true;
            TextPrint2 = "In danh sách";
        }

        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.CDT_HoiChuanTrucTuyen;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.CDT_HoiChuanTrucTuyen;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HoiChuan_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HoiChuan_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HoiChuan_Delete);
        }

        protected override void Save()
        {

            formMode.IsInsert = true;
            HoiChuanTrucTuyen hoichuan = new HoiChuanTrucTuyen(formMode);
            hoichuan.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radbindingSource.DataSource = CDT_HoiChuan_Coll.GetCDT_HoiChuan_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridView));
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                LoadUS();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void Print2()
        {
            try
            {
                PrintToHTML();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    if (GlobalCommon.AcceptDelete())
                    {
                        CDT_HoiChuan.DeleteCDT_HoiChuan(selectedID);
                        LoadUS();
                    }
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            base.MyClose();
        }

        #endregion

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    HoiChuanTrucTuyen hoichuan = new HoiChuanTrucTuyen(formMode);
                    hoichuan.ShowDialog();
                    LoadUS();
                }


            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Ngày","Nội dung","Loại","Chủ trì BM","Số bệnh viện","Số người","Số báo cáo" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    CDT_HoiChuan_Info itemInfo = (CDT_HoiChuan_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() {itemInfo.NgayDienRa,itemInfo.NoiDung,itemInfo.LoaiHC,itemInfo.ChuTriBM,itemInfo.SoLuongBenhVien.ToString(),itemInfo.SoLuongThanhVien.ToString(),itemInfo.SoLuongBaoCao.ToString() };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách hội chẩn";

            cv.E_TenTrungTam = "Phòng Chỉ đạo tuyến";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(2); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
