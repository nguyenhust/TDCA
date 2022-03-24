using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
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
using System.IO;
using Authoration.LIB;
using System.Data.SqlClient;
namespace ModuleHanhChinh.ThanhToan
{
   public delegate void NumberReportPrint1(bool _isThanhToan, int i);
    public partial class FormLopHocThuHP : Dictionary
    {
        #region khai báo biến
        private FormMode formMode = new FormMode();
        private DataTable dt;
        private bool _isNew;
        private Int32 _intIDLopHoc;
        private string _strMaLopHoc = string.Empty;
        private string _strTenCanBoPhuTrach = string.Empty;
        private string _strTenChuyenKhoa = string.Empty;
        private string _strTenLop = string.Empty;
        private LoadLopHoc _oLoadLopHoc = new LoadLopHoc();
        private BienLaiLopHoc _oBienLaiLopHoc;
        private BienLaiLopHocColl _oBienLaiTamThuColl;
        public event EventHandler RefreshPatientLoad;
        Int64 iDBienLai = 0;
        int soLanIn = 0;
        public Int32 IDLopHoc
        {
            get { return _intIDLopHoc; }
            set { _intIDLopHoc = value; }
        }
        public string MaLopHoc
        {
            get { return _strMaLopHoc; }
            set { _strMaLopHoc = value; }
        }
        public string TenCanBoPhuTrach
        {
            get { return _strTenCanBoPhuTrach; }
            set { _strTenCanBoPhuTrach = value; }
        }
        public string TenChuyenKhoa
        {
            get { return _strTenChuyenKhoa; }
            set { _strTenChuyenKhoa = value; }
        }
        public string TenLop
        {
            get { return _strTenLop; }
            set { _strTenLop = value; }
        }
        #endregion
        public FormLopHocThuHP()
        {
            InitializeComponent();
            btnSave.Enabled = true;       
            RadGrid = radgBienLaiLopHoc;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            this.RadGrid.Columns["STT"].ReadOnly = true;
            RadGrid.AllowAddNewRow = false;
        }

        private void InititialValue()
        {
            _oLoadLopHoc.IDLopHoc = _intIDLopHoc;
            _oLoadLopHoc.MaLopHoc = _strMaLopHoc;
            _oLoadLopHoc.TenCanBoPhuTrach = _strTenCanBoPhuTrach;
            _oLoadLopHoc.TenChuyenKhoa = _strTenChuyenKhoa;
            _oLoadLopHoc.TenLop = _strTenLop;

            this.binLopHoc.DataSource = _oLoadLopHoc;
            this.binLopHoc.RaiseListChangedEvents = true;
            this.binLopHoc.ResetBindings(false);
        }
        public void RefreshValue()
        {
            _oLoadLopHoc = new LoadLopHoc();
            _intIDLopHoc = 0;
            _strMaLopHoc = "";
            _strTenCanBoPhuTrach = "";
            _strTenChuyenKhoa = "";
            _strTenLop = "";
            this.binLopHoc.DataSource = _oLoadLopHoc;
            _oBienLaiLopHoc = BienLaiLopHoc.NewBienLaiLopHoc();
            this.binBienLaiLopHoc.DataSource = _oBienLaiLopHoc;
            ClearForm();
        }
        private void GetValuesFromDataTable()
        {
            foreach (DataRow dr in dt.Rows)
            {
                _intIDLopHoc = Convert.ToInt32(dr["IDLopHoc"].ToString());
                _strMaLopHoc = dr["MaLopHoc"].ToString();
                _strTenCanBoPhuTrach = dr["TenCanBoPhuTrach"].ToString();
                _strTenChuyenKhoa = dr["TenChuyenKhoa"].ToString();
                _strTenLop = dr["TenLop"].ToString();
            }
            InititialValue();
        }

