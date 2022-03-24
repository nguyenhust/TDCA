using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Authoration.LIB;
using NETLINK.UI.Form;
using NETLINK.LIB;
using System.Data.SqlClient;
namespace TDCA.Report.BaoCaoForm
{
    public partial class frmBaoCaoHuy : Telerik.WinControls.UI.RadForm
    {
        public frmBaoCaoHuy()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
                      XemBaoCao();

        }

        private void rcbTatCa_CheckStateChanged(object sender, EventArgs e)
        {
            // rcbNguoiDung.Checked = false;
        }

        private void rcbNguoiDung_CheckStateChanged(object sender, EventArgs e)
        {
            //  rcbTatCa.Checked = false;
        }
        private void XemBaoCao()
        {
            PreviewReport preview = new PreviewReport();
            ReportDocument rp = new ReportDocument();
            preview.Text = "Báo cáo huỷ học phí";
            rp.Load(AppConfig.ReportPath + "rptBaoCaoHuyHocVien.rpt");

            ModuleHanhChinh.ThanhToan.BaoCao dsdata = new ModuleHanhChinh.ThanhToan.BaoCao();
            rp.SetDataSource(dsdata);

            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                cn.Open();
                using (SqlCommand cm = cn.CreateCommand())
                {
                    cm.CommandText = "BaoCaoHuyBienLai_ThucTe";
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
                        da.Fill(ds, "BaoCaoHuyBienLaiThucTe");
                        if (ds.Tables[0].Rows.Count <= 0)
                        {
                            GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                            return;
                        }
                        else
                        {

                            rp.SetDataSource(ds);
                            preview.crystalReportViewer.ReportSource = rp;
                            if (rdoNguoiDung.IsChecked == true)
                                rp.SetParameterValue("prTenBaoCao", "BÁO CÁO HUỶ BIÊN LAI THEO NGƯỜI DÙNG");
                            else
                                rp.SetParameterValue("prTenBaoCao", "BÁO CÁO HUỶ BIÊN LAI");

                            rp.SetParameterValue("prTuNgay", GlobalCommon.ConvertNgayBaoCao(dtpTuNgay.Value, dtpDenNgay.Value));

                            rp.SetParameterValue("prNgayThangNam", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                            //rp.SetParameterValue("paraTenMay", "In từ máy tính: " + GlobalCommon.DisplayLocalHostName().ToUpper() + "   ngày:" + DateTime.Now.ToString("dd/MM/yyyy") + " vào lúc:" + DateTime.Now.ToString("hh:mm:ss")); 
                            rp.SetParameterValue("prTenNguoiDung", PTIdentity.FullName);
                         //   rp.SetParameterValue("paraTenMay", "In từ máy tính: " + GlobalCommon.DisplayLocalHostName().ToUpper() + "   ngày:" + DateTime.Now.ToString("dd/MM/yyyy") + " vào lúc:" + DateTime.Now.ToString("hh:mm:ss"));
                            preview.ShowDialog();
                        }
                    }
                }
            }

        }

      

    }
}
