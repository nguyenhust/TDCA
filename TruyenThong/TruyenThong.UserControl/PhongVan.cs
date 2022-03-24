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
using TruyenThong.UI;
using ExportLib;
using ExportLib.Entities;
using Authoration.LIB;

namespace TruyenThong.UserControl
{
    public partial class PhongVan : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private long selectedID = -1;
        #endregion

        public PhongVan()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            RadGrid.CellDoubleClick += radGridView_CellDoubleClick;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();

            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            ShowPrint2 = true;
            TextPrint2 = "In Thống kê";
          
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.TT_PhongVan;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.TT_PhongVan;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_PhongVan_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_PhongVan_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.TT_PhongVan_Del);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            TruyenThong.UI.PhongVan fr = new TruyenThong.UI.PhongVan(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {

                bindPhongVan.DataSource = TT_PhongVan_Coll.GetTT_PhongVan_Coll();

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
        protected override void Delete()
        {
            try
            {
                if (long.TryParse(RadGrid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    TT_PhongVan.DeleteTT_PhongVan(selectedID);
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
                    TruyenThong.UI.PhongVan fr = new TruyenThong.UI.PhongVan(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void PrintToHTML()
        {
            TT_PhongVan_Coll listItem = (TT_PhongVan_Coll)bindPhongVan.DataSource;
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() {"Thời gian","Tên phóng viên","Tên đơn vị báo đài","Nội dung lấy tin","Người / đơn vị tiếp","Ghi chú"};
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    TT_PhongVan_Info itemInfo = (TT_PhongVan_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.ThoiGian, itemInfo.TenPhongVien, itemInfo.TenCoQuan, itemInfo.NoiDung, itemInfo.NguoiTiep, itemInfo.Ghichu };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách các đoàn phóng viên";
            cv.E_TenTrungTam = "Phòng Đào tạo kỹ năng và Truyền thông";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.ProcessTuNgayDenNgay(0); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
