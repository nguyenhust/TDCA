using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETLINK.LIB
{
    public class FormMode
    {
        /// <summary>
        /// Insert = true;
        /// </summary>
        public FormMode()
        {
            Item = null;
            Id = -1;
            IsInsert = true;
            Permission = new NETLINK_Permission();
            FormID = string.Empty;
        }
        public FormMode(object item)
        {
            Item = item;
            Id = -1;
            Id64 = -1;
            IsInsert = true;
            Permission = new NETLINK_Permission();
            FormID = string.Empty;
        }
        public string FormID { get; set; }
        private bool isDelete = false;
        private bool isEdit = false;
        private bool isInsert = false;
        public int Id { get; set; }
        public long Id64 { get; set; }

        public string StringId { get; set;}

        public object Item { get; set; }
        public object ItemInfo { get; set; }
        public object ItemColl { get; set; }
        public bool IsDelete
        {
            get { return isDelete; }
            set { isDelete = value; isEdit = false; isInsert = false; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; isDelete = false; isInsert = false; }
        }
        public bool IsEnable { get; set; }
        public bool IsInsert
        {
            get { return isInsert; }
            set
            {
                isInsert = value; isDelete = false;
                isEdit = false;
            }
        }
        public System.EventHandler CloseFormEvent { get; set; }
        public NETLINK_Permission Permission { get; set; }
    }
}
