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
using Authoration.LIB;
using NETLINK.LIB;

namespace Authoration.UserControls
{
    public partial class DropDownUser_CanBo : RadMultiColumnComboBox
    {
        ADM_NguoiDung_Coll listItem;
        public DropDownUser_CanBo()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn người dùng";


        }


        private void BindData()
        {

            string columnVisible = "TenCanBo";
            string columnVisible2 = "ChucVu";
            string columnVisible3 = "BoPhan";
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
            gridViewControl.Columns[columnVisible].HeaderText = "Tên người dùng";
            gridViewControl.Columns[columnVisible2].IsVisible = true;
            gridViewControl.Columns[columnVisible2].HeaderText = "Chức vụ";
            gridViewControl.Columns[columnVisible3].IsVisible = true;
            gridViewControl.Columns[columnVisible3].HeaderText = "Bộ Phận";
            gridViewControl.MasterTemplate.AutoGenerateColumns = false;
            gridViewControl.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            this.AutoFilter = true;
            this.BestFitColumns(true, true);
            this.AutoSizeDropDownToBestFit = true;
            FilterDescriptor filter = new FilterDescriptor();
            filter.PropertyName = this.DisplayMember;
            filter.Operator = FilterOperator.Contains;
            this.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

        }

        /// <summary>
        /// Connect DB, Lấy tất cả data từ CSDL và nạp vào control
        /// </summary>
        public void FillData()
        {
            listItem = ADM_NguoiDung_Coll.GetADM_NguoiDung_Coll(new BusinessFunction(BusinessFunctionMode.GetDataForDropDownWithCondition));
            BindData();
        }


        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        /// <param name="chucVu"></param>
        public void FillData(ADM_NguoiDung_Coll listItem)
        {
            this.listItem = listItem;
            BindData();
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public ADM_NguoiDung_Coll GetListData()
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
                    if (this.SelectedIndex >= 0)
                        return listItem[this.SelectedIndex].IDNguoiDung;
                    return -1;
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
                        if (listItem[i].IDNguoiDung == Convert.ToInt64(value))
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
                    if (this.SelectedIndex >= 0)
                        return listItem[this.SelectedIndex].TenDangNhap;
                    return string.Empty;
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
                        if (listItem[i].TenDangNhap == value.ToString())
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
                    if (this.SelectedIndex >= 0)
                        return listItem[this.SelectedIndex];
                    return null;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