        private void ClearForm()
        {
            _oBienLaiLopHoc.SoTien = 0;
            _oBienLaiLopHoc.NgayThu = GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm");
            _oBienLaiLopHoc.NguoiDong = "";
            _oBienLaiLopHoc.HinhThucThu = 0;
            radHinhThuc.SelectedIndex = 0;
        }

        private void btnLamSach_Click(object sender, EventArgs e)
        {
            RefreshValue();
            if (RefreshPatientLoad != null)
            {
                RefreshPatientLoad(this, EventArgs.Empty);
            }
        }

        protected  void  SaveData(bool rebind)
        {
            //base.Save();
            using (StatusBusy busy = new StatusBusy("Lưu trữ..."))
            {
                this.binBienLaiLopHoc_Info.RaiseListChangedEvents = false;
                // do the save
                this.binBienLaiLopHoc_Info.EndEdit();
                try
                {
                    BienLaiLopHoc _oTemp = _oBienLaiLopHoc.Clone();
                    _oBienLaiLopHoc = _oTemp.Save();
                    if(rebind)
                    {
                        this.binBienLaiLopHoc_Info.DataSource = null;
                        this.binBienLaiLopHoc_Info.DataSource = _oBienLaiLopHoc;
                    }

                }
                catch(Exception ex)
                {
                    GlobalCommon.ShowErrorMessager(ex);
                }
                finally
                {
                    this.binBienLaiLopHoc_Info.RaiseListChangedEvents = true;
                    this.binBienLaiLopHoc_Info.ResetBindings(false);
                }
            }
        }
        private void LoadDuLieu()
        {            
          this.binBienLaiLopHoc.DataSource= BienLaiLopHocColl.GetBienLaiLopHocColl(_oBienLaiLopHoc.IDLopHoc);
        }
          protected void AddNew()
        {
            _intIDLopHoc = _oLoadLopHoc.IDLopHoc;
            _oBienLaiLopHoc = BienLaiLopHoc.NewBienLaiLopHoc();
            _oBienLaiLopHoc.MaBienLai = GlobalCommon.CreateMaBienLai(int.Parse(GlobalCommon.GetTimeServer().ToString("yyyy")), GlobalCommon.GetTenDangNhap(PTIdentity.IDNguoiDung));
            _oBienLaiLopHoc.IDLopHoc = _intIDLopHoc;
            _isNew = _oBienLaiLopHoc.IsNew;
            _oBienLaiLopHoc.IDNguoiThu = PTIdentity.IDNguoiDung;
            _oBienLaiLopHoc.NguoiThu = PTIdentity.FullName;
            _oBienLaiLopHoc.NgayThu = GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm");
            _oBienLaiLopHoc.HinhThucThu = 0;
            _oBienLaiLopHoc.XuatHD = false;
            _oBienLaiLopHoc.NguoiDong = _oLoadLopHoc.TenCanBoPhuTrach;
            _oBienLaiLopHoc.Reference_Code = "";
            _oBienLaiLopHoc.SoLan = 1;
            _oBienLaiLopHoc.SoLanIn = 1;
            _oBienLaiLopHoc.LoaiPhieu = 0;
            LoadDuLieu();
            this.binBienLaiLopHoc_Info.DataSource = _oBienLaiLopHoc;
            radHinhThuc.SelectedIndex = 0;
            radNoiDung.SelectedIndex = 0;

        }
          private void txtIDLopHoc_KeyDown(object sender, KeyEventArgs e)
          {
              if (e.KeyCode == Keys.Enter)
              {
                  dt = new DataTable();
                  LopHocSeach.search(ref dt, Convert.ToInt32(this.txtIDLopHoc.Text));
                  if (dt.Rows.Count == 1)
                      GetValuesFromDataTable();
                  AddNew();
                  if (radgBienLaiLopHoc.RowCount > 0)
                      LoadDuLieu();
                  btnSave.Enabled = true;
                 
              }
          }

          private void FormLopHocThuHP_Shown(object sender, EventArgs e)
          {
              txtIDLopHoc.Focus();
          }

