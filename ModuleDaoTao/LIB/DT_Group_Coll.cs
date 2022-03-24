using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModuleDaoTao.LIB
{
    class DT_Group_Coll : List<DT_Group>
    {
        public static DT_Group_Coll GetAllGroup() {

            DT_Group_Coll coll = new DT_Group_Coll();
            coll.Add(new DT_Group(1, "Nhóm 1"));
            coll.Add(new DT_Group(2, "Nhóm 2"));
            coll.Add(new DT_Group(3, "Nhóm 3"));
            coll.Add(new DT_Group(4, "Nhóm 4"));
            coll.Add(new DT_Group(5, "Nhóm 5"));

            return coll;
        }
    }
}
