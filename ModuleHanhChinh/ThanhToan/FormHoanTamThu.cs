using System;
using ModuleHanhChinh.LIB;
using NETLINK.UI;
using NETLINK.LIB;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Authoration.LIB;
using System.Threading.Tasks;
using System.IO;
using ExportLib.Entities.DaoTao;
using ExportLib;
using CrystalDecisions.CrystalReports.Engine;
using System.Diagnostics;
using Csla;
using Csla.Data;

namespace ModuleHanhChinh.ThanhToan
{
    public partial class FormHoanTamThu : Telerik.WinControls.UI.RadForm
    {
        #region Declare
        private DataTable dt;
        private bool _isNew;
        private Int64 _intIDHocVien;
        private string _strMaHocVien = string.Empty;
        private string _strTenHocVien = string.Empty;
        private string _strTrinhDo = string.Empty;
        private string _strSoCMT = string.Empty;
        private string _strHinhThucHoc = string.Empty;
        private string _strNoiDungHoc = string.Empty;
        private LoadHocVien _oLoadHocVien = new LoadHocVien();
        private BienLaiTamThu _oBienlaitamthu;
        private BienLaiTamThu _oBienlaitamthuInfo;
        public event EventHandler RefreshPatientLoad;
        static DateTime dteNow = GlobalCommon.GetTimeServer();
        string stryyMMdd = dteNow.ToString("yyMMdd");

        private HoanTamThu _oBienLaiHoanTamThu;
        private HoanTamThu _oHoanTamThu;
        private HoanTamThu_Coll _oHoanTamThu_ChiTiet_coll;
        private decimal _decTongHoan = 0;//Luu so tien bien lai hoan phai hoan 
        public bool _isFirstActivate = false;
        Int64 IDBienLai = 0;
        /// Luu so phieu hoan ky quy vua duoc tao
        /// </summary>
        private string _strNewSoPhieuHoan = string.Empty;
        /// <summary>
        /// Danh cho không thao tác chọn bệnh nhân trên grid ngoài form main
        /// </summary>

        #endregion

        public bool IsNew
        {
            get { return _isNew; }
        }
        public Int64 IDHocVien
        {
            get { return _intIDHocVien; }
            set { _intIDHocVien = value; }
        }
        public string MaHocVien
        {
            get { return _strMaHocVien; }
            set { _strMaHocVien = value; }
        }
        public string TenHocVien
        {
            get { return _strTenHocVien; }
            set { _strTenHocVien = value; }
        }
        public string TrinhDo
        {
            get { return _strTrinhDo; }
            set { _strTrinhDo = value; }
        }
        public string SoCMT
        {
            get { return _strSoCMT; }
            set { _strSoCMT = value; }
        }
        public string HinhThucHoc
        {
            get { return _strHinhThucHoc; }
            set { _strHinhThucHoc = value; }
        }
        public string NoiDungHoc
        {
            get { return _strNoiDungHoc; }
            set { _strNoiDungHoc = value; }
        }
        //public HoanTamThu()
        //{
        //    InitializeComponent();
        //}

         #region Constructor

        public FormHoanTamThu()
        {
            InitializeComponent();
            //loadPatientUC1.DoiTuong = 9;
            //EnableControl(false);
        }
        /// <summary>
        /// Dành cho trường hợp chọn bệnh nhân trước khi chọn menu vào form
        /// </summary>
        public FormHoanTamThu(Int64 intIDHocVien)
        {
            InitializeComponent();
            //loadPatientUC1.LoaiPatientForRightClick(strSoHSBA, "", 9);
            _intIDHocVien = this._oLoadHocVien.IDHocVien;
        }

        #endregion
        private void InititialValue()
        {


            _oLoadHocVien.IDHocVien = _intIDHocVien;
            _oLoadHocVien.MaHocVien = _strMaHocVien;
            _oLoadHocVien.TenHocVien = _strTenHocVien;
            _oLoadHocVien.TrinhDo = _strTrinhDo;
            _oLoadHocVien.SoCMT = _strSoCMT;
            _oLoadHocVien.HinhThucHoc = _strHinhThucHoc;
            _oLoadHocVien.NoiDungHoc = _strNoiDungHoc;

            this.bindHocVien.DataSource = _oLoadHocVien;
            this.bindHocVien.RaiseListChangedEvents = true;
            this.bindHocVien.ResetBindings(false);

        }

        public void RefreshValue()
        {
            _oLoadHocVien = new LoadHocVien();
            _intIDHocVien = 0;
            _strMaHocVien = "";
            _strTenHocVien = "";
            _strTrinhDo = "";
            _strSoCMT = "";
            _strHinhThucHoc = "";
            _strNoiDungHoc = "";
            this.bindHocVien.DataSource = _oLoadHocVien;
            _oBienlaitamthu = BienLaiTamThu.NewBienLaiTamThu();
            //this.bindBienLaiTamThu.DataSource = _oBienlaitamthu;
            //ClearForm();
            ///// Refresh cac gia tri cua Load patient UC         
        }

