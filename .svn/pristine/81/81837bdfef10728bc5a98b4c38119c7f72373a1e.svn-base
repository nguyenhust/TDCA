using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using NETLINK.LIB;
using NETLINK.UI;
using DanhMuc.LIB;
using ExportLib;

namespace DanhMuc.UserControl
{
    public partial class BenhVien : NETLINK.UI.UsDictionary
    {
        
         #region variables

        private FormMode formMode = new FormMode();
        private long selectedID = -1;
        #endregion

        public BenhVien()
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
            return TextMessages.ControlID.DM_BenhVien;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DM_BenhVien;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_BenhVien_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_BenhVien_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_BenhVien_Del);
        }

        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                BenhVienInfo fr = new BenhVienInfo(formMode);
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
                    radbindingSource.DataSource = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();
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
                if (long.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DIC_BenhVien.DeleteDIC_BenhVien(selectedID);
                    GlobalCommon.Log.WriteLog(0, "Không bắt được tên người dùng", FormAction.Delete, "CDT - Bệnh viện | ID" + selectedID.ToString());
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
                if (long.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[]{TextMessages.RolePermission.CDT_HopDongKyThuat_View,TextMessages.RolePermission.CDT_CanBoDiTinh_Edit}))
                {
                    formMode.Id64 = selectedID;
                    formMode.IsEdit = true;
                    BenhVienInfo fr = new BenhVienInfo(formMode);
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
            cv.E_TieuDe = new List<string>() { "Tên bệnh viện","Quy mô", "Địa chỉ","Điện thoại/Fax","Ban Giám đốc","P. Kế hoạch Tổng hợp","P. Chỉ đạo tuyến" };
            
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DIC_BenhVien_Info itemInfo = (DIC_BenhVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    string Hang = string.Format("Hạng: {0}</br>Phòng/Ban: {1}</br>Giường KH: {2}</br>Giường TK: {3}</br>Khoa LS: {4}</br>Khoa CLS: {5}", itemInfo.Hang, itemInfo.Phong,itemInfo.GiuongKH,itemInfo.GiuongTK,itemInfo.KhoaLS,itemInfo.KhoaCLS);
                    string GDTen = string.Format("<b>GD. {0}</b></br>{1}</br>{2}", itemInfo.GDTen, itemInfo.GDDT, itemInfo.GDEmail);
                    string PGD1Ten = string.Format("<b>PGD. {0}</b></br>{1}</br>{2}", itemInfo.PGD1Ten, itemInfo.PGD1DT, itemInfo.PGD1Email);
                    string PGD2Ten = string.Format("<b>PGD. {0}</b></br>{1}</br>{2}", itemInfo.PGD2Ten, itemInfo.PGD2DT, itemInfo.PGD2Email);
                    string TPKHTHTen = string.Format("<b>TP. {0}</b></br>{1}</br>{2}", itemInfo.TPKHTHTen, itemInfo.TPKHTHDT, itemInfo.TPKHTHEmail);
                    string PPKH1Ten = string.Format("<b>PP. {0}</b></br>{1}</br>{2}", itemInfo.PPKH1Ten, itemInfo.PPKH1DT, itemInfo.PPKH1Email);
                    string PPKH2Ten = string.Format("<b>PP. {0}</b></br>{1}</br>{2}", itemInfo.PPKH2Ten, itemInfo.PPKH2DT, itemInfo.PPKH2Email);
                    string TPCDTTen = string.Format("<b>TP. {0}</b></br>{1}</br>{2}", itemInfo.TPCDTTen, itemInfo.TPCDTDT, itemInfo.TPCDTEmail);
                    string PPCDT1Ten = string.Format("<b>PP. {0}</b></br>{1}</br>{2}", itemInfo.PPCDT1Ten, itemInfo.PPCDT1DT, itemInfo.PPCDT1Email);
                    string PPCDT2Ten = string.Format("<b>PP. {0}</b></br>{1}</br>{2}", itemInfo.PPCDT2Ten, itemInfo.PPCDT2DT, itemInfo.PPCDT2Email);
                    string DienThoai = string.Format("DT: {0}</br>Fax: {1}",itemInfo.DienThoai,itemInfo.Fax);
                    GDTen = string.Format("{0}</br>{1}</br>{2}", GDTen, PGD1Ten, PGD2Ten);
                    TPCDTTen = string.Format("{0}</br>{1}</br>{2}", TPCDTTen, PPCDT1Ten, PPCDT2Ten);
                    TPKHTHTen = string.Format("{0}</br>{1}</br>{2}", TPKHTHTen, PPKH1Ten, PPKH2Ten);
                    cvItem.E_Value = new List<string>() { itemInfo.Ten, Hang, itemInfo.DiaChi, DienThoai,GDTen,TPKHTHTen,TPCDTTen};
                                                         
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách các bệnh viện thuộc địa bàn chỉ đạo tuyến";
            cv.E_TenTrungTam = "Phòng Chỉ đạo tuyến";
            cv.E_TenBenhVien = "Trung tâm đào tạo và chỉ đạo tuyến";
            cv.IsNamDoc = false;
            //cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            //cv.ProcessTuNgayDenNgay(2); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
