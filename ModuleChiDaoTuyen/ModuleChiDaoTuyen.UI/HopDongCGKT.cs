//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using Authoration.LIB;
//using DanhMuc.LIB;
//using ModuleChiDaoTuyen.LIB;
//using NETLINK.LIB;
//using NETLINK.UI;
//using Telerik.WinControls;
//using Telerik.WinControls.Data;
//using Telerik.WinControls.UI;

//namespace ModuleChiDaoTuyen.UI
//{
//    public partial class HopDongCGKT : Dictionary
//    {
//        string IDhopdong = string.Empty;
//        CDT_HopDongCGKT hopdong;

//        CDT_HopDong_GoiKT_Info hopdongGKT;

//        CDT_CanBoNhanCGKT_Info canbonhanCG;

//        CDT_HopDong_GoiKT_CanBoTrienKhai_Info canboTrienKhai;

//        private FormMode mode;

//        public HopDongCGKT(FormMode formmode)
//        {
//            InitializeComponent();
//            ApplyAuthorizationRules();
//            VNRadGridLP.CurrentProvider = new VNRadGridLP();



//            this.mode = formmode;
//            if (mode.IsInsert)
//            {
//                hopdong = CDT_HopDongCGKT.NewCDT_HopDongCGKT();
//            }
//            else
//            {
//                IDhopdong = mode.StringId;
//                //hopdong = CDT_HopDongCGKT.GetCDT_HopDongCGKT(IDhopdong);

//            }
//            bindingHopDong.DataSource = hopdong;
//        }

//        public HopDongCGKT()
//        {
//            InitializeComponent();
//            ApplyAuthorizationRules();
//            VNRadGridLP.CurrentProvider = new VNRadGridLP();
//            hopdong = CDT_HopDongCGKT.NewCDT_HopDongCGKT();
//            bindingHopDong.DataSource = hopdong;
//        }

//        public HopDongCGKT(string _Id)
//        {
//            IDhopdong = _Id;
//            InitializeComponent();
//            ApplyAuthorizationRules();
//            hopdong = CDT_HopDongCGKT.GetCDT_HopDongCGKT(_Id);
//        }

//        #region Override

//        protected override void ApplyAuthorizationRules()
//        {
//            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:I")
//            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
//            btnContinue.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:D")
//            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
//            HopDong_Activated(this, EventArgs.Empty);
//        }

//        protected override void FormLoad()
//        {
//            try
//            {
//                if (!string.IsNullOrEmpty(IDhopdong))
//                {
//                    hopdong = CDT_HopDongCGKT.GetCDT_HopDongCGKT(IDhopdong);
//                    bindingHopDong.DataSource = hopdong;
//                    netLink_DatePickerNgayKyKet.Value_String = hopdong.NgayKiKet;

//                    if (hopdong.DaThanhLy != null)
//                        radCheckBoxDaThanhLy.Checked = (bool)hopdong.DaThanhLy;
//                }

//                // setup combobox
//                dICBenhVienBindingSource.DataSource = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();

//                // binding for hopdong goi ky thuat
//                hopdongGKT = CDT_HopDong_GoiKT_Info.NewCDT_HopDong_GoiKT_Info();
//                bindingHopdongGktSingle.DataSource = hopdongGKT;

//                // binding for canbo nhan chuyen giao
//                canbonhanCG = CDT_CanBoNhanCGKT_Info.NewCDT_CanBoNhanCGKT_Info();
//                bindingCanbonhanCGSingle.DataSource = canbonhanCG;

//                // binding for can bo trien khai
//                canboTrienKhai = CDT_HopDong_GoiKT_CanBoTrienKhai_Info.NewCDT_HopDong_GoiKT_CanBoTrienKhai_Info();
//                bindingCanboTrienKhaiSingle.DataSource = canboTrienKhai;


//                // for goi kt
//                dropDownGoiKyThuat1.FillData();

//                // binding for chuyen nganh
//                bindingLoaihinhchuyengiao.DataSource = CDT_LoaiHinhChuyenGiao_Coll.GetCDT_LoaiHinhChuyenGiao_Coll();

