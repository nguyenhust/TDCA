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
using System.Diagnostics;

namespace DanhMuc.UserControl
{
    public partial class DropDownBenhVien : RadMultiColumnComboBox
    {
        DIC_BenhVien_Coll listItem;
        public DropDownBenhVien()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn bệnh viện";


        }


        private void BindData()
        {

            string columnVisible = "Ten";
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
            gridViewControl.Columns[columnVisible].IsVisible = true;
            gridViewControl.Columns[columnVisible].HeaderText = "Tên bệnh viện";
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.AutoFilter = true;
            this.BestFitColumns(true, true);
            this.AutoSizeDropDownToBestFit = true;
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);
            Debug.WriteLine(DateTime.Now.ToString()+"day roi");
            try
            {
                this.SelectedIndex = -1;
            }
            catch
            {
            }
        }

        /// <summary>
        /// Nếu trong Form chỉ có 1 ô dropdownBenhVien -> STT = 1, else đánh số cho đến hết 
        /// </summary>
        public void FillData(int STT)
        {
            object obj = GlobalCommon.CacheReader(TextMessages.CacheID.DIC_BenhVien + STT.ToString());
            if (obj != null)
            {
                FillData((DIC_BenhVien_Coll)obj);
            }
            else
            {
                listItem = DIC_BenhVien_Coll.GetDIC_BenhVien_Coll();
                GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_BenhVien + STT.ToString(), listItem);
                BindData();
            }
            
        }


        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        /// <param name="chucVu"></param>
        public void FillData(DIC_BenhVien_Coll listItem)
        {
            this.listItem = listItem;
            BindData();
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public DIC_BenhVien_Coll GetListData()
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
                    return listItem[this.SelectedIndex].ID;
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
                        if (listItem[i].ID == Convert.ToInt64(value))
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
                    return listItem[this.SelectedIndex].Ten;
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
                        if (listItem[i].Ten == value.ToString())
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
    }
}
