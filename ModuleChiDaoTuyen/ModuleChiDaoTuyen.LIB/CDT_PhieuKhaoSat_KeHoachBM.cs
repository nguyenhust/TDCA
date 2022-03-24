//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_PhieuKhaoSat_KeHoachBM
// ObjectType:  CDT_PhieuKhaoSat_KeHoachBM
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
    /// CDT_PhieuKhaoSat_KeHoachBM (editable root object).<br/>
    /// This is a generated base class of <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> business object.
    /// </summary>
    [Serializable]
    public partial class CDT_PhieuKhaoSat_KeHoachBM : BusinessBase<CDT_PhieuKhaoSat_KeHoachBM>
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
        /// Maintains metadata about <see cref="DoiTuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DoiTuongProperty = RegisterProperty<string>(p => p.DoiTuong, "Doi Tuong");
        /// <summary>
        /// Gets or sets the Doi Tuong.
        /// </summary>
        /// <value>The Doi Tuong.</value>
        public string DoiTuong
        {
            get { return GetProperty(DoiTuongProperty); }
            set { SetProperty(DoiTuongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiLuong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ThoiLuongProperty = RegisterProperty<string>(p => p.ThoiLuong, "Thoi Luong");
        /// <summary>
        /// Gets or sets the Thoi Luong.
        /// </summary>
        /// <value>The Thoi Luong.</value>
        public string ThoiLuong
        {
            get { return GetProperty(ThoiLuongProperty); }
            set { SetProperty(ThoiLuongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DonViPhoiHop"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DonViPhoiHopProperty = RegisterProperty<string>(p => p.DonViPhoiHop, "Don Vi Phoi Hop");
        /// <summary>
        /// Gets or sets the Don Vi Phoi Hop.
        /// </summary>
        /// <value>The Don Vi Phoi Hop.</value>
        public string DonViPhoiHop
        {
            get { return GetProperty(DonViPhoiHopProperty); }
            set { SetProperty(DonViPhoiHopProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object.</returns>
        public static CDT_PhieuKhaoSat_KeHoachBM NewCDT_PhieuKhaoSat_KeHoachBM()
        {
            return DataPortal.Create<CDT_PhieuKhaoSat_KeHoachBM>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the CDT_PhieuKhaoSat_KeHoachBM to fetch.</param>
        /// <returns>A reference to the fetched <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object.</returns>
        public static CDT_PhieuKhaoSat_KeHoachBM GetCDT_PhieuKhaoSat_KeHoachBM(int id)
        {
            return DataPortal.Fetch<CDT_PhieuKhaoSat_KeHoachBM>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the CDT_PhieuKhaoSat_KeHoachBM to delete.</param>
        public static void DeleteCDT_PhieuKhaoSat_KeHoachBM(int id)
        {
            DataPortal.Delete<CDT_PhieuKhaoSat_KeHoachBM>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_PhieuKhaoSat_KeHoachBM(EventHandler<DataPortalResult<CDT_PhieuKhaoSat_KeHoachBM>> callback)
        {
            DataPortal.BeginCreate<CDT_PhieuKhaoSat_KeHoachBM>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id parameter of the CDT_PhieuKhaoSat_KeHoachBM to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_PhieuKhaoSat_KeHoachBM(int id, EventHandler<DataPortalResult<CDT_PhieuKhaoSat_KeHoachBM>> callback)
        {
            DataPortal.BeginFetch<CDT_PhieuKhaoSat_KeHoachBM>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The Id of the CDT_PhieuKhaoSat_KeHoachBM to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteCDT_PhieuKhaoSat_KeHoachBM(int id, EventHandler<DataPortalResult<CDT_PhieuKhaoSat_KeHoachBM>> callback)
        {
            DataPortal.BeginDelete<CDT_PhieuKhaoSat_KeHoachBM>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_PhieuKhaoSat_KeHoachBM()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(DoiTuongProperty, null);
            LoadProperty(ThoiLuongProperty, null);
            LoadProperty(DonViPhoiHopProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The id.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_KeHoachBM_get", ctx.Connection))
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
        /// Loads a <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdPhieuKhaoSatProperty, dr.GetInt32("IdPhieuKhaoSat"));
            LoadProperty(IdChuDeDaoTaoProperty, dr.GetInt32("IdChuDeDaoTao"));
            LoadProperty(DoiTuongProperty, dr.GetString("DoiTuong"));
            LoadProperty(ThoiLuongProperty, dr.GetString("ThoiLuong"));
            LoadProperty(DonViPhoiHopProperty, dr.GetString("DonViPhoiHop"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_KeHoachBM_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idChuDeDaoTao", ReadProperty(IdChuDeDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuDeDaoTaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DoiTuong", ReadProperty(DoiTuongProperty) == null ? (object)DBNull.Value : ReadProperty(DoiTuongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiLuong", ReadProperty(ThoiLuongProperty) == null ? (object)DBNull.Value : ReadProperty(ThoiLuongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DonViPhoiHop", ReadProperty(DonViPhoiHopProperty) == null ? (object)DBNull.Value : ReadProperty(DonViPhoiHopProperty)).DbType = DbType.String;
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
        /// Updates in the database all changes made to the <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_KeHoachBM_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty) == null ? (object)DBNull.Value : ReadProperty(IdPhieuKhaoSatProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idChuDeDaoTao", ReadProperty(IdChuDeDaoTaoProperty) == null ? (object)DBNull.Value : ReadProperty(IdChuDeDaoTaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DoiTuong", ReadProperty(DoiTuongProperty) == null ? (object)DBNull.Value : ReadProperty(DoiTuongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiLuong", ReadProperty(ThoiLuongProperty) == null ? (object)DBNull.Value : ReadProperty(ThoiLuongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DonViPhoiHop", ReadProperty(DonViPhoiHopProperty) == null ? (object)DBNull.Value : ReadProperty(DonViPhoiHopProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(Id);
        }

        /// <summary>
        /// Deletes the <see cref="CDT_PhieuKhaoSat_KeHoachBM"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_KeHoachBM_delete", ctx.Connection))
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
