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
    public partial class PhieuKhaoSatTuyenTruoc : Dictionary
    {
        CDT_PhieuKhaoSat phieukhaosat;

        CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info daotaoLientucBM;

        CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info daotaoLientucTaicho;

        CDT_PhieuKhaoSat_DeAn1816_Info dean1816;

        CDT_PhieuKhaoSat_YeuCauHoTro_Info yeucaukhac;

        CDT_PhieuKhaoSat_YeuCauHoTro_Coll lstYeucauKhac;

        CDT_PhieuKhaoSat_DaoTaoChinhQuy_Info daotaoChinhQuy;

        int IdPhieuKhaoSat = -1;

        private FormMode mode;

        public PhieuKhaoSatTuyenTruoc(FormMode formmode)
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
        public PhieuKhaoSatTuyenTruoc()
        {
            InitializeComponent();
            ApplyAuthorizationRules();

            bindingPhieuKhaoSat.DataSource = phieukhaosat;

            // TODO for testing, remove later
        }

        // for edit
        public PhieuKhaoSatTuyenTruoc(int _id) {
            
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
                //bindingGoiKt.DataSource = CDT_GoiKT_Coll.GetCDT_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));


                // binding data for daotaoLienTucBM
                daotaoLientucBM = CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info.NewCDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info();
                bindingSourceDaotaoLienTucBVBM.DataSource = daotaoLientucBM;

                // bindind data for to chuc tuyen truoc
                daotaoLientucTaicho = CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info.NewCDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info();
                bindingSourceDaotaolientuctaicho.DataSource = daotaoLientucTaicho;


                // binding data for DeAn1816
                dean1816 = CDT_PhieuKhaoSat_DeAn1816_Info.NewCDT_PhieuKhaoSat_DeAn1816_Info();
                bindingSourceDeAn1816.DataSource = dean1816;

                // binding data for chinh quy
                daotaoChinhQuy = CDT_PhieuKhaoSat_DaoTaoChinhQuy_Info.NewCDT_PhieuKhaoSat_DaoTaoChinhQuy_Info();
                bindingSourceDaotaochinhquySingle.DataSource = daotaoChinhQuy;

                bindingBenhVienTuyenDuoi.DataSource = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();
                bindingChudeDaotao.DataSource = CDT_PhieuKhaoSat_ChuDeDaoTao_Coll.GetCDT_PhieuKhaoSat_ChuDeDaoTao_Coll();
                bindingLoaiHinhDaotao.DataSource = CDT_PhieuKhaoSat_LoaiHinhDaoTao_Coll.GetCDT_PhieuKhaoSat_LoaiHinhDaoTao_Coll();
                cDTGoiKTBindingSource.DataSource = CDT_GoiKT_Coll.GetCDT_GoiKT_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                bindingSourceChuyenganh.DataSource = CDT_PhieuKhaoSat_ChuyenNganhHoc_Coll.GetCDT_PhieuKhaoSat_ChuyenNganhHoc_Coll();

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
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Phiếu khảo sát tuyến trước");
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

                    bool shouldbeContinue = true;
                    // save before
                    if (index == 0) {
                        if (ValidateThongTinChung())
                        {
                            phieukhaosat.IsBachMai = false;
                            phieukhaosat.NamLapPhieu = DateTime.Now.Year;
                            phieukhaosat.ApplyEdit();
                            phieukhaosat = phieukhaosat.Save();
                            bindingPhieuKhaoSat.DataSource = phieukhaosat;
                        }
                        else {
                            shouldbeContinue = false;
                        }

                    }

                    if (shouldbeContinue)
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
            if (radPageViewkhaosat.SelectedPage == radPageViewPageDangKyDaotaoLientuc)
                setUpdaotaoLientucBM();
            else if (radPageViewkhaosat.SelectedPage == radPageViewPageDaotaoLientucTaicho)
                setUpDaotaoLientuctaicho();
            else if (radPageViewkhaosat.SelectedPage == radPageViewPageDean1816)
                setUpDeAn1618();
            else if (radPageViewkhaosat.SelectedPage == radPageViewPageYeuCau)
                setupYeucauHotro();
            else if (radPageViewkhaosat.SelectedPage == radPageViewPageDaotaoChinhquy)
                setupDaotaoChinhquy();
        }

        #region Dao tao lien tuc bv BM
        private void setUpdaotaoLientucBM()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
            function.ItemID = phieukhaosat.ID;
            bindingSourceDaotaoLienTucBVBMList.DataSource = CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Coll.GetCDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Coll(function);
        }

        private void btnLuuKehoachDaotaolientuc_Click(object sender, EventArgs e)
        {
            if (ValidateDangKyDaoTaoLienTuc())
            {
                daotaoLientucBM.IdPhieuKhaoSat = phieukhaosat.ID;

                CDT_PhieuKhaoSat_ChuDeDaoTao_Coll lstChuDeDaotao = (CDT_PhieuKhaoSat_ChuDeDaoTao_Coll)bindingChudeDaotao.DataSource;
                foreach (CDT_PhieuKhaoSat_ChuDeDaoTao_Info chude in lstChuDeDaotao)
                {
                    if (daotaoLientucBM.IdChuDeDaoTao == chude.Id)
                    {
                        daotaoLientucBM.ChuDeDaoTao = chude.Ten;
                        break;
                    }
                }

                try
                {
                    CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Coll lstDaotaoLientucBM = (CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Coll)bindingSourceDaotaoLienTucBVBMList.DataSource;
                    if (daotaoLientucBM.IsNew)
                    {

                        lstDaotaoLientucBM.Add(daotaoLientucBM);

                    }

                    bindingSourceDaotaoLienTucBVBMList.DataSource = lstDaotaoLientucBM.Save();
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
                    daotaoLientucBM = (CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info)e.CurrentRow.DataBoundItem;
                    bindingSourceDaotaoLienTucBVBM.DataSource = daotaoLientucBM;
                }
            }
            else {
                daotaoLientucBM = CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info.NewCDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info();
                bindingSourceDaotaoLienTucBVBM.DataSource = daotaoLientucBM;
            }
        }

        private void btnKeHoachBMThemmoi_Click(object sender, EventArgs e)
        {
            daotaoLientucBM = CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info.NewCDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info();
            bindingSourceDaotaoLienTucBVBM.DataSource = daotaoLientucBM;
        }

        private void btnXoaKehoachBM_Click(object sender, EventArgs e)
        {
           try{
               if (radGridViewKehoachBM.CurrentRow.Cells["Id"].Value != null)
               {
                   int id = Convert.ToInt32(radGridViewKehoachBM.CurrentRow.Cells["ID"].Value);
                   if (GlobalCommon.AcceptDelete())
                   {
                       //CDT_PhieuKhaoSat_KeHoachBM.DeleteCDT_PhieuKhaoSat_KeHoachBM(id);
                       CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Coll lstDaotaoLientucBM = (CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Coll)bindingSourceDaotaoLienTucBVBMList.DataSource;
                        //CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info removed = (CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info)radGridViewKehoachBM.CurrentRow.DataBoundItem;
                        lstDaotaoLientucBM.RemoveAt(radGridViewKehoachBM.CurrentRow.Index);
                        lstDaotaoLientucBM.Save();
                   }
               }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        #endregion

        # region Dao tao lien tuc tai cho

        private void setUpDaotaoLientuctaicho()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
            function.ItemID = phieukhaosat.ID;
            bindingSourceDaotaolientuctaichoList.DataSource = CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Coll.GetCDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Coll(function);
        }

        private void btnThemTochuctuyentruoc_Click(object sender, EventArgs e)
        {
            daotaoLientucTaicho = CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info.NewCDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info();
            bindingSourceDaotaolientuctaicho.DataSource = daotaoLientucTaicho;
        }

        private void btnLuutochuctuyentruoc_Click(object sender, EventArgs e)
        {
            if (ValidateDangKyDaoTaoTaiCho())
            {
                bindDataForDaoTaoTaiCho(true);
                daotaoLientucTaicho.IdPhieuKhaoSat = phieukhaosat.ID;

                CDT_PhieuKhaoSat_ChuDeDaoTao_Coll lstChuDeDaotao = (CDT_PhieuKhaoSat_ChuDeDaoTao_Coll)bindingChudeDaotao.DataSource;
                foreach (CDT_PhieuKhaoSat_ChuDeDaoTao_Info chude in lstChuDeDaotao)
                {
                    if (daotaoLientucBM.IdChuDeDaoTao == chude.Id)
                    {
                        daotaoLientucBM.ChuDeDaoTao = chude.Ten;
                        break;
                    }
                }

                try
                {
                    CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Coll lstDaotaoLientucTaicho = (CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Coll)bindingSourceDaotaolientuctaichoList.DataSource;
                    if (daotaoLientucTaicho.IsNew)
                    {

                        lstDaotaoLientucTaicho.Add(daotaoLientucTaicho);

                    }

                    bindingSourceDaotaolientuctaichoList.DataSource = lstDaotaoLientucTaicho.Save();
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
                        //CDT_PhieuKhaoSat_KeHoachBM.DeleteCDT_PhieuKhaoSat_KeHoachBM(id);
                        CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Coll lstDaotaoLientucTaicho = (CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Coll)bindingSourceDaotaolientuctaichoList.DataSource;
                        //CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info removed = (CDT_PhieuKhaoSat_DaoTaoLienTucBVBM_Info)radGridViewKehoachBM.CurrentRow.DataBoundItem;
                        lstDaotaoLientucTaicho.RemoveAt(radGridViewTochucTuyenduoi.CurrentRow.Index);
                        lstDaotaoLientucTaicho.Save();
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
                    daotaoLientucTaicho = (CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info)e.CurrentRow.DataBoundItem;
                    bindDataForDaoTaoTaiCho(false);
                    bindingSourceDaotaolientuctaicho.DataSource = daotaoLientucTaicho;
                }
            }
            else
            {
                daotaoLientucTaicho = CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info.NewCDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info();
                bindingSourceDaotaolientuctaicho.DataSource = daotaoLientucTaicho;
            }
        }
        #endregion

        #region Dean 1618
        private void btnThemDeAn1816_Click(object sender, EventArgs e)
        {
            dean1816 = CDT_PhieuKhaoSat_DeAn1816_Info.NewCDT_PhieuKhaoSat_DeAn1816_Info();
            bindingSourceDeAn1816.DataSource = dean1816;
        }

        private void btnLuuDeAn1816_Click(object sender, EventArgs e)
        {
            if (ValidateForDeAn1816())
            {
                dean1816.IdPhieuKhaoSat = phieukhaosat.ID;
                CDT_GoiKT_Coll lsGoiKythuat = (CDT_GoiKT_Coll)cDTGoiKTBindingSource.DataSource;
                foreach (CDT_GoiKT_Info goiKythuat in lsGoiKythuat)
                {
                    if (dean1816.IdGoiKyThuat == goiKythuat.ID)
                    {
                        dean1816.GoiKyThuat = goiKythuat.TenGoiKT;
                        break;
                    }
                }
                try
                {
                    CDT_PhieuKhaoSat_DeAn1816_Coll lstDeAn1816 = (CDT_PhieuKhaoSat_DeAn1816_Coll)cDTPhieuKhaoSatDeAn1816CollBindingSource.DataSource;
                    if (dean1816.IsNew)
                    {

                        lstDeAn1816.Add(dean1816);

                    }

                    lstDeAn1816 = lstDeAn1816.Save();
                    cDTPhieuKhaoSatDeAn1816CollBindingSource.DataSource = lstDeAn1816;
                }
                catch (Exception ex)
                { GlobalCommon.ShowErrorMessager(ex); }
            }
        }

        private void btnXoaDeAn1816_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridViewDeAn1816.CurrentRow.Cells["Id"].Value != null)
                {
                    if (GlobalCommon.AcceptDelete())
                    {
                        CDT_PhieuKhaoSat_DeAn1816_Coll lstDeAn1816 = (CDT_PhieuKhaoSat_DeAn1816_Coll)cDTPhieuKhaoSatDeAn1816CollBindingSource.DataSource;
                        lstDeAn1816.RemoveAt(radGridViewDeAn1816.CurrentRow.Index);
                        lstDeAn1816.Save();
                    }
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridViewDeAn1816_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (radGridViewDeAn1816.CurrentRow != null)
            {
                if (radGridViewDeAn1816.CurrentRow.Cells["Id"].Value != null)
                {
                    dean1816 = (CDT_PhieuKhaoSat_DeAn1816_Info)radGridViewDeAn1816.CurrentRow.DataBoundItem;
                    bindingSourceDeAn1816.DataSource = dean1816;
                }
            }
            else {
                dean1816 = CDT_PhieuKhaoSat_DeAn1816_Info.NewCDT_PhieuKhaoSat_DeAn1816_Info();
                bindingSourceDeAn1816.DataSource = dean1816;
            }
        }

        private void setUpDeAn1618() {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
            function.ItemID = phieukhaosat.ID;
            cDTPhieuKhaoSatDeAn1816CollBindingSource.DataSource = CDT_PhieuKhaoSat_DeAn1816_Coll.GetCDT_PhieuKhaoSat_DeAn1816_Coll(function);
        }

        #endregion

        private void radDropDownListKehoachBMChude_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        private void txtDonviPhoiHopDaoTaolientuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKehoachDTDoituong_TextChanged(object sender, EventArgs e)
        {

        }

        private void radDropDownListDeAn1816ChuDe_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {

        }

        #region Yeu cau khac

        private void radButtonLuuYeuCau_Click(object sender, EventArgs e)
        {
            try
            {
                if (radCheckBoxYeuCau1.Checked)
                {
                    yeucaukhac.YeuCauHoTro1 = radCheckBoxYeuCau1.Text;
                }
                else
                {
                    yeucaukhac.YeuCauHoTro1 = string.Empty;
                }

                if (radCheckBoxYeucau2.Checked)
                {
                    yeucaukhac.YeuCauHoTro2 = radCheckBoxYeucau2.Text;
                }
                else
                {
                    yeucaukhac.YeuCauHoTro2 = string.Empty;
                }

                if (radCheckBoxYeucau3.Checked)
                {
                    yeucaukhac.YeuCauHoTro3 = radCheckBoxYeucau3.Text;
                }
                else
                {
                    yeucaukhac.YeuCauHoTro3 = string.Empty;
                }

                if (radCheckBoxYeuCau4.Checked)
                {
                    yeucaukhac.YeuCauHoTro4 = radCheckBoxYeuCau4.Text;
                }
                else
                {
                    yeucaukhac.YeuCauHoTro4 = string.Empty;
                }

                if (radCheckBoxYeucau5.Checked)
                {
                    yeucaukhac.YeuCauHoTro5 = radCheckBoxYeucau5.Text;
                }
                else
                {
                    yeucaukhac.YeuCauHoTro5 = string.Empty;
                }

                if (radCheckBoxYeucau6.Checked)
                {
                    yeucaukhac.YeuCauHoTro6 = radCheckBoxYeucau6.Text;
                }
                else
                {
                    yeucaukhac.YeuCauHoTro6 = string.Empty;
                }

                if (radCheckBoxYeucau7.Checked)
                {
                    yeucaukhac.YeuCauHoTro7 = radCheckBoxYeucau7.Text;
                }
                else
                {
                    yeucaukhac.YeuCauHoTro7 = string.Empty;
                }
                yeucaukhac.YeuCauHoTro8 = radTextBoxYecau.Text;
                yeucaukhac.YeuCauHoTro8 = radTextBoxYecau.Text;
                yeucaukhac.IdPhieuKhaoSat = phieukhaosat.ID;
                lstYeucauKhac.Save();
            }
            catch (Exception ex) {
                GlobalCommon.ShowErrorMessager(ex); 
            }
        }

        private void setupYeucauHotro() 
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
            function.ItemID = phieukhaosat.ID;

            lstYeucauKhac = CDT_PhieuKhaoSat_YeuCauHoTro_Coll.GetCDT_PhieuKhaoSat_YeuCauHoTro_Coll(function);
            if (lstYeucauKhac != null && lstYeucauKhac.Count > 0)
            {
                yeucaukhac = lstYeucauKhac[0];
                radTextBoxYecau.Text = yeucaukhac.YeuCauHoTro8;

                if (yeucaukhac.CoYeuCauHoTro1)
                {
                    radCheckBoxYeuCau1.Checked = true;
                }
                else
                {
                    radCheckBoxYeuCau1.Checked = false;
                }

                if (yeucaukhac.CoYeuCauHoTro2)
                {
                    radCheckBoxYeucau2.Checked = true;
                }
                else
                {
                    radCheckBoxYeucau2.Checked = false;
                }

                if (yeucaukhac.CoYeuCauHoTro3)
                {
                    radCheckBoxYeucau3.Checked = true;
                }
                else
                {
                    radCheckBoxYeucau3.Checked = false;
                }

                if (yeucaukhac.CoYeuCauHoTro4)
                {
                    radCheckBoxYeuCau4.Checked = true;
                }
                else
                {
                    radCheckBoxYeuCau4.Checked = false;
                }

                if (yeucaukhac.CoYeuCauHoTro5)
                {
                    radCheckBoxYeucau5.Checked = true;
                }
                else
                {
                    radCheckBoxYeucau5.Checked = false;
                }

                if (yeucaukhac.CoYeuCauHoTro6)
                {
                    radCheckBoxYeucau6.Checked = true;
                }
                else
                {
                    radCheckBoxYeucau6.Checked = false;
                }

                if (yeucaukhac.CoYeuCauHoTro7)
                {
                    radCheckBoxYeucau7.Checked = true;
                }
                else
                {
                    radCheckBoxYeucau7.Checked = false;
                }
            }
            else
            {
                lstYeucauKhac = CDT_PhieuKhaoSat_YeuCauHoTro_Coll.NewCDT_PhieuKhaoSat_YeuCauHoTro_Coll();
                yeucaukhac = CDT_PhieuKhaoSat_YeuCauHoTro_Info.NewCDT_PhieuKhaoSat_YeuCauHoTro_Info();
                lstYeucauKhac.Add(yeucaukhac);
            }
        }

        #endregion

        #region Chinh quy



        private void radButtonThemChinhquy_Click(object sender, EventArgs e)
        {
            daotaoChinhQuy = CDT_PhieuKhaoSat_DaoTaoChinhQuy_Info.NewCDT_PhieuKhaoSat_DaoTaoChinhQuy_Info();
            bindingSourceDaotaochinhquySingle.DataSource = daotaoChinhQuy;
        }

        private void radButtonLuuChinhQuy_Click(object sender, EventArgs e)
        {
            daotaoChinhQuy.IdPhieuKhaoSat = phieukhaosat.ID;
            CDT_PhieuKhaoSat_ChuyenNganhHoc_Coll lsChuyennganh = (CDT_PhieuKhaoSat_ChuyenNganhHoc_Coll)bindingSourceChuyenganh.DataSource;
            foreach (CDT_PhieuKhaoSat_ChuyenNganhHoc_Info chuyennganh in lsChuyennganh)
            {
                if (daotaoChinhQuy.IdChuyennganhHoc == chuyennganh.Id)
                {
                    daotaoChinhQuy.ChuyennganhHoc = chuyennganh.TenChuyenNganh;
                    break;
                }
            }
            try
            {
                CDT_PhieuKhaoSat_DaoTaoChinhQuy_Coll lstDaotaoChinhquy = (CDT_PhieuKhaoSat_DaoTaoChinhQuy_Coll)bindingSourceDaotaochinhquy.DataSource;
                if (daotaoChinhQuy.IsNew)
                {

                    lstDaotaoChinhquy.Add(daotaoChinhQuy);

                }

                bindingSourceDaotaochinhquy.DataSource = lstDaotaoChinhquy.Save();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radButtonXoaCQ_Click(object sender, EventArgs e)
        {
            if (radGridView1.CurrentRow.Cells["Id"].Value != null)
            {
                if (GlobalCommon.AcceptDelete())
                {
                    CDT_PhieuKhaoSat_DaoTaoChinhQuy_Coll lstDaotaoChinhquy = (CDT_PhieuKhaoSat_DaoTaoChinhQuy_Coll)bindingSourceDaotaochinhquy.DataSource;
                    lstDaotaoChinhquy.RemoveAt(radGridView1.CurrentRow.Index);
                    lstDaotaoChinhquy.Save();
                }
            }
        }

        private void radGridView1_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
        {
            if (radGridView1.CurrentRow != null)
            {
                if (radGridView1.CurrentRow.Cells["Id"].Value != null)
                {
                    daotaoChinhQuy = (CDT_PhieuKhaoSat_DaoTaoChinhQuy_Info)radGridView1.CurrentRow.DataBoundItem;
                    bindingSourceDaotaochinhquySingle.DataSource = daotaoChinhQuy;
                }
            }
            else
            {
                daotaoChinhQuy = CDT_PhieuKhaoSat_DaoTaoChinhQuy_Info.NewCDT_PhieuKhaoSat_DaoTaoChinhQuy_Info();
                bindingSourceDaotaochinhquySingle.DataSource = daotaoChinhQuy;
            }
        }

        private void setupDaotaoChinhquy()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridView);
            function.ItemID = phieukhaosat.ID;
            bindingSourceDaotaochinhquy.DataSource = CDT_PhieuKhaoSat_DaoTaoChinhQuy_Coll.GetCDT_PhieuKhaoSat_DaoTaoChinhQuy_Coll(function);
        }

        #endregion

        #region list gridview
        //CDT_PhieuKhaoSat_KeHoachBM_Coll mListPhieuKhaoSat_KeHoachBM;
        #endregion

        #region Validate Data
        public bool ValidateThongTinChung() {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { txtCongVan.Text, radDropDownListBenhvien.Text, txtTenPhuTrachDT.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        public bool ValidateDangKyDaoTaoLienTuc()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radDropDownListKehoachBMChude.Text, dropDownDoiTuongDTLTBM.Text, txtThoiLuongDaoTaoLientuc.Text, txtDonviPhoiHopDaoTaolientuc.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        public bool ValidateDangKyDaoTaoTaiCho() 
        {
            if (!netLink_DatePickerNgayBatDauTaiCho.isDateTime && !netLink_DatePickerNgayBatDauTaiCho.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayBatDauTaiCho.Value_Error);
                return false;
            }
            if (!netLink_DatePickerNgayKetThucTaiCho.isDateTime && !netLink_DatePickerNgayKetThucTaiCho.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayKetThucTaiCho.Value_Error);
                return false;
            }

            if (GlobalCommon.CheckDateMustBeEarilierThanOther(netLink_DatePickerNgayKetThucTaiCho.Value_String, netLink_DatePickerNgayBatDauTaiCho.Value_String))
            {
                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, netLink_DatePickerNgayKetThucTaiCho.MyName, netLink_DatePickerNgayBatDauTaiCho.MyName));
                return false;
            }

            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radDropDownListTochuctuyenduoiTenLinhvuc.Text, txtKehoachDTDoituong.Text, radTextBoxCanBoCanDaotaoDDKTV.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true; 
        }

        private void bindDataForDaoTaoTaiCho(bool isNew) {
            if (isNew)
            {
                daotaoLientucTaicho.ThoiGianBatDau = netLink_DatePickerNgayBatDauTaiCho.Value_String;
                daotaoLientucTaicho.ThoiGianKetThuc = netLink_DatePickerNgayKetThucTaiCho.Value_String;
            }
            else {
                netLink_DatePickerNgayBatDauTaiCho.Value_String = daotaoLientucTaicho.ThoiGianBatDau;
                netLink_DatePickerNgayKetThucTaiCho.Value_String = daotaoLientucTaicho.ThoiGianKetThuc;
            }
        }

        private bool ValidateForDeAn1816() 
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radDropDownListDeAn1816ChuDe.Text, txtSoluongBsDH.Text, txtSoluongĐDKTV.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;  
        }

        private bool ValidateForDangKyDaoTaoChinhQuy()
        {
            if (GlobalCommon.CheckArrayTextIsNull(new string[] { radDropDownListChuyennganh.Text, radTextBoxSoLuongCanBo.Text}))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }

        #endregion
    }
}
