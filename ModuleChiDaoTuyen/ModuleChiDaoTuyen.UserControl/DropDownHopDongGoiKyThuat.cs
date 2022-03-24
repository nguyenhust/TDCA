using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using ModuleChiDaoTuyen.LIB;
using DanhMuc.LIB;
using NETLINK.LIB;

namespace ModuleChiDaoTuyen.UserControl
{
    public partial class DropDownHopDongGoiKyThuat : RadMultiColumnComboBox
    {
        private CDT_HopDong_GoiKT_Coll listItem;
        public DropDownHopDongGoiKyThuat()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn gói kỹ thuật";


        }


        private void BindData()
        {

            string columnVisible = "TenGoiKT";
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
            gridViewControl.Columns[columnVisible].HeaderText = "Tên Gói Kỹ Thuật";
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
        public void FillData(int IdHopDong)
        {
            object obj = GlobalCommon.CacheReader(TextMessages.CacheID.CDT_GoiKT +IdHopDong.ToString());
            if (obj != null)
            {
                FillData(((CDT_HopDong_GoiKT_Coll)obj).Clone());
            }
            else
            {
                BusinessFunction function = new BusinessFunction(BusinessFunctionMode.GetAllDataWithCondition);
                function.ItemID = IdHopDong;
                listItem = CDT_HopDong_GoiKT_Coll.GetCDT_HopDong_GoiKT_Coll(function);
                GlobalCommon.CacheWriter(TextMessages.CacheID.CDT_GoiKT+IdHopDong.ToString(), listItem);
                BindData();
            }
            
        }

        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        /// <param name="chucVu"></param>
        public void FillData(CDT_HopDong_GoiKT_Coll listItem)
        {
            this.listItem = listItem;
            BindData();
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public CDT_HopDong_GoiKT_Coll GetListData()
        {
            return listItem;
        }
        /// <summary>
        /// Lấy id của bản ghi, ép kiểu về int or int64
        /// </summary>
        public object Selected_IDGoiKT
        {
            get
            {
                try
                {
                    CDT_HopDong_GoiKT_Info itemX = listItem[this.SelectedIndex];
                    return itemX.IdGoiKT;
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
                        CDT_HopDong_GoiKT_Info itemX = listItem[i];
                        if (itemX.IdGoiKT == Convert.ToInt64(value))
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
                    return listItem[this.SelectedIndex].TenGoiKT;
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
                        if (listItem[i].TenGoiKT == value.ToString())
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
