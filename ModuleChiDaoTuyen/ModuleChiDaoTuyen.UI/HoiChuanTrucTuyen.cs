using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using DanhMuc.LIB;
using ModuleChiDaoTuyen.LIB;
using NETLINK.UI;
using ExportLib;
using Authoration.LIB;

namespace ModuleChiDaoTuyen.UI
{
    public partial class HoiChuanTrucTuyen : Dictionary
    {

        private CDT_HoiChuan item;
        private CDT_HoiChuan_BVThamGia_Coll listBenhVien;
        private string fileUploaded;
        private int TongBaoCao = 0;
        private int TongBenhVien = 0;
        private int TongThamGia = 0;
        public HoiChuanTrucTuyen(FormMode _formMode)
        {
            InitializeComponent();
            this.formMode = _formMode;
            ngaydienra.MyName = "Ngày diễn ra";
            ApplyAuthorizationRules();
        }
        protected override void ApplyAuthorizationRules()
        {
            if (formMode.IsInsert)
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.CDT_HoiChuan_Insert });
            else
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.CDT_HoiChuan_Edit });
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave() && UploadFile())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item = item.Save();
                    BindDataForList();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "CDT_Hoi CHuan" + this.Text);
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
                dropDownBenhVien.FillData(1);
                dropDownChucVuChuTri.FillData(1);
                dropDownChucVuThuKy.FillData(2);
                dropDownChucVuThuKy2.FillData(3);
                dropDownChuyenKhoaChuTri.FillData(1);
                dropDownChuyenKhoaThuKy.FillData(2);
                dropDownChuyenKhoaThuKy2.FillData(3);
                dropDownTrangThaiCNTT1.FillData();
                dropDownLoaiHC1.FillData();
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = CDT_HoiChuan.GetCDT_HoiChuan(formMode.Id);
                    listBenhVien = CDT_HoiChuan_BVThamGia_Coll.GetCDT_HoiChuan_BVThamGia_Coll(formMode.Id);
                }
                else
                {
                    item = CDT_HoiChuan.NewCDT_HoiChuan();
                    listBenhVien = CDT_HoiChuan_BVThamGia_Coll.NewCDT_HoiChuan_BVThamGia_Coll();
                }
                radBindingSource_BVthamgiaList.DataSource = listBenhVien;
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
                    ngaydienra.Value_String = item.NgayDienRa;
                    radtxtNoidung.Text = item.NoiDung;
                    radtxtChuTriBM.Text = item.ChuTriBM;
                    radtxtDeMuc1.Text = item.DeMuc1;
                    radtxtDeMuc2.Text = item.DeMuc2;
                    radtxtDeMuc3.Text = item.DeMuc3;
                    radtxtThuKyBM.Text = item.ThuKy1;
                    radtxtBC1.Text = item.ThuKy2;
                    dropDownLoaiHC1.Text = item.LoaiHC;
                    dropDownTrangThaiCNTT1.Text = item.TinhTrangCNTT;
                    ghichu.Text = item.GhiChu;
                    txtLyDo.Text = item.LyDo;
                    radBrowseEditor1.Value = item.LinkFile;
                    dropDownChucVuChuTri.Selected_ID = item.IdChucVuChuTri;
                    dropDownChucVuThuKy.Selected_ID = item.IdChucVuThuKy1;
                    dropDownChucVuThuKy2.Selected_ID = item.IdChucVuThuKy2;
                    dropDownChuyenKhoaChuTri.Selected_ID = item.IdKhoaChuTri;
                    dropDownChuyenKhoaThuKy.Selected_ID = item.IdKhoaThuKy1;
                    dropDownChuyenKhoaThuKy2.Selected_ID = item.IdKhoaThuKy2;
                    if (formMode.IsInsert)
                    {
                        radtxtDeMuc1.Text = "1. Tài liệu đào tạo/ Bệnh án hội chẩn: \n";
                        radtxtDeMuc1.Text += "2. Công tác truyền thông : \n";
                        radtxtDeMuc1.Text += "3. Hậu cần: \n";
                        radtxtDeMuc2.Text = "1. Chất lượng đường truyền: \n";
                        radtxtDeMuc2.Text += "2. Mức độ tham gia của các bệnh viên và các tham dự viên: \n";
                        radtxtDeMuc2.Text += "3. Các nội dung đã trình bày: \n";
                    }
                    if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                        radButton2.Enabled = true;
                    else
                        radButton2.Enabled = false;
                    CaculateTotal();
                }
                else
                {
                    item.NgayDienRa = ngaydienra.Value_String;
                    item.NoiDung = radtxtNoidung.Text;
                    item.ChuTriBM = radtxtChuTriBM.Text;
                    item.DeMuc1 = radtxtDeMuc1.Text;
                    item.DeMuc2 = radtxtDeMuc2.Text;
                    item.DeMuc3 = radtxtDeMuc3.Text;
                    item.ThuKy1 = radtxtThuKyBM.Text;
                    item.ThuKy2 = radtxtBC1.Text;
                    item.LoaiHC = dropDownLoaiHC1.Text;
                    item.TinhTrangCNTT = dropDownTrangThaiCNTT1.Text;
                    item.GhiChu = ghichu.Text;
                    item.LyDo = txtLyDo.Text;
                    if (dropDownChucVuChuTri.Selected_ID != null)
                        item.IdChucVuChuTri = Convert.ToInt32(dropDownChucVuChuTri.Selected_ID);
                    if (dropDownChucVuThuKy.Selected_ID != null)
                        item.IdChucVuThuKy1 = Convert.ToInt32(dropDownChucVuThuKy.Selected_ID);
                    if (dropDownChucVuThuKy2.Selected_ID != null)
                        item.IdChucVuThuKy2 = Convert.ToInt32(dropDownChucVuThuKy2.Selected_ID);
                    if (dropDownChuyenKhoaChuTri.Selected_ID != null)
                        item.IdKhoaChuTri = Convert.ToInt32(dropDownChuyenKhoaChuTri.Selected_ID);
                    if (dropDownChuyenKhoaThuKy.Selected_ID != null)
                        item.IdKhoaThuKy1 = Convert.ToInt32(dropDownChuyenKhoaThuKy.Selected_ID);
                    if (dropDownChuyenKhoaThuKy2.Selected_ID != null)
                        item.IdKhoaThuKy2 = Convert.ToInt32(dropDownChuyenKhoaThuKy2.Selected_ID);
                    if (!string.IsNullOrEmpty(fileUploaded))
                        item.LinkFile = fileUploaded;
                    item.Sobaocao = TongBaoCao;
                    item.Sobenhvien = TongBenhVien;
                    item.Sothanhvien = TongThamGia;
                    item.LastEdited_IDUser = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                }
            }
        }
        private bool ValidateDataBeforeSave()
        {
            if (!ngaydienra.isDateTime && !ngaydienra.isNull)
            {
                GlobalCommon.ShowErrorMessager(ngaydienra.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { ngaydienra.Value_String}))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }
        private bool UploadFile()
        {
            if (radBrowseEditor1.Value != null && !string.IsNullOrEmpty(radBrowseEditor1.Value.ToString()) && radBrowseEditor1.Value != item.LinkFile)
            {
                FtpUltilies ftp = new FtpUltilies();
                if (!ftp.UploadLargeFile(radBrowseEditor1.Value, true, out fileUploaded))
                {
                    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.FileUploadLoi);
                    return false;
                }
            }
            return true;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {

                ExportChiDaoTuyen ex = new ExportChiDaoTuyen();
                ExportLib.Entities.ChiDaoTuyen.B013_BaoCaoKetQuaDaoTaoHoiChan bx = new ExportLib.Entities.ChiDaoTuyen.B013_BaoCaoKetQuaDaoTaoHoiChan();
                if (dropDownChuyenKhoaChuTri.Selected_Item != null)
                    bx.ChucVuChuTri = dropDownChucVuChuTri.Selected_TextValue.ToString();
                bx.ChuTri = radtxtChuTriBM.Text;
                bx.DeMuc1 = radtxtDeMuc1.Text.Replace("\n", "<br>");
                bx.DeMuc2 = radtxtDeMuc2.Text.Replace("\n", "<br>");
                bx.DeMuc3 = radtxtDeMuc3.Text.Replace("\n", "<br>");
                if (dropDownChuyenKhoaChuTri.Selected_Item != null)
                    bx.KhoaChuTri = dropDownChuyenKhoaChuTri.Selected_TextValue.ToString();
                bx.NgayLapBaoCao = GlobalCommon.BC_NgayThangNam(DateTime.Now);
                if (!string.IsNullOrEmpty(ngaydienra.Value_String))
                    bx.NgayTienHanh = GlobalCommon.BC_NgayThangNam(ngaydienra.Value);
                bx.NguoiLamBaoCao = PTIdentity.FullName;
                bx.NoiDung = radtxtNoidung.Text;
                bx.PhongChiDaoTuyen = string.Empty;
                if (dropDownChucVuThuKy.Selected_Item != null)
                    bx.ThuKy1 = string.Format("{0} - {1}", radtxtThuKyBM.Text, dropDownChuyenKhoaThuKy.Selected_TextValue.ToString());
                if (dropDownChucVuThuKy2.Selected_Item != null)
                    bx.ThuKy2 = string.Format("{0} - {1}", radtxtBC1.Text, dropDownChuyenKhoaThuKy2.Selected_TextValue.ToString());
                bx.ListSoLieuThongKe = new List<ExportLib.Entities.ChiDaoTuyen.SoLieuThongKe>();
                if (listBenhVien != null)
                {
                    foreach (CDT_HoiChuan_BVThamGia_Info itemBV in listBenhVien)
                    {
                        ExportLib.Entities.ChiDaoTuyen.SoLieuThongKe itemInfo = new ExportLib.Entities.ChiDaoTuyen.SoLieuThongKe();
                        itemInfo.BaoCaoBA = itemBV.SoLuongBaoCao.ToString();
                        itemInfo.SoLuongThamGia = itemBV.SoLuongThamDu.ToString();
                        itemInfo.TenBVThamGia = itemBV.TenBenhVien;
                        bx.ListSoLieuThongKe.Add(itemInfo);
                    }
                }
                ex.B013_BaoCaoKetQuaDaoTaoHoiChan(bx);

            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    

        private void radbtnEditList_Click(object sender, EventArgs e)
        {
            try
            {
                if (dropDownBenhVien.Selected_ID == null)
                {
                    GlobalCommon.ShowErrorMessager("Bạn chưa chọn bệnh viện");
                    return;
                }
                int test1 = 0;
                if (!int.TryParse(radtxtSoLuongBaoCao.Text, out test1) || test1 < 0 )
                {
                    GlobalCommon.ShowErrorMessager("Số lượng báo cáo phải là một số và không nhỏ hơn 0");
                    return;
                }
                int test2 = 0;
                if (!int.TryParse(radtxtSoLuongBVkhac.Text, out test2) || test2 <= 0)
                {
                    GlobalCommon.ShowErrorMessager("Số lượng cán bộ tham gia phải là một số và lớn hơn 0");
                    return;
                }
                long selectIDList = Convert.ToInt64(dropDownBenhVien.Selected_ID);
                foreach (CDT_HoiChuan_BVThamGia_Info itemx in listBenhVien)
                {
                    if (itemx.IdBenhVien == selectIDList)
                    {
                        GlobalCommon.ShowErrorMessager("Bệnh viện đã nằm trong danh sách");
                        return;
                    }
                }
                CDT_HoiChuan_BVThamGia_Info itemInfo = listBenhVien.AddNew();
                itemInfo.IdBenhVien = selectIDList;
                itemInfo.IdHoiChuan = 0;
                itemInfo.SoLuongBaoCao = test1;
                itemInfo.SoLuongThamDu = test2;
                itemInfo.TenBenhVien = dropDownBenhVien.Selected_TextValue.ToString();
                radBindingSource_BVthamgiaList.DataSource = listBenhVien;
                CaculateTotal();
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radbtnDelList_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridView1.CurrentRow.DataBoundItem != null)
                {
                    CDT_HoiChuan_BVThamGia_Info itemInfo = (CDT_HoiChuan_BVThamGia_Info)radGridView1.CurrentRow.DataBoundItem;
                    listBenhVien.Remove(itemInfo);
                    radBindingSource_BVthamgiaList.DataSource = listBenhVien;
                    CaculateTotal();
                }
                else
                {
                    GlobalCommon.ShowErrorMessager("Bạn phải chọn 1 bản ghi để xóa");
                    return;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void CaculateTotal()
        {
            TongBenhVien = 0;
            TongBaoCao = 0;
            TongThamGia = 0;
            foreach (CDT_HoiChuan_BVThamGia_Info itemInfo in listBenhVien)
            {
                TongBenhVien++;
                TongBaoCao += Convert.ToInt32(itemInfo.SoLuongBaoCao);
                TongThamGia += Convert.ToInt32(itemInfo.SoLuongThamDu);
            }
            radlbBaoCao.Text = TongBaoCao.ToString();
            radlbBenhVien.Text = TongBenhVien.ToString();
            radlbCanBo.Text = TongThamGia.ToString();
        }
        private void BindDataForList()
        {
            foreach (CDT_HoiChuan_BVThamGia_Info itemInfo in listBenhVien)
            {
                itemInfo.IdHoiChuan = item.ID;
            }
            if (listBenhVien.IsDirty)
                listBenhVien.Save();
        }
        private void dropDownBenhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                radtxtSoLuongBaoCao.Text = string.Empty;
                radtxtSoLuongBVkhac.Text = string.Empty;
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
                if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                {
                    FtpUltilies ftp = new FtpUltilies();
                    ftp.SaveDownloadedFile(item.LinkFile);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void dropDownTrangThaiCNTT1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                radtxtDeMuc2.Text = radtxtDeMuc2.Text.Replace("Chất lượng đường truyền: ", "Chất lượng đường truyền: " + dropDownTrangThaiCNTT1.Text);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
