using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DanhMuc.LIB;
using ModuleChiDaoTuyen.LIB;
using NETLINK.LIB;
using NETLINK.UI;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Authoration.LIB;

namespace ModuleChiDaoTuyen.UI
{
    public partial class PhieuKhaoSat : Dictionary
    {
        CDT_PhieuKhaoSat phieukhaosat;

        CDT_PhieuKhaoSat_KeHoachBM_Info kehoachBM;

        CDT_PhieuKhaoSat_ToChucTuyenTruoc_Info tochucTuyenTruoc;

        CDT_PhieuKhaoSat_DTSauDH_Info daotaoSauDH;


        int IdPhieuKhaoSat = -1;

        private FormMode mode;

        public PhieuKhaoSat(FormMode formmode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.mode = formmode;
            if (mode.IsInsert)
                phieukhaosat = CDT_PhieuKhaoSat.NewCDT_PhieuKhaoSat();
            else
            {
                phieukhaosat = CDT_PhieuKhaoSat.GetCDT_PhieuKhaoSat(mode.Id);
                IdPhieuKhaoSat = mode.Id;
            }
            bindingPhieuKhaoSat.DataSource = phieukhaosat;
        }

        #region Need to remove *************************************************************************************
        public PhieuKhaoSat()
        {
            InitializeComponent();
            ApplyAuthorizationRules();

            bindingPhieuKhaoSat.DataSource = phieukhaosat;

            // TODO for testing, remove later
        }

        // for edit
        public PhieuKhaoSat(int _id) {
            
            IdPhieuKhaoSat = _id;
            InitializeComponent();
            ApplyAuthorizationRules();

            phieukhaosat = CDT_PhieuKhaoSat.GetCDT_PhieuKhaoSat(_id);
            bindingPhieuKhaoSat.DataSource = phieukhaosat;
        }
        #endregion

        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole(" PhieuKhaoSat:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //btnDelete.Enabled = (Csla.ApplicationContext.User.IsInRole("PhieuKhaoSat:D")
            //|| Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }

        protected override void FormLoad()
        {
            try
            {
                if (IdPhieuKhaoSat != -1)
                {
                    phieukhaosat = CDT_PhieuKhaoSat.GetCDT_PhieuKhaoSat(IdPhieuKhaoSat);
                    bindingPhieuKhaoSat.DataSource = phieukhaosat;
                }

                // load binding data
                bindingVienKhoa.DataSource = DIC_VienKhoaPhong_Coll.GetDIC_VienKhoaPhong_Coll();
                bindingGoiKt.DataSource = CDT_GoiKT_Coll.GetCDT_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));


                // binding data for kehoachBM
                kehoachBM = CDT_PhieuKhaoSat_KeHoachBM_Info.NewCDT_PhieuKhaoSat_KeHoachBM_Info();
                bindingKehoachBMSingle.DataSource = kehoachBM;

                // bindind data for to chuc tuyen truoc
                tochucTuyenTruoc = CDT_PhieuKhaoSat_ToChucTuyenTruoc_Info.NewCDT_PhieuKhaoSat_ToChucTuyenTruoc_Info();
                bindingTochucTuyenDuoiSingle.DataSource = tochucTuyenTruoc;

                // binding data for dao tao sau dai hoc
                daotaoSauDH = CDT_PhieuKhaoSat_DTSauDH_Info.NewCDT_PhieuKhaoSat_DTSauDH_Info();
                bindingDTSauDHSingle.DataSource = daotaoSauDH;


                bindingBenhVienTuyenDuoi.DataSource = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();
                bindingChudeDaotao.DataSource = CDT_PhieuKhaoSat_ChuDeDaoTao_Coll.GetCDT_PhieuKhaoSat_ChuDeDaoTao_Coll();
                bindingLoaiHinhDaotao.DataSource = CDT_PhieuKhaoSat_LoaiHinhDaoTao_Coll.GetCDT_PhieuKhaoSat_LoaiHinhDaoTao_Coll();

                radPageViewkhaosat.SelectedPage = radPageViewPageThongtin;
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                if (ValidateThongTinChung())
                {
                    phieukhaosat.NamLapPhieu = DateTime.Now.Year;
                    phieukhaosat.IsBachMai = true;
                    phieukhaosat.ApplyEdit();
                    phieukhaosat.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Phiếu khảo sát");
                    this.Close();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }


        #endregion

        // for btnclick
        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach(RadPageViewPage c in radPageViewkhaosat.Pages)
            {
                if (c == radPageViewkhaosat.SelectedPage) {
                    bool shouldVisit = true;
                    // save before
                    if (index == 0) {
                        if (ValidateThongTinChung())
                        {
                            phieukhaosat.IsBachMai = true;
                            phieukhaosat.NamLapPhieu = DateTime.Now.Year;
                            phieukhaosat.ApplyEdit();
                            phieukhaosat = phieukhaosat.Save();
                            bindingPhieuKhaoSat.DataSource = phieukhaosat;
                        }
                        else {
                            shouldVisit = false;
                        }
                    }
                    if (shouldVisit)
                    {
                        if (index == radPageViewkhaosat.Pages.Count - 1)
                        {
                            index = 0;
                        }
                        else
                            index = index + 1;
                        radPageViewkhaosat.SelectedPage = radPageViewkhaosat.Pages[index];
                        radPageViewkhaosat.Select();

                        SetUpSelectedPage();
                    }
                    return;
                }
                index++;
            }
        }

