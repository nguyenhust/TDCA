//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_HoiChuan_Detail
// ObjectType:  CDT_HoiChuan_Detail
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
    /// CDT_HoiChuan_Detail (editable root object).<br/>
    /// This is a generated base class of <see cref="CDT_HoiChuan_Detail"/> business object.
    /// </summary>
    [Serializable]
    public partial class CDT_HoiChuan_Detail : BusinessBase<CDT_HoiChuan_Detail>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="idHoiChuan"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IdHoiChuanProperty = RegisterProperty<int>(p => p.IdHoiChuan, "id Hoi Chuan");
        /// <summary>
        /// Gets or sets the id Hoi Chuan.
        /// </summary>
        /// <value>The id Hoi Chuan.</value>
        public int IdHoiChuan
        {
            get { return GetProperty(IdHoiChuanProperty); }
            set { SetProperty(IdHoiChuanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="sobenhvien"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SobenhvienProperty = RegisterProperty<int?>(p => p.Sobenhvien, "sobenhvien");
        /// <summary>
        /// Gets or sets the sobenhvien.
        /// </summary>
        /// <value>The sobenhvien.</value>
        public int? Sobenhvien
        {
            get { return GetProperty(SobenhvienProperty); }
            set { SetProperty(SobenhvienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="sobaocao"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SobaocaoProperty = RegisterProperty<int?>(p => p.Sobaocao, "sobaocao");
        /// <summary>
        /// Gets or sets the sobaocao.
        /// </summary>
        /// <value>The sobaocao.</value>
        public int? Sobaocao
        {
            get { return GetProperty(SobaocaoProperty); }
            set { SetProperty(SobaocaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="sothanhvien"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> SothanhvienProperty = RegisterProperty<int?>(p => p.Sothanhvien, "sothanhvien");
        /// <summary>
        /// Gets or sets the sothanhvien.
        /// </summary>
        /// <value>The sothanhvien.</value>
        public int? Sothanhvien
        {
            get { return GetProperty(SothanhvienProperty); }
            set { SetProperty(SothanhvienProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_HoiChuan_Detail"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_HoiChuan_Detail"/> object.</returns>
        public static CDT_HoiChuan_Detail NewCDT_HoiChuan_Detail()
        {
            return DataPortal.Create<CDT_HoiChuan_Detail>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_HoiChuan_Detail"/> object, based on given parameters.
        /// </summary>
        /// <param name="idHoiChuan">The IdHoiChuan parameter of the CDT_HoiChuan_Detail to fetch.</param>
        /// <returns>A reference to the fetched <see cref="CDT_HoiChuan_Detail"/> object.</returns>
        public static CDT_HoiChuan_Detail GetCDT_HoiChuan_Detail(int idHoiChuan)
        {
            return DataPortal.Fetch<CDT_HoiChuan_Detail>(idHoiChuan);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="CDT_HoiChuan_Detail"/> object, based on given parameters.
        /// </summary>
        /// <param name="idHoiChuan">The IdHoiChuan of the CDT_HoiChuan_Detail to delete.</param>
        public static void DeleteCDT_HoiChuan_Detail(int idHoiChuan)
        {
            DataPortal.Delete<CDT_HoiChuan_Detail>(idHoiChuan);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_HoiChuan_Detail"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_HoiChuan_Detail(EventHandler<DataPortalResult<CDT_HoiChuan_Detail>> callback)
        {
            DataPortal.BeginCreate<CDT_HoiChuan_Detail>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_HoiChuan_Detail"/> object, based on given parameters.
        /// </summary>
        /// <param name="idHoiChuan">The IdHoiChuan parameter of the CDT_HoiChuan_Detail to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_HoiChuan_Detail(int idHoiChuan, EventHandler<DataPortalResult<CDT_HoiChuan_Detail>> callback)
        {
            DataPortal.BeginFetch<CDT_HoiChuan_Detail>(idHoiChuan, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="CDT_HoiChuan_Detail"/> object, based on given parameters.
        /// </summary>
        /// <param name="idHoiChuan">The IdHoiChuan of the CDT_HoiChuan_Detail to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteCDT_HoiChuan_Detail(int idHoiChuan, EventHandler<DataPortalResult<CDT_HoiChuan_Detail>> callback)
        {
            DataPortal.BeginDelete<CDT_HoiChuan_Detail>(idHoiChuan, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_HoiChuan_Detail"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_HoiChuan_Detail()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_HoiChuan_Detail"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_HoiChuan_Detail"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="idHoiChuan">The id Hoi Chuan.</param>
        protected void DataPortal_Fetch(int idHoiChuan)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_Detail_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHoiChuan", idHoiChuan).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, idHoiChuan);
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
        /// Loads a <see cref="CDT_HoiChuan_Detail"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdHoiChuanProperty, dr.GetInt32("IdHoiChuan"));
            LoadProperty(SobenhvienProperty, dr.GetInt32("Sobenhvien"));
            LoadProperty(SobaocaoProperty, dr.GetInt32("Sobaocao"));
            LoadProperty(SothanhvienProperty, dr.GetInt32("Sothanhvien"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_HoiChuan_Detail"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_Detail_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHoiChuan", ReadProperty(IdHoiChuanProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@sobenhvien", ReadProperty(SobenhvienProperty) == null ? (object)DBNull.Value : ReadProperty(SobenhvienProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@sobaocao", ReadProperty(SobaocaoProperty) == null ? (object)DBNull.Value : ReadProperty(SobaocaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@sothanhvien", ReadProperty(SothanhvienProperty) == null ? (object)DBNull.Value : ReadProperty(SothanhvienProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CDT_HoiChuan_Detail"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_Detail_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHoiChuan", ReadProperty(IdHoiChuanProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@sobenhvien", ReadProperty(SobenhvienProperty) == null ? (object)DBNull.Value : ReadProperty(SobenhvienProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@sobaocao", ReadProperty(SobaocaoProperty) == null ? (object)DBNull.Value : ReadProperty(SobaocaoProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@sothanhvien", ReadProperty(SothanhvienProperty) == null ? (object)DBNull.Value : ReadProperty(SothanhvienProperty).Value).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_HoiChuan_Detail"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(IdHoiChuan);
        }

        /// <summary>
        /// Deletes the <see cref="CDT_HoiChuan_Detail"/> object from database.
        /// </summary>
        /// <param name="idHoiChuan">The delete criteria.</param>
        protected void DataPortal_Delete(int idHoiChuan)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_HoiChuan_Detail_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idHoiChuan", idHoiChuan).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, idHoiChuan);
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