using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleDaoTao.LIB;


using CrystalDecisions.CrystalReports.Engine;
using Csla.Data;
using NETLINK.LIB;
using NETLINK.UI.Form;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NETLINK.UI;
using System.Threading.Tasks;
using System.IO;
using ExportLib.Entities.DaoTao;
using ExportLib;
using System.Diagnostics;
using Csla;
using Telerik.WinControls.UI;
using System.Drawing.Printing;

namespace TDCA.Report.BaoCaoForm
{
    public partial class BC_ChamCongGiangVien : Telerik.WinControls.UI.RadForm
    {
        string strMaLop = string.Empty;
        string strTenlop = string.Empty;
        public BC_ChamCongGiangVien(string MaLop, string TenLop, string TuNgay, string DenNgay)
        {
            InitializeComponent();
            strMaLop = MaLop;
            strTenlop = TenLop;
        }
        //public BC_ChamCongGiangVien()
        //{
        //    InitializeComponent();
        //    dTLienTucLopHocCollBindingSource.DataSource = DT_LienTuc_LopHoc_Coll.GetDT_LienTuc_LopHoc_Coll();
        //}

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
                            //ReportDocument.SetParameterValue("prmThoiGian", dtpDenNgay.Value.ToShortDateString());
                            ReportDocument.SetParameterValue("prmThang", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                            ReportDocument.SetParameterValue("prmNgayLap", "2019");
                            ReportDocument.SetParameterValue("prmNguoiLap", "Dat");

                            PreviewReport.ShowDialog();
                        }
                    }
                }
            }
        }

        private void radBtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
