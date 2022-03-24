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


namespace ModuleHanhChinh.UserControl
{
    public partial class Grid_HC_ChamCong : UsDictionary
    {
        #region variables

        private HC_ChamCong_Coll listItem;
        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        private string LastYear = string.Empty;
        private string TenCanBo = string.Empty;
        #endregion

        public Grid_HC_ChamCong()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            
            //STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            HideDelete();
            HideNew();
            //HideSave();
            HideList();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.HC_ChamCong;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.HC_ChamCong;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = true;
            bl_btnPrint = true;
            bl_btnMyClose = true;
            //bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Insert);
            ////Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            //bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Print);
            //bl_btnMyClose = true;
            //bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Del);
        }

        protected override void Save()
        {
            try
            {
                if (listItem != null)
                {
                    listItem.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Edit, "Sửa thông tin chấm công của cán bộ : "  + TenCanBo);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
            //formMode.IsInsert = true;
            //Form_LichLamViec fr = new Form_LichLamViec(formMode);
            //fr.ShowDialog();
            //LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                dropDownCanBo1.DanhMucCotHienThi = new List<string> {  "HoTen", "TenBoPhan" };
                dropDownCanBo1.TenTuongUng = new List<string> {  "Tên", "Phòng" };
                dropDownCanBo1.FillData(1);
                dropDownNam1.FillData();
                //dropDownThang1.FillData();
                DateTime dt = DateTime.Now;
                if (dt.Month != 1)
                {
                    dropDownNam1.Text = dt.Year.ToString();
                    //dropDownThang1.Text = (dt.Month - 1).ToString();
                }
                else
                {
                    dropDownNam1.Text = (dt.Year - 1).ToString();
                    //dropDownThang1.Text = "12";
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            PrintToHTML();
        }

        protected override void Delete()
        {
    //        try
    //        {
    //            if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
    //&& GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Del))
    //            {
    //                HC_LichLamViecTT.DeleteHC_LichLamViecTT(selectedID);
    //            }
    //        }
    //        catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
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
                //if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                //    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.HC_LichLamViec_Edit))
                //{
                //    formMode.Id = selectedID;
                //    formMode.IsEdit = true;
                //    Form_LichLamViec fr = new Form_LichLamViec(formMode);
                //    fr.ShowDialog();
                //    LoadUS();
                //}
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
        private void PrintToHTML()
        {
            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Ngày","Thứ","Giờ vào","Giờ ra","Phân loại","Lý do" };
            cv.E_FilterExpression = this.FilterExpression;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
            {
                if (rowInfo.IsVisible)
                {
                    HC_ChamCong_Info itemInfo = (HC_ChamCong_Info)rowInfo.DataBoundItem;
                    ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                    string PhanLoai = string.Empty;
                    if (Convert.ToBoolean(itemInfo.Muon))
                        PhanLoai = "Đi muộn";
                    else if (Convert.ToBoolean(itemInfo.NghiKhongLyDo))
                        PhanLoai = "Nghỉ không lý do";
                    else if (Convert.ToBoolean(itemInfo.NgayPhep))
                        PhanLoai = "Nghỉ phép";
                    else if (Convert.ToBoolean(itemInfo.DiCongTac))
                        PhanLoai = "Đi công tác";
                    else if (itemInfo.Thu.ToLower() == "bảy" || itemInfo.Thu.ToLower() == "cn")
                        PhanLoai = "Cuối tuần";
                    else
                        PhanLoai = "BT";

                    cvItem.E_Value = new List<string>() { itemInfo.Ngay,itemInfo.Thu,itemInfo.GioVao,itemInfo.GioRa,PhanLoai,itemInfo.LyDo};
                    cv.E_Content.Add(cvItem);
                }
            }



            cv.E_TieuDeBaoCao = string.Format("Bảng chấm công cán bộ: {0}", TenCanBo);
            string ketluan = string.Empty;
            ketluan = string.Format("{0}Tổng số ngày đi muộn : {1} ngày</br>",ketluan, txtNgayDiMuon.Text);
            ketluan = string.Format("{0}Tổng số ngày nghỉ không lý do : {1} ngày</br>", ketluan, txtNghiKhongLyDo.Text);
            ketluan = string.Format("{0}Tổng số ngày nghỉ phép trong thời gian chọn : {1} ngày</br>", ketluan, txtNghiPhepThang.Text);
            cv.E_ThongTinTongHop = ketluan;
            cv.E_IsUseTongSo = false;
            cv.ProcessTuNgayDenNgay(0); // số thứ tự này tính bằng cách đếm mảng E_TieuDe (bắt đầu từ 0) . ở đây 2 = ngày đi
            ex.B100_GenReport(cv, 2);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {

                    BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
                    CanBoChamCong cbcc = new CanBoChamCong();
                    cbcc.IDCanBo = Convert.ToInt64(dropDownCanBo1.Selected_ID);
                    //cbcc.Thang = Convert.ToInt32(dropDownThang1.Text);
                    cbcc.Nam = Convert.ToInt32(dropDownNam1.Text);
                    function.Item = cbcc;
                    listItem = HC_ChamCong_Coll.GetHC_ChamCong_Coll(function);
                    radbindingSource.DataSource = listItem;
                    LastYear = dropDownNam1.Text;
                    CaculateTotal();
                    TenCanBo = dropDownCanBo1.Selected_TextValue.ToString();

                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
            
        }
        private bool ValidateData()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { dropDownCanBo1.Selected_TextValue, dropDownNam1.Text }))
            {
                GlobalCommon.ShowErrorMessager("Bạn phải chọn đủ cả ba thông tin");
                return false;
            }
            return true;
        }
        private void CaculateTotal()
        {
            if (listItem != null)
            {
                
               //int Thang = Convert.ToInt32(dropDownThang1.Text);
                int muon = 0;
                int phepThang = 0;
                int phepNam = 0;
                int khongLyDoThang = 0;
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in RadGrid.ChildRows)
                {
                    HC_ChamCong_Info itemInfo = (HC_ChamCong_Info)rowInfo.DataBoundItem;
                    if (rowInfo.IsVisible)
                    {
                        
                        if (Convert.ToBoolean(itemInfo.Muon))
                            muon++;
                        if (Convert.ToBoolean(itemInfo.NghiKhongLyDo))
                            khongLyDoThang++;
                        if (Convert.ToBoolean(itemInfo.NgayPhep))
                            phepThang++;
                    }
                    if (Convert.ToBoolean(itemInfo.NgayPhep))
                        phepNam++;
                    
                }
                txtNgayDiMuon.Text = muon.ToString();
                txtNghiKhongLyDo.Text = khongLyDoThang.ToString();
                txtNghiPhepNam.Text = phepNam.ToString();
                txtNghiPhepThang.Text = phepThang.ToString();
            }
        }
        private void SetFilterExpression()
        {
            //RadGrid.FilterExpressionChanged += RadGrid_FilterExpressionChanged;
            
        }

