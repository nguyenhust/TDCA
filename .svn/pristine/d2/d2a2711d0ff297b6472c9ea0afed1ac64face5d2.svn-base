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
using ModuleHanhChinh.LIB;
using Authoration.LIB;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace ModuleHanhChinh.UI
{
    public partial class Form_CongVan_Di : NETLINK.UI.Dictionary
    {
        
        private HC_CongVanDi item;
        private HC_PhieuGiaoViec ItemPGV;
        private string fileUploaded;
        private bool GridAvaiable = false;
        private Thread thread;
        public Form_CongVan_Di(FormMode _formMode)
        {
            InitializeComponent();
            ApplyAuthorizationRules();
            this.formMode = _formMode;
            this.btnSave.CausesValidation = false;
            txtDateCV.MyName = "Ngày Ban Hành";
            txtDateNgayGui.MyName = "Ngày gửi";
        }
        
        protected override void ApplyAuthorizationRules()
        {
            try
            {
                btnSave.Enabled = GlobalCommon.IsHavePermission(new[] { TextMessages.RolePermission.HC_CongVanDen_Insert, TextMessages.RolePermission.HC_CongVanDen_Edit });
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
                this.Close();
            }
        }
        protected override void Save()
        {
            try
            {
                if (ValidateDataBeforeSave() && UploadFile() )
                {
                    if (txtGmail.Text != "" && txtPass.Text != "" && txtMailNhan.Text != "")
                    {
                        SendEmail();
                    }                   
                    BindData(false);
                    item.ApplyEdit();
                    item = item.Save();
                    SaveListItem();
                    //#region test

                    //if (formMode.IsInsert)
                    //{
                    //    HC_PhieuGiaoViec pgv = HC_PhieuGiaoViec.NewHC_PhieuGiaoViec();
                    //    pgv.BatDauTuNgay = DateTime.Now.ToShortDateString();
                    //    pgv.IdNguoiDuocGiao = PTIdentity.IDNguoiDung;
                    //    pgv.IdNguoiGiaoViec = PTIdentity.IDNguoiDung;
                    //    pgv.NoiDungCongViec = "Xử lý công văn: " + item.SoCongVan + "| Ký ngày: " + item.NgayKi + "| Theo phương hướng: " + item.HuongGiaiQuyet;
                    //    pgv.NgayGiao = DateTime.Now.ToShortDateString();
                    //    pgv.BatDauTuNgay = DateTime.Now.ToShortDateString();
                    //    pgv.PhaiXongNgay = DateTime.Now.ToShortDateString();
                    //    pgv.ApplyEdit();
                    //    pgv.Save();
                    //}


                    //#endregion
                    GlobalCommon.Log.WriteLog(PTIdentity.IDNguoiDung, PTIdentity.FullName, formMode, "Công văn đến số " + item.SoCongVan);
                    GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        protected override void FormLoad()
        {
            try
            {
                radDropGuiTu.DataSource = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();
                FillDataForDropDownBox();
                if (formMode.IsEdit && formMode.Id > 0)
                {
                    item = HC_CongVanDi.GetHC_CongVanDi(formMode.Id);
                    //listItem = HC_CongVanDi_NoiNhan_Coll.GetHC_CongVanDi_NoiNhan_Coll(new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition,formMode.Id));
                    
                }
                else
                {
                    item = HC_CongVanDi.NewHC_CongVanDi();
                    //listItem = HC_CongVanDi_NoiNhan_Coll.NewHC_CongVanDi_NoiNhan_Coll();
                    item.LuuTruTai = "Văn Phòng Trung Tâm";
                    item.NguoiGui = "";
                }
                
                radBindingSource.DataSource = item;
                BindData(true);
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }
        private void BindData(bool isLoad)
        {
            if (item != null)
            {
                if (isLoad)
                {
                    
                    radtxtHuongGiaiQuyet.Text = item.HuongGiaiQuyet;
                    txtNoiDung.Text = item.NoiDung;
                    txtVeVanDe.Text = item.VeVanDe;
                    //if (GlobalCommon.CheckDate(item.NgayGui))
                    txtDateNgayGui.Value_String = item.NgayGui;
                    // if (GlobalCommon.CheckDate(item.NgayKi))
                    txtDateCV.Value_String = item.NgayKi;
                    radBrowseEditor1.Value = item.LinkFile;
                    if (formMode.IsEdit)
                    {
                        radLabel14.Text = GlobalCommon.GenLastEditString(item.LastEdited_UserName, item.LastEdited_Date.ToString(TextMessages.Config.DateAndTimeFormat));
                        radButton1.Enabled = true;
                        //Đoạn này dùng Thread để chương trình chính ko bị treo khi thao tác - QuangBH
                        if (!string.IsNullOrEmpty(item.ListIDCanBoDuocGiao))
                        {
                            try
                            {
                                thread = new Thread(new ThreadStart(LoadItemPGV));
                                thread.Start();
                                thread.Join();
                            }
                            catch
                            {
                            }
                        }
                    }
                    else
                    {
                        radLabel14.Text = string.Empty;
                        radButton1.Enabled = false;
                    }
                    //gridViewCanBoTDC1.Selected_ListItem_ID = item.ListIDCanBoDuocGiao;
                    GridAvaiable = true;
                }
                else
                {
                    item.HuongGiaiQuyet = radtxtHuongGiaiQuyet.Text;
                    item.NoiDung = txtNoiDung.Text;
                    item.VeVanDe = txtVeVanDe.Text;
                    item.NgayGui = txtDateNgayGui.Value_String;
                    item.NgayKi = txtDateCV.Value_String;
                    item.IdUserGui = PTIdentity.IDNguoiDung;
                    item.LinkFile = fileUploaded;
                    item.LastEdited_UserID = PTIdentity.IDNguoiDung;
                    item.LastEdited_Date = DateTime.Now;
                    //item.ListIDCanBoDuocGiao = gridViewCanBoTDC1.Selected_ListItem_ID;
                    //item.ListIDUserDuocGiao = gridViewCanBoTDC1.Selected_ListItem_IDUser;
                    //item.ListHoTenCanBoDuocGiao = gridViewCanBoTDC1.Selected_ListItem_Name;
                }
            }
        }

        private void radTextBox4_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.Controls)
                {
                    control.Focus();
                    if (Validate())
                    {
                        DialogResult = System.Windows.Forms.DialogResult.None;
                        return;
                    }
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void radLabel14_Click(object sender, EventArgs e)
        {

        }

        //private void radInsert_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        object obj = dropDownBoPhan1.Selected_ID;
        //        if (obj != null)
        //        {
        //            int id = Convert.ToInt32(obj);
        //            bool exist = false;
        //            foreach (HC_CongVanDi_NoiNhan_Info noinhan in listItem)
        //            {
        //                if (noinhan.IdBoPhan == id)
        //                {
        //                    exist = true;
        //                    break;
        //                }
        //            }
        //            if (!exist)
        //            {
        //                HC_CongVanDi_NoiNhan_Info itemInfo = listItem.AddNew();
        //                itemInfo.IdBoPhan = id;
        //                itemInfo.TenBoPhan = dropDownBoPhan1.Selected_TextValue.ToString();
        //            }
        //        }
               
        //    }
        //    catch (Exception ex)
        //    {
        //        GlobalCommon.ShowErrorMessager(ex);
        //    }
        //}

        private void SaveListItem()
        {
            try
            {
                if (thread != null && thread.IsAlive)
                {
                    thread.Abort();
                    thread.Join();
                }
                //if (!gridViewCanBoTDC1.IsNull)
                //{
                //    if (formMode.IsInsert || ItemPGV == null)
                //        ItemPGV = HC_PhieuGiaoViec.NewHC_PhieuGiaoViec();
                //    ItemPGV.NoiDungCongViec = string.Format("Xử lý công văn số '{0}' - Ban hành ngày {1}\nVề vấn đề :\n {2}", item.SoCongVan, item.NgayKi, item.VeVanDe);
                //    ItemPGV.NgayGiao = DateTime.Now.ToShortDateString();
                //    ItemPGV.BatDauTuNgay = DateTime.Now.ToShortDateString();
                //    ItemPGV.PhaiXongNgay = DateTime.Now.ToShortDateString();
                //    ItemPGV.ListHoTenCanBoDuocGiao = item.ListHoTenCanBoDuocGiao;
                //    ItemPGV.ListIDCanBoDuocGiao = item.ListIDCanBoDuocGiao;
                //    ItemPGV.ListIDUserDuocGiao = item.ListIDUserDuocGiao;
                //    ItemPGV.IdNguoiGiaoViec = PTIdentity.IDNguoiDung;
                //    ItemPGV.TrangThai = "Chưa bắt đầu";
                //    ItemPGV.GhiChu = "Mở phần công văn đến hoặc liên hệ với văn phòng để xem chi tiết nội dung";
                //    ItemPGV.Backup03 = item.ID.ToString();
                //    ItemPGV.ApplyEdit();
                //    ItemPGV.Save();
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private void radDel_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (radGridView1.CurrentRow.DataBoundItem != null && GlobalCommon.AcceptDelete())
        //        {
        //            listItem.Remove((HC_CongVanDi_NoiNhan_Info)radGridView1.CurrentRow.DataBoundItem);
        //        }
               
        //    }
        //    catch (Exception ex)
        //    {
        //        GlobalCommon.ShowErrorMessager(ex);
        //    }
        //}
        private void FillDataForDropDownBox()
        {
            dropDownCapQuanLy1.FillData();
            dropDownLoaiCongVan1.FillData();
            //gridViewCanBoTDC1.FillData(BusinessFunctionMode.GetDataForGridViewWithCondition2);
        }
        private bool ValidateDataBeforeSave()
        {
            if (!txtDateNgayGui.isDateTime && !txtDateNgayGui.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtDateNgayGui.Value_Error);
                return false;
            }
            if (!txtDateCV.isDateTime && !txtDateCV.isNull)
            {
                GlobalCommon.ShowErrorMessager(txtDateNgayGui.Value_Error);
                return false;
            }
            if (GlobalCommon.CheckArrayTextIsNull(new string[] {txtDateCV.Value_String, txtNoiDung.Text, txtSoCV.Text,  txtVeVanDe.Text, dropDownCapQuanLy1.Text, dropDownLoaiCongVan1.Text }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.UserChuaNhapDayDuThongTin);
                return false;
            }
            return true;
        }
        private bool UploadFile()
        {
            if (radBrowseEditor1.Value != null && !string.IsNullOrEmpty(radBrowseEditor1.Value.ToString()) && radBrowseEditor1.Value != item.LinkFile)
            {
                FtpUltilies ftp = new FtpUltilies();
                if (!ftp.UploadLargeFile(radBrowseEditor1.Value, true, out fileUploaded))
                {
                    GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.FileUploadLoi);
                    return false;
                }
            }
            return true;
        }

        private void Form_CongVan_Di_Load(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (formMode.IsEdit && !string.IsNullOrEmpty(item.LinkFile))
                {
                    FtpUltilies ftp = new FtpUltilies();
                    ftp.SaveDownloadedFile(item.LinkFile);
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        private void txtVeVanDe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNoiDung.Text))
                txtNoiDung.Text = txtVeVanDe.Text;
        }

        private void gridViewCanBoTDC1_ValueChanged(object sender, EventArgs e)
        {
            if (GridAvaiable)
            {
                GridAvaiable = false;
            }
        }
        private void LoadItemPGV()
        {

            BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataWithCondition);
            function.ItemID = item.ID;
            ItemPGV = HC_PhieuGiaoViec.GetHC_PhieuGiaoViec(function);


        }

        private void radLabel18_Click(object sender, EventArgs e)
        {

        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendEmail()
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.UseDefaultCredentials = false;
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential(txtGmail.Text.Trim(), txtPass.Text.Trim());

                MailMessage message = new MailMessage();
                message.From = new MailAddress(txtGmail.Text.Trim());
                message.To.Add(txtMailNhan.Text.Trim());
                message.Subject = txtVeVanDe.Text.Trim();
                message.Body = txtNoiDung.Text.Trim();



                //Nếu có nhập Cc
                if (txtCC.Text != "")
                {
                //Cắt chuỗi Cc bằng dấu ";"
                string[] cc = txtCC.Text.Split(';');

                    foreach (var _cc in cc)
                    {
                        message.CC.Add(_cc.ToString());
                    }
                }

                //Nếu có nhập Bcc
                if (txtBcc.Text != "")
                {
                //Cắt chuỗi Bcc bằng dấu ";"
                string[] bcc = txtBcc.Text.Split(';');

                    foreach (var _bcc in bcc)
                    {
                    message.Bcc.Add(_bcc.ToString());
                    }
                }

                ////Kiểm tra nếu có file trong listBox1
                //if (listBox1.Items.Count > 0)
                //{
                //    foreach (var filename in listBox1.Items)
                //    {
                //    //Kiểm tra file có tồn tại trong ổ đĩa không
                //        if (File.Exists(filename.ToString()))
                //         {
                //    //Thêm file đính kèm vào tin nhắn
                //            message.Attachments.Add(new Attachment(filename.ToString()));
                //         }
                //    }
                //}

            mailclient.Send(message);
            MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