//                // binding for chuc vu
//                bindingChucvu.DataSource = DIC_ChucVu_Coll.GetDIC_ChucVu_Coll();

//                // binding for chuyen nganh
//                bindingChuyennganh.DataSource = DIC_ChuyenNganh_Coll.GetDIC_ChuyenNganh_Coll();

//                // binding for canbo
//                bindingCanbo.DataSource = DIC_CanBo_Coll.GetDIC_CanBo_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));

//                // for all text
//                dropDownGoiKyThuat2.FillData(hopdong.ID);
//                dropDownGoiKyThuat3.FillData(dropDownGoiKyThuat2.GetListData().Clone());

//                // for benh vien
//                dropDownBenhVien1.FillData();
//                dropDownBenhVien2.FillData(dropDownBenhVien1.GetListData().Clone());

//                if (!string.IsNullOrEmpty(IDhopdong))
//                {
//                    DIC_BenhVien_Coll benhvien = dropDownBenhVien1.GetListData();
//                    for (int i = 0; i < benhvien.Count; i++)
//                    {
//                        if (benhvien[i].ID == hopdong.B_idBenhVien)
//                            dropDownBenhVien2.SelectedIndex = i;
//                        if (benhvien[i].ID == hopdong.A_idBenhVien)
//                            dropDownBenhVien1.SelectedIndex = i;
//                    }
//                }

//                // binding for trinh do
//                dropDownTrinhDo.FillData();

//                // binding dropdown goi ky thuat
//                dropDownGoiKyThuat2.FillData(hopdong.ID);
//                dropDownGoiKyThuat3.FillData(dropDownGoiKyThuat2.GetListData().Clone());

//                radPageViewHopdong.SelectedPage = radPageViewPageThongTin;
//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }


//        protected override void Save()
//        {
//            try
//            {
//                if (ValidateDataThongTinHopDong())
//                {
//                    ConstructHopdong();
//                    hopdong.ApplyEdit();
//                    hopdong.ApplyEdit();
//                    hopdong.Save();
//                    this.Close();
//                }
//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }



//        #endregion

//        private void ConstructHopdong()
//        {
//            DIC_BenhVien_Info benhvienA = (DIC_BenhVien_Info)dropDownBenhVien1.Selected_Item;
//            DIC_BenhVien_Info benhbienB = (DIC_BenhVien_Info)dropDownBenhVien1.Selected_Item;
//            if (benhvienA != null)
//                hopdong.A_idBenhVien = benhvienA.ID;
//            if (benhbienB != null)
//                hopdong.B_idBenhVien = benhbienB.ID;

//            hopdong.DaThanhLy = radCheckBoxDaThanhLy.Checked;
//            hopdong.NgayKiKet = netLink_DatePickerNgayKyKet.Value_String;

//        }

//        private void Click_Delete(object sender, EventArgs e)
//        {
//            try
//            {
//                if (GlobalCommon.AcceptDelete())
//                {
//                    CDT_HopDongCGKT.DeleteCDT_HopDongCGKT(IDhopdong);
//                    this.Close();
//                }
//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }

//        private void HopDong_Activated(object sender, EventArgs e)
//        {

//        }

//        private void btnContinue_Click(object sender, EventArgs e)
//        {
//            int index = 0;
//            foreach (RadPageViewPage c in radPageViewHopdong.Pages)
//            {
//                if (c == radPageViewHopdong.SelectedPage)
//                {
//                    bool shouldContinue = true;
//                    // save before
//                    if (index == 0)
//                    {
//                        if (ValidateDataThongTinHopDong())
//                        {
//                            ConstructHopdong();
//                            hopdong.ApplyEdit();
//                            hopdong = hopdong.Save();
//                            bindingHopDong.DataSource = hopdong;
//                        }
//                        else
//                        {
//                            shouldContinue = false;
//                        }
//                    }

//                    if (shouldContinue)
//                    {

//                        if (index == radPageViewHopdong.Pages.Count - 1)
//                        {
//                            index = 0;
//                        }
//                        else
//                            index = index + 1;
//                        radPageViewHopdong.SelectedPage = radPageViewHopdong.Pages[index];
//                        radPageViewHopdong.Select();

