//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DIC_Tinh_Info
// ObjectType:  DIC_Tinh_Info
// CSLAType:    ReadOnlyObject

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace TruyenThong.LIB
{

    /// <summary>
    /// DIC_Tinh_Info (read only object).<br/>
    /// This is a generated base class of <see cref="DIC_Tinh_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DIC_Tinh_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DIC_Tinh_Info : ReadOnlyBase<DIC_Tinh_Info>
    {

        #region Business Properties

        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID { get; private set; }

        /// <summary>
        /// Gets the Ma.
        /// </summary>
        /// <value>The Ma.</value>
        public string Ma { get; private set; }

        /// <summary>
        /// Gets the Ma DK.
        /// </summary>
        /// <value>The Ma DK.</value>
        public string MaDK { get; private set; }

        /// <summary>
        /// Gets the Tieu De.
        /// </summary>
        /// <value>The Tieu De.</value>
        public string TieuDe { get; private set; }

        /// <summary>
        /// Gets the Ten.
        /// </summary>
        /// <value>The Ten.</value>
        public string Ten { get; private set; }

        /// <summary>
        /// Gets the IDRefer.
        /// </summary>
        /// <value>The IDRefer.</value>
        public Int64? IDRefer { get; private set; }

        /// <summary>
        /// Gets the Su Dung.
        /// </summary>
        /// <value><c>true</c> if Su Dung; <c>false</c> if not Su Dung; otherwise, <c>null</c>.</value>
        public bool? SuDung { get; private set; }

        /// <summary>
        /// Gets the Ghi Chu.
        /// </summary>
        /// <value>The Ghi Chu.</value>
        public string GhiChu { get; private set; }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_Tinh_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DIC_Tinh_Info"/> object.</returns>
        internal static DIC_Tinh_Info GetDIC_Tinh_Info(SafeDataReader dr)
        {
            DIC_Tinh_Info obj = new DIC_Tinh_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_Tinh_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_Tinh_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="DIC_Tinh_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            ID = data.ID;
            Ma = data.Ma;
            MaDK = data.MaDK;
            TieuDe = data.TieuDe;
            Ten = data.Ten;
            IDRefer = data.IDRefer;
            SuDung = data.SuDung;
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