using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using CrystalDecisions.CrystalReports.Engine;
using NETLINK.UI.Form;
using System.Data.SqlClient;
using NETLINK.LIB;
using Authoration.LIB;
using ModuleHanhChinh.ThanhToan;
namespace TDCA.Report.BaoCaoForm
{
    public partial class FormHocVienChuaDongHocPhi : Telerik.WinControls.UI.RadForm
    {
        public FormHocVienChuaDongHocPhi()
        {
            InitializeComponent();
            radTuNgay.Value = GlobalCommon.GetTimeServer();
            radDenNgay.Value = GlobalCommon.GetTimeServer();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Print()
        {
            PreviewReport preview = new PreviewReport();
            ReportDocument rp = new ReportDocument();
            preview.Text = "Báo cáo học viên chưa hoàn thành học phí";         
            rp.Load(AppConfig.ReportPath + "BC_HocVienChuaHoanThanhHocPhi.rpt");                     
            ModuleHanhChinh.ThanhToan.BaoCao dsdata = new ModuleHanhChinh.ThanhToan.BaoCao();
            rp.SetDataSource(dsdata);

            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    
                     cm.CommandText = "BC_HocVienChuaDongHocPhi";                                  
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@TuNgay", Convert.ToDateTime(radTuNgay.Value.ToString("dd/MM/yyyy")));
                    cm.Parameters.AddWithValue("@DenNgay", Convert.ToDateTime(radDenNgay.Value.ToString("dd/MM/yyyy")));                    
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        DataSet ds = new DataSet();                       
                        da.Fill(ds, "BC_HocVienChuaDongHocPhi");                                             
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
}
