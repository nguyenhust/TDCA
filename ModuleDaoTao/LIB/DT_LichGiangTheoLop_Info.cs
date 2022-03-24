using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    [Serializable]
    public partial class DT_LichGiangTheoLop_Info : ReadOnlyBase<DT_LichGiangTheoLop_Info>
    {
        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        public Int64 IDLichGiang { get; private set; }

        public string MaLop { get; private set; }

        public string TenLop { get; private set; }

        public SmartDate NgayBatDau { get; private set; }

        public SmartDate NgayKetThuc { get; private set; }

        public int SoTietLyThuyet { get; private set; }

        public int SoTietThucHanh { get; private set; }

        public SmartDate NgayTao { get; private set; }

        #endregion

        #region Factory Methods

        internal static DT_LichGiangTheoLop_Info GetDT_LichGiangTheoLop_Info(SafeDataReader dr)
        {
            DT_LichGiangTheoLop_Info obj = new DT_LichGiangTheoLop_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        private DT_LichGiangTheoLop_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="DT_LichGiangTheoLop_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            IDLichGiang = dr.GetInt64("IDLichGiang");
            MaLop = dr.GetString("MaLop");
            TenLop = dr.GetString("TenLop");
            NgayBatDau = dr.GetSmartDate("NgayBatDau");
            NgayKetThuc = dr.GetSmartDate("NgayKetThuc");
            SoTietLyThuyet = dr.GetInt32("SoTietLyThuyet");
            SoTietThucHanh = dr.GetInt32("SoTietThucHanh");
            NgayTao = dr.GetSmartDate("NgayTao");
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        #endregion

        #region Pseudo Events

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        #endregion
    }
}
