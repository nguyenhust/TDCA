using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;
using NETLINK.UI;
using TruyenThong.LIB;

namespace TruyenThong.UserControl
{
    public partial class AnhVideo : UsDictionary
    {
        Int64 _ID = 0;
        Int64 IDAnhVideo;

        public AnhVideo()
        {
            InitializeComponent();
            RadGrid = radgAnhVideo;
            STT();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            SaveToNew();
            PrintToShow();
        }

        #region Override

        public override object GetIdValue()
        {
            return "AnhVideo";
        }

        public override string ToString()
        {
            return "Quản lý Ảnh và video";
        }

        protected override void ApplyAuthorizationRules()
        {
            // nếu có được quyền tối thiểu thì cho phép vào form
            bl_btnSave = (Csla.ApplicationContext.User.IsInRole("AnhVideo:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnPrint = (Csla.ApplicationContext.User.IsInRole("AnhVideo:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
            bl_btnMyClose = true;
            bl_btnDelete = (Csla.ApplicationContext.User.IsInRole("AnhVideo:S")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }

        protected override void Save()
        {
            UI.AnhVideo frm = new UI.AnhVideo();
            frm.ShowDialog();
            LoadUS();
        }

        protected override void LoadUS()
        {
            try
            {
                bindAnhVideo.DataSource = TT_AnhVideo_Coll.GetTT_AnhVideo_Coll();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Print()
        {
            try
            {
                bindAnhVideo.DataSource = TT_AnhVideo_Coll.GetTT_AnhVideo_Coll();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Delete()
        {
            try
            {
                radgAnhVideo.DataSource = bindAnhVideo;
                if (radgAnhVideo.CurrentRow.Cells["ID"].Value != null)
                    IDAnhVideo = Convert.ToInt64(radgAnhVideo.CurrentRow.Cells["ID"].Value);
                if (GlobalCommon.AcceptDelete())
                {
                    TT_AnhVideo.DeleteTT_AnhVideo(IDAnhVideo);
                    LoadUS();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }
        protected override void MyClose()
        {
            base.MyClose();
        }

        #endregion

        private void CellDoubleClick_AnhVideo(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (radgAnhVideo.CurrentRow.Cells["ID"].Value != null)
                    _ID = Convert.ToInt64(radgAnhVideo.CurrentRow.Cells["ID"].Value);
                UI.AnhVideo frm = new UI.AnhVideo(_ID);
                frm.ShowDialog();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            radG_CellFormat(sender, e);
        }
    }
}
