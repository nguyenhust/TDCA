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
using ModuleHanhChinh.LIB;

namespace ModuleHanhChinh.UI
{
    public partial class Form_ThietBiTLS_ChoMuon : NETLINK.UI.Dictionary
    {
        #region variables

        
        private int itemId = -1;
        private HC_ThietBiTienLamSang_ChoMuon item;
        
        #endregion


        public Form_ThietBiTLS_ChoMuon(FormMode _formMode)
        {
            InitializeComponent();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                itemId = 0;
                item = HC_ThietBiTienLamSang_ChoMuon.NewHC_ThietBiTienLamSang_ChoMuon();
            }
            else
            {
                itemId = _formMode.Id;
                item = HC_ThietBiTienLamSang_ChoMuon.GetHC_ThietBiTienLamSang_ChoMuon(_formMode.Id);
            }
            bindingSourceMain.DataSource = item;
        }

        #region overrides

        protected override void FormLoad()
        {
            try
            {
                if (itemId > 0)
                {
                    //if (item.TrongVien == true)
                    //    radCheckBox1.Checked = true;
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            //item.TenThietBi = radTextBox1.Text;
            //item.NguoiMuon = radTextBox2.Text;
        }

        
        #endregion
    }
}
