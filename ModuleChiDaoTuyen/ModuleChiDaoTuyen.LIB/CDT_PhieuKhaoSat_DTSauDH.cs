//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_PhieuKhaoSat_DTSauDH
// ObjectType:  CDT_PhieuKhaoSat_DTSauDH
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
    /// CDT_PhieuKhaoSat_DTSauDH (editable root object).<br/>
    /// This is a generated base class of <see cref="CDT_PhieuKhaoSat_DTSauDH"/> business object.
    /// </summary>
    [Serializable]
    public partial class CDT_PhieuKhaoSat_DTSauDH : BusinessBase<CDT_PhieuKhaoSat_DTSauDH>
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
        /// Maintains metadata about <see cref="idLoaiHinhDaoTao"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> IdLoaiHinhDaoTaoProperty = RegisterProperty<int?>(p => p.IdLoaiHinhDaoTao, "id Loai Hinh Dao Tao");
        /// <summary>
        /// Gets or sets the id Loai Hinh Dao Tao.
        /// </summary>
        /// <value>The id Loai Hinh Dao Tao.</value>
        public int? IdLoaiHinhDaoTao
        {
            get { return GetProperty(IdLoaiHinhDaoTaoProperty); }
            set { SetProperty(IdLoaiHinhDaoTaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DangKiMoMaDT"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool?> DangKiMoMaDTProperty = RegisterProperty<bool?>(p => p.DangKiMoMaDT, "Dang Ki Mo Ma DT");
        /// <summary>
        /// Gets or sets the Dang Ki Mo Ma DT.
        /// </summary>
        /// <value><c>true</c> if Dang Ki Mo Ma DT; <c>false</c> if not Dang Ki Mo Ma DT; otherwise, <c>null</c>.</value>
        public bool? DangKiMoMaDT
        {
            get { return GetProperty(DangKiMoMaDTProperty); }
            set { SetProperty(DangKiMoMaDTProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChiTieuNhanDaoTao"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> ChiTieuNhanDaoTaoProperty = RegisterProperty<int?>(p => p.ChiTieuNhanDaoTao, "Chi Tieu Nhan Dao Tao");
        /// <summary>
        /// Gets or sets the Chi Tieu Nhan Dao Tao.
        /// </summary>
        /// <value>The Chi Tieu Nhan Dao Tao.</value>
        public int? ChiTieuNhanDaoTao
        {
            get { return GetProperty(ChiTieuNhanDaoTaoProperty); }
            set { SetProperty(ChiTieuNhanDaoTaoProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object.</returns>
        public static CDT_PhieuKhaoSat_DTSauDH NewCDT_PhieuKhaoSat_DTSauDH()
        {
            return DataPortal.Create<CDT_PhieuKhaoSat_DTSauDH>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the CDT_PhieuKhaoSat_DTSauDH to fetch.</param>
        /// <returns>A reference to the fetched <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object.</returns>
        public static CDT_PhieuKhaoSat_DTSauDH GetCDT_PhieuKhaoSat_DTSauDH(int id)
        {
            return DataPortal.Fetch<CDT_PhieuKhaoSat_DTSauDH>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the CDT_PhieuKhaoSat_DTSauDH to delete.</param>
        public static void DeleteCDT_PhieuKhaoSat_DTSauDH(int id)
        {
            DataPortal.Delete<CDT_PhieuKhaoSat_DTSauDH>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_PhieuKhaoSat_DTSauDH(EventHandler<DataPortalResult<CDT_PhieuKhaoSat_DTSauDH>> callback)
        {
            DataPortal.BeginCreate<CDT_PhieuKhaoSat_DTSauDH>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the CDT_PhieuKhaoSat_DTSauDH to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_PhieuKhaoSat_DTSauDH(int id, EventHandler<DataPortalResult<CDT_PhieuKhaoSat_DTSauDH>> callback)
        {
            DataPortal.BeginFetch<CDT_PhieuKhaoSat_DTSauDH>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the CDT_PhieuKhaoSat_DTSauDH to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteCDT_PhieuKhaoSat_DTSauDH(int id, EventHandler<DataPortalResult<CDT_PhieuKhaoSat_DTSauDH>> callback)
        {
            DataPortal.BeginDelete<CDT_PhieuKhaoSat_DTSauDH>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_PhieuKhaoSat_DTSauDH"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_PhieuKhaoSat_DTSauDH()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object properties.
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
        /// Loads a <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The id.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DTSauDH_get", ctx.Connection))
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
        /// Loads a <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdPhieuKhaoSatProperty, dr.GetInt32("IdPhieuKhaoSat"));
            LoadProperty(IdLoaiHinhDaoTaoProperty, dr.GetInt32("IdLoaiHinhDaoTao"));
            LoadProperty(DangKiMoMaDTProperty, dr.GetBoolean("DangKiMoMaDT"));
            LoadProperty(ChiTieuNhanDaoTaoProperty, dr.GetInt32("ChiTieuNhanDaoTao"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DTSauDH_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idLoaiHinhDaoTao", ReadProperty(IdLoaiHinhDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(IdLoaiHinhDaoTaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DangKiMoMaDT", ReadProperty(DangKiMoMaDTProperty) == null ? (object)DBNull.Value : ReadProperty(DangKiMoMaDTProperty).Value).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@ChiTieuNhanDaoTao", ReadProperty(ChiTieuNhanDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(ChiTieuNhanDaoTaoProperty).Value).DbType = DbType.Int32;
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
        /// Updates in the database all changes made to the <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DTSauDH_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idLoaiHinhDaoTao", ReadProperty(IdLoaiHinhDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(IdLoaiHinhDaoTaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DangKiMoMaDT", ReadProperty(DangKiMoMaDTProperty) == null ? (object)DBNull.Value : ReadProperty(DangKiMoMaDTProperty).Value).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@ChiTieuNhanDaoTao", ReadProperty(ChiTieuNhanDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(ChiTieuNhanDaoTaoProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(Id);
        }

        /// <summary>
        /// Deletes the <see cref="CDT_PhieuKhaoSat_DTSauDH"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_DTSauDH_delete", ctx.Connection))
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
