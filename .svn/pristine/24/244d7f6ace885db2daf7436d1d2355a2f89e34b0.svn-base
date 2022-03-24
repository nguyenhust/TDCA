using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Authoration.LIB;
using NETLINK.LIB;
using NETLINK.UI;

namespace TDCA
{
    public partial class LogIn : NETLINK.UI.LogIn
    {
        public LogIn()
        {
            InitializeComponent();
        }
        public Menu_ver2 MainForm
        {
            get;
            set;
        }
        protected override void Save(string username, string password)
        {
            try
            {
                txtPassWord.Text = string.Empty;
                using(StatusBusy busy = new StatusBusy("Đang kiểm tra đăng nhập ..."))
                {
                    Authoration.LIB.PTPrincipal.Login(username, password);
                }
                Csla.ApplicationContext.GlobalContext["KhongLoi"] = "T";
                this.Close();
            }
            catch(Exception ex)
            {
                Csla.ApplicationContext.GlobalContext["SoLanDangNhapLai"] = Convert.ToByte(Csla.ApplicationContext.GlobalContext["SoLanDangNhapLai"]) + 1;
                Csla.ApplicationContext.GlobalContext["KhongLoi"] = "F";
                GlobalCommon.ShowError(ex.Message, "Lỗi đăng nhập làm việc.");
                if(Convert.ToByte(Csla.ApplicationContext.GlobalContext["SoLanDangNhapLai"]) >2)
                    Application.Restart();
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Save(txtUserName.Text, txtPassWord.Text);
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
           
        }
        private bool move = false;
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            //if(move)
            //radPanel.Visible = false;
            //MessageBox.Show("leave");
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //radPanel.Visible = true;
           // MessageBox.Show("enter");
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.Close();
                this.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void radPanel_MouseEnter(object sender, EventArgs e)
        {
            //move = true;
            //radPanel.Visible = true;
        }

        private void radPanel_Click(object sender, EventArgs e)
        {
            Save(txtUserName.Text, txtPassWord.Text);
        }

        private void radPanel_MouseLeave(object sender, EventArgs e)
        {
            move = false;
        }
    }
}
