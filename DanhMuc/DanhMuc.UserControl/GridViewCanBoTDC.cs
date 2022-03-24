using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NETLINK.LIB;
using DanhMuc.LIB;
using NETLINK.UI;
using Csla;

namespace DanhMuc.UserControl
{
    public partial class GridViewCanBoTDC : System.Windows.Forms.UserControl
    {
        private LoaiCanBo loaiCanBo = LoaiCanBo.CanBoThuocTrungTamCDT;
        private DIC_CanBo_Coll listItem;
        private int TotalChecked = 0;
        private string Title = "Số CB được chọn : ";
        private string Separate = ", ";
        private bool isLoading = false;
        public GridViewCanBoTDC()
        {
            InitializeComponent();
            VNRadGridLP.CurrentProvider = new VNRadGridLP();
            IncludeCurrentUser = true;
        }
        public bool Enable
        {
            get { return radGridView1.Enabled; }
            set
            {
                radGridView1.Enabled = value;
                radCheckBox1.Enabled = value;
            }
        }
        public bool IncludeCurrentUser
        {
            get;
            set;
        }
        public string TextTitle
        {
            get { return radLabel2.Text; }
            set { radLabel2.Text = value; }
        }
        public Color TextColor
        {
            get { return radLabel2.ForeColor; }
            set { radLabel2.ForeColor = value; }
        }
        public bool IsNull
        {
            get
            {
                bool str = true;
                foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                {
                    if (rowInfo.Cells["Selected"].Value != null && (bool)rowInfo.Cells["Selected"].Value)
                    {
                        str = false;
                        break;
                    }
                }
                return str;
            }
        }
        public string IsNull_String
        {
            get
            {
                if (IsNull)
                    return string.Empty;
                else
                    return "notNull";
            }
        }
        private void BindData()
        {
            if (listItem != null)
            {
                isLoading = true;
                SortedBindingList<DIC_CanBo_Info> sortListPGV = new SortedBindingList<DIC_CanBo_Info>(listItem);
                sortListPGV.ApplySort("SortBy_Phong_ChucVu", ListSortDirection.Ascending);
                bindingSource.DataSource = sortListPGV;
                TotalChecked = 0;
                radLabelTongSo.Text = Title + "00";
                isLoading = false;
            }
        }

        /// <summary>
        /// Connect DB, Lấy tất cả data từ CSDL và nạp vào control
        /// </summary>
        public void FillData()
        {
            FillData(LoaiCanBo.CanBoThuocTrungTamCDT,BusinessFunctionMode.GetDataForGridViewWithCondition);
        }

        public void FillData(BusinessFunctionMode mode)
        {
            FillData(LoaiCanBo.CanBoThuocTrungTamCDT,mode);
        }

        /// <summary>
        /// Lấy tất cả data với Loại cán bộ tương ứng
        /// </summary>
        /// <param name="loaiCanBo"></param>
        public void FillData(LoaiCanBo loaiCanBo, BusinessFunctionMode mode)
        {
            object obj = GlobalCommon.CacheReader(string.Format("{0}{1}1", TextMessages.CacheID.DIC_CanBo, Convert.ToInt32(loaiCanBo).ToString()));
            if (obj != null)
            {
                FillData((DIC_CanBo_Coll)obj);
            }
            else
            {
                BusinessFunction function = new BusinessFunction(mode);
                function.Item = loaiCanBo;
                listItem = DIC_CanBo_Coll.GetDIC_CanBo_Coll(function);
                GlobalCommon.CacheWriter(string.Format("{0}{1}1", TextMessages.CacheID.DIC_CanBo, Convert.ToInt32(loaiCanBo).ToString()), listItem);
            }
            BindData();
        }

        /// <summary>
        /// Nap data bang list co san
        /// </summary>
        /// <param name="chucVu"></param>
        public void FillData(DIC_CanBo_Coll listItem)
        {
            this.listItem = listItem;
            BindData();
        }

