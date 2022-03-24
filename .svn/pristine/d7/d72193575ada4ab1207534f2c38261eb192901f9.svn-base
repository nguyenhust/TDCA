using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using NETLINK.UI;
using NETLINK.LIB;
using ModuleDaoTao.LIB;
using Telerik.WinControls.UI;
using DanhMuc.UserControl;

namespace ModuleDaoTao.UI
{
    public partial class Form_HocVien_Chua_Upload_Images : Telerik.WinControls.UI.RadForm
    {
        private DT_LienTuc_HocVien_Coll listHV;
        BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_HVChuaUploadAnh);
        int nam = 0;
        public Form_HocVien_Chua_Upload_Images()
        {
            InitializeComponent();
            ThietLapGrid();
            dropDownBoPhan1.FillData(1);
            dropDownLoaiHinhDaoTao1.FillData();
            dropDownNam1.FillData();
            LoadUS();
        }

        private void LoadUS()
        {
            try
            {
                if (dropDownBoPhan1.GetListData() == null)
                    dropDownBoPhan1.FillData(1);
                if (dropDownBoPhan1.Selected_Item == null)
                    dropDownBoPhan1.SetText("đào tạo");
                if (string.IsNullOrEmpty(dropDownLoaiHinhDaoTao1.Text))
                    dropDownLoaiHinhDaoTao1.Text = "Theo Lớp";
                if (string.IsNullOrEmpty(dropDownNam1.Text))
                    dropDownNam1.Text = DateTime.Now.Year.ToString();
                //int nam = 0;
                if (!string.IsNullOrEmpty(dropDownLoaiHinhDaoTao1.Text) && int.TryParse(dropDownNam1.Text == "Tất cả" ? "0" : dropDownNam1.Text, out nam) && dropDownBoPhan1.Selected_TextValue != null)
                {

                    //BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDTLienTuc_HVChuaUploadAnh);
                    function.ItemFilterCondition_Int = nam;
                    function.ItemFilterCondition_String = dropDownLoaiHinhDaoTao1.Text;
                    function.ItemFilterCondition_Int2 = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
                    listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
                    bindHocVien.DataSource = listHV;
                    TotalRecordValue = listHV.Count.ToString();
                }
                else
                {
                    GlobalCommon.ShowErrorMessager("Bộ lọc tổng có lỗi, có thể bạn chưa chọn phòng, loại hình đào tạo hoặc giá trị năm không phải là một số");
                }
            }
            catch (Exception ex) { GlobalCommon.ShowErrorMessager(ex); }
        }

        private void ThietLapGrid()
        {
            this.radGridDSHocVien.ShowGroupPanel = false;
            this.radGridDSHocVien.MasterTemplate.AllowAddNewRow = true;
            this.radGridDSHocVien.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            // Thêm cột số thức tự vào radgrid
            var STT = new GridViewDecimalColumn(typeof(int), "STT", "STT");
            STT.AllowSort = false;
            radGridDSHocVien.Columns.Add(STT);
            this.radGridDSHocVien.Columns["STT"].MinWidth = 40;
            this.radGridDSHocVien.Columns["STT"].MaxWidth = 40;
            this.radGridDSHocVien.Columns["STT"].TextAlignment = ContentAlignment.TopCenter;
            //Chuyển cột số thứ tự lên đầu
            this.radGridDSHocVien.Columns.Move(this.radGridDSHocVien.Columns["STT"].Index, 0);
        }
        public string TotalRecordValue { get; set; }

        private void radGridDSHocVien_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.ColumnInfo.Name == "STT" && string.IsNullOrEmpty(e.CellElement.Text))
            {
                e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString();
            }
        }

        private void btnLietke_Click(object sender, EventArgs e)
        {
            function.ItemFilterCondition_Int = nam;
            function.ItemFilterCondition_String = dropDownLoaiHinhDaoTao1.Text;
            function.ItemFilterCondition_Int2 = Convert.ToInt32(dropDownBoPhan1.Selected_ID);
            listHV = DT_LienTuc_HocVien_Coll.GetDT_LienTuc_HocVien_Coll(function);
            bindHocVien.DataSource = listHV;
        }
    }
}
