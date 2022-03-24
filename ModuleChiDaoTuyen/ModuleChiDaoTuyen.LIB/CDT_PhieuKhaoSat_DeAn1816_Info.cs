//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_PhieuKhaoSat_DeAn1816_Info
// ObjectType:  CDT_PhieuKhaoSat_DeAn1816_Info
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
    /// CDT_PhieuKhaoSat_DeAn1816_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="CDT_PhieuKhaoSat_DeAn1816_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class CDT_PhieuKhaoSat_DeAn1816_Info : BusinessBase<CDT_PhieuKhaoSat_DeAn1816_Info>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="id"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(p => p.Id, "id");
        /// <summary>
        /// Gets the id.
        /// </summary>
        /// <value>The id.</value>
        public int Id
        {
            get { return GetProperty(IdProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idPhieuKhaoSat"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdPhieuKhaoSatProperty = RegisterProperty<int?>(p => p.IdPhieuKhaoSat, "id Phieu Khao Sat");
        /// <summary>
        /// Gets or sets the id Phieu Khao Sat.
        /// </summary>
        /// <value>The id Phieu Khao Sat.</value>
        public int? IdPhieuKhaoSat
        {
            get { return GetProperty(IdPhieuKhaoSatProperty); }
            set { SetProperty(IdPhieuKhaoSatProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idGoiKyThuat"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GoiKyThuatProperty = RegisterProperty<string>(p => p.GoiKyThuat, "Goi Ky Thuat");
        /// <summary>
        /// Gets or sets the id Goi Ky Thuat.
        /// </summary>
        /// <value>The id Goi Ky Thuat.</value>
        public string GoiKyThuat
        {
            get { return GetProperty(GoiKyThuatProperty); }
            set { SetProperty(GoiKyThuatProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idGoiKyThuat"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdGoiKyThuatProperty = RegisterProperty<int?>(p => p.IdGoiKyThuat, "id Goi Ky Thuat");
        /// <summary>
        /// Gets or sets the id Goi Ky Thuat.
        /// </summary>
        /// <value>The id Goi Ky Thuat.</value>
        public int? IdGoiKyThuat
        {
            get { return GetProperty(IdGoiKyThuatProperty); }
            set { SetProperty(IdGoiKyThuatProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuongBS_DH"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SoLuongBS_DHProperty = RegisterProperty<int?>(p => p.SoLuongBS_DH, "So Luong BS DH");
        /// <summary>
        /// Gets or sets the So Luong BS DH.
        /// </summary>
        /// <value>The So Luong BS DH.</value>
        public int? SoLuongBS_DH
        {
            get { return GetProperty(SoLuongBS_DHProperty); }
            set { SetProperty(SoLuongBS_DHProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuongDD_KTV"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SoLuongDD_KTVProperty = RegisterProperty<int?>(p => p.SoLuongDD_KTV, "So Luong DD KTV");
        /// <summary>
        /// Gets or sets the So Luong DD KTV.
        /// </summary>
        /// <value>The So Luong DD KTV.</value>
        public int? SoLuongDD_KTV
        {
            get { return GetProperty(SoLuongDD_KTVProperty); }
            set { SetProperty(SoLuongDD_KTVProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TrangThietBiCanCo"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TrangThietBiCanCoProperty = RegisterProperty<string>(p => p.TrangThietBiCanCo, "Trang Thiet Bi Can Co");
        /// <summary>
        /// Gets or sets the Trang Thiet Bi Can Co.
        /// </summary>
        /// <value>The Trang Thiet Bi Can Co.</value>
        public string TrangThietBiCanCo
        {
            get { return GetProperty(TrangThietBiCanCoProperty); }
            set { SetProperty(TrangThietBiCanCoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TrangThieBiChuaCo"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TrangThieBiChuaCoProperty = RegisterProperty<string>(p => p.TrangThieBiChuaCo, "Trang Thie Bi Chua Co");
        /// <summary>
        /// Gets or sets the Trang Thie Bi Chua Co.
        /// </summary>
        /// <value>The Trang Thie Bi Chua Co.</value>
        public string TrangThieBiChuaCo
        {
            get { return GetProperty(TrangThieBiChuaCoProperty); }
            set { SetProperty(TrangThieBiChuaCoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianDuKienTrienKhai"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianDuKienTrienKhaiProperty = RegisterProperty<SmartDate>(p => p.ThoiGianDuKienTrienKhai, "Thoi Gian Du Kien Trien Khai");
        /// <summary>
        /// Gets or sets the Thoi Gian Du Kien Trien Khai.
        /// </summary>
        /// <value>The Thoi Gian Du Kien Trien Khai.</value>
        public SmartDate ThoiGianDuKienTrienKhai
        {
            get { return GetProperty(ThoiGianDuKienTrienKhaiProperty); }
            set { SetProperty(ThoiGianDuKienTrienKhaiProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object.</returns>
        internal static CDT_PhieuKhaoSat_DeAn1816_Info NewCDT_PhieuKhaoSat_DeAn1816_Info()
        {
            return DataPortal.CreateChild<CDT_PhieuKhaoSat_DeAn1816_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewCDT_PhieuKhaoSat_DeAn1816_Info(EventHandler<DataPortalResult<CDT_PhieuKhaoSat_DeAn1816_Info>> callback)
        {
            DataPortal.BeginCreate<CDT_PhieuKhaoSat_DeAn1816_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object.</returns>
        internal static CDT_PhieuKhaoSat_DeAn1816_Info GetCDT_PhieuKhaoSat_DeAn1816_Info(SafeDataReader dr, BusinessFunction function)
        {
            CDT_PhieuKhaoSat_DeAn1816_Info obj = new CDT_PhieuKhaoSat_DeAn1816_Info();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr, function);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_PhieuKhaoSat_DeAn1816_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(TrangThietBiCanCoProperty, null);
            LoadProperty(TrangThieBiChuaCoProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr, BusinessFunction function)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdPhieuKhaoSatProperty, dr.GetInt32("IdPhieuKhaoSat"));
            LoadProperty(IdGoiKyThuatProperty, dr.GetInt32("IdGoiKyThuat"));
            
            LoadProperty(SoLuongBS_DHProperty, dr.GetInt32("SoLuongBS_DH"));
            LoadProperty(SoLuongDD_KTVProperty, dr.GetInt32("SoLuongDD_KTV"));
            LoadProperty(TrangThietBiCanCoProperty, dr.GetString("TrangThietBiCanCo"));
            LoadProperty(TrangThieBiChuaCoProperty, dr.GetString("TrangThieBiChuaCo"));
            LoadProperty(ThoiGianDuKienTrienKhaiProperty, dr.GetDateTime("ThoiGianDuKienTrienKhai"));

            if (function.Mode == BusinessFunctionMode.GetDataForGridView)
                LoadProperty(GoiKyThuatProperty, dr.GetString("GoiKyThuat"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DeAn1816_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idGoiKyThuat", ReadProperty(IdGoiKyThuatProperty) == null ? (object)DBNull.Value : ReadProperty(IdGoiKyThuatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongBS_DH", ReadProperty(SoLuongBS_DHProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongBS_DHProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongDD_KTV", ReadProperty(SoLuongDD_KTVProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongDD_KTVProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TrangThietBiCanCo", ReadProperty(TrangThietBiCanCoProperty) == null ? (object)DBNull.Value : ReadProperty(TrangThietBiCanCoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TrangThieBiChuaCo", ReadProperty(TrangThieBiChuaCoProperty) == null ? (object)DBNull.Value : ReadProperty(TrangThieBiChuaCoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiGianDuKienTrienKhai", ReadProperty(ThoiGianDuKienTrienKhaiProperty)).DbType = DbType.DateTime;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IdProperty, (int) cmd.Parameters["@id"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DeAn1816_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idGoiKyThuat", ReadProperty(IdGoiKyThuatProperty) == null ? (object)DBNull.Value : ReadProperty(IdGoiKyThuatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongBS_DH", ReadProperty(SoLuongBS_DHProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongBS_DHProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongDD_KTV", ReadProperty(SoLuongDD_KTVProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongDD_KTVProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@TrangThietBiCanCo", ReadProperty(TrangThietBiCanCoProperty) == null ? (object)DBNull.Value : ReadProperty(TrangThietBiCanCoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TrangThieBiChuaCo", ReadProperty(TrangThieBiChuaCoProperty) == null ? (object)DBNull.Value : ReadProperty(TrangThieBiChuaCoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiGianDuKienTrienKhai", ReadProperty(ThoiGianDuKienTrienKhaiProperty)).DbType = DbType.DateTime;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_PhieuKhaoSat_DeAn1816_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DeAn1816_Info_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
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