        private void radPageViewkhaosat_SelectedPageChanging(object sender, Telerik.WinControls.UI.RadPageViewCancelEventArgs e)
        {
            
        }

        private void radPageViewkhaosat_SelectedPageChanged(object sender, EventArgs e)
        {
            SetUpSelectedPage();
        }

        private void SetUpSelectedPage() {
            if (radPageViewkhaosat.SelectedPage == radPageViewPageDaotaolientuc)
                setUpKeHoachBM();
            else if (radPageViewkhaosat.SelectedPage == radPageViewPageDaotao)
                setUpTochucTruyenTruoc();
            else if (radPageViewkhaosat.SelectedPage == radPageViewPageManganh)
                setUpSauDH();
        }

        #region ke hoach BM
        private void setUpKeHoachBM()
        {
            BusinessFunction function = new BusinessFunction (BusinessFunctionMode.GetDataForGridView);
            function.ItemID = phieukhaosat.ID;
            bindingKehoachBM.DataSource = CDT_PhieuKhaoSat_KeHoachBM_Coll.GetCDT_PhieuKhaoSat_KeHoachBM_Coll(function);
        }

        private void btnLuuKehoachDaotaolientuc_Click(object sender, EventArgs e)
        {
            if (ValidateDaotaoLientuc())
            {
                kehoachBM.IdPhieuKhaoSat = phieukhaosat.ID;
                CDT_PhieuKhaoSat_ChuDeDaoTao_Coll lstChuDeDaotao = (CDT_PhieuKhaoSat_ChuDeDaoTao_Coll)bindingChudeDaotao.DataSource;
                foreach (CDT_PhieuKhaoSat_ChuDeDaoTao_Info chude in lstChuDeDaotao)
                {
                    if (kehoachBM.IdChuDeDaoTao == chude.Id)
                    {
                        kehoachBM.ChuDeDaoTao = chude.Ten;
                        break;
                    }
                }
                try
                {
                    CDT_PhieuKhaoSat_KeHoachBM_Coll lstKehoachBM = (CDT_PhieuKhaoSat_KeHoachBM_Coll)bindingKehoachBM.DataSource;
                    if (kehoachBM.IsNew)
                        lstKehoachBM.Add(kehoachBM);
                    bindingKehoachBM.DataSource = lstKehoachBM.Save();
                }
                catch (Exception ex)
                { GlobalCommon.ShowErrorMessager(ex); }
            }
        }

        private void radGridViewKehoachBM_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (radGridViewKehoachBM.CurrentRow != null)
            {
                if (radGridViewKehoachBM.CurrentRow.Cells["Id"].Value != null)
                {
                    kehoachBM = (CDT_PhieuKhaoSat_KeHoachBM_Info)radGridViewKehoachBM.CurrentRow.DataBoundItem;
                    bindingKehoachBMSingle.DataSource = kehoachBM;
                }
            }
            else {
                kehoachBM = CDT_PhieuKhaoSat_KeHoachBM_Info.NewCDT_PhieuKhaoSat_KeHoachBM_Info();
                bindingKehoachBMSingle.DataSource = kehoachBM;
            }
        }

        private void btnKeHoachBMThemmoi_Click(object sender, EventArgs e)
        {
            kehoachBM = CDT_PhieuKhaoSat_KeHoachBM_Info.NewCDT_PhieuKhaoSat_KeHoachBM_Info();
            bindingKehoachBMSingle.DataSource = kehoachBM;
        }

