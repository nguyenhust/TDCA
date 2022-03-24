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
using TruyenThong.LIB;
using DanhMuc.LIB;
using ExportLib;
using ExportLib.Entities;
using Authoration.LIB;

namespace TruyenThong.UserControl
{
    public partial class DKThietKe : UsDictionary
    {
         #region variables

        private FormMode formMode = new FormMode();
        private long selectedID = -1;
        #endregion

        public DKThietKe()
        {
            InitializeComponent();
            RadGrid = radgDKThietKe;
            RadGrid.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
          
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.TT_DangKiThietKe;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.TT_DangKiThietKe;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_PhieuDangKyThietKe_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(new []{TextMessages.RolePermission.TT_PhieuDangKyThietKe_Print,TextMessages.RolePermission.TT_DuyetPhieuDangKyThietKe_Print});
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_PhieuDangKyThietKe_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            TruyenThong.UI.DKThietKe fr = new TruyenThong.UI.DKThietKe(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                bindDKThietKe.DataSource = TT_PhieuDangKyThietKe_Coll.GetTT_PhieuDangKyThietKe_Coll();

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
                if (long.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    TT_PhieuDangKyThietKe.DeleteTT_PhieuDangKyThietKe(selectedID);
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Truyền Thông |" + this.ToString());
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
                if (long.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    formMode.Id64 = selectedID;
                    formMode.IsEdit = true;
                    TruyenThong.UI.DKThietKe fr = new TruyenThong.UI.DKThietKe(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
        #region HTML generator

        private void PrintToHTML()
        {
            TT_PhieuDangKyThietKe_Coll listItem = (TT_PhieuDangKyThietKe_Coll)bindDKThietKe.DataSource;
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Nội dung", "Loại", "Họ tên", "Từ ngày", "Đến ngày", "SL Yêu cầu", "SL Duyệt","Tình Trạng" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    TT_PhieuDangKyThietKe_Info itemInfo = (TT_PhieuDangKyThietKe_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.NoiDung, itemInfo.TenLoai, itemInfo.TenCBDangKy, itemInfo.TuNgay, itemInfo.DenNgay, itemInfo.SLYeuCau.ToString(), itemInfo.SLDuyet.ToString(), itemInfo.TinhTrang };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "báo cáo phiếu đăng ký thiết kế";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.ProcessTuNgayDenNgay(3); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }


        #endregion
    }
}