//                        SetUpSelectedPage();
//                    }

//                    return;
//                }
//                index++;
//            }
//        }

//        private void SetUpSelectedPage()
//        {
//            if (radPageViewHopdong.SelectedPage == radPageViewPageGoiKyThuat)
//                setupHopDongGKT();
//            else if (radPageViewHopdong.SelectedPage == radPageViewPageCBnhanchuyengiao)
//                setUpCanBonhanchuyengiao();
//            else if (radPageViewHopdong.SelectedPage == radPageViewPageCanBoTrienKhai)
//                setupCanboTrienKhai();
//        }

//        #region Hop dong Goi ky thuat

//        private void setupHopDongGKT()
//        {

//            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
//            function.Item = hopdong.ID;
//            bindingHopdongGoiKythuat.DataSource = CDT_HopDong_GoiKT_Coll.GetCDT_HopDong_GoiKT_Coll(function);
//        }

//        private void radGridView2_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
//        {
//            try
//            {
//                if (radGridViewHopdongGoiKt.CurrentRow != null)
//                {
//                    if (radGridViewHopdongGoiKt.CurrentRow.Cells["Id"].Value != null)
//                    {
//                        hopdongGKT = (CDT_HopDong_GoiKT_Info)radGridViewHopdongGoiKt.CurrentRow.DataBoundItem;
//                        bindingHopdongGktSingle.DataSource = hopdongGKT;
//                        BindHopDongGoiKTtoControls(true);
//                    }
//                }
//                else
//                {
//                    hopdongGKT = CDT_HopDong_GoiKT_Info.NewCDT_HopDong_GoiKT_Info();
//                    bindingHopdongGktSingle.DataSource = hopdongGKT;
//                }
//            }
//            catch (Exception ex)
//            {
//                GlobalCommon.ShowErrorMessager(ex);
//            }
//        }


//        private void btnGoikythuatThem_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                hopdongGKT = CDT_HopDong_GoiKT_Info.NewCDT_HopDong_GoiKT_Info();
//                bindingHopdongGktSingle.DataSource = hopdongGKT;
//                AutoFillGoikythuat();
//            }
//            catch (Exception ex)
//            {
//                GlobalCommon.ShowErrorMessager(ex);
//            }
//        }

//        private void BindHopDongGoiKTtoControls(bool isEdit)
//        {
//            if (isEdit)
//            {
//                txtMTkienthuc.Text = hopdongGKT.MucTieuKienThuc;
//                txtMTKyNang.Text = hopdongGKT.MucTieuKyNang;
//                txtMTThaiDo.Text = hopdongGKT.MucTieuThaiDo;
//                txtMTKTChuyenGiao.Text = hopdongGKT.MoTaKyThuatChuyenGiao;
//                txtTCGoiKT.Text = hopdongGKT.TieuChuanGoiKT;
//                txtNDChuyenGiao.Text = hopdongGKT.NoiDungChuyenGiao;
//                txtCTDanhGia.Text = hopdongGKT.ChiTieuDanhGia;
//                txtTLBS.Text = hopdongGKT.TaiLieuHocTap_BS;
//                txtTLDD.Text = hopdongGKT.TaiLieuHocTap_DD;
//                txtTLKhac.Text = hopdongGKT.TaiLieuHocTap_Khac;
//                txtGhiChuGKT.Text = hopdongGKT.GhiChu;
//                netLink_DatePickerANgayBatDau.Value_String = hopdongGKT.A_NgayBatDau;
//                netLink_DatePickerANgayKetThuc.Value_String = hopdongGKT.A_NgayKetThuc;
//                netLink_DatePickerBNgayBatDau.Value_String = hopdongGKT.B_NgayBatDau;
//                netLink_DatePickerBNgayKetThuc.Value_String = hopdongGKT.B_NgayKetThuc;
//            }
//            else
//            {
//                hopdongGKT.MucTieuKienThuc = txtMTkienthuc.Text;
//                hopdongGKT.MucTieuKyNang = txtMTKyNang.Text;
//                hopdongGKT.MucTieuThaiDo = txtMTThaiDo.Text;
//                hopdongGKT.MoTaKyThuatChuyenGiao = txtMTKTChuyenGiao.Text;
//                hopdongGKT.TieuChuanGoiKT = txtTCGoiKT.Text;
//                hopdongGKT.NoiDungChuyenGiao = txtNDChuyenGiao.Text;
//                hopdongGKT.ChiTieuDanhGia = txtCTDanhGia.Text;
//                hopdongGKT.TaiLieuHocTap_BS = txtTLBS.Text;
//                hopdongGKT.TaiLieuHocTap_DD = txtTLDD.Text;
//                hopdongGKT.TaiLieuHocTap_Khac = txtTLKhac.Text;
//                hopdongGKT.GhiChu = txtGhiChuGKT.Text;
//                hopdongGKT.A_NgayBatDau = netLink_DatePickerANgayBatDau.Value_String;
//                hopdongGKT.A_NgayKetThuc = netLink_DatePickerANgayKetThuc.Value_String;
//                hopdongGKT.B_NgayBatDau = netLink_DatePickerBNgayBatDau.Value_String;
//                hopdongGKT.B_NgayKetThuc = netLink_DatePickerBNgayKetThuc.Value_String;

