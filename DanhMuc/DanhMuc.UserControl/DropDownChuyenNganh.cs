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
    public partial class DropDownChuyenNganh : RadMultiColumnComboBox
    {
        DIC_ChuyenNganh_Coll listItem;
        public DropDownChuyenNganh()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn Chuyên Ngành";
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
            gridViewControl.Columns[columnVisible].HeaderText = "Chuyên ngành";
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
        public void FillData(long STT)
        {
            object obj = GlobalCommon.CacheReader(TextMessages.CacheID.DIC_ChuyenNganh + STT.ToString());
            if (obj != null)
            {
                FillData((DIC_ChuyenNganh_Coll)obj);
            }
            else
            {

                listItem = DIC_ChuyenNganh_Coll.GetDIC_ChuyenNganh_Coll();
                GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_ChuyenNganh + STT.ToString(), listItem);
                BindData();
            }
            
        }

        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        public void FillData(DIC_ChuyenNganh_Coll chuyenNganh)
        {
            this.listItem = chuyenNganh.Clone();
            BindData();
        }

        /// <summary>
        /// Connect DB, Lấy data theo điều kiện lọc
        /// </summary>
        /// <param name="idChuyenKhoa">id của chuyên khoa</param>
        public void FillData(int idChuyenKhoa)
        {
            listItem = DIC_ChuyenNganh_Coll.GetDIC_ChuyenNganh_Coll();
            BindData();
        }

        /// <summary>
        /// Khong Connect DB, Chỉ lọc ra những chuyên khoa liên quan
        /// </summary>
        /// <param name="idChuyenKhoa">id chuyên ngành</param>
        public void ReFillData(int idChuyenKhoa)
        {
            
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public DIC_ChuyenNganh_Coll GetListData()
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
