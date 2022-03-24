//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DIC_GioiTInh_Info
// ObjectType:  DIC_GioiTInh_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Dictionary
{

    /// <summary>
    /// DIC_GioiTInh_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="DIC_GioiTInh_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DIC_GioiTinh_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DIC_GioiTInh_Info : BusinessBase<DIC_GioiTInh_Info>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IDProperty = RegisterProperty<int>(p => p.ID, "ID");
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public int ID
        {
            get { return GetProperty(IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Ten"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenProperty = RegisterProperty<string>(p => p.Ten, "Ten");
        /// <summary>
        /// Gets or sets the Ten.
        /// </summary>
        /// <value>The Ten.</value>
        public string Ten
        {
            get { return GetProperty(TenProperty); }
            set { SetProperty(TenProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GhiChu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GhiChuProperty = RegisterProperty<string>(p => p.GhiChu, "Ghi Chu");
        /// <summary>
        /// Gets or sets the Ghi Chu.
        /// </summary>
        /// <value>The Ghi Chu.</value>
        public string GhiChu
        {
            get { return GetProperty(GhiChuProperty); }
            set { SetProperty(GhiChuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SuDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool?> SuDungProperty = RegisterProperty<bool?>(p => p.SuDung, "Su Dung");
        /// <summary>
        /// Gets or sets the Su Dung.
        /// </summary>
        /// <value><c>true</c> if Su Dung; <c>false</c> if not Su Dung; otherwise, <c>null</c>.</value>
        public bool? SuDung
        {
            get { return GetProperty(SuDungProperty); }
            set { SetProperty(SuDungProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_GioiTInh_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_GioiTInh_Info"/> object.</returns>
        internal static DIC_GioiTInh_Info NewDIC_GioiTInh_Info()
        {
            return DataPortal.CreateChild<DIC_GioiTInh_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_GioiTInh_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDIC_GioiTInh_Info(EventHandler<DataPortalResult<DIC_GioiTInh_Info>> callback)
        {
            DataPortal.BeginCreate<DIC_GioiTInh_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_GioiTInh_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DIC_GioiTInh_Info"/> object.</returns>
        internal static DIC_GioiTInh_Info GetDIC_GioiTInh_Info(SafeDataReader dr)
        {
            DIC_GioiTInh_Info obj = new DIC_GioiTInh_Info();
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
        /// Initializes a new instance of the <see cref="DIC_GioiTInh_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_GioiTInh_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DIC_GioiTInh_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(GhiChuProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="DIC_GioiTInh_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, data.ID);
            LoadProperty(TenProperty, data.Ten);
            LoadProperty(GhiChuProperty, data.GhiChu);
            LoadProperty(SuDungProperty, data.SuDung);
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DIC_GioiTInh_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_GioiTInh_Info_Add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SuDung", ReadProperty(SuDungProperty) == null ? (object)DBNull.Value : ReadProperty(SuDungProperty).Value).DbType = DbType.Boolean;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (int) cmd.Parameters["@ID"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DIC_GioiTInh_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_GioiTInh_Info_Upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SuDung", ReadProperty(SuDungProperty) == null ? (object)DBNull.Value : ReadProperty(SuDungProperty).Value).DbType = DbType.Boolean;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DIC_GioiTInh_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_GioiTInh_Info_Delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
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
