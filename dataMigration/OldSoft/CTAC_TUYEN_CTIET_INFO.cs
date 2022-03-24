//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CTAC_TUYEN_CTIET_INFO
// ObjectType:  CTAC_TUYEN_CTIET_INFO
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
namespace oldSoft
{

    /// <summary>
    /// CTAC_TUYEN_CTIET_INFO (editable child object).<br/>
    /// This is a generated base class of <see cref="CTAC_TUYEN_CTIET_INFO"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="CTAC_TUYEN_CTIET_COLL"/> collection.
    /// </remarks>
    [Serializable]
    public partial class CTAC_TUYEN_CTIET_INFO : BusinessBase<CTAC_TUYEN_CTIET_INFO>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="CTAC_TUYEN_CTIET_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> CTAC_TUYEN_CTIET_IDProperty = RegisterProperty<int>(p => p.CTAC_TUYEN_CTIET_ID, "CTAC TUYEN CTIET ID");
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.CTAC_TUYEN_CTIET_ID
        /// </summary>
        /// <value>The CTAC TUYEN CTIET ID.</value>
        public int CTAC_TUYEN_CTIET_ID
        {
            get { return GetProperty(CTAC_TUYEN_CTIET_IDProperty); }
            set { SetProperty(CTAC_TUYEN_CTIET_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CONGTAC_TUYEN_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> CONGTAC_TUYEN_IDProperty = RegisterProperty<int>(p => p.CONGTAC_TUYEN_ID, "CONGTAC TUYEN ID");
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.CONGTAC_TUYEN_ID
        /// </summary>
        /// <value>The CONGTAC TUYEN ID.</value>
        public int CONGTAC_TUYEN_ID
        {
            get { return GetProperty(CONGTAC_TUYEN_IDProperty); }
            set { SetProperty(CONGTAC_TUYEN_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NHAN_VIEN_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> NHAN_VIEN_IDProperty = RegisterProperty<int?>(p => p.NHAN_VIEN_ID, "NHAN VIEN ID", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.NHAN_VIEN_ID
        /// </summary>
        /// <value>The NHAN VIEN ID.</value>
        public int? NHAN_VIEN_ID
        {
            get { return GetProperty(NHAN_VIEN_IDProperty); }
            set { SetProperty(NHAN_VIEN_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NGAY_BDAU"/> property.
        /// </summary>
        public static readonly PropertyInfo<Object> NGAY_BDAUProperty = RegisterProperty<Object>(p => p.NGAY_BDAU, "NGAY BDAU");
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.NGAY_BDAU
        /// </summary>
        /// <value>The NGAY BDAU.</value>
        public Object NGAY_BDAU
        {
            get { return GetProperty(NGAY_BDAUProperty); }
            set { SetProperty(NGAY_BDAUProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NGAY_KTHUC"/> property.
        /// </summary>
        public static readonly PropertyInfo<Object> NGAY_KTHUCProperty = RegisterProperty<Object>(p => p.NGAY_KTHUC, "NGAY KTHUC");
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.NGAY_KTHUC
        /// </summary>
        /// <value>The NGAY KTHUC.</value>
        public Object NGAY_KTHUC
        {
            get { return GetProperty(NGAY_KTHUCProperty); }
            set { SetProperty(NGAY_KTHUCProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_LOAIHINH"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_LOAIHINHProperty = RegisterProperty<string>(p => p.MA_LOAIHINH, "MA LOAIHINH", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.MA_LOAIHINH
        /// </summary>
        /// <value>The MA LOAIHINH.</value>
        public string MA_LOAIHINH
        {
            get { return GetProperty(MA_LOAIHINHProperty); }
            set { SetProperty(MA_LOAIHINHProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NOI_DUNG"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NOI_DUNGProperty = RegisterProperty<string>(p => p.NOI_DUNG, "NOI DUNG", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.NOI_DUNG
        /// </summary>
        /// <value>The NOI DUNG.</value>
        public string NOI_DUNG
        {
            get { return GetProperty(NOI_DUNGProperty); }
            set { SetProperty(NOI_DUNGProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GHI_CHU"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GHI_CHUProperty = RegisterProperty<string>(p => p.GHI_CHU, "GHI CHU", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.GHI_CHU
        /// </summary>
        /// <value>The GHI CHU.</value>
        public string GHI_CHU
        {
            get { return GetProperty(GHI_CHUProperty); }
            set { SetProperty(GHI_CHUProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_BOPHAN_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> MA_BOPHAN_IDProperty = RegisterProperty<int?>(p => p.MA_BOPHAN_ID, "MA BOPHAN ID", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.MA_BOPHAN_ID
        /// </summary>
        /// <value>The MA BOPHAN ID.</value>
        public int? MA_BOPHAN_ID
        {
            get { return GetProperty(MA_BOPHAN_IDProperty); }
            set { SetProperty(MA_BOPHAN_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_CB"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_CBProperty = RegisterProperty<string>(p => p.TEN_CB, "TEN CB");
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.TEN_CB
        /// </summary>
        /// <value>The TEN CB.</value>
        public string TEN_CB
        {
            get { return GetProperty(TEN_CBProperty); }
            set { SetProperty(TEN_CBProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CHUC_VU"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> CHUC_VUProperty = RegisterProperty<string>(p => p.CHUC_VU, "CHUC VU", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.CHUC_VU
        /// </summary>
        /// <value>The CHUC VU.</value>
        public string CHUC_VU
        {
            get { return GetProperty(CHUC_VUProperty); }
            set { SetProperty(CHUC_VUProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TRINH_DO"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TRINH_DOProperty = RegisterProperty<string>(p => p.TRINH_DO, "TRINH DO", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.TRINH_DO
        /// </summary>
        /// <value>The TRINH DO.</value>
        public string TRINH_DO
        {
            get { return GetProperty(TRINH_DOProperty); }
            set { SetProperty(TRINH_DOProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NAM_SINHCB"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> NAM_SINHCBProperty = RegisterProperty<int?>(p => p.NAM_SINHCB, "NAM SINHCB", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.NAM_SINHCB
        /// </summary>
        /// <value>The NAM SINHCB.</value>
        public int? NAM_SINHCB
        {
            get { return GetProperty(NAM_SINHCBProperty); }
            set { SetProperty(NAM_SINHCBProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SO_QD"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> SO_QDProperty = RegisterProperty<string>(p => p.SO_QD, "SO QD", null);
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.SO_QD
        /// </summary>
        /// <value>The SO QD.</value>
        public string SO_QD
        {
            get { return GetProperty(SO_QDProperty); }
            set { SetProperty(SO_QDProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="SO_QD"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> MA_BVIEN_IDProperty = RegisterProperty<int>(p => p.MA_BVIEN_ID, "SO QD");
        /// <summary>
        /// CDT.CTAC_TUYEN_CTIET.SO_QD
        /// </summary>
        /// <value>The SO QD.</value>
        public int MA_BVIEN_ID
        {
            get { return GetProperty(MA_BVIEN_IDProperty); }
            set { SetProperty(MA_BVIEN_IDProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="CTAC_TUYEN_CTIET_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="CTAC_TUYEN_CTIET_INFO"/> object.</returns>
        internal static CTAC_TUYEN_CTIET_INFO GetCTAC_TUYEN_CTIET_INFO(SafeDataReader dr)
        {
            CTAC_TUYEN_CTIET_INFO obj = new CTAC_TUYEN_CTIET_INFO();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CTAC_TUYEN_CTIET_INFO"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CTAC_TUYEN_CTIET_INFO()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="CTAC_TUYEN_CTIET_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            //LoadProperty(CTAC_TUYEN_CTIET_IDProperty, data.CTAC_TUYEN_CTIET_ID);
            //LoadProperty(CONGTAC_TUYEN_IDProperty, data.CONGTAC_TUYEN_ID);
            //LoadProperty(NHAN_VIEN_IDProperty, data.NHAN_VIEN_ID);
            LoadProperty(MA_BVIEN_IDProperty, dr.GetInt32("MA_BVIEN_ID"));
            LoadProperty(NGAY_BDAUProperty, dr.GetDateTime("TU_NGAY"));
            LoadProperty(NGAY_KTHUCProperty, dr.GetDateTime("DEN_NGAY"));
            //LoadProperty(MA_LOAIHINHProperty, data.MA_LOAIHINH);
            LoadProperty(NOI_DUNGProperty, dr.GetString("Expr2"));
            LoadProperty(GHI_CHUProperty, dr.GetString("GHI_CHU"));
            //LoadProperty(MA_BOPHAN_IDProperty, data.MA_BOPHAN_ID);
            LoadProperty(TEN_CBProperty, dr.GetString("TEN_CB"));
            LoadProperty(CHUC_VUProperty, dr.GetString("CHUC_VU"));
            LoadProperty(TRINH_DOProperty, dr.GetString("TRINH_DO"));
            //LoadProperty(NAM_SINHCBProperty, data.NAM_SINHCB);
            LoadProperty(SO_QDProperty, dr.GetString("Expr3"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CTAC_TUYEN_CTIET_INFO"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.CTAC_TUYEN_CTIET_INFO_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CTAC_TUYEN_CTIET_ID", ReadProperty(CTAC_TUYEN_CTIET_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CONGTAC_TUYEN_ID", ReadProperty(CONGTAC_TUYEN_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NHAN_VIEN_ID", ReadProperty(NHAN_VIEN_IDProperty) == null ? (object)DBNull.Value : ReadProperty(NHAN_VIEN_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NGAY_BDAU", ReadProperty(NGAY_BDAUProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@NGAY_KTHUC", ReadProperty(NGAY_KTHUCProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@MA_LOAIHINH", ReadProperty(MA_LOAIHINHProperty) == null ? (object)DBNull.Value : ReadProperty(MA_LOAIHINHProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NOI_DUNG", ReadProperty(NOI_DUNGProperty) == null ? (object)DBNull.Value : ReadProperty(NOI_DUNGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GHI_CHU", ReadProperty(GHI_CHUProperty) == null ? (object)DBNull.Value : ReadProperty(GHI_CHUProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_BOPHAN_ID", ReadProperty(MA_BOPHAN_IDProperty) == null ? (object)DBNull.Value : ReadProperty(MA_BOPHAN_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TEN_CB", ReadProperty(TEN_CBProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CHUC_VU", ReadProperty(CHUC_VUProperty) == null ? (object)DBNull.Value : ReadProperty(CHUC_VUProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TRINH_DO", ReadProperty(TRINH_DOProperty) == null ? (object)DBNull.Value : ReadProperty(TRINH_DOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NAM_SINHCB", ReadProperty(NAM_SINHCBProperty) == null ? (object)DBNull.Value : ReadProperty(NAM_SINHCBProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SO_QD", ReadProperty(SO_QDProperty) == null ? (object)DBNull.Value : ReadProperty(SO_QDProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CTAC_TUYEN_CTIET_INFO"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.CTAC_TUYEN_CTIET_INFO_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CTAC_TUYEN_CTIET_ID", ReadProperty(CTAC_TUYEN_CTIET_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CONGTAC_TUYEN_ID", ReadProperty(CONGTAC_TUYEN_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NHAN_VIEN_ID", ReadProperty(NHAN_VIEN_IDProperty) == null ? (object)DBNull.Value : ReadProperty(NHAN_VIEN_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NGAY_BDAU", ReadProperty(NGAY_BDAUProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@NGAY_KTHUC", ReadProperty(NGAY_KTHUCProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@MA_LOAIHINH", ReadProperty(MA_LOAIHINHProperty) == null ? (object)DBNull.Value : ReadProperty(MA_LOAIHINHProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NOI_DUNG", ReadProperty(NOI_DUNGProperty) == null ? (object)DBNull.Value : ReadProperty(NOI_DUNGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GHI_CHU", ReadProperty(GHI_CHUProperty) == null ? (object)DBNull.Value : ReadProperty(GHI_CHUProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_BOPHAN_ID", ReadProperty(MA_BOPHAN_IDProperty) == null ? (object)DBNull.Value : ReadProperty(MA_BOPHAN_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TEN_CB", ReadProperty(TEN_CBProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CHUC_VU", ReadProperty(CHUC_VUProperty) == null ? (object)DBNull.Value : ReadProperty(CHUC_VUProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TRINH_DO", ReadProperty(TRINH_DOProperty) == null ? (object)DBNull.Value : ReadProperty(TRINH_DOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NAM_SINHCB", ReadProperty(NAM_SINHCBProperty) == null ? (object)DBNull.Value : ReadProperty(NAM_SINHCBProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SO_QD", ReadProperty(SO_QDProperty) == null ? (object)DBNull.Value : ReadProperty(SO_QDProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CTAC_TUYEN_CTIET_INFO"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.CTAC_TUYEN_CTIET_INFO_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    var args = new DataPortalHookArgs(cmd);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
            }
        }

        #endregion

        #region Pseudo Events

        /// <summary>
        /// Occurs in DataPortal_Delete, after setting query parameters and before the delete operation.
        /// </summary>
        partial void OnDeletePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after the delete operation, before Commit().
        /// </summary>
        partial void OnDeletePost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the update operation.
        /// </summary>
        partial void OnUpdatePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the update operation, before setting back row identifiers (RowVersion) and Commit().
        /// </summary>
        partial void OnUpdatePost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after setting query parameters and before the insert operation.
        /// </summary>
        partial void OnInsertPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the insert operation, before setting back row identifiers (ID and RowVersion) and Commit().
        /// </summary>
        partial void OnInsertPost(DataPortalHookArgs args);

        #endregion

    }
}