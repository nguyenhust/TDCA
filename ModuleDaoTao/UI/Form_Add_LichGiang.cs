using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using ModuleDaoTao.LIB;
using Authoration.LIB;
using DanhMuc.LIB;
using NETLINK.LIB;
using Authoration.LIB;
using CrystalDecisions.CrystalReports.Engine;
using NETLINK.UI.Form;
using System.Data.SqlClient;


namespace ModuleDaoTao.UI
{
    public partial class Form_Add_LichGiang : Telerik.WinControls.UI.RadForm
    {
        DT_LichGiangTheoLop lichgiang;
        DT_LichGiangTheoLop_CT_Coll lichgiangCTColl;
        DIC_GiangVien giangvien;
        string DoiTuong;
        string NguonKinhPhi;
        string MaLop;
        string TenLop;
        DateTime NgayBatDau;
        DateTime NgayKetThuc;
        int indexRowhandle;
        public Form_Add_LichGiang( string strMaLop, string strTenLop, DateTime dteNgayBatDau, DateTime dteNgayKetThuc, string  strDoiTuong, string strNguonKinhPhi)
        {
            InitializeComponent();
            DoiTuong = strDoiTuong;
            NguonKinhPhi = strNguonKinhPhi;
            MaLop = strMaLop;
            TenLop = strTenLop;
            NgayBatDau = dteNgayBatDau;
            NgayKetThuc = dteNgayKetThuc;
            //radDS.AutoSizeColumnsMode = Fill;
        }

        #region hien thi cot

