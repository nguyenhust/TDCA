using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using NETLINK.LIB;
using DanhMuc.LIB;
namespace DanhMuc.UserControl
{
    public partial class DropHocHam : RadMultiColumnComboBox
    {
        DIC_HocHam_Coll items;
        public DropHocHam()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn học hàm";
        }
        private void BindData()
        {
            string columnVisible = "TenHocHam";
            this.DisplayMember = columnVisible;
            RadGridView gridViewControl = this.EditorControl;
            //dropChuyenNganh.EditorControl.DataSource = chuyenNganh;
            gridViewControl.DataSource = items;
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            foreach (GridViewColumn col in gridViewControl.Columns)
            {
                col.IsVisible = false;
            }
            gridViewControl.Columns[columnVisible].IsVisible = true;
            gridViewControl.Columns[columnVisible].HeaderText = "Học hàm";
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

        public void FillData(int STT)
        {
           object obj = GlobalCommon.CacheReader(TextMessages.CacheID.DIC_HocHam + STT.ToString());
            if (obj != null)
            {
                FillData((DIC_HocHam_Coll)obj);               
            }
            else
            {
                items = DIC_HocHam_Coll.GetDIC_HocHam_Coll();
                GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_HocHam + STT.ToString(), items);
                BindData();
            }


        }


        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        /// <param name="chucVu"></param>
        public void FillData(DIC_HocHam_Coll listItem)
        {
            this.items = listItem;
            BindData();
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public DIC_HocHam_Coll GetListData()
        {
            return items;
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
                    return items[this.SelectedIndex].ID;
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
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i].ID == Convert.ToInt64(value))
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
                    return items[this.SelectedIndex].TenHocHam;
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
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i].TenHocHam == value.ToString())
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
                    return items[this.SelectedIndex];
                }
                catch
                {
                    return null;
                }
            }
        }

       
    }
}
