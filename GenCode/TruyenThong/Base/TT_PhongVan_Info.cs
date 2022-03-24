//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    TT_PhongVan_Info
// ObjectType:  TT_PhongVan_Info
// CSLAType:    ReadOnlyObject

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace TruyenThong
{

    /// <summary>
    /// TT_PhongVan_Info (read only object).<br/>
    /// This is a generated base class of <see cref="TT_PhongVan_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="TT_PhongVan_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class TT_PhongVan_Info : ReadOnlyBase<TT_PhongVan_Info>
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
        /// Gets the Co Quan CT.
        /// </summary>
        /// <value>The Co Quan CT.</value>
        public string CoQuanCT { get; private set; }

        /// <summary>
        /// Gets the Khoa Lam Viec.
        /// </summary>
        /// <value>The Khoa Lam Viec.</value>
        public string KhoaLamViec { get; private set; }

        /// <summary>
        /// Gets the So Giay Gioi Thieu.
        /// </summary>
        /// <value>The So Giay Gioi Thieu.</value>
        public string SoGiayGioiThieu { get; private set; }

        /// <summary>
        /// Gets the So Dien Thoai.
        /// </summary>
        /// <value>The So Dien Thoai.</value>
        public string SoDienThoai { get; private set; }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGian"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianProperty = RegisterProperty<SmartDate>(p => p.ThoiGian, "Thoi Gian");
        /// <summary>
        /// Gets the Thoi Gian.
        /// </summary>
        /// <value>The Thoi Gian.</value>
        public string ThoiGian
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianProperty); }
        }

        /// <summary>
        /// Gets the Ghichu.
        /// </summary>
        /// <value>The Ghichu.</value>
        public string Ghichu { get; private set; }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="TT_PhongVan_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="TT_PhongVan_Info"/> object.</returns>
        internal static TT_PhongVan_Info GetTT_PhongVan_Info(SafeDataReader dr)
        {
            TT_PhongVan_Info obj = new TT_PhongVan_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TT_PhongVan_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TT_PhongVan_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="TT_PhongVan_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            ID = data.ID;
            NoiDung = data.NoiDung;
            CoQuanCT = data.CoQuanCT;
            KhoaLamViec = data.KhoaLamViec;
            SoGiayGioiThieu = data.SoGiayGioiThieu;
            SoDienThoai = data.SoDienThoai;
            LoadProperty(ThoiGianProperty, data.ThoiGian);
            Ghichu = data.Ghichu;
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