        void RadGrid_FilterExpressionChanged(object sender, Telerik.WinControls.UI.FilterExpressionChangedEventArgs e)
        {
            //e.FilterExpression = string.Format("Thang = '{0}'",dropDownThang1.Text);
        }


        
        private void dropDownNam1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
           
        }

        private void radGridView_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
           
        }
        bool phep = false;
        bool congtac = false;
        bool khonglydo = false;
        private void radGridView_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {

                if (e.Row.Cells["NgayPhep"].Value == null)
                    phep = false;
                else
                    bool.TryParse(e.Row.Cells["NgayPhep"].Value.ToString(), out phep);
                if (e.Row.Cells["DiCongTac"].Value == null)
                    phep = false;
                else
                    bool.TryParse(e.Row.Cells["DiCongTac"].Value.ToString(), out congtac);
                if (congtac)
                {
                    e.Row.Cells["DiCongTac"].Value = true;
                }
                else if (phep)
                {
                    e.Row.Cells["NgayPhep"].Value = true;
                }
                else
                {
                    e.Row.Cells["NghiKhongLyDo"].Value = true;
                }

                CaculateTotal();



            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridView_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            try
            {
                if (e.Row.Cells["NgayPhep"].Value == null)
                    phep = false;
                else
                    bool.TryParse(e.Row.Cells["NgayPhep"].Value.ToString(), out phep);
                if (e.Row.Cells["DiCongTac"].Value == null)
                    phep = false;
                else
                    bool.TryParse(e.Row.Cells["DiCongTac"].Value.ToString(), out congtac);
                if (e.Row.Cells["NghiKhongLyDo"].Value == null)
                    phep = false;
                else
                    bool.TryParse(e.Row.Cells["NghiKhongLyDo"].Value.ToString(), out khonglydo);
                if (!khonglydo && !phep && !congtac)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Row.Cells["NgayPhep"].Value = false;
                    e.Row.Cells["DiCongTac"].Value = false;
                    e.Row.Cells["NghiKhongLyDo"].Value = false;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radGridView_FilterChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {
            try
            {
                CaculateTotal();
            }
            catch(Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radGridView_RowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            try
            {
                //if (e.RowElement.RowInfo.DataBoundItem != null)
                //{
                //    HC_ChamCong_Info itemInfo = (HC_ChamCong_Info)e.RowElement.RowInfo.DataBoundItem;
                //    if (itemInfo.Thu.ToLower() == "bay" || itemInfo.Thu.ToLower() == "bảy")
                //    {
                //        e.RowElement.BackColor = Color.Yellow;
                //        e.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                //        e.RowElement.DrawFill = true;
                //    }
                //    if (itemInfo.Thu.ToLower() == "cn" || itemInfo.Thu.ToLower() == "chu nhat" || itemInfo.Thu.ToLower() == "chủ nhật")
                //    {
                //        e.RowElement.BackColor = Color.Pink;
                //        e.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
                //        e.RowElement.DrawFill = true;
                //    }

                //}

                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
