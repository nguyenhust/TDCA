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
    public partial class GridChinhQuyHocPhi : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public GridChinhQuyHocPhi()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            HideDelete();
            HideSave();
            HideNew();

        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_ChinhQuy_HocPhi;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_ChinhQuy_HocPhi;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocPhi_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocPhi_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_CQ_HocVien_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_CQ_HocPhiChinhQuy fr = new Form_CQ_HocPhiChinhQuy(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                radBindingSource.DataSource = DT_ChinhQuy_HocVien_Coll.GetDT_ChinhQuy_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));

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
                    Form_CQ_HocPhiChinhQuy fr = new Form_CQ_HocPhiChinhQuy(formMode);
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
            cv.E_TieuDe = new List<string>() { "Họ tên","Ngày sinh","Lớp","Tổng tiền đã nộp","Tổng tiền phải nộp" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DT_ChinhQuy_HocVien_Info itemInfo = (DT_ChinhQuy_HocVien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenLop, itemInfo.TongHocPhiDaDong,itemInfo.TongHocPhiPhaiDong };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Tình trạng đóng học phí học viên";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty;
            cv.E_TenTrungTam = "Phòng đào tạo";
            //cv.ProcessTuNgayDenNgay(5); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }


        #endregion
    }
}