        private void btnXoaKehoachBM_Click(object sender, EventArgs e)
        {
           try{
               if (radGridViewKehoachBM.CurrentRow.Cells["Id"].Value != null)
               {
                   if (GlobalCommon.AcceptDelete())
                   {
                       //CDT_PhieuKhaoSat_KeHoachBM.DeleteCDT_PhieuKhaoSat_KeHoachBM(id);
                       CDT_PhieuKhaoSat_KeHoachBM_Coll lstKehoachBM = (CDT_PhieuKhaoSat_KeHoachBM_Coll)bindingKehoachBM.DataSource;
                       //CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info removed = (CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info)radGridViewKehoachBM.CurrentRow.DataBoundItem;
                       lstKehoachBM.RemoveAt(radGridViewKehoachBM.CurrentRow.Index);
                       lstKehoachBM.Save();
                   }
               }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        #endregion

        # region Tochuctuyentruoc

        private void setUpTochucTruyenTruoc()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
            function.ItemID = phieukhaosat.ID;
            bindingTochucTuyenDuoi.DataSource = CDT_PhieuKhaoSat_ToChucTuyenTruoc_Coll.GetCDT_PhieuKhaoSat_ToChucTuyenTruoc_Coll(function);
        }

        private void btnThemTochuctuyentruoc_Click(object sender, EventArgs e)
        {
            tochucTuyenTruoc = CDT_PhieuKhaoSat_ToChucTuyenTruoc_Info.NewCDT_PhieuKhaoSat_ToChucTuyenTruoc_Info();
            bindingTochucTuyenDuoiSingle.DataSource = tochucTuyenTruoc;
        }

        private void btnLuutochuctuyentruoc_Click(object sender, EventArgs e)
        {
            if (ValidateDaotaoChinhQuy())
            {
                tochucTuyenTruoc.IdPhieuKhaoSat = phieukhaosat.ID;

                CDT_PhieuKhaoSat_ChuDeDaoTao_Coll lstChuDeDaotao = (CDT_PhieuKhaoSat_ChuDeDaoTao_Coll)bindingChudeDaotao.DataSource;
                foreach (CDT_PhieuKhaoSat_ChuDeDaoTao_Info chude in lstChuDeDaotao)
                {
                    if (tochucTuyenTruoc.IdChuDeDaoTao == chude.Id)
                    {
                        tochucTuyenTruoc.ChuDeDaoTao = chude.Ten;
                        break;
                    }
                }

                DIC_BenhVien_Coll lstBenhvien = (DIC_BenhVien_Coll)bindingBenhVienTuyenDuoi.DataSource;
                foreach (DIC_BenhVien_Info bv in lstBenhvien)
                {
                    if (tochucTuyenTruoc.IdBenhVien == bv.ID)
                    {
                        tochucTuyenTruoc.BenhVien = bv.Ten;
                        break;
                    }
                }


                try
                {
                    CDT_PhieuKhaoSat_ToChucTuyenTruoc_Coll lstTuyenDuoi = (CDT_PhieuKhaoSat_ToChucTuyenTruoc_Coll)bindingTochucTuyenDuoi.DataSource;
                    if (tochucTuyenTruoc.IsNew)
                    {
                        lstTuyenDuoi.Add(tochucTuyenTruoc);
                    }
                    bindingTochucTuyenDuoi.DataSource = lstTuyenDuoi.Save();
                }
                catch (Exception ex)
                { GlobalCommon.ShowErrorMessager(ex); }
            }
        }

        private void btnXoatochuctuyenduoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridViewTochucTuyenduoi.CurrentRow.Cells["Id"].Value != null)
                {
                    if (GlobalCommon.AcceptDelete())
                    {
                        CDT_PhieuKhaoSat_ToChucTuyenTruoc_Coll lstTuyenDuoi = (CDT_PhieuKhaoSat_ToChucTuyenTruoc_Coll)bindingTochucTuyenDuoi.DataSource;
                        lstTuyenDuoi.RemoveAt(radGridViewTochucTuyenduoi.CurrentRow.Index);
                        lstTuyenDuoi.Save();
                    }
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridViewTochucTuyenduoi_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (radGridViewTochucTuyenduoi.CurrentRow != null)
            {
                if (radGridViewTochucTuyenduoi.CurrentRow.Cells["Id"].Value != null)
                {
                    tochucTuyenTruoc = (CDT_PhieuKhaoSat_ToChucTuyenTruoc_Info)radGridViewTochucTuyenduoi.CurrentRow.DataBoundItem;
                    bindingTochucTuyenDuoiSingle.DataSource = tochucTuyenTruoc;
                }
            }
            else {
                tochucTuyenTruoc = CDT_PhieuKhaoSat_ToChucTuyenTruoc_Info.NewCDT_PhieuKhaoSat_ToChucTuyenTruoc_Info();
                bindingTochucTuyenDuoiSingle.DataSource = tochucTuyenTruoc; 
            }
        }
        #endregion

