//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DM_LOPHOC_INFO
// ObjectType:  DM_LOPHOC_INFO
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
    /// DM_LOPHOC_INFO (editable child object).<br/>
    /// This is a generated base class of <see cref="DM_LOPHOC_INFO"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DM_LOPHOC_COLL"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DM_LOPHOC_INFO : BusinessBase<DM_LOPHOC_INFO>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="DM_LOPHOC_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> DM_LOPHOC_IDProperty = RegisterProperty<int>(p => p.DM_LOPHOC_ID, "DM LOPHOC ID");
        /// <summary>
        /// CDT.DM_LOPHOC.DM_LOPHOC_ID
        /// </summary>
        /// <value>The DM LOPHOC ID.</value>
        public int DM_LOPHOC_ID
        {
            get { return GetProperty(DM_LOPHOC_IDProperty); }
            set { SetProperty(DM_LOPHOC_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_LH"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_LHProperty = RegisterProperty<string>(p => p.TEN_LH, "TEN LH");
        /// <summary>
        /// CDT.DM_LOPHOC.TEN_LH
        /// </summary>
        /// <value>The TEN LH.</value>
        public string TEN_LH
        {
            get { return GetProperty(TEN_LHProperty); }
            set { SetProperty(TEN_LHProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NOI_DUNG"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NOI_DUNGProperty = RegisterProperty<string>(p => p.NOI_DUNG, "NOI DUNG");
        /// <summary>
        /// CDT.DM_LOPHOC.NOI_DUNG
        /// </summary>
        /// <value>The NOI DUNG.</value>
        public string NOI_DUNG
        {
            get { return GetProperty(NOI_DUNGProperty); }
            set { SetProperty(NOI_DUNGProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TAI_LIEU"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TAI_LIEUProperty = RegisterProperty<string>(p => p.TAI_LIEU, "TAI LIEU");
        /// <summary>
        /// CDT.DM_LOPHOC.TAI_LIEU
        /// </summary>
        /// <value>The TAI LIEU.</value>
        public string TAI_LIEU
        {
            get { return GetProperty(TAI_LIEUProperty); }
            set { SetProperty(TAI_LIEUProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="THOI_GIAN"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> THOI_GIANProperty = RegisterProperty<string>(p => p.THOI_GIAN, "THOI GIAN");
        /// <summary>
        /// CDT.DM_LOPHOC.THOI_GIAN
        /// </summary>
        /// <value>The THOI GIAN.</value>
        public string THOI_GIAN
        {
            get { return GetProperty(THOI_GIANProperty); }
            set { SetProperty(THOI_GIANProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_CHUYENNGANH_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> MA_CHUYENNGANH_IDProperty = RegisterProperty<int?>(p => p.MA_CHUYENNGANH_ID, "MA CHUYENNGANH ID");
        /// <summary>
        /// CDT.DM_LOPHOC.MA_CHUYENNGANH_ID
        /// </summary>
        /// <value>The MA CHUYENNGANH ID.</value>
        public int? MA_CHUYENNGANH_ID
        {
            get { return GetProperty(MA_CHUYENNGANH_IDProperty); }
            set { SetProperty(MA_CHUYENNGANH_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_CN"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_CNProperty = RegisterProperty<string>(p => p.TEN_CN, "TEN CN");
        /// <summary>
        /// CDT.DM_LOPHOC.TEN_CN
        /// </summary>
        /// <value>The TEN CN.</value>
        public string TEN_CN
        {
            get { return GetProperty(TEN_CNProperty); }
            set { SetProperty(TEN_CNProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DIA_DIEM"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DIA_DIEMProperty = RegisterProperty<string>(p => p.DIA_DIEM, "DIA DIEM");
        /// <summary>
        /// CDT.DM_LOPHOC.DIA_DIEM
        /// </summary>
        /// <value>The DIA DIEM.</value>
        public string DIA_DIEM
        {
            get { return GetProperty(DIA_DIEMProperty); }
            set { SetProperty(DIA_DIEMProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DOI_TUONG"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DOI_TUONGProperty = RegisterProperty<string>(p => p.DOI_TUONG, "DOI TUONG");
        /// <summary>
        /// CDT.DM_LOPHOC.DOI_TUONG
        /// </summary>
        /// <value>The DOI TUONG.</value>
        public string DOI_TUONG
        {
            get { return GetProperty(DOI_TUONGProperty); }
            set { SetProperty(DOI_TUONGProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TMP"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TMPProperty = RegisterProperty<string>(p => p.TMP, "TMP");
        /// <summary>
        /// CDT.DM_LOPHOC.TMP
        /// </summary>
        /// <value>The TMP.</value>
        public string TMP
        {
            get { return GetProperty(TMPProperty); }
            set { SetProperty(TMPProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DM_LOPHOC_INFO"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DM_LOPHOC_INFO"/> object.</returns>
        internal static DM_LOPHOC_INFO NewDM_LOPHOC_INFO()
        {
            return DataPortal.CreateChild<DM_LOPHOC_INFO>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DM_LOPHOC_INFO"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDM_LOPHOC_INFO(EventHandler<DataPortalResult<DM_LOPHOC_INFO>> callback)
        {
            DataPortal.BeginCreate<DM_LOPHOC_INFO>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DM_LOPHOC_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DM_LOPHOC_INFO"/> object.</returns>
        internal static DM_LOPHOC_INFO GetDM_LOPHOC_INFO(SafeDataReader dr)
        {
            DM_LOPHOC_INFO obj = new DM_LOPHOC_INFO();
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
        /// Initializes a new instance of the <see cref="DM_LOPHOC_INFO"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DM_LOPHOC_INFO()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DM_LOPHOC_INFO"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(TEN_LHProperty, null);
            LoadProperty(NOI_DUNGProperty, null);
            LoadProperty(TAI_LIEUProperty, null);
            LoadProperty(THOI_GIANProperty, null);
            LoadProperty(TEN_CNProperty, null);
            LoadProperty(DIA_DIEMProperty, null);
            LoadProperty(DOI_TUONGProperty, null);
            LoadProperty(TMPProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="DM_LOPHOC_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(DM_LOPHOC_IDProperty, dr.GetInt32("DM_LOPHOC_ID"));
            LoadProperty(TEN_LHProperty, dr.GetString("TEN_LH"));
            LoadProperty(NOI_DUNGProperty, dr.GetString("NOI_DUNG"));
            LoadProperty(TAI_LIEUProperty, dr.GetString("TAI_LIEU"));
            LoadProperty(THOI_GIANProperty, dr.GetString("THOI_GIAN"));
            LoadProperty(MA_CHUYENNGANH_IDProperty, dr.GetInt32("MA_CHUYENNGANH_ID"));
            LoadProperty(TEN_CNProperty, dr.GetString("TEN_CN"));
            LoadProperty(DIA_DIEMProperty, dr.GetString("DIA_DIEM"));
            LoadProperty(DOI_TUONGProperty, dr.GetString("DOI_TUONG"));
            LoadProperty(TMPProperty, dr.GetString("TMP"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DM_LOPHOC_INFO"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.DM_LOPHOC_INFO_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DM_LOPHOC_ID", ReadProperty(DM_LOPHOC_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TEN_LH", ReadProperty(TEN_LHProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_LHProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NOI_DUNG", ReadProperty(NOI_DUNGProperty) == null ? (object)DBNull.Value : ReadProperty(NOI_DUNGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TAI_LIEU", ReadProperty(TAI_LIEUProperty) == null ? (object)DBNull.Value : ReadProperty(TAI_LIEUProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@THOI_GIAN", ReadProperty(THOI_GIANProperty) == null ? (object)DBNull.Value : ReadProperty(THOI_GIANProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_CHUYENNGANH_ID", ReadProperty(MA_CHUYENNGANH_IDProperty) == null ? (object)DBNull.Value : ReadProperty(MA_CHUYENNGANH_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TEN_CN", ReadProperty(TEN_CNProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_CNProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DIA_DIEM", ReadProperty(DIA_DIEMProperty) == null ? (object)DBNull.Value : ReadProperty(DIA_DIEMProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DOI_TUONG", ReadProperty(DOI_TUONGProperty) == null ? (object)DBNull.Value : ReadProperty(DOI_TUONGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TMP", ReadProperty(TMPProperty) == null ? (object)DBNull.Value : ReadProperty(TMPProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DM_LOPHOC_INFO"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.DM_LOPHOC_INFO_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DM_LOPHOC_ID", ReadProperty(DM_LOPHOC_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TEN_LH", ReadProperty(TEN_LHProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_LHProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NOI_DUNG", ReadProperty(NOI_DUNGProperty) == null ? (object)DBNull.Value : ReadProperty(NOI_DUNGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TAI_LIEU", ReadProperty(TAI_LIEUProperty) == null ? (object)DBNull.Value : ReadProperty(TAI_LIEUProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@THOI_GIAN", ReadProperty(THOI_GIANProperty) == null ? (object)DBNull.Value : ReadProperty(THOI_GIANProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_CHUYENNGANH_ID", ReadProperty(MA_CHUYENNGANH_IDProperty) == null ? (object)DBNull.Value : ReadProperty(MA_CHUYENNGANH_IDProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TEN_CN", ReadProperty(TEN_CNProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_CNProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DIA_DIEM", ReadProperty(DIA_DIEMProperty) == null ? (object)DBNull.Value : ReadProperty(DIA_DIEMProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DOI_TUONG", ReadProperty(DOI_TUONGProperty) == null ? (object)DBNull.Value : ReadProperty(DOI_TUONGProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TMP", ReadProperty(TMPProperty) == null ? (object)DBNull.Value : ReadProperty(TMPProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DM_LOPHOC_INFO"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.DM_LOPHOC_INFO_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DM_LOPHOC_ID", ReadProperty(DM_LOPHOC_IDProperty)).DbType = DbType.Int32;
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