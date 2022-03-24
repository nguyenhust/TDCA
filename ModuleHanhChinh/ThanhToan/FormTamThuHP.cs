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
using NETLINK.UI.Form;
using Telerik.WinControls.UI;
using System.Drawing.Printing;
using ModuleDaoTao.UI;
using Telerik.WinControls.UI;
using System.Net;
using NETLINK.LIB;
using ModuleHanhChinh.LIB;
using DanhMuc.LIB;
namespace ModuleHanhChinh.ThanhToan
{
   public delegate void NumberReportPrint(bool _isThanhToan, int i);
    public partial class FormTamThuHP : NETLINK.UI.Dictionary
    {

        public static Boolean _Huy;
        public static decimal _SoTien;
        //string iDbienLaiList=string.Empty;
        private FormMode formMode = new FormMode();
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
        private LoadLopHoc _oLoadLopHoc = new LoadLopHoc();
        private BienLaiTamThu _oBienlaitamthu;
        private BienLaiTamThu _oBienlaitamthuInfo;
        private BienLaiTamThuColl obj;
        string Bien;
        public event EventHandler RefreshPatientLoad;

        bool Huy = false;
        string user = string.Empty;
        string pathFile = string.Empty;
        string Status = string.Empty;
        string soHoaDon = string.Empty;
        bool In = true;
        byte? DK;
        Int64 iDBienLai = 0;
        int soLanIn = 0;
       private Int64 intiDPhieuHuy;

