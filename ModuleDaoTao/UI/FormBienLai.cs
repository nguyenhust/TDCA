using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModuleDaoTao.LIB;
using CrystalDecisions.CrystalReports.Engine;
using NETLINK.UI.Form;
using NETLINK.LIB;
using NETLINK.UI;
using System.Data.SqlClient;

namespace ModuleDaoTao.UI
{
    public partial class FormBienLai : NETLINK.UI.Dictionary
    {
        private BienLaiColl obj;    
        public FormBienLai(Int32 _IDHocVien)
        {
            InitializeComponent();
            RadGrid = radBienLai;
            RadGrid.CellFormatting += radGridView_CellFormatting;
            STT();
            btnSave.Enabled = true;     
            obj = BienLaiColl.GetBienLaiTamThuColl(_IDHocVien);
            RadGrid.DataSource = obj;
            radBienLai.AllowAddNewRow = false;
        }

        protected override void Save()
        {                                       
          
            if (Convert.ToBoolean(radBienLai.CurrentRow.Cells["INPYC"].Value) == true)

            {
                if (Convert.ToBoolean(radBienLai.CurrentRow.Cells["Huy"].Value) == false)
                {
                    PreviewReport preview = new PreviewReport();
                    ReportDocument doc = new ReportDocument();
                    string IDBienLaiList = string.Empty;
                    for (int j = 0; j <= radBienLai.RowCount - 1; j++)
                    {
                        if (Convert.ToBoolean(radBienLai.Rows[j].Cells["INPYC"].Value) == true)
                        {
                            IDBienLaiList = IDBienLaiList + radBienLai.Rows[j].Cells["IDBienLai"].Value + ',';
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
                    MessageBox.Show("Biên lai này đã được huỷ nên bạn không thể in phiếu ! ", "Thông báo từ hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Convert.ToBoolean(radBienLai.CurrentRow.Cells["Huy"].Value) == false)
                {
                    PreviewReport preview = new PreviewReport();
                    ReportDocument doc = new ReportDocument();   
                    doc.Load(AppConfig.ReportPath + "rprBaoCaoHoanHocPhi.rpt");

                    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                    {
                        cn.Open();
                        using (SqlCommand cm = cn.CreateCommand())
                        {
                            cm.CommandText = "BaoCaoHoanTienHocPhirpt";
                            cm.CommandType = CommandType.StoredProcedure;

                            cm.Parameters.AddWithValue("@IDBienLai", Convert.ToString(radBienLai.CurrentRow.Cells["IDBienLai"].Value));

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
            }          
            radIntatCa.Checked = false;
        
        }
        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radBienLai_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            if (Convert.ToBoolean(e.Row.Cells["Huy"].Value) == true)
            {
                e.CellElement.Font = new Font(e.CellElement.Font, FontStyle.Strikeout);
                e.CellElement.ForeColor = Color.Red;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radBienLai.ChildRows)
                {
                    rowInfo.Cells["INPYC"].Value = radIntatCa.Checked;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

    }
}
