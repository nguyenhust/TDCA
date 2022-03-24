using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using DanhMuc.LIB;
using Telerik.WinControls.Data;
using ModuleChiDaoTuyen.LIB;

namespace ModuleChiDaoTuyen.UI
{
    public partial class CBNhanCGKT : Telerik.WinControls.UI.RadForm
    {
        #region Variables

        private int _idHopDong;

        #endregion

        public CBNhanCGKT(int idHopDong)
        {
            InitializeComponent();
            _idHopDong = idHopDong;
        }

    }
}
