using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using NETLINK.LIB;
using ModuleChiDaoTuyen.LIB;

namespace ModuleChiDaoTuyen.UserControl
{
    public partial class CBNhanCGKT : System.Windows.Forms.UserControl
    {
        #region Global Variables

        private int _idHopDong;
        private CDT_CanBoNhanCGKT _canBoNhanCGKT;

        #endregion

        public CBNhanCGKT()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        #region Mode Setting

        public void SetNewMode(int idHopDong)
        {
            _idHopDong = idHopDong;
            _canBoNhanCGKT = CDT_CanBoNhanCGKT.NewCDT_CanBoNhanCGKT();
        }

        public void SetEditMode(int idHopDong)
        {
            _idHopDong = idHopDong;
        }

        #endregion

        #region Initialize ComboBoxes

        private void InitializeComboBoxes()
        {
            InitializeComboBoxChucVu();
            InitializeComboBoxChuyenNganh();
            InitializeComboBoxTrinhDo();
            InitializeComboBoxGoiKyThuat();
        }

        private void InitializeComboBoxChuyenNganh()
        {
            dropDownChuyenNganh1.FillData(1);
        }

        private void InitializeComboBoxChucVu()
        {
            dropDownChucVu1.FillData(1);
        }

        private void InitializeComboBoxTrinhDo()
        {
            dropDownTrinhDo1.FillData(1);
        }

        private void InitializeComboBoxGoiKyThuat()
        {
            //dropDownGoiKyThuat1.FillData(_idHopDong);
        }

        #endregion

        #region Events Handler

        private void btnInsertToList_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtDiemSauCG_TextChanged(object sender, EventArgs e)
        {
            int point;
            if (int.TryParse(txtDiemSauCG.Text, out point))
            {
                if (point >= 5)
                {
                    checkDat.IsChecked = true;
                    checkChuaDat.IsChecked = false;
                }
                else
                {
                    checkChuaDat.IsChecked = true;
                    checkDat.IsChecked = false;
                }
            }
        }

        #endregion

        #region Database Process

        private void SaveItem()
        {
            try
            {

            }
            catch (Exception ex)
            {
            }
        }

        #endregion



    }
}
