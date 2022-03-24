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
using ExportLib;
using ExportLib.Entities;
using DanhMuc.LIB;

namespace DanhMuc.UserControl
{
    public partial class AdminTracker : UsDictionary
    {
        #region variables

        #endregion

        public AdminTracker()
        {
            InitializeComponent();
            RadGrid = radGridView2;
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
            return TextMessages.ControlID.DM_AdminTracker;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DM_AdminTracker;
        }

        protected override void ApplyAuthorizationRules()
        {

            bl_btnPrint = true;
            bl_btnMyClose = true;
          
        }

        protected override void Save()
        {

        }

        protected override void LoadUS()
        {
            try
            {
                bindingSource1.DataSource = ADM_AdminTracker_Coll.GetADM_AdminTracker_Coll();

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
                
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        #region HTML generator

        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Phòng","Tên","Hành động","Thời gian","nội dung","Ghi chú" };
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    ADM_AdminTracker_Info itemInfo = (ADM_AdminTracker_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.TenBoPhan,itemInfo.FullName,itemInfo.JobType,itemInfo.Ngay.ToString(),itemInfo.NoiDung,itemInfo.GhiChu };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Lưu vết phần mềm";
           // cv.E_NguoiKi = PTIdentity.FullName;
            cv.ProcessTuNgayDenNgay(5); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }


        #endregion
    }
}
