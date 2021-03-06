//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    ADM_NhomChucNang_Info
// ObjectType:  ADM_NhomChucNang_Info
// CSLAType:    ReadOnlyObject

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace Authoration.LIB
{

    /// <summary>
    /// ADM_NhomChucNang_Info (read only object).<br/>
    /// This is a generated base class of <see cref="ADM_NhomChucNang_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="ADM_NhomChucNang_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class ADM_NhomChucNang_Info : ReadOnlyBase<ADM_NhomChucNang_Info>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public int ID { get; private set; }

        /// <summary>
        /// Gets the Ma.
        /// </summary>
        /// <value>The Ma.</value>
        public string Ma { get; private set; }

        /// <summary>
        /// Gets the IDPhan He.
        /// </summary>
        /// <value>The IDPhan He.</value>
        public int IDPhanHe { get; private set; }

        /// <summary>
        /// Gets the Ten Nhom CN.
        /// </summary>
        /// <value>The Ten Nhom CN.</value>
        public string TenNhomCN { get; private set; }

        /// <summary>
        /// Gets the Ten phan he.
        /// </summary>
        /// <value>The Ten pha he.</value>
        public string TenPhanHe { get; private set; }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="ADM_NhomChucNang_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="ADM_NhomChucNang_Info"/> object.</returns>
        internal static ADM_NhomChucNang_Info GetADM_NhomChucNang_Info(SafeDataReader dr)
        {
            ADM_NhomChucNang_Info obj = new ADM_NhomChucNang_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ADM_NhomChucNang_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public ADM_NhomChucNang_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="ADM_NhomChucNang_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            ID = dr.GetInt32("ID");
            Ma = dr.GetString("Ma");
            IDPhanHe = dr.GetInt32("IDPhanHe");
            TenNhomCN = dr.GetString("TenNhomCN");
            TenPhanHe = dr.GetString("TenPhanHe");
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
