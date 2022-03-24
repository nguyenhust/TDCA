using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{
    [Serializable]
    public partial class HC_LichLamViecTheoPhong_Info : ReadOnlyBase<HC_LichLamViecTheoPhong_Info>
    {
        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        public Int64 IDLich{ get; private set; }

        public Int64 IDNguoiDung{ get; private set; }

        public string TenPhong { get; private set; }

        public SmartDate TuNgay { get; private set; }

        public SmartDate DenNgay { get; private set; }

        public string GhiChu { get; private set; }

        public SmartDate NgayTao { get; private set; }

        #endregion

        #region Factory Methods

        internal static HC_LichLamViecTheoPhong_Info GetHC_LichLamViecTheoPhong_Info(SafeDataReader dr)
        {
            HC_LichLamViecTheoPhong_Info obj = new HC_LichLamViecTheoPhong_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        private HC_LichLamViecTheoPhong_Info()
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
            IDLich = dr.GetInt64("IDLich");
            IDNguoiDung = dr.GetInt64("IDNguoiDung");
            TenPhong = dr.GetString("TenLop");
            TuNgay = dr.GetSmartDate("TuNgay");
            DenNgay = dr.GetSmartDate("DenNgay");
            GhiChu = dr.GetString("GhiChu");
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
