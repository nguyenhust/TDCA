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
    public partial class Form_CQ_DiemThi: NETLINK.UI.Dictionary
    {
        private DT_ChinhQuy_HocVien item;
        private DT_ChinhQuy_DiemThi_Coll listDiemThi;
        private DT_ChinhQuy_GiangVienMonHoc_Coll listMonHocTheoLop;
        private string fileUploaded;
        private int TongSoHocTrinhstr = 0;
        private string TongDiemstr = string.Empty;
        public Form_CQ_DiemThi(FormMode _formMode)
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
                    item.ApplyEdit();
                    item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Chính quy - Điểm thi học viên cmt:" + item.SoCMT);
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
                if (formMode.Id >0)
                {
                    item = DT_ChinhQuy_HocVien.GetDT_ChinhQuy_HocVien(formMode.Id);
                    if (item.IdLopHoc > 0)
                    {
                        BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
                        function.ItemID = item.Id;
                        listDiemThi = DT_ChinhQuy_DiemThi_Coll.GetDT_ChinhQuy_DiemThi_Coll(function);
                        CaculateXepLoai();

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
        private void CaculateXepLoai()
        {
            try
            {
                double tongDiem = 0;
                double tongdiemtotnghiep = 0;
                int sohoctrinh = 0;
                int tongsohoctrinh = 0;
                foreach (DT_ChinhQuy_DiemThi_Info diemInfo in listDiemThi)
                {
                    if (!string.IsNullOrEmpty(diemInfo.Backup01))
                        sohoctrinh = Convert.ToInt32(diemInfo.Backup01);
                    else
                        sohoctrinh = 1;
                    tongsohoctrinh += sohoctrinh;
                    tongDiem += diemInfo.DiemTrungBinh * sohoctrinh;
                }
                tongDiem = tongDiem / tongsohoctrinh;
                TongDiemstr = tongDiem.ToString();
                TongSoHocTrinhstr = tongsohoctrinh;
                BindData(false);
                if (item.TotNghiepLT > 0)
                {
                    tongdiemtotnghiep += Convert.ToDouble(item.TotNghiepLT);
                }
                if (item.TotNghiepTH > 0)
                {
                    tongdiemtotnghiep += Convert.ToDouble(item.TotNghiepTH);
                }
                if (item.BaoVeLuanVan > 0 && item.CapDoDuTuyen != DT_Common.CQ_LoaiDT_CKI)
                {
                    tongdiemtotnghiep += Convert.ToDouble(item.BaoVeLuanVan);
                }
                if (item.CapDoDuTuyen == DT_Common.CQ_LoaiDT_CKI)
                {
                    tongdiemtotnghiep = tongdiemtotnghiep / 2;
                }
                else
                {
                    tongdiemtotnghiep = tongdiemtotnghiep / 3;
                }
                tongDiem = (tongDiem + tongdiemtotnghiep) / 2;
                
                txtlbDiem.Text = tongDiem.ToString();
                
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
                    txtKhoa.Text = item.TenKhoaHoc;
                    txtLop.Text = item.TenLop;
                    txtTen.Text = item.HoTen;
                    netLink_DatePicker1.Value_String = item.NgaySinh;
                    if (item.CapDoDuTuyen == DT_Common.CQ_LoaiDT_CKI)
                    {
                        txtLV.Enabled = true;
                    }
                    else
                    {
                        txtLV.Enabled = false;
                    }
                }
                else
                {
                    if(!string.IsNullOrEmpty(txtLT.Text))
                    item.TotNghiepLT = Convert.ToDouble(txtLT.Text);
                    if (!string.IsNullOrEmpty(txtTH.Text))
                    item.TotNghiepTH = Convert.ToDouble(txtTH.Text);
                    if (!string.IsNullOrEmpty(txtLV.Text))
                    item.BaoVeLuanVan = Convert.ToDouble(txtLV.Text);
                    item.Backup03 = TongDiemstr;
                    item.Backup05 = TongSoHocTrinhstr;
                   // item.LastEdited_Date = DateTime.Now;
                   // item.LastEdited_User = PTIdentity.IDNguoiDung;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!GlobalCommon.CheckIsDiem(new string[]{txtLV.Text, txtLT.Text, txtTH.Text}))
            {
                GlobalCommon.ShowErrorMessager("Định dạng điểm không đúng");
                return false;
            }
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

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                //{
                //    FtpUltilies ftp = new FtpUltilies();
                //    ftp.SaveDownloadedFile(item.LinkFile);
                //}
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (ValidateDataBeforeSave())
                CaculateXepLoai();
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }

        private void radGridView1_Leave(object sender, EventArgs e)
        {
            if (ValidateDataBeforeSave())
                CaculateXepLoai();
        }

        private void txtTH_TextChanged(object sender, EventArgs e)
        {
            if (ValidateDataBeforeSave())
                CaculateXepLoai();
        }

        private void txtLV_TextChanged(object sender, EventArgs e)
        {
            if (ValidateDataBeforeSave())
                CaculateXepLoai();
        }


    }
}
