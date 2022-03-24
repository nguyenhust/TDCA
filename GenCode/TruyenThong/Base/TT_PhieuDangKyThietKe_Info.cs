//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    TT_PhieuDangKyThietKe_Info
// ObjectType:  TT_PhieuDangKyThietKe_Info
// CSLAType:    ReadOnlyObject

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace TruyenThong
{

    /// <summary>
    /// TT_PhieuDangKyThietKe_Info (read only object).<br/>
    /// This is a generated base class of <see cref="TT_PhieuDangKyThietKe_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="TT_PhieuDangKyThietKe_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class TT_PhieuDangKyThietKe_Info : ReadOnlyBase<TT_PhieuDangKyThietKe_Info>
    {

        #region Business Properties

        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID { get; private set; }

        /// <summary>
        /// Gets the Noi Dung.
        /// </summary>
        /// <value>The Noi Dung.</value>
        public string NoiDung { get; private set; }

        /// <summary>
        /// Gets the IDLoai.
        /// </summary>
        /// <value>The IDLoai.</value>
        public int IDLoai { get; private set; }

        /// <summary>
        /// Maintains metadata about <see cref="TuNgay"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> TuNgayProperty = RegisterProperty<SmartDate>(p => p.TuNgay, "Tu Ngay", null);
        /// <summary>
        /// Gets the Tu Ngay.
        /// </summary>
        /// <value>The Tu Ngay.</value>
        public string TuNgay
        {
            get { return GetPropertyConvert<SmartDate, String>(TuNgayProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DenNgay"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> DenNgayProperty = RegisterProperty<SmartDate>(p => p.DenNgay, "Den Ngay", null);
        /// <summary>
        /// Gets the Den Ngay.
        /// </summary>
        /// <value>The Den Ngay.</value>
        public string DenNgay
        {
            get { return GetPropertyConvert<SmartDate, String>(DenNgayProperty); }
        }

        /// <summary>
        /// Gets the IDCan Bo.
        /// </summary>
        /// <value>The IDCan Bo.</value>
        public Int64 IDCanBo { get; private set; }

        /// <summary>
        /// Gets the SLYeu Cau.
        /// </summary>
        /// <value>The SLYeu Cau.</value>
        public int? SLYeuCau { get; private set; }

        /// <summary>
        /// Gets the SLDuyet.
        /// </summary>
        /// <value>The SLDuyet.</value>
        public int? SLDuyet { get; private set; }

        /// <summary>
        /// Gets the Tinh Trang.
        /// </summary>
        /// <value>The Tinh Trang.</value>
        public int? TinhTrang { get; private set; }

        /// <summary>
        /// Gets the Ghi Chu.
        /// </summary>
        /// <value>The Ghi Chu.</value>
        public string GhiChu { get; private set; }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="TT_PhieuDangKyThietKe_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="TT_PhieuDangKyThietKe_Info"/> object.</returns>
        internal static TT_PhieuDangKyThietKe_Info GetTT_PhieuDangKyThietKe_Info(SafeDataReader dr)
        {
            TT_PhieuDangKyThietKe_Info obj = new TT_PhieuDangKyThietKe_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TT_PhieuDangKyThietKe_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TT_PhieuDangKyThietKe_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="TT_PhieuDangKyThietKe_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            ID = data.ID;
            NoiDung = data.NoiDung;
            IDLoai = data.IDLoai;
            LoadProperty(TuNgayProperty, data.TuNgay);
            LoadProperty(DenNgayProperty, data.DenNgay);
            IDCanBo = data.IDCanBo;
            SLYeuCau = data.SLYeuCau;
            SLDuyet = data.SLDuyet;
            TinhTrang = data.TinhTrang;
            GhiChu = data.GhiChu;
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
