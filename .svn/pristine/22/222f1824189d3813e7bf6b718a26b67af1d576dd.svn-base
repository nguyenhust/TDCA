using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DanhMuc.LIB;
using NETLINK.LIB;
using NETLINK.UI;
using NETLINK.UI.Form;



namespace DanhMuc
{
    public partial class CanBoInfo : DictionaryEx
    {
        
        long IDCanBo, IDTinh, IDHuyen;   
        DIC_CanBo canbo;
        
        public CanBoInfo()
        {
            InitializeComponent(); 
        }
        public CanBoInfo(Int64 _ID)
        {
            InitializeComponent();
            IDCanBo = _ID; 
        }

        #region Override
        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("CanBoInfo:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"
            || Csla.ApplicationContext.User.IsInRole("CanBoInfo:U"));
            btnDelete.Enabled = (Csla.ApplicationContext.User.IsInRole("CanBoInfo:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }

        protected override void Save()
        {
            try
            {
                if (radXa.SelectedValue != null)
                {
                    canbo.IDTinh = Convert.ToInt64(radXa.SelectedValue);
                }
                else
                if ( radHuyen.SelectedValue != null )
                {
                    canbo.IDTinh = Convert.ToInt64(radHuyen.SelectedValue);
                }
                else if (radTinhThanh.SelectedValue != null)
                {
                    canbo.IDTinh = Convert.ToInt64(radTinhThanh.SelectedValue);
                }
                canbo.ApplyEdit();
                canbo.Save();
                bindCanBo.DataSource = canbo;
                this.Close();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowError(ex.Message, "Lưu thất bại.");
            }
        }
  
        protected override void Cancel()
        {
            this.Close();
        }
        protected override void FormLoad()
        {
            this.bindGioiTinh.DataSource = DIC_GioiTinh_Coll.GetDIC_GioiTinh_Coll();
            this.bindTinhThanh.DataSource = DIC_TinhChild_Coll.GetDIC_TinhChild_Coll();
            this.bindQuocGia.DataSource = DIC_QuocGia_Coll.GetDIC_QuocGia_Coll();
            
            this.bindCoQuan.DataSource = DIC_CoQuan_Coll.GetDIC_CoQuan_Coll();
            this.bindBoPhan.DataSource = DIC_BoPhan_Coll.GetDIC_BoPhan_Coll();
            this.bindChucVu.DataSource = DIC_ChucVu_Coll.GetDIC_ChucVu_Coll();
            radTinhThanh.SelectedValue = null;
    
            radHuyen.SelectedValue = null;
            radXa.SelectedValue = null;
            if (IDCanBo == 0)
            {
                canbo = DIC_CanBo.NewDIC_CanBo();
                bindCanBo.DataSource = canbo;
                btnDelete.Enabled = false;
                radTxtTenCanBo.Focus();
            }
            else
            {
                canbo = DIC_CanBo.GetDIC_CanBo(IDCanBo);
                bindCanBo.DataSource = canbo;
                LoadTinhThanh();
                radTxtTenCanBo.Focus();
            }
        }
        
        protected override void Delete()
        {
            try
            {
                if (GlobalCommon.AcceptDelete())
                {
                    DIC_CanBo.DeleteDIC_CanBo(IDCanBo);
                    this.Close();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        #endregion

        #region Hàm bổ sung
        // Load tỉnh thành, huyện, Xã 
        DIC_Tinh checkTinh, checkCha;
        DIC_TinhChild_Coll checkCon;
        private void LoadTinhThanh()
        {
            //checkTinh = DIC_Tinh.GetDIC_Tinh(canbo.IDTinh);
            checkCon = DIC_TinhChild_Coll.GetDIC_TinhChild_Coll(checkTinh.ID);
            checkCha = DIC_Tinh.GetDIC_Tinh(Convert.ToInt64(checkTinh.IDRefer));
            if (checkCha.IDRefer == 0 && (DIC_Tinh.GetDIC_Tinh(Convert.ToInt64(checkCha.IDRefer))) != null)
            {
                bindHuyen.DataSource = checkTinh;
                bindTinhThanh.DataSource = checkCha;
                radXa.SelectedValue = null;
            }
            else if (checkCha == null)
            {
                bindTinhThanh.DataSource = checkTinh;
                radHuyen.SelectedValue = null;
                radXa.SelectedValue = null;
            }
            else if (checkCha.IDRefer != 0 && checkCon.Count == 0)
            {
                bindXa.DataSource = checkTinh;
                bindHuyen.DataSource = checkCha;
                bindTinhThanh.DataSource = DIC_Tinh.GetDIC_Tinh(Convert.ToInt64(checkCha.IDRefer));
            }
        }
        #endregion

        #region Event
        private void radTxtTenCanBo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Họ tên phải là kí tự chữ ", "Thông Báo ");
            }
        }  
        private void radTinhThanh_Click(object sender, EventArgs e)
        {
            
            this.bindTinhThanh.DataSource = DIC_TinhChild_Coll.GetDIC_TinhChild_Coll();
            radXa.SelectedValue = null;
            radHuyen.SelectedValue = null;  

        }

        private void radHuyen_Click(object sender, EventArgs e)
        {
            radXa.SelectedValue = null;
            IDTinh = Convert.ToInt64(radTinhThanh.SelectedValue);
            if (IDTinh != 0)
            {
                bindHuyen.DataSource = DIC_TinhChild_Coll.GetDIC_TinhChild_Coll(IDTinh);
                radHuyen.SelectedValue = null;
            }
            IDTinh = 0;
            
        }

        private void radXa_Click(object sender, EventArgs e)
        {
            if (bindHuyen.DataSource == null)
            {
                radXa.SelectedValue = null; 
            }
            else
            {
                IDHuyen = Convert.ToInt64(radHuyen.SelectedValue);
                if (IDHuyen != 0)
                {
                    bindXa.DataSource = DIC_TinhChild_Coll.GetDIC_TinhChild_Coll(IDHuyen);
                    radXa.SelectedValue = null;
                }

            }
        }


        #endregion

    }
}
