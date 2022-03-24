//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    TT_BaiViet_Info
// ObjectType:  TT_BaiViet_Info
// CSLAType:    ReadOnlyObject

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace TruyenThong.LIB
{

    /// <summary>
    /// TT_BaiViet_Info (read only object).<br/>
    /// This is a generated base class of <see cref="TT_BaiViet_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="TT_BaiViet_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class TT_BaiViet_Info : ReadOnlyBase<TT_BaiViet_Info>
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
        /// Gets the Tac Gia.
        /// </summary>
        /// <value>The Tac Gia.</value>
        public string TacGia { get; private set; }

        /// <summary>
        /// Gets the Tieu De.
        /// </summary>
        /// <value>The Tieu De.</value>
        public string TieuDe { get; private set; }

        /// <summary>
        /// Gets the Noi Dung.
        /// </summary>
        /// <value>The Noi Dung.</value>
        public string NoiDung { get; private set; }

        /// <summary>
        /// Gets the IDLoai.
        /// </summary>
        /// <value>The IDLoai.</value>
        public int? IDLoai { get; private set; }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianDang"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianDangProperty = RegisterProperty<SmartDate>(p => p.ThoiGianDang, "Thoi Gian Dang", null);
        /// <summary>
        /// Gets the Thoi Gian Dang.
        /// </summary>
        /// <value>The Thoi Gian Dang.</value>
        public string ThoiGianDang
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianDangProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianDuyet"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianDuyetProperty = RegisterProperty<SmartDate>(p => p.ThoiGianDuyet, "Thoi Gian Duyet", null);
        /// <summary>
        /// Gets the Thoi Gian Duyet.
        /// </summary>
        /// <value>The Thoi Gian Duyet.</value>
        public string ThoiGianDuyet
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianDuyetProperty); }
        }

        /// <summary>
        /// Gets the Nguoi Duyet.
        /// </summary>
        /// <value>The Nguoi Duyet.</value>
        public string NguoiDuyet { get; private set; }

        /// <summary>
        /// Gets the Link.
        /// </summary>
        /// <value>The Link.</value>
        public string Link { get; private set; }

        /// <summary>
        /// Gets the Duong Dan.
        /// </summary>
        /// <value>The Duong Dan.</value>
        public string DuongDan { get; private set; }

        /// <summary>
        /// Gets the Ghi Chu.
        /// </summary>
        /// <value>The Ghi Chu.</value>
        public string GhiChu { get; private set; }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="TT_BaiViet_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="TT_BaiViet_Info"/> object.</returns>
        internal static TT_BaiViet_Info GetTT_BaiViet_Info(SafeDataReader dr)
        {
            TT_BaiViet_Info obj = new TT_BaiViet_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TT_BaiViet_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private TT_BaiViet_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="TT_BaiViet_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            ID = data.ID;
            TacGia = data.TacGia;
            TieuDe = data.TieuDe;
            NoiDung = data.NoiDung;
            IDLoai = data.IDLoai;
            LoadProperty(ThoiGianDangProperty, data.ThoiGianDang);
            LoadProperty(ThoiGianDuyetProperty, data.ThoiGianDuyet);
            NguoiDuyet = data.NguoiDuyet;
            Link = data.Link;
            DuongDan = data.DuongDan;
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
