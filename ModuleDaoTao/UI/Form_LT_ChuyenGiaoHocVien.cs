using NETLINK.UI;
using NETLINK.LIB;
using DanhMuc.LIB;
using DanhMuc.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using ModuleDaoTao.LIB;

namespace ModuleDaoTao.UI
{
    public partial class Form_LT_ChuyenGiaoHocVien : NETLINK.UI.Dictionary
    {
        #region variables

        
        private int selectedID = -1;
        private DT_LienTuc_HocVien item;

        #endregion

        public Form_LT_ChuyenGiaoHocVien(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert)
            {
                selectedID = 0;
                item = DT_LienTuc_HocVien.NewDT_LienTuc_HocVien();
            }
            else
            {
                selectedID = _formMode.Id;
                item = DT_LienTuc_HocVien.GetDT_LienTuc_HocVien(selectedID);
            }
            
        }

        #region Override

        protected override void ApplyAuthorizationRules()
        {
            /*this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            btnContinue.Enabled = (Csla.ApplicationContext.User.IsInRole("HopDong:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            HopDong_Activated(this, EventArgs.Empty);*/
        }

        protected override void FormLoad()
        {
            try
            {
                // find dropdown list
                dropDownUserLeft.FillData();
                dropDownUserRight.FillData(dropDownUserLeft.GetListData().Clone());
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void radButtonLoadHocVienLeft_Click(object sender, EventArgs e)
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDownWithCondition);
            function.ItemID = System.Convert.ToInt32(dropDownUserLeft.Selected_ID);
            bindingSourceHocVienLeft.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
        }

