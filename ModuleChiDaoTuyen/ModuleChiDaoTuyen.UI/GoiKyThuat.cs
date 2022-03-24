using NETLINK.LIB;
using ModuleChiDaoTuyen.LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI;
using Authoration.LIB;

namespace ModuleChiDaoTuyen.UI
{
    public partial class GoiKyThuat : Dictionary
    {
        private FormMode mode;
        private CDT_GoiKT goiKT;
        public GoiKyThuat(FormMode formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            mode = formMode;
            this.formMode = formMode;
        }

        #region Business Logic

        private void radRaPhu_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radRaPhu.IsChecked)
            {
                radLbChongoiKT.Visible = true;
                dropDownGoiKyThuat.Visible = true;
            }
            else
            {
                radLbChongoiKT.Visible = false;
                dropDownGoiKyThuat.Visible = false;
            }
        }

        private void BindingDataControl_Load()
        {
            radtxtChitieudanhgia.Text = goiKT.ChiTieuDanhGia;
            radtxtGhiChu.Text = goiKT.GhiChu;
            radtxtHocTapBS.Text = goiKT.TaiLieuHocTap_BS;
            radtxtHocTapDD.Text = goiKT.TaiLieuHocTap_DD;
            radtxtHocTapKhac.Text = goiKT.TaiLieuHocTap_Khac;
            radtxtMoTagoiKT.Text = goiKT.MoTaKyThuatChuyenGiao;
            radtxtMTkienthuc.Text = goiKT.MucTieuKienThuc;
            radtxtMTkynang.Text = goiKT.MucTieuKyNang;
            radtxtMTthaido.Text = goiKT.MucTieuThaiDo;
            radtxtNoidungchuyengiao.Text = goiKT.NoiDungChuyenGiao;
            radtxtTieuchuanapdung.Text = goiKT.TieuChuanGoiKT;
            int result;
            if (int.TryParse(goiKT.IdGoiKT_Parent.ToString(), out result))
            {
                if (result <= 0)
                {
                    radRaChinh.IsChecked = true;
                }
                else
                {
                    radRaPhu.IsChecked = true;
                }
            }
        }
        private void BindingDataControl_Save()
        {
            goiKT.GhiChu = radtxtGhiChu.Text;
            goiKT.ChiTieuDanhGia = radtxtChitieudanhgia.Text;
            goiKT.MoTaKyThuatChuyenGiao = radtxtMoTagoiKT.Text;
            goiKT.MucTieuKienThuc = radtxtMTkienthuc.Text;
            goiKT.MucTieuKyNang = radtxtMTkynang.Text;
            goiKT.MucTieuThaiDo = radtxtMTthaido.Text;
            goiKT.NoiDungChuyenGiao = radtxtNoidungchuyengiao.Text;
            goiKT.TieuChuanGoiKT = radtxtTieuchuanapdung.Text;
            goiKT.TaiLieuHocTap_BS = radtxtHocTapBS.Text;
            goiKT.TaiLieuHocTap_DD = radtxtHocTapDD.Text;
            goiKT.TaiLieuHocTap_Khac = radtxtHocTapKhac.Text;
            if (radRaChinh.IsChecked)
                goiKT.IdGoiKT_Parent = null;
            else
            {
                goiKT.IdGoiKT_Parent = Convert.ToInt32(dropDownGoiKyThuat.Selected_ID);
            }
        }


        #endregion

        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.CDT_GoiKyThuat_Edit, TextMessages.RolePermission.CDT_GoiKyThuat_Insert });
        }

        protected override void FormLoad()
        {
            try
            {
               // dropDownGoiKyThuat.FillData();
                if (mode.IsInsert)
                {
                    goiKT = CDT_GoiKT.NewCDT_GoiKT();
                    radBindingSource.DataSource = goiKT;
                }
                else
                {
                    goiKT = CDT_GoiKT.GetCDT_GoiKT(mode.Id);
                    radBindingSource.DataSource = goiKT;
                    BindingDataControl_Load();
                }

            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                try
                {
                    BindingDataControl_Save();
                    goiKT.ApplyEdit();
                    goiKT.Save();
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Form Gói Kỹ Thuật");
                    this.Close();
                }
                catch (Exception ex)
                {
                    GlobalCommon.ShowErrorMessager(ex);
                }


            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion

        private void GoiKyThuat_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
