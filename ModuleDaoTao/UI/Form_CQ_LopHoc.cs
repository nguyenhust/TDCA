using NETLINK.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleDaoTao.LIB;
using NETLINK.LIB;
using Authoration.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_CQ_LopHoc : Dictionary
    {

        private DT_ChinhQuy_LopHoc item;
        private DT_ChinhQuy_HocVien_Coll hvxeplop;
        private DT_ChinhQuy_HocVien_Coll daxeplopupdate;
        private string fileUploaded;
        public Form_CQ_LopHoc(FormMode _formMode)
        {
            InitializeComponent();

            this.formMode = _formMode;
            ApplyAuthorizationRules();
            tungay.MyName = "Ngày bắt đầu";
            denngay.MyName = "Ngày kết thúc";
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_AnPham_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.TT_AnPham_Edit });
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave())
                {
                    UploadFile();
                    BindData(false);
                    item.ApplyEdit();
                    item = item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Chính quy - Lớp học - Tên lớp : " + item.TenLop);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    groupBox3.Enabled = true;
                    groupBox2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void FormLoad()
        {
            try
            {
                dropDownChuyenKhoa1.FillData(1);
                dropDownLopHocLienTucKhung1.FillData(1);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = DT_ChinhQuy_LopHoc.GetDT_ChinhQuy_LopHoc(formMode.Id);
                    groupBox3.Enabled = true;
                    groupBox2.Enabled = true;
                }
                else
                {
                    item = DT_ChinhQuy_LopHoc.NewDT_ChinhQuy_LopHoc();
                }
                BindData(true);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void BindData(bool isLoad)
        {
            if (item != null)
            {
                if (isLoad)
                {
                    dropDownChuyenKhoa1.Selected_ID = item.IdChuyenKhoa;
                    dropDownLopHocLienTucKhung1.Selected_ID = item.IdKhungLopHoc;
                    txtKhoaHoc.Text = item.Khoa;
                    txtMaLop.Text = item.MaLop;
                    txtNamHoc.Text = item.NamHoc;
                    tungay.Value_String = item.ThoiGianBatDau;
                    denngay.Value_String = item.ThoiGianKetThuc;
                    txtTienHoc.Text = item.TongTienHoc.ToString();
                    
                }
                else
                {
                    if (dropDownChuyenKhoa1.Selected_ID != null)
                        item.IdChuyenKhoa = Convert.ToInt32(dropDownChuyenKhoa1.Selected_ID);
                    if (dropDownLopHocLienTucKhung1.Selected_ID != null)
                    {
                        item.IdKhungLopHoc = Convert.ToInt32(dropDownLopHocLienTucKhung1.Selected_ID);

                        item.TenLop = dropDownLopHocLienTucKhung1.Selected_TextValue.ToString();
                    }
                    item.Khoa = txtKhoaHoc.Text;
                    item.NamHoc = txtNamHoc.Text;
                    item.MaLop = txtMaLop.Text;
                    item.LastEdited_Date = DateTime.Now;
                    item.LastEdited_User = PTIdentity.IDNguoiDung;
                    item.ThoiGianBatDau = tungay.Value_String;
                    item.ThoiGianKetThuc = denngay.Value_String;
                    if (!string.IsNullOrEmpty(txtTienHoc.Text))
                        item.TongTienHoc = Convert.ToInt32(txtTienHoc.Text);
                }
            }
        }
        private void LoadDaXepLop()
        {

            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
            function.Item = item.ID;
            daxeplopupdate = DT_ChinhQuy_HocVien_Coll.GetDT_ChinhQuy_HocVien_Coll(function);
            gridDaXepLop.DataSource = daxeplopupdate;
        }
        private void LoadChuaxeplop()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition2);
            gridChuaXepLop.DataSource = DT_ChinhQuy_HocVien_Coll.GetDT_ChinhQuy_HocVien_Coll(function);
           
        }
        private void LoadGiangVienMonHoc()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
            function.Item = item.ID;
            gridMonHocGiangVien.DataSource = DT_ChinhQuy_GiangVienMonHoc_Coll.GetDT_ChinhQuy_GiangVienMonHoc_Coll(function);
        }
        private bool ValidateDataBeforeSave()
        {
            if (!tungay.isDateTime && !tungay.isNull)
            {
                GlobalCommon.ShowErrorMessager(tungay.Value_Error);
                return false;
            }
            if (!denngay.isDateTime && !denngay.isNull)
            {
                GlobalCommon.ShowErrorMessager(denngay.Value_Error);
                return false;
            }
            if (!GlobalCommon.CheckIsNumber(txtTienHoc.Text))
            {
                GlobalCommon.ShowErrorMessager("Tiền học phải là một số");
                return false;
            }
            //if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtAnPham.Text, dropDownLoai1.Selected_TextValue, radMaskedEditBox1.Text, tungay.Value_String, denngay.Value_String }))
            //{
            //    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
            //    return false;
            //}
            //if (!GlobalCommon.CheckDateMustBeEarilierOrEqualOther(denngay.Value_String, tungay.Value_String))
            //{
            //    GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, denngay.MyName, tungay.MyName));
            //    return false;
            //}
            return true;
        }

        private void UploadFile()
        {
            try
            {
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            try
            {
                LoadChuaxeplop();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Daxeplop_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDaXepLop();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radCheckBox2_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in gridChuaXepLop.ChildRows)
                {
                    rowInfo.Cells["chon"].Value = radCheckBox2.Checked;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in gridDaXepLop.ChildRows)
                {
                    rowInfo.Cells["chon"].Value = radCheckBox1.Checked;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool chon = false;

                    hvxeplop = DT_ChinhQuy_HocVien_Coll.NewDT_ChinhQuy_HocVien_Coll();
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in gridDaXepLop.ChildRows)
                {
                    if (rowInfo.Cells["chon"].Value != null && bool.TryParse(rowInfo.Cells["chon"].Value.ToString(), out chon) && chon)
                    {
                        DT_ChinhQuy_HocVien_Info itemInfo = (DT_ChinhQuy_HocVien_Info)rowInfo.DataBoundItem;
                        itemInfo.IdLopHoc = 0;
                        hvxeplop.Add(itemInfo);
                        chon = false;
                    }
                }
                if (hvxeplop.Count > 0)
                {

                    hvxeplop.Save();
                    LoadDaXepLop();
                    LoadChuaxeplop();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void xeplop_Click(object sender, EventArgs e)
        {
            try
            {
                bool chon = false;

                    hvxeplop = DT_ChinhQuy_HocVien_Coll.NewDT_ChinhQuy_HocVien_Coll();

                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in gridChuaXepLop.ChildRows)
                {
                    if (rowInfo.Cells["chon"].Value != null && bool.TryParse(rowInfo.Cells["chon"].Value.ToString(), out chon) && chon)
                    {
                        DT_ChinhQuy_HocVien_Info itemInfo = (DT_ChinhQuy_HocVien_Info)rowInfo.DataBoundItem;
                        itemInfo.IdLopHoc = item.ID;
                        hvxeplop.Add(itemInfo);
                        chon = false;
                    }
                }
                if (hvxeplop.Count > 0)
                {
                  
                    hvxeplop.Save();
                    LoadDaXepLop();
                    LoadChuaxeplop();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                FormMode modex = new FormMode();
                modex.Item = item.ID;
                Form_CQ_LopHocMonHocGiangVien fr = new Form_CQ_LopHocMonHocGiangVien(modex);
                fr.ShowDialog();
                LoadGiangVienMonHoc();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridMonHocGiangVien.CurrentRow!= null && gridMonHocGiangVien.CurrentRow.Cells["ID"].Value != null)
                {
                    FormMode modex = new FormMode();
                    modex.IsEdit = true;
                    modex.Item = item.ID;
                    modex.Id = Convert.ToInt32(gridMonHocGiangVien.CurrentRow.Cells["ID"].Value);
                    Form_CQ_LopHocMonHocGiangVien fr = new Form_CQ_LopHocMonHocGiangVien(modex);
                    fr.ShowDialog();
                    LoadGiangVienMonHoc();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridMonHocGiangVien.CurrentRow != null && gridMonHocGiangVien.CurrentRow.Cells["ID"].Value != null && GlobalCommon.AcceptDelete())
                {
                    DT_ChinhQuy_GiangVienMonHoc.DeleteDT_ChinhQuy_GiangVienMonHoc(Convert.ToInt32(gridMonHocGiangVien.CurrentRow.Cells["ID"].Value));
                    LoadGiangVienMonHoc();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void lietke_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGiangVienMonHoc();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void gridMonHocGiangVien_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (gridMonHocGiangVien.CurrentRow != null && gridMonHocGiangVien.CurrentRow.Cells["ID"].Value != null)
                {
                    FormMode modex = new FormMode();
                    modex.IsEdit = true;
                    modex.Item = item.ID;
                    modex.Id = Convert.ToInt32(gridMonHocGiangVien.CurrentRow.Cells["ID"].Value);
                    Form_CQ_LopHocMonHocGiangVien fr = new Form_CQ_LopHocMonHocGiangVien(modex);
                    fr.ShowDialog();
                    LoadGiangVienMonHoc();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void dropDownChuyenKhoa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropDownChuyenKhoa1.Selected_ID != null)
                    dropDownLopHocLienTucKhung1.FilterData(FilterColumn.IDKhoaNgoai64, dropDownChuyenKhoa1.Selected_ID);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void txtTienHoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtLbTienHoc.Text = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(txtTienHoc.Text);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

    
    }
}
