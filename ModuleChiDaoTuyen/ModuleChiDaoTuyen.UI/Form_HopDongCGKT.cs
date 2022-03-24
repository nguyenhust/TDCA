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
    public partial class Form_HopDongCGKT : Dictionary
    {
        #region Variable

        private CDT_HopDongCGKT item;
        private CDT_HopDong_GoiKT_CanBoTrienKhai_Coll listCanBoTrienKhai;
        private DIC_CanBo_Coll listGiangVien;
        private DIC_CanBo_Coll listCanBoQuanLy;
        private CDT_HopDong_GoiKT_Coll listHopDongGoiKT;
        private CDT_HopDong_GoiKT ItemInfoHDGKT;
        private string fileUploaded;
        private string ErrorMessage01 = "Bạn phải lưu thông tin hợp đồng trước khi tiếp tục";
        private string A_Name = string.Empty;
        private string B_Name = string.Empty;
        private int selectedID;
        private bool IsSaved = false;

        #endregion
        public Form_HopDongCGKT(FormMode _formMode)
        {
            InitializeComponent();
            this.formMode = _formMode;
            netLink_DatePickerNgayKyKet.MyName = "Ngày kí kết";
            // ngaydienra.MyName = "Ngày diễn ra";
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
           
        }
        protected override void FormLoad()
        {
            try
            {
                lbCanhbao01.Visible = false;
                lbcanhbao02.Visible = false;
                lbcanhbao03.Visible = false;
                dropDownBenhVienA.FillData(1);
                dropDownBenhVienB.FillData(2);
                dropDownChucVuA.FillData(1);
                dropDownChucVuB.FillData(2);
                dropDownCanBo1.FillData(1);
                dropDownGoiKyThuatPage2.FillData();
                dropDownLoaiHinhChuyenGiao1.FillData();
                dropDownTinhThanhA.FillData(1);
                dropDownTinhThanhB.FillData(2);
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = CDT_HopDongCGKT.GetCDT_HopDongCGKT(formMode.Id);
                    IsSaved = true;
                    Page2LoadDataForHopDongGoiKT();
                    BindDataPage3();
                    BindDataPage4();
                    BindDataPage5();
                    BindDataPage6();
                }
                else
                {
                    item = CDT_HopDongCGKT.NewCDT_HopDongCGKT();
                    listHopDongGoiKT = CDT_HopDong_GoiKT_Coll.NewCDT_HopDong_GoiKT_Coll();
                }
                BindDataForAll(true);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void BindDataForAll(bool isLoad)
        {
            BindDataPage1(isLoad);

        }
        private void UploadFile()
        {
            //if (radBrowseEditor1.Value != null && !string.IsNullOrEmpty(radBrowseEditor1.Value.ToString()))
            //{
            //    FtpUltilies ftp = new FtpUltilies();
            //    ftp.UploadLargeFile(radBrowseEditor1.Value, true, out fileUploaded);
            //}
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
            //    {
            //        FtpUltilies ftp = new FtpUltilies();
            //        ftp.SaveDownloadedFile(item.LinkFile);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    GlobalCommon.ShowErrorMessager(ex);
            //}
        }

        #region BusinessProcess

        private void FillDataForDropDownBox()
        {
            #region Page 1
            dropDownBenhVienA.FillData(1);
            dropDownBenhVienB.FillData(2);
            dropDownTinhThanhA.FillData(1);
            dropDownTinhThanhB.FillData(2);
            dropDownChucVuA.FillData(1);
            dropDownChucVuB.FillData(2);
            #endregion

            #region Page 2
            dropDownGoiKyThuatPage2.FillData();
            #endregion
        }

        private void FillNameForDataTimePicker()
        {
            netLink_DatePickerNgayKyKet.MyName = "Ngày Kí kết - trang 01";
        }



        #region Validate Data

        private bool ValidatePage1()
        {
            if (!netLink_DatePickerNgayKyKet.isDateTime && !netLink_DatePickerNgayKyKet.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayKyKet.Value_Error);
                return false;
            }
            return true;
        }

        #endregion

        #endregion

        #region Event Handler

        private void dropDownBenhVien1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropDownBenhVienA.Selected_Item != null)
                {
                    DIC_BenhVien_Info itemInfo = (DIC_BenhVien_Info)dropDownBenhVienA.Selected_Item;
                    dropDownTinhThanhA.Selected_ID = itemInfo.IDTinh;
                    txtA_DiaChi.Text = itemInfo.DiaChi;
                    txtA_DienThoai.Text = itemInfo.DienThoai;
                    txtA_Fax.Text = itemInfo.Fax;
                    A_Name = itemInfo.Ten;

                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void dropDownBenhVien2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropDownBenhVienB.Selected_Item != null)
                {
                    DIC_BenhVien_Info itemInfo = (DIC_BenhVien_Info)dropDownBenhVienB.Selected_Item;
                    dropDownTinhThanhB.Selected_ID = itemInfo.IDTinh;
                    txtB_DiaChi.Text = itemInfo.DiaChi;
                    txtB_DienThoai.Text = itemInfo.DienThoai;
                    txtB_Fax.Text = itemInfo.Fax;
                    B_Name = itemInfo.Ten;

                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radPageViewHopdong_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void radPageViewHopdong_SelectedPageChanging(object sender, Telerik.WinControls.UI.RadPageViewCancelEventArgs e)
        {
            try
            {
                if (!IsSaved && radPageViewPageThongTin != e.Page)
                {
                    e.Cancel = true;
                    lbCanhbao01.Visible = true;
                    lbcanhbao02.Visible = true;
                    lbcanhbao03.Visible = true;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion






        #region Page2

        private void Page2LoadDataForHopDongGoiKT()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
            function.ItemID = item.ID;
            listHopDongGoiKT = CDT_HopDong_GoiKT_Coll.GetCDT_HopDong_GoiKT_Coll(function);
            bindHopDongGoiKT_Page2.DataSource = listHopDongGoiKT;
        }

        //private void Page2SaveListData()
        //{
        //    listHopDongGoiKT.ApplyEdit();
        //    listHopDongGoiKT.Save();
        //    bindHopDongGoiKT_Page2.DataSource = listHopDongGoiKT;
        //}

        private void Page2BindDataForGoiKyThuat(CDT_HopDong_GoiKT_Info itemInfo, bool IsLoad)
        {
            if (!IsLoad)
            {
                if (dropDownCanBo1.Selected_ID != null)
                {
                    itemInfo.IdCanBoPhuTrach = Convert.ToInt64(dropDownCanBo1.Selected_ID);
                }
                itemInfo.ChiTieuDanhGia = txtP2CTDanhGia.Text;
                itemInfo.MucTieuKienThuc = txtP2MTkienthuc.Text;
                itemInfo.MoTaKyThuatChuyenGiao = txtP2MTKTChuyenGiao.Text;
                itemInfo.MucTieuKyNang = txtP2MTKyNang.Text;
                itemInfo.MucTieuThaiDo = txtP2MTThaiDo.Text;
                itemInfo.NoiDungChuyenGiao = txtP2NDChuyenGiao.Text;
                itemInfo.TieuChuanGoiKT = txtP2TCGoiKT.Text;
                itemInfo.TaiLieuHocTap_BS = txtP2TLBS.Text;
                itemInfo.TaiLieuHocTap_DD = txtP2TLDD.Text;
                itemInfo.TaiLieuHocTap_Khac = txtP2TLKhac.Text;
                itemInfo.GhiChu = txtP2GhiChuGKT.Text;
                itemInfo.A_NgayBatDau = netLink_DatePickerANgayBatDau.Value_String;
                itemInfo.A_NgayKetThuc = netLink_DatePickerANgayKetThuc.Value_String;
                itemInfo.B_NgayBatDau = netLink_DatePickerBNgayBatDau.Value_String;
                itemInfo.B_NgayKetThuc = netLink_DatePickerBNgayKetThuc.Value_String;
                itemInfo.LastEdited_Date = DateTime.Now;
                itemInfo.LastEdited_UserID = PTIdentity.IDNguoiDung;
                itemInfo.LoaiHinhChuyenGiao = dropDownLoaiHinhChuyenGiao1.Text;
                itemInfo.MaHopDong = item.ID.ToString();
                if (dropDownCanBo1.Selected_TextValue!= null)
                    itemInfo.TenNguoiThongQua = dropDownCanBo1.Selected_TextValue.ToString();
            }
            else
            {
                netLink_DatePickerANgayBatDau.Value_String = itemInfo.A_NgayBatDau;
                netLink_DatePickerANgayKetThuc.Value_String = itemInfo.A_NgayKetThuc;
                netLink_DatePickerBNgayBatDau.Value_String = itemInfo.B_NgayBatDau;
                netLink_DatePickerBNgayKetThuc.Value_String = itemInfo.B_NgayKetThuc;
                txtGhiChu.Text = itemInfo.GhiChu;
                dropDownCanBo1.Selected_ID = itemInfo.IdCanBoPhuTrach;
                dropDownGoiKyThuatPage2.Selected_ID = itemInfo.IdGoiKT;
                dropDownLoaiHinhChuyenGiao1.Text = itemInfo.LoaiHinhChuyenGiao;
                txtP2CTDanhGia.Text = itemInfo.ChiTieuDanhGia;
                txtP2MTkienthuc.Text = itemInfo.MucTieuKienThuc;
                txtP2MTKTChuyenGiao.Text = itemInfo.MoTaKyThuatChuyenGiao;
                txtP2MTKyNang.Text = itemInfo.MucTieuKyNang;
                txtP2MTThaiDo.Text = itemInfo.MucTieuThaiDo;
                txtP2NDChuyenGiao.Text = itemInfo.NoiDungChuyenGiao;
                txtP2TCGoiKT.Text = itemInfo.TieuChuanGoiKT;
                txtP2TLBS.Text = itemInfo.TaiLieuHocTap_BS;
                txtP2TLDD.Text = itemInfo.TaiLieuHocTap_DD;
                txtP2TLKhac.Text = itemInfo.TaiLieuHocTap_Khac;

            }
        }
        private void Page2BindDataForGoiKyThuat(CDT_HopDong_GoiKT itemInfo, bool IsLoad)
        {
            if (!IsLoad)
            {
                if (dropDownCanBo1.Selected_ID != null)
                {
                    itemInfo.IdCanBoPhuTrach = Convert.ToInt64(dropDownCanBo1.Selected_ID);
                }
                itemInfo.ChiTieuDanhGia = txtP2CTDanhGia.Text;
                itemInfo.MucTieuKienThuc = txtP2MTkienthuc.Text;
                itemInfo.MoTaKyThuatChuyenGiao = txtP2MTKTChuyenGiao.Text;
                itemInfo.MucTieuKyNang = txtP2MTKyNang.Text;
                itemInfo.MucTieuThaiDo = txtP2MTThaiDo.Text;
                itemInfo.NoiDungChuyenGiao = txtP2NDChuyenGiao.Text;
                itemInfo.TieuChuanGoiKT = txtP2TCGoiKT.Text;
                itemInfo.TaiLieuHocTap_BS = txtP2TLBS.Text;
                itemInfo.TaiLieuHocTap_DD = txtP2TLDD.Text;
                itemInfo.TaiLieuHocTap_Khac = txtP2TLKhac.Text;
                itemInfo.GhiChu = txtP2GhiChuGKT.Text;
                itemInfo.A_NgayBatDau = netLink_DatePickerANgayBatDau.Value_String;
                itemInfo.A_NgayKetThuc = netLink_DatePickerANgayKetThuc.Value_String;
                itemInfo.B_NgayBatDau = netLink_DatePickerBNgayBatDau.Value_String;
                itemInfo.B_NgayKetThuc = netLink_DatePickerBNgayKetThuc.Value_String;
                itemInfo.LastEdited_Date = DateTime.Now;
                itemInfo.LastEdited_UserID = PTIdentity.IDNguoiDung;
                itemInfo.LoaiHinhChuyenGiao = dropDownLoaiHinhChuyenGiao1.Text;
                itemInfo.MaHopDong = item.ID.ToString();
                if (dropDownCanBo1.Selected_TextValue != null)
                    itemInfo.TenNguoiThongQua = dropDownCanBo1.Selected_TextValue.ToString();
            }
            else
            {
                netLink_DatePickerANgayBatDau.Value_String = itemInfo.A_NgayBatDau;
                netLink_DatePickerANgayKetThuc.Value_String = itemInfo.A_NgayKetThuc;
                netLink_DatePickerBNgayBatDau.Value_String = itemInfo.B_NgayBatDau;
                netLink_DatePickerBNgayKetThuc.Value_String = itemInfo.B_NgayKetThuc;
                txtGhiChu.Text = itemInfo.GhiChu;
                dropDownCanBo1.Selected_ID = itemInfo.IdCanBoPhuTrach;
                dropDownGoiKyThuatPage2.Selected_ID = itemInfo.IdGoiKT;
                dropDownLoaiHinhChuyenGiao1.Text = itemInfo.LoaiHinhChuyenGiao;
                txtP2CTDanhGia.Text = itemInfo.ChiTieuDanhGia;
                txtP2MTkienthuc.Text = itemInfo.MucTieuKienThuc;
                txtP2MTKTChuyenGiao.Text = itemInfo.MoTaKyThuatChuyenGiao;
                txtP2MTKyNang.Text = itemInfo.MucTieuKyNang;
                txtP2MTThaiDo.Text = itemInfo.MucTieuThaiDo;
                txtP2NDChuyenGiao.Text = itemInfo.NoiDungChuyenGiao;
                txtP2TCGoiKT.Text = itemInfo.TieuChuanGoiKT;
                txtP2TLBS.Text = itemInfo.TaiLieuHocTap_BS;
                txtP2TLDD.Text = itemInfo.TaiLieuHocTap_DD;
                txtP2TLKhac.Text = itemInfo.TaiLieuHocTap_Khac;

            }
        }
        


        private void btnGktLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemInfoHDGKT != null)
                {
                    Page2BindDataForGoiKyThuat(ItemInfoHDGKT, false);
                    Page2Save(ItemInfoHDGKT);
                    Page2BindDataForGoiKyThuat(CDT_HopDong_GoiKT_Info.NewCDT_HopDong_GoiKT_Info(), true);
                    dropDownGoiKyThuatPage2.Enabled = true;
                    GlobalCommon.CacheRemove(TextMessages.CacheID.CDT_GoiKT + item.ID.ToString());
                    Page2LoadDataForHopDongGoiKT();
                }

            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }


        private void Page2Save(CDT_HopDong_GoiKT itemInfo)
        {
            itemInfo.ApplyEdit();
            itemInfo.Save();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dropDownGoiKyThuatPage2.Selected_ID != null)
                {
                    int idGoiKT = Convert.ToInt32(dropDownGoiKyThuatPage2.Selected_ID);
                    foreach (CDT_HopDong_GoiKT_Info itemInfo in listHopDongGoiKT)
                    {
                        if (itemInfo.IdGoiKT == idGoiKT)
                        {
                            GlobalCommon.ShowErrorMessager("Gói kỹ thuật đã tồn tại");
                            return;
                        }
                    }
                    ItemInfoHDGKT = CDT_HopDong_GoiKT.NewCDT_HopDong_GoiKT();
                    ItemInfoHDGKT.IdGoiKT = idGoiKT;
                    Page2BindDataForGoiKyThuat(ItemInfoHDGKT, false);
                    Page2Save(ItemInfoHDGKT);
                    Page2BindDataForGoiKyThuat(CDT_HopDong_GoiKT.NewCDT_HopDong_GoiKT(), true);
                    GlobalCommon.CacheRemove(TextMessages.CacheID.CDT_GoiKT + item.ID.ToString());
                    Page2LoadDataForHopDongGoiKT();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void dropDownGoiKyThuatPage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dropDownGoiKyThuatPage2.Selected_Item != null)
                {
                    CDT_GoiKT_Info itemInfo = (CDT_GoiKT_Info)dropDownGoiKyThuatPage2.Selected_Item;
                    txtP2CTDanhGia.Text = itemInfo.ChiTieuDanhGia;
                    txtP2MTkienthuc.Text = itemInfo.MucTieuKienThuc;
                    txtP2MTKTChuyenGiao.Text = itemInfo.MoTaKyThuatChuyenGiao;
                    txtP2MTKyNang.Text = itemInfo.MucTieuKyNang;
                    txtP2MTThaiDo.Text = itemInfo.MucTieuThaiDo;
                    txtP2NDChuyenGiao.Text = itemInfo.NoiDungChuyenGiao;
                    txtP2TCGoiKT.Text = itemInfo.TieuChuanGoiKT;
                    txtP2TLBS.Text = itemInfo.TaiLieuHocTap_BS;
                    txtP2TLDD.Text = itemInfo.TaiLieuHocTap_DD;
                    txtP2TLKhac.Text = itemInfo.TaiLieuHocTap_Khac;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radGridViewHopdongGoiKt_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridViewHopdongGoiKt.CurrentRow != null)
                {
                   
                    CDT_HopDong_GoiKT_Info Itemx = (CDT_HopDong_GoiKT_Info)radGridViewHopdongGoiKt.CurrentRow.DataBoundItem;
                    ItemInfoHDGKT = CDT_HopDong_GoiKT.GetCDT_HopDong_GoiKT(Itemx.ID);
                    Page2BindDataForGoiKyThuat(ItemInfoHDGKT, true);
                    dropDownGoiKyThuatPage2.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void btnGKTxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridViewHopdongGoiKt.CurrentRow != null && GlobalCommon.AcceptDelete())
                {
                    CDT_HopDong_GoiKT_Info Itemx = (CDT_HopDong_GoiKT_Info)radGridViewHopdongGoiKt.CurrentRow.DataBoundItem;
                    CDT_HopDong_GoiKT.DeleteCDT_HopDong_GoiKT(Itemx.ID);
                    Page2LoadDataForHopDongGoiKT();
                    GlobalCommon.CacheRemove(TextMessages.CacheID.CDT_GoiKT + item.ID.ToString());
                    Page2LoadDataForHopDongGoiKT();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion





        #region Page3

        private void Page3Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null || item.ID == null || item.ID <= 0)
                {
                    GlobalCommon.ShowErrorMessager(ErrorMessage01);
                    return;
                }
                FormMode newMode = new FormMode(item);
                newMode.IsInsert = true;
                CanBoNhanCGKT fr = new CanBoNhanCGKT(newMode);
                fr.ShowDialog();
                BindDataPage3();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Page3Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null || item.ID == null || item.ID <= 0)
                {
                    GlobalCommon.ShowErrorMessager(ErrorMessage01);
                    return;
                }
                if (Page3Grid.CurrentCell != null && int.TryParse(Page3Grid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    FormMode newMode = new FormMode(item);
                    newMode.Id = selectedID;
                    newMode.IsEdit = true;
                    CanBoNhanCGKT fr = new CanBoNhanCGKT(newMode);
                    fr.ShowDialog();
                    BindDataPage3();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Page3Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Page3Grid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    CDT_CanBoNhanCGKT.DeleteCDT_CanBoNhanCGKT(selectedID);
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Can Bo Nhan CGKT" + this.ToString());
                    BindDataPage3();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void BindDataPage3()
        {
            if (item != null && item.ID != null && item.ID > 0)
            {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
                function.ItemID = item.ID;
                CDT_CanBoNhanCGKT_Coll itemColl = CDT_CanBoNhanCGKT_Coll.GetCDT_CanBoNhanCGKT_Coll(function);

                bindCanBoNCGKT_Page3.DataSource = itemColl;
            }
        }

        #endregion

        #region Page4

        private void Page4Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null || item.ID == null || item.ID <= 0)
                {
                    GlobalCommon.ShowErrorMessager(ErrorMessage01);
                    return;
                }
                FormMode newMode = new FormMode(item);
                newMode.IsInsert = true;
                Form_GiangVien fr = new Form_GiangVien(newMode);
                fr.ShowDialog();
                BindDataPage4();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Page4Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null || item.ID == null || item.ID <= 0)
                {
                    GlobalCommon.ShowErrorMessager(ErrorMessage01);
                    return;
                }
                if (Page4Grid.CurrentCell != null && int.TryParse(Page4Grid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    FormMode newMode = new FormMode(item);
                    newMode.Id = selectedID;
                    newMode.IsEdit = true;
                    Form_GiangVien fr = new Form_GiangVien(newMode);
                    fr.ShowDialog();
                    BindDataPage4();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Page4Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Page4Grid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    CDT_HopDong_GoiKT_CanBoTrienKhai.DeleteCDT_HopDong_GoiKT_CanBoTrienKhai(selectedID);
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Giang Vien" + this.ToString());
                    BindDataPage4();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void BindDataPage4()
        {
            if (item != null && item.ID != null && item.ID > 0)
            {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
                function.ItemID = item.ID;
                CDT_HopDong_GoiKT_CanBoTrienKhai_Coll itemColl = CDT_HopDong_GoiKT_CanBoTrienKhai_Coll.GetCDT_HopDong_GoiKT_CanBoTrienKhai_Coll(function);

                bindGiangVien_Page4.DataSource = itemColl;
            }
        }

        #endregion

        #region Page5

        private void Page5Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null || item.ID == null || item.ID <= 0)
                {
                    GlobalCommon.ShowErrorMessager(ErrorMessage01);
                    return;
                }
                FormMode newMode = new FormMode(item);
                newMode.IsInsert = true;
                Form_CanBoDiTinh fr = new Form_CanBoDiTinh(newMode);
                fr.ShowDialog();
                BindDataPage5();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Page5Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null || item.ID == null || item.ID <= 0)
                {
                    GlobalCommon.ShowErrorMessager(ErrorMessage01);
                    return;
                }
                if (Page5Grid.CurrentCell != null && int.TryParse(Page5Grid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    FormMode newMode = new FormMode(item);
                    newMode.Id = selectedID;
                    newMode.IsEdit = true;
                    Form_CanBoDiTinh fr = new Form_CanBoDiTinh(newMode);
                    fr.ShowDialog();
                    BindDataPage5();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Page5Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Page5Grid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    CDT_CanBoDiTinh.DeleteCDT_CanBoDiTinh(selectedID);
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Can Bo Di Tinh" + this.ToString());
                    BindDataPage5();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void BindDataPage5()
        {
            if (item != null && item.ID != null && item.ID > 0)
            {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
                function.ItemID = item.ID;
                CDT_CanBoDiTinh_Coll itemColl = CDT_CanBoDiTinh_Coll.GetCDT_CanBoDiTinh_Coll(function);

                bindCanBoDiTinh_Page5.DataSource = itemColl;
            }
        }

        #endregion

        #region Page6

        private void Page6Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null || item.ID == null || item.ID <= 0)
                {
                    GlobalCommon.ShowErrorMessager(ErrorMessage01);
                    return;
                }
                FormMode newMode = new FormMode(item);
                newMode.IsInsert = true;
                Form_TaiChinh fr = new Form_TaiChinh(newMode);
                fr.ShowDialog();
                BindDataPage6();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Page6Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (item == null || item.ID == null || item.ID <= 0)
                {
                    GlobalCommon.ShowErrorMessager(ErrorMessage01);
                    return;
                }
                if (Page6Grid.CurrentCell != null && int.TryParse(Page6Grid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID))
                {
                    FormMode newMode = new FormMode(item);
                    newMode.Id = selectedID;
                    newMode.IsEdit = true;
                    Form_TaiChinh fr = new Form_TaiChinh(newMode);
                    fr.ShowDialog();
                    BindDataPage6();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Page6Del_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(Page6Grid.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    CDT_KinhPhiCGKT.DeleteCDT_KinhPhiCGKT(selectedID);
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Delete, "Kinh Phi" + this.ToString());
                    BindDataPage6();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void BindDataPage6()
        {
            if (item != null && item.ID != null && item.ID > 0)
            {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
                function.ItemID = item.ID;
                CDT_KinhPhiCGKT_Coll itemColl = CDT_KinhPhiCGKT_Coll.GetCDT_KinhPhiCGKT_Coll(function);
                bindTaiChinh_Page6.DataSource = itemColl;
            }
        }

        #endregion

        #region Page1

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDataBeforeSavePage1())
                {
                    //UploadFile();
                    BindDataPage1(false);
                    item.ApplyEdit();
                    item = item.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "CDT_Hoi CHuan" + this.Text);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    IsSaved = true;
                    lbCanhbao01.Visible = false;
                    lbcanhbao02.Visible = false;
                    lbcanhbao03.Visible = false;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void BindDataPage1(bool isLoad)
        {
            if (item != null)
            {
                if (isLoad)
                {
                    txtA_DiaChi.Text = item.A_DiaChi;
                    txtA_DienThoai.Text = item.A_DienThoai;
                    txtA_Fax.Text = item.A_Fax;
                    txtA_NguoiDaiDien.Text = item.A_NguoiDaiDien;
                    txtB_DiaChi.Text = item.B_DiaChi;
                    txtB_DienThoai.Text = item.B_DienThoai;
                    txtB_Fax.Text = item.B_Fax;
                    txtB_NguoiDaiDien.Text = item.B_NguoiDaiDien;
                    dropDownBenhVienA.Selected_ID = item.A_idBenhVien;
                    dropDownBenhVienB.Selected_ID = item.B_idBenhVien;
                    dropDownChucVuA.Selected_ID = item.A_ChucVu;
                    dropDownChucVuB.Selected_ID = item.B_ChucVu;
                    dropDownTinhThanhA.Selected_ID = item.A_City;
                    dropDownTinhThanhB.Selected_ID = item.B_City;
                    txtTenhopdong.Text = item.MaHopDong;
                    txtGhiChu.Text = item.GhiChu;
                    netLink_DatePickerNgayKyKet.Value_String = item.NgayKiKet;
                    radCheckBoxDaThanhLy.Checked = Convert.ToBoolean(item.DaThanhLy);
                    if (dropDownBenhVienA.Selected_ID != null)
                    {
                        
                        item.TenBenhVienA = dropDownBenhVienA.Selected_TextValue.ToString();
                    }
                    if (dropDownBenhVienB.Selected_ID != null)
                    {

                        item.TenBenhVienB = dropDownBenhVienB.Selected_TextValue.ToString();
                    }
                }
                else
                {
                    item.A_DiaChi = txtA_DiaChi.Text;
                    item.A_DienThoai = txtA_DienThoai.Text;
                    item.A_Fax = txtA_Fax.Text;
                    item.A_NguoiDaiDien = txtA_NguoiDaiDien.Text;
                    item.B_DienThoai = txtB_DienThoai.Text;
                    item.B_Fax = txtB_Fax.Text;
                    item.B_DiaChi = txtB_DiaChi.Text;
                    item.B_NguoiDaiDien = txtB_NguoiDaiDien.Text;
                    if (dropDownBenhVienA.Selected_ID != null)
                    {
                        item.A_idBenhVien = Convert.ToInt32(dropDownBenhVienA.Selected_ID);
                        item.TenBenhVienA = dropDownBenhVienA.Selected_TextValue.ToString();
                    }
                    if (dropDownBenhVienB.Selected_ID != null)
                    {
                        item.B_idBenhVien = Convert.ToInt32(dropDownBenhVienB.Selected_ID);
                        item.TenBenhVienB = dropDownBenhVienB.Selected_TextValue.ToString();
                    }
                    if (dropDownChucVuA.Selected_ID != null)
                        item.A_ChucVu = dropDownChucVuA.Selected_ID.ToString();
                    if (dropDownTinhThanhA.Selected_ID != null)
                        item.A_City = dropDownTinhThanhA.Selected_ID.ToString();
                    if (dropDownChucVuB.Selected_ID != null)
                        item.B_ChucVu = dropDownChucVuB.Selected_ID.ToString();
                    if (dropDownTinhThanhB.Selected_ID != null)
                        item.B_City = dropDownTinhThanhB.Selected_ID.ToString();
                    item.DaThanhLy = radCheckBoxDaThanhLy.Checked;
                    item.MaHopDong = txtTenhopdong.Text;
                    item.GhiChu = txtGhiChu.Text;
                    item.NgayKiKet = netLink_DatePickerNgayKyKet.Value_String;
                    item.LastEdited_Date = DateTime.Now;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;



                }
            }
        }
        private bool ValidateDataBeforeSavePage1()
        {
            if (!netLink_DatePickerNgayKyKet.isDateTime && !netLink_DatePickerNgayKyKet.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayKyKet.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { netLink_DatePickerNgayKyKet.Value_String,txtTenhopdong.Text, dropDownChucVuA.Selected_TextValue, dropDownChucVuB.Selected_TextValue, dropDownBenhVienA.Selected_TextValue, dropDownBenhVienB.Selected_TextValue, txtA_NguoiDaiDien.Text, txtB_NguoiDaiDien.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        #endregion










    }
}
