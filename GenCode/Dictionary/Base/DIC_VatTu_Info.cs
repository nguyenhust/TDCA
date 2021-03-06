//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DIC_VatTu_Info
// ObjectType:  DIC_VatTu_Info
// CSLAType:    ReadOnlyObject

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Dictionary
{

    /// <summary>
    /// DIC_VatTu_Info (read only object).<br/>
    /// This is a generated base class of <see cref="DIC_VatTu_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DIC_VatTu_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DIC_VatTu_Info : ReadOnlyBase<DIC_VatTu_Info>
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
        /// Gets the Ma.
        /// </summary>
        /// <value>The Ma.</value>
        public string Ma { get; private set; }

        /// <summary>
        /// Gets the IDLoai.
        /// </summary>
        /// <value>The IDLoai.</value>
        public int IDLoai { get; private set; }

        /// <summary>
        /// Gets the IDDon Vi Tinh.
        /// </summary>
        /// <value>The IDDon Vi Tinh.</value>
        public int IDDonViTinh { get; private set; }

        /// <summary>
        /// Gets the Mau Sac.
        /// </summary>
        /// <value>The Mau Sac.</value>
        public string MauSac { get; private set; }

        /// <summary>
        /// Gets the Nha SX.
        /// </summary>
        /// <value>The Nha SX.</value>
        public string NhaSX { get; private set; }

        /// <summary>
        /// Gets the Nguon Goc Xuat Xu.
        /// </summary>
        /// <value>The Nguon Goc Xuat Xu.</value>
        public string NguonGocXuatXu { get; private set; }

        /// <summary>
        /// Gets the Don Gia.
        /// </summary>
        /// <value>The Don Gia.</value>
        public Decimal DonGia { get; private set; }

        /// <summary>
        /// Gets the Phu Kien.
        /// </summary>
        /// <value>The Phu Kien.</value>
        public string PhuKien { get; private set; }

        /// <summary>
        /// Gets the Serial.
        /// </summary>
        /// <value>The Serial.</value>
        public string Serial { get; private set; }

        /// <summary>
        /// Maintains metadata about <see cref="NgayTao"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayTaoProperty = RegisterProperty<SmartDate>(p => p.NgayTao, "Ngay Tao");
        /// <summary>
        /// Gets the Ngay Tao.
        /// </summary>
        /// <value>The Ngay Tao.</value>
        public string NgayTao
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayTaoProperty); }
        }

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
        /// Factory method. Loads a <see cref="DIC_VatTu_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DIC_VatTu_Info"/> object.</returns>
        internal static DIC_VatTu_Info GetDIC_VatTu_Info(SafeDataReader dr)
        {
            DIC_VatTu_Info obj = new DIC_VatTu_Info();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_VatTu_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_VatTu_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="DIC_VatTu_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            ID = data.ID;
            Ten = data.Ten;
            Ma = data.Ma;
            IDLoai = data.IDLoai;
            IDDonViTinh = data.IDDonViTinh;
            MauSac = data.MauSac;
            NhaSX = data.NhaSX;
            NguonGocXuatXu = data.NguonGocXuatXu;
            DonGia = data.DonGia;
            PhuKien = data.PhuKien;
            Serial = data.Serial;
            LoadProperty(NgayTaoProperty, data.NgayTao);
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