//                netLink_DatePickerANgayBatDau.MyName = "Ngày bắt đầu bên A";
//                netLink_DatePickerANgayKetThuc.MyName = "Ngày kết thúc bên A";
//                netLink_DatePickerBNgayBatDau.MyName = "Ngày bắt đầu bên B";
//                netLink_DatePickerBNgayKetThuc.MyName = "Ngày kết thúc bên B";
//            }
//        }

//        private void btnGktLuu_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (ValidateDataHopDongGoiKyThuat())
//                {
//                    hopdongGKT.IdHopDong = hopdong.ID;
//                    //CDT_GoiKT_Coll _goikythuatcoll = dropDownGoiKyThuat1.GetListData();
//                    //if (_goikythuatcoll != null)
//                    //{
//                    //    for (int i = 0; i < _goikythuatcoll.Count; i++)
//                    //    {
//                    //        if (_goikythuatcoll[i].ID == hopdongGKT.IdGoiKT)
//                    //        {
//                    //            hopdongGKT.TenGoiKT = hopdongGKT.TenGoiKT;
//                    //            break;
//                    //        }
//                    //    }
//                    //}
//                    BindHopDongGoiKTtoControls(false);

//                    CDT_LoaiHinhChuyenGiao_Coll lstLoaihinhChuyenGiao = (CDT_LoaiHinhChuyenGiao_Coll)bindingLoaihinhchuyengiao.DataSource;
//                    foreach (CDT_LoaiHinhChuyenGiao_Info loaihinhchuyengiao in lstLoaihinhChuyenGiao)
//                    {
//                        if (hopdongGKT.IDLoaiHinhChuyenGiao == loaihinhchuyengiao.ID)
//                        {
//                            hopdongGKT.LoaiHinhChuyenGiao = loaihinhchuyengiao.Ten;
//                            break;
//                        }
//                    }

//                    hopdongGKT.IdLastPersonUpdated = (int)PTIdentity.IDNguoiDung;


//                    CDT_HopDong_GoiKT_Coll lstHopdongGKt = (CDT_HopDong_GoiKT_Coll)bindingHopdongGoiKythuat.DataSource;
//                    if (hopdongGKT.IsNew)
//                    {

//                        lstHopdongGKt.Add(hopdongGKT);

//                    }

//                    bindingHopdongGoiKythuat.DataSource = lstHopdongGKt.Save();
//                }
//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }

//        private void btnGKTxoa_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (radGridViewHopdongGoiKt.CurrentRow.Cells["Id"].Value != null)
//                {
//                    int id = Convert.ToInt32(radGridViewHopdongGoiKt.CurrentRow.Cells["ID"].Value);
//                    if (GlobalCommon.AcceptDelete())
//                    {
//                        CDT_HopDong_GoiKT_Coll lstHopdongGKT = (CDT_HopDong_GoiKT_Coll)bindingHopdongGoiKythuat.DataSource;
//                        lstHopdongGKT.RemoveAt(radGridViewHopdongGoiKt.CurrentRow.Index);
//                        lstHopdongGKT.Save();
//                    }
//                }
//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }

