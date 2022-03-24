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
using ModuleDaoTao.LIB;
using NETLINK.LIB;

namespace ModuleDaoTao.UserControls
{
    public partial class DropDownLopHocLienTucKhung : RadMultiColumnComboBox
    {
        DT_LienTuc_KhungLopHoc_Coll listItem;
        DT_LienTuc_KhungLopHoc_Coll itemListTem;
        public DropDownLopHocLienTucKhung()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn Lớp Học";


        }

        private void BindData()
        {
            BindData(listItem);
        }
        private void BindData(DT_LienTuc_KhungLopHoc_Coll source)
        {
            
            string columnVisible = "TenLop";
            this.DisplayMember = columnVisible;
            RadGridView gridViewControl = this.EditorControl;
            //dropChuyenNganh.EditorControl.DataSource = chuyenNganh;
            //gridViewControl.DataSource = null;
            //gridViewControl.Refresh();
            gridViewControl.DataSource = source;
            gridViewControl.Refresh();
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            foreach (GridViewColumn col in gridViewControl.Columns)
            {
                col.IsVisible = false;
            }
            gridViewControl.Columns[columnVisible].IsVisible = true;
            gridViewControl.Columns[columnVisible].HeaderText = "Tên";
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
        /// Loc du lieu theo dieu kien
        /// </summary>
        public void FilterData(FilterColumn filter, object item)
        {
            try
            {
                if (item != null && listItem != null)
                {
                    if (filter == FilterColumn.IDKhoaNgoai32 || filter == FilterColumn.IDKhoaNgoai64)
                    {
                        long id = Convert.ToInt64(item);
                        itemListTem = DT_LienTuc_KhungLopHoc_Coll.NewDT_LienTuc_KhungLopHoc_Coll();
                        foreach (DT_LienTuc_KhungLopHoc_Info itemInfo in listItem)
                        {
                            if(itemListTem.Count == 0)
                            {
                                DT_LienTuc_KhungLopHoc_Info itemnull = DT_LienTuc_KhungLopHoc_Info.NewDT_LienTuc_KhungLopHoc_Info();
                                itemnull.TenLop = "";
                                itemnull.Id = 0;
                                itemnull.IdChuyenKhoa = 0;
                                itemListTem.Add(itemnull);
                            }
                            if (itemInfo.IdChuyenKhoa == id)
                            {
                                //itemListTem.Add(itemInfo.Clone());
                                itemListTem.Add(itemInfo);
                            }
                        }
                        BindData(itemListTem);
                    }
                }

                this.Text = string.Empty;
                this.SelectedIndex = -1;
            }
            catch
            {
            }
        }
        /// <summary>
        /// Connect DB, Lấy tất cả data từ CSDL và nạp vào control
        /// </summary>
        public void FillData(int STT)
        {
            //object obj = GlobalCommon.CacheReader(TextMessages.CacheID.DT_KhungLopHoc + STT.ToString());
            //if (obj != null)
            //{
            //    FillData(((DT_LienTuc_KhungLopHoc_Coll)obj));
            //}
            //else
            //{

                listItem = DT_LienTuc_KhungLopHoc_Coll.GetDT_LienTuc_KhungLopHoc_Coll();
                itemListTem = listItem;
                GlobalCommon.CacheWriter(TextMessages.CacheID.DT_KhungLopHoc + STT.ToString(), listItem);
                BindData();
            //}
        }


        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        /// <param name="chucVu"></param>
        public void FillData(DT_LienTuc_KhungLopHoc_Coll listItem)
        {
            this.listItem = listItem;
            itemListTem = listItem;
            BindData();
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public DT_LienTuc_KhungLopHoc_Coll GetListData()
        {
            return listItem;
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
                    return itemListTem[this.SelectedIndex].Id;
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
                    for (int i = 0; i < itemListTem.Count; i++)
                    {
                        if (itemListTem[i].Id == Convert.ToInt64(value))
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
                    return itemListTem[this.SelectedIndex].TenLop;
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
                    for (int i = 0; i < itemListTem.Count; i++)
                    {
                        if (itemListTem[i].TenLop == value.ToString())
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
                    return itemListTem[this.SelectedIndex];
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
