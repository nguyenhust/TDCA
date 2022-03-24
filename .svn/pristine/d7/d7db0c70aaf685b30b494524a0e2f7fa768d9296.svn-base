using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;
using TruyenThong.LIB;
using NETLINK.UI;
using ExportLib;
using ExportLib.Entities;
using Authoration.LIB;

namespace TruyenThong.UserControl
{
    public partial class SuKien : NETLINK.UI.UsDictionary
    {
        Int64 _ID = 0;
        Int64 IDSuKien;
        TT_SuKien_Coll ttskcoll;

        public SuKien()
        {
            InitializeComponent();
            RadGrid = radgSuKien;
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
            return TextMessages.ControlID.TT_SuKien;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.TT_SuKien;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("SuKien:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("SuKien:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
            bl_btnDelete = (Csla.ApplicationContext.User.IsInRole("SuKien:D")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }

        protected override void Save()
        {
            try
            {
                UI.SuKien frm = new UI.SuKien(new FormMode());
                frm.ShowDialog();
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
                bindSuKien.DataSource = TT_SuKien_Coll.GetTT_SuKien_Coll();
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
                radgSuKien.DataSource = bindSuKien;
                if (radgSuKien.CurrentRow.Cells["ID"].Value != null)
                    IDSuKien = Convert.ToInt64(radgSuKien.CurrentRow.Cells["ID"].Value);
                if (GlobalCommon.AcceptDelete())
                {
                    TT_SuKien.DeleteTT_SuKien(IDSuKien);
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
                if (radgSuKien.CurrentRow.Cells["ID"].Value != null)
                    _ID = Convert.ToInt64(radgSuKien.CurrentRow.Cells["ID"].Value);
                FormMode mode = new FormMode();
                mode.IsEdit = true;
                mode.Id64 = _ID;
                UI.SuKien frm = new UI.SuKien(mode);
                frm.ShowDialog();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void PrintToHTML()
        {
            TT_SuKien_Coll listItem = (TT_SuKien_Coll)bindSuKien.DataSource;
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Sự kiện", "Chuyên Ngành", "Loại", "Địa điểm", "Thời gian", "Chủ trì" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    TT_SuKien_Info itemInfo = (TT_SuKien_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.Ten, itemInfo.TenChuyenNganh, itemInfo.Loai, itemInfo.DiaDiem, itemInfo.ThoiGian, itemInfo.ChuTri };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "báo cáo sự kiện";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.ProcessTuNgayDenNgay(4); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
