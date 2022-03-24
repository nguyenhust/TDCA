using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;
using Csla.Data;
using ModuleHanhChinh.LIB;
using Telerik.WinControls.UI;
using NETLINK.UI;

namespace ModuleHanhChinh.ThanhToan
{
    public partial class FormLyDoHuy :Form
    {
        public static bool close=true;
        private int selectedID = -1;
        public static Int64 _IDHuy;
        public static string _LyDoHuy;
     
        #region Declare
        private HuyBienLai_Coll _oHuyBienLai_Coll;
        public HuyBienLai_Coll oHuyBienLai_Coll
        {
            get { return _oHuyBienLai_Coll; }
            set { _oHuyBienLai_Coll = value; }
        }
        private LyDoHuy_Coll oLyDoHuy_Coll;
     
        private decimal _SoTien;
        private Int64 _IDHocVien;
        private Int64 _IDBienLai;
        private string _SoPhieuHuy;
        private DateTime _NgayHuy;
        private Int64 _IDNguoiHuy;
        private string _NguoiNhan;
        private Int32 _IDLopHoc;
        public decimal SoTien
        {
            get { return _SoTien; }
            set { _SoTien = value; }
        }
        public Int64 IDHocVien
        {
            get { return _IDHocVien; }
            set { _IDHocVien = value; }
        }
        public Int64 IDBienLai
        {
            get { return _IDBienLai; }
            set { _IDBienLai = value; }
        }
        public string SoPhieuHuy
        {
            get { return _SoPhieuHuy; }
            set { _SoPhieuHuy = value; }
        }
        public DateTime NgayHuy
        {
            get { return _NgayHuy; }
            set { _NgayHuy = value; }
        }
        public Int64 IDNguoiHuy
        {
            get { return _IDNguoiHuy; }
            set { _IDNguoiHuy = value; }
        }
         public string NguoiNhan
        {
            get { return _NguoiNhan; }
            set { _NguoiNhan = value; }
        }
        public Int32 IDLopHoc
         {
             get { return _IDLopHoc; }
             set { _IDLopHoc = value; }
         }
      
