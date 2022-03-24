//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_PhieuKhaoSat_BMVeHoTro
// ObjectType:  CDT_PhieuKhaoSat_BMVeHoTro
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleChiDaoTuyen.LIB
{

    /// <summary>
    /// CDT_PhieuKhaoSat_BMVeHoTro (editable root object).<br/>
    /// This is a generated base class of <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> business object.
    /// </summary>
    [Serializable]
    public partial class CDT_PhieuKhaoSat_BMVeHoTro : BusinessBase<CDT_PhieuKhaoSat_BMVeHoTro>
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
        /// Maintains metadata about <see cref="ThoiGianBatDau"/> property.
        /// </summary>
        public static readonly PropertyInfo<Object> ThoiGianBatDauProperty = RegisterProperty<Object>(p => p.ThoiGianBatDau, "Thoi Gian Bat Dau");
        /// <summary>
        /// Gets or sets the Thoi Gian Bat Dau.
        /// </summary>
        /// <value>The Thoi Gian Bat Dau.</value>
        public Object ThoiGianBatDau
        {
            get { return GetProperty(ThoiGianBatDauProperty); }
            set { SetProperty(ThoiGianBatDauProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianKetThuc"/> property.
        /// </summary>
        public static readonly PropertyInfo<Object> ThoiGianKetThucProperty = RegisterProperty<Object>(p => p.ThoiGianKetThuc, "Thoi Gian Ket Thuc");
        /// <summary>
        /// Gets or sets the Thoi Gian Ket Thuc.
        /// </summary>
        /// <value>The Thoi Gian Ket Thuc.</value>
        public Object ThoiGianKetThuc
        {
            get { return GetProperty(ThoiGianKetThucProperty); }
            set { SetProperty(ThoiGianKetThucProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object.</returns>
        public static CDT_PhieuKhaoSat_BMVeHoTro NewCDT_PhieuKhaoSat_BMVeHoTro()
        {
            return DataPortal.Create<CDT_PhieuKhaoSat_BMVeHoTro>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the CDT_PhieuKhaoSat_BMVeHoTro to fetch.</param>
        /// <returns>A reference to the fetched <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object.</returns>
        public static CDT_PhieuKhaoSat_BMVeHoTro GetCDT_PhieuKhaoSat_BMVeHoTro(int id)
        {
            return DataPortal.Fetch<CDT_PhieuKhaoSat_BMVeHoTro>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the CDT_PhieuKhaoSat_BMVeHoTro to delete.</param>
        public static void DeleteCDT_PhieuKhaoSat_BMVeHoTro(int id)
        {
            DataPortal.Delete<CDT_PhieuKhaoSat_BMVeHoTro>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_PhieuKhaoSat_BMVeHoTro(EventHandler<DataPortalResult<CDT_PhieuKhaoSat_BMVeHoTro>> callback)
        {
            DataPortal.BeginCreate<CDT_PhieuKhaoSat_BMVeHoTro>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the CDT_PhieuKhaoSat_BMVeHoTro to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_PhieuKhaoSat_BMVeHoTro(int id, EventHandler<DataPortalResult<CDT_PhieuKhaoSat_BMVeHoTro>> callback)
        {
            DataPortal.BeginFetch<CDT_PhieuKhaoSat_BMVeHoTro>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the CDT_PhieuKhaoSat_BMVeHoTro to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteCDT_PhieuKhaoSat_BMVeHoTro(int id, EventHandler<DataPortalResult<CDT_PhieuKhaoSat_BMVeHoTro>> callback)
        {
            DataPortal.BeginDelete<CDT_PhieuKhaoSat_BMVeHoTro>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_PhieuKhaoSat_BMVeHoTro()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The id.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_BMVeHoTro_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, id);
                    OnFetchPre(args);
                    Fetch(cmd);
                    OnFetchPost(args);
                }
            }
            // check all object rules and property rules
            BusinessRules.CheckRules();
        }

        private void Fetch(SqlCommand cmd)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                }
            }
        }

        /// <summary>
        /// Loads a <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdPhieuKhaoSatProperty, dr.GetInt32("IdPhieuKhaoSat"));
            LoadProperty(IdChuDeDaoTaoProperty, dr.GetInt32("IdChuDeDaoTao"));
            LoadProperty(SoLuongBS_DHProperty, dr.GetInt32("SoLuongBS_DH"));
            LoadProperty(SoLuongDD_KTVProperty, dr.GetInt32("SoLuongDD_KTV"));
            LoadProperty(ThoiGianBatDauProperty, dr.GetDateTime("ThoiGianBatDau"));
            LoadProperty(ThoiGianKetThucProperty, dr.GetDateTime("ThoiGianKetThuc"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_BMVeHoTro_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idChuDeDaoTao", ReadProperty(IdChuDeDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuDeDaoTaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongBS_DH", ReadProperty(SoLuongBS_DHProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongBS_DHProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongDD_KTV", ReadProperty(SoLuongDD_KTVProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongDD_KTVProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ThoiGianBatDau", ReadProperty(ThoiGianBatDauProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@ThoiGianKetThuc", ReadProperty(ThoiGianKetThucProperty)).DbType = DbType.Binary;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IdProperty, (int) cmd.Parameters["@id"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_BMVeHoTro_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idChuDeDaoTao", ReadProperty(IdChuDeDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuDeDaoTaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongBS_DH", ReadProperty(SoLuongBS_DHProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongBS_DHProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@SoLuongDD_KTV", ReadProperty(SoLuongDD_KTVProperty) == null ? (object)DBNull.Value : ReadProperty(SoLuongDD_KTVProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ThoiGianBatDau", ReadProperty(ThoiGianBatDauProperty)).DbType = DbType.Binary;
                    cmd.Parameters.AddWithValue("@ThoiGianKetThuc", ReadProperty(ThoiGianKetThucProperty)).DbType = DbType.Binary;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(Id);
        }

        /// <summary>
        /// Deletes the <see cref="CDT_PhieuKhaoSat_BMVeHoTro"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_BMVeHoTro_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, id);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
                ctx.Commit();
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
