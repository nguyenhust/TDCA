//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    MA_BVIEN
// ObjectType:  MA_BVIEN
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace oldSoft
{

    /// <summary>
    /// MA_BVIEN (editable root object).<br/>
    /// This is a generated base class of <see cref="MA_BVIEN"/> business object.
    /// </summary>
    [Serializable]
    public partial class MA_BVIEN : BusinessBase<MA_BVIEN>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="MA_BVIEN"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_BVIENProperty = RegisterProperty<string>(p => p.MA_BVIENx, "MA BVIEN");
        /// <summary>
        /// CDT.MA_BVIEN.MA_BVIEN
        /// </summary>
        /// <value>The MA BVIEN.</value>
        public string MA_BVIENx
        {
            get { return GetProperty(MA_BVIENProperty); }
            set { SetProperty(MA_BVIENProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_BVIEN"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_BVIENProperty = RegisterProperty<string>(p => p.TEN_BVIEN, "TEN BVIEN", null);
        /// <summary>
        /// CDT.MA_BVIEN.TEN_BVIEN
        /// </summary>
        /// <value>The TEN BVIEN.</value>
        public string TEN_BVIEN
        {
            get { return GetProperty(TEN_BVIENProperty); }
            set { SetProperty(TEN_BVIENProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DIA_CHI"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DIA_CHIProperty = RegisterProperty<string>(p => p.DIA_CHI, "DIA CHI", null);
        /// <summary>
        /// CDT.MA_BVIEN.DIA_CHI
        /// </summary>
        /// <value>The DIA CHI.</value>
        public string DIA_CHI
        {
            get { return GetProperty(DIA_CHIProperty); }
            set { SetProperty(DIA_CHIProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DUNG_TUYEN"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DUNG_TUYENProperty = RegisterProperty<string>(p => p.DUNG_TUYEN, "DUNG TUYEN", null);
        /// <summary>
        /// CDT.MA_BVIEN.DUNG_TUYEN
        /// </summary>
        /// <value>The DUNG TUYEN.</value>
        public string DUNG_TUYEN
        {
            get { return GetProperty(DUNG_TUYENProperty); }
            set { SetProperty(DUNG_TUYENProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_BVIEN_ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> MA_BVIEN_IDProperty = RegisterProperty<int>(p => p.MA_BVIEN_ID, "MA BVIEN ID");
        /// <summary>
        /// CDT.MA_BVIEN.MA_BVIEN_ID
        /// </summary>
        /// <value>The MA BVIEN ID.</value>
        public int MA_BVIEN_ID
        {
            get { return GetProperty(MA_BVIEN_IDProperty); }
            set { SetProperty(MA_BVIEN_IDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_BVIEN_KCC"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_BVIEN_KCCProperty = RegisterProperty<string>(p => p.MA_BVIEN_KCC, "MA BVIEN KCC", null);
        /// <summary>
        /// CDT.MA_BVIEN.MA_BVIEN_KCC
        /// </summary>
        /// <value>The MA BVIEN KCC.</value>
        public string MA_BVIEN_KCC
        {
            get { return GetProperty(MA_BVIEN_KCCProperty); }
            set { SetProperty(MA_BVIEN_KCCProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MA_TPHO"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MA_TPHOProperty = RegisterProperty<string>(p => p.MA_TPHO, "MA TPHO", null);
        /// <summary>
        /// CDT.MA_BVIEN.MA_TPHO
        /// </summary>
        /// <value>The MA TPHO.</value>
        public string MA_TPHO
        {
            get { return GetProperty(MA_TPHOProperty); }
            set { SetProperty(MA_TPHOProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TEN_THPO"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TEN_THPOProperty = RegisterProperty<string>(p => p.TEN_THPO, "TEN THPO", null);
        /// <summary>
        /// CDT.MA_BVIEN.TEN_THPO
        /// </summary>
        /// <value>The TEN THPO.</value>
        public string TEN_THPO
        {
            get { return GetProperty(TEN_THPOProperty); }
            set { SetProperty(TEN_THPOProperty, value); }
        }

        #endregion

        #region Factory Methods

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MA_BVIEN"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private MA_BVIEN()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="MA_BVIEN"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            //LoadProperty(MA_BVIENProperty, data.MA_BVIEN);
            //LoadProperty(TEN_BVIENProperty, data.TEN_BVIEN);
            //LoadProperty(DIA_CHIProperty, data.DIA_CHI);
            //LoadProperty(DUNG_TUYENProperty, data.DUNG_TUYEN);
            //LoadProperty(MA_BVIEN_IDProperty, data.MA_BVIEN_ID);
            //LoadProperty(MA_BVIEN_KCCProperty, data.MA_BVIEN_KCC);
            //LoadProperty(MA_TPHOProperty, data.MA_TPHO);
            //LoadProperty(TEN_THPOProperty, data.TEN_THPO);
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="MA_BVIEN"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.MA_BVIEN_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MA_BVIEN", ReadProperty(MA_BVIENProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_BVIEN", ReadProperty(TEN_BVIENProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_BVIENProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DIA_CHI", ReadProperty(DIA_CHIProperty) == null ? (object)DBNull.Value : ReadProperty(DIA_CHIProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DUNG_TUYEN", ReadProperty(DUNG_TUYENProperty) == null ? (object)DBNull.Value : ReadProperty(DUNG_TUYENProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_BVIEN_ID", ReadProperty(MA_BVIEN_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@MA_BVIEN_KCC", ReadProperty(MA_BVIEN_KCCProperty) == null ? (object)DBNull.Value : ReadProperty(MA_BVIEN_KCCProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_TPHO", ReadProperty(MA_TPHOProperty) == null ? (object)DBNull.Value : ReadProperty(MA_TPHOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_THPO", ReadProperty(TEN_THPOProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_THPOProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="MA_BVIEN"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection2"))
            {
                using (var cmd = new SqlCommand("dbo.MA_BVIEN_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MA_BVIEN", ReadProperty(MA_BVIENProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_BVIEN", ReadProperty(TEN_BVIENProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_BVIENProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DIA_CHI", ReadProperty(DIA_CHIProperty) == null ? (object)DBNull.Value : ReadProperty(DIA_CHIProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DUNG_TUYEN", ReadProperty(DUNG_TUYENProperty) == null ? (object)DBNull.Value : ReadProperty(DUNG_TUYENProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_BVIEN_ID", ReadProperty(MA_BVIEN_IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@MA_BVIEN_KCC", ReadProperty(MA_BVIEN_KCCProperty) == null ? (object)DBNull.Value : ReadProperty(MA_BVIEN_KCCProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MA_TPHO", ReadProperty(MA_TPHOProperty) == null ? (object)DBNull.Value : ReadProperty(MA_TPHOProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TEN_THPO", ReadProperty(TEN_THPOProperty) == null ? (object)DBNull.Value : ReadProperty(TEN_THPOProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
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