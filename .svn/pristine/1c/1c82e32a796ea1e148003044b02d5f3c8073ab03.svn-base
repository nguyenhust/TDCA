using ModuleDaoTao.LIB;
using NETLINK.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TDCA
{
    public partial class testNumberOfRecords : Telerik.WinControls.UI.RadForm
    {
        public testNumberOfRecords()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(radTextBox1.Text);
                // DT_LienTuc_HocVien_Coll listx = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                progressBar1.Maximum = x;
                progressBar1.Value = 0;
                for (int i = 0; i < x; i++)
                {
                    DT_LienTuc_HocVien itemInfo = DT_LienTuc_HocVien.NewDT_LienTuc_HocVien();
                    itemInfo.HoTen = "Hoc Vien Test" + i.ToString();
                    itemInfo.NgaySinh = DateTime.Now.ToShortDateString();
                    itemInfo.NgayDangKi = "01/01/1995";
                    itemInfo.NgayBatDau = DateTime.Now.ToShortDateString();
                    itemInfo.NgayKetThuc = DateTime.Now.ToShortDateString();
                    itemInfo.SoCMT = i.ToString() + "Rac";
                    itemInfo.IdChuyenNganh = 1;
                    itemInfo.IdBoPhan = 1;
                    itemInfo.IdBenhVienCongTac = 10005;
                    itemInfo.IdTinhThanh = 12;
                    itemInfo.IdNguoiQuanLy = 15;
                    itemInfo.IdTrinhDo = 1;
                    itemInfo.ApplyEdit();
                    itemInfo.Save();
                    progressBar1.Value = i + 1;
                    
                }
                //listx.ApplyEdit();
                //listx.Save();
                GlobalCommon.ShowMessageInformation("Xong");
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalCommon.AcceptUpdate())
                {
                    DT_LienTuc_HocVien_Coll listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                    progressBar1.Maximum = listHV.Count;
                    progressBar1.Value = 0;
                    foreach (DT_LienTuc_HocVien_Info itemInfo in listHV)
                    {
                        DT_LienTuc_HocVien item = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(itemInfo.Id);
                        item.TongSoLanInThe = 0;
                        item.ApplyEdit();
                        item.Save();
                        progressBar1.Value++;
                    }
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalCommon.AcceptUpdate())
                {
                     string spearte = ",";
        string spearte2 = "^";
                    DT_LienTuc_HocVien_Coll listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                    progressBar1.Maximum = listHV.Count;
                    progressBar1.Value = 0;
                    string allInOne = string.Empty;
                    foreach (DT_LienTuc_HocVien_Info itemInfo in listHV)
                    {
                        DT_LienTuc_HocVien item = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(itemInfo.Id);
                        if (!string.IsNullOrEmpty(item.Backup01))
                        {
                            string[] yAllInOne = item.Backup01.Split(new string[] { spearte2 }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < yAllInOne.Length; i++)
                            {
                                string[] rowSplit = yAllInOne[i].Split(new string[] { spearte }, StringSplitOptions.RemoveEmptyEntries);
                                if (rowSplit.Length <= 3)
                                {
                                    allInOne+= string.Format("{0}{1}{2}{1}{3}{1}{4}{5}", rowSplit[0], spearte, rowSplit[1], rowSplit[2], "0", spearte2);
                                }
                            }
                        }
                        item.Backup01 = allInOne;
                        item.ApplyEdit();
                        item.Save();
                        progressBar1.Value++;
                        allInOne = string.Empty;
                    }
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void testNumberOfRecords_Load(object sender, EventArgs e)
        {

        }
        private string Business_CreateMaHocVienKemCap(int count,DateTime date)
        {
            string strCount = count.ToString();
            if (count < 10)
                strCount = string.Format("00{0}", count);
            else if (count < 100)
                strCount = string.Format("0{0}", count);
            string result = string.Format("{0}-KC-BM-{1}-B24", strCount, GlobalCommon.CutYear(date.Year));
            return result;
        }
        private void radButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DT_LienTuc_HocVien_Coll listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                progressBar1.Maximum = listHV.Count;
                progressBar1.Value = 0;
                int count = 1;
                foreach (DT_LienTuc_HocVien_Info itemInfo in listHV)
                {
                    if (itemInfo.HinhThucHoc.ToLower() == "kèm cặp")
                    {
                        DT_LienTuc_HocVien item = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(itemInfo.Id);
                        item.MaHocVien = Business_CreateMaHocVienKemCap(count, itemInfo.DateNgayDangKi);
                        item.STTHocVienKemCap = count.ToString();
                        count++;
                        item.ApplyEdit();
                        item.Save();
                    }
                    progressBar1.Value++;
                }
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            try
            {
                DT_LienTuc_HocVien_Coll listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                progressBar1.Maximum = listHV.Count;
                progressBar1.Value = 0;
                int count = 1;
                foreach (DT_LienTuc_HocVien_Info itemInfo in listHV)
                {
                   
                        DT_LienTuc_HocVien item = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(itemInfo.Id);
                        string[] HTSplit = item.HoTen.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        if (HTSplit.Length > 0)
                        {
                            item.Backup03 = HTSplit[HTSplit.Length - 1];
                        }
                        count++;
                        item.ApplyEdit();
                        item.Save();
                  
                    progressBar1.Value++;
                }
                GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            try
            {

                DT_LienTuc_HocVien_Coll listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(new BusinessFunction(BusinessFunctionMode.GetAllData));
                progressBar1.Maximum = listHV.Count;
                progressBar1.Value = 0;
                foreach (DT_LienTuc_HocVien_Info itemI in listHV)
                {
                    if (itemI.HinhThucHoc == DT_Common.KemCap)
                    {
                        DT_LienTuc_HocVien item = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(itemI.Id);
                        item.IdBoPhan = 1;
                        item.ApplyEdit();
                        item.Save();
                       
                    }
                    progressBar1.Value++;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