//        private void dropDownGoiKyThuat1_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            try
//            {
//                AutoFillGoikythuat();
//            }
//            catch (Exception ex)
//            {
//                GlobalCommon.ShowErrorMessager(ex);
//            }
//        }

//        private void AutoFillGoikythuat()
//        {
//            try
//            {
//                CDT_GoiKT_Info item = (CDT_GoiKT_Info)dropDownGoiKyThuat1.Selected_Item;
//                if (item != null)
//                {
//                    hopdongGKT.MucTieuKienThuc = txtMTkienthuc.Text = item.MucTieuKienThuc;
//                    hopdongGKT.IdGoiKT = item.ID;
//                    hopdongGKT.TenGoiKT = item.TenGoiKT;
//                    hopdongGKT.MucTieuKyNang = txtMTKyNang.Text = item.MucTieuKyNang;
//                    hopdongGKT.MucTieuThaiDo = txtMTThaiDo.Text = item.MucTieuThaiDo;
//                    hopdongGKT.MoTaKyThuatChuyenGiao = txtMTKTChuyenGiao.Text = item.MoTaKyThuatChuyenGiao;
//                    hopdongGKT.TieuChuanGoiKT = txtTCGoiKT.Text = item.TieuChuanGoiKT;
//                    hopdongGKT.NoiDungChuyenGiao = txtNDChuyenGiao.Text = item.NoiDungChuyenGiao;
//                    hopdongGKT.ChiTieuDanhGia = txtCTDanhGia.Text = item.ChiTieuDanhGia;
//                    hopdongGKT.TaiLieuHocTap_BS = txtTLBS.Text = item.TaiLieuHocTap_BS;
//                    hopdongGKT.TaiLieuHocTap_DD = txtTLDD.Text = item.TaiLieuHocTap_DD;
//                    hopdongGKT.TaiLieuHocTap_Khac = txtTLKhac.Text = item.TaiLieuHocTap_Khac;
//                }
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }

//        }


//        private void radDropDownListNguoithongqua_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
//        {
//            //DIC_CanBo_Coll lstCanbo = (DIC_CanBo_Coll)bindingCanbo.DataSource;
//            //if (radDropDownListNguoithongqua.SelectedIndex >= 0)
//            //    hopdongGKT.IDCanBoThongQua = lstCanbo[radDropDownListNguoithongqua.SelectedIndex].ID;
//        }

//        #endregion

//        private void radPageViewHopdong_SelectedPageChanged(object sender, EventArgs e)
//        {
//            SetUpSelectedPage();
//        }



//        private void radDDLLoaihinhchuyengiao_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
//        {

//        }

//        #region Can bo nhan chuyen giao
//        private void btnThemCBNCG_Click(object sender, EventArgs e)
//        {
//            canbonhanCG = CDT_CanBoNhanCGKT_Info.NewCDT_CanBoNhanCGKT_Info();
//            bindingCanbonhanCGSingle.DataSource = canbonhanCG;
//        }

//        private void btnLuuCBNCG_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (ValidateDataThongTinHopDong())
//                {
//                    canbonhanCG.Ngaysinh = netLink_DatePickerNgaySinhCanBoNhanCG.Value_String;
//                    CDT_GoiKT_Info _goiKythuat = ((CDT_GoiKT_Info)dropDownGoiKyThuat2.Selected_Item);
//                    if (_goiKythuat != null)
//                    {
//                        canbonhanCG.IDHopDong_GoiKT = (int)_goiKythuat.IdHopDongGoiKT;
//                        canbonhanCG.HopDong_GoiKT = _goiKythuat.TenGoiKT;
//                    }

//                    DIC_HocVi_Info trinhdo = ((DIC_HocVi_Info)dropDownTrinhDo.Selected_Item);
//                    if (trinhdo != null)
//                    {
//                        canbonhanCG.IdTrinhDo = (int)trinhdo.ID;
//                        canbonhanCG.TrinhDo = trinhdo.TenHocVi;
//                    }
//                    else
//                        canbonhanCG.IdTrinhDo = null;

