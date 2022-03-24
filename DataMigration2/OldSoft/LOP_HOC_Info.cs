//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    LOP_HOC_INFO
// ObjectType:  LOP_HOC_INFO
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
    /// LOP_HOC_INFO (editable child object).<br/>
    /// This is a generated base class of <see cref="LOP_HOC_INFO"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="LOP_HOC_COLL"/> collection.
    /// </remarks>
    [Serializable]
    public partial class LOP_HOC_INFO : BusinessBase<LOP_HOC_INFO>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="LOP_HOC_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> LOP_HOC_IDProperty = RegisterProperty<int>(p => p.LOP_HOC_ID, "LOP HOC ID");
        /// <summary>
        /// CDT.LOP_HOC.LOP_HOC_ID
        /// </summary>
        /// <value>The LOP HOC ID.</value>
        public int LOP_HOC_ID
        {
            get { return GetProperty(LOP_HOC_IDProperty); }
            set { SetProperty(LOP_HOC_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NAM"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NAMProperty = RegisterProperty<string>(p => p.NAM, "NAM");
        /// <summary>
        /// CDT.LOP_HOC.NAM
        /// </summary>
        /// <value>The NAM.</value>
        public string NAM
        {
            get { return GetProperty(NAMProperty); }
            set { SetProperty(NAMProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_LOP"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_LOPProperty = RegisterProperty<string>(p => p.MA_LOP, "MA LOP");
        /// <summary>
        /// CDT.LOP_HOC.MA_LOP
        /// </summary>
        /// <value>The MA LOP.</value>
        public string MA_LOP
        {
            get { return GetProperty(MA_LOPProperty); }
            set { SetProperty(MA_LOPProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_LOP"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_LOPProperty = RegisterProperty<string>(p => p.TEN_LOP, "TEN LOP");
        /// <summary>
        /// CDT.LOP_HOC.TEN_LOP
        /// </summary>
        /// <value>The TEN LOP.</value>
        public string TEN_LOP
        {
            get { return GetProperty(TEN_LOPProperty); }
            set { SetProperty(TEN_LOPProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NOI_DUNG"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NOI_DUNGProperty = RegisterProperty<string>(p => p.NOI_DUNG, "NOI DUNG");
        /// <summary>
        /// CDT.LOP_HOC.NOI_DUNG
        /// </summary>
        /// <value>The NOI DUNG.</value>
        public string NOI_DUNG
        {
            get { return GetProperty(NOI_DUNGProperty); }
            set { SetProperty(NOI_DUNGProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NGAY_BDAU"/> property.
        /// </summary>
        public static readonly PropertyInfo<Object> NGAY_BDAUProperty = RegisterProperty<Object>(p => p.NGAY_BDAU, "NGAY BDAU");
        /// <summary>
        /// CDT.LOP_HOC.NGAY_BDAU
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
        /// CDT.LOP_HOC.NGAY_KTHUC
        /// </summary>
        /// <value>The NGAY KTHUC.</value>
        public Object NGAY_KTHUC
        {
            get { return GetProperty(NGAY_KTHUCProperty); }
            set { SetProperty(NGAY_KTHUCProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="KP_DTRU"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> KP_DTRUProperty = RegisterProperty<int?>(p => p.KP_DTRU, "KP DTRU");
        /// <summary>
        /// CDT.LOP_HOC.KP_DTRU
        /// </summary>
        /// <value>The KP DTRU.</value>
        public int? KP_DTRU
        {
            get { return GetProperty(KP_DTRUProperty); }
            set { SetProperty(KP_DTRUProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="KP_DUYET"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> KP_DUYETProperty = RegisterProperty<int?>(p => p.KP_DUYET, "KP DUYET");
        /// <summary>
        /// CDT.LOP_HOC.KP_DUYET
        /// </summary>
        /// <value>The KP DUYET.</value>
        public int? KP_DUYET
        {
            get { return GetProperty(KP_DUYETProperty); }
            set { SetProperty(KP_DUYETProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="KP_QTOAN"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> KP_QTOANProperty = RegisterProperty<int?>(p => p.KP_QTOAN, "KP QTOAN");
        /// <summary>
        /// CDT.LOP_HOC.KP_QTOAN
        /// </summary>
        /// <value>The KP QTOAN.</value>
        public int? KP_QTOAN
        {
            get { return GetProperty(KP_QTOANProperty); }
            set { SetProperty(KP_QTOANProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NGAY_QTOAN"/> property.
        /// </summary>
        public static readonly PropertyInfo<Object> NGAY_QTOANProperty = RegisterProperty<Object>(p => p.NGAY_QTOAN, "NGAY QTOAN");
        /// <summary>
        /// CDT.LOP_HOC.NGAY_QTOAN
        /// </summary>
        /// <value>The NGAY QTOAN.</value>
        public Object NGAY_QTOAN
        {
            get { return GetProperty(NGAY_QTOANProperty); }
            set { SetProperty(NGAY_QTOANProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="BP_TCHUC_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> BP_TCHUC_IDProperty = RegisterProperty<int?>(p => p.BP_TCHUC_ID, "BP TCHUC ID");
        /// <summary>
        /// CDT.LOP_HOC.BP_TCHUC_ID
        /// </summary>
        /// <value>The BP TCHUC ID.</value>
        public int? BP_TCHUC_ID
        {
            get { return GetProperty(BP_TCHUC_IDProperty); }
            set { SetProperty(BP_TCHUC_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CQ_TCHUC_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> CQ_TCHUC_IDProperty = RegisterProperty<int?>(p => p.CQ_TCHUC_ID, "CQ TCHUC ID");
        /// <summary>
        /// CDT.LOP_HOC.CQ_TCHUC_ID
        /// </summary>
        /// <value>The CQ TCHUC ID.</value>
        public int? CQ_TCHUC_ID
        {
            get { return GetProperty(CQ_TCHUC_IDProperty); }
            set { SetProperty(CQ_TCHUC_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DOI_TUONG"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DOI_TUONGProperty = RegisterProperty<string>(p => p.DOI_TUONG, "DOI TUONG");
        /// <summary>
        /// CDT.LOP_HOC.DOI_TUONG
        /// </summary>
        /// <value>The DOI TUONG.</value>
        public string DOI_TUONG
        {
            get { return GetProperty(DOI_TUONGProperty); }
            set { SetProperty(DOI_TUONGProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GHI_CHU"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GHI_CHUProperty = RegisterProperty<string>(p => p.GHI_CHU, "GHI CHU");
        /// <summary>
        /// CDT.LOP_HOC.GHI_CHU
        /// </summary>
        /// <value>The GHI CHU.</value>
        public string GHI_CHU
        {
            get { return GetProperty(GHI_CHUProperty); }
            set { SetProperty(GHI_CHUProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CBO_PTRACH_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> CBO_PTRACH_IDProperty = RegisterProperty<int?>(p => p.CBO_PTRACH_ID, "CBO PTRACH ID");
        /// <summary>
        /// CDT.LOP_HOC.CBO_PTRACH_ID
        /// </summary>
        /// <value>The CBO PTRACH ID.</value>
        public int? CBO_PTRACH_ID
        {
            get { return GetProperty(CBO_PTRACH_IDProperty); }
            set { SetProperty(CBO_PTRACH_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CBO_PHOP"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> CBO_PHOPProperty = RegisterProperty<string>(p => p.CBO_PHOP, "CBO PHOP");
        /// <summary>
        /// CDT.LOP_HOC.CBO_PHOP
        /// </summary>
        /// <value>The CBO PHOP.</value>
        public string CBO_PHOP
        {
            get { return GetProperty(CBO_PHOPProperty); }
            set { SetProperty(CBO_PHOPProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TGIAN_DTAO"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TGIAN_DTAOProperty = RegisterProperty<string>(p => p.TGIAN_DTAO, "TGIAN DTAO");
        /// <summary>
        /// CDT.LOP_HOC.TGIAN_DTAO
        /// </summary>
        /// <value>The TGIAN DTAO.</value>
        public string TGIAN_DTAO
        {
            get { return GetProperty(TGIAN_DTAOProperty); }
            set { SetProperty(TGIAN_DTAOProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NGUON_KP"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NGUON_KPProperty = RegisterProperty<string>(p => p.NGUON_KP, "NGUON KP");
        /// <summary>
        /// CDT.LOP_HOC.NGUON_KP
        /// </summary>
        /// <value>The NGUON KP.</value>
        public string NGUON_KP
        {
            get { return GetProperty(NGUON_KPProperty); }
            set { SetProperty(NGUON_KPProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="HOC_PHI"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> HOC_PHIProperty = RegisterProperty<int?>(p => p.HOC_PHI, "HOC PHI");
        /// <summary>
        /// CDT.LOP_HOC.HOC_PHI
        /// </summary>
        /// <value>The HOC PHI.</value>
        public int? HOC_PHI
        {
            get { return GetProperty(HOC_PHIProperty); }
            set { SetProperty(HOC_PHIProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DUYET"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DUYETProperty = RegisterProperty<string>(p => p.DUYET, "DUYET");
        /// <summary>
        /// CDT.LOP_HOC.DUYET
        /// </summary>
        /// <value>The DUYET.</value>
        public string DUYET
        {
            get { return GetProperty(DUYETProperty); }
            set { SetProperty(DUYETProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TRANG_THAI"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TRANG_THAIProperty = RegisterProperty<string>(p => p.TRANG_THAI, "TRANG THAI");
        /// <summary>
        /// CDT.LOP_HOC.TRANG_THAI
        /// </summary>
        /// <value>The TRANG THAI.</value>
        public string TRANG_THAI
        {
            get { return GetProperty(TRANG_THAIProperty); }
            set { SetProperty(TRANG_THAIProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DM_LOPHOC_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> DM_LOPHOC_IDProperty = RegisterProperty<int?>(p => p.DM_LOPHOC_ID, "DM LOPHOC ID");
        /// <summary>
        /// CDT.LOP_HOC.DM_LOPHOC_ID
        /// </summary>
        /// <value>The DM LOPHOC ID.</value>
        public int? DM_LOPHOC_ID
        {
            get { return GetProperty(DM_LOPHOC_IDProperty); }
            set { SetProperty(DM_LOPHOC_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DM_NGUONKINHPHI_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> DM_NGUONKINHPHI_IDProperty = RegisterProperty<int?>(p => p.DM_NGUONKINHPHI_ID, "DM NGUONKINHPHI ID");
        /// <summary>
        /// CDT.LOP_HOC.DM_NGUONKINHPHI_ID
        /// </summary>
        /// <value>The DM NGUONKINHPHI ID.</value>
        public int? DM_NGUONKINHPHI_ID
        {
            get { return GetProperty(DM_NGUONKINHPHI_IDProperty); }
            set { SetProperty(DM_NGUONKINHPHI_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="CB_PHOP_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> CB_PHOP_IDProperty = RegisterProperty<int?>(p => p.CB_PHOP_ID, "CB PHOP ID");
        /// <summary>
        /// CDT.LOP_HOC.CB_PHOP_ID
        /// </summary>
        /// <value>The CB PHOP ID.</value>
        public int? CB_PHOP_ID
        {
            get { return GetProperty(CB_PHOP_IDProperty); }
            set { SetProperty(CB_PHOP_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_LOP_ANH"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_LOP_ANHProperty = RegisterProperty<string>(p => p.TEN_LOP_ANH, "TEN LOP ANH");
        /// <summary>
        /// CDT.LOP_HOC.TEN_LOP_ANH
        /// </summary>
        /// <value>The TEN LOP ANH.</value>
        public string TEN_LOP_ANH
        {
            get { return GetProperty(TEN_LOP_ANHProperty); }
            set { SetProperty(TEN_LOP_ANHProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="LOP_HOC_INFO"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="LOP_HOC_INFO"/> object.</returns>
        internal static LOP_HOC_INFO NewLOP_HOC_INFO()
        {
            return DataPortal.CreateChild<LOP_HOC_INFO>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="LOP_HOC_INFO"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewLOP_HOC_INFO(EventHandler<DataPortalResult<LOP_HOC_INFO>> callback)
        {
            DataPortal.BeginCreate<LOP_HOC_INFO>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="LOP_HOC_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="LOP_HOC_INFO"/> object.</returns>
        internal static LOP_HOC_INFO GetLOP_HOC_INFO(SafeDataReader dr)
        {
            LOP_HOC_INFO obj = new LOP_HOC_INFO();
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
        /// Initializes a new instance of the <see cref="LOP_HOC_INFO"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private LOP_HOC_INFO()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="LOP_HOC_INFO"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(NAMProperty, null);
            LoadProperty(MA_LOPProperty, null);
            LoadProperty(TEN_LOPProperty, null);
            LoadProperty(NOI_DUNGProperty, null);
            LoadProperty(DOI_TUONGProperty, null);
            LoadProperty(GHI_CHUProperty, null);
            LoadProperty(CBO_PHOPProperty, null);
            LoadProperty(TGIAN_DTAOProperty, null);
            LoadProperty(NGUON_KPProperty, null);
            LoadProperty(DUYETProperty, null);
            LoadProperty(TRANG_THAIProperty, null);
            LoadProperty(TEN_LOP_ANHProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="LOP_HOC_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(LOP_HOC_IDProperty, dr.GetInt32("LOP_HOC_ID"));
            LoadProperty(NAMProperty, dr.GetString("NAM"));
            LoadProperty(MA_LOPProperty, dr.GetString("MA_LOP"));
            LoadProperty(TEN_LOPProperty, dr.GetString("TEN_LOP"));
            LoadProperty(NOI_DUNGProperty, dr.GetString("NOI_DUNG"));
            LoadProperty(NGAY_BDAUProperty, dr.GetSmartDate("NGAY_BDAU"));
            LoadProperty(NGAY_KTHUCProperty, dr.GetSmartDate("NGAY_KTHUC"));
            //LoadProperty(KP_DTRUProperty, dr.GetString("KP_DTRU"));
            //LoadProperty(KP_DUYETProperty, dr.GetString("KP_DUYET"));
            //LoadProperty(KP_QTOANProperty, dr.GetString("KP_QTOAN"));
            //LoadProperty(NGAY_QTOANProperty, dr.GetString("NGAY_QTOAN"));
            //LoadProperty(BP_TCHUC_IDProperty, dr.GetString("BP_TCHUC_ID"));
            //LoadProperty(CQ_TCHUC_IDProperty, dr.GetString("CQ_TCHUC_ID"));
            LoadProperty(DOI_TUONGProperty, dr.GetString("DOI_TUONG"));
            LoadProperty(GHI_CHUProperty, dr.GetString("GHI_CHU"));
            LoadProperty(CBO_PTRACH_IDProperty, dr.GetInt32("CBO_PTRACH_ID"));
            LoadProperty(CBO_PHOPProperty, dr.GetString("CBO_PHOP"));
            LoadProperty(TGIAN_DTAOProperty, dr.GetString("TGIAN_DTAO"));
            LoadProperty(NGUON_KPProperty, dr.GetString("NGUON_KP"));
            LoadProperty(HOC_PHIProperty, dr.GetInt32("HOC_PHI"));
            LoadProperty(DUYETProperty, dr.GetString("DUYET"));
            LoadProperty(TRANG_THAIProperty, dr.GetString("TRANG_THAI"));
            LoadProperty(DM_LOPHOC_IDProperty, dr.GetInt32("DM_LOPHOC_ID"));
            LoadProperty(DM_NGUONKINHPHI_IDProperty, dr.GetInt32("DM_NGUONKINHPHI_ID"));
            LoadProperty(CB_PHOP_IDProperty, dr.GetInt32("CB_PHOP_ID"));
            LoadProperty(TEN_LOP_ANHProperty, dr.GetString("TEN_LOP_ANH"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="LOP_HOC_INFO"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.LOP_HOC_INFO_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LOP_HOC_ID", ReadProperty(LOP_HOC_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NAM", ReadProperty(NAMProperty) == null ? (object)DBNull.Value : ReadProperty(NAMProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_LOP", ReadProperty(MA_LOPProperty) == null ? (object)DBNull.Value : ReadProperty(MA_LOPProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_LOP", ReadProperty(TEN_LOPProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_LOPProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NOI_DUNG", ReadProperty(NOI_DUNGProperty) == null ? (object)DBNull.Value : ReadProperty(NOI_DUNGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NGAY_BDAU", ReadProperty(NGAY_BDAUProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@NGAY_KTHUC", ReadProperty(NGAY_KTHUCProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@KP_DTRU", ReadProperty(KP_DTRUProperty) == null ? (object)DBNull.Value : ReadProperty(KP_DTRUProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@KP_DUYET", ReadProperty(KP_DUYETProperty) == null ? (object)DBNull.Value : ReadProperty(KP_DUYETProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@KP_QTOAN", ReadProperty(KP_QTOANProperty) == null ? (object)DBNull.Value : ReadProperty(KP_QTOANProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NGAY_QTOAN", ReadProperty(NGAY_QTOANProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@BP_TCHUC_ID", ReadProperty(BP_TCHUC_IDProperty) == null ? (object)DBNull.Value : ReadProperty(BP_TCHUC_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CQ_TCHUC_ID", ReadProperty(CQ_TCHUC_IDProperty) == null ? (object)DBNull.Value : ReadProperty(CQ_TCHUC_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DOI_TUONG", ReadProperty(DOI_TUONGProperty) == null ? (object)DBNull.Value : ReadProperty(DOI_TUONGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GHI_CHU", ReadProperty(GHI_CHUProperty) == null ? (object)DBNull.Value : ReadProperty(GHI_CHUProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CBO_PTRACH_ID", ReadProperty(CBO_PTRACH_IDProperty) == null ? (object)DBNull.Value : ReadProperty(CBO_PTRACH_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CBO_PHOP", ReadProperty(CBO_PHOPProperty) == null ? (object)DBNull.Value : ReadProperty(CBO_PHOPProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TGIAN_DTAO", ReadProperty(TGIAN_DTAOProperty) == null ? (object)DBNull.Value : ReadProperty(TGIAN_DTAOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NGUON_KP", ReadProperty(NGUON_KPProperty) == null ? (object)DBNull.Value : ReadProperty(NGUON_KPProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@HOC_PHI", ReadProperty(HOC_PHIProperty) == null ? (object)DBNull.Value : ReadProperty(HOC_PHIProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DUYET", ReadProperty(DUYETProperty) == null ? (object)DBNull.Value : ReadProperty(DUYETProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TRANG_THAI", ReadProperty(TRANG_THAIProperty) == null ? (object)DBNull.Value : ReadProperty(TRANG_THAIProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DM_LOPHOC_ID", ReadProperty(DM_LOPHOC_IDProperty) == null ? (object)DBNull.Value : ReadProperty(DM_LOPHOC_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DM_NGUONKINHPHI_ID", ReadProperty(DM_NGUONKINHPHI_IDProperty) == null ? (object)DBNull.Value : ReadProperty(DM_NGUONKINHPHI_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CB_PHOP_ID", ReadProperty(CB_PHOP_IDProperty) == null ? (object)DBNull.Value : ReadProperty(CB_PHOP_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TEN_LOP_ANH", ReadProperty(TEN_LOP_ANHProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_LOP_ANHProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="LOP_HOC_INFO"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.LOP_HOC_INFO_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LOP_HOC_ID", ReadProperty(LOP_HOC_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NAM", ReadProperty(NAMProperty) == null ? (object)DBNull.Value : ReadProperty(NAMProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_LOP", ReadProperty(MA_LOPProperty) == null ? (object)DBNull.Value : ReadProperty(MA_LOPProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_LOP", ReadProperty(TEN_LOPProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_LOPProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NOI_DUNG", ReadProperty(NOI_DUNGProperty) == null ? (object)DBNull.Value : ReadProperty(NOI_DUNGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NGAY_BDAU", ReadProperty(NGAY_BDAUProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@NGAY_KTHUC", ReadProperty(NGAY_KTHUCProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@KP_DTRU", ReadProperty(KP_DTRUProperty) == null ? (object)DBNull.Value : ReadProperty(KP_DTRUProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@KP_DUYET", ReadProperty(KP_DUYETProperty) == null ? (object)DBNull.Value : ReadProperty(KP_DUYETProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@KP_QTOAN", ReadProperty(KP_QTOANProperty) == null ? (object)DBNull.Value : ReadProperty(KP_QTOANProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NGAY_QTOAN", ReadProperty(NGAY_QTOANProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@BP_TCHUC_ID", ReadProperty(BP_TCHUC_IDProperty) == null ? (object)DBNull.Value : ReadProperty(BP_TCHUC_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CQ_TCHUC_ID", ReadProperty(CQ_TCHUC_IDProperty) == null ? (object)DBNull.Value : ReadProperty(CQ_TCHUC_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DOI_TUONG", ReadProperty(DOI_TUONGProperty) == null ? (object)DBNull.Value : ReadProperty(DOI_TUONGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GHI_CHU", ReadProperty(GHI_CHUProperty) == null ? (object)DBNull.Value : ReadProperty(GHI_CHUProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@CBO_PTRACH_ID", ReadProperty(CBO_PTRACH_IDProperty) == null ? (object)DBNull.Value : ReadProperty(CBO_PTRACH_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CBO_PHOP", ReadProperty(CBO_PHOPProperty) == null ? (object)DBNull.Value : ReadProperty(CBO_PHOPProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TGIAN_DTAO", ReadProperty(TGIAN_DTAOProperty) == null ? (object)DBNull.Value : ReadProperty(TGIAN_DTAOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NGUON_KP", ReadProperty(NGUON_KPProperty) == null ? (object)DBNull.Value : ReadProperty(NGUON_KPProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@HOC_PHI", ReadProperty(HOC_PHIProperty) == null ? (object)DBNull.Value : ReadProperty(HOC_PHIProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DUYET", ReadProperty(DUYETProperty) == null ? (object)DBNull.Value : ReadProperty(DUYETProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TRANG_THAI", ReadProperty(TRANG_THAIProperty) == null ? (object)DBNull.Value : ReadProperty(TRANG_THAIProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DM_LOPHOC_ID", ReadProperty(DM_LOPHOC_IDProperty) == null ? (object)DBNull.Value : ReadProperty(DM_LOPHOC_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DM_NGUONKINHPHI_ID", ReadProperty(DM_NGUONKINHPHI_IDProperty) == null ? (object)DBNull.Value : ReadProperty(DM_NGUONKINHPHI_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CB_PHOP_ID", ReadProperty(CB_PHOP_IDProperty) == null ? (object)DBNull.Value : ReadProperty(CB_PHOP_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TEN_LOP_ANH", ReadProperty(TEN_LOP_ANHProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_LOP_ANHProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="LOP_HOC_INFO"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.LOP_HOC_INFO_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@LOP_HOC_ID", ReadProperty(LOP_HOC_IDProperty)).DbType = DbType.Int32;
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
        /// Occurs after setting all defaults for object creation.
        /// </summary>
        partial void OnCreate(DataPortalHookArgs args);

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
