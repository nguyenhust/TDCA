using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleDaoTao.LIB;
using Authoration.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_CQ_DiemThiTheoLop : NETLINK.UI.Dictionary
    {
        private DT_ChinhQuy_LopHoc_Info item;
        private DT_ChinhQuy_DiemThi_Coll listDiemThi;
        DT_ChinhQuy_HocVien_Coll listHocVien;
        private string fileUploaded;
        public Form_CQ_DiemThiTheoLop(FormMode _formMode)
        {
            InitializeComponent();

            this.formMode = _formMode;
            //tungay.MyName = "Từ ngày";
            //denngay.MyName = "Đến ngày";
            ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_CQ_QuanLyDiem_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.DT_CQ_QuanLyDiem_Edit });
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave())
                {
                    UploadFile();
                    BindData(false);
                    if (listDiemThi != null && listDiemThi.Count > 0)
                    {
                        listDiemThi.Save();
                    }
                    //if (listHocVien != null)
                    //{
                    //    listHocVien.Save();
                    //}
                    //item.ApplyEdit();
                    //item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Chính quy - Điểm thi Theo Lop:"+item.TenLop + " Khoa "+item.Khoa);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    this.Close();
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
                dropDownMonHocChinhQuy1.FillData(1);
                if (formMode.Id > 0)
                {
                    item = (DT_ChinhQuy_LopHoc_Info)formMode.ItemInfo;
                    BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
                    function.ItemID = item.ID;
                    listDiemThi = DT_ChinhQuy_DiemThi_Coll.GetDT_ChinhQuy_DiemThi_Coll(function);
            
                    
                    //function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition2);
                    //function.ItemID = Convert.ToInt32(item.IdLopHoc);
                    //listMonHocTheoLop = DT_ChinhQuy_GiangVienMonHoc_Coll.GetDT_ChinhQuy_GiangVienMonHoc_Coll(function);
                    //bool isExist = false;
                    //foreach (DT_ChinhQuy_GiangVienMonHoc_Info itemInfo in listMonHocTheoLop)
                    //{
                    //    foreach (DT_ChinhQuy_DiemThi_Info itemInfox in listDiemThi)
                    //    {
                    //        if (itemInfo.IdMonHoc == itemInfox.IdMonHoc)
                    //        {
                    //            isExist = true;
                    //            break;
                    //        }
                    //    }
                    //    if (!isExist)
                    //    {
                    //        DT_ChinhQuy_DiemThi_Info itemInfoDiem = listDiemThi.AddNew();
                    //        itemInfoDiem.IdMonHoc = itemInfo.IdMonHoc;
                    //        itemInfoDiem.IdHocVien = formMode.Id;
                    //        itemInfoDiem.TenMonHoc = itemInfo.TenMonHoc;
                    //    }
                    //    isExist = false;
                    //}

                    radGridView1.DataSource = listDiemThi;
                }
                else
                {
                    this.Close();
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

            if (isLoad)
            {
                {
                    txtKhoa.Text = item.Khoa;
                    txtTenLop.Text = item.TenLop;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            //if (!tungay.isDateTime && !tungay.isNull)
            //{
            //    GlobalCommon.ShowErrorMessager(tungay.Value_Error);
            //    return false;
            //}
            //if (!denngay.isDateTime && !denngay.isNull)
            //{
            //    GlobalCommon.ShowErrorMessager(denngay.Value_Error);
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
            //if (!string.IsNullOrEmpty(radBrowseEditor1.Value) && radBrowseEditor1.Value != item.LinkFile)
            //{
            //    FtpUltilies ftp = new FtpUltilies();
            //    ftp.UploadLargeFile(radBrowseEditor1.Value, true, out fileUploaded);
            //}
        }
        private void BindDataHocVien()
        {
            
        }
        private void taids_Click(object sender, EventArgs e)
        {
            try
            {
                int soHT;
                if (int.TryParse(radTextBox1.Text, out soHT) && soHT > 0)
                {
                    if (dropDownMonHocChinhQuy1.Selected_ID != null)
                    {
                        BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition2);
                        function.ItemID = item.ID;
                        function.Item = dropDownMonHocChinhQuy1.Selected_ID;
                        listDiemThi = DT_ChinhQuy_DiemThi_Coll.GetDT_ChinhQuy_DiemThi_Coll(function);
                        function.Item = item.ID;
                        function.Mode = BusinessFunctionMode.GetAllDataWithCondition;
                        listHocVien = DT_ChinhQuy_HocVien_Coll.GetDT_ChinhQuy_HocVien_Coll(function);
                       
                        if (listDiemThi.Count <= 0)
                        {
                            foreach (DT_ChinhQuy_HocVien_Info itemInfo in listHocVien)
                            {
                                DT_ChinhQuy_DiemThi_Info itemInfox = listDiemThi.AddNew();
                                itemInfox.IdHocVien = itemInfo.Id;
                                itemInfox.IdMonHoc = Convert.ToInt32(dropDownMonHocChinhQuy1.Selected_ID);
                                itemInfox.TenHocVien = itemInfo.HoTen;
                                itemInfox.NgaySinh = itemInfo.NgaySinh;
                                itemInfox.SoCMT = itemInfo.SoCMT;
                                itemInfox.Backup01 = radTextBox1.Text;
                               
                            }
                        }
                        else
                        {
                            bool isExist = false;
                            foreach (DT_ChinhQuy_HocVien_Info itemInfo in listHocVien)
                            {
                                foreach (DT_ChinhQuy_DiemThi_Info itemInfox in listDiemThi)
                                {
                                    if (itemInfo.Id == itemInfox.IdHocVien)
                                    {
                                        isExist = true;
                                        break;
                                    }
                                }
                                if (!isExist)
                                {
                                    DT_ChinhQuy_DiemThi_Info itemInfox = listDiemThi.AddNew();
                                    itemInfox.IdHocVien = itemInfo.Id;
                                    itemInfox.IdMonHoc = Convert.ToInt32(dropDownMonHocChinhQuy1.Selected_ID);
                                    itemInfox.TenHocVien = itemInfo.HoTen;
                                    itemInfox.NgaySinh = itemInfo.NgaySinh;
                                    itemInfox.SoCMT = itemInfo.SoCMT;
                                    itemInfox.Backup01 = radTextBox1.Text;
                                }
                                isExist = false;
                            }
                        }
                        radGridView1.DataSource = listDiemThi;
                    }
                }
                else
                {
                    GlobalCommon.ShowErrorMessager("Bạn phải nhập số đơn vị học trình");
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void luulai_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void dropDownMonHocChinhQuy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                radGridView1.DataSource = DT_ChinhQuy_DiemThi_Coll.NewDT_ChinhQuy_DiemThi_Coll();
                if (dropDownMonHocChinhQuy1.Selected_Item != null)
                {
                    radTextBox1.Text = ((DT_ChinhQuy_MonHoc_Info)dropDownMonHocChinhQuy1.Selected_Item).SoHocTrinh.ToString();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radLabel3_Click(object sender, EventArgs e)
        {

        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            DT_ChinhQuy_DiemThi_Info itemX = (DT_ChinhQuy_DiemThi_Info)radGridView1.CurrentRow.DataBoundItem;
            int sohoctrinh = 0;
            if (!string.IsNullOrEmpty(itemX.Backup01))
                sohoctrinh = Convert.ToInt32(itemX.Backup01);
            else
                sohoctrinh = 1;
            double template = 0;
            int soHT = 0;
            if (listHocVien != null)
            {
                foreach (DT_ChinhQuy_HocVien_Info itemInfo in listHocVien)
                {
                    if (itemInfo.Id == itemX.IdHocVien)
                    {
                        if (itemInfo.Backup03 != null && !string.IsNullOrEmpty(itemInfo.Backup03))
                        {
                            template = Convert.ToDouble(itemInfo.Backup03);
                            soHT = Convert.ToInt32(itemInfo.Backup05);
                            template = (template * soHT + itemX.DiemTrungBinh * sohoctrinh) / (sohoctrinh + soHT);
                            itemInfo.Backup03 = template.ToString();
                            itemInfo.Backup05 = sohoctrinh + soHT;
                        }
                        else
                        {
                            itemInfo.Backup03 = itemX.DiemTrungBinh.ToString();
                            itemInfo.Backup05 = sohoctrinh;
                        }
                        break;
                    }
                }
            }
        }

        private void radBThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