        private void GetValuesFromDataTable()
        {
            foreach (DataRow dr in dt.Rows)
            {
                _intIDHocVien = Convert.ToInt64(dr["IDHocVien"].ToString());
                _strMaHocVien = dr["MaHocVien"].ToString();
                _strTenHocVien = dr["TenHocVien"].ToString();
                _strTrinhDo = dr["TrinhDo"].ToString();
                _strSoCMT = dr["SoCMT"].ToString();// khoa dang lam viec la  khoa cua benh nhan                
                _strHinhThucHoc = dr["HinhThucHoc"].ToString();
                _strNoiDungHoc = dr["NoiDungHoc"].ToString();
            }
            InititialValue();
        }
        private void txtMaHocVien_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    dt = new DataTable();
            //    HocVienSearch.search(ref dt, Convert.ToInt64(this.txtMaHocVien.Text));
            //    if (dt.Rows.Count == 1)
            //        GetValuesFromDataTable();
            //    _intIDHocVien = this._oLoadHocVien.IDHocVien;
            //    _oBienLaiHoanTamThu = HoanTamThu.NewHoanTamThu();
            //    EnableControl(true); //Cho hien cac dieu khien
            //    _oBienLaiHoanTamThu.SoPhieu = GlobalCommon.CreateMaBienLai(int.Parse(GlobalCommon.GetTimeServer().ToString("yyyy")), _oLoadHocVien.MaHocVien);
            //    _oBienLaiHoanTamThu.SoPhieuHoan = HoanTamThu.CreateMaBienLai(int.Parse(stryyMMdd));
            //    _oBienLaiHoanTamThu.IDHocVien = _intIDHocVien;
            //    _isNew = _oBienLaiHoanTamThu.IsNew;
            //    ApplyAuthorizationRules();
            //    _oBienLaiHoanTamThu.IDNguoiHoan = PTIdentity.IDNguoiDung;
            //    _oBienLaiHoanTamThu.NguoiThu = PTIdentity.FullName;
            //    _oBienLaiHoanTamThu.NgayHoan = GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy");
            //    _oBienLaiHoanTamThu.NguoiNhan = _oLoadHocVien.TenHocVien;
            //    _oBienLaiHoanTamThu.Lydo = "Hủy";
            //    this.bindTamUngColl.DataSource = BienLaiTamThuColl.GetBienLaiTamThuColl(_oBienLaiHoanTamThu.IDHocVien);
            //    this.bindHoanTamUng.DataSource = _oBienLaiHoanTamThu;
            //    soBienLaiTextBox.Focus();
            //    RefreshForm(HoanTamThu.NewHoanTamThu());
            //}

        }