        #endregion
        public FormLyDoHuy(Int64 intiDHocVien, Int64 intiDBienLai,string strsoPhieuHuy, decimal dclsoTien, DateTime dtengayHuy, Int64 intiDNguoiHuy, String strnguoiNhan,Int32 intIDLopHoc)
        {
            InitializeComponent();
            this.bindLyDo.DataSource = LyDoHuy_Coll.GetLyDoHuy_Coll();
            IDHocVien = intiDHocVien;
            IDBienLai = intiDBienLai;
            SoPhieuHuy = strsoPhieuHuy;
            SoTien = dclsoTien;
            NgayHuy = dtengayHuy;
            IDNguoiHuy = intiDNguoiHuy;
            NguoiNhan = strnguoiNhan;
            IDLopHoc = intIDLopHoc;
            LyDoHuy fm = new LyDoHuy(close);
            //LyDoHuy fm = new LyDoHuy();
            fm.RadGrid = radgDSBienLai;
          
           
        }
        private void Load()
        {
            LyDoHuy fm = new LyDoHuy(close);
            fm.RadGrid = radgDSBienLai;
            radgDSBienLai.DataSource = LyDoHuy_Coll.GetLyDoHuy_Coll();
         
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool closed = false;
            //_oHuyBienLai_Coll = HuyBienLai_Coll.NewHuyBienLai_Coll();
            //        HuyBienLai_Info info = HuyBienLai_Info.NewHuyBienLai_Info();
            //info.IDHocVien = Convert.ToInt32(this.IDHocVien);
            //info.IDBienLai = this.IDBienLai;
            //info.SoPhieuHuy  = this.SoPhieuHuy;
            //info.SoTien = this.SoTien;
            //info.NgayHuy = this.NgayHuy;
            //info.IDNguoiHuy = this.IDNguoiHuy;
            //info.NguoiNhan = this.NguoiNhan;
            //info.LyDoHuy = GlobalCommon.GetLyDoHuy(Convert.ToInt64(radgDSBienLai.CurrentRow.Cells["IDHuy"].Value));
            //info.TrangThai = 0;
            //_oHuyBienLai_Coll.Add(info);
            //closed = true;
            if (Convert.ToInt32(this.IDHocVien) != 0)
            {
                using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
                {
                    cn.Open();
                    using (SqlCommand cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "HuyBienLai_ins";

                        cmd.Parameters.AddWithValue("@IDHocVien", Convert.ToInt32(this.IDHocVien));
                        cmd.Parameters.AddWithValue("@IDBienLai", IDBienLai);
                        cmd.Parameters.AddWithValue("@SoPhieuHuy", this.SoPhieuHuy);
                        cmd.Parameters.AddWithValue("@SoTien", this.SoTien);
                        cmd.Parameters.AddWithValue("@NgayHuy", Convert.ToDateTime(GlobalCommon.GetTimeServer()));
                        cmd.Parameters.AddWithValue("@IDNguoihuy", this.IDNguoiHuy);
                        cmd.Parameters.AddWithValue("@NguoiNhan", this.NguoiNhan);
                        cmd.Parameters.AddWithValue("@LyDoHuy", GlobalCommon.GetLyDoHuy(Convert.ToInt64(radgDSBienLai.CurrentRow.Cells["IDHuy"].Value)));
                        cmd.Parameters.AddWithValue("@TrangThai", 0);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Hủy thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    closed = true;
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
                        cmd.CommandText = "HuyBienLai_insert ";

                        cmd.Parameters.AddWithValue("@IDLopHoc", Convert.ToInt32(this.IDLopHoc));
                        cmd.Parameters.AddWithValue("@IDBienLai", IDBienLai);
                        cmd.Parameters.AddWithValue("@SoPhieuHuy", this.SoPhieuHuy);
                        cmd.Parameters.AddWithValue("@SoTien", this.SoTien);
                        cmd.Parameters.AddWithValue("@NgayHuy", Convert.ToDateTime(GlobalCommon.GetTimeServer()));
                        cmd.Parameters.AddWithValue("@IDNguoihuy", this.IDNguoiHuy);
                        cmd.Parameters.AddWithValue("@NguoiNhan", this.NguoiNhan);
                        cmd.Parameters.AddWithValue("@LyDoHuy", GlobalCommon.GetLyDoHuy(Convert.ToInt64(radgDSBienLai.CurrentRow.Cells["IDHuy"].Value)));
                        cmd.Parameters.AddWithValue("@TrangThai", 0);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Hủy thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    closed = true;
                }
            }

            if (closed)
                this.Close();
            else
                MessageBox.Show("Bác sĩ phải chọn một hoặc nhiều điều kiện để xác nhận cho dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
       
        private void radgDSBienLai_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
           
        }

        private void radgDSBienLai_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            close = false;
            _IDHuy = (Int64)(radgDSBienLai.CurrentRow.Cells["IDHuy"].Value);
            _LyDoHuy = radgDSBienLai.CurrentRow.Cells["LyDoHuy"].Value.ToString();
            LyDoHuy fm = new LyDoHuy(close);
            fm.ShowDialog();
            Load();                    
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {          
            
            close = true;
            LyDoHuy fm = new LyDoHuy(close);           
            fm.ShowDialog();
            Load();
          
          
       }  
        private void radgDSBienLai_Click(object sender, EventArgs e)
        {

        }

        private void radbtnDelete_Click(object sender, EventArgs e)
        {
           if( GlobalCommon.AcceptDelete())
           {
               using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
               {
                   cn.Open();
                   using (SqlCommand cmd = cn.CreateCommand())
                   {
                       cmd.CommandType = CommandType.StoredProcedure;
                       cmd.CommandText = "dbo.LyDoHuyBienLai_delete";
                       _IDHuy = (Int64)(radgDSBienLai.CurrentRow.Cells["IDHuy"].Value);
                       cmd.Parameters.AddWithValue("@IDHuy", _IDHuy);
                       cmd.ExecuteNonQuery();
                       Load();
                   }
                   GlobalCommon.ShowMessageInformation(TextMessages.InfoMessage.Deletesuccessfully);
               }
            }
           else
           {
             
           }
        }

        private void FormLyDoHuy_Load(object sender, EventArgs e)
        {
           // radgDSBienLai.DataSource = LyDoHuy_Coll.GetLyDoHuy_Coll();
        }
    }
}
