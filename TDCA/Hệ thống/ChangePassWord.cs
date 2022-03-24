using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace TDCA
{
    public partial class ChangePassWord : NETLINK.UI.ChangePassWord
    {
        public ChangePassWord()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
        }

        #region Override

        protected override void ApplyAuthorizationRules()
        {
           // this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("ChangPass:I")
           //|| Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            btnSave.Enabled = true;
        }

        #endregion

    }
}
