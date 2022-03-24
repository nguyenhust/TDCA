using NETLINK.LIB;
using DanhMuc.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using ModuleHanhChinh.LIB;
using System.Threading.Tasks;
using Authoration.LIB;

namespace ModuleHanhChinh.UI
{
    public partial class Form_ChamCong : NETLINK.UI.Dictionary
    {
        
        public Form_ChamCong(FormMode _formMode)
        {
            InitializeComponent();
            this.formMode = _formMode;
        }

        private void radGridView3_Click(object sender, EventArgs e)
        {

        }


        protected override void FormLoad()
        {
            try
            {
                
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void Form_ChamCong_Load(object sender, EventArgs e)
        {
           
        }



        private void radButtonFromExcel_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "xsl files (*.xsl)|*.xls|xlsx files (*.xlsx)|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string strFileName = openFileDialog.FileName;

                    if (strFileName == string.Empty)
                        return;
                    pictureBoxLoading.Visible = true;
                    radButtonFromExcel.Text = "Đang xử lý...";
                    Task t = Task.Factory.StartNew(() =>
                    {
                        if (!string.IsNullOrEmpty(strFileName))
                        {
                            DIC_CanBo_Coll Listcanbo = DIC_CanBo_Coll.GetDIC_CanBo_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                            HC_ChamCong_Coll ListChamCongCanBo = HC_ChamCong_Coll.NewHC_ChamCong_Coll();
                            ExcelHelper helper = new ExcelHelper();
                            List<ChamCongNhanVien> listChamCong = helper.ReadExcel(strFileName);
                            long userID = PTIdentity.IDNguoiDung;
                            if (listChamCong != null && listChamCong.Count > 0)
                            {
                                foreach (ChamCongNhanVien nhanVienCong in listChamCong)
                                {
                                    foreach (DIC_CanBo_Info canboInfo in Listcanbo)
                                    {
                                        if (canboInfo.MaNhanVienTheoMayCC == nhanVienCong.MaNhanVien)
                                        {
                                            long maNV = canboInfo.ID;
                                            foreach (NgayCong ngayCong in nhanVienCong.ngayCong)
                                            {

                                                HC_ChamCong_Info itemInfo = ListChamCongCanBo.AddNew();

                                                itemInfo.GioVao = ngayCong.ThoigianVao1;
                                                itemInfo.GioVao2 = ngayCong.ThoigianVao2;
                                                itemInfo.GioVao3 = ngayCong.ThoigianVao3;
                                                itemInfo.GioRa = ngayCong.Thoigianra1;
                                                itemInfo.GioRa2 = ngayCong.Thoigianra2;
                                                itemInfo.GioRa3 = ngayCong.Thoigianra3;
                                                itemInfo.SoCong = ngayCong.Cong.ToString();
                                                itemInfo.TongGio = ngayCong.TongGio.ToString();
                                                itemInfo.Ngay = ngayCong.Ngay.ToShortDateString();
                                                itemInfo.NgayTrongThang = ngayCong.Ngay.Day;
                                                itemInfo.Nam = ngayCong.Ngay.Year;
                                                itemInfo.Thang = ngayCong.Ngay.Month;
                                                itemInfo.Thu = ngayCong.Thu;
                                                if (ngayCong.ThoigianTre > 0)
                                                {
                                                    itemInfo.Muon = true;
                                                }
                                                else
                                                {
                                                    itemInfo.Muon = false;
                                                }
                                                if (ngayCong.Cong <= 0 && ngayCong.Thu.ToLower() != "cn" && ngayCong.Thu.ToLower() != "bảy" && ngayCong.Thu.ToLower() != "chủ nhật")
                                                {
                                                    itemInfo.NghiKhongLyDo = true;
                                                   
                                                }
                                                else
                                                {
                                                    itemInfo.NghiKhongLyDo = false;
                                                   
                                                }
                                                itemInfo.NgayPhep = false;
                                                itemInfo.DiCongTac = false;
                                                itemInfo.LyDo = string.Empty;
                                                
                                                long maChamCong = 0;
                                                long.TryParse(nhanVienCong.MaNhanVien, out maChamCong);

                                                itemInfo.IDCanBo = maNV;
                                                //Listcanbo.Remove(canboInfo);
                                                itemInfo.LastEdited_Date = DateTime.Now;
                                                itemInfo.LastEdited_UserID = userID;
                                                
                                            }
                                            break;
                                        }

                                    }
                                }

                                ListChamCongCanBo.Save();
                            }
                           //bindingSourceCanBo.DataSource = Listcanbo;
                            this.pictureBoxLoading.BeginInvoke(new Action(() =>
                            {
                                this.pictureBoxLoading.Visible = false;
                                this.radButtonFromExcel.Text = "Tải file chấm công";
                            }));
                        }
                    });
                    t.ContinueWith((Success) =>
                    {
                        GlobalCommon.ShowMessageInformation("Đã tải xong");
                        //this.Close();
                        //this.Close();
                    }, TaskContinuationOptions.NotOnFaulted);
                    t.ContinueWith((Fail) =>
                    {
                        GlobalCommon.ShowErrorMessager("Tải lên thất bại");
                        //log the exception i.e.: Fail.Exception.InnerException);
                    }, TaskContinuationOptions.OnlyOnFaulted);



                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

      

        //private void radDropDownListMonth_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        //{
        //    if (radDropDownListMonth.SelectedIndex >= 0) {
        //        if (radGridViewCanBo.CurrentRow != null)
        //        {
        //            if (radGridViewCanBo.CurrentRow.Cells["MaNhanVienTheoMayCC"].Value != null)
        //            {
        //                int currentMonth = radDropDownListMonth.SelectedIndex + 1;
        //                int currentYear = DateTime.Now.Year;

        //                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewWithCondition);

        //                HC_ChamCongSearchObject searchObj = new HC_ChamCongSearchObject(currentMonth, currentYear, radGridViewCanBo.CurrentRow.Cells["MaNhanVienTheoMayCC"].Value.ToString());
        //                function.Item = searchObj;

        //                bindingSourceNgayCong.DataSource = HC_NhanVien_ChamCong_Coll.GetHC_NhanVien_ChamCong_Coll(function);

        //            }
        //        }
        //    }
        //}

       
    }
}
