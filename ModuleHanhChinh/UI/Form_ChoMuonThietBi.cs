using NETLINK.LIB;
using DanhMuc.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleHanhChinh.LIB;
using Authoration.LIB;

namespace ModuleHanhChinh.UI
{
    public partial class Form_ChoMuonThietBi : NETLINK.UI.Dictionary
    {
        
       private LoaiPhieu loaiPhieu;
        private HC_PhieuGiaoNhanThietBi item;
        private HC_VatTuTaiSan_Coll listVatTu;
        private HC_VatTuTaiSan_PhieuGiaoNhan_Coll listVatTu_ChoMuon;
        private List<ExportLib.Entities.HanhChinh.NoiDungThietBi> P001List;

        public Form_ChoMuonThietBi(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            btnSave.Text = "Lưu và In phiếu";
            P001List = new List<ExportLib.Entities.HanhChinh.NoiDungThietBi>();
            if (formMode.Item != null)
                loaiPhieu = (LoaiPhieu)formMode.Item;
            else
                loaiPhieu = LoaiPhieu.PhieuMuonThietBi;
        }
        protected override void ApplyAuthorizationRules()
        {
            btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_PhieuMuonThietBi_Insert, TextMessages.RolePermission.HC_PhieuMuonThietBi_Edit });
        }
        protected override void Save()
        {
            try
            { 
                if (ValidateDataBeforeSave())
                {
                    BindData(false);
                    item.ApplyEdit();
                    item = item.Save();
                    //GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    SaveDataBeforePrint();
                    PrintToCrystalReport();
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
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_PhieuGiaoNhanThietBi.GetHC_PhieuGiaoNhanThietBi(formMode.Id);
                }
                else
                {
                    item = HC_PhieuGiaoNhanThietBi.NewHC_PhieuGiaoNhanThietBi();
                    if (formMode.ItemColl != null)
                        listVatTu = (HC_VatTuTaiSan_Coll)formMode.ItemColl;
                    else
                        this.Close();
                }
                BindData(true);
                radBingdingSource.DataSource = item;
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
                    richTextBoxWithBigEditor1.Text = item.GhiChu;
                }
                else
                {
                    item.GhiChu = richTextBoxWithBigEditor1.Text;
                    item.LastEdited_Date = DateTime.Now.ToShortDateString();
                    item.LastEdited_IDUser = PTIdentity.IDNguoiDung;
                    item.TongSoLanIn = item.TongSoLanIn + 1;
                    item.Type = Convert.ToInt32(LoaiPhieu.PhieuMuonThietBi);
                }
            }
        }

        private bool ValidateDataBeforeSave()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new object[] { txtong1.Text, txtong4.Text, txtChucVu1.Text, txtchucvu4.Text, txtdiadiem.Text, txtthoigianmuon.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;

        }
        private void SaveDataBeforePrint()
        {
            listVatTu_ChoMuon = HC_VatTuTaiSan_PhieuGiaoNhan_Coll.NewHC_VatTuTaiSan_PhieuGiaoNhan_Coll();
            int count = 1;
            foreach (HC_VatTuTaiSan_Info itemInfo in listVatTu)
            {
                ExportLib.Entities.HanhChinh.NoiDungThietBi itemY = new ExportLib.Entities.HanhChinh.NoiDungThietBi();
                itemY.TenThietBi = itemInfo.TenVatTu;
                itemY.XuatSu = itemInfo.XuatXu;
                itemY.SoLuong = "1";
                itemY.Serial = itemInfo.SerialMay;
                itemY.DonVi = string.Empty;
                itemY.GhiChu = string.Empty;
                itemY.STT = count.ToString();
                count++;
                P001List.Add(itemY);
                HC_VatTuTaiSan_PhieuGiaoNhan_Info itemX = HC_VatTuTaiSan_PhieuGiaoNhan_Info.NewHC_VatTuTaiSan_PhieuGiaoNhan_Info();
                itemX.IDVatTuTaiSan = itemInfo.ID;
                itemX.IDPhieuGiaoNhan = item.ID;
                listVatTu_ChoMuon.Add(itemX);
            }
            listVatTu.Save();
            listVatTu_ChoMuon.Save();
        }
        private void PrintToCrystalReport()
        {
            ExportLib.ExportHanhChinh ex = new ExportLib.ExportHanhChinh();
            ExportLib.Entities.HanhChinh.P001_PhieuMuonThietBi P001 = new ExportLib.Entities.HanhChinh.P001_PhieuMuonThietBi();
            P001.ListNoiDungThietBi = P001List;
            P001.ChucVuGiao1 = item.ChucVuGiao1;
            P001.ChucVuGiao2 = item.ChucVuGiao2;
            P001.ChucVuGiao3 = item.ChucVuGiao3;
            P001.ChucVuMuon1 = item.ChucVuMuon1;
            P001.ChucVuMuon2 = item.ChucVuMuon2;
            P001.ChucVuMuon3 = item.ChucVuMuon3;
            P001.DaiDienBenGiao = item.DaiDienBenGiao;
            P001.DaiDienBenMuon = item.DaiDienBenMuon;
            P001.DiaDiemMuon = item.DiaDiemMuon;
            P001.NgayVietPhieu = GlobalCommon.BC_NgayThangNam(DateTime.Now);
            P001.NguoiGiao1 = item.GiaoTen1;
            P001.NguoiGiao2 = item.GiaoTen2;
            P001.NguoiGiao3 = item.GiaoTen3;
            P001.NguoiMuon1 = item.MuonTen1;
            P001.NguoiMuon2 = item.MuonTen2;
            P001.NguoiMuon3 = item.MuonTen3;
            P001.ThoiGianMuon = item.ThoiGianMuon;
            P001.KyDaiDienBenGiao = string.Empty;
            P001.KyDaiDienBenNhan = string.Empty;
            if (loaiPhieu == LoaiPhieu.PhieuMuonThietBi)
            {
                P001.NhanOrMuon = "MƯỢN";
                P001.TenBaoCao = "PHIẾU MƯỢN THIẾT BỊ";
                P001.Warning = "<P class='p17 ft6'>Kể từ khi mượn, bên nhận thiết bị có trách nhiệm giữ gìn, bảo quản thiết bị theo quy định. Có trách nhiệm bồi thường khi xảy ra mất mát hay hư hỏng. Hoàn trả thiết bị đúng thời gian.</P>";
                P001.Warning += "<P class='p18 ft1'>Biên bản được thành lập làm 02 bản. Mỗi bên giữ một bản và có giá trị như nhau.</P>";
            }
            else
            {
                P001.NhanOrMuon = "NHẬN";
                P001.TenBaoCao = "BIÊN BẢN GIAO NHẬN THIẾT BỊ";
                P001.Warning = string.Empty;
            }
                ex.P100_GenReport(P001);
            
        }

        
    }
}
