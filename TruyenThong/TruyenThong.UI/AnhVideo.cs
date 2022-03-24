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
using TruyenThong.LIB;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using DanhMuc.LIB;
using Authoration.LIB;

namespace TruyenThong.UI
{
    public partial class AnhVideo : Dictionary
    {
        long IDAnhVideo = 0;
        TT_AnhVideo anhvideo;

        public AnhVideo()
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            anhvideo = TT_AnhVideo.NewTT_AnhVideo();
            bindAnhVideo.DataSource = anhvideo;

            #region tao ra du lieu combox Sự kiện
            // find
            this.radcomboSuKien.AutoFilter = true;
            // open with
            this.radcomboSuKien.BestFitColumns(true, true);
            // open height
            this.radcomboSuKien.AutoSizeDropDownToBestFit = true;
            // display on dropdwownlist
            this.radcomboSuKien.DisplayMember = "Ten";
            // creat gridview show with click dropdownlist
            SetUpGridCombSuKien();
            // find by displaymember
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.radcomboSuKien.DisplayMember;
            // find type  contains
            filter.Operator = FilterOperator.Contains;
            this.radcomboSuKien.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            #endregion
            

        }

        public AnhVideo(long _ID)
        {
            IDAnhVideo = _ID;
            InitializeComponent();
            ApplyAuthorizationRules();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            anhvideo = TT_AnhVideo.GetTT_AnhVideo(IDAnhVideo);
            bindAnhVideo.DataSource = anhvideo;

            #region tao ra du lieu combox Sự kiện
            // find
            this.radcomboSuKien.AutoFilter = true;
            // open with
            this.radcomboSuKien.BestFitColumns(true, true);
            // open height
            this.radcomboSuKien.AutoSizeDropDownToBestFit = true;
            // display on dropdwownlist
            this.radcomboSuKien.DisplayMember = "Ten";
            // creat gridview show with click dropdownlist
            SetUpGridCombSuKien();
            // find by displaymember
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.radcomboSuKien.DisplayMember;
            // find type  contains
            filter.Operator = FilterOperator.Contains;
            this.radcomboSuKien.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            #endregion

            #region tao ra du lieu combox cán bộ
            #endregion
        }


        #region setup combox

        private void SetUpGridCombSuKien()
        {
            RadGridView gridViewControl = this.radcomboSuKien.EditorControl;
            radcomboSuKien.EditorControl.DataSource = TT_SuKien_Coll.GetTT_SuKien_Coll();
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            gridViewControl.Columns["ID"].IsVisible = false;
            gridViewControl.Columns["IDChuyenNganh"].IsVisible = false;
            gridViewControl.Columns["Ten"].HeaderText = "Loại";
            gridViewControl.Columns["DiaDiem"].IsVisible = false;
            gridViewControl.Columns["ThoiGian"].IsVisible = false;
            gridViewControl.Columns["IDLoai"].IsVisible = false;
            gridViewControl.Columns["ChuTri"].IsVisible = false;
            gridViewControl.Columns["GhiChu"].IsVisible = false;
            gridViewControl.Columns["TenChuyenNganh"].IsVisible = false;
            gridViewControl.Columns["TenLoai"].IsVisible = false;
        }


        #endregion

        #region Override

        protected override void ApplyAuthorizationRules()
        {
            this.btnSave.Enabled = (Csla.ApplicationContext.User.IsInRole("AnhVideo:I")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN"
            || Csla.ApplicationContext.User.IsInRole("AnhVideo:U"));
            btnDelete.Enabled = (Csla.ApplicationContext.User.IsInRole("AnhVideo:D")
            || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN");
        }

        protected override void FormLoad()
        {
            try
            {
                dropDownCanBo1.FillData(1);
                if (IDAnhVideo != 0)
                {
                    anhvideo = TT_AnhVideo.GetTT_AnhVideo(IDAnhVideo);
                    radbrowDuongDan.Value = anhvideo.DuongDan;
                    if (anhvideo.Loai == true)
                        radrdAnh.IsChecked = true;
                    else
                        radrdVideo.IsChecked = true;
                    dropDownCanBo1.Selected_ID = anhvideo.IDCanBo;
                    bindAnhVideo.DataSource = anhvideo;
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        protected override void Save()
        {
            try
            {
                UploadFile();
                if (radrdAnh.IsChecked == true)
                    anhvideo.Loai = true;
                else
                    anhvideo.Loai = false;
                anhvideo.IDCanBo = Convert.ToInt64(dropDownCanBo1.Selected_ID);
                anhvideo.IDSuKien = Convert.ToInt64(radcomboSuKien.SelectedValue);
                anhvideo.DuongDan = fileUploaded;
                anhvideo.ApplyEdit();
                anhvideo.Save();
                GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "CDT - Hop Dong CGKT - Giang Vien" + this.Text);
                this.Close();
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        #endregion
        private string fileUploaded;
        private void UploadFile()
        {
            if (radbrowDuongDan.Value != null && !string.IsNullOrEmpty(radbrowDuongDan.Value.ToString()))
            {
                FtpUltilies ftp = new FtpUltilies();
                ftp.UploadLargeFile(radbrowDuongDan.Value, true, out fileUploaded);
            }
        }
        private void Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (anhvideo != null && anhvideo.DuongDan != null && !string.IsNullOrEmpty(anhvideo.DuongDan))
                {
                    FtpUltilies ftp = new FtpUltilies();
                    ftp.SaveDownloadedFile(anhvideo.DuongDan);
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalCommon.AcceptDelete())
                {
                    TT_AnhVideo.DeleteTT_AnhVideo(IDAnhVideo);
                    this.Close();
                }
            }
            catch (Exception ex)
            { GlobalCommon.ShowErrorMessager(ex); }
        }

    }
}