        private void RefreshGridView()
        {
            isLoading = true;
            foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
            {
                try
                {
                    rowInfo.Cells["Selected"].Value = false;
                }
                catch
                {
                }
            }
            TotalChecked = 0;
            radLabelTongSo.Text = Title + "00";
            isLoading = false;
        }
        public DIC_CanBo_Coll Selected_ListItem
        {
            get
            {
                try
                {
                    DIC_CanBo_Coll listTempItem = DIC_CanBo_Coll.NewDIC_CanBo_Coll();
                    foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                    {
                        if (rowInfo.Cells["Selected"].Value != null && (bool)rowInfo.Cells["Selected"].Value)
                        {
                            DIC_CanBo_Info itemInfo = (DIC_CanBo_Info)rowInfo.DataBoundItem;
                            listTempItem.Add(itemInfo);
                        }
                    }
                    return listTempItem;
                }
                catch
                {
                    return DIC_CanBo_Coll.NewDIC_CanBo_Coll();
                }
            }
            set
            {
                if (value != null && value.ToString() != string.Empty)
                {
                    isLoading = true;
                    RefreshGridView();
                    DIC_CanBo_Coll listTempItem = value;

                    foreach (DIC_CanBo_Info itemInfo in listTempItem)
                    {
                        foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                        {
                            try
                            {
                                if (rowInfo.Cells["ID"].Value != null && Convert.ToInt64(rowInfo.Cells["ID"].Value) == itemInfo.ID)
                                {
                                    rowInfo.Cells["Selected"].Value = true;
                                    TotalChecked++;
                                    break;
                                }


                            }
                            catch
                            {

                            }
                        }
                    }
                    if (TotalChecked < 9)
                    {
                        radLabelTongSo.Text = string.Format("{0}0{1}", Title, TotalChecked.ToString());
                    }
                    else
                    {
                        radLabelTongSo.Text = string.Format("{0}{1}", Title, TotalChecked.ToString());
                    }
                    isLoading = false;
                }
                else
                {
                    RefreshGridView();
                }
            }
        }
        public string Selected_ListItem_Name
        {
            get
            {
                try
                {
                    string str = string.Empty;
                    foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                    {
                        if (rowInfo.Cells["Selected"].Value != null && (bool)rowInfo.Cells["Selected"].Value)
                        {
                            DIC_CanBo_Info itemInfo = (DIC_CanBo_Info)rowInfo.DataBoundItem;
                            str = string.Format("{0}{1}{2}", str, itemInfo.HoTen.ToString(), Separate);
                        }
                    }
                    return str;
                }
                catch
                {
                    return string.Empty;
                }
            }
            set
            {
                if (value != null && value.ToString() != string.Empty)
                {
                    isLoading = true;
                    RefreshGridView();
                    string str = value;
                    string[] listID = str.Split(new string[] { Separate }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string HoTen in listID)
                    {
                        foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                        {
                            try
                            {
                                if (rowInfo.Cells["HoTen"].Value != null && Convert.ToString(rowInfo.Cells["HoTen"].Value).ToLower().Trim() == HoTen.ToLower().Trim())
                                {
                                    rowInfo.Cells["Selected"].Value = true;
                                    TotalChecked++;
                                    break;
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    if (TotalChecked < 9)
                    {
                        radLabelTongSo.Text = string.Format("{0}0{1}", Title, TotalChecked.ToString());
                    }
                    else
                    {
                        radLabelTongSo.Text = string.Format("{0}{1}", Title, TotalChecked.ToString());
                    }
                    isLoading = false;
                }
                else
                {
                    RefreshGridView();
                }
            }
        }
        public string Selected_ListItem_ID
        {
            get
            {
                try
                {
                    string str = string.Empty;
                    foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                    {
                        if (rowInfo.Cells["Selected"].Value != null && (bool)rowInfo.Cells["Selected"].Value)
                        {
                            DIC_CanBo_Info itemInfo = (DIC_CanBo_Info)rowInfo.DataBoundItem;
                            str = string.Format("{0}{1}{2}", str, itemInfo.ID.ToString(), Separate);
                        }
                    }
                    return str;
                }
                catch
                {
                    return string.Empty;
                }
            }
            set
            {
                if (value != null && value.ToString() != string.Empty)
                {
                    isLoading = true;
                    RefreshGridView();
                    string str = value;
                    string[] listID = str.Split(new string[] { Separate }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string ID in listID)
                    {
                        foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                        {
                            try
                            {
                                if (rowInfo.Cells["ID"].Value != null && Convert.ToInt64(rowInfo.Cells["ID"].Value) == Convert.ToInt64(ID.Trim()))
                                {
                                    rowInfo.Cells["Selected"].Value = true;
                                    TotalChecked++;
                                    break;
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    if (TotalChecked < 9)
                    {
                        radLabelTongSo.Text = string.Format("{0}0{1}", Title, TotalChecked.ToString());
                    }
                    else
                    {
                        radLabelTongSo.Text = string.Format("{0}{1}", Title, TotalChecked.ToString());
                    }
                    isLoading = false;
                }
                else
                {
                    RefreshGridView();
                }
            }
        }

        public string Selected_ListItem_IDUser
        {
            get
            {
                try
                {
                    string str = string.Empty;
                    foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                    {
                        if (rowInfo.Cells["Selected"].Value != null && (bool)rowInfo.Cells["Selected"].Value)
                        {
                            DIC_CanBo_Info itemInfo = (DIC_CanBo_Info)rowInfo.DataBoundItem;
                            str = string.Format("{0}{1}{2}{3}", str, TextMessages.Config.Separte01, itemInfo.IDUser.ToString(), TextMessages.Config.Separte01);
                        }
                    }
                    return str;
                }
                catch
                {
                    return string.Empty;
                }
            }
        }
        public event EventHandler ValueChanged;

        private void radGridView1_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (!isLoading)
            {
                if ((bool)e.Row.Cells["Selected"].Value)
                {
                    TotalChecked++;
                }
                else
                {
                    TotalChecked--;
                }
                if (TotalChecked < 9)
                {
                    radLabelTongSo.Text = string.Format("{0}0{1}", Title, TotalChecked.ToString());
                }
                else
                {
                    radLabelTongSo.Text = string.Format("{0}{1}", Title, TotalChecked.ToString());
                }
            }
            EventHandler handler = ValueChanged;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        private void radGridView1_CellBeginEdit(object sender, Telerik.WinControls.UI.GridViewCellCancelEventArgs e)
        {
            
        }

        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            try
            {
                if (radCheckBox1.Checked)
                {
                    foreach (Telerik.WinControls.UI.GridViewRowInfo rowInfo in radGridView1.ChildRows)
                    {
                        rowInfo.Cells["Selected"].Value = true;
                    }
                }
                else
                {
                    RefreshGridView();
                }
            }
            catch
            {
            }
        }

        private void radGridView1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (radGridView1 != null && radGridView1.AllowEditRow && !radGridView1.CurrentRow.Cells[radGridView1.CurrentColumn.Name].ReadOnly)
                {
                    radGridView1.CurrentRow.Cells[radGridView1.CurrentColumn.Name].EndEdit();
                    //_RadGrid.CellEndEdit(_RadGrid, new GridViewCellEventArgs(_RadGrid.CurrentRow, _RadGrid.CurrentColumn, new IInputEditor()));
                }
            }
            catch
            {
            }
        }

    }
}
