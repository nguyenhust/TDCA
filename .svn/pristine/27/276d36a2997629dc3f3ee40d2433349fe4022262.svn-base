using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UI;
using CrystalDecisions.CrystalReports.Engine;
using NETLINK.UI.Form;
using System.Data.SqlClient;
using CrystalDecisions.ReportSource;
//using Authoration.LIB;
namespace DanhMuc.UserControl
{
    public partial class Grid_DM_CanBo_NgoaiCDT : UsDictionary
    {
        #region variables

        private FormMode formMode = new FormMode();
        private int selectedID = -1;
        #endregion

        public Grid_DM_CanBo_NgoaiCDT()
        {
            InitializeComponent();
            RadGrid = radGridView;
            radGridView.CellDoubleClick += radGridView_CellDoubleClick;
            radGridView.CellFormatting += radGridView_CellFormatting;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            //PrintToShow();
        }
        #region Override

        public override object GetIdValue()
        {
            return TextMessages.ControlID.DM_CanBoGiangVien;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DM_CanBoGiangVien;
        }

        protected override void ApplyAuthorizationRules()
        {
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoNgoaiCDT_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoNgoaiCDT_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoNgoaiCDT_Del);
        }

        protected override void Save()
        {
            try
            {
                formMode.IsInsert = true;
                Form_CanBo_NgoaiCDT fr = new Form_CanBo_NgoaiCDT(formMode);
                fr.ShowDialog();
                LoadUS();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void LoadUS()
        {
            try
            {
             //   radbindingSource.DataSource = DIC_CanBo_Coll.GetDIC_CanBo_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition,LoaiCanBo.GiaoVien));
                radbindingSource.DataSource = DIC_GiangVien_Coll.GetDIC_GiangVien_Coll();
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                if (Convert.ToBoolean(radGridView.CurrentRow.Cells["Chon"].Value) == true)
                {
                    PreviewReport previewreport = new PreviewReport();
                    ReportDocument reportdocument = new ReportDocument();
                    string IDBienLaiList = string.Empty;
                    for (int j = 0; j <= radGridView.RowCount - 1; j++)
                    {
                        if (Convert.ToBoolean(radGridView.Rows[j].Cells["Chon"].Value) == true)
                        {
                            IDBienLaiList = IDBienLaiList + radGridView.Rows[j].Cells["ID"].Value + ',';
                        }
                    }
                    IDBienLaiList = IDBienLaiList.Substring(0, IDBienLaiList.Length - 1);
                    previewreport.Text = "Báo cáo danh sách giảng viên";
                    reportdocument.Load(AppConfig.ReportPath + "BC_DanhSachGiangVien.rpt");
                    DanhMuc.BaoCao.BaoCao dsdata = new BaoCao.BaoCao();
                    reportdocument.SetDataSource(dsdata);
                    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                    {
                        cn.Open();
                        using (SqlCommand cmd = cn.CreateCommand())
                        {
                            cmd.CommandText = "BC_DanhSachGiangVien";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ID", IDBienLaiList);
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                DataSet ds = new DataSet();
                                da.Fill(ds, "BC_DanhSachGiangVien");
                                if (ds.Tables[0].Rows.Count <= 0)
                                {
                                    GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                                    return;
                                }
                                else
                                {
                                    reportdocument.SetDataSource(ds);
                                    previewreport.crystalReportViewer.ReportSource = reportdocument;
                                    reportdocument.SetParameterValue("NgayThangNam", "Hà Nôi, Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                                    if (radInTatCa.Checked == true)
                                    {
                                        reportdocument.SetParameterValue("ChuyenKhoa", "Tất cả");
                                    }
                                    else
                                    {
                                        reportdocument.SetParameterValue("ChuyenKhoa", radGridView.CurrentRow.Cells["ChuyenKhoa"].Value.ToString());
                                    }
                                    reportdocument.SetParameterValue("NguoiLap", GlobalCommon.GetTenDayDu());
                                    //   rp.SetParameterValue("paraTenMay", "In từ máy tính: " + GlobalCommon.DisplayLocalHostName().ToUpper() + "   ngày:" + DateTime.Now.ToString("dd/MM/yyyy") + " vào lúc:" + DateTime.Now.ToString("hh:mm:ss"));
                                    previewreport.ShowDialog();
                                }
                            }
                        }
                    }
                }

                else
                {
                    GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DIC_CanBo.DeleteDIC_CanBo(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        #endregion

        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void radGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //try
            //{
            //    if (int.TryParse(radGridView.CurrentRow.Cells["IDGiangVien"].Value.ToString(), out selectedID)
            //        && GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoNgoaiCDT_Edit))
            //    {
            //        formMode.Id = selectedID;
            //        formMode.IsEdit = true;
            //        Form_CanBo_NgoaiCDT fr = new Form_CanBo_NgoaiCDT(formMode);
            //        fr.ShowDialog();
            //        LoadUS();
            //    }
            //}
            //catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radInTatCa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView.ChildRows)
                {
                    rowInfo.Cells["Chon"].Value = radInTatCa.Checked;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView.CurrentRow.Cells["IDGiangVien"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(TextMessages.RolePermission.DM_CanBoNgoaiCDT_Edit))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_CanBo_NgoaiCDT fr = new Form_CanBo_NgoaiCDT(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }
    }
}
