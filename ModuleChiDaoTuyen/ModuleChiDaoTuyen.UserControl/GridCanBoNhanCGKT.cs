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
    public partial class GridCanBoNhanCGKT : UsDictionary
    {
           #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridCanBoNhanCGKT()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            HideDelete();
            HideSave();
            HideNew();
            PrintToShow();
            ShowPrint2 = true;
            TextPrint2 = "In danh sách";
           // PrintToShow();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.CDT_CanBoNhanChuyenGiaoKT;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.CDT_CanBoNhanChuyenGiaoKT;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_Delete);
        }

        protected override void Save()
        {
           
        }

        protected override void LoadUS()
        {
            try
            {
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    radbindingSource.DataSource = CDT_CanBoNhanCGKT_Coll.GetCDT_CanBoNhanCGKT_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

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
        protected override void Print2()
        {
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
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.CDT_HopDongKyThuat_View,TextMessages.RolePermission.CDT_HopDongKyThuat_Edit}))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    ModuleChiDaoTuyen.UI.CanBoNhanCGKT fr = new CanBoNhanCGKT(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
     
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Mã hợp đồng","Gói kỹ thuật","Họ tên","Ngày sinh","Chuyên ngành","Trình độ","Điểm trước CG","Điểm sau CG","Số lần thực hành","Kết luận" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    CDT_CanBoNhanCGKT_Info itemInfo = (CDT_CanBoNhanCGKT_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.TenMaHopDong,itemInfo.TenGoiKyThuat, itemInfo.HoTen,itemInfo.Ngaysinh, itemInfo.TenChuyenNganh, itemInfo.TenTrinhDo, itemInfo.DiemTruocCG.ToString(), itemInfo.DiemSauCG.ToString(), itemInfo.SoLanThucHanhKT.ToString(), itemInfo.KetLuan };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách cán bộ nhận CGKT";
            cv.E_TenTrungTam = "Phòng Chỉ đạo tuyến";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(2); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void radGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