          private void btnSave_Click(object sender, EventArgs e)
          {
             
              try
              {                  
                  if (GlobalCommon.AcceptUpdate())
                      if (_oBienLaiLopHoc.SoTien > 0)
                      {
                          SaveData(true);
                          if (_oBienLaiLopHoc.XuatHD == false)
                          {
                              GetBienLai(_oBienLaiLopHoc.IDLopHoc);
                              Print();
                              LoadDuLieu();
                          }
                      }
              }
              catch (Exception ex)
              {
                  GlobalCommon.ShowErrorMessager(ex);
              }
          }

          private void btnAdd_Click(object sender, EventArgs e)
          {
              ClearForm();
              AddNew();
          }

          private void GetBienLai(Int32 intIDLopHoc)
          {
              try
              {
                  using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                  {
                      cn.Open();
                      using (SqlCommand cmd = cn.CreateCommand())
                      {
                          cmd.CommandType = CommandType.StoredProcedure;
                          cmd.CommandText = "HoaDon_insert";
                          cmd.Parameters.AddWithValue("@SoHoaDon", "");
                          cmd.Parameters.AddWithValue("@NgayHoaDon", Convert.ToDateTime(GlobalCommon.GetTimeServer()));
                          cmd.Parameters.AddWithValue("@IDNguoiXuat", PTIdentity.IDNguoiDung);
                          cmd.Parameters.AddWithValue("@IDLopHoc", intIDLopHoc);
                          cmd.ExecuteNonQuery();
                      }
                      using (SqlCommand cd = cn.CreateCommand())
                      {
                          cd.CommandType = CommandType.StoredProcedure;
                          cd.CommandText = "HoaDonCT_Gets";
                          cd.Parameters.AddWithValue("@IDLopHoc", intIDLopHoc);
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
              catch(Exception ex)
              { GlobalCommon.ShowError(ex); }
          }

          private void btnEdit_Click(object sender, EventArgs e)
          {
              try
              {
                  formMode.StringId = Convert.ToString(_oLoadLopHoc.MaLopHoc);
                  formMode.IsEdit = true;
                  ModuleDaoTao.UI.Form_LT_LopHoc fr = new ModuleDaoTao.UI.Form_LT_LopHoc(formMode);
                  fr.ShowDialog();
              }
              catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
          }     
          private void radgBienLaiLopHoc_Click(object sender, EventArgs e)
          {

          }

          private void radgBienLaiLopHoc_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
          {
              try
              {
                  if (radgBienLaiLopHoc.CurrentColumn.Name == "btnHuyBL" && Convert.ToBoolean(radgBienLaiLopHoc.CurrentRow.Cells["Huy"].Value) == false)
                  {
                      if (GlobalCommon.AcceptHuy())
                      {
                          FormLyDoHuy frm = new FormLyDoHuy(Convert.ToInt64(_oBienLaiLopHoc.IDHocVien), Convert.ToInt64(radgBienLaiLopHoc.CurrentRow.Cells["IDBienLai"].Value), "H1700001", Convert.ToDecimal(radgBienLaiLopHoc.CurrentRow.Cells["SoTien"].Value), Convert.ToDateTime(GlobalCommon.GetTimeServer()), PTIdentity.IDNguoiDung, _oLoadLopHoc.TenCanBoPhuTrach, Convert.ToInt32(_oLoadLopHoc.IDLopHoc));
                          frm.ShowDialog();
                      }
                      LoadDuLieu();
                  }
                  else
                  {

                      if (radgBienLaiLopHoc.CurrentColumn.Name == "btnHuyBL")
                      {
                          GlobalCommon.ShowError("Biên lai này đã được hủy, bạn hãy kiểm tra lại!", "Thông báo");
                          return;

                      }

                  }
                  this._oBienLaiLopHoc = BienLaiLopHoc.GetBienLaiLopHoc(Convert.ToInt64(radgBienLaiLopHoc.CurrentRow.Cells["IDBienLai"].Value));
                  this.binBienLaiLopHoc_Info.DataSource = _oBienLaiLopHoc;
                  iDBienLai = this._oBienLaiLopHoc.IDBienLai;
                  soLanIn = (byte)(radgBienLaiLopHoc.CurrentRow.Cells["SoLanIn"].Value);
                  if (_oBienLaiLopHoc.LoaiPhieu == 0)
                      radNoiDung.SelectedValue = "PDNTT làm thẻ";
                  if (_oBienLaiLopHoc.LoaiPhieu == 1)
                      radNoiDung.SelectedValue = "PDNTT làm chứng chỉ";
              }
              catch(Exception ex)
              { GlobalCommon.ShowError(ex); }
          }

          private void radNoiDung_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
          {
              _oBienLaiLopHoc.LoaiPhieu = Convert.ToByte(radNoiDung.SelectedIndex);
              //if (_oBienLaiLopHoc.LoaiPhieu == 0)
              //    radNoiDung.SelectedValue = "Phiếu thu học phí";
              if (_oBienLaiLopHoc.LoaiPhieu == 0)
                  radNoiDung.SelectedValue = "PDNTT làm thẻ";
              if (_oBienLaiLopHoc.LoaiPhieu == 1)
                  radNoiDung.SelectedValue = "PDNTT làm chứng chỉ";
          }
          private void radHinhThuc_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
          {
              _oBienLaiLopHoc.HinhThucThu = Convert.ToByte(radHinhThuc.SelectedIndex);
          }
          private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
          {
              radG_CellFormat(sender, e);
          }

          private void radgBienLaiLopHoc_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
          {
              try
              {
                  if (Convert.ToBoolean(e.Row.Cells["Huy"].Value) == true)
                  {
                      e.CellElement.Font = new Font(e.CellElement.Font, FontStyle.Strikeout);
                      e.CellElement.ForeColor = Color.Red;

                  }
              }
              catch(Exception ex)
              { GlobalCommon.ShowError(ex); }
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
                  dsData.SoHoaDonBarCode.AddSoHoaDonBarCodeRow(GlobalCommon.GetBarCode(GlobalCommon.GetSoHoaDonLopHoc(_oLoadLopHoc.IDLopHoc), false, BarcodeLib.TYPE.CODE128, 420, 90));
                  ReportDocument.SetDataSource(dsData);
                  using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                  {
                      cn.Open();
                      using (SqlCommand cm = cn.CreateCommand())
                      {

                          cm.CommandText = "HoaDonThanhToanLopHoc_XuanHD";
                          cm.CommandType = CommandType.StoredProcedure;
                          cm.Parameters.AddWithValue("@IDLopHoc",Convert.ToInt64(this._oLoadLopHoc.IDLopHoc));
                          cm.Parameters.AddWithValue("@DieuKien",Convert.ToInt32(radNoiDung.SelectedIndex));

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
                              if (_oBienLaiLopHoc.LoaiPhieu == 0)
                                  ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM THẺ HỌC VIÊN");
                              if (_oBienLaiLopHoc.LoaiPhieu == 1)
                                  ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM CHỨNG CHỈ");
                              if (i == 1)
                                  ReportDocument.SetParameterValue("Lien", "Liên 1: Lưu");
                              if (i == 2)
                                  ReportDocument.SetParameterValue("Lien", "Liên 2 : Xác nhận của trung tâm");
                              if (i == 3)
                                  ReportDocument.SetParameterValue("Lien", "Liên 3 :Cán bộ đưa cho học viên giữ");
                              if(_oLoadLopHoc.IDLopHoc !=null)
                              {
                                  ReportDocument.SetParameterValue("ID","IDLH:");
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
                  dsData.SoHoaDonBarCode.AddSoHoaDonBarCodeRow(GlobalCommon.GetBarCode(GlobalCommon.GetSoHoaDonLopHoc(_oLoadLopHoc.IDLopHoc), false, BarcodeLib.TYPE.CODE128, 420, 90));
                  ReportDocument.SetDataSource(dsData);
                  using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                  {
                      cn.Open();
                      using (SqlCommand cm = cn.CreateCommand())
                      {

                          cm.CommandText = "InLaiHoaDonLopHoc";
                          cm.CommandType = CommandType.StoredProcedure;
                          cm.Parameters.AddWithValue("@IDLopHoc", this._oLoadLopHoc.IDLopHoc);
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
                              ReportDocument.SetParameterValue("NguoiLap", _oBienLaiLopHoc.NguoiThu);
                              ReportDocument.SetParameterValue("LanIn", soLanIn + 1);

                              ReportDocument.SetParameterValue("LanIn", soLanIn + 1);

                              ReportDocument.SetParameterValue("NgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                              ReportDocument.SetParameterValue("ThoiGianServer", GlobalCommon.GetTimeServer().ToString("dd/MM/yyyy HH:mm:ss"));

                              ReportDocument.SetParameterValue("SoBienLai", txtMaBienLai.Text.Replace("/", ""));


                              ReportDocument.SetParameterValue("SoBienLai", txtMaBienLai.Text.Replace("/", ""));
                              if (_oBienLaiLopHoc.LoaiPhieu == 0)
                                  ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM THẺ HỌC VIÊN");
                              if (_oBienLaiLopHoc.LoaiPhieu == 1)
                                  ReportDocument.SetParameterValue("TieuDe", "PHIẾU ĐỀ NGHỊ THU TIỀN LÀM CHỨNG CHỈ");
                              if (i == 1)
                                  ReportDocument.SetParameterValue("Lien", "Liên 1: Lưu");
                              if (i == 2)
                                  ReportDocument.SetParameterValue("Lien", "Liên 2 : Xác nhận của trung tâm");
                              if (i == 3)
                                  ReportDocument.SetParameterValue("Lien", "Liên 3 : Cán bộ đưa cho học viên giữ");
                              if (_oLoadLopHoc.IDLopHoc != null)
                              {
                                  ReportDocument.SetParameterValue("ID", "IDLH:");
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

          class AutoPrintReport
          {
              public event NumberReportPrint1 Notifi;
              public void PrintReport(bool _thanhToan, int i)
              {
                  if (Notifi != null)
                      Notifi(_thanhToan, i);
              }
          }
          private void Print()
          {
              for (int i = 1; i <= 3; i++)
              {
                  AutoPrintReport printReport = new AutoPrintReport();
                  printReport.Notifi += new NumberReportPrint1(CreateFileReport);
                  printReport.PrintReport(true, i);
              }
              MessageBox.Show("Báo cáo đã in xong!", "Thông báo từ hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

             

          }
          private void PrintAgain()
          {
              for (int i = 1; i <= 3; i++)
              {
                  AutoPrintReport printReport = new AutoPrintReport();
                  printReport.Notifi += new NumberReportPrint1(CreateFileReportAgain);
                  printReport.PrintReport(true, i);
              }
              MessageBox.Show("Báo cáo đã in xong!", "Thông báo từ hệ thống", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

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

          private void btnPrint_Click(object sender, EventArgs e)
          {
              try
              {
                  if (Convert.ToBoolean(radgBienLaiLopHoc.CurrentRow.Cells["Huy"].Value) == false)
                  {
                      PrintAgain();
                      UpdateSoLanIn();
                      LoadDuLieu();
                  }
                  else
                  {
                      GlobalCommon.ShowError("Hóa đơn này đã hủy nên bạn không thể in lại hóa đơn!", "Thông báo từ hệ thống");
                  }
              }
              catch(Exception ex)
              { GlobalCommon.ShowError(ex); }
          }     
    }
    }
   