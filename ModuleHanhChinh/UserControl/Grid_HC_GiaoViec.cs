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
using Csla;
using Telerik.WinControls.UI;
using System.Web.UI.WebControls;
using Telerik.WinControls;

namespace ModuleHanhChinh.UserControl
{
    public partial class Grid_HC_GiaoViec : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public Grid_HC_GiaoViec()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            this.radGridView.EnableAlternatingRowColor = true;
            SaveToNew();
            ShowPrint2 = true;
            TextPrint2 = "Chuyển vào lịch làm việc";
            
            //PrintToShow();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.HC_PhieuGiaoViec;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.HC_PhieuGiaoViec;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_PhieuGiaoViec_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_PhieuGiaoViec_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_PhieuGiaoViec_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_PhieuGiaoViec fr = new Form_PhieuGiaoViec(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                formMode.FormID = this.GetIdValue().ToString();
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_PhieuGiaoViec_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    radbindingSource.DataSource = HC_PhieuGiaoViec_Coll.GetHC_PhieuGiaoViec_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition,PTIdentity.IDNguoiDung));
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            PrintToHTML();
        }
        protected override void Print2()
        {
            try
            {
                HC_LichLamViecTT_Coll listLichLV = HC_LichLamViecTT_Coll.NewHC_LichLamViecTT_Coll();
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                {
                    if (rowInfo.Cells["LichLamViec"].Value != null && (bool)rowInfo.Cells["LichLamViec"].Value)
                    {
                        HC_PhieuGiaoViec_Info itemInfo = (HC_PhieuGiaoViec_Info)rowInfo.DataBoundItem;
                        HC_LichLamViecTT_Info itemLLV = listLichLV.AddNew();
                        itemLLV.TenCanBoThucHien = itemInfo.ListHoTenCanBoDuocGiao;

                       // itemLLV.
                        itemLLV.LastEdited_Date = DateTime.Now;
                        itemLLV.LastEdited_UserID = PTIdentity.IDNguoiDung;
                        itemLLV.NgayBatDau = itemInfo.BatDauTuNgay;
                        itemLLV.NgayKetThuc = itemInfo.PhaiXongNgay;
                        itemLLV.NoiDungThucHien = itemInfo.NoiDungCongViec;
                        itemLLV.GhiChu = itemInfo.GhiChu;
                        itemLLV.Backup01 = itemInfo.ListIDCanBoDuocGiao;
                        if (!string.IsNullOrEmpty(itemInfo.Backup01))
                            itemLLV.IdBoPhan = Convert.ToInt32(itemInfo.Backup01);
                    }
                }
                //HC_PhieuGiaoViec_Coll listPhieuGiaoViec = HC_PhieuGiaoViec_Coll.NewHC_PhieuGiaoViec_Coll();
               
                //SortedBindingList<HC_PhieuGiaoViec_Info> sortListPGV = new SortedBindingList<HC_PhieuGiaoViec_Info>(listPhieuGiaoViec);
                //sortListPGV.ApplySort("IdBoPhanCanBoDuocGiao", ListSortDirection.Ascending);
                ////sortListPGV.GroupBy(
                //foreach (HC_PhieuGiaoViec_Info itemInfo in sortListPGV)
                //{
                //    HC_LichLamViecTT_Info itemLLVInfo = listLichLV.AddNew();
                //    itemLLVInfo.IdBoPhan = itemInfo.IdBoPhanCanBoDuocGiao;
                //    itemLLVInfo.NoiDungThucHien = itemInfo.NoiDungCongViec;
                //    itemLLVInfo.NgayBatDau = itemInfo.BatDauTuNgay.ToShortDateString();
                //    itemLLVInfo.NgayKetThuc = itemInfo.NgayPhaiXong;
                //    itemLLVInfo.GhiChu = itemInfo.GhiChu;
                //    itemLLVInfo.TenCanBoThucHien = itemInfo.TenCanBoDuocGiao;
                //}
                if (listLichLV.Count >= 0)
                  listLichLV.Save();
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
            }
            catch (Exception ex)
            {
            }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    HC_PhieuGiaoViec.DeleteHC_PhieuGiaoViec(selectedID);
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
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_PhieuGiaoViec_Edit))
                {
                    HC_PhieuGiaoViec_Info phieugiaoviec = (HC_PhieuGiaoViec_Info)radGridView.CurrentRow.DataBoundItem;
                    formMode.Item = phieugiaoviec.CongViecCuaToi;
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_PhieuGiaoViec fr = new Form_PhieuGiaoViec(formMode);
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
            cv.E_TieuDe = new List<string>() {"Nội dung", "Từ ngày","Đến ngày","Trạng thái","Lý do"};
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    HC_PhieuGiaoViec_Info itemInfo = (HC_PhieuGiaoViec_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.NoiDungCongViec, itemInfo.BatDauTuNgay, itemInfo.PhaiXongNgay, itemInfo.TrangThai, itemInfo.LyDo };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "báo cáo công việc cá nhân";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_isCenter = false;
            cv.IsNamDoc = false;
            cv.ProcessTuNgayDenNgay(1); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }


        private void radGridView_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            if ((bool)e.RowElement.RowInfo.Cells["TrangThai"].Value.ToString().Equals("Chưa bắt đầu"))
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.Yellow;
            }
            else if((bool)e.RowElement.RowInfo.Cells["TrangThai"].Value.ToString().Equals("Đang tiến hành"))
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.Green;
            }
            else if ((bool)e.RowElement.RowInfo.Cells["TrangThai"].Value.ToString().Equals("Xong"))
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.WhiteSmoke;
            }
            else if ((bool)e.RowElement.RowInfo.Cells["TrangThai"].Value.ToString().Equals("Hủy"))
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.Red;
            }
            else if ((bool)e.RowElement.RowInfo.Cells["TrangThai"].Value.ToString().Equals("Tạm dừng"))
            {
                e.RowElement.DrawFill = true;
                e.RowElement.GradientStyle = GradientStyles.Solid;
                e.RowElement.BackColor = Color.DarkRed;
            }
            else
            {
                e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
                e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);
            }
        }
    }
}
