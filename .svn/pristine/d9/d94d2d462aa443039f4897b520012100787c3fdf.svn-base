using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETLINK.LIB
{
    public class BusinessFunction
    {
        public BusinessFunction(BusinessFunctionMode mode)
        {
            Mode = mode;
            Permission = new NETLINK_Permission();
        }
        public BusinessFunction(BusinessFunctionMode mode, int itemID)
        {
            Mode = mode;
            ItemID = itemID;
            Permission = new NETLINK_Permission();
        }
        public BusinessFunction(BusinessFunctionMode mode, object item)
        {
            Mode = mode;
            this.Item = item;
            Permission = new NETLINK_Permission();
        }
        public BusinessFunctionMode Mode { get; set; }
        public int ItemID { get; set; }
        public int ItemSoNam { get; set; }
        public DateTime ItemNgayBatDau { get; set; }
        public object Item { get; set; }
        public DateTime ItemFilterCondition_Date { get; set; }
        public DateTime ItemFilterCondition_Date2 { get; set; }
        public string ItemFilterCondition_String { get; set; }
        public string ItemFilterCondition_String2 { get; set; }
        public int ItemFilterCondition_Int { get; set; }
        public string ItemTrangThai { get; set; }
        public int ItemFilterCondition_Int2 { get; set; }
        public string ItemFilterCondition_KemCap { get; set; }
        
        public NETLINK_Permission Permission { get; set; }
    }
}
