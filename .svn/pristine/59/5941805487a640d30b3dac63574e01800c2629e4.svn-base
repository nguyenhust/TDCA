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
using System.Collections;
using ExportLib.Entities.DaoTao;
using ExportLib;
using System.Data.SqlClient;
using ModuleDaoTao.UI;
using CrystalDecisions.CrystalReports.Engine;
using Csla.Data;
namespace ModuleDaoTao.UI
{
    public partial class Form_LT_LopHoc : NETLINK.UI.Dictionary
    {

        DT_LienTuc_LopHoc_Info obj;
   //     DT_LienTuc_HocVien_Info obj;
        DT_LienTuc_LopHoc objLophoc;
        DT_LienTuc_HocVien_Coll hocvienchuaxeplop;
        DT_LienTuc_HocVien_Coll hocviendaxeplop;
        DIC_HocVi_Coll trinhdo;
        DIC_GiangVien_Coll giangviencoll;
        private bool acceptGen = false;
        string lophocId;
        private int SoLuong;
        private Decimal DonGia;
        private Decimal ThanhTien;
        public static int DKien;
        public static string DuLieu = string.Empty;
        public Form_LT_LopHoc(FormMode _formMode)
        {
            InitializeComponent();
            formMode = _formMode;
            //dropDownChuyenKhoa1.FillData(1);
            if (_formMode.IsInsert)
            {
                objLophoc = DT_LienTuc_LopHoc.NewDT_LienTuc_LopHoc();
                lophocId = string.Empty;
            }
            else
            {
                lophocId = _formMode.StringId;
                objLophoc = DT_LienTuc_LopHoc.GetDT_LienTuc_LopHoc(lophocId);
            }

            bindingSourceLophoc.DataSource = objLophoc;

            lopHocCount = new Hashtable();
            mMaLophocCount = new Hashtable();
            DuLieu = dropDownCanBophutrach.Text;
        }

        #region Override

        protected override void ApplyAuthorizationRules()
        {
            /*this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            btnContinue.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            HopDong_Activated(this, EventArgs.Empty);*/
        }

