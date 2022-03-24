using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using System.Data.SqlClient;
using DanhMuc.LIB;

namespace DanhMuc.UI
{
    public partial class DM_TrangThai_TrangThietBi : Telerik.WinControls.UI.RadForm
    {
        public DM_TrangThai_TrangThietBi()
        {
            InitializeComponent();
        }

        #region variables

        DIC_TrangThaiTrangThietBi trangthaitrangthietbi;
        DIC_TrangThaiTrangThietBi_Coll trangthaitrangthietbicoll;

        #endregion

        private void radbtnAddNew_Click(object sender, EventArgs e)
        {
            trangthaitrangthietbi = DIC_TrangThaiTrangThietBi.NewDIC_TrangThaiTrangThietBi();
            bindThongTin.DataSource = trangthaitrangthietbi;
        }

        private void radbtnSave_Click(object sender, EventArgs e)
        {
            trangthaitrangthietbi.TenTrangThai = txtTrangThai.Text;
            trangthaitrangthietbi.GhiChu = txtGhiChu.Text;
            trangthaitrangthietbi.ApplyEdit();
            trangthaitrangthietbi.Save();
            radGirdTrangThaiList.DataSource = DIC_TrangThaiTrangThietBi_Coll.GetDIC_TrangThaiTrangThietBi_Coll();
        }

        private void DM_TrangThai_TrangThietBi_Load(object sender, EventArgs e)
        {
            trangthaitrangthietbi = DIC_TrangThaiTrangThietBi.NewDIC_TrangThaiTrangThietBi();
            txtTrangThai.Text = trangthaitrangthietbi.TenTrangThai;
            txtGhiChu.Text = trangthaitrangthietbi.GhiChu;
            radGirdTrangThaiList.DataSource = DIC_TrangThaiTrangThietBi_Coll.GetDIC_TrangThaiTrangThietBi_Coll();
        }

        private void radGirdTrangThaiList_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radGirdTrangThaiList.CurrentRow.Cells["IDTrangThai"].Value != null)
                {
                    trangthaitrangthietbi = DIC_TrangThaiTrangThietBi.GetDIC_TrangThaiTrangThietBi(Convert.ToInt64(radGirdTrangThaiList.CurrentRow.Cells["IDTrangThai"].Value));
                    txtTrangThai.Text = trangthaitrangthietbi.TenTrangThai;
                    txtGhiChu.Text = trangthaitrangthietbi.GhiChu;
                    //this.radGridDSTrangThai.DataSource = trangthaihocvien;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi click vào bản ghi!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