        #region Dao tao Sau DH
        
        private void setUpSauDH()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
            function.ItemID = phieukhaosat.ID;
            bindingDTSauDH.DataSource = CDT_PhieuKhaoSat_DTSauDH_Coll.GetCDT_PhieuKhaoSat_DTSauDH_Coll(function);
        }
        private void btnThemSauDH_Click(object sender, EventArgs e)
        {
            daotaoSauDH = CDT_PhieuKhaoSat_DTSauDH_Info.NewCDT_PhieuKhaoSat_DTSauDH_Info();
            bindingDTSauDHSingle.DataSource = daotaoSauDH;
            
        }

        private void btnLuuDaotaoSaudaihoc_Click(object sender, EventArgs e)
        {
            if (ValidateDangKyMaNganh())
            {
                daotaoSauDH.IdPhieuKhaoSat = phieukhaosat.ID;
                try
                {
                    CDT_PhieuKhaoSat_LoaiHinhDaoTao_Coll lstLoaihinh = (CDT_PhieuKhaoSat_LoaiHinhDaoTao_Coll)bindingLoaiHinhDaotao.DataSource;
                    foreach (CDT_PhieuKhaoSat_LoaiHinhDaoTao_Info loaihinh in lstLoaihinh)
                    {
                        if (daotaoSauDH.IdLoaiHinhDaoTao == loaihinh.Id)
                        {
                            daotaoSauDH.LoaiHinhDaoTao = loaihinh.Ten;
                            break;
                        }
                    }

                    CDT_PhieuKhaoSat_DTSauDH_Coll lstBindingDTSauDH = (CDT_PhieuKhaoSat_DTSauDH_Coll)bindingDTSauDH.DataSource;

                    if (daotaoSauDH.IsNew)
                        lstBindingDTSauDH.Add(daotaoSauDH);
                    bindingDTSauDH.DataSource = lstBindingDTSauDH.Save();

                }
                catch (Exception ex)
                { GlobalCommon.ShowErrorMessager(ex); }
            }
        }

        private void btnXoaSauDaihoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridViewDaoTaoSauDH.CurrentRow.Cells["id"].Value != null)
                {
                    if (GlobalCommon.AcceptDelete())
                    {
                        CDT_PhieuKhaoSat_DTSauDH_Coll lstBindingDTSauDH = (CDT_PhieuKhaoSat_DTSauDH_Coll)bindingDTSauDH.DataSource;
                        lstBindingDTSauDH.RemoveAt(radGridViewDaoTaoSauDH.CurrentRow.Index);
                        lstBindingDTSauDH.Save();
                    }
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        

        private void radGridViewDaoTaoSauDH_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (radGridViewDaoTaoSauDH.CurrentRow != null)
            {
                if (radGridViewDaoTaoSauDH.CurrentRow.Cells["Id"].Value != null)
                {
                    daotaoSauDH = (CDT_PhieuKhaoSat_DTSauDH_Info)radGridViewDaoTaoSauDH.CurrentRow.DataBoundItem;
                    bindingDTSauDHSingle.DataSource = daotaoSauDH;
                }
            }
            else {
                daotaoSauDH = CDT_PhieuKhaoSat_DTSauDH_Info.NewCDT_PhieuKhaoSat_DTSauDH_Info();
                bindingDTSauDHSingle.DataSource = daotaoSauDH;
            }
        }
        #endregion


        #region list gridview
        //CDT_PhieuKhaoSat_KeHoachBM_Coll mListPhieuKhaoSat_KeHoachBM;
        #endregion

        #region Validate data
        
        private bool ValidateThongTinChung()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { txtCongVan.Text, radDropDownList9.Text, txtTenPhuTrachDT.Text, txtHotenCanBoPhuTrachTT.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        private bool ValidateDaotaoLientuc() 
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radDropDownListKehoachBMChude.Text, dropDownDoiTuongKehoachBM.Text, txtThoiLuongDaoTaoLientuc.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        private bool ValidateDaotaoChinhQuy()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radDropDownListBenhVienTuyenDuoi.Text, dropDownDoiTuongTuyenDuoi.Text, radDropDownListTochuctuyenduoiTenLinhvuc.Text, txtKehoachDTThoiluong.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        private bool ValidateDangKyMaNganh()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radDropDownListLoaiHinhDaotao.Text, txtChitieuDaotaoSauDH.Text}))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        #endregion
    }
}
