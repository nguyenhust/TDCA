using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using DanhMuc.LIB;
using NETLINK.LIB;

namespace DanhMuc.UserControl
{
    public partial class DropDownGiangVien : RadMultiColumnComboBox
    {
        DIC_GiangVien_Coll listItem;
        public List<string> DanhMucCotHienThi { get; set; }
        public List<string> TenTuongUng { get; set; }
        public DropDownGiangVien()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn Giảng viên";
            DanhMucCotHienThi = new List<string>() { "HoTen" };
            TenTuongUng = new List<string>() { "Họ tên giảng viên" };
        }


        private void BindData()
        {

            string columnVisible = "HoTen";
            this.DisplayMember = columnVisible;
            RadGridView gridViewControl = this.EditorControl;
            //dropChuyenNganh.EditorControl.DataSource = chuyenNganh;
            gridViewControl.DataSource = listItem;
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            foreach (GridViewColumn col in gridViewControl.Columns)
            {
                col.IsVisible = false;
            }
            for (int i = 0; i < DanhMucCotHienThi.Count; i++)
            {
                gridViewControl.Columns[DanhMucCotHienThi[i]].IsVisible = true;
                gridViewControl.Columns[DanhMucCotHienThi[i]].HeaderText = TenTuongUng[i];
            }
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.AutoFilter = true;
            this.BestFitColumns(true, true);
            this.AutoSizeDropDownToBestFit = true;
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            try
            {
                this.SelectedIndex = -1;
            }
            catch
            {
            }
        }



        /// <summary>
        /// Connect DB, Lấy tất cả data từ CSDL và nạp vào control
        /// </summary>
        public void FillData()
        {
            this.listItem = DIC_GiangVien_Coll.GetDIC_GiangVien_Coll();
            BindData();
            //FillData(STT);
        }
        /// <summary>
        /// Lấy tất cả data với Loại cán bộ tương ứng
        /// </summary>
        /// <param name="loaiCanBo"></param>
        public void FillData(int STT)
        {
            // object obj = GlobalCommon.CacheReader(string.Format("{0}{1}{2}",TextMessages.CacheID.DIC_CanBo,Convert.ToInt32(loaiCanBo).ToString(),STT.ToString()));
            //if (obj != null)
            //{
            //    FillData((DIC_CanBo_Coll)obj);
            //}
            //else
            //{
                //BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetDataForDropDownWithCondition);
                //function.Item = loaiCanBo;
            listItem = DIC_GiangVien_Coll.GetDIC_GiangVien_Coll();
                //GlobalCommon.CacheWriter(string.Format("{0}{1}{2}", TextMessages.CacheID.DIC_CanBo, Convert.ToInt32(loaiCanBo).ToString(), STT.ToString()), listItem);
                BindData();
            //}
           
        }


        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        /// <param name="chucVu"></param>
        public void FillData(DIC_GiangVien_Coll listItem)
        {
            this.listItem = listItem;
            BindData();
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public DIC_GiangVien_Coll GetListData()
        {
            return listItem;
        }

        /// <summary>
        /// Loc du lieu theo dieu kien
        /// </summary>
        public void FilterData(FilterColumn filter, object item)
        {
            if (item != null)
            {
                if (filter == FilterColumn.IDKhoaNgoai32)
                {
                    int id = Convert.ToInt32(item);
                    string columnName = "";
                    RadGridView gridViewControl = this.EditorControl;
                    foreach (GridViewRowInfo row in gridViewControl.Rows)
                    {
                        DIC_CanBo_Info info = (DIC_CanBo_Info)row.DataBoundItem;
                        if (info.IDBoPhan != id)
                        {
                            row.IsVisible = false;
                        }
                        else
                        {
                            row.IsVisible = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Lấy id của bản ghi, ép kiểu về int or int64
        /// </summary>
        public object Selected_ID
        {
            get
            {
                try
                {
                    return listItem[this.SelectedIndex].IDGiangVien;
                }
                catch
                {
                    return null;
                }
            }
            set
            {
                try
                {
                    for (int i = 0; i < listItem.Count; i++)
                    {
                        if (listItem[i].IDGiangVien == Convert.ToInt64(value))
                        {
                            this.SelectedIndex = i;
                        }
                    }
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Lấy text value đang hiển thị (kiểu string)
        /// </summary>
        public object Selected_TextValue
        {
            get
            {
                try
                {
                    return listItem[this.SelectedIndex].HoTen;
                }
                catch
                {
                    return null;
                }
            }
            set
            {
                try
                {
                    for (int i = 0; i < listItem.Count; i++)
                    {
                        if (listItem[i].HoTen == value.ToString())
                        {
                            this.SelectedIndex = i;
                        }
                    }
                }
                catch
                {
                }
            }
        }

        /// <summary>
        /// Lấy toàn bộ object đang được select (ép kiểu về class tương ứng)
        /// </summary>
        public object Selected_Item
        {
            get
            {
                try
                {
                    return listItem[this.SelectedIndex];
                }
                catch
                {
                    return null;
                }
            }
        }

        public object Selected_Item_IDChucVu
        {
            get
            {
                try
                {
                    return listItem[this.SelectedIndex].IDChucVu;
                }
                catch
                {
                    return null;
                }
            }
        }
        public object Selected_Item_IDBoPhan
        {
            get
            {
                try
                {
                    return listItem[this.SelectedIndex].IDBoPhan;
                }
                catch
                {
                    return null;
                }
            }
        }
        public object Selected_Item_IDTrinhDo
        {
            get
            {
                try
                {
                    return listItem[this.SelectedIndex].IDTrinhDo;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
