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
using Telerik.WinControls.UI;
using System.Data.SqlClient;
namespace DanhMuc.UI
{
    public partial class ChucvuInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_ChucVu item;
        

        #endregion

        public ChucvuInfo(FormMode _formMode)
        {
            InitializeComponent();// khoi tao form
            ApplyAuthorizationRules();// phan quyen tren fom
            this.formMode = _formMode;// gan vao bien he thong
        }

        #region overrides

        /// <summary>
        /// Kiem tra form xem neu nhu khong co quyen thi thong bao va dong form lai
        /// </summary>
        protected override void ApplyAuthorizationRules()
        {// Can sua permission tuong ung voi moi form, luu permission vao trong textmessages
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_ChucVu_Insert, TextMessages.RolePermission.DM_ChucVu_Edit }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                this.Close();
            }
            else
            {
                btnSave.Enabled = true;
            }

        }

        protected override void FormLoad()
        {
            try
            {
                if (formMode.IsInsert)
                {
                    item = DIC_ChucVu.NewDIC_ChucVu();// Can sua tuong ung voi moi form
                }
                else
                {
                    item = DIC_ChucVu.GetDIC_ChucVu(formMode.Id);// Can sua tuong ung voi moi form
                }
                bindingSourceChucVu.DataSource = item;
                item.SuDung = true; // cái này nên để bằng true ngay từ đầu vì như thế sẽ tiện hơn cho người dùng
                BindData(true);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        protected override void Save()
        {
            try
            {
                if (kiemtratontai())
                {
                    GlobalCommon.ShowError("Tên chức vụ đã tồn tại", "Thông báo");
                }
                else
                {
                    BindData(false);
                    item.ApplyEdit();
                    item.Save();
                    if (formMode.IsInsert)
                        GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.InsertSuccess);
                    else
                        GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    //GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, FormAction.Other, "Form Người dùng");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        #endregion

        /// <summary>
        /// Ham dung de bin data bang tay vao he thong
        /// Can phai sua tuong ung voi moi Form
        /// </summary>
        /// <param name="isLoad"></param>
        private void BindData(bool isLoad)
        {
            if (isLoad)
            {
                radGhiChu.Text = item.GhiChu;
                radSuDung.Checked = Convert.ToBoolean(item.SuDung);
            }
            else
            {
                item.GhiChu = radGhiChu.Text;
                item.SuDung = radSuDung.Checked;
            }
        }
        private bool kiemtratontai()
        {
            bool tatkt = false;
            string maso =radChucVu.Text ;
            SqlConnection con = new SqlConnection(DBConnection.Connection);
            SqlCommand cmd = new SqlCommand("Select Ten from DIC_ChucVu", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (maso == dr.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            con.Close();
            return tatkt;
        }  
    }
}
