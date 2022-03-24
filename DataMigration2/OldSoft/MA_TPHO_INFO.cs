//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    MA_TPHO_INFO
// ObjectType:  MA_TPHO_INFO
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
    /// MA_TPHO_INFO (editable child object).<br/>
    /// This is a generated base class of <see cref="MA_TPHO_INFO"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="MA_TPHO_COLL"/> collection.
    /// </remarks>
    [Serializable]
    public partial class MA_TPHO_INFO : BusinessBase<MA_TPHO_INFO>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="MA_TPHO"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_TPHOProperty = RegisterProperty<string>(p => p.MA_TPHO, "MA TPHO");
        /// <summary>
        /// CDT.MA_TPHO.MA_TPHO
        /// </summary>
        /// <value>The MA TPHO.</value>
        public string MA_TPHO
        {
            get { return GetProperty(MA_TPHOProperty); }
            set { SetProperty(MA_TPHOProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_TPHO"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_TPHOProperty = RegisterProperty<string>(p => p.TEN_TPHO, "TEN TPHO");
        /// <summary>
        /// CDT.MA_TPHO.TEN_TPHO
        /// </summary>
        /// <value>The TEN TPHO.</value>
        public string TEN_TPHO
        {
            get { return GetProperty(TEN_TPHOProperty); }
            set { SetProperty(TEN_TPHOProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_TP_KKB"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_TP_KKBProperty = RegisterProperty<string>(p => p.MA_TP_KKB, "MA TP KKB", null);
        /// <summary>
        /// CDT.MA_TPHO.MA_TP_KKB
        /// </summary>
        /// <value>The MA TP KKB.</value>
        public string MA_TP_KKB
        {
            get { return GetProperty(MA_TP_KKBProperty); }
            set { SetProperty(MA_TP_KKBProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_TP_KCC"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_TP_KCCProperty = RegisterProperty<string>(p => p.MA_TP_KCC, "MA TP KCC", null);
        /// <summary>
        /// CDT.MA_TPHO.MA_TP_KCC
        /// </summary>
        /// <value>The MA TP KCC.</value>
        public string MA_TP_KCC
        {
            get { return GetProperty(MA_TP_KCCProperty); }
            set { SetProperty(MA_TP_KCCProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="MA_TPHO_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="MA_TPHO_INFO"/> object.</returns>
        internal static MA_TPHO_INFO GetMA_TPHO_INFO(SafeDataReader dr)
        {
            MA_TPHO_INFO obj = new MA_TPHO_INFO();
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
        /// Initializes a new instance of the <see cref="MA_TPHO_INFO"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private MA_TPHO_INFO()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="MA_TPHO_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(MA_TPHOProperty, dr.GetString("MA_TPHO"));
            LoadProperty(TEN_TPHOProperty, dr.GetString("TEN_TPHO"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="MA_TPHO_INFO"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.MA_TPHO_INFO_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MA_TPHO", ReadProperty(MA_TPHOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_TPHO", ReadProperty(TEN_TPHOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_TP_KKB", ReadProperty(MA_TP_KKBProperty) == null ? (object)DBNull.Value : ReadProperty(MA_TP_KKBProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_TP_KCC", ReadProperty(MA_TP_KCCProperty) == null ? (object)DBNull.Value : ReadProperty(MA_TP_KCCProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="MA_TPHO_INFO"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.MA_TPHO_INFO_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MA_TPHO", ReadProperty(MA_TPHOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_TPHO", ReadProperty(TEN_TPHOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_TP_KKB", ReadProperty(MA_TP_KKBProperty) == null ? (object)DBNull.Value : ReadProperty(MA_TP_KKBProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_TP_KCC", ReadProperty(MA_TP_KCCProperty) == null ? (object)DBNull.Value : ReadProperty(MA_TP_KCCProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="MA_TPHO_INFO"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.MA_TPHO_INFO_delete", ctx.Connection))
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
