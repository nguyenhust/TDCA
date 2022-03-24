using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using ModuleHanhChinh.LIB;
using System.Data.SqlClient;


namespace ModuleHanhChinh.UI
{
    public partial class DM_TrangThai_HocVien : Telerik.WinControls.UI.RadForm
    {
        #region variables

        TrangThaiCuaHocVien trangthaihocvien ;
        TrangThaiCuaHocVien_Coll trangthaihocviencoll;

        #endregion
        public DM_TrangThai_HocVien()
        {
            InitializeComponent();           
        }

        private void DM_TrangThai_HocVien_Load(object sender, EventArgs e)
        {
            trangthaihocvien = TrangThaiCuaHocVien.NewTrangThaiCuaHocVien();
            radtxtTrangThai.Text = trangthaihocvien.TenTrangThai;
            radtxtGhiChu.Text = trangthaihocvien.GhiChu;
            radGridDSTrangThai.DataSource = TrangThaiCuaHocVien_Coll.GetTrangThaiCuaHocVien_Coll();
        }

        private void radbtnAddNew_Click(object sender, EventArgs e)
        {
            trangthaihocvien = TrangThaiCuaHocVien.NewTrangThaiCuaHocVien();
            bindTrangThaiHocVien.DataSource = trangthaihocvien;
        }

        private void radbtnSave_Click(object sender, EventArgs e)
        {
            trangthaihocvien.TenTrangThai = radtxtTrangThai.Text;
            trangthaihocvien.GhiChu = radtxtGhiChu.Text;
            trangthaihocvien.ApplyEdit();
            trangthaihocvien.Save();
            radGridDSTrangThai.DataSource = TrangThaiCuaHocVien_Coll.GetTrangThaiCuaHocVien_Coll();
        }

        private void radGridDSTrangThai_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGridDSTrangThai.CurrentRow.Cells["IDTrangThai"].Value != null)
                {
                    trangthaihocvien = TrangThaiCuaHocVien.GetTrangThaiCuaHocVien(Convert.ToInt64(radGridDSTrangThai.CurrentRow.Cells["IDTrangThai"].Value));
                    radtxtTrangThai.Text = trangthaihocvien.TenTrangThai;
                    radtxtGhiChu.Text = trangthaihocvien.GhiChu;
                    //this.radGridDSTrangThai.DataSource = trangthaihocvien;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi click vào bản ghi!");
            }
        }

          
    }
}