        protected override void FormLoad()
        {
            try
            {
                // binding for trinh do
                // load chuyen khoa
                // chuyenkhoa = DIC_ChuyenKhoa_Coll.GetDIC_ChuyenKhoa_Coll();                
                trinhdo = DIC_HocVi_Coll.GetDIC_HocVi_Coll();
                dropDownCanBoPhoihop.FillData(1);
                dropDownCanBophutrach.FillData(2);
                dropDownTrinhDo1.FillData(1);
                // dropDownChuyenKhoa1.FillData();
                dropDownChuyenKhoa1.FillData(1);
                chuyenkhoa = dropDownChuyenKhoa1.GetListData();
                dropDownLopHocLienTucKhung1.FillData(1);
                if (objLophoc.MaLop != "")
                {
                    dropDownChuyenKhoa1.Selected_ID = (Int64)objLophoc.IDChuyenKhoa;
                }
                // load for nguon kinh phi
                dropDownNguonKinhPhi.FillData(1);
                txtCanBo.Enabled = false;
                radGioiTinh.Enabled = false;
                if (!string.IsNullOrEmpty(lophocId))
                {
                   
                    dropDownLopHocLienTucKhung1.Selected_ID = objLophoc.IdKhungLopHoc;
                    dropDownCanBoPhoihop.Selected_ID = objLophoc.IdCanBoPhoiHop;
                    dropDownCanBophutrach.Selected_ID = objLophoc.IdCanBoPhuTrach;
                    dropDownTrinhDo1.Selected_TextValue = objLophoc.DoiTuong;
                    //dropDownChuyenKhoa1.Selected_ID = objLophoc.IdKhungLopHoc;
                    dropDownNguonKinhPhi.Selected_ID = objLophoc.IdNguonKinhPhi;
                    netLink_DatePickerNgayBatDau.Value_String = objLophoc.NgayBatDau == "" ? objLophoc.NgayBatDau : Convert.ToDateTime(objLophoc.NgayBatDau).ToString("dd/MM/yyy");
                    netLink_DatePickerNgayKetThuc.Value_String = objLophoc.NgayKetThuc == "" ? objLophoc.NgayKetThuc : Convert.ToDateTime(objLophoc.NgayKetThuc).ToString("dd/MM/yyy");
                    radButtonDiemdanh.Enabled = true;
                    groupBox1.Enabled = true;
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    dropDownChuyenKhoa1.Enabled = false;
                    dropDownLopHocLienTucKhung1.Enabled = false;
                }
                else
                {
                    radButtonDiemdanh.Enabled = false;
                }

                netLink_DatePickerNgayBatDau.MyName = "Ngày bắt đầu";
                netLink_DatePickerNgayKetThuc.MyName = "Ngày kết thúc";
                txtSoTiet.Text = objLophoc.TongSoTiet.ToString();
                txtCanBo.Text = objLophoc.TenCanBo;
                radGioiTinh.Text = objLophoc.GioiTinh;           
                bindingSourceBenhVien.DataSource = dropDownBenhVien1.GetListData();

                // load for dia diem
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
                function.Item = lophocId;

                bindingSourceGroup.DataSource = DT_Group_Coll.GetAllGroup();
                acceptGen = true;
              
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                if (ValidateData())
                {
                    //int VT = dropDownLopHocLienTucKhung1.Selected_TextValue.ToString().IndexOf("(");
                    objLophoc.IdCanBoPhuTrach = System.Convert.ToInt64(dropDownCanBophutrach.Selected_ID);
                    objLophoc.IdCanBoPhoiHop = System.Convert.ToInt64(dropDownCanBoPhoihop.Selected_ID);
                    objLophoc.IdTrinhDo = System.Convert.ToInt64(dropDownTrinhDo1.Selected_ID);
                    objLophoc.DoiTuong = Convert.ToString(dropDownTrinhDo1.Selected_TextValue.ToString());
                    objLophoc.IdKhungLopHoc = System.Convert.ToInt32(dropDownLopHocLienTucKhung1.Selected_ID);
                    //if (VT > 0)
                    //    objLophoc.TenLop = dropDownLopHocLienTucKhung1.Selected_TextValue.ToString().Substring(0, VT);
                    //else
                        objLophoc.TenLop = dropDownLopHocLienTucKhung1.Selected_TextValue.ToString();

                    objLophoc.IdNguonKinhPhi = dropDownNguonKinhPhi.Selected_Item != null ? System.Convert.ToInt32(dropDownNguonKinhPhi.Selected_ID) : -1;
                    objLophoc.TongSoTiet = Convert.ToInt32(txtSoTiet.Text);
                    // setup ngay bat dau
                    objLophoc.NgayBatDau = netLink_DatePickerNgayBatDau.Value_String == "" ? netLink_DatePickerNgayBatDau.Value_String : netLink_DatePickerNgayBatDau.Value.ToShortDateString();
                    objLophoc.NgayKetThuc = netLink_DatePickerNgayKetThuc.Value_String == "" ? netLink_DatePickerNgayKetThuc.Value_String : netLink_DatePickerNgayKetThuc.Value.ToShortDateString();

                    //DT_LienTuc_KhungLopHoc_Coll khunglop = dropDownLopHocLienTucKhung1.GetListData();
                    //if (khunglop != null)
                    //{
                    //    if (dropDownLopHocLienTucKhung1.SelectedIndex >= 0)
                    //        objLophoc.TenLop = khunglop[dropDownLopHocLienTucKhung1.SelectedIndex].TenLop;
                    //}
                    objLophoc.TenCanBo=txtCanBo.Text;
                  objLophoc.GioiTinh=radGioiTinh.Text;                   
                    objLophoc.ApplyEdit();
                    objLophoc.Save();

                    // endable diem danh
                    radButtonDiemdanh.Enabled = true;

                    // save dia diem
                    try
                    {
                        DT_LienTuc_LopHoc_DiaDiemToChuc_Coll DiaDiemColl = (DT_LienTuc_LopHoc_DiaDiemToChuc_Coll)bindingSourceDiaDiem.DataSource;
                        foreach (DT_LienTuc_LopHoc_DiaDiemToChuc_Info item in DiaDiemColl)
                        {
                            item.MaLop = objLophoc.MaLop;
                        }
                        DiaDiemColl.Save();
                    }
                    catch
                    {
                    }
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "CĐT - Liên Tục - Lớp học mã:" + objLophoc.MaLop);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);

                    groupBox1.Enabled = true;
                    groupBox3.Enabled = true;
                    groupBox4.Enabled = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private bool ValidateData()
        {
            if (!netLink_DatePickerNgayBatDau.isDateTime && !netLink_DatePickerNgayBatDau.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayBatDau.Value_Error);
                return false;
            }
            if (!netLink_DatePickerNgayKetThuc.isDateTime && !netLink_DatePickerNgayKetThuc.isNull)
            {
                GlobalCommon.ShowErrorMessager(netLink_DatePickerNgayKetThuc.Value_Error);
                return false;
            }
            if (string.IsNullOrEmpty(dropDownLopHocLienTucKhung1.Text))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }

            if (GlobalCommon.CheckArrayTextIsNull(new string[] { netLink_DatePickerNgayBatDau.Text, netLink_DatePickerNgayKetThuc.Text, txtSoTiet.Text, radTextBoxHocPhi.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }

            if (!GlobalCommon.CheckDateMustBeEarilierThanOther(netLink_DatePickerNgayKetThuc.Value.ToShortDateString(), netLink_DatePickerNgayBatDau.Value.ToShortDateString()))
            {
                if (netLink_DatePickerNgayBatDau.Value <= netLink_DatePickerNgayKetThuc.Value)
                {
                    return true;
                }
                else
                {
                    GlobalCommon.ShowErrorMessager(string.Format(TextMessages.ErrorMessage.PhaiCungNgayHoacMuonHon, netLink_DatePickerNgayKetThuc.MyName, netLink_DatePickerNgayBatDau.MyName));
                    return false;
                }
            }
            if (!string.IsNullOrEmpty(txtSoTiet.Text) && !GlobalCommon.CheckIsNumber(txtSoTiet.Text))
            {
                GlobalCommon.ShowErrorMessager("Số tiết phải là một số");
                return false;
            }

            return true;
        }
        #endregion

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            //FormMode mode = new FormMode();
            //mode.IsInsert = true;
            //Form_LT_ThemLopHoc fr = new Form_LT_ThemLopHoc(mode);
            //fr.FormLophoc = this;
            //fr.ShowDialog();
        }

        public void RefreshLopHoc()
        {
            dropDownLopHocLienTucKhung1.FillData(1);
        }



