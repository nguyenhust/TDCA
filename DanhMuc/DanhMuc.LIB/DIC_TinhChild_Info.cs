//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DIC_TinhChild_Info
// ObjectType:  DIC_TinhChild_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{

    /// <summary>
    /// DIC_TinhChild_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="DIC_TinhChild_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="DIC_TinhChild_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DIC_TinhChild_Info : BusinessBase<DIC_TinhChild_Info>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDProperty = RegisterProperty<Int64>(p => p.ID, "ID");
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public Int64 ID
        {
            get { return GetProperty(IDProperty); }
            set { SetProperty(IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Ma"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaProperty = RegisterProperty<string>(p => p.Ma, "Ma");
        /// <summary>
        /// Gets or sets the Ma.
        /// </summary>
        /// <value>The Ma.</value>
        public string Ma
        {
            get { return GetProperty(MaProperty); }
            set { SetProperty(MaProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MaDK"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaDKProperty = RegisterProperty<string>(p => p.MaDK, "Ma DK");
        /// <summary>
        /// Gets or sets the Ma DK.
        /// </summary>
        /// <value>The Ma DK.</value>
        public string MaDK
        {
            get { return GetProperty(MaDKProperty); }
            set { SetProperty(MaDKProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TieuDe"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TieuDeProperty = RegisterProperty<string>(p => p.TieuDe, "Tieu De");
        /// <summary>
        /// Gets or sets the Tieu De.
        /// </summary>
        /// <value>The Tieu De.</value>
        public string TieuDe
        {
            get { return GetProperty(TieuDeProperty); }
            set { SetProperty(TieuDeProperty, value); }
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

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_TinhChild_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_TinhChild_Info"/> object.</returns>
        internal static DIC_TinhChild_Info NewDIC_TinhChild_Info()
        {
            return DataPortal.CreateChild<DIC_TinhChild_Info>();
        }
        

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_TinhChild_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDIC_TinhChild_Info(EventHandler<DataPortalResult<DIC_TinhChild_Info>> callback)
        {
            DataPortal.BeginCreate<DIC_TinhChild_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_TinhChild_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DIC_TinhChild_Info"/> object.</returns>
        internal static DIC_TinhChild_Info GetDIC_TinhChild_Info(SafeDataReader dr)
        {
            DIC_TinhChild_Info obj = new DIC_TinhChild_Info();
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
        /// Initializes a new instance of the <see cref="DIC_TinhChild_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_TinhChild_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="DIC_TinhChild_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(MaProperty, null);
            LoadProperty(MaDKProperty, null);
            LoadProperty(GhiChuProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }
       
        /// <summary>
        /// Loads a <see cref="DIC_TinhChild_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt64("ID"));
            LoadProperty(MaProperty, dr.GetString("Ma"));
            LoadProperty(MaDKProperty, dr.GetString("MaDK"));
            LoadProperty(TieuDeProperty, dr.GetString("TieuDe"));
            LoadProperty(TenProperty, dr.GetString("Ten"));
            LoadProperty(SuDungProperty, dr.GetBoolean("SuDung"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="DIC_TinhChild_Info"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        private void Child_Insert(DIC_Tinh parent)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_TinhCon_Info_Add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDRefer", parent.ID).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@Ma", ReadProperty(MaProperty) == null ? (object)DBNull.Value : ReadProperty(MaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaDK", ReadProperty(MaDKProperty) == null ? (object)DBNull.Value : ReadProperty(MaDKProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TieuDe", ReadProperty(TieuDeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SuDung", ReadProperty(SuDungProperty) == null ? (object)DBNull.Value : ReadProperty(SuDungProperty).Value).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="DIC_TinhChild_Info"/> object.
        /// </summary>
        private void Child_Update(DIC_Tinh parent)
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_TinhCon_Info_Upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@Ma", ReadProperty(MaProperty) == null ? (object)DBNull.Value : ReadProperty(MaProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MaDK", ReadProperty(MaDKProperty) == null ? (object)DBNull.Value : ReadProperty(MaDKProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TieuDe", ReadProperty(TieuDeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Ten", ReadProperty(TenProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SuDung", ReadProperty(SuDungProperty) == null ? (object)DBNull.Value : ReadProperty(SuDungProperty).Value).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="DIC_TinhChild_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.DIC_TinhCon_Info_Delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int64;
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
