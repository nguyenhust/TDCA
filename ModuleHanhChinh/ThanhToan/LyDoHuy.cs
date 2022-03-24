using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.UI;
using NETLINK.LIB;
using Authoration.LIB;
using System.Data.SqlClient;
using ModuleHanhChinh.LIB;

namespace ModuleHanhChinh.ThanhToan
{
    public partial class LyDoHuy : NETLINK.UI.Dictionary
    {
        bool cloen;
        


        public LyDoHuy(bool _DieuKien)
        {

            if (_DieuKien == false)
            {
                InitializeComponent();
                btnSave.Enabled = true;
                //ApplyAuthorizationRules();// phân quyền trên form
                rtbLyDo.Focus();
                rtbLyDo.Text = FormLyDoHuy._LyDoHuy;
                
            }
            else
            {
                InitializeComponent();
                btnSave.Enabled = true;
                //ApplyAuthorizationRules();// phân quyền trên form
                rtbLyDo.Focus();
              

            }
            //bindingSourceLyDo.DataSource = item;

        }
        private void LoadData()
        {
            RadGrid.DataSource = LyDoHuy_Coll.GetLyDoHuy_Coll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected override void ApplyAuthorizationRules()
        {// Can sua permission tuong ung voi moi form, luu permission vao trong textmessages
            if (!GlobalCommon.IsHavePermission(new string[] { TextMessages.RolePermission.DM_LyDoHuy_Insert, TextMessages.RolePermission.DM_LyDoHuy_Edit }))
            {
                GlobalCommon.ShowErrorMessager(TextMessages.ErrorMessage.DontHavePermissionToViewForm);
                this.Close();
            }
            else
            {
                btnSave.Enabled = true;
            }

        }
        protected override void Save()
        {

            cloen = FormLyDoHuy.close;


            if (cloen == true)
            {
                using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                {

                    cn.Open();
                    using (SqlCommand cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "LyDoHuyBienLai_ins";
                        cmd.Parameters.AddWithValue("@LyDoHuy", rtbLyDo.Text);
                        cmd.ExecuteNonQuery();
                        
                        GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.SaveSuccess);                      
                    }
                    this.Close();
                }
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                {
                    cn.Open();
                    using (SqlCommand cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "LyDoHuyBienLai_update";
                        cmd.Parameters.AddWithValue("@IDHuy", FormLyDoHuy._IDHuy);
                        cmd.Parameters.AddWithValue("@LyDoHuy", rtbLyDo.Text);
                        cmd.ExecuteNonQuery();
                       
                        GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.Editsuccessfully);
                    }
                }
                this.Close();
            }
        }  
    }   
    }