        private void radButtonLoadHocVienRight_Click(object sender, EventArgs e)
        {
            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDownWithCondition);
            function.ItemID =  System.Convert.ToInt32(dropDownUserRight.Selected_ID);
            bindingSourceHocVienRight.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
        }

        private void btnLefttoRigtAll_Click(object sender, EventArgs e)
        {
            
            if (bindingSourceHocVienLeft.DataSource == null || radGridViewLeft.RowCount == 0)
                return;
            if (dropDownUserRight.Selected_ID == dropDownUserLeft.Selected_ID)
                return;
            DT_LienTuc_HocVien_Coll leftHocvien = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienLeft.DataSource;
            DT_LienTuc_HocVien_Coll rightHocvien = null;
            if (bindingSourceHocVienRight.DataSource == null || radGridViewRight.RowCount == 0)
            {
                bindingSourceHocVienRight.DataSource = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                
            }
            rightHocvien = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienRight.DataSource;

            DIC_CanBo rightPerson = DIC_CanBo.GetDIC_CanBo(System.Convert.ToInt32(dropDownUserRight.Selected_ID));

            foreach (DT_LienTuc_HocVien_Info hv in leftHocvien) {
                hv.IdNguoiQuanLy = System.Convert.ToInt32(dropDownUserRight.Selected_ID);
                if (rightPerson != null)
                    hv.IdBoPhan = rightPerson.IDBoPhan;
                rightHocvien.Add(hv);
            }
            leftHocvien = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
            bindingSourceHocVienLeft.DataSource = leftHocvien;
            rightHocvien.Save();
        }

        private void btnLefttoRightOne_Click(object sender, EventArgs e)
        {
            if (bindingSourceHocVienLeft.DataSource == null || radGridViewLeft.RowCount == 0)
                return;
            if (dropDownUserRight.Selected_ID == dropDownUserLeft.Selected_ID)
                return;

            if (radGridViewLeft.CurrentRow != null)
            {
                DT_LienTuc_HocVien_Info hocvienCanchuyengiao = (DT_LienTuc_HocVien_Info)radGridViewLeft.CurrentRow.DataBoundItem;
                if (hocvienCanchuyengiao != null) {
                    DT_LienTuc_HocVien_Coll leftHocvien = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienLeft.DataSource;
                    DT_LienTuc_HocVien_Coll rightHocvien = null;
                    if (bindingSourceHocVienRight.DataSource == null || radGridViewRight.RowCount == 0)
                    {
                        bindingSourceHocVienRight.DataSource = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();

                    }
                    rightHocvien = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienRight.DataSource;


                    DIC_CanBo rightPerson = DIC_CanBo.GetDIC_CanBo(System.Convert.ToInt32(dropDownUserRight.Selected_ID));
                    hocvienCanchuyengiao.IdNguoiQuanLy = System.Convert.ToInt32(dropDownUserRight.Selected_ID);
                    if (rightPerson != null)
                    {
                        hocvienCanchuyengiao.IdBoPhan = rightPerson.IDBoPhan;
                    }

                    DT_LienTuc_HocVien_Coll newLientuc = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                    foreach (DT_LienTuc_HocVien_Info hv in leftHocvien)
                    {
                        if (hv.IdNguoiQuanLy == (long?)dropDownUserLeft.Selected_ID)
                            newLientuc.Add(hv);
                    }
                    bindingSourceHocVienLeft.DataSource = newLientuc;

                    rightHocvien.Add(hocvienCanchuyengiao);
                    
                    rightHocvien.Save();   
                }
            }
        }

        private void btnRighttoLeftOne_Click(object sender, EventArgs e)
        {
            if (bindingSourceHocVienRight.DataSource == null || radGridViewRight.RowCount == 0)
                return;
            if (dropDownUserRight.Selected_ID == dropDownUserLeft.Selected_ID)
                return;
            if (radGridViewRight.CurrentRow != null)
            {
                DT_LienTuc_HocVien_Info hocvienCanchuyengiao = (DT_LienTuc_HocVien_Info)radGridViewRight.CurrentRow.DataBoundItem;
                if (hocvienCanchuyengiao != null)
                {
                    DT_LienTuc_HocVien_Coll rightHocvien = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienRight.DataSource;
                    DT_LienTuc_HocVien_Coll leftHocvien = null;
                    if (bindingSourceHocVienLeft.DataSource == null || radGridViewLeft.RowCount == 0)
                    {
                        bindingSourceHocVienLeft.DataSource = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();

                    }
                    leftHocvien = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienLeft.DataSource;
                    DIC_CanBo leftPerson = DIC_CanBo.GetDIC_CanBo(System.Convert.ToInt32(dropDownUserLeft.Selected_ID));
                    hocvienCanchuyengiao.IdNguoiQuanLy = System.Convert.ToInt32(dropDownUserLeft.Selected_ID);
                    if (leftPerson != null) {
                        hocvienCanchuyengiao.IdBoPhan = leftPerson.IDBoPhan;
                    }

                    DT_LienTuc_HocVien_Coll newLientuc = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
                    foreach (DT_LienTuc_HocVien_Info hv in rightHocvien)
                    {
                        if (hv.IdNguoiQuanLy == (long?)dropDownUserRight.Selected_ID)
                            newLientuc.Add(hv);
                    }
                    bindingSourceHocVienRight.DataSource = newLientuc;

                    leftHocvien.Add(hocvienCanchuyengiao);
                    leftHocvien.Save();
                }
            }
        }

        private void btnRighttoLeftAll_Click(object sender, EventArgs e)
        {
            if (bindingSourceHocVienRight.DataSource == null || radGridViewRight.RowCount == 0)
                return;
            if (dropDownUserRight.Selected_ID == dropDownUserLeft.Selected_ID)
                return;
            DT_LienTuc_HocVien_Coll rightHocvien = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienRight.DataSource;
            DT_LienTuc_HocVien_Coll leftHocvien = null;
            if (bindingSourceHocVienLeft.DataSource == null || radGridViewLeft.RowCount == 0)
            {
                bindingSourceHocVienLeft.DataSource = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();

            }
            leftHocvien = (DT_LienTuc_HocVien_Coll)bindingSourceHocVienLeft.DataSource;
            DIC_CanBo leftPerson = DIC_CanBo.GetDIC_CanBo(System.Convert.ToInt32(dropDownUserLeft.Selected_ID));
            foreach (DT_LienTuc_HocVien_Info hv in rightHocvien)
            {
                hv.IdNguoiQuanLy = System.Convert.ToInt32(dropDownUserLeft.Selected_ID);
                if (leftPerson != null) {
                    hv.IdBoPhan = leftPerson.IDBoPhan;
                }
                leftHocvien.Add(hv);
            }
            rightHocvien = DT_LienTuc_HocVien_Coll.NewDT_LienTuc_HocVien_Coll();
            bindingSourceHocVienRight.DataSource = rightHocvien;
            leftHocvien.Save();
        }
    }
}
