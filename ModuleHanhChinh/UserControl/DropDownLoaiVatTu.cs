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
using ModuleHanhChinh.LIB;
using DanhMuc.LIB;
using NETLINK.LIB;

namespace ModuleHanhChinh.UserControl
{
    public partial class DropDownLoaiVatTu : RadMultiColumnComboBox
    {
        
        //HC_VatTuTaiSan_Coll listItem;
        DIC_LoaiTrangThietBi_Coll listItem;
        public List<string> DanhMucCotHienThi { get; set; }
        public List<string> TenTuongUng { get; set; }
        public DropDownLoaiVatTu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.NullText = "Chọn loại vật tư";
            DanhMucCotHienThi = new List<string>() { "Type" };
            TenTuongUng = new List<string>() { "Loại vật tư" };
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
            gridViewControl.Columns[columnVisible].HeaderText = "Loại vật tư";
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
            //object obj = GlobalCommon.CacheReader(TextMessages.CacheID.DIC_LoaiVatTu + STT.ToString());
            //if (obj != null)
            //{
            //    FillData((HC_VatTuTaiSan_Coll)obj);
            //}
            //else
            //{
            //    listItem = HC_VatTuTaiSan_Coll.GetHC_VatTuTaiSan_Coll();
            //    GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_LoaiVatTu + STT.ToString(), listItem);
            //    BindData();
            //}
            object obj = GlobalCommon.CacheReader(TextMessages.CacheID.DIC_LoaiTrangThietBi + STT.ToString());
            if (obj != null)
            {
                FillData((DIC_LoaiTrangThietBi_Coll)obj);
            }
            else
            {
                listItem = DIC_LoaiTrangThietBi_Coll.GetDIC_LoaiTrangThietBi_Coll();
                GlobalCommon.CacheWriter(TextMessages.CacheID.DIC_LoaiTrangThietBi + STT.ToString(), listItem);
                BindData();
            }

        }

        /// <summary>
        /// Nap Data vao control bang list co san
        /// </summary>
        /// <param name="hocVi"></param>
        public void FillData(DIC_LoaiTrangThietBi_Coll hocVi)
        {
            listItem = hocVi;
            BindData();
        }

        /// <summary>
        /// Lấy data từ list được lưu trong control
        /// </summary>
        /// <returns></returns>
        public DIC_LoaiTrangThietBi_Coll GetListData()
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