        private void buttonLamSach_Click(object sender, EventArgs e)
        {
            RefreshValue();
            if (RefreshPatientLoad != null)
            {
                RefreshPatientLoad(this, EventArgs.Empty);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshForm(HoanTamThu oBienlaihoantamthu)
        {
            _oBienLaiHoanTamThu = oBienlaihoantamthu;

            //_oHoanTamThu_ChiTiet_coll = BienLaiTamThuColl.GetHoanTamThu_ChiTiet_Coll(_intIDHocVien);
            //bindTamUngColl.DataSource = BienLaiTamThuColl.GetBienLaiTamThuColl(_oBienLaiHoanTamThu.IDHocVien);
            //kiểm tra xem có ký quỹ nào không
            //Nếu không có thì return;
            //có thì gắn đối tượng cho chạy tiếp
            if (BienLaiTamThuColl.GetBienLaiTamThuColl(_oBienLaiHoanTamThu.IDHocVien).Count < 1)
            {
                MessageBox.Show("Bệnh nhân hiện tại không có ký quỹ nào để hoàn cả.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _oBienLaiHoanTamThu.CancelEdit();
                return;
            }
            else
            {
                foreach (BienLaiTamThuInfo info in bindTamUngColl.List)
                {
                    HoanTamThuCT_Info infoAdd = HoanTamThuCT_Info.NewHoanTamThuCT_Info();
                    infoAdd.IDBienLaiTamUng = info.IDBienLai;
                    //_oBienLaiHoanTamThu.HoanTamThuCT_Child.Add(infoAdd);
                }
            }


            //if (GetBienLaiKyQuyHoan(_lngIDDieuTri))
            //    EnableControl(true);
            //else
            //    EnableControl(false);
            if (_oBienLaiHoanTamThu.IsNew)
            {
                //Gan mac dinh cho phieu hoan ky quy
                _oBienLaiHoanTamThu.NguoiThu = GlobalCommon.GetTenDayDu();
                _oBienLaiHoanTamThu.SoTien = _decTongHoan;
                _oBienLaiHoanTamThu.NguoiNhan = PTIdentity.FullName;
                //Lay ve ngay cua may chu
                DateTime oServerTime = GlobalCommon.GetTimeServer();
                _oBienLaiHoanTamThu.NgayHoan = oServerTime.ToString("dd/MM/yyyy");
                _oBienLaiHoanTamThu.SoPhieuHoan = HoanTamThu.CreateMaBienLai(int.Parse(stryyMMdd));
                _strNewSoPhieuHoan = _oBienLaiHoanTamThu.SoPhieuHoan;
            }
            bindHoanTamUng.DataSource = _oBienLaiHoanTamThu;
            this.bindTamUngColl.DataSource = _oHoanTamThu_ChiTiet_coll;
           // ApplyAuthorizationRules();
        }


        private void radbtnSave_Click(object sender, EventArgs e)
        {
            SaveData(true);
            //using (StatusBusy busy = new StatusBusy("Lưu trữ..."))
            //{
            //    this.bindHoanTamUng.RaiseListChangedEvents = false;
            //    // do the save
            //    this.bindHoanTamUng.EndEdit();
            //    try
            //    {
            //        _oBienLaiHoanTamThu.IDHocVien = _intIDHocVien;
            //        //Lay nguoi dung hien tai
            //        _oBienLaiHoanTamThu.IDNguoiHoan = PTIdentity.IDNguoiDung;
            //        HoanTamThu oTemp = _oBienLaiHoanTamThu.Clone();
            //        _oBienLaiHoanTamThu = oTemp.Save();
            //        ////Xóa số phiếu hoàn ký quỹ
            //        //if (!_strNewSoPhieuHoan.Equals(""))
            //        //{
            //        //    HoanTamThu.XoaSoPhieuHoan(_strNewSoPhieuHoan);
            //        //    _strNewSoPhieuHoan = "";
            //        //}
            //        ////In phiếu hoàn ký quỹ
            //        ////if (GlobalCommon.CoTonTai("IP_HoanKyQuy", "IDPhieuHoan", _oBienLaiHoanKyQuy.IDPhieuHoan.ToString()))
            //        ////   // InPhieuHoan();
            //        this.Close();
            //        //Binding
            //        // rebind the UI
            //        this.bindHoanTamUng.DataSource = null;
            //        this.bindHoanTamUng.DataSource = _oBienLaiHoanTamThu;
            //    }
            //    catch (Exception ex)
            //    {
            //        if (_oBienLaiHoanTamThu.IsDirty)
            //            GlobalCommon.ShowError("Lưu phiếu hoàn ký quỹ bị lỗi: " + ex.Message, "Lỗi lưu phiếu hoàn ký quỹ");
            //        else
            //            GlobalCommon.ShowError("Lưu phiếu hoàn ký quỹ thành công, nhưng In phiếu hoàn bị lỗi: " + ex.Message, "Lỗi in phiếu hoàn ký quỹ");
            //    }
            //    //finally
            //    //{
            //    //    this._oBienLaiHoanTamThu.RaiseListChangedEvents = true;
            //    //    this._oBienLaiHoanTamThu.ResetBindings(false);
            //    //}
            //}
        }

        protected void SaveData(bool rebind)
        {
            using (StatusBusy busy = new StatusBusy("Lưu trữ..."))
            {
                this.bindHoanTamUng.RaiseListChangedEvents = false;
                // do the save
                this.bindHoanTamUng.EndEdit();
                try
                {
                    _oBienLaiHoanTamThu.IDHocVien = _intIDHocVien;
                    //Lay nguoi dung hien tai
                    _oBienLaiHoanTamThu.IDNguoiHoan = PTIdentity.IDNguoiDung;
                    HoanTamThu oTemp = _oBienLaiHoanTamThu.Clone();
                    _oBienLaiHoanTamThu = oTemp.Save();
                    ////Xóa số phiếu hoàn ký quỹ
                    //if (!_strNewSoPhieuHoan.Equals(""))
                    //{
                    //    HoanTamThu.XoaSoPhieuHoan(_strNewSoPhieuHoan);
                    //    _strNewSoPhieuHoan = "";
                    //}
                    ////In phiếu hoàn ký quỹ
                    ////if (GlobalCommon.CoTonTai("IP_HoanKyQuy", "IDPhieuHoan", _oBienLaiHoanKyQuy.IDPhieuHoan.ToString()))
                    ////   // InPhieuHoan();
                    this.Close();
                    //Binding
                    // rebind the UI
                    this.bindHoanTamUng.DataSource = null;
                    this.bindHoanTamUng.DataSource = _oBienLaiHoanTamThu;
                }
                catch (Exception ex)
                {
                    if (_oBienLaiHoanTamThu.IsDirty)
                        GlobalCommon.ShowError("Lưu phiếu hoàn ký quỹ bị lỗi: " + ex.Message, "Lỗi lưu phiếu hoàn ký quỹ");
                    else
                        GlobalCommon.ShowError("Lưu phiếu hoàn ký quỹ thành công, nhưng In phiếu hoàn bị lỗi: " + ex.Message, "Lỗi in phiếu hoàn ký quỹ");
                }
                //finally
                //{
                //    this._oBienLaiHoanTamThu.RaiseListChangedEvents = true;
                //    this._oBienLaiHoanTamThu.ResetBindings(false);
                //}
            }
        }
    }
}
