using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using ModuleDaoTao.LIB;
using ModuleDaoTao.UI;
using NETLINK.LIB;
using ExportLib;
using ExportLib.Entities;
using Authoration.LIB;

namespace ModuleDaoTao.UserControls
{
    public partial class GridChinhQuyNhapDiemLopHoc : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridChinhQuyNhapDiemLopHoc()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            HideDelete();
            HideNew();
            HideSave();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_ChinhQuy_DiemThiTheoLop;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_ChinhQuy_DiemThiTheoLop;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_QuanLyDiem_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_QuanLyDiem_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_QuanLyDiem_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_CQ_DiemThiTheoLop fr = new Form_CQ_DiemThiTheoLop(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radBindingSource.DataSource = DT_ChinhQuy_LopHoc_Coll.GetDT_ChinhQuy_LopHoc_Coll();

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
                //if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                //{
                //    DT_ChinhQuy_LopHoc.DeleteDT_ChinhQuy_LopHoc(selectedID);
                //    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Chính Quy - Nhập điểm |" + this.ToString());
                //    LoadUS();
                //}
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
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    formMode.ItemInfo = RadGrid.CurrentRow.DataBoundItem;
                    Form_CQ_DiemThiTheoLop fr = new Form_CQ_DiemThiTheoLop(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #region HTML generator

        private void PrintToHTML()
        {
            //TT_AnPham_Coll listItem = (TT_AnPham_Coll)bindAnPham.DataSource;
            //ExportHanhChinh ex = new ExportHanhChinh();
            //ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            //cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            //cv.E_TieuDe = new List<string>() { "Ấn Phẩm", "Đơn Vị Đặt", "Loại", "Nội dung", "Số lượng", "Từ ngày", "Đến ngày" };
            //foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            //{
            //    if (rowInfo.IsVisible)
            //    {
            //        TT_AnPham_Info itemInfo = (TT_AnPham_Info)rowInfo.DataBoundItem;
            //        ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
            //        cvItem.E_Value = new List<string>() { itemInfo.Ten, itemInfo.DonViDat, itemInfo.Loai, itemInfo.NoiDung, itemInfo.SoLuong.ToString(), itemInfo.TuNgay, itemInfo.DenNgay };
            //        cv.E_Content.Add(cvItem);
            //    }
            //}
            //cv.E_TieuDeBaoCao = "báo cáo ấn phẩm";
            //cv.E_NguoiKi = PTIdentity.FullName;
            //cv.ProcessTuNgayDenNgay(5); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            //ex.B100_GenReport(cv);
        }


        #endregion

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }
    }
}