        private void radButtonDsHocVien_Click(object sender, EventArgs e)
        {
            try
            {
                LoadHocVienDaXepLop();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void LoadHocVienDaXepLop()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);

            DT_Lientuc_HocVienSearch objSearch = new DT_Lientuc_HocVienSearch();
            objSearch.MaLop = objLophoc.MaLop;
            objSearch.KhungLophoc = (int)dropDownLopHocLienTucKhung1.Selected_ID;

            function.ItemID = (int)PTIdentity.IDNguoiDung;
            function.Item = objSearch;
            hocviendaxeplop = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            bindingSourceHocvien.DataSource = hocviendaxeplop;
        }

        private void radButtonLuuDsHocvien_Click(object sender, EventArgs e)
        {

        }


        Hashtable mMaLophocCount;
        private void radGridViewHocvien_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.Column.Name == "XepLop")
                {
                    bool isCheck = (bool)e.Value;
                    DT_LienTuc_HocVien_Info item = (DT_LienTuc_HocVien_Info)e.Row.DataBoundItem;
                    if (!isCheck)
                    {
                        item.MaLopHoc = null;
                        item.MaHocVien = null;
                        item.LastEdited_Date = DateTime.Now;
                        item.LastEdited_User = PTIdentity.IDNguoiDung;
                        DT_LienTuc_HocVien_Coll collHocVien = hocviendaxeplop;
                        DT_LienTuc_HocVien_Coll collHocVienChuaxepLop = null;
                        if (bindingSourceHocVienChuaxeplop.DataSource == null || radGridViewHocVienChuacolop.RowCount == 0)
                        {
                            bindingSourceHocVienChuaxeplop.DataSource = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                        }

                        DT_LienTuc_HocVien_Coll newHocVien = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                        foreach (DT_LienTuc_HocVien_Info hv in collHocVien)
                        {
                            if (!string.IsNullOrEmpty(hv.MaHocVien))
                            {
                                newHocVien.Add(hv);
                            }
                        }
                        hocviendaxeplop = newHocVien;
                        bindingSourceHocvien.DataSource = hocviendaxeplop;

                        collHocVienChuaxepLop = hocvienchuaxeplop;
                        collHocVienChuaxepLop.Add(item);
                        collHocVien.Save();
                    }



                }
                else if (e.Column.Name == "Nhom")
                {
                    DT_LienTuc_HocVien_Info item = (DT_LienTuc_HocVien_Info)e.Row.DataBoundItem;
                    item.LastEdited_Date = DateTime.Now;
                    item.LastEdited_User = PTIdentity.IDNguoiDung;
                    if (item.MaLopHoc != null)
                    {
                        //DT_LienTuc_HocVien_Coll collHocVien = (DT_LienTuc_HocVien_Coll)bindingSourceHocvien.DataSource;
                        //collHocVien.Save();
                        hocviendaxeplop.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                radGridViewHocvien.CancelEdit();
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private string CreateMaHocVien(string maLophoc, int count)
        {
            maLophoc = maLophoc.Replace("LT-", "TL-");
            
            string strCount = count.ToString();
            //if (count < 10)
            //    strCount = string.Format("000{0}", count);
            //else if (count < 100)
            //    strCount = string.Format("00{0}", count);
            //else if (count < 1000)
            //    strCount = string.Format("0{0}", count);
            //string result = string.Format("{0}-{1}", strCount, maLophoc);

            // Bỏ hết số 0 ở đầu mã
            string result = string.Format("{0}-{1}", strCount, maLophoc);
            return result;
        }

        private string taoMaHocVien(string maLopHoc)
        {
            
            string result = string.Empty;
            string maHocVienCu = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "Get_MaHocVienCu";
                    cm.Parameters.AddWithValue("@MaLopHoc",maLopHoc);
                    maHocVienCu = (string)cm.ExecuteScalar();
                }
            }
            //try // mã học viên mới có dạng : 5CC3517B24
            //{
            //    Int64 soHocVienCu = Convert.ToInt64(maHocVienCu.Substring(0, maHocVienCu.IndexOf("-",0)));                
            //    result = string.Format("{0}-{1}", soHocVienCu + 1, maLopHoc);
            //}
            //// nếu xảy ra lỗi khi convert thì lớp đó đang đánh mã học viên theo mã cu, bắt đầu tạo mã theo kiểu mới
            //catch (Exception)
            //{
            //    result = string.Format("{0}-{1}",1,maLopHoc);
            //}

            try // mã học viên mới có dạng : 0005CC3517B24
            {
                Int64 soHocVienCu = Convert.ToInt64(maHocVienCu.Substring(0, maHocVienCu.IndexOf("-", 0)));
                if (soHocVienCu.ToString().Length < 10)
                    result = string.Format("000{0}-{1}", soHocVienCu + 1, maLopHoc);
                if (soHocVienCu.ToString().Length >= 10 && soHocVienCu.ToString().Length < 100)
                    result = string.Format("00{0}-{1}", soHocVienCu + 1, maLopHoc);
                if (soHocVienCu.ToString().Length >= 100 && soHocVienCu.ToString().Length < 1000)
                    result = string.Format("0{0}-{1}", soHocVienCu + 1, maLopHoc);
                if (soHocVienCu.ToString().Length >= 1000)
                    result = string.Format("{0}-{1}", soHocVienCu + 1, maLopHoc);
            }
            // nếu xảy ra lỗi khi convert thì lớp đó đang đánh mã học viên theo mã cu, bắt đầu tạo mã theo kiểu mới
            catch (Exception)
            {
                result = string.Format("000{0}-{1}", 1, maLopHoc);
            }
            return result;
        }

