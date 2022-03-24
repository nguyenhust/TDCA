//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_LoaiHinhChuyenGiao_Info
// ObjectType:  CDT_LoaiHinhChuyenGiao_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleChiDaoTuyen.LIB
{

    /// <summary>
    /// CDT_LoaiHinhChuyenGiao_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="CDT_LoaiHinhChuyenGiao_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="CDT_LoaiHinhChuyenGiao_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class CDT_LoaiHinhChuyenGiao_Info : BusinessBase<CDT_LoaiHinhChuyenGiao_Info>
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

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object.</returns>
        internal static CDT_LoaiHinhChuyenGiao_Info NewCDT_LoaiHinhChuyenGiao_Info()
        {
            return DataPortal.CreateChild<CDT_LoaiHinhChuyenGiao_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewCDT_LoaiHinhChuyenGiao_Info(EventHandler<DataPortalResult<CDT_LoaiHinhChuyenGiao_Info>> callback)
        {
            DataPortal.BeginCreate<CDT_LoaiHinhChuyenGiao_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object.</returns>
        internal static CDT_LoaiHinhChuyenGiao_Info GetCDT_LoaiHinhChuyenGiao_Info(SafeDataReader dr)
        {
            CDT_LoaiHinhChuyenGiao_Info obj = new CDT_LoaiHinhChuyenGiao_Info();
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
        /// Initializes a new instance of the <see cref="CDT_LoaiHinhChuyenGiao_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_LoaiHinhChuyenGiao_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(TenProperty, dr.GetString("Ten"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_LoaiHinhChuyenGiao_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (int) cmd.Parameters["@ID"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_LoaiHinhChuyenGiao_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_LoaiHinhChuyenGiao_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_LoaiHinhChuyenGiao_Info_delete", ctx.Connection))
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
