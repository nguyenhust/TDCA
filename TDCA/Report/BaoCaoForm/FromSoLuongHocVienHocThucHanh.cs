using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI.Form;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using NETLINK.LIB;
using Authoration.LIB;
namespace TDCA.Report.BaoCaoForm
{
    public partial class FromSoLuongHocVienHocThucHanh : NETLINK.UI.Dictionary
    {
        public FromSoLuongHocVienHocThucHanh()
        {
            InitializeComponent();
            radTuNgay.Value = GlobalCommon.GetTimeServer();
            radDenNgay.Value = GlobalCommon.GetTimeServer();
        }

        private void Print()
        {
            if (radTimKiem.Text == "")
            {
                GlobalCommon.ShowError("Bạn chưa chọn loại báo cáo nào !", "Thông báo từ hệ thống");
            }
            else
            {
                PreviewReport preview = new PreviewReport();
                ReportDocument rp = new ReportDocument();
                preview.Text = "Báo cáo học viên chưa hoàn thành học phí";
                if (radTimKiem.SelectedIndex == 0)
                {
                    rp.Load(AppConfig.ReportPath + "BC_SoLuongHocVienHocThucHanhTheoKhoa.rpt");
                }
                if (radTimKiem.SelectedIndex == 1)
                {
                    rp.Load(AppConfig.ReportPath + "BC_SoLuongHocVienHocThucHanhTheoTruong.rpt");
                }
                if (radTimKiem.SelectedIndex == 2)
                {
                    rp.Load(AppConfig.ReportPath + "BC_SoLuongHocVienHocThucHanhTheoTen.rpt");
                }
                ModuleHanhChinh.ThanhToan.BaoCao dsdata = new ModuleHanhChinh.ThanhToan.BaoCao();
                rp.SetDataSource(dsdata);

                using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                {
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {
                        if (radTimKiem.SelectedIndex == 0)
                        {
                            cm.CommandText = "BC_SoLuongHocVienHocThuHanhTheoKhoa";
                        }
                        if (radTimKiem.SelectedIndex == 1)
                        {
                            cm.CommandText = "BC_SoLuongHocVienHocThuHanhTheoTruong";
                        }
                        if (radTimKiem.SelectedIndex == 2)
                        {
                            cm.CommandText = "BC_SoLuongHocVienHocThuHanhTheoTen";
                        }
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@TuNgay", Convert.ToDateTime(radTuNgay.Value.ToString("dd/MM/yyyy")));
                        cm.Parameters.AddWithValue("@DenNgay", Convert.ToDateTime(radDenNgay.Value.ToString("dd/MM/yyyy")));
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            DataSet ds = new DataSet();
                            if (radTimKiem.SelectedIndex == 0)
                            {
                                da.Fill(ds, "BC_SoLuongHocVienThucHanhTheKhoa");
                            }
                            if (radTimKiem.SelectedIndex == 1)
                            {
                                da.Fill(ds, "BC_SoLuongHocVienThucHanhTheTruong");
                            }
                            if (radTimKiem.SelectedIndex == 2)
                            {
                                da.Fill(ds, "BC_SoLuongHocVienThucHanhTheoHocVien");
                            }
                            if (ds.Tables[0].Rows.Count <= 0)
                            {
                                GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                                return;
                            }
                            else
                            {

                                rp.SetDataSource(ds);
                                preview.crystalReportViewer.ReportSource = rp;

                                rp.SetParameterValue("paraNgayThangNam", "Thời gian : từ ngày " + radTuNgay.Value.ToString("dd/MM/yyyy") + "  đến ngày  " + radDenNgay.Value.ToString("dd/MM/yyyy") + "");
                                rp.SetParameterValue("TuNgayDenNgay", "TUẦN TỪ " + radTuNgay.Value.ToString("dd/MM/yyyy") + "   ĐẾN NGÀY   " + radDenNgay.Value.ToString("dd/MM/yyyy") + "");
                                rp.SetParameterValue("NgayThangNam", "Hà Nội, Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                                //rp.SetParameterValue("paraTenMay", "In từ máy tính: " + GlobalCommon.DisplayLocalHostName().ToUpper() + "   ngày:" + DateTime.Now.ToString("dd/MM/yyyy") + " vào lúc:" + DateTime.Now.ToString("hh:mm:ss")); 
                                rp.SetParameterValue("NguoiLap", PTIdentity.FullName);
                                //   rp.SetParameterValue("paraTenMay", "In từ máy tính: " + GlobalCommon.DisplayLocalHostName().ToUpper() + "   ngày:" + DateTime.Now.ToString("dd/MM/yyyy") + " vào lúc:" + DateTime.Now.ToString("hh:mm:ss"));
                                preview.ShowDialog();
                            }
                        }
                    }
                }
            }
           
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
