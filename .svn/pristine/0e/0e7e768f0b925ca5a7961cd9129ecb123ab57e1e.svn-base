using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using NETLINK.LIB;
using ModuleDaoTao.UI;
using ModuleDaoTao.LIB;
using Authoration.LIB;
using DanhMuc.LIB;

namespace ModuleDaoTao.UserControls
{
    public partial class GridHocVienLienTucHocPhiHoanTien : UsDictionary
    {
        #region variables
        
        private FormMode formMode = new FormMode();
        private int selectedID = -1;

        #endregion

        public GridHocVienLienTucHocPhiHoanTien()
        {
            InitializeComponent();
            RadGrid = radGridView1;
            STT();
            RadGrid.CellFormatting += radGridView_CellFormatting;
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
          
            SaveToNew();
            PrintToShow();
        }
        #region Override
        private void radGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
        public override object GetIdValue()
        {
            return TextMessages.ControlID.DT_HocVienLientTuc_HocPhi_HoanTien;
        }

        public override string ToString()
        {
            return TextMessages.FormTitle.DT_HocVienLienTuc_HocPhiHoanTien;
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Insert);
            //Nếu không sử dụng chức năng in thì Role sẽ check là View. còn nếu sử dụng thì role là Print
            bl_btnPrint = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Print);
            bl_btnMyClose = true;
            bl_btnDelete = GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Delete);
        }

        protected override void Save()
        {
            formMode.IsInsert = true;
            Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
            fr.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                bl_btnDelete = false;
                bl_btnPrint = false;
                bl_btnSave = false;
                if (!GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_View))
                {
                    bl_btnDelete = false;
                    bl_btnPrint = false;
                    bl_btnSave = false;
                    throw new Exception(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                }
                else
                {
                    BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForGridViewDaDongHP);
                    function.ItemID = (int)PTIdentity.IDNguoiDung;
                    bindingSourceHocVien.DataSource = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                }

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Print))
                    bl_btnPrint = true;

                if (GlobalCommon.IsHavePermission(TextMessages.RolePermission.DT_LT_TraCuuHocPhi_Delete))
                    bl_btnDelete = true;
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                DT_LienTuc_HocVien_Coll hocVienColl = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
                DIC_ChuyenNganh_Coll chuyenNganhColl = DIC_ChuyenNganh_Coll.GetDIC_ChuyenNganh_Coll();
                DIC_HocVi_Coll hocViColl = DIC_HocVi_Coll.GetDIC_HocVi_Coll();
                foreach (DT_LienTuc_HocVien_Info hocvien in hocVienColl)
                {
                    if (hocvien.Checked)
                    {
                        DIC_ChuyenNganh_Info chuyennganh = null;
                        foreach (DIC_ChuyenNganh_Info item in chuyenNganhColl)
                        {
                            if (hocvien.IdChuyenNganh == item.ID)
                            {
                                chuyennganh = item;
                                break;
                            }
                        }

                        DIC_HocVi_Info trinhDo = null;
                        foreach (DIC_HocVi_Info item in hocViColl)
                        {
                            if (hocvien.IdTrinhDo == item.ID)
                            {
                                trinhDo = item;
                                break;
                            }
                        }

                        DT_Common.PrintHocPhi(hocvien, chuyennganh, trinhDo);
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }

        }

        protected override void Delete()
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID) && GlobalCommon.AcceptDelete())
                {
                    DT_LienTuc_HocVien.DeleteDT_LienTuc_HocVien(selectedID);
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void MyClose()
        {
            this.Close();
        }

        #endregion

        private void radGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(radGridView1.CurrentRow.Cells["Id"].Value.ToString(), out selectedID)
                    && GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DT_LT_TraCuuHocPhi_View, TextMessages.RolePermission.DT_NghienCuuKhoaHoc_Edit }))
                {
                    formMode.Id = selectedID;
                    formMode.IsEdit = true;
                    Form_LT_HocVienLienTuc fr = new Form_LT_HocVienLienTuc(formMode);
                    fr.ShowDialog();
                    LoadUS();
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radGridView1_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                // just save when HoaDonHocPhi
                if (e.Column.Name == "SoTienHoan" || e.Column.Name == "LyDoHoanTien")
                {
                    DT_LienTuc_HocVien_Info item = (DT_LienTuc_HocVien_Info)e.Row.DataBoundItem;
                    // just insert when already Lophoc is loaded
                    DT_LienTuc_HocVien_Coll hocVienColl = (DT_LienTuc_HocVien_Coll)bindingSourceHocVien.DataSource;
                    hocVienColl.Save();
                }
            }
            catch (Exception ex)
            {
                radGridView1.CancelEdit();
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
    }
}
