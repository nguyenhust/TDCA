using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;
using NETLINK.UI;
using Authoration.LIB;
using Telerik.WinControls.UI;

namespace Authoration.UI
{
    public partial class NhomNguoiDung : ParentChild
    {
        ADM_NhomNguoiDung nhomnguoidung;
        ADM_QuyenNhomNguoiDung_Coll quyennhom_coll;
        ADM_ChucNang_Coll chucnang_coll = ADM_ChucNang_Coll.GetADM_ChucNang_Coll();
        RadGridView dt;
        Int64 IDNND;

        public NhomNguoiDung()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            RadGrid = radgChucNang;
            STT();
            RadGridChild = radgNhomNguoiDung;
            STTChild();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            dt = new RadGridView();
            dt.DataSource = chucnang_coll;
            AddComboxToGrid(dt,"TenCN","IDCN","IDChucNang","Combo_ChucNang","Chức năng",300,1);
        }
        public NhomNguoiDung(Int64 _ID)
        {
            InitializeComponent();
            IDNND = _ID;
            ApplyAuthorizationRules();
            RadGrid = radgChucNang;
            STT();
            RadGridChild = radgNhomNguoiDung;
            STTChild();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            dt = new RadGridView();
            dt.DataSource = chucnang_coll;
            AddComboxToGrid(dt, "TenCN", "IDCN", "IDChucNang", "Combo_ChucNang", "Chức năng", 300, 1);
            nhomnguoidung = ADM_NhomNguoiDung.GetADM_NhomNguoiDung(_ID);
            bindNhom.DataSource = nhomnguoidung;
        }
        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("NhomNguoiDung:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"
            || Csla.ApplicationContext.User.IsInRole("NhomNguoiDung:U"));
            this.btnDelete.Enabled = (Csla.ApplicationContext.User.IsInRole("NhomNguoiDung:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            //this.btnNew.Enabled = (Csla.ApplicationContext.User.IsInRole("NhomNguoiDung:I")
            //|| Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }


        //protected override void New()
        //{
        //    try
        //    {
        //        nhomnguoidung = ADM_NhomNguoiDung.NewADM_NhomNguoiDung();
        //        quyennhom_coll = ADM_QuyenNhomNguoiDung_Coll.NewADM_QuyenNhomNguoiDung_Coll();
        //        this.bindNhom.DataSource = nhomnguoidung;
        //        this.bindChucNang.DataSource = quyennhom_coll;
        //        radgChucNang.DataSource = quyennhom_coll;
        //    }
        //    catch (Exception ex)
        //    {
        //        GlobalCommon.ShowErrorMessager(ex);
        //    }
        //}

        protected override void Save()
        {
            try
            {
                nhomnguoidung.QuyeNhomNguoiDung = quyennhom_coll;
                nhomnguoidung.ApplyEdit();
                nhomnguoidung.Save();
                this.bindNhomList.DataSource = ADM_NhomNguoiDung_Coll.GetADM_NhomNguoiDung_Coll();
                GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Other, "Form Nhóm Người dùng");
                MessageBox.Show("Lưu Thành Công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
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
                ADM_NhomNguoiDung.DeleteADM_NhomNguoiDung(nhomnguoidung.ID);
                this.bindNhomList.DataSource = ADM_NhomNguoiDung_Coll.GetADM_NhomNguoiDung_Coll();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Cancel()
        {
            this.Close();
        }

        protected override void FormLoad()
        {
            try
            {
                if(IDNND !=0)
                {
                    nhomnguoidung = ADM_NhomNguoiDung.GetADM_NhomNguoiDung(IDNND);
                    bindNhom.DataSource = nhomnguoidung;
                    bindNhomList.DataSource = ADM_NhomNguoiDung_Coll.GetADM_NhomNguoiDung_Coll();
                    quyennhom_coll = ADM_NhomNguoiDung.GetADM_NhomNguoiDung(IDNND).QuyenNhomNguoiDung;
                    radgChucNang.DataSource = quyennhom_coll;
                }
                else
                {
                nhomnguoidung = ADM_NhomNguoiDung.NewADM_NhomNguoiDung();
                quyennhom_coll = ADM_QuyenNhomNguoiDung_Coll.NewADM_QuyenNhomNguoiDung_Coll();
                this.bindNhom.DataSource = nhomnguoidung;
                this.bindChucNang.DataSource = quyennhom_coll;
                radgChucNang.DataSource = quyennhom_coll;
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
            bindNhomList.DataSource = ADM_NhomNguoiDung_Coll.GetADM_NhomNguoiDung_Coll();
        }

        #endregion 

        //private void CellClick_radgNhomNguoiDung(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (radgNhomNguoiDung.CurrentRow.Cells["ID"].Value != null)
        //        {
        //            quyennhom_coll = ADM_NhomNguoiDung.GetADM_NhomNguoiDung(Convert.ToInt32(radgNhomNguoiDung.CurrentRow.Cells["ID"].Value)).QuyeNhomNguoiDung;
        //            this.radgChucNang.DataSource = quyennhom_coll;
        //            nhomnguoidung = ADM_NhomNguoiDung.GetADM_NhomNguoiDung(Convert.ToInt32(radgNhomNguoiDung.CurrentRow.Cells["ID"].Value));
        //            this.bindNhom.DataSource = nhomnguoidung;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        GlobalCommon.ShowErrorMessager(ex);
        //    }
        //}

        private void CellFormattingParent(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }

        private void CellFormattingChild(object sender, CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
    }
}
