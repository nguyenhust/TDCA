using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using NETLINK.LIB;

namespace NETLINK.UI
{
    public partial class netLink_DatePicker : Telerik.WinControls.UI.RadTextBox
    {
        public netLink_DatePicker()
        {
            InitializeComponent();
            this.NullText = "dd/mm/yyyy";
            this.MyName = "Ngày";
        }
        private bool isdatetime = false;
        private bool isnull = true;

        public bool isDateTime { get { return isdatetime; } }
        public bool isNull { get { return isnull; } }

        protected override void OnLoad(Size desiredSize)
        {
            base.OnLoad(desiredSize);
            isdatetime = false;
        }


        protected override void OnLeave(EventArgs e)
        {
            ConvertData();
        }
        public void ConvertData()
        {
            try
            {
                isdatetime = false;
                isnull = false;
                if (string.IsNullOrEmpty(this.Text))
                {
                    isdatetime = true;
                    isnull = true;
                }
                else
                {
                    string str = this.Text;
                    Int64 num;
                    if (str.Length == 8 && Int64.TryParse(str, out num))
                    {
                        this.Text = string.Format("{0}/{1}/{2}", str.Substring(0, 2), str.Substring(2, 2), str.Substring(4, 4));
                        DateTime dt;
                        if (DateTime.TryParse(this.Text, GlobalCommon.Culture, DateTimeStyles.None, out dt))
                        {
                            isdatetime = true;
                        }
                    }
                    else
                    {
                        DateTime dt;
                        if (DateTime.TryParse(this.Text, GlobalCommon.Culture, DateTimeStyles.None, out dt))
                        {
                            isdatetime = true;
                        }

                    }
                }
            }
            catch
            {
                isdatetime = false;
            }
        }
        public string MyName
        {
            get;
            set;
        }
        public string Value_Error
        {
            get { return " - Định dạng Ngày tháng sai, bạn vui lòng nhập lại ô '" + MyName + "'; \n - Ngày tháng có dạng dd/mm/yyyy; \n - Chú ý những tháng không có ngày 30, 31"; }
        }

        public string Value_String
        {
            get
            {
                DateTime dt;
                if (DateTime.TryParse(this.Text, GlobalCommon.Culture, DateTimeStyles.None, out dt))
                {
                    return this.Text;
                }
                else
                    return string.Empty;
            }
            set {
                DateTime dt;
                if (DateTime.TryParse(value, GlobalCommon.Culture, DateTimeStyles.None, out dt))
                {
                    this.Text = value;
                }
                else
                    this.Text = string.Empty;
            }
        }

        public DateTime Value
        {
            get {
                DateTime dt;
                if (DateTime.TryParse(this.Text, GlobalCommon.Culture, DateTimeStyles.None, out dt))
                {
                    return dt;
                }
                else
                    return DateTime.MinValue;
            }
            set {
                this.Text = value.ToShortDateString();
            }

        }

    }
}