        private void AddColumns()
        {
            #region them combox GiangVien
            GridViewComboBoxColumn combGiangVien = new GridViewComboBoxColumn();
            combGiangVien.Width = 110;
            combGiangVien.MaxWidth = 300;
            combGiangVien.AutoCompleteMode = AutoCompleteMode.Append;
            combGiangVien.FilteringMode = GridViewFilteringMode.DisplayMember;
            combGiangVien.DataSource = DIC_GiangVien_Coll.GetDIC_GiangVien_Coll(MaLop);
            combGiangVien.DropDownStyle = RadDropDownStyle.DropDown;
            combGiangVien.DisplayMember = "HoTen";
            combGiangVien.ValueMember = "IDGiangVien";
            combGiangVien.Name = "cboGiangVien";
            combGiangVien.FieldName = "IDGiangVien";
            combGiangVien.HeaderText = "Tên giảng viên";
            
            this.radDS.Columns.Add(combGiangVien);
            //end add
            #endregion

            #region them combox Loai dao tao
            GridViewComboBoxColumn combLoaiDT = new GridViewComboBoxColumn();
            combLoaiDT.Width = 90;
            combLoaiDT.AutoCompleteMode = AutoCompleteMode.Append;
            combLoaiDT.FilteringMode = GridViewFilteringMode.DisplayMember;
            combLoaiDT.DataSource = GetDataSource();
            combLoaiDT.DropDownStyle = RadDropDownStyle.DropDown;
            combLoaiDT.DisplayMember = "LoaiDaoTao";
            combLoaiDT.ValueMember = "LoaiDaoTao";
            combLoaiDT.Name = "cboLoaiDT";
            combLoaiDT.FieldName = "LoaiDaoTao";
            combLoaiDT.HeaderText = "Loại đào tạo";
            this.radDS.Columns.Add(combLoaiDT);
            //end add
            #endregion

            #region Thêm buttion copyadd
            GridViewCommandColumn combCopyAdd = new GridViewCommandColumn();
            combCopyAdd.Width = 80;
            combCopyAdd.MaxWidth = 100;
            combCopyAdd.Name = "btnCopyAdd";
            combCopyAdd.FieldName = "btnCopyAdd";
            combCopyAdd.HeaderText = "Copy & Add";
            combCopyAdd.TextAlignment = ContentAlignment.MiddleCenter;
            combCopyAdd.UseDefaultText = true;
            combCopyAdd.DefaultText = "Thêm dòng";
            this.radDS.Columns.Add(combCopyAdd);
            //end add
            #endregion

            #region Thêm button Delete rows
            GridViewCommandColumn combDeleteRow = new GridViewCommandColumn();
            combDeleteRow.Width = 60;
            combDeleteRow.MaxWidth = 80;
            combDeleteRow.Name = "btnDeleteRow";
            combDeleteRow.FieldName = "btnDeleteRow";
            combDeleteRow.HeaderText = "Xóa dòng";
            combDeleteRow.UseDefaultText = true;
            combDeleteRow.TextAlignment = ContentAlignment.MiddleCenter;
            combDeleteRow.DefaultText = "Xóa";
            this.radDS.Columns.Add(combDeleteRow);
            //end add

            #endregion
            this.radDS.Columns["IDLichGiangCT"].IsVisible = false;
            this.radDS.Columns["IDLichGiang"].IsVisible = false;
            this.radDS.Columns["IDGiangVien"].IsVisible = false;
            this.radDS.Columns["IDNguoiDung"].IsVisible = false;
            this.radDS.Columns["LoaiDaoTao"].IsVisible = false;
            this.radDS.Columns["Ngay"].IsVisible = false;
            this.radDS.Columns["NgayGiang"].HeaderText = "Ngày giảng";
            this.radDS.Columns["NgayGiang"].MinWidth = 150;
            this.radDS.Columns["NgayGiang"].MaxWidth = 180;
            this.radDS.Columns["NgayGiang"].ReadOnly = true;
            this.radDS.Columns["BuoiGiang"].HeaderText = "Buổi";
            this.radDS.Columns["BuoiGiang"].MinWidth = 50;
            this.radDS.Columns["BuoiGiang"].MaxWidth = 60;
            this.radDS.Columns["BuoiGiang"].ReadOnly = true;
            this.radDS.Columns["NoiDungGiang"].HeaderText = "Nội dung giảng";
            this.radDS.Columns["NoiDungGiang"].MinWidth = 500;
            this.radDS.Columns["NoiDungGiang"].MaxWidth = 2000;
            this.radDS.Columns["LoaiDaoTao"].HeaderText = "Loại hình";
            this.radDS.Columns["LoaiDaoTao"].MinWidth = 80;
            this.radDS.Columns["LoaiDaoTao"].MaxWidth = 100;


            this.radDS.Columns.Move(radDS.Columns["NgayGiang"].Index, 0);
            this.radDS.Columns.Move(radDS.Columns["BuoiGiang"].Index, 1);
            this.radDS.Columns.Move(radDS.Columns["NoiDungGiang"].Index, 2);
            this.radDS.Columns.Move(radDS.Columns["cboLoaiDT"].Index, 3);
            this.radDS.Columns.Move(radDS.Columns["cboGiangVien"].Index, 4);
            this.radDS.Columns.Move(radDS.Columns["btnCopyAdd"].Index, 5);
            this.radDS.Columns.Move(radDS.Columns["btnDeleteRow"].Index, 6);
            this.radDS.Columns.Move(radDS.Columns["IDLichGiangCT"].Index, 7);
            this.radDS.Columns.Move(radDS.Columns["IDLichGiang"].Index, 8);
            this.radDS.Columns.Move(radDS.Columns["LoaiDaoTao"].Index, 9);
            this.radDS.Columns.Move(radDS.Columns["IDGiangVien"].Index, 10);
            this.radDS.Columns.Move(radDS.Columns["IDNguoiDung"].Index, 11);
            this.radDS.Columns.Move(radDS.Columns["Ngay"].Index, 12);
        }

        public class Custom
        {
            public string LoaiDaoTao { get; set; }
        }

        private BindingList<Custom> GetDataSource()
        {
           
            BindingList<Custom> list = new BindingList<Custom>();
            for (int i = 1; i <= 2; i ++)
            {
                if (i == 1)
                {
                    list.Add(new Custom()
                    {
                        LoaiDaoTao = "Lý thuyết"

                    });
                }
                else
                {
                    list.Add(new Custom()
                    {
                        LoaiDaoTao = "Thực hành"

                    });
                }
                
            }
            return list;
        }
        
