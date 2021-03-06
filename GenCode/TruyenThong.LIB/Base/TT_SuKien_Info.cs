//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    TT_SuKien_Info
// ObjectType:  TT_SuKien_Info
// CSLAType:    ReadOnlyObject

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace TruyenThong.LIB
{

    /// <summary>
    /// TT_SuKien_Info (read only object).<br/>
    /// This is a generated base class of <see cref="TT_SuKien_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="TT_SuKien_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class TT_SuKien_Info : ReadOnlyBase<TT_SuKien_Info>
    {

        #region Static Fields

        private static Int64 _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID { get; private set; }

        /// <summary>
        /// Gets the Ten.
        /// </summary>
        /// <value>The Ten.</value>
        public string Ten { get; private set; }

        /// <summary>
        /// Gets the IDChuyen Nganh.
        /// </summary>
        /// <value>The IDChuyen Nganh.</value>
        public int IDChuyenNganh { get; private set; }

        /// <summary>
        /// Gets the Dia Diem.
        /// </summary>
        /// <value>The Dia Diem.</value>
        public string DiaDiem { get; private set; }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGian"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianProperty = RegisterProperty<SmartDate>(p => p.ThoiGian, "Thoi Gian", null);
        /// <summary>
        /// Gets the Thoi Gian.
        /// </summary>
        /// <value>The Thoi Gian.</value>
        public string ThoiGian
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianProperty); }
        }

        /// <summary>
        /// Gets the IDLoai.
        /// </summary>
        /// <value>The IDLoai.</value>
        public int IDLoai { get; private set; }

        /// <summary>
        /// Gets the Chu Tri.
        /// </summary>
        /// <value>The Chu Tri.</value>
        public string ChuTri { get; private set; }

        /// <summary>
        /// Gets the Ghi Chu.
        /// </summary>
        /// <value>The Ghi Chu.</value>
        public string GhiChu { get; private set; }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="TT_SuKien_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="TT_SuKien_Info"/> object.</returns>
        internal static TT_SuKien_Info GetTT_SuKien_Info(SafeDataReader dr)
        {
            TT_SuKien_Info obj = new TT_SuKien_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TT_SuKien_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TT_SuKien_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="TT_SuKien_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            ID = data.ID;
            Ten = data.Ten;
            IDChuyenNganh = data.IDChuyenNganh;
            DiaDiem = data.DiaDiem;
            LoadProperty(ThoiGianProperty, data.ThoiGian);
            IDLoai = data.IDLoai;
            ChuTri = data.ChuTri;
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
