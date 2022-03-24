using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using TruyenThong.LIB;
using NETLINK.LIB;
using ExportLib;
using ExportLib.Entities;
using Authoration.LIB;

namespace TruyenThong.UserControl
{
    public partial class BaiViet : UsDictionary
    {
        Int64 _ID = 0;
        Int64 IDBaiViet;
        TT_BaiViet_Coll ttbvcoll;

        public BaiViet()
        {
            InitializeComponent();
            RadGrid = radgBaiViet;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            SaveToNew();
            ShowPrint2 = true;
            TextPrint2 = "In Thống kê";
            //PrintToShow();
        }

        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.TT_BaiViet;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.TT_BaiViet;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("BaiViet:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("BaiViet:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
            bl_btnDelete = (Csla.ApplicationContext.User.IsInRole("BaiViet:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }

        protected override void Save()
        {
            try
            {
                UI.BaiViet frm = new UI.BaiViet(new FormMode());
                frm.ShowDialog();
                LoadUS();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void LoadUS()
        {
            try
            {
                bindBaiViet.DataSource = TT_BaiViet_Coll.GetTT_BaiViet_Coll();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                PrintToHTML();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void Print2()
        {
            try
            {
                FormMode fm = new FormMode();
                fm.FormID = GetIdValue().ToString();
                fm.Item = RadGrid;
                TruyenThong.UI.ThongKe tk = new UI.ThongKe(fm);
                tk.ShowDialog();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void MyClose()
        {
            base.MyClose();
        }

        protected override void Delete()
        {
            try
            {
                radgBaiViet.DataSource = bindBaiViet;
                //ttbvcoll = (TT_BaiViet_Coll)radgBaiViet.DataSource;
                if (radgBaiViet.CurrentRow.Cells["ID"].Value != null)
                    IDBaiViet = Convert.ToInt64(radgBaiViet.CurrentRow.Cells["ID"].Value);
                if (GlobalCommon.AcceptDelete())
                {
                    TT_BaiViet.DeleteTT_BaiViet(IDBaiViet);
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Truyền Thông |" + this.ToString());
                    LoadUS();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        #endregion

        private void CellDoubleClick_SuKien(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radgBaiViet.CurrentRow.Cells["ID"].Value != null)
                    _ID = Convert.ToInt64(radgBaiViet.CurrentRow.Cells["ID"].Value);
                FormMode mode = new FormMode();
                mode.IsEdit = true;
                mode.Id64 = _ID;
                UI.BaiViet frm = new UI.BaiViet(mode);
                frm.ShowDialog();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        #region HTML generator

        private void PrintToHTML()
        {
           
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Tiêu đề", "Nội dung", "Loại", "Tác giả", "Ngày đăng", "Ngày duyệt", "Người duyệt" };
            cv.E_Width = new List<string>() {"70","400","100","80","80","80","80","" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    TT_BaiViet_Info itemInfo = (TT_BaiViet_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.TieuDe, itemInfo.NoiDung, itemInfo.Loai, itemInfo.TacGia, itemInfo.ThoiGianDang, itemInfo.ThoiGianDuyet, itemInfo.NguoiDuyet };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "báo cáo bài viết";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.IsNamDoc = false;
            cv.E_TuDinhDangWidth = false;
            cv.ProcessTuNgayDenNgay(4); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }

        #endregion
    }
}