        private int GetMaxHocVienCode()
        {
            // DT_LienTuc_HocVien_Coll collHocVien = (DT_LienTuc_HocVien_Coll)bindingSourceHocvien.DataSource;

            int code = 0;
            foreach (DT_LienTuc_HocVien_Info hv in hocviendaxeplop)
            {
                if (!string.IsNullOrEmpty(hv.MaHocVien))
                {
                    string stt = hv.MaHocVien.Split('-')[0].Trim();
                    int currentCode = 0;
                    int.TryParse(stt, out currentCode);
                    if (currentCode > code)
                        code = currentCode;
                }
            }
            return code;
        }


        private Hashtable lopHocCount;
        private DIC_ChuyenKhoa_Coll chuyenkhoa;
        private void SetMaLopHoc()
        {
            try
            {
                if (acceptGen && dropDownChuyenKhoa1.Selected_Item != null && !string.IsNullOrEmpty(netLink_DatePickerNgayBatDau.Value_String))
                {
                    DIC_ChuyenKhoa_Info ck = (DIC_ChuyenKhoa_Info)dropDownChuyenKhoa1.Selected_Item;
                    int count = 0;
                    //if (!lopHocCount.ContainsKey(ck.ID))
                    //{
                    BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDown);
                    function.ItemFilterCondition_Int = netLink_DatePickerNgayBatDau.Value.Year;
                    function.ItemFilterCondition_Int2 = ck.ID;
                  count = DT_LienTuc_LopHoc_Coll.GetDT_LienTuc_LopHoc_Coll_Count(function);
                   
                    if (formMode.IsInsert)
                    {
                        objLophoc.MaLop = radTextBoxMaLop.Text = createMaLopHoc(ck.GhiChu, count + 1, netLink_DatePickerNgayBatDau.Value.Year);
                        objLophoc.Backup06 = count + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void dropDownLopHocLienTucKhung1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private string createMaLopHoc(string vietat, int count, int year)
        {
            string strCount = count.ToString();
            if (count < 10)
                strCount = string.Format("0{0}", count);

            string result = string.Format("TL-BM-{0}-{1}-{2}-B24", vietat, strCount, GlobalCommon.CutYear(year));
            return result;
        }

        private void dropDownLopHocLienTucKhung1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void radButtonDiemdanh_Click(object sender, EventArgs e)
        {
            try
            {
                B001_BangDiemDanhTheoLop bangdiemdanh = new B001_BangDiemDanhTheoLop();

                DT_LienTuc_KhungLopHoc_Info lophocInfo = (DT_LienTuc_KhungLopHoc_Info)dropDownLopHocLienTucKhung1.Selected_Item;
                bangdiemdanh.KhoaDaoTao = lophocInfo.ChuyenKhoa;
                bangdiemdanh.TenLop = lophocInfo.TenLop + "(" + radTextBoxMaLop.Text + ")";
                bangdiemdanh.NgayBatDau = objLophoc.NgayBatDau;
                bangdiemdanh.NgayKetThuc = objLophoc.NgayKetThuc;
                bangdiemdanh.ThoiGianNhap = DateTime.Now.ToString();
                bangdiemdanh.ListHocVien = new List<DanhSachLop>();

                DT_LienTuc_HocVien_Coll collHocVien = (DT_LienTuc_HocVien_Coll)bindingSourceHocvien.DataSource;
                int count = 1;
                foreach (DT_LienTuc_HocVien_Info hv in collHocVien)
                {
                    if (!string.IsNullOrEmpty(hv.MaHocVien) && !string.IsNullOrEmpty(hv.MaLopHoc))
                    {

                        bangdiemdanh.ListHocVien.Add(new DanhSachLop(count.ToString(), hv.HoTen));
                    }
                }
                ExportDaoTao daotao = new ExportDaoTao();
                daotao.B001_BangDiemDanhTheoLop(bangdiemdanh);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonTaiDSHocVienchuaxeplop_Click(object sender, EventArgs e)
        {
            try
            {
                LoadHocVienChuaXepLop();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void LoadHocVienChuaXepLop()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition3);

            DT_Lientuc_HocVienSearch objSearch = new DT_Lientuc_HocVienSearch();
            objSearch.KhungLophoc = (int)dropDownLopHocLienTucKhung1.Selected_ID;

            function.ItemID = (int)PTIdentity.IDNguoiDung;
            function.Item = objSearch;
            hocvienchuaxeplop = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            bindingSourceHocVienChuaxeplop.DataSource = hocvienchuaxeplop;
        }

        private void radGridViewHocVienChuacolop_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.Column.Name == "XepLop")
                {
                    bool isCheck = (bool)e.Value;
                    DT_LienTuc_HocVien_Info item = (DT_LienTuc_HocVien_Info)e.Row.DataBoundItem;
                    if (isCheck)
                    {
                        if (bindingSourceHocvien.DataSource == null || radGridViewHocvien.RowCount == 0)
                        {
                            bindingSourceHocvien.DataSource = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                        }
                        int count = 1;
                        if (mMaLophocCount.ContainsKey(objLophoc.MaLop))
                        {
                            count = (int)mMaLophocCount[objLophoc.MaLop];
                        }
                        else
                        {
                            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDown);
                            function.Item = objLophoc.MaLop;
                            count = GetMaxHocVienCode() + 1;
                        }
                        item.MaHocVien = CreateMaHocVien(objLophoc.MaLop, count);//objHocVien.MaHocVien;
                        //item.MaHocVien = taoMaHocVien(objLophoc.MaLop);
                        item.MaLopHoc = objLophoc.MaLop;
                        item.TongHocPhi = objLophoc.HocPhi;
                        item.NgayBatDau = objLophoc.NgayBatDau;
                        item.NgayKetThuc = objLophoc.NgayKetThuc;
                        if ((!string.IsNullOrEmpty(item.NgayKetThuc) && !string.IsNullOrEmpty(item.NgayBatDau)) && (item.TrangThai == TextMessages.Itemvalue.TrangThaiHoc_DangHoc || item.TrangThai == TextMessages.Itemvalue.TrangThaiHoc_ChuaHoc || item.TrangThai == TextMessages.Itemvalue.TrangThaiHoc_KT_ChuaCC))
                        {
                            if (DateTime.Compare(item.DateNgayBatDau, DateTime.Now) <= 0 && DateTime.Compare(item.DateNgayKetThuc, DateTime.Now) >= 0)
                            {
                                item.TrangThai = TextMessages.Itemvalue.TrangThaiHoc_DangHoc;
                            }
                            else if (DateTime.Compare(item.DateNgayKetThuc, DateTime.Now) < 0)
                            {
                                item.TrangThai = TextMessages.Itemvalue.TrangThaiHoc_KT_ChuaCC;
                            }
                            else
                            {
                                item.TrangThai = TextMessages.Itemvalue.TrangThaiHoc_ChuaHoc;
                            }

                        }
                        DT_LienTuc_HocVien_Coll collHocVien = null;
                        //DT_LienTuc_HocVien_Coll collHocVienChuaxepLop = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienChuaxeplop.DataSource;

                        DT_LienTuc_HocVien_Coll newHocVien = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                        foreach (DT_LienTuc_HocVien_Info hv in hocvienchuaxeplop)
                        {
                            if (string.IsNullOrEmpty(hv.MaHocVien))
                            {
                                newHocVien.Add(hv);
                            }
                        }
                        bindingSourceHocVienChuaxeplop.DataSource = newHocVien;
                        hocvienchuaxeplop = newHocVien;

                        collHocVien = hocviendaxeplop;
                        collHocVien.Add(item);

                        collHocVien.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                radGridViewHocvien.CancelEdit();
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radTextBoxHocPhi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lbTienHoc.Text = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(radTextBoxHocPhi.Text);
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
                SetMaLopHoc();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radLabel22_Click(object sender, EventArgs e)
        {

        }

        private void radButtonLietKeGv_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGiangVien();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void LoadGiangVien()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
            function.Item = objLophoc.MaLop;
            bindingSourceGiangVien.DataSource = DT_LienTuc_GiangVien_Coll.GetDT_LienTuc_GiangVien_Coll(function);
        }

        private void BtnThemMoiGiangVien_Click(object sender, EventArgs e)
        {
            try
            {
                FormMode modex = new FormMode();
                modex.Item = objLophoc.MaLop;
                modex.IsInsert = true;
                Form_LT_LopHocGiangVien fr = new Form_LT_LopHocGiangVien(modex);
                fr.ShowDialog();
                LoadGiangVien();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButtonSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridViewGiangVien.CurrentRow != null && radGridViewGiangVien.CurrentRow.Cells["ID"].Value != null)
                {
                    FormMode modex = new FormMode();
                    modex.IsEdit = true;
                    modex.Item = objLophoc.MaLop;
                    modex.Id = Convert.ToInt32(radGridViewGiangVien.CurrentRow.Cells["ID"].Value);
                    Form_LT_LopHocGiangVien fr = new Form_LT_LopHocGiangVien(modex);
                    fr.ShowDialog();
                    LoadGiangVien();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void btnXoaGiangVien_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridViewGiangVien.CurrentRow != null && radGridViewGiangVien.CurrentRow.Cells["ID"].Value != null && GlobalCommon.AcceptDelete())
                {
                    DT_LienTuc_GiangVien.DeleteDT_LienTuc_GiangVien(Convert.ToInt32(radGridViewGiangVien.CurrentRow.Cells["ID"].Value));
                    LoadGiangVien();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radGridViewGiangVien_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (radGridViewGiangVien.CurrentRow != null && radGridViewGiangVien.CurrentRow.Cells["ID"].Value != null)
                {
                    FormMode modex = new FormMode();
                    modex.IsEdit = true;
                    modex.Item = objLophoc.MaLop;
                    modex.Id = Convert.ToInt32(radGridViewGiangVien.CurrentRow.Cells["ID"].Value);
                    Form_LT_LopHocGiangVien fr = new Form_LT_LopHocGiangVien(modex);
                    fr.ShowDialog();
                    LoadGiangVien();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private DT_LienTuc_HocVien_Coll hvxeplop;
        private void btnBoxeplop_Click(object sender, EventArgs e)
        {
            try
            {
                bool chon = false;

                hvxeplop = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewHocvien.ChildRows)
                {
                    if (rowInfo.Cells["Chon"].Value != null && bool.TryParse(rowInfo.Cells["Chon"].Value.ToString(), out chon) && chon)
                    {
                        string strMaHocVien = rowInfo.Cells["MaHocVien"].Value.ToString();
                        int SoHientai = Convert.ToInt32(strMaHocVien.Split('-')[0].Trim());
                        if (GetMaxHocVienCode() > SoHientai && radCheckBoxAllDaXepLop.Checked == false)
                        {
                            MessageBox.Show(" Bạn hãy đẩy hết danh sách học viên xuống rồi upload lên để đảm bảo mã học viên tăng đều","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                        itemInfo.IdLopHoc = 0;
                        itemInfo.MaLopHoc = null;
                        itemInfo.MaHocVien = null;
                        itemInfo.LastEdited_Date = DateTime.Now;
                        itemInfo.LastEdited_User = PTIdentity.IDNguoiDung;
                        hvxeplop.Add(itemInfo);
                        chon = false;
                    }
                }
                radCheckBoxAllDaXepLop.Checked = false;
                if (hvxeplop.Count > 0)
                {
                    hvxeplop.Save();
                    LoadHocVienDaXepLop();
                    LoadHocVienChuaXepLop();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void btnXepLop_Click(object sender, EventArgs e)
        {
            try
            {
                bool chon = false;

                hvxeplop = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();

                int count = 1;
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDown);
                function.Item = objLophoc.MaLop;
                if (hocviendaxeplop == null)
                    LoadHocVienDaXepLop();
                count = GetMaxHocVienCode() + 1;

                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewHocVienChuacolop.ChildRows)
                {
                    if (rowInfo.Cells["Chon"].Value != null && bool.TryParse(rowInfo.Cells["Chon"].Value.ToString(), out chon) && chon)
                    {
                        DT_LienTuc_HocVien_Info itemInfo = (DT_LienTuc_HocVien_Info)rowInfo.DataBoundItem;
                        itemInfo.MaHocVien = CreateMaHocVien(objLophoc.MaLop, count);//objHocVien.MaHocVien;
                        //itemInfo.MaHocVien = taoMaHocVien(objLophoc.MaLop);
                        itemInfo.MaLopHoc = objLophoc.MaLop;
                        itemInfo.TongHocPhi = objLophoc.HocPhi;
                        itemInfo.NgayBatDau = objLophoc.NgayBatDau;
                        itemInfo.NgayKetThuc = objLophoc.NgayKetThuc;
                        itemInfo.TongSoTiet = objLophoc.TongSoTiet;
                        if ((!string.IsNullOrEmpty(itemInfo.NgayKetThuc) && !string.IsNullOrEmpty(itemInfo.NgayBatDau)) && (itemInfo.TrangThai == TextMessages.Itemvalue.TrangThaiHoc_DangHoc || itemInfo.TrangThai == TextMessages.Itemvalue.TrangThaiHoc_ChuaHoc || itemInfo.TrangThai == TextMessages.Itemvalue.TrangThaiHoc_KT_ChuaCC) || itemInfo.TrangThai == "")
                        {
                            if (DateTime.Compare(itemInfo.DateNgayBatDau, DateTime.Now) <= 0 && DateTime.Compare(itemInfo.DateNgayKetThuc, DateTime.Now) >= 0)
                            {
                                itemInfo.TrangThai = TextMessages.Itemvalue.TrangThaiHoc_DangHoc;
                            }
                            else if (DateTime.Compare(itemInfo.DateNgayKetThuc, DateTime.Now) < 0)
                            {
                                itemInfo.TrangThai = TextMessages.Itemvalue.TrangThaiHoc_KT_ChuaCC;
                            }
                            else
                            {
                                itemInfo.TrangThai = TextMessages.Itemvalue.TrangThaiHoc_ChuaHoc;
                            }

                        }
                        hvxeplop.Add(itemInfo);
                        chon = false;
                        count++;
                    }
                }
                if (hvxeplop.Count > 0)
                {

                    hvxeplop.Save();
                    LoadHocVienDaXepLop();
                    LoadHocVienChuaXepLop();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radCheckBoxAllDaXepLop_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewHocvien.ChildRows)
                {
                    rowInfo.Cells["Chon"].Value = radCheckBoxAllDaXepLop.Checked;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radCheckBoxAllChuaXepLop_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridViewHocVienChuacolop.ChildRows)
                {
                    rowInfo.Cells["Chon"].Value = radCheckBoxAllChuaXepLop.Checked;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void PrintDanhSachHocVien()
        {
            if (hocviendaxeplop == null)
            {
                LoadHocVienDaXepLop();
            }

            ExportHanhChinh ex = new ExportHanhChinh();
            ExportLib.Entities.HanhChinh.B100_BaoCaoChung cv = new ExportLib.Entities.HanhChinh.B100_BaoCaoChung();
            cv.E_Content = new List<ExportLib.Entities.HanhChinh.B100_Table>();
            cv.E_TieuDe = new List<string>() { "Họ tên", "Ngày sinh", "Trình độ", "Nơi công tác", "Điện thoại", "Ghi Chú", TextMessages.Itemvalue.RemoveSimblo };
            cv.E_Width = new List<string>() { "160", "70", "100", "230", "90", "", "" };
            string PhongBan = string.Empty;
            string TenLop = string.Empty;
            foreach (DT_LienTuc_HocVien_Info itemInfo in hocviendaxeplop)
            {

                ExportLib.Entities.HanhChinh.B100_Table cvItem = new ExportLib.Entities.HanhChinh.B100_Table();
                cvItem.E_Value = new List<string>() { itemInfo.HoTen, itemInfo.NgaySinh, itemInfo.TenTrinhDo, itemInfo.TenBenhVien, itemInfo.DiDong, itemInfo.GhiChu, TextMessages.Itemvalue.RemoveSimblo + itemInfo.NgayDangKi };
                cv.E_Content.Add(cvItem);
                PhongBan = itemInfo.TenPhongQuanLy;
                cv.E_TieuDeLop = itemInfo.TenLopHoc;
                cv.E_MaLop = itemInfo.MaLopHoc;
                TenLop = itemInfo.NoiDungDaoTao;
            }
            cv.E_TieuDeBaoCao = "Danh sách học viên";
            cv.E_NguoiKi = PTIdentity.FullName;
            cv.E_ThongTinKhac = string.Format("KHÓA ĐÀO TẠO: {0}", TenLop);
            cv.E_CongHoaXaHoi = "bM.09.07";
            cv.E_DocLapTuDo = string.Empty;
            cv.E_TenTrungTam = cv.E_TenBenhVien == "BỆNH VIỆN BẠCH MAI" ? "TRUNG TÂM ĐÀO TẠO VÀ CHỈ ĐẠO TUYẾN" : PhongBan;
            cv.E_isCenter = false;
            cv.E_TuNgayDenNgay = string.Format("Từ ngày {0} đến ngày {1}", netLink_DatePickerNgayBatDau.Value_String, netLink_DatePickerNgayKetThuc.Value_String);
            ex.B100_GenReport(cv);

        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {

                ExportLib.Entities.DaoTao.DanhSachBangTheoDoiChiTieuThucHanh ds = new ExportLib.Entities.DaoTao.DanhSachBangTheoDoiChiTieuThucHanh();
                ds.list = new List<ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh>();
                if (hocviendaxeplop != null)
                {
                    foreach (DT_LienTuc_HocVien_Info hv in hocviendaxeplop)
                    {
                        if (!string.IsNullOrEmpty(hv.MaHocVien) && !string.IsNullOrEmpty(hv.MaLopHoc))
                        {
                            ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh b1 = new ExportLib.Entities.DaoTao.BangTheoDoiChiTieuThucHanh();
                            b1.HoTenHocVien = hv.HoTen;
                            b1.ThoiGianBatDau = hv.NgayBatDau;
                            b1.ThoiGianKetThuc = hv.NgayKetThuc;
                            b1.DonViCongTac = hv.TenBenhVien;
                            b1.TenKhoaDaoTao = hv.TenChuyenKhoaLopHoc;
                            b1.TenLop = hv.TenLopHoc + " (<i>" + hv.MaLopHoc + "</i> )";
                            ds.list.Add(b1);
                        }
                    }
                }

                ExportLib.ExportDaoTao dt = new ExportDaoTao();
                dt.ExportBangTheoDoiChiTieuThucHanh(ds, 20);
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
                PrintDanhSachHocVien();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void netLink_DatePickerNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SetMaLopHoc();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void LoadDiaDiemDaoTao()
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
            function.ItemFilterCondition_String = objLophoc.MaLop;
            bindingSourceDiaDiem.DataSource = DT_LienTuc_LopHoc_DiaDiemToChuc_Coll.GetDT_LienTuc_LopHoc_DiaDiemToChuc_Coll(function);
        }
        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(objLophoc.MaLop))
                {
                    FormMode modex = new FormMode();
                    if (objLophoc != null && !string.IsNullOrEmpty(objLophoc.MaLop))
                        modex.Item = objLophoc.MaLop;
                    else
                        modex.Item = radTextBoxMaLop.Text;
                    Form_LT_LopHocDiaDiemToChuc fr = new Form_LT_LopHocDiaDiemToChuc(modex);
                    fr.ShowDialog();
                    LoadDiaDiemDaoTao();
                }
                else
                {
                    GlobalCommon.ShowErrorMessager("Lớp học chưa được khởi tạo");
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton5_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(objLophoc.MaLop))
                    LoadDiaDiemDaoTao();
                else
                    GlobalCommon.ShowErrorMessager("Lớp học chưa được khởi tạo");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (radGridDiaDiem.CurrentRow != null && radGridDiaDiem.CurrentRow.Cells["ID"].Value != null && GlobalCommon.AcceptDelete())
                {
                    DT_LienTuc_LopHoc_DiaDiemToChuc.DeleteDT_LienTuc_LopHoc_DiaDiemToChuc(Convert.ToInt32(radGridDiaDiem.CurrentRow.Cells["ID"].Value));
                    LoadDiaDiemDaoTao();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void netLink_DatePickerNgayBatDau_Leave(object sender, EventArgs e)
        {

        }

       
        private void btnPrint_Click(object sender, EventArgs e)
        {
          
            objLophoc = DT_LienTuc_LopHoc.GetDT_LienTuc_LopHoc_KQ(radTextBoxMaLop.Text);        
                G003_GiayDeNghiThuTienHocPhi denghithuhocphi = new G003_GiayDeNghiThuTienHocPhi();

                denghithuhocphi.MaHocVienBarCode = (GlobalCommon.GetBarCode(Convert.ToString(objLophoc.Id), false, BarcodeLib.TYPE.CODE128, 420, 90));

                if (dropDownChuyenKhoa1.Selected_Item != null)
                    denghithuhocphi.DiaDiemDangKy = dropDownChuyenKhoa1.Selected_TextValue.ToString();
                objLophoc.NgayBatDau = netLink_DatePickerNgayBatDau.Value_String;
                objLophoc.NgayKetThuc = netLink_DatePickerNgayKetThuc.Value_String;
                int month = GlobalCommon.DateTimeProcess.MinusDateTime_Month(objLophoc.NgayBatDau, objLophoc.NgayKetThuc);
                double sotienmoithang = 0;
                if (!string.IsNullOrEmpty(objLophoc.HocPhi))
                    sotienmoithang = Convert.ToInt64(objLophoc.HocPhi) / month;
                
                    FromNhapSoTien frm = new FromNhapSoTien();
                    frm.ShowDialog();
                    SoLuong = ModuleDaoTao.UI.FromNhapSoTien.soLuong;
                    DonGia = ModuleDaoTao.UI.FromNhapSoTien.donGia;
                    ThanhTien = ModuleDaoTao.UI.FromNhapSoTien.thanhTien;
                    string TongHocPhiStr1 = string.Format("Số lượng học viên :{0} x Đơn giá :{1} = {2} VND", GlobalCommon.ConvertMoney(SoLuong), GlobalCommon.ConvertMoney(DonGia), GlobalCommon.ConvertMoney(ThanhTien));
                    denghithuhocphi.BangChu = GlobalCommon.StringProcess.NumberToString.ConvertToStringMoney(ThanhTien);
                    denghithuhocphi.TongTienHocPhi = TongHocPhiStr1;
                
           
                if (dropDownCanBophutrach.Selected_TextValue != null && txtCanBo.Text=="")
                {
                    denghithuhocphi.HoTenHocVien = dropDownCanBophutrach.Text;
                    denghithuhocphi.NgaySinh = objLophoc.NgaySinh;
                    denghithuhocphi.GioiTinh = objLophoc.GioiTinhCBT;
                    denghithuhocphi.TrinhDo = objLophoc.TrinhDo;
                }
               if(dropDownCanBophutrach.Selected_TextValue!=null && txtCanBo.Text!="")
                {
                    denghithuhocphi.HoTenHocVien=txtCanBo.Text;
                    denghithuhocphi.NgaySinh = "";
                    denghithuhocphi.GioiTinh = radGioiTinh.Text;
                    denghithuhocphi.TrinhDo = "";                 
                }
                denghithuhocphi.NgayViet = GlobalCommon.StringProcess.ForReport.NgayThangNam(DateTime.Now);
                denghithuhocphi.NoiCongTac = string.Format("{0} - Bệnh Viện Bạch Mai", dropDownChuyenKhoa1.Selected_TextValue.ToString());
                denghithuhocphi.TongSoThoiGianHoc = GlobalCommon.StringProcess.ForReport.TongThoiGianHoc(objLophoc.NgayBatDau, objLophoc.NgayKetThuc);

              
                denghithuhocphi.NoiDungHoc = objLophoc.TenLop;
                denghithuhocphi.IDHocVien =objLophoc.Id;
                ExportDaoTao daotao = new ExportDaoTao();

                ReportDocument doc = daotao.G003_GiayDeNghiThuTienHocPhi(new List<ExportLib.Entities.DaoTao.G003_GiayDeNghiThuTienHocPhi>() { denghithuhocphi });

                if (DKien == 1)
                {
                    doc.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM THẺ HỌC VIÊN");
                    doc.SetParameterValue("NoiDung", "TCKT thu tiền làm thẻ cho học viên với mức kinh phí là :");
                }
                if (DKien == 2)
                {
                    doc.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM CHỨNG CHỈ");
                    doc.SetParameterValue("NoiDung", "TCKT thu tiền làm chứng chỉ cho học viên với mức kinh phí là :");
                }
            if(objLophoc.Id!=null)
            {
                doc.SetParameterValue("ID", "IDLH");
            }
                FormMode newmode = new FormMode();
                newmode.Item = doc;
                if (DonGia != 0 && SoLuong != 0)
                {
                    NetLinkReport fr = new NetLinkReport(newmode);
                    fr.Show();
                }              
            }
        private void radCheck_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radCheck.Checked == true)          
            {
                txtCanBo.Enabled = true;
                radGioiTinh.Enabled = true;
            } 
            else
            {
                txtCanBo.Enabled = false;
                radGioiTinh.Enabled = false;
            }
        }

        private void radGridViewGiangVien_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //if (radGridViewGiangVien.CurrentColumn.Name == "btnAddLichGiang")
            //{
            //    Form_Add_LichGiang frm = new Form_Add_LichGiang(objLophoc.MaLop, objLophoc.TenLop, Convert.ToDateTime(objLophoc.NgayBatDau), Convert.ToDateTime(objLophoc.NgayKetThuc), Convert.ToInt64(radGridViewGiangVien.CurrentRow.Cells["IDGiangVien"].Value));
            //    frm.ShowDialog();
            //}
        }

        private void btnAddLichGiang_Click(object sender, EventArgs e)
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);
            function.Item = objLophoc.MaLop;
            bindingSourceGiangVien.DataSource = DT_LienTuc_GiangVien_Coll.GetDT_LienTuc_GiangVien_Coll(function);
            if (bindingSourceGiangVien.Count > 0)
            {
                Form_Add_LichGiang frm = new Form_Add_LichGiang(objLophoc.MaLop, objLophoc.TenLop, Convert.ToDateTime(objLophoc.NgayBatDau), Convert.ToDateTime(objLophoc.NgayKetThuc), dropDownTrinhDo1.Text, dropDownNguonKinhPhi.Text);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Bạn phải thêm giảng viên trước khi thêm lịch giảng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnBangChamCong_Click(object sender, EventArgs e)
        {
            Form_BangChamCongGV frm = new Form_BangChamCongGV(objLophoc.MaLop, objLophoc.TenLop,objLophoc.NgayBatDau,objLophoc.NgayKetThuc);
            frm.ShowDialog();
        }
    }
}
