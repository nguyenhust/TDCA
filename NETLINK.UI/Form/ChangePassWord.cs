using Csla.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.LIB;

namespace NETLINK.UI
{
    public partial class ChangePassWord : Dictionary
    {
        string strAcount = String.Empty;

        public ChangePassWord()
        {
            InitializeComponent();
            strAcount = Csla.ApplicationContext.User.Identity.Name;
        }

        protected override void Save()
        {
            try
            {
                using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
                {
                    using (var cmd = new SqlCommand("dbo.ADM_NguoiDung_ChangePass", ctx.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@OldPass", txtPassWordOld.Text);
                        cmd.Parameters.AddWithValue("@TenDangNhap", strAcount);
                        cmd.Parameters.AddWithValue("@NewPass", txtNewPass.Text);
                        cmd.Parameters.AddWithValue("@NewPassConfirm", txtNewPassConfirm.Text);
                        var args = new DataPortalHookArgs(cmd);
                        OnDeletePre(args);
                        cmd.ExecuteNonQuery();
                        OnDeletePost(args);
                    }
                }
                GlobalCommon.ShowError("Đổi mật khẩu thành công", "Bạn đã thực hiện thao tác đổi mật khẩu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void Click_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                Save();
        }

        #region Pseudo Events

        /// <summary>
        /// Occurs after setting all defaults for object creation.
        /// </summary>
        partial void OnCreate(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after setting query parameters and before the delete operation.
        /// </summary>
        partial void OnDeletePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after the delete operation, before Commit().
        /// </summary>
        partial void OnDeletePost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the update operation.
        /// </summary>
        partial void OnUpdatePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the update operation, before setting back row identifiers (RowVersion) and Commit().
        /// </summary>
        partial void OnUpdatePost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after setting query parameters and before the insert operation.
        /// </summary>
        partial void OnInsertPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the insert operation, before setting back row identifiers (ID and RowVersion) and Commit().
        /// </summary>
        partial void OnInsertPost(DataPortalHookArgs args);

        #endregion

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