        #endregion


        private void radbtnSave_Click(object sender, EventArgs e)
        {
            lichgiang.ApplyEdit();
            lichgiang.Save();
            MessageBox.Show("Lưu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            radDS.Columns.Clear();
            lichgiang = DT_LichGiangTheoLop.GetDT_LichGiangTheoLop(MaLop);
            bindLG.DataSource = lichgiang;
            bindLGCTList.DataSource = lichgiang.DT_LichGiangTheoLop_CT_Coll;
            AddColumns();
            MergeVertically();
            //Views();
        }

        private void GetList()
        {
            var culture = new System.Globalization.CultureInfo("vi-VN");
            DateTime dt = lichgiang.NgayBatDau;
            int month = dt.Month;
            DateTime enddate = Convert.ToDateTime(lichgiang.NgayKetThuc + " 12:00:00 PM");
            for (DateTime i = dt; i <= enddate; i = i.AddDays(0.5))
            {
                //string strNgay = i.ToString("dd/MM/yyyy");
                radDS.Rows.Add(1, 2, culture.DateTimeFormat.GetDayName(i.DayOfWeek).ToString() + " - " + i.ToString("dd/MM/yyyy"), i.ToString("tt").Replace("AM", "Sáng").Replace("PM", "Chiều"), "", "Thực hành", 0, Convert.ToInt64(PTIdentity.IDNguoiDung), i.ToString("dd/MM/yyyy"));                
            }
        }

        private void radDS_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int index = radDS.CurrentRow.Index;
            if (radDS.CurrentColumn.Name == "btnCopyAdd" || radDS.CurrentColumn.Name == "btnDeleteRow")
            {
                if (radDS.CurrentColumn.Name == "btnCopyAdd")
                {
                    DialogResult dlr = MessageBox.Show("Bạn có đồng ý thêm dòng mới ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if ( dlr == DialogResult.OK)
                    {
                        try {
                            //radDS.CurrentRow.Cells["cboGiangVien"].Value = "";
                            radDS.Rows.Add(radDS.CurrentRow.Cells["NgayGiang"].Value, radDS.CurrentRow.Cells["BuoiGiang"].Value,
                            radDS.CurrentRow.Cells["NoiDungGiang"].Value, radDS.CurrentRow.Cells["LoaiDaoTao"].Value,
                            radDS.CurrentRow.Cells["cboGiangVien"].Value, radDS.CurrentRow.Cells["btnCopyAdd"].Value, radDS.CurrentRow.Cells["btnDeleteRow"].Value,
                            radDS.CurrentRow.Cells["IDLichGiangCT"].Value, radDS.CurrentRow.Cells["IDLichGiang"].Value,
                            radDS.CurrentRow.Cells["LoaiDaoTao"].Value, 0,
                            radDS.CurrentRow.Cells["IDNguoiDung"].Value, radDS.CurrentRow.Cells["Ngay"].Value);    
                            
                            }
                        catch (Exception ex)
                        {
                            GlobalCommon.ShowErrorMessager(ex);
                        }
                    }  
                        
                        
                }

                if (radDS.CurrentColumn.Name == "btnDeleteRow")
                {
                    DialogResult dlr = MessageBox.Show("Bạn có đồng ý xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlr == DialogResult.OK)
                    {
                        index = radDS.CurrentRow.Index;
                        radDS.Rows.RemoveAt(index);
                        //MessageBox.Show("Bạn có đồng ý thêm dòng mới ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
                lichgiang.ApplyEdit();
                lichgiang.Save();
                radDS.Columns.Clear();
                lichgiang = DT_LichGiangTheoLop.GetDT_LichGiangTheoLop(MaLop);
                bindLG.DataSource = lichgiang;
                bindLGCTList.DataSource = lichgiang.DT_LichGiangTheoLop_CT_Coll;
                AddColumns();
                MergeVertically();
                radDS.Rows[index].IsSelected = true;
                radDS.Rows[index].IsCurrent = true;
                radDS.Rows[index].EnsureVisible();
                //Views();
            }
        }
        private void radDS_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            //if (e.CellElement.ColumnInfo is GridViewCommandColumn)
            //{
            //    GridCommandCellElement element = (GridCommandCellElement)e.CellElement;
            //    element.CommandButton.ButtonFillElement.BackColor = Color.GreenYellow;
            //    element.CommandButton.ButtonFillElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid;
            //}

            string strThuBay = "Thứ Bảy ";
            string strChuNhat = "Chủ Nhật";
            for (int i = 0; i < radDS.RowCount; i++)
            {
                //radDS.Rows[i].Cells["btnDeleteRow"].Style.BackColor = Color.Red;
                string str = radDS.Rows[i].Cells["NgayGiang"].Value.ToString().Substring(0, 10);
                if (str == strThuBay || str == strChuNhat)
                {
                    //radDS.Rows[i].Cells["NgayGiang"].Style.ForeColor = Color.Red;
                    radDS.Rows[i].Cells["BuoiGiang"].Style.ForeColor = Color.Red;
                }
            }            
        }      
        //Hợp nhất theo chiều dọc
        private void MergeVertically()
        {
            int k = radDS.Columns.Count;
            int[] columns= new int[k] ;
            //for(int c = 0;c<radDS.Columns.Count;c++)
            for (int c = 0; c < 2; c ++ )
            {
                columns[c] = c;
            }
            GridViewRowInfo Prev = null;
            foreach (GridViewRowInfo item in radDS.Rows)
            {
                if (Prev != null)
                {
                    string firstCellText = string.Empty;
                    string secondCellText = string.Empty;
                    foreach (int i in columns)
                    {
                        GridViewCellInfo firstCell = Prev.Cells[i];
                        GridViewCellInfo secondCell = item.Cells[i];
                        firstCellText = (firstCell != null && firstCell.Value != null ? firstCell.Value.ToString() : string.Empty);
                        secondCellText = (secondCell != null && secondCell.Value != null ? secondCell.Value.ToString() : string.Empty);
                        if (firstCellText == secondCellText)
                        {
                            string strThuBay = "Thứ Bảy ";
                            string strChuNhat = "Chủ Nhật";
                            if (firstCellText.Length >=10)
                            {
                                if (firstCellText.Substring(0, 10) == strThuBay || firstCellText.Substring(0, 10) == strChuNhat)
                                {
                                    firstCell.Style.ForeColor = Color.Red;
                                }
                            }
                            //if (firstCellText.Substring(0, 10) == strThuBay || firstCellText.Substring(0, 10) == strChuNhat)
                            //{
                            //    firstCell.Style.ForeColor = Color.Red;
                            //}
                            firstCell.Style.BorderBottomColor = Color.Transparent;
                            secondCell.Style.BorderTopColor = Color.Transparent;
                            secondCell.Style.ForeColor = Color.Transparent;
                        }
                        else
                        {
                            secondCell.Style.ForeColor = Color.Black;
                            Prev = item;
                            break;
                        }
                    }
                }
                else
                {
                    Prev = item;
                }
            }
        }

        private void Views()
        {
            int k = radDS.Columns.Count;
            int[] columns = new int[k];
            for (int c = 0; c < radDS.Columns.Count; c++)
            {
                columns[c] = c;
            }
            GridViewRowInfo Prev = null;
            foreach (GridViewRowInfo item in radDS.Rows)
            {
                if (Prev != null)
                {
                    string firstCellText = string.Empty;
                    string secondCellText = string.Empty;
                    foreach (int i in columns)
                    {
                        GridViewCellInfo firstCell = Prev.Cells[i];
                        GridViewCellInfo secondCell = item.Cells[i];
                        firstCellText = (firstCell != null && firstCell.Value != null ? firstCell.Value.ToString() : string.Empty);
                        secondCellText = (secondCell != null && secondCell.Value != null ? secondCell.Value.ToString() : string.Empty);
                        if (firstCellText == secondCellText)
                        {
                            firstCell.Style.BorderBottomColor = Color.Transparent;
                            secondCell.Style.BorderTopColor = Color.Transparent;
                            secondCell.Style.ForeColor = Color.Transparent;
                        }
                        else
                        {
                            secondCell.Style.ForeColor = Color.Black;
                            Prev = item;
                            break;
                        }
                    }
                }
                else
                {
                    Prev = item;
                }
            }
        }

        private void Form_Add_LichGiang_Load(object sender, EventArgs e)
        {
            lichgiang = DT_LichGiangTheoLop.GetDT_LichGiangTheoLop(MaLop);
            bindLG.DataSource = lichgiang;
            bindLGCTList.DataSource = lichgiang.DT_LichGiangTheoLop_CT_Coll;
            if (lichgiang.MaLop == "")
            {
                lichgiang = DT_LichGiangTheoLop.NewDT_LichGiangTheoLop();
                lichgiang.MaLop = MaLop;
                lichgiang.TenLop = TenLop;
                lichgiang.NgayBatDau = NgayBatDau;
                lichgiang.NgayKetThuc = NgayKetThuc;
                bindLG.DataSource = lichgiang;
                bindLGCTList.DataSource = lichgiang.DT_LichGiangTheoLop_CT_Coll;
                GetList();
            }
            AddColumns();
            MergeVertically();
            //Views();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult drl = MessageBox.Show("Bạn có đồng ý xóa không ?", "Xác nhận lại hành động", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if ( drl == DialogResult.Yes)
            {
                DT_LichGiangTheoLop.DeleteDT_LichGiangTheoLop(lichgiang.IDLichGiang);
            }                       
            this.Close();
        }

        private void radDS_CellValueChanged(object sender, GridViewCellEventArgs e)
        {
            if (radDS.CurrentColumn.Name == "cboGiangVien")
            {
                Int64 IDGV = Convert.ToInt64(radDS.CurrentRow.Cells["IDGiangVien"].Value);
                string Ngay = Convert.ToString(radDS.CurrentRow.Cells["Ngay"].Value);
                string Buoi = Convert.ToString(radDS.CurrentRow.Cells["BuoiGiang"].Value);
                string ND = GlobalCommon.KiemTraGiangVien(IDGV, Ngay, Buoi);
                if (ND != "")
                {
                    int vt = ND.IndexOf("(");
                    int dodai = ND.Length;
                    string strMaLop = ND.Substring(vt + 2, (dodai - vt -4));
                    if (strMaLop != lichgiang.MaLop)
                    {
                        MessageBox.Show(GlobalCommon.KiemTraGiangVien(IDGV, Ngay, Buoi), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        radDS.CurrentRow.Cells["IDGiangVien"].Value = 0;
                    }                    
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

                PreviewReport PreviewReport = new PreviewReport();
                ReportDocument ReportDocument = new ReportDocument();
                DataTable tblResult = new DataTable();
                DataTable dataTable = new DataTable();
                DataRow drow;
                DataRow dr;
                DataSet dataSet = new DataSet();
                PreviewReport.Text = "Lịch giảng chi tiết";
                //ReportDocument.Load(AppConfig.ReportPath + "rpt_LGChiTiet.rpt");
                ReportDocument.Load(AppConfig.ReportPath + "rptLichGiangChiTiet.rpt");
                ModuleDaoTao.DataSetReport ds = new ModuleDaoTao.DataSetReport();
                ReportDocument.SetDataSource(ds);
                using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                {
                    cn.Open();
                    using (SqlCommand cm = cn.CreateCommand())
                    {

                        cm.CommandText = "BC_LichGiangChiTiet";
                        cm.CommandType = CommandType.StoredProcedure;
                        cm.Parameters.AddWithValue("@IDLichGiang", lichgiang.IDLichGiang);
                        using (SqlDataAdapter da = new SqlDataAdapter(cm))
                        {
                            tblResult = ds.Tables["LichGiangTheoLopCT"].Clone();
                            da.Fill(dataSet);
                            dataTable = dataSet.Tables[0];
                            if (dataSet.Tables[0].Rows.Count <= 0)
                            {
                                GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
                                return;
                            }
                            else
                            {
                                int countRows = dataTable.Rows.Count;
                                drow = tblResult.NewRow();
                                dr = dataTable.Rows[0];
                                drow["NgayGiang"] = dr["NgayGiang"];
                                drow["BuoiGiang"] = dr["BuoiGiang"];
                                drow["NoiDungGiang"] = dr["NoiDungGiang"];
                                drow["HoTen"] = dr["HoTen"];
                                drow["TuanThu"] = dr["TuanThu"];
                                for (int i = 1; i < countRows; i++)
                                {
                                    dr = dataTable.Rows[i];

                                    string shs = drow["NgayGiang"].ToString();
                                    string s1 = dr["NgayGiang"].ToString();
                                    string s2 = drow["BuoiGiang"].ToString();
                                    string s3 = dr["BuoiGiang"].ToString();
                                    if (drow["BuoiGiang"].ToString().Contains(dr["BuoiGiang"].ToString()))
                                        drow["BuoiGiang"] = dr["BuoiGiang"];
                                    if (drow["NgayGiang"].ToString() != dr["NgayGiang"].ToString() || drow["BuoiGiang"].ToString() != dr["BuoiGiang"].ToString())
                                        {
                                            string sbl = drow["BuoiGiang"].ToString();
                                            tblResult.Rows.Add(drow);

                                            drow = tblResult.NewRow();
                                            drow["NgayGiang"] = dr["NgayGiang"];
                                            drow["BuoiGiang"] = dr["BuoiGiang"];
                                            drow["NoiDungGiang"] = dr["NoiDungGiang"];
                                            drow["HoTen"] = dr["HoTen"];
                                            drow["TuanThu"] = dr["TuanThu"];
                                        }
                                        else
                                        if (drow["BuoiGiang"].ToString().Contains(dr["BuoiGiang"].ToString()) && drow["HoTen"].ToString().Contains(dr["HoTen"].ToString())) //&& drow["MaBienLai"].ToString().Contains(dr["MaBienLai"].ToString()))
                                            {

                                                drow["BuoiGiang"] = dr["BuoiGiang"] + "\n";
                                                drow["HoTen"] = drow["HoTen"].ToString() + "\n" + dr["HoTen"].ToString();
                                                //drow["SoTien"] = Convert.ToDecimal(drow["SoTien"]);// +Convert.ToDecimal(drow["SoTien"]);

                                                //if (drow["SoHoaDon"].ToString() != dr["SoHoaDon"].ToString())
                                                //{

                                                //    drow["SoHoaDon"] = drow["SoHoaDon"] + "<br>" + dr["SoHoaDon"].ToString();
                                                //    drow["TienThucThu"] = Convert.ToDecimal(drow["TienThucThu"]) + Convert.ToDecimal(dr["TienThucThu"]);
                                                //}
                                                //string tk = dr["TenKhoa"].ToString();
                                                //if (drow["TenKhoa"].ToString().Contains(dr["TenKhoa"].ToString()))
                                                //{
                                                //    drow["TenKhoa"] = dr["TenKhoa"];

                                                //    string tk2 = drow["TenKhoa"].ToString();
                                                //}
                                                //else
                                                //{
                                                //    drow["TenKhoa"] = drow["TenKhoa"].ToString() + "<br>" + dr["TenKhoa"].ToString();
                                                //    // string tk = dr["TenKhoa"].ToString();
                                                //    string tk2 = drow["TenKhoa"].ToString();
                                                //}
                                                //string BL = drow["MaBienLai"].ToString();
                                            }
                                            else
                                            {

                                                drow["NgayGiang"] = dr["NgayGiang"];
                                                drow["BuoiGiang"] = dr["BuoiGiang"];
                                                if (drow["NoiDungGiang"].ToString().Contains(dr["NoiDungGiang"].ToString()))
                                                {
                                                    drow["NoiDungGiang"] = dr["NoiDungGiang"];
                                                }
                                                else
                                                {
                                                    drow["NoiDungGiang"] = drow["NoiDungGiang"] + "\n" + dr["NoiDungGiang"];
                                                }
                                                drow["HoTen"] = drow["HoTen"].ToString() + "\n" + dr["HoTen"].ToString();
                                                drow["TuanThu"] = dr["TuanThu"];
                                            }
                                    
                                }

                                tblResult.Rows.Add(drow);
                                ReportDocument.SetDataSource(tblResult);
                                PreviewReport.crystalReportViewer.ReportSource = ReportDocument;                   
                                ReportDocument.SetParameterValue("prmNoiDung", lichgiang.TenLop);
                                ReportDocument.SetParameterValue("prmThoiGian", "Từ ngày" + lichgiang.NgayBatDau + " - " + lichgiang.NgayKetThuc);
                                ReportDocument.SetParameterValue("prmDoiTuong", DoiTuong);
                                ReportDocument.SetParameterValue("prmLanhDao", "Đạt");
                                ReportDocument.SetParameterValue("prmThoiGianServer", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
                                ReportDocument.SetParameterValue("prmNguoiDung", PTIdentity.FullName);
                                PreviewReport.ShowDialog();
                            }
                        }
                    }
                }


        //    PreviewReport PreviewReport = new PreviewReport();
        //    ReportDocument ReportDocument = new ReportDocument();
        //    PreviewReport.Text = "Lịch giảng chi tiết";
        //    ReportDocument.Load(AppConfig.ReportPath + "rptLichGiangChiTiet.rpt");
        //    ModuleDaoTao.DataSetReport dsData = new ModuleDaoTao.DataSetReport();
        //    ReportDocument.SetDataSource(dsData);
        //    using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
        //    {
        //        cn.Open();
        //        using (SqlCommand cm = cn.CreateCommand())
        //        {

        //            cm.CommandText = "BC_LichGiangChiTiet";
        //            cm.CommandType = CommandType.StoredProcedure;
        //            cm.Parameters.AddWithValue("@IDLichGiang", lichgiang.IDLichGiang);
        //            using (SqlDataAdapter da = new SqlDataAdapter(cm))
        //            {
        //                DataSet ds = new DataSet();
        //                da.Fill(ds, "LichGiangTheoLopCT");// bác để e ngó cái này phát
        //                if (ds.Tables[0].Rows.Count <= 0)
        //                {
        //                    GlobalCommon.ShowError("Không có dữ liệu để báo cáo !", "Thông báo");
        //                    return;
        //                }
        //                else
        //                {
        //                    ReportDocument.SetDataSource(ds);//okii rồi bác
        //                    PreviewReport.crystalReportViewer.ReportSource = ReportDocument;// sao bên bác vẫn chạy chỗ này bình thường mà bên e nó lại bắt version crystal nhỉ                          
        //                    ReportDocument.SetParameterValue("prmNoiDung", lichgiang.TenLop);
        //                    ReportDocument.SetParameterValue("prmThoiGian", "Từ ngày" + lichgiang.NgayBatDau + " - " + lichgiang.NgayKetThuc);
        //                    ReportDocument.SetParameterValue("prmDoiTuong", DoiTuong);
        //                    ReportDocument.SetParameterValue("prmLanhDao", "Đạt");
        //                    ReportDocument.SetParameterValue("prmThoiGianServer", " Ngày " + GlobalCommon.GetTimeServer().ToString("dd") + " Tháng " + GlobalCommon.GetTimeServer().ToString("MM") + " Năm " + GlobalCommon.GetTimeServer().ToString("yyyy"));
        //                    ReportDocument.SetParameterValue("prmNguoiDung", PTIdentity.FullName);
        //                    PreviewReport.ShowDialog();
        //                }
        //            }
        //        }
        //    }
        }

    }
}