//                    DIC_ChucVu_Coll lstChucVu = (DIC_ChucVu_Coll)bindingChucvu.DataSource;
//                    foreach (DIC_ChucVu_Info chucvu in lstChucVu)
//                    {
//                        if (canbonhanCG.IdChucVu == chucvu.ID)
//                        {
//                            canbonhanCG.ChucVu = chucvu.Ten;
//                            break;
//                        }
//                    }

//                    DIC_ChuyenNganh_Coll lstChuyennganh = (DIC_ChuyenNganh_Coll)bindingChuyennganh.DataSource;
//                    foreach (DIC_ChuyenNganh_Info chuyenngganh in lstChuyennganh)
//                    {
//                        canbonhanCG.ChuyenNganh = chuyenngganh.Ten;
//                    }

//                    CDT_CanBoNhanCGKT_Coll lstCanbonhanChuyen = (CDT_CanBoNhanCGKT_Coll)bindingCanbonhanCG.DataSource;
//                    if (canbonhanCG.IsNew)
//                    {
//                        lstCanbonhanChuyen.Add(canbonhanCG);
//                    }
//                    bindingCanbonhanCG.DataSource = lstCanbonhanChuyen.Save();
//                }

//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }

//        private void btnXoaCBNCG_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (radGridViewCBNCG.CurrentRow.Cells["ID"].Value != null)
//                {
//                    if (GlobalCommon.AcceptDelete())
//                    {
//                        CDT_CanBoNhanCGKT_Coll lstCanbonhanChuyen = (CDT_CanBoNhanCGKT_Coll)bindingCanbonhanCG.DataSource;
//                        lstCanbonhanChuyen.RemoveAt(radGridViewCBNCG.CurrentRow.Index);
//                        lstCanbonhanChuyen.Save();
//                    }
//                }
//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }

//        private void setUpCanBonhanchuyengiao()
//        {
//            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
//            function.Item = hopdong.ID;
//            bindingCanbonhanCG.DataSource = CDT_CanBoNhanCGKT_Coll.GetCDT_CanBoNhanCGKT_Coll(function);
//        }

//        private void radGridViewCBNCG_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
//        {
//            if (radGridViewCBNCG.CurrentRow != null)
//            {
//                if (radGridViewCBNCG.CurrentRow.Cells["Id"].Value != null)
//                {
//                    canbonhanCG = (CDT_CanBoNhanCGKT_Info)radGridViewCBNCG.CurrentRow.DataBoundItem;
//                    canbonhanCG.Ngaysinh = netLink_DatePickerNgaySinhCanBoNhanCG.Value_String;
//                    bindingCanbonhanCGSingle.DataSource = canbonhanCG;
//                }
//            }
//            else
//            {
//                canbonhanCG = CDT_CanBoNhanCGKT_Info.NewCDT_CanBoNhanCGKT_Info();
//                bindingCanbonhanCGSingle.DataSource = canbonhanCG;
//            }
//        }

//        private void dropDownTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        #endregion

//        #region can bo trien khai
//        private void btnThemCanboTrienkhai_Click(object sender, EventArgs e)
//        {
//            canboTrienKhai = CDT_HopDong_GoiKT_CanBoTrienKhai_Info.NewCDT_HopDong_GoiKT_CanBoTrienKhai_Info();
//            bindingCanboTrienKhaiSingle.DataSource = canboTrienKhai;
//        }

//        private void btnLuuCanbotrienkhai_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (ValidateDataCanBoChuyenGiao())
//                {
//                    CDT_GoiKT_Info _goiKythuat = ((CDT_GoiKT_Info)dropDownGoiKyThuat3.Selected_Item);
//                    if (_goiKythuat != null)
//                    {
//                        canboTrienKhai.IdHopDong_GoiKT = (int)_goiKythuat.IdHopDongGoiKT;
//                        canboTrienKhai.HopDong_GoiKT = _goiKythuat.TenGoiKT;
//                    }

