using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ModuleDaoTao.LIB;
using CrystalDecisions.CrystalReports.Engine;
using Csla.Data;
using NETLINK.LIB;
using NETLINK.UI.Form;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Telerik.WinControls.UI;
using System.Drawing.Printing;
using Authoration.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_BangChamCongGV : Telerik.WinControls.UI.RadForm
    {
        string strMaLop = string.Empty;
        string strTenlop = string.Empty;
        string strTuNgay = string.Empty;
        string strDenNgay = string.Empty;
        public Form_BangChamCongGV(string MaLop, string TenLop, string TuNgay, string DenNgay)
        {
            InitializeComponent();
            strMaLop = MaLop;
            strTenlop = TenLop;
            strTuNgay = TuNgay;
            strDenNgay = DenNgay;
            radTxtMaLop.Text = MaLop;
            radtxtTenLop.Text = TenLop;
        }

        private void radBtnPrint_Click(object sender, EventArgs e)
        {
            PreviewReport PreviewReport = new PreviewReport();
            ReportDocument ReportDocument = new ReportDocument();
            PreviewReport.Text = "Bảng chấm công giảng viên";
            ReportDocument.Load(AppConfig.ReportPath + "rptChamCongGiangVien.rpt");
            ModuleDaoTao.DataSetReport dsData = new ModuleDaoTao.DataSetReport();
            ReportDocument.SetDataSource(dsData);
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {

                    cm.CommandText = "BC_ChamCongGiangVien";
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@MaLop", strMaLop);
                    cm.Parameters.AddWithValue("@Thang", radDropThang.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "BC_ChamCongGiangVien");
                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                            return;
                        }
                        else
                        {
                            ReportDocument.SetDataSource(ds);
                            PreviewReport.crystalReportViewer.ReportSource = ReportDocument;
                            ReportDocument.SetParameterValue("prmNoiDung", strTenlop);
                            ReportDocument.SetParameterValue("prmThoiGian", "Từ " + strTuNgay + " - " + strDenNgay);
                            ReportDocument.SetParameterValue("prmNgayLap", " Hà nội, ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                            ReportDocument.SetParameterValue("prmThang", radDropThang.Text);
                            ReportDocument.SetParameterValue("prmNguoiLap", PTIdentity.FullName);
                            PreviewReport.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
