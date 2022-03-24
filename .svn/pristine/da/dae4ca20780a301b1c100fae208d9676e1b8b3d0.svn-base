using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ExportLib;
using ExportLib.Entities.DaoTao;
using NETLINK.LIB;
using NETLINK.UI;
using CrystalDecisions.CrystalReports.Engine;
using System.Diagnostics;

namespace ModuleDaoTao.UI
{
    public partial class FromNhapSoTien : NETLINK.UI.Dictionary
    {
        public static int SoTien;
        public static int soLuong;
        public static Decimal donGia;
        public static Decimal thanhTien;
        public FromNhapSoTien()
        {
            InitializeComponent();     
            btnSave.Enabled = true;
            SoTien = ModuleDaoTao.UI.Form_LT_HocVienLienTuc.DieuKien;
            SoTien = ModuleDaoTao.UI.Form_LT_LopHoc.DKien;
            if (SoTien == 1)
            {
                this.Text = "Nhập số lượng đơn giá làm thẻ học viên";
                if (txtDonGia.Value=="")
                {
                    donGia = Convert.ToDecimal(txtDonGia.Value);
                }
                else
                {
                  txtDonGia.Value = "30000";                
                }
              
            }
           if (SoTien == 2)
                {
                   this.Text= "Nhập số lượng đơn giá làm chứng chỉ";
                    if (txtDonGia.Value == "")
                    {
                        donGia = Convert.ToDecimal(txtDonGia.Value);
                    }
                    else
                    {                    
                        txtDonGia.Text = "50000";                       
                    }
                    
                }
           radNoiDung.SelectedIndex = 1; 
        }    
        protected override void Save()
        {
            try
            {
               
                soLuong = Convert.ToInt32(txtSL.Text);
                donGia = Convert.ToDecimal(txtDonGia.Value);
                thanhTien = soLuong * donGia;       
                this.Close();
                
            }
            catch(Exception ex)
            {
                GlobalCommon.ShowError(ex);
            }

            }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            soLuong = 0;
            donGia = 0;
        }   
        private void FromNhapSoTien_Shown(object sender, EventArgs e)
        {
            txtSL.Focus();
        }

        private void radNoiDung_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {          
                ModuleDaoTao.UI.Form_LT_LopHoc.DKien = Convert.ToInt32(radNoiDung.SelectedIndex);
                radNoiDung.Enabled = true;
            if(ModuleDaoTao.UI.Form_LT_HocVienLienTuc.DieuKien==Convert.ToInt32(radNoiDung.SelectedIndex))
            {
                radNoiDung.Enabled = false;
            }

        }
  
        }
    }

