//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_GiangDuong_Phong_Info
// ObjectType:  HC_GiangDuong_Phong_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;
namespace ModuleHanhChinh.LIB
{

    /// <summary>
    /// HC_GiangDuong_Phong_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="HC_GiangDuong_Phong_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="HC_GiangDuong_Phong_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class HC_GiangDuong_Phong_Info : BusinessBase<HC_GiangDuong_Phong_Info>
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
        /// Maintains metadata about <see cref="MaPhong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaPhongProperty = RegisterProperty<string>(p => p.MaPhong, "Ma Phong");
        /// <summary>
        /// Gets or sets the Ma Phong.
        /// </summary>
        /// <value>The Ma Phong.</value>
        public string MaPhong
        {
            get { return GetProperty(MaPhongProperty); }
            set { SetProperty(MaPhongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TenPhong"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TenPhongProperty = RegisterProperty<string>(p => p.TenPhong, "Ten Phong");
        /// <summary>
        /// Gets or sets the Ten Phong.
        /// </summary>
        /// <value>The Ten Phong.</value>
        public string TenPhong
        {
            get { return GetProperty(TenPhongProperty); }
            set { SetProperty(TenPhongProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idNguoiQuanLy"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> IdNguoiQuanLyProperty = RegisterProperty<Int64?>(p => p.IdNguoiQuanLy, "id Nguoi Quan Ly");
        /// <summary>
        /// Gets or sets the id Nguoi Quan Ly.
        /// </summary>
        /// <value>The id Nguoi Quan Ly.</value>
        public Int64? IdNguoiQuanLy
        {
            get { return GetProperty(IdNguoiQuanLyProperty); }
            set { SetProperty(IdNguoiQuanLyProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TrangThai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TrangThaiProperty = RegisterProperty<string>(p => p.TrangThai, "Trang Thai");
        /// <summary>
        /// Gets or sets the Trang Thai.
        /// </summary>
        /// <value>The Trang Thai.</value>
        public string TrangThai
        {
            get { return GetProperty(TrangThaiProperty); }
            set { SetProperty(TrangThaiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NoiDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDungProperty = RegisterProperty<string>(p => p.NoiDung, "Noi Dung");
        /// <summary>
        /// Gets or sets the Noi Dung.
        /// </summary>
        /// <value>The Noi Dung.</value>
        public string NoiDung
        {
            get { return GetProperty(NoiDungProperty); }
            set { SetProperty(NoiDungProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DiaDiem"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DiaDiemProperty = RegisterProperty<string>(p => p.DiaDiem, "Dia Diem");
        /// <summary>
        /// Gets or sets the Dia Diem.
        /// </summary>
        /// <value>The Dia Diem.</value>
        public string DiaDiem
        {
            get { return GetProperty(DiaDiemProperty); }
            set { SetProperty(DiaDiemProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThietBiDiKem"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ThietBiDiKemProperty = RegisterProperty<string>(p => p.ThietBiDiKem, "Thiet Bi Di Kem");
        /// <summary>
        /// Gets or sets the Thiet Bi Di Kem.
        /// </summary>
        /// <value>The Thiet Bi Di Kem.</value>
        public string ThietBiDiKem
        {
            get { return GetProperty(ThietBiDiKemProperty); }
            set { SetProperty(ThietBiDiKemProperty, value); }
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
        /// Factory method. Creates a new <see cref="HC_GiangDuong_Phong_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_GiangDuong_Phong_Info"/> object.</returns>
        internal static HC_GiangDuong_Phong_Info NewHC_GiangDuong_Phong_Info()
        {
            return DataPortal.CreateChild<HC_GiangDuong_Phong_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_GiangDuong_Phong_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewHC_GiangDuong_Phong_Info(EventHandler<DataPortalResult<HC_GiangDuong_Phong_Info>> callback)
        {
            DataPortal.BeginCreate<HC_GiangDuong_Phong_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_GiangDuong_Phong_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="HC_GiangDuong_Phong_Info"/> object.</returns>
        internal static HC_GiangDuong_Phong_Info GetHC_GiangDuong_Phong_Info(SafeDataReader dr)
        {
            HC_GiangDuong_Phong_Info obj = new HC_GiangDuong_Phong_Info();
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
        /// Initializes a new instance of the <see cref="HC_GiangDuong_Phong_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_GiangDuong_Phong_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="HC_GiangDuong_Phong_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(MaPhongProperty, null);
            LoadProperty(TenPhongProperty, null);
            LoadProperty(TrangThaiProperty, null);
            LoadProperty(NoiDungProperty, null);
            LoadProperty(DiaDiemProperty, null);
            LoadProperty(ThietBiDiKemProperty, null);
            LoadProperty(GhiChuProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="HC_GiangDuong_Phong_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(MaPhongProperty, dr.GetString("MaPhong"));
            LoadProperty(TenPhongProperty, dr.GetString("TenPhong"));
            LoadProperty(IdNguoiQuanLyProperty, dr.GetInt64("IdNguoiQuanLy"));
            LoadProperty(TrangThaiProperty, dr.GetString("TrangThai"));
            LoadProperty(NoiDungProperty, dr.GetString("NoiDung"));
            LoadProperty(DiaDiemProperty, dr.GetString("DiaDiem"));
            LoadProperty(ThietBiDiKemProperty, dr.GetString("ThietBiDiKem"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="HC_GiangDuong_Phong_Info"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_GiangDuong_Phong_Info_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@MaPhong", ReadProperty(MaPhongProperty) == null ? (object)DBNull.Value : ReadProperty(MaPhongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenPhong", ReadProperty(TenPhongProperty) == null ? (object)DBNull.Value : ReadProperty(TenPhongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idNguoiQuanLy", ReadProperty(IdNguoiQuanLyProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguoiQuanLyProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@TrangThai", ReadProperty(TrangThaiProperty) == null ? (object)DBNull.Value : ReadProperty(TrangThaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DiaDiem", ReadProperty(DiaDiemProperty) == null ? (object)DBNull.Value : ReadProperty(DiaDiemProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThietBiDiKem", ReadProperty(ThietBiDiKemProperty) == null ? (object)DBNull.Value : ReadProperty(ThietBiDiKemProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (int) cmd.Parameters["@ID"].Value);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_GiangDuong_Phong_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_GiangDuong_Phong_Info_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@MaPhong", ReadProperty(MaPhongProperty) == null ? (object)DBNull.Value : ReadProperty(MaPhongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@TenPhong", ReadProperty(TenPhongProperty) == null ? (object)DBNull.Value : ReadProperty(TenPhongProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@idNguoiQuanLy", ReadProperty(IdNguoiQuanLyProperty) == null ? (object)DBNull.Value : ReadProperty(IdNguoiQuanLyProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@TrangThai", ReadProperty(TrangThaiProperty) == null ? (object)DBNull.Value : ReadProperty(TrangThaiProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@NoiDung", ReadProperty(NoiDungProperty) == null ? (object)DBNull.Value : ReadProperty(NoiDungProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DiaDiem", ReadProperty(DiaDiemProperty) == null ? (object)DBNull.Value : ReadProperty(DiaDiemProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThietBiDiKem", ReadProperty(ThietBiDiKemProperty) == null ? (object)DBNull.Value : ReadProperty(ThietBiDiKemProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="HC_GiangDuong_Phong_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_GiangDuong_Phong_Info_delete", ctx.Connection))
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
