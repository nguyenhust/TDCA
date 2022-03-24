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
    public partial class GridChinhQuyLopHoc : UsDictionary
    {
         #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridChinhQuyLopHoc()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
          
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_ChinhQuy_LopHoc;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_ChinhQuy_LopHoc;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_DSLop_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_DSLop_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_DSLop_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_CQ_LopHoc fr = new Form_CQ_LopHoc(formMode);
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
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DT_ChinhQuy_LopHoc.DeleteDT_ChinhQuy_LopHoc(selectedID);
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Chính Quy - Lớp hoc |" + this.ToString());
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
                if (int.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_CQ_LopHoc fr = new Form_CQ_LopHoc(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #region HTML generator

        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Tên Lớp", "Khóa", "Năm", "Ngày bắt đầu", "Ngày kết thúc" };
            cv.E_FilterExpression = this.FilterExpression;

            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_ChinhQuy_LopHoc_Info itemInfo = (DT_ChinhQuy_LopHoc_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.TenLop, itemInfo.Khoa, itemInfo.NamHoc, itemInfo.ThoiGianBatDau, itemInfo.ThoiGianKetThuc };
                    cv.E_Content.Add(cvItem);

                }
            }
            cv.E_TieuDeBaoCao = "Danh sách Lớp học";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TenTrungTam = "Trung tâm TDC";
            cv.ProcessTuNgayDenNgay(3); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }


        #endregion
    }
}
