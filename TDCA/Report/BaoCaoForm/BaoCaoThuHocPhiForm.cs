using Authoration.LIB;
using CrystalDecisions.CrystalReports.Engine;
using Csla.Data;
using NETLINK.LIB;
using NETLINK.UI.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frmBCHocVienDongHocPhi : Form
    {
        public static Boolean Huy;
        public static decimal SoTien;
        public frmBCHocVienDongHocPhi()
        {
            InitializeComponent();
        }

        private void rbtHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBCHocVienDongHocPhi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        private void rbtXemBaoCao_Click(object sender, EventArgs e)
        {
            XemBaoCaoTruocKhiIn();           
        }

        private void XemBaoCaoTruocKhiIn()
        {
            PreviewReport PreviewReport = new PreviewReport();
            ReportDocument ReportDocument = new ReportDocument();
            PreviewReport.Text = "Báo cáo học viên đóng học phí";
            ReportDocument.Load(AppConfig.ReportPath + "rptHocVienDongHocPhi.rpt");
            ModuleHanhChinh.ThanhToan.BaoCao dsData = new ModuleHanhChinh.ThanhToan.BaoCao();
            ReportDocument.SetDataSource(dsData);
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {

                    cm.CommandText = "BC_ThuHocPhiHocVien";
                    cm.CommandType = CommandType.StoredProcedure;
                    string TuNgay = dtpTuNgay.Value.ToString("MM/dd/yyyy");
                    string DenNgay = dtpDenNgay.Value.ToString("MM/dd/yyyy");
                    cm.Parameters.AddWithValue("@TuNgay", TuNgay);
                    cm.Parameters.AddWithValue("@DenNgay", DenNgay);
                    if (rdoNguoiDung.IsChecked == true)
                        cm.Parameters.AddWithValue("@DieuKien", 1);
                    else
                        cm.Parameters.AddWithValue("@DieuKien", 2);
                    long IDNguoiDung = PTIdentity.IDNguoiDung;
                    cm.Parameters.AddWithValue("@IDNguoiDung", IDNguoiDung);
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "BaoCaoHocVienDongHocPhi");// bác để e ngó cái này phát
                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                            return;
                        }
                        else
                        {
                            ReportDocument.SetDataSource(ds);//okii rồi bác
                            PreviewReport.crystalReportViewer.ReportSource = ReportDocument;// sao bên bác vẫn chạy chỗ này bình thường mà bên e nó lại bắt version crystal nhỉ
                            //oki bác
                            if(rdoNguoiDung.IsChecked == true)
                                ReportDocument.SetParameterValue("TenBaoCao", "BÁO CÁO THỰC THU HỌC PHÍ THEO NGƯỜI DÙNG");
                            else
                                ReportDocument.SetParameterValue("TenBaoCao", "BÁO CÁO THỰC THU HỌC PHÍ");
                            ReportDocument.SetParameterValue("TuNgay", dtpTuNgay.Value.ToShortDateString());
                            ReportDocument.SetParameterValue("DenNgay", dtpDenNgay.Value.ToShortDateString());
                            ReportDocument.SetParameterValue("NgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                            ReportDocument.SetParameterValue("TenNguoiDung", PTIdentity.FullName);
                           
                            PreviewReport.ShowDialog();
                        }
                    }
                }
            }
        }
      
        private void frmBCHocVienDongHocPhi_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = DateTime.Now;
            dtpDenNgay.Value = DateTime.Now;
           
        }
    }
}
