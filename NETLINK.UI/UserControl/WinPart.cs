using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NETLINK.UI
{
    public partial class WinPart : UserControl
    {
        public WinPart()
        {
            InitializeComponent();
        }

        public virtual object GetIdValue()
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            if (this.DesignMode)
                return base.Equals(obj);
            else
            {
                object id = GetIdValue();
                if (this.GetType().Equals(obj.GetType()) && id != null)
                    return ((WinPart)obj).GetIdValue().Equals(id);
                else
                    return false;
            }
        }

        public override int GetHashCode()
        {
            object id = GetIdValue();
            if (id != null)
                return GetIdValue().GetHashCode();
            else
                return base.GetHashCode();
        }

        public override string ToString()
        {
            object id = GetIdValue();
            if (id != null)
                return id.ToString();
            else
                return base.ToString();
        }

        public virtual void SetTitle(string text)
        {
        }

        #region CloseWinPart

        public event EventHandler CloseWinPart;

        protected void Close()
        {
            if (CloseWinPart != null)
                CloseWinPart(this, EventArgs.Empty);
        }

        #endregion

        #region CurrentPrincipalChanged

        public event EventHandler CurrentPrincipalChanged;

        public void OnCurrentPrincipalChanged(
          object sender, EventArgs e)
        {
            if (CurrentPrincipalChanged != null)
                CurrentPrincipalChanged(sender, e);
        }

        #endregion
        
    }
}