//                    DIC_CanBo_Coll lstCanbo = (DIC_CanBo_Coll)bindingCanbo.DataSource;
//                    if (radDropDownListCanbotrienkhai.SelectedIndex >= 0)
//                    {
//                        canboTrienKhai.IdCanBoTrienKhai = lstCanbo[radDropDownListCanbotrienkhai.SelectedIndex].ID;
//                        canboTrienKhai.CanBoTrienKhai = lstCanbo[radDropDownListCanbotrienkhai.SelectedIndex].HoTen;
//                    }
//                    CDT_HopDong_GoiKT_CanBoTrienKhai_Coll lstCanboTrienKhai = (CDT_HopDong_GoiKT_CanBoTrienKhai_Coll)bindingCanBoTrienKhai.DataSource;
//                    if (canboTrienKhai.IsNew)
//                    {
//                        lstCanboTrienKhai.Add(canboTrienKhai);
//                    }
//                    bindingCanBoTrienKhai.DataSource = lstCanboTrienKhai.Save();
//                }
//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }

//        private void btnXoaCanbotrienkhai_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (radGridViewCanBoTrienKhai.CurrentRow.Cells["IdCanBoTrienKhai"].Value != null)
//                {
//                    if (GlobalCommon.AcceptDelete())
//                    {
//                        CDT_HopDong_GoiKT_CanBoTrienKhai_Coll lstCanboTrienKhai = (CDT_HopDong_GoiKT_CanBoTrienKhai_Coll)bindingCanBoTrienKhai.DataSource;
//                        lstCanboTrienKhai.RemoveAt(radGridViewCanBoTrienKhai.CurrentRow.Index);
//                        lstCanboTrienKhai.Save();
//                    }
//                }
//            }
//            catch (Exception ex)
//            { GlobalCommon.ShowErrorMessager(ex); }
//        }

//        private void setupCanboTrienKhai()
//        {
//            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
//            function.Item = hopdong.ID;
//            bindingCanBoTrienKhai.DataSource = CDT_HopDong_GoiKT_CanBoTrienKhai_Coll.GetCDT_HopDong_GoiKT_CanBoTrienKhai_Coll(function);
//        }

//        private void radGridViewCanBoTrienKhai_CurrentRowChanged(object sender, CurrentRowChangedEventArgs e)
//        {
//            if (radGridViewCanBoTrienKhai.CurrentRow != null)
//            {
//                if (radGridViewCanBoTrienKhai.CurrentRow.Cells["IdCanBoTrienKhai"].Value != null)
//                {
//                    canboTrienKhai = (CDT_HopDong_GoiKT_CanBoTrienKhai_Info)radGridViewCanBoTrienKhai.CurrentRow.DataBoundItem;
//                    bindingCanboTrienKhaiSingle.DataSource = canboTrienKhai;

//                    CDT_GoiKT_Coll _goikythuatcoll = dropDownGoiKyThuat3.GetListData();
//                    if (_goikythuatcoll != null)
//                    {
//                        for (int i = 0; i < _goikythuatcoll.Count; i++)
//                        {
//                            if (_goikythuatcoll[i].IdHopDongGoiKT == canboTrienKhai.IdHopDong_GoiKT)
//                            {
//                                dropDownGoiKyThuat3.SelectedIndex = i;
//                                break;
//                            }
//                        }
//                    }

//                    // binding data for id can bo dropdownlist
//                    DIC_CanBo_Coll lstCanbo = (DIC_CanBo_Coll)bindingCanbo.DataSource;
//                    for (int i = 0; i < lstCanbo.Count; i++)
//                    {
//                        if (canboTrienKhai.IdCanBoTrienKhai == lstCanbo[i].ID)
//                        {
//                            radDropDownListCanbotrienkhai.SelectedIndex = i;
//                            break;
//                        }
//                    }
//                }
//            }
//            else
//            {
//                canboTrienKhai = CDT_HopDong_GoiKT_CanBoTrienKhai_Info.NewCDT_HopDong_GoiKT_CanBoTrienKhai_Info();
//                bindingCanboTrienKhaiSingle.DataSource = canboTrienKhai;
//            }
//        }

