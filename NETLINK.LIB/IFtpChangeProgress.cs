using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETLINK.LIB
{
    public interface IFtpChangeProgress
    {
        void ChangeProgress(int percent);
    }
}
