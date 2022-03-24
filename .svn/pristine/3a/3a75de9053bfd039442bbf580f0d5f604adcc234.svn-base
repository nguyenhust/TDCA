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
using ModuleHanhChinh.UI;
using ModuleHanhChinh.LIB;
using Authoration.LIB;
using ExportLib;


namespace ModuleHanhChinh.UserControl
{
    public partial class Grid_HC_CongVanDen : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public Grid_HC_CongVanDen()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            //PrintToShow();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.HC_CongVanDi;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.HC_CongVanDi;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDi_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDi_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDi_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_CongVan_Den fr = new Form_CongVan_Den(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDi_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    radbindingSource.DataSource = HC_CongVanDen_Coll.GetHC_CongVanDen_Coll();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
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
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    HC_CongVanDen.DeleteHC_CongVanDen(selectedID);
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
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_CongVanDi_Edit))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_CongVan_Den fr = new Form_CongVan_Den(formMode);
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
            cv.E_TieuDe = new List<string>() { "Số công văn", "Ngày ban hành", "Về việc", "Gửi tới", "Vị trí lưu" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    HC_CongVanDen_Info itemInfo = (HC_CongVanDen_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.SoCongVan, itemInfo.NgayKi, itemInfo.VeVanDe, itemInfo.NoiGui, itemInfo.LuuTruTai };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "báo cáo công văn đi";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.ProcessTuNgayDenNgay(1); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
        private void PrintToHTML1()
        {
            HC_CongVanDi_Coll listItem = (HC_CongVanDi_Coll)radbindingSource.DataSource;
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B004_BaoCaoCongVanDi cv = new ExportLib.Entities.HanhChinh.B004_BaoCaoCongVanDi();
            cv.ListCongVanDi = new List<ExportLib.Entities.HanhChinh.CongVanDi>();
            DateTime startDate = new DateTime(2050, 1, 1);
            DateTime endDate = new DateTime(1900, 1, 1);
            int count = 0;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    HC_CongVanDi_Info itemInfo = (HC_CongVanDi_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.CongVanDi item = new ExportLib.Entities.HanhChinh.CongVanDi();
                    try
                    {
                        item.NgayNhan = itemInfo.NgayGui;
                    }
                    catch
                    {
                    }
                    item.NoiGui = itemInfo.NoiGui;
                    item.SoCongVan = itemInfo.SoCongVan;
                    item.VeViec = itemInfo.VeVanDe;
                    item.ViTriLuu = itemInfo.LuuTruTai;
                    if (0 == 0)
                    {
                        try
                        {
                            startDate = GlobalCommon.CompareDate_Earlier(Convert.ToDateTime(itemInfo.NgayGui), startDate);
                            endDate = GlobalCommon.CompareDate_Later(Convert.ToDateTime(itemInfo.NgayGui), endDate);
                        }
                        catch
                        {
                        }
                    }

                    cv.ListCongVanDi.Add(item);
                    count++;
                }
            }
            cv.NgayBatDau = GlobalCommon.FixDate_Return(startDate);
            cv.NgayKetThuc = GlobalCommon.FixDate_Return(endDate);
            //cv.TongSoCongVanDen = count.ToString();
            cv.NgayLapBaoCao = GlobalCommon.BC_HaNoiNgayThangNam(DateTime.Now);
            cv.NguoiLapBaoCao = PTIdentity.FullName;
            ex.B004_BaoCaoCongVanDi(cv);
        }
    }
}
