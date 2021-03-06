//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info
// ObjectType:  CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info
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
    /// CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info : BusinessBase<CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="Id"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(p => p.Id, "Id");
        /// <summary>
        /// Gets the Id.
        /// </summary>
        /// <value>The Id.</value>
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
        /// Maintains metadata about <see cref="idChuDeDaoTao"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdChuDeDaoTaoProperty = RegisterProperty<int?>(p => p.IdChuDeDaoTao, "id Chu De Dao Tao");
        /// <summary>
        /// Gets or sets the id Chu De Dao Tao.
        /// </summary>
        /// <value>The id Chu De Dao Tao.</value>
        public int? IdChuDeDaoTao
        {
            get { return GetProperty(IdChuDeDaoTaoProperty); }
            set { SetProperty(IdChuDeDaoTaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idChuDeDaoTao"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChuDeDaoTaoProperty = RegisterProperty<string>(p => p.ChuDeDaoTao, "Chu De Dao Tao");
        /// <summary>
        /// Gets or sets the id Chu De Dao Tao.
        /// </summary>
        /// <value>The id Chu De Dao Tao.</value>
        public string ChuDeDaoTao
        {
            get { return GetProperty(ChuDeDaoTaoProperty); }
            set { SetProperty(ChuDeDaoTaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuongCanBoBSDH"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SoLuongCanBoBSDHProperty = RegisterProperty<int?>(p => p.SoLuongCanBoBSDH, "So Luong Can Bo BSDH");
        /// <summary>
        /// Gets or sets the So Luong Can Bo BSDH.
        /// </summary>
        /// <value>The So Luong Can Bo BSDH.</value>
        public int? SoLuongCanBoBSDH
        {
            get { return GetProperty(SoLuongCanBoBSDHProperty); }
            set { SetProperty(SoLuongCanBoBSDHProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLuongCanBoDDKTV"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SoLuongCanBoDDKTVProperty = RegisterProperty<int?>(p => p.SoLuongCanBoDDKTV, "So Luong Can Bo DDKTV");
        /// <summary>
        /// Gets or sets the So Luong Can Bo DDKTV.
        /// </summary>
        /// <value>The So Luong Can Bo DDKTV.</value>
        public int? SoLuongCanBoDDKTV
        {
            get { return GetProperty(SoLuongCanBoDDKTVProperty); }
            set { SetProperty(SoLuongCanBoDDKTVProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianBatDau"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianBatDauProperty = RegisterProperty<SmartDate>(p => p.ThoiGianBatDau, "Thoi Gian Bat Dau");
        /// <summary>
        /// Gets or sets the Thoi Gian Bat Dau.
        /// </summary>
        /// <value>The Thoi Gian Bat Dau.</value>
        public string ThoiGianBatDau
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianBatDauProperty); }
            set { SetPropertyConvert<SmartDate, String>(ThoiGianBatDauProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianKetThuc"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> ThoiGianKetThucProperty = RegisterProperty<SmartDate>(p => p.ThoiGianKetThuc, "Thoi Gian Ket Thuc");
        /// <summary>
        /// Gets or sets the Thoi Gian Ket Thuc.
        /// </summary>
        /// <value>The Thoi Gian Ket Thuc.</value>
        public string ThoiGianKetThuc
        {
            get { return GetPropertyConvert<SmartDate, String>(ThoiGianKetThucProperty); }
            set { SetPropertyConvert<SmartDate, String>(ThoiGianKetThucProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object.</returns>
        internal static CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info NewCDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info()
        {
            return DataPortal.CreateChild<CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewCDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info(EventHandler<DataPortalResult<CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info>> callback)
        {
            DataPortal.BeginCreate<CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object.</returns>
        internal static CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info GetCDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info(SafeDataReader dr, BusinessFunction function)
        {
            CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info obj = new CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info();
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
        /// Initializes a new instance of the <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr, BusinessFunction function)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdPhieuKhaoSatProperty, dr.GetInt32("IdPhieuKhaoSat"));
            LoadProperty(IdChuDeDaoTaoProperty, dr.GetInt32("IdChuDeDaoTao"));
            LoadProperty(SoLuongCanBoBSDHProperty, dr.GetInt32("SoLuongCanBoBSDH"));
            LoadProperty(SoLuongCanBoDDKTVProperty, dr.GetInt32("SoLuongCanBoDDKTV"));
            LoadProperty(ThoiGianBatDauProperty, dr.GetDateTime("ThoiGianBatDau"));
            LoadProperty(ThoiGianKetThucProperty, dr.GetDateTime("ThoiGianKetThuc"));

            if (function.Mode == BusinessFunctionMode.GetDataForGridView) {
                LoadProperty(ChuDeDaoTaoProperty, dr.GetString("ChuDeDaoTao")); 
            }
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idChuDeDaoTao", ReadProperty(IdChuDeDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuDeDaoTaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongCanBoBSDH", ReadProperty(SoLuongCanBoBSDHProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongCanBoBSDHProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongCanBoDDKTV", ReadProperty(SoLuongCanBoDDKTVProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongCanBoDDKTVProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ThoiGianBatDau", ReadProperty(ThoiGianBatDauProperty)).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@ThoiGianKetThuc", ReadProperty(ThoiGianKetThucProperty)).DbType = DbType.DateTime;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IdProperty, (int) cmd.Parameters["@Id"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idChuDeDaoTao", ReadProperty(IdChuDeDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuDeDaoTaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongCanBoBSDH", ReadProperty(SoLuongCanBoBSDHProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongCanBoBSDHProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongCanBoDDKTV", ReadProperty(SoLuongCanBoDDKTVProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongCanBoDDKTVProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ThoiGianBatDau", ReadProperty(ThoiGianBatDauProperty)).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@ThoiGianKetThuc", ReadProperty(ThoiGianKetThucProperty)).DbType = DbType.DateTime;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DaoTaoLienTucTaiCho_Info_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", ReadProperty(IdProperty)).DbType = DbType.Int32;
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
