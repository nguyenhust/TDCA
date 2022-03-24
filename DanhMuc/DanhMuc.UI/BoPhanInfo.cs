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

namespace DanhMuc.UI
{
    public partial class BoPhanInfo : NETLINK.UI.Dictionary
    {
        #region variables

        private DIC_BoPhan item;
        private int itemID = -1;
        

        #endregion
        public BoPhanInfo(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            if (_formMode.IsInsert) // thêm mới
            {
                itemID = 0;
            }
            else
            {
                itemID = _formMode.Id;
            }
            bindingSourceBoPhan.DataSource = item;
        }

        #region overrides

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("GoiKyThuat:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == TextMessages.RolePermission.SystemAdmin
            || Csla.ApplicationContext.User.IsInRole("GoiKyThuat:U"));
        }

        protected override void FormLoad()
        {
            base.FormLoad();
        }

        protected override void Save()
        {
            base.Save();
        }


        #endregion
    }
}
