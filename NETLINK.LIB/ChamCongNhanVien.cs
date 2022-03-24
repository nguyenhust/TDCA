using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETLINK.LIB
{
    public class ChamCongNhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string Phong { get; set; }
        public float Gio { get; set; }
        public float Cong { get; set; }
        public float Ngoaigio { get; set; }
        public string chunhat { get; set; }
        public int VeSom { get; set; }
        public int VeTre { get; set; }
        public int VangKoPhep { get; set; }
        public int VangCoPhep { get; set; }
        public int Phuttre { get; set; }
        public int PhutSom { get; set; }

        public ArrayList ngayCong { get; set; }

        public ChamCongNhanVien() {
            ngayCong = new ArrayList();
        }

        public bool Equals(ChamCongNhanVien other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.MaNhanVien == MaNhanVien;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ChamCongNhanVien)) return false;
            return Equals((ChamCongNhanVien)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return MaNhanVien.GetHashCode();
            }
        }
    }
}

