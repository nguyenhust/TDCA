using System;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable]
    public partial class HoanTamThuInfocs : ReadOnlyBase<HoanTamThuInfocs>
    {
        #region Business Properties

        /// <summary>
        /// Gets the IDPhieu Hoan.
        /// </summary>
        /// <value>The IDPhieu Hoan.</value>
        public Int64 IDPhieuHoan { get; private set; }

        /// <summary>
        /// ID dieu tri ma benh nhan dang nam dieu tri thuc hien hoan
        /// </summary>
        /// <value>The IDHocVien.</value>
        public Int64 IDHocVien { get; private set; }

        /// <summary>
        /// So phieu hoan ky quy: yymmdd-99999
        /// </summary>
        /// <value>The So Phieu Hoan.</value>
        public string SoPhieuHoan { get; private set; }

        /// <summary>
        /// Gets the So Tien.
        /// </summary>
        /// <value>The So Tien.</value>
        public Decimal SoTien { get; private set; }

        /// <summary>
        /// Maintains metadata about <see cref="NgayHoan"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayHoanProperty = RegisterProperty<SmartDate>(p => p.NgayHoan, "Ngay Hoan");
        /// <summary>
        /// Gets the Ngay Hoan.
        /// </summary>
        /// <value>The Ngay Hoan.</value>
        public string NgayHoan
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayHoanProperty); }
        }

        /// <summary>
        /// ID nguoi su dung hoan ky quy
        /// </summary>
        /// <value>The IDNguoi Hoan.</value>
        public Int64 IDNguoiHoan { get; private set; }


        /// <summary>
        /// Gets the Nguoi Nhan.
        /// </summary>
        /// <value>The Nguoi Nhan.</value>
        public string NguoiNhan { get; private set; }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="IP_HoanKyQuy_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_HoanKyQuy_Info"/> object.</returns>
        internal static HoanTamThuInfocs GetHoanTamThuInfocs(SafeDataReader dr)
        {
            HoanTamThuInfocs obj = new HoanTamThuInfocs();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_HoanKyQuy_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HoanTamThuInfocs()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="IP_HoanKyQuy_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            IDPhieuHoan = dr.GetInt64("IDPhieuHoan");
            IDHocVien = dr.GetInt64("IDHocVien");
            SoPhieuHoan = dr.GetString("SoPhieuHoan");
            SoTien = dr.GetDecimal("SoTien");
            LoadProperty(NgayHoanProperty, dr.GetDateTime("NgayHoan"));
            IDNguoiHoan = dr.GetInt64("IDNguoiHoan");
            NguoiNhan = dr.GetString("NguoiNhan");
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
