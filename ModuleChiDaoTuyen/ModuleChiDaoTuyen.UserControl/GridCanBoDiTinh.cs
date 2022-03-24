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
using Authoration.LIB;
using ExportLib;
using ModuleChiDaoTuyen.UI;

namespace ModuleChiDaoTuyen.UserControl
{
    public partial class GridCanBoDiTinh : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridCanBoDiTinh()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
            ShowPrint2 = true;
            TextPrint2 = "In danh sách";
           // PrintToShow();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.CDT_CanBoDiTinh;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.CDT_CanBoDiTinh;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_CanBoDiTinh_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_CanBoDiTinh_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_CanBoDiTinh_Delete);
        }

        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                Form_CanBoDiTinh fr = new Form_CanBoDiTinh(formMode);
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
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.CDT_HopDongKyThuat_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    radbindingSource.DataSource = CDT_CanBoDiTinh_Coll.GetCDT_CanBoDiTinh_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
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
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    CDT_CanBoDiTinh.DeleteCDT_CanBoDiTinh(selectedID);
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "CDT- Cán bộ đi tỉnh | ID" + selectedID.ToString());
                    LoadUS();
                }
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
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.CDT_HopDongKyThuat_View,TextMessages.RolePermission.CDT_CanBoDiTinh_Edit}))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_CanBoDiTinh fr = new Form_CanBoDiTinh(formMode);
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
            cv.E_TieuDe = new List<string>() {"Họ tên","Trình độ","Chức vụ","Khoa công tác","Bệnh viện nơi đến","Nội dung hoạt động","Từ ngày","Đến ngày","Nguồn kinh phí" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    CDT_CanBoDiTinh_Info itemInfo = (CDT_CanBoDiTinh_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() {itemInfo.HoTen,itemInfo.TenTrinhDo,itemInfo.TenChucVu,itemInfo.TenChuyenKhoa,itemInfo.TenBenhVien,itemInfo.NoiDungHoatDong,itemInfo.NgayBatDau,itemInfo.NgayKetThuc,itemInfo.TenNguonKinhPhi};
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách cán bộ tham gia công tác tuyến";
            cv.E_TenTrungTam = "Phòng Chỉ đạo tuyến";
            cv.E_TenBenhVien = "Trung tâm đào tạo và chỉ đạo tuyến";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            cv.IsNamDoc = false;
            
            //cv.ProcessTuNgayDenNgay(2); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        private void radbindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void radGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
