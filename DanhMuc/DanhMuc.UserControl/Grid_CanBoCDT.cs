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
using DanhMuc.LIB;
using DanhMuc.UI;
using ExportLib;


namespace DanhMuc.UserControl
{
    public partial class Grid_DM_CanBoCDT : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public Grid_DM_CanBoCDT()
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
            return TextMessages.ControlID.DM_CanBoCDT;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DM_CanBoCDT;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoCDT_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoCDT_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoCDT_Del);
        }

        protected override void Save()
        {
            try
            {
                DIC_CanBo_Coll itemlist = (DIC_CanBo_Coll)radbindingSource.DataSource;
                if (itemlist == null || itemlist.Count <= 0)
                {
                    formMode.StringId = "01";
                }
                else
                {
                    int max = 1;
                    int temp = 0;
                    foreach (DIC_CanBo_Info cbinfo in itemlist)
                    {
                        if (int.TryParse(cbinfo.MaNhanVien.Replace("TDC", string.Empty), out temp))
                        {
                            if (max < temp)
                            {
                                max = temp;
                            }
                        }
                        
                    }
                    max++;
                    if (max >= 100)
                    {
                        formMode.StringId = max.ToString();
                    }
                    else if (max >= 10)
                    {
                        formMode.StringId = string.Format("0{0}", max.ToString());
                    }
                    else
                    {
                        formMode.StringId = string.Format("00{0}", max.ToString());
                    }
                }
                formMode.IsInsert = true;
                Form_CanBoCDT fr = new Form_CanBoCDT(formMode);
                fr.ShowDialog();
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
                radbindingSource.DataSource = DIC_CanBo_Coll.GetDIC_CanBo_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition,LoaiCanBo.CanBoThuocTrungTamCDT));
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
                    DIC_CanBo.DeleteDIC_CanBo(selectedID);
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
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoCDT_Edit))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_CanBoCDT fr = new Form_CanBoCDT(formMode);
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
            cv.E_TieuDe = new List<string>() { "Họ tên cán bộ", "Giới tính", "Ngày sinh", "Địa chỉ", "Tỉnh thành", "Dân tộc", "Số điện thoại", "Email", "Quốc tịch", "Phòng ban", "Trình độ", "Chức vụ", "Số CMT", "Ngày cấp", "Nơi cấp", "Ngày vào đảng", "Quá trình đào tạo", "Quá trình công tác", "Trình độ ngoại ngữ - tin học", "Nghiên cứu", "Khen thưởng kỷ luật", "Kinh nghiệm", "Ghi chú" };
            cv.E_FilterExpression = this.FilterExpression;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    DIC_CanBo_Info itemInfo = (DIC_CanBo_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.GioiTinh, itemInfo.NgaySinh, string.Empty, itemInfo.TenTinh, itemInfo.DanToc, itemInfo.DienThoai, itemInfo.Email, itemInfo.QuocGia, itemInfo.TenBoPhan, itemInfo.TenTrinhDo, itemInfo.TenChucVu, itemInfo.SoCMT, itemInfo.NgayCap, itemInfo.NoiCap, itemInfo.NgayVaoDang, itemInfo.QTDaoTao, itemInfo.QTCongTac, itemInfo.NgoaiNguTinHoc, itemInfo.NghienCuuTGia, itemInfo.KhenThuongKyLuat, itemInfo.KinhNghiemNN, itemInfo.GhiChu };
                    cv.E_Content.Add(cvItem);
                }
            }
            cv.E_TieuDeBaoCao = "Danh sách cán bộ trung tâm TDC";
            cv.E_PaperWidth = "500mm";
            //cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_TuNgayDenNgay = string.Empty; // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv);
        }
    }
}
