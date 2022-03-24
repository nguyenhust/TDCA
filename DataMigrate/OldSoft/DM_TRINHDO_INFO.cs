//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DM_TRINHDO_INFO
// ObjectType:  DM_TRINHDO_INFO
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
    /// DM_TRINHDO_INFO (editable child object).<br/>
    /// This is a generated base class of <see cref="DM_TRINHDO_INFO"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DM_TRINHDO_COLL"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DM_TRINHDO_INFO : BusinessBase<DM_TRINHDO_INFO>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="MA_TRINHDO"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_TRINHDOProperty = RegisterProperty<string>(p => p.MA_TRINHDO, "MA TRINHDO");
        /// <summary>
        /// CDT.DM_TRINHDO.MA_TRINHDO
        /// </summary>
        /// <value>The MA TRINHDO.</value>
        public string MA_TRINHDO
        {
            get { return GetProperty(MA_TRINHDOProperty); }
            set { SetProperty(MA_TRINHDOProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_TRINHDO"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_TRINHDOProperty = RegisterProperty<string>(p => p.TEN_TRINHDO, "TEN TRINHDO");
        /// <summary>
        /// CDT.DM_TRINHDO.TEN_TRINHDO
        /// </summary>
        /// <value>The TEN TRINHDO.</value>
        public string TEN_TRINHDO
        {
            get { return GetProperty(TEN_TRINHDOProperty); }
            set { SetProperty(TEN_TRINHDOProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SAP_XEP"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SAP_XEPProperty = RegisterProperty<int?>(p => p.SAP_XEP, "SAP XEP", null);
        /// <summary>
        /// CDT.DM_TRINHDO.SAP_XEP
        /// </summary>
        /// <value>The SAP XEP.</value>
        public int? SAP_XEP
        {
            get { return GetProperty(SAP_XEPProperty); }
            set { SetProperty(SAP_XEPProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="DM_TRINHDO_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DM_TRINHDO_INFO"/> object.</returns>
        internal static DM_TRINHDO_INFO GetDM_TRINHDO_INFO(SafeDataReader dr)
        {
            DM_TRINHDO_INFO obj = new DM_TRINHDO_INFO();
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
        /// Initializes a new instance of the <see cref="DM_TRINHDO_INFO"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DM_TRINHDO_INFO()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="DM_TRINHDO_INFO"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(MA_TRINHDOProperty, dr.GetString("MA_TRINHDO"));
            LoadProperty(TEN_TRINHDOProperty, dr.GetString("TEN_TRINHDO"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DM_TRINHDO_INFO"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.DM_TRINHDO_INFO_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MA_TRINHDO", ReadProperty(MA_TRINHDOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_TRINHDO", ReadProperty(TEN_TRINHDOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SAP_XEP", ReadProperty(SAP_XEPProperty) == null ? (object)DBNull.Value : ReadProperty(SAP_XEPProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DM_TRINHDO_INFO"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.DM_TRINHDO_INFO_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MA_TRINHDO", ReadProperty(MA_TRINHDOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_TRINHDO", ReadProperty(TEN_TRINHDOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SAP_XEP", ReadProperty(SAP_XEPProperty) == null ? (object)DBNull.Value : ReadProperty(SAP_XEPProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DM_TRINHDO_INFO"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.DM_TRINHDO_INFO_delete", ctx.Connection))
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