        string soTiepNhan = string.Empty;
        public bool IsNew
        {
            get { return _isNew; }
        }
        public Int64 IDPhieuHuy
        {
            get { return intiDPhieuHuy; }
            set { intiDPhieuHuy = value; }
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
        public FormTamThuHP()
        {
            InitializeComponent();
            RadGrid = radgDSBienLai;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            this.RadGrid.Columns["STT"].ReadOnly = true;
            btnSave.Enabled = true;
            radgDSBienLai.AllowAddNewRow = false;       
        }
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
            this.bindBienLaiTamThu.DataSource = _oBienlaitamthu;
            ClearForm();
            /// Refresh cac gia tri cua Load patient UC         
        }
        private void txtMaHocVien_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    dt = new DataTable();
            //        HocVienSearch.search(ref dt, this.txtMaHocVien.Text);
            //        if (dt.Rows.Count == 1)
            //            GetValuesFromDataTable();
            //        AddNew();
            //}

        }
        private void FormTamThuHP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.F2)
                {
                    //btnAdd.PerformClick();
                }
                if (e.KeyData == Keys.F3)
                {
                    btnSave.PerformClick();
                }
                if (e.KeyData == Keys.F4)
                {
                    //btnDelete.PerformClick();
                }

                if (e.KeyData == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        private void FormTamThuHP_Load(object sender, EventArgs e)
        {
            this.txtMaHocVien.Focus();
            btnSave.Enabled = true;
        }
        private void ClearForm()
        {

            _oBienlaitamthu.SoTien = 0;
            _oBienlaitamthu.NgayThu = GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy");
            _oBienlaitamthu.NguoiDong = "";
            _oBienlaitamthu.HinhThucThu = 0;
            this.comboBoxThanToans.SelectedIndex = 0;
        }
        private void buttonLamSach_Click(object sender, EventArgs e)
        {
            RefreshValue();
            if (RefreshPatientLoad != null)
            {
                RefreshPatientLoad(this, EventArgs.Empty);
            }
        }
        
        protected void SaveData(bool rebind)
        {
            using (StatusBusy busy = new StatusBusy("Lưu trữ..."))
            {
                this.bindBienLaiTamThuInfo.RaiseListChangedEvents = false;
                // do the save
                this.bindBienLaiTamThuInfo.EndEdit();
                try
                {

                    BienLaiTamThu oTemp = _oBienlaitamthu.Clone();
                    _oBienlaitamthu = oTemp.Save();
                    if (rebind)
                    {
                        // rebind the UI
                        this.bindBienLaiTamThuInfo.DataSource = null;
                        this.bindBienLaiTamThuInfo.DataSource = _oBienlaitamthu;
                    }
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowErrorMessager(ex);
                }
                finally
                {
                    this.bindBienLaiTamThuInfo.RaiseListChangedEvents = true;
                    this.bindBienLaiTamThuInfo.ResetBindings(false);
                }                
            }           
            //MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadDanhSachKyQuy()
        {
            //this.bindBienLaiTamThu.DataSource = BienLaiTamThuColl.GetBienLaiTamThuColl(_oBienlaitamthu.IDHocVien);
            this.radgDSBienLai.DataSource = BienLaiTamThuColl.GetBienLaiTamThuColl(_oBienlaitamthu.IDHocVien);
           
        }
        protected void AddNew()
        {
            //ClearForm();
            _intIDHocVien = this._oLoadHocVien.IDHocVien;
            _oBienlaitamthu = BienLaiTamThu.NewBienLaiTamThu();
            //EnableControl(true); //Cho hien cac dieu khien
            _oBienlaitamthu.MaBienLai = GlobalCommon.CreateMaBienLai(int.Parse(GlobalCommon.GetTimeServer().ToString("yyyy")), GlobalCommon.GetTenDangNhap(PTIdentity.IDNguoiDung));
            _oBienlaitamthu.IDHocVien = _intIDHocVien;
            _isNew = _oBienlaitamthu.IsNew;
            //ApplyAuthorizationRules();
            _oBienlaitamthu.IDNguoiThu = PTIdentity.IDNguoiDung;
            _oBienlaitamthu.NguoiThu = PTIdentity.FullName;
            _oBienlaitamthu.NgayThu = GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy");
            _oBienlaitamthu.HinhThucThu = 0;
            _oBienlaitamthu.XuatHD = false;
            _oBienlaitamthu.NguoiDong = _oLoadHocVien.TenHocVien;
            _oBienlaitamthu.Reference_Code = "";
            _oBienlaitamthu.SoLan = 1;
            _oBienlaitamthu.SoLanIn = 1;
            _oBienlaitamthu.LoaiPhieu = 0;
            LoadDanhSachKyQuy();
            this.bindBienLaiTamThuInfo.DataSource = _oBienlaitamthu;
            this.comboBoxThanToans.SelectedIndex = 0;
            this.radNoiDung.SelectedIndex = 0;
        }

        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        public void InBienLai(bool _isThToan, int i)
        {
            PreviewReport PreviewReport = new PreviewReport();
            ReportDocument ReportDocument = new ReportDocument();
            PreviewReport.Text = "Biên lai tạm thu";

            ReportDocument.Load(AppConfig.ReportPath + "rptBienLaiTamThu.rpt");

            ModuleHanhChinh.ThanhToan.BaoCao dsData = new ModuleHanhChinh.ThanhToan.BaoCao();
            dsData.Clear();
            dsData.HoaDonThanhToanBarCode.AddHoaDonThanhToanBarCodeRow(GlobalCommon.GetBarCode(_oLoadHocVien.MaHocVien, false, BarcodeLib.TYPE.CODE128, 420, 90));
            ReportDocument.SetDataSource(dsData);
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {

                    cm.CommandText = "HoaDonThanhToan";
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@IDHocVien", this._oLoadHocVien.IDHocVien);
                    cm.Parameters.AddWithValue("@MaBienLai", this._oBienlaitamthu.MaBienLai);
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "HoaDonThanhToan");
                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                            return;
                        }
                        ReportDocument.SetDataSource(ds);
                        PreviewReport.crystalReportViewer.ReportSource = ReportDocument;
                        ReportDocument.SetParameterValue("NguoiLap", PTIdentity.FullName);
                        ReportDocument.SetParameterValue("LanIn", "1");
                        if (i == 1)
                            ReportDocument.SetParameterValue("Lien", "Liên 1: Lưu");
                        if (i == 2)
                            ReportDocument.SetParameterValue("Lien", "Liên 2 : Xác nhận của trung tâm");
                        if (i == 3)
                            ReportDocument.SetParameterValue("Lien", "Liên 3 : Học viên giữ");
                        ReportDocument.SetParameterValue("NgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                        ReportDocument.SetParameterValue("ThoiGianServer", GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm:ss"));
                        if (i == 1)
                            PreviewReport.ShowDialog();
                    }
                }
            }
        }
        public void InBienLaiHoaDon(bool _isThToan)
        {
            #region Comment
            //PreviewReport PreviewReport = new PreviewReport();
            //ReportDocument ReportDocument = new ReportDocument();
            //PreviewReport.Text = "Biên lai tạm thu(HD)";
            //ReportDocument.Load(AppConfig.ReportPath + "rptBienLaiTamThu_XuatHD.rpt");
            //ModuleHanhChinh.ThanhToan.BaoCao dsData = new ModuleHanhChinh.ThanhToan.BaoCao();
            //dsData.Clear();
            //dsData.SoHoaDonBarCode.AddSoHoaDonBarCodeRow(GlobalCommon.GetBarCode(GlobalCommon.GetSoHoaDon(_oLoadHocVien.IDHocVien), false, BarcodeLib.TYPE.CODE128, 420, 90));
            //ReportDocument.SetDataSource(dsData);
            //using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            //{
            //    cn.Open();
            //    using (SqlCommand cm = cn.CreateCommand())
            //    {

            //        cm.CommandText = "HoaDonThanhToan_XuatHD";
            //        cm.CommandType = CommandType.StoredProcedure;
            //        cm.Parameters.AddWithValue("@IDHocVien", this._oLoadHocVien.IDHocVien);
            //        using (SqlDataAdapter da = new SqlDataAdapter(cm))
            //        {
            //            DataSet ds = new DataSet();
            //            da.Fill(ds, "HoaDonThanhToan");
            //            if (ds.Tables[0].Rows.Count <= 0)
            //            {
            //                GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
            //                return;
            //            }
            //            ReportDocument.SetDataSource(ds);
            //            PreviewReport.crystalReportViewer.ReportSource = ReportDocument;
            //            ReportDocument.SetParameterValue("NguoiLap", PTIdentity.FullName);
            //            ReportDocument.SetParameterValue("LanIn", "1");
            //            ReportDocument.SetParameterValue("NgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
            //            ReportDocument.SetParameterValue("ThoiGianServer", GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm:ss"));
            //            if (i == 1)
            //                ReportDocument.SetParameterValue("Lien", "Liên 1: Lưu");
            //            if (i == 2)
            //                ReportDocument.SetParameterValue("Lien", "Liên 2 : Xác nhận của trung tâm");
            //            if (i == 3)
            //                ReportDocument.SetParameterValue("Lien", "Liên 3 : Học viên giữ");

            //            //PrintDialog _PrintDialog = new PrintDialog();
            //            //PrintDocument _PrintDocument = new PrintDocument();

            //            //_PrintDialog.Document = _PrintDocument; //add the document to the dialog box

            //            //_PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(AutoPrint);

            //            PreviewReport.ShowDialog();
            //        }
            //    }
            //}
            #endregion

            #region Print

            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();

                _PrintDialog.Document = _PrintDocument;

                //_PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(AutoPrint);
                DialogResult result = _PrintDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                }
            }
            catch (Exception)
            {

            }

            #endregion
        }

        private void CreateFileReport(bool _isThToan, int i)
        {
            try
            {
                PreviewReport PreviewReport = new PreviewReport();
                ReportDocument ReportDocument = new ReportDocument();
                PreviewReport.Text = "Biên lai tạm thu(HD)";
                ReportDocument.Load(AppConfig.ReportPath + "rptBienLaiTamThu_XuatHD.rpt");
                ModuleHanhChinh.ThanhToan.BaoCao dsData = new ModuleHanhChinh.ThanhToan.BaoCao();
                dsData.Clear();
                dsData.SoHoaDonBarCode.AddSoHoaDonBarCodeRow(GlobalCommon.GetBarCode(GlobalCommon.GetSoHoaDon(_oLoadHocVien.IDHocVien), false, BarcodeLib.TYPE.CODE128, 420, 90));
                ReportDocument.SetDataSource(dsData);
                using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                {
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {
                       
                            cm.CommandText = "HoaDonThanhToan_XuatHD";
                            cm.CommandType = CommandType.StoredProcedure;
                            cm.Parameters.AddWithValue("@IDHocVien", this._oLoadHocVien.IDHocVien);
                            //cm.Parameters.AddWithValue("@LoaiPhieu", radNoiDung.SelectedIndex);
                   
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds, "HoaDonThanhToan");
                            if (ds.Tables[0].Rows.Count <= 0)
                            {
                                GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                                return;
                            }
                            ReportDocument.SetDataSource(ds);
                            PreviewReport.crystalReportViewer.ReportSource = ReportDocument;
                            ReportDocument.SetParameterValue("NguoiLap", PTIdentity.FullName);
                            ReportDocument.SetParameterValue("LanIn", 1);

                            ReportDocument.SetParameterValue("LanIn", 1);

                            ReportDocument.SetParameterValue("NgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                            ReportDocument.SetParameterValue("ThoiGianServer", GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm:ss"));

                            ReportDocument.SetParameterValue("SoBienLai", txtMaBienLai.Text.Replace("/", ""));


                            ReportDocument.SetParameterValue("SoBienLai", txtMaBienLai.Text.Replace("/", ""));

                            if (_oBienlaitamthu.LoaiPhieu == 0)
                                ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN HỌC PHÍ");
                            if (_oBienlaitamthu.LoaiPhieu == 1)
                                ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM THẺ HỌC VIÊN");
                            if (_oBienlaitamthu.LoaiPhieu == 2)
                                ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM CHỨNG CHỈ");
                            if (i == 1)
                                ReportDocument.SetParameterValue("Lien", "Liên 1: Lưu");
                            if (i == 2)
                                ReportDocument.SetParameterValue("Lien", "Liên 2 : Xác nhận của trung tâm");
                            if (i == 3)
                                ReportDocument.SetParameterValue("Lien", "Liên 3 : Học viên giữ");
                            if(_oLoadHocVien.IDHocVien!=null)
                            {
                                ReportDocument.SetParameterValue("ID", "IDHV:");
                            }

                            ReportDocument.PrintToPrinter(1, false, 0, 0);
                        }
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Lấy dữ liệu bị lỗi\n" + err.ToString(), "Thông báo từ hệ thống");
            }
        }

        private void CreateFileReportAgain(bool _isThToan, int i)
        {
            try
            {
                PreviewReport PreviewReport = new PreviewReport();
                ReportDocument ReportDocument = new ReportDocument();
                PreviewReport.Text = "Biên lai tạm thu(HD)";
                ReportDocument.Load(AppConfig.ReportPath + "rptBienLaiTamThu_XuatHD.rpt");
                ModuleHanhChinh.ThanhToan.BaoCao dsData = new ModuleHanhChinh.ThanhToan.BaoCao();
                dsData.Clear();
                dsData.SoHoaDonBarCode.AddSoHoaDonBarCodeRow(GlobalCommon.GetBarCode(GlobalCommon.GetSoHoaDon(_oLoadHocVien.IDHocVien), false, BarcodeLib.TYPE.CODE128, 420, 90));
                ReportDocument.SetDataSource(dsData);
                using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                {
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {

                        cm.CommandText = "InLaiHoaDon";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@IDHocVien", this._oLoadHocVien.IDHocVien);
                        cm.Parameters.AddWithValue("@IDBienLai", iDBienLai);
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds, "HoaDonThanhToan");
                            if (ds.Tables[0].Rows.Count <= 0)
                            {
                                GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                                return;
                            }
                            ReportDocument.SetDataSource(ds);
                            PreviewReport.crystalReportViewer.ReportSource = ReportDocument;
                            ReportDocument.SetParameterValue("NguoiLap", _oBienlaitamthu.NguoiThu);
                            ReportDocument.SetParameterValue("LanIn", soLanIn + 1);

                            ReportDocument.SetParameterValue("LanIn", soLanIn + 1);

                            ReportDocument.SetParameterValue("NgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                            ReportDocument.SetParameterValue("ThoiGianServer", GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm:ss"));

                            ReportDocument.SetParameterValue("SoBienLai", txtMaBienLai.Text.Replace("/", ""));


                            ReportDocument.SetParameterValue("SoBienLai", txtMaBienLai.Text.Replace("/", ""));
                            if (_oBienlaitamthu.LoaiPhieu == 0)
                                ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN HỌC PHÍ");
                            if (_oBienlaitamthu.LoaiPhieu == 1)
                                ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM THẺ HỌC VIÊN");
                            if (_oBienlaitamthu.LoaiPhieu == 2)
                                ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM CHỨNG CHỈ");
                            if (i == 1)
                                ReportDocument.SetParameterValue("Lien", "Liên 1: Lưu");
                            if (i == 2)
                                ReportDocument.SetParameterValue("Lien", "Liên 2 : Xác nhận của trung tâm");
                            if (i == 3)
                                ReportDocument.SetParameterValue("Lien", "Liên 3 : Học viên giữ");
                            if (_oLoadHocVien.IDHocVien != null)
                            {
                                ReportDocument.SetParameterValue("ID", "IDHV:");
                            }
                            ReportDocument.PrintToPrinter(1, false, 0, 0);
                        }
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu ! !\n" + err.ToString(), "Thông báo từ hệ thống");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalCommon.AcceptUpdate())
                    if (_oBienlaitamthu.SoTien > 0)
                    {
                        SaveData(true);
                        if (_oBienlaitamthu.XuatHD == false)
                        {
                            GetBienLai(_oBienlaitamthu.IDHocVien);
                            Print();                         
                            LoadDanhSachKyQuy();
                        }
                    }
                
               // txtIDHocVien.Text = "";
               
             
                txtIDHocVien.Focus();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Print()
        {
            for (int i = 1; i <= 3; i++)
            {
                AutoPrintReport printReport = new AutoPrintReport();
                printReport.Notifi += new NumberReportPrint(CreateFileReport);
                printReport.PrintReport(true, i);
            }
            MessageBox.Show("Báo cáo đã in xong!", "Thông báo từ hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            //MessageBox.Show("Save and Bill finished printing!", "Notification from system", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void PrintAgain()
        {
            for (int i = 1; i <= 3; i++)
            {
                AutoPrintReport printReport = new AutoPrintReport();
                printReport.Notifi += new NumberReportPrint(CreateFileReportAgain);
                printReport.PrintReport(true, i);
            }
            MessageBox.Show("Báo cáo đã in xong!", "Thông báo từ hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            //MessageBox.Show("Save and Bill finished printing!", "Notification from system", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void comboBoxThanToans_SelectedIndexChanged(object sender, EventArgs e)
        {
            _oBienlaitamthu.HinhThucThu = Convert.ToByte(comboBoxThanToans.SelectedIndex);
        }

        private void radbtnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            AddNew();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            //GetBienLai(_oBienlaitamthu.IDHocVien);
            ////InBienLaiHoaDon(true);
            LoadDanhSachKyQuy();
            //AddNew();

            GetResponseHD(soTiepNhan);
        }
        private void GetBienLai(Int64 intIDHocVien)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "HoaDon_ins";
                    cmd.Parameters.AddWithValue("@IDHocVien", intIDHocVien);
                    cmd.Parameters.AddWithValue("@SoHoaDon", "");
                    cmd.Parameters.AddWithValue("@NgayHoaDon", Convert.ToDateTime(GlobalCommon.GetTimeServer()));
                    cmd.Parameters.AddWithValue("@IDNguoiXuat", PTIdentity.IDNguoiDung);          
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cd = cn.CreateCommand())
                {
                    cd.CommandType = CommandType.StoredProcedure;
                    cd.CommandText = "HoaDonCT_Get";
                    cd.Parameters.AddWithValue("@IDHocVien", intIDHocVien);
                 
                    using (SafeDataReader sdr = new SafeDataReader(cd.ExecuteReader()))
                    {
                        while (sdr.Read())
                        {
                            using (SqlConnection con = new SqlConnection(DBConnection.Connection))
                            {
                                con.Open();
                                using (SqlCommand scd = con.CreateCommand())
                                {
                                    scd.CommandType = CommandType.StoredProcedure;
                                    scd.CommandText = "HoaDonCT_ins";
                                    scd.Parameters.AddWithValue("@IDHoaDon", sdr.GetInt64("IDHoaDon"));
                                    scd.Parameters.AddWithValue("@IDBienLai", sdr.GetInt64("IDBienLai"));
                                    scd.Parameters.AddWithValue("@TenHang", sdr.GetString("TenHang"));
                                    scd.Parameters.AddWithValue("@SoTien", sdr.GetDecimal("SoTien"));
                                    scd.Parameters.AddWithValue("@TrangThai", sdr.GetByte("TrangThai"));
                                    scd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
        }

        private object[] GetValues(GridViewSelectedRowsCollection items)
        {
            object[] objValues = new object[items.Count];
            int intIndex = 0;

            foreach (GridViewRowInfo item in items)
            {
                objValues[intIndex] = item.Cells[0].Value;
                intIndex++;
            }
            return objValues;
        }


        private void radgDSBienLai_CellClick(object sender, GridViewCellEventArgs e)
        {

            if (radgDSBienLai.CurrentColumn.Name == "btnHuyBL" && Convert.ToBoolean(radgDSBienLai.CurrentRow.Cells["Huy"].Value) == false)
            {

                btnHoanLyDo.Enabled = false;

                if (GlobalCommon.AcceptHuy())
                {
                    FormLyDoHuy frm = new FormLyDoHuy(Convert.ToInt64(_oLoadHocVien.IDHocVien), Convert.ToInt64(radgDSBienLai.CurrentRow.Cells["IDBienLai"].Value), "H1700001", Convert.ToDecimal(radgDSBienLai.CurrentRow.Cells["SoTien"].Value), Convert.ToDateTime(GlobalCommon.GetTimeServer()), PTIdentity.IDNguoiDung, _oLoadHocVien.TenHocVien,_oLoadLopHoc.IDLopHoc);
                    frm.ShowDialog();

                }
                LoadDanhSachKyQuy();
            }
            else
            {

                if (radgDSBienLai.CurrentColumn.Name == "btnHuyBL")
                {
                    GlobalCommon.ShowError("Biên lai này đã được hủy, bạn hãy kiểm tra lại!", "Thông báo");
                    return;

                }
                btnHoanLyDo.Enabled = true;
              
            }
        
            this._oBienlaitamthu = BienLaiTamThu.GetBienLaiTamThu(Convert.ToInt64(radgDSBienLai.CurrentRow.Cells["IDBienLai"].Value));
            this.bindBienLaiTamThuInfo.DataSource = _oBienlaitamthu;        
            iDBienLai = this._oBienlaitamthu.IDBienLai;
            soLanIn = (byte)(radgDSBienLai.CurrentRow.Cells["SoLanIn"].Value);
            if (_oBienlaitamthu.LoaiPhieu == 0)
                radNoiDung.SelectedValue = "Phiếu thu học phí";
            if (_oBienlaitamthu.LoaiPhieu == 1)         
                radNoiDung.SelectedValue = "PDNTT làm thẻ";
            if (_oBienlaitamthu.LoaiPhieu == 2)
                radNoiDung.SelectedValue = "PDNTT làm chứng chỉ";      
        }

        private void btnPrintChuyenDoi_Click(object sender, EventArgs e)
        {
            GetResponseHDConvert(soTiepNhan);
        }

        private void btnSuaTTHV_Click(object sender, EventArgs e)
        {
            try
            {
                formMode.Id = Convert.ToInt32(_oLoadHocVien.IDHocVien);
                formMode.IsEdit = true;
                ModuleDaoTao.UI.Form_LT_HocVienLienTuc fr = new ModuleDaoTao.UI.Form_LT_HocVienLienTuc(formMode);
                fr.ShowDialog();
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radgDSBienLai_Click(object sender, EventArgs e)
        {
         
        }

        private void txtIDHocVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dt = new DataTable();
                HocVienSearch.search(ref dt, Convert.ToInt64(this.txtIDHocVien.Text));
                if (dt.Rows.Count == 1)
                    GetValuesFromDataTable();
                AddNew();
                if (radgDSBienLai.RowCount > 0)
                    btnInBienLai.Enabled = true;
                btnInHoaDonHuy.Enabled = true;
                LoadDanhSachKyQuy();         
                if (radgDSBienLai.RowCount > 0)
                    btnInBienLai.Enabled = true;              
            }
        }

        #region Xuất Hóa Đơn và Hóa Đơn Chuyển Đổi

        /// <summary>
        /// Method check internet connected or not
        /// </summary>
        /// <returns></returns>
        private static bool CheckInternet()
        {
            bool checkInternet;
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("https://client3.google.com/generate_204"))
                    {
                        checkInternet = true;
                    }
                }
            }
            catch (Exception)
            {
                checkInternet = false;
            }
            return checkInternet;
        }

        /// <summary>
        /// Get UserName login
        /// </summary>
        /// <returns>UserName</returns>
        private static string Get_UserName()
        {
            string userName = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "Get_UserName";
                    cm.Parameters.AddWithValue("@IDNguoiDung", PTIdentity.IDNguoiDung);
                    userName = (string)cm.ExecuteScalar();
                }
            }
            return userName;
        }
        /// <summary>
        /// Method GetResponseHD get response with parameter is soTiepNhan(soHoaDon), after responsed to convert byte[] base64 to pdf file.
        /// </summary>
        /// <param name="soTiepNhan"></param>
        private void GetResponseHD(string soTiepNhan)//HD171200017
        {
            user = Get_UserName();
            String strResponseHD = String.Empty;
            pathFile = @"D:/fileHD.pdf";
            try
            {
                if (CheckInternet() == true)
                {
                    ServiceReferenceHD.TransferTTBHXHSoapClient wsrHD = new ServiceReferenceHD.TransferTTBHXHSoapClient();
                    strResponseHD = wsrHD.ExportHDHocVien(soTiepNhan, user, "datnguyenks198@23456");
                    if (strResponseHD.Length == 0)
                    {
                        MessageBox.Show("Hiện chưa có file hóa đơn chuyển đổi của " + _oBienlaitamthu.NguoiDong + " trên hệ thống.", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (ConvertStringToBase(strResponseHD, pathFile) == true)
                        {
                            System.Diagnostics.Process.Start(pathFile);
                        }
                        else
                        {
                            MessageBox.Show("File hóa đơn thanh toán đang được mở, vui lòng kiểm tra lại", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else
                {
                    ServiceReferenceHDLan.TransferTTBHXHSoapClient wsrHDLan = new ServiceReferenceHDLan.TransferTTBHXHSoapClient();
                    strResponseHD = wsrHDLan.ExportHDHocVien(soTiepNhan, user, "datnguyenks198@23456");
                    if (strResponseHD.Length == 0)
                    {
                        MessageBox.Show("Hiện chưa có file hóa đơn chuyển đổi của " + _oBienlaitamthu.NguoiDong + " trên hệ thống.", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (ConvertStringToBase(strResponseHD, pathFile) == true)
                        {
                            System.Diagnostics.Process.Start(pathFile);
                        }
                        else
                        {
                            MessageBox.Show("File hóa đơn thanh toán chuyển đổi đang được mở, vui lòng kiểm tra lại", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình lấy hóa đơn tạm thu.\nVui lòng liên hệ với nhà cũng cấp để được giúp đỡ.\n" + ex.ToString(), "Thông báo từ hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method GetResponseHDConvert get response with parameter is soTiepNhan(soHoaDon), after responsed to convert byte[] base64 to pdf file.
        /// </summary>
        /// <param name="soTiepNhan"></param>
        private void GetResponseHDConvert(string soTiepNhan)
        {

            user = Get_UserName();
            String strResponseHDConvert = String.Empty;
            pathFile = "D:/fileHDCD.pdf";
            try
            {
                if (CheckInternet() == true)
                {
                    ServiceReferenceHD.TransferTTBHXHSoapClient wsrHD = new ServiceReferenceHD.TransferTTBHXHSoapClient();
                    strResponseHDConvert = wsrHD.ExportHDHocVienChuyenDoi(soTiepNhan, user, "datnguyenks198@23456");
                    if (strResponseHDConvert.Length == 0)
                    {
                        MessageBox.Show("Hiện chưa có file hóa đơn chuyển đổi của " + _oBienlaitamthu.NguoiDong + " trên hệ thống.", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (ConvertStringToBase(strResponseHDConvert, pathFile) == true)
                            System.Diagnostics.Process.Start(pathFile);
                        else
                        {
                            MessageBox.Show("File hóa đơn thanh toán chuyển đổi đang được mở, vui lòng kiểm tra lại", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        UpdateStatusPrintHD(soTiepNhan);
                        btnPrintChuyenDoi.Enabled = false;
                    }
                }
                else
                {
                    ServiceReferenceHDLan.TransferTTBHXHSoapClient wsrHDLan = new ServiceReferenceHDLan.TransferTTBHXHSoapClient();
                    strResponseHDConvert = wsrHDLan.ExportHDHocVienChuyenDoi(soTiepNhan, user, "datnguyenks198@23456");
                    if (strResponseHDConvert.Length == 0)
                    {
                        MessageBox.Show("Hiện chưa có file hóa đơn chuyển đổi của " + _oBienlaitamthu.NguoiDong + " trên hệ thống.", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (ConvertStringToBase(strResponseHDConvert, pathFile) == true)
                            System.Diagnostics.Process.Start(pathFile);
                        else
                        {
                            MessageBox.Show("File hóa đơn thanh toán chuyển đổi đang được mở, vui lòng kiểm tra lại", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình lấy hóa đơn tạm thu chuyển đổi.\nVui lòng liên hệ với nhà cũng cấp để được giúp đỡ.\n" + ex.ToString(), "Thông báo từ hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Method ConvertStringToBase, parameter is a string code base64
        /// </summary>
        /// <param name="stringBase64">string base64</param>
        /// <returns>pdf file</returns>
        private bool ConvertStringToBase(string stringBase64, string pathFile)
        {
            bool result = true;
            if (File.Exists(pathFile) == false)
            {
                byte[] bytes = Convert.FromBase64String(stringBase64);
                System.IO.FileStream stream = new FileStream(pathFile, FileMode.CreateNew);
                System.IO.BinaryWriter writer = new BinaryWriter(stream);
                writer.Write(bytes, 0, bytes.Length);
                writer.Close();
            }
            else
            {
                try
                {
                    File.Delete(pathFile);
                    byte[] bytes = Convert.FromBase64String(stringBase64);
                    System.IO.FileStream stream = new FileStream(pathFile, FileMode.CreateNew);
                    System.IO.BinaryWriter writer = new BinaryWriter(stream);
                    writer.Write(bytes, 0, bytes.Length);
                    writer.Close();
                }
                catch (Exception)
                {
                    result = false;
                }
            }
            return result;
        }

        /// <summary>
        /// Get code bill by receipt 
        /// </summary>
        /// <param name="soBienLai">code receipt</param>
        /// <returns>code bill</returns>
        private string GetMaHoaDon(Int64 iDBienLai)
        {
            string strMaBienLai = string.Empty;
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "GetSoHoaDon";
                    cm.Parameters.AddWithValue("@IDBienLai", iDBienLai);
                    strMaBienLai = (string)cm.ExecuteScalar();
                }
            }
            return strMaBienLai;
        }

        /// <summary>
        /// Method Update Status after printed bill convert
        /// </summary>
        /// <param name="iDHoaDon">soHoaDon</param>
        private void UpdateStatusPrintHD(string soBienLai)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "UpdateStatusPrintHD";
                    cm.Parameters.AddWithValue("@SoHoaDon", soBienLai);
                    cm.ExecuteNonQuery();
                }
            }
        }

        private int GetStatus(string Status)
        {
            int result = 0;
            if (Status.Equals("F") == true)
            {
                result = 1;
            }
            return result;
        }

        #endregion

        private void btnInBienLai_Click(object sender, EventArgs e)
        {

            PrintAgain();

            UpdateSoLanIn();
            LoadDanhSachKyQuy();

        }

        private void UpdateSoLanIn()
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateSoLanInBL";
                    cmd.Parameters.AddWithValue("@IDBienLai", iDBienLai);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnInHoaDonHuy_Click(object sender, EventArgs e)
         {
            try
            {               
                    if (Convert.ToBoolean(radgDSBienLai.CurrentRow.Cells["Huy"].Value) == false)
                    {
                        PreviewReport preview = new PreviewReport();
                        ReportDocument doc = new ReportDocument();
                        string IDBienLaiList = string.Empty;
                        for (int j = 0; j <= radgDSBienLai.RowCount - 1; j++)
                        {
                            if (Convert.ToBoolean(radgDSBienLai.Rows[j].Cells["INPYC"].Value) == true)
                            {
                                IDBienLaiList = IDBienLaiList + radgDSBienLai.Rows[j].Cells["IDBienLai"].Value + ',';
                            }
                        }
                        IDBienLaiList = IDBienLaiList.Substring(0, IDBienLaiList.Length - 1);
                        doc.Load(AppConfig.ReportPath + "rprBaoCaoHoanHocPhi.rpt");

                        using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                        {
                            cn.Open();
                            using (SqlCommand cm = cn.CreateCommand())
                            {
                                cm.CommandText = "BaoCaoHoanTienHocPhirpt";
                                cm.CommandType = CommandType.StoredProcedure;
                                cm.Parameters.AddWithValue("@IDBienLai", IDBienLaiList);
                                using (SqlDataAdapter da = new SqlDataAdapter(cm))
                                {
                                    DataSet ds = new DataSet();
                                    da.Fill(ds, "BaoCaoHoanTienHocPhi");
                                    if (ds.Tables[0].Rows.Count <= 0)
                                    {
                                        GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "thông báo");
                                        return;
                                    }
                                    else
                                    {
                                        doc.SetDataSource(ds);
                                        preview.crystalReportViewer.ReportSource = doc;
                                        doc.SetParameterValue("paNgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                                        doc.SetParameterValue("Tenmay", "In từ máy tính: " + GlobalCommon.DisplayLocalHostName().ToUpper() + "   ngày:" + DateTime.Now.ToString("dd/MM/yyyy") + " vào lúc:" + DateTime.Now.ToString("hh:mm:ss"));
                                        preview.ShowDialog(this);

                                    }
                                }
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Biên lai này đã huỷ nên bạn không thể in phiếu ! ", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex);
            }
            radInTatCa.Checked = false;
        }
      
        private void PrintHuyBienLai()
        {
            try
            {
                PreviewReport PreviewReport = new PreviewReport();
                ReportDocument ReportDocument = new ReportDocument();
                PreviewReport.Text = "Hủy biên lai";
                ReportDocument.Load(AppConfig.ReportPath + "rptBienLaiHuyTamThu.rpt");
                ModuleHanhChinh.ThanhToan.BaoCao dsData = new ModuleHanhChinh.ThanhToan.BaoCao();
                dsData.Clear();
                dsData.SoHoaDonBarCode.AddSoHoaDonBarCodeRow(GlobalCommon.GetBarCode(GlobalCommon.GetSoHoaDon(_oLoadHocVien.IDHocVien), false, BarcodeLib.TYPE.CODE128, 420, 90));
                ReportDocument.SetDataSource(dsData);
                using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                {
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {

                        cm.CommandText = "InBienLaiHuyHD";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@IDHocVien", this._oLoadHocVien.IDHocVien);
                        cm.Parameters.AddWithValue("@IDBienLai", Convert.ToInt64(radgDSBienLai.CurrentRow.Cells["IDBienLai"].Value));
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            DataSet ds = new DataSet();
                            da.Fill(ds, "HoaDonThanhToan");
                            if (ds.Tables[0].Rows.Count <= 0)
                            {
                                GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                                return;
                            }
                            ReportDocument.SetDataSource(ds);
                            PreviewReport.crystalReportViewer.ReportSource = ReportDocument;
                            ReportDocument.SetParameterValue("NguoiLap", PTIdentity.FullName);
                            ReportDocument.SetParameterValue("LanIn", soLanIn + 1);

                            ReportDocument.SetParameterValue("LanIn", soLanIn + 1);

                            ReportDocument.SetParameterValue("NgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                            ReportDocument.SetParameterValue("ThoiGianServer", GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm:ss"));

                            ReportDocument.SetParameterValue("SoBienLai", txtMaBienLai.Text.Replace("/", ""));


                            ReportDocument.SetParameterValue("SoBienLai", txtMaBienLai.Text.Replace("/", ""));
                            ReportDocument.SetParameterValue("Lien", "Liên 1: Lưu");
                        
                            PreviewReport.ShowDialog(this);
                        }
                    }
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu ! !\n" + err.ToString(), "Thông báo từ hệ thống");
            }
        }

        class AutoPrintReport
        {
            public event NumberReportPrint Notifi;
            public void PrintReport(bool _thanhToan, int i)
            {
                if (Notifi != null)
                    Notifi(_thanhToan, i);
            }
        }

        private void btnHoanLyDo_Click(object sender, EventArgs e)
        {

            if (Convert.ToBoolean(radgDSBienLai.CurrentRow.Cells["Huy"].Value) == true)
            {
                if (GlobalCommon.AcceptHoanBienLai())
                {
                    bindBienLaiTamThu.DataSource = BienLaiTamThuColl.GetBienLaiTamThuColl(_oBienlaitamthu.IDHocVien);
                    GetHoanBienLaiHuy(_oBienlaitamthu.IDHocVien);
                    MessageBox.Show("Bạn đã hoàn phiếu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Biên lai này chưa được huỷ nên bạn \n không thể hoàn biên lai này được !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDanhSachKyQuy();
        }
        private void GetHoanBienLaiHuy(Int64 intIDHocVien)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();

                using (SqlCommand scd = cn.CreateCommand())
                {
                    scd.CommandType = CommandType.StoredProcedure;
                    scd.CommandText = "HoanTamThu_ins";
                    scd.Parameters.AddWithValue("@IDHocVien", intIDHocVien);
                    scd.Parameters.AddWithValue("@SoPhieuHoan", radgDSBienLai.CurrentRow.Cells["MaBienLai"].Value.ToString());
                    scd.Parameters.AddWithValue("@SoTien", _oBienlaitamthu.SoTien);
                    scd.Parameters.AddWithValue("@NgayHoan", Convert.ToDateTime(GlobalCommon.GetTimeServer()));
                    scd.Parameters.AddWithValue("@NguoiNhan", _oBienlaitamthu.NguoiDong = _oLoadHocVien.TenHocVien);
                    scd.Parameters.AddWithValue("@IDNguoiHoan", _oBienlaitamthu.IDNguoiThu = PTIdentity.IDNguoiDung);
                    scd.Parameters.AddWithValue("@IDPhieuHuy", _oBienlaitamthu.IDPhieuHuy);
                    scd.Parameters.AddWithValue("@IDBienLai", _oBienlaitamthu.IDBienLai);
                    scd.ExecuteNonQuery();

                }
            }

        }

        private void radgDSBienLai_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (Convert.ToBoolean(e.Row.Cells["Huy"].Value) == true)
            {
                e.CellElement.Font = new Font(e.CellElement.Font,FontStyle.Strikeout);
                e.CellElement.ForeColor = Color.Red;       
            }
        }

        private void radInTatCa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radgDSBienLai.ChildRows)
                {
                    rowInfo.Cells["INPYC"].Value = radInTatCa.Checked;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radNoiDung_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            _oBienlaitamthu.LoaiPhieu = Convert.ToByte(radNoiDung.SelectedIndex);

            if (_oBienlaitamthu.LoaiPhieu == 0)              
            radNoiDung.SelectedValue = "Phiếu thu học phí";
            if (_oBienlaitamthu.LoaiPhieu == 1)
            radNoiDung.SelectedValue = "PDNTT làm thẻ";
            if (_oBienlaitamthu.LoaiPhieu == 2)
            radNoiDung.SelectedValue = "PDNTT làm chứng chỉ";     
        }
    }
}
            
        

        
        
    