//        private void radDropDownListCanbotrienkhai_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
//        {
//            DIC_CanBo_Coll lstCanbo = (DIC_CanBo_Coll)bindingCanbo.DataSource;
//            if (radDropDownListCanbotrienkhai.SelectedIndex >= 0)
//                canboTrienKhai.IdCanBoTrienKhai = lstCanbo[radDropDownListCanbotrienkhai.SelectedIndex].ID;
//        }

//        #endregion


//        #region Validate data

//        private bool ValidateDataHopDongGoiKyThuat()
//        {

//            if (!netLink_DatePickerANgayBatDau.isDateTime && !netLink_DatePickerANgayBatDau.isNull)
//            {
//                GlobalCommon.ShowErrorMessager(netLink_DatePickerANgayBatDau.Value_Error);
//                return false;
//            }
//            if (!netLink_DatePickerANgayKetThuc.isDateTime && !netLink_DatePickerANgayKetThuc.isNull)
//            {
//                GlobalCommon.ShowErrorMessager(netLink_DatePickerANgayKetThuc.Value_Error);
//                return false;
//            }
//            if (!netLink_DatePickerBNgayBatDau.isDateTime && !netLink_DatePickerBNgayBatDau.isNull)
//            {
//                GlobalCommon.ShowErrorMessager(netLink_DatePickerBNgayBatDau.Value_Error);
//                return false;
//            }
//            if (!netLink_DatePickerBNgayKetThuc.isDateTime && !netLink_DatePickerBNgayKetThuc.isNull)
//            {
//                GlobalCommon.ShowErrorMessager(netLink_DatePickerBNgayKetThuc.Value_Error);
//                return false;
//            }
//            if (string.IsNullOrEmpty(dropDownGoiKyThuat1.Text))
//            {
//                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
//                return false;
//            }

//            if (string.IsNullOrEmpty(radDDLLoaihinhchuyengiao.Text))
//            {
//                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
//                return false;
//            }

//            if (GlobalCommon.CheckDateMustBeEarilierThanOther(netLink_DatePickerANgayKetThuc.Value_String, netLink_DatePickerANgayBatDau.Value_String))
//            {
//                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, netLink_DatePickerANgayKetThuc.MyName, netLink_DatePickerANgayBatDau.MyName));
//                return false;
//            }

//            if (GlobalCommon.CheckDateMustBeEarilierThanOther(netLink_DatePickerBNgayKetThuc.Value_String, netLink_DatePickerBNgayBatDau.Value_String))
//            {
//                GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, netLink_DatePickerBNgayKetThuc.MyName, netLink_DatePickerBNgayBatDau.MyName));
//                return false;
//            }

//            return true;
//        }

//        private bool ValidateDataThongTinHopDong()
//        {
//            if (!netLink_DatePickerNgayKyKet.isDateTime && !netLink_DatePickerNgayKyKet.isNull)
//            {
//                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayKyKet.Value_Error);
//                return false;
//            }
//            if (GlobalCommon.CheckArrayTextIsNull(new string[] { txtTenhopdong.Text, dropDownBenhVien1.Text, txtA_NguoiDaiDien.Text, txtA_ChucVu.Text, dropDownBenhVien2.Text, txtB_NguoiDaiDien.Text, txtB_ChucVu.Text }))
//            {
//                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
//                return false;
//            }
//            return true;
//        }

//        private bool ValidateDataCanBoNhanChuyenGiao()
//        {
//            if (GlobalCommon.CheckArrayTextIsNull(new string[] { txtTenCBNCG.Text, dropDownBenhVien1.Text, dropDownGoiKyThuat2.Text, radDropDownListChucvu.Text }))
//            {
//                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
//                return false;
//            }
//            return true;
//        }

//        private bool ValidateDataCanBoChuyenGiao()
//        {
//            if (GlobalCommon.CheckArrayTextIsNull(new string[] { dropDownGoiKyThuat3.Text, radDropDownListCanbotrienkhai.Text }))
//            {
//                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
//                return false;
//            }
//            return true;
//        }

//        #endregion

//    }
//}
