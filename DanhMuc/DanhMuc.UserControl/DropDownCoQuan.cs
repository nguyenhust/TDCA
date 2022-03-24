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
    public partial class DropDownCoQuan : RadMultiColumnComboBox
    {
        DIC_CoQuan_Coll listItem;
        public DropDownCoQuan()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn Cơ quan";
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
            gridViewControl.Columns[columnVisible].HeaderText = "Cơ quan";
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
        public void FillData(int STT)
        {
            object obj = GlobalCommon.CacheReader(TextMessages.CacheID.DIC_CoQuan + STT.ToString());
            if (obj != null)
            {
                FillData(((DIC_CoQuan_Coll)obj));
            }
            else
            {

                listItem = DIC_CoQuan_Coll.GetDIC_CoQuan_Coll();
                GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_CoQuan + STT.ToString(), listItem);
                BindData();
            }
           
        }


        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        /// <param name="Loai"></param>
        public void FillData(DIC_CoQuan_Coll Loai)
        {
            this.listItem = Loai;
            BindData();
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public DIC_CoQuan_Coll GetListData()
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
