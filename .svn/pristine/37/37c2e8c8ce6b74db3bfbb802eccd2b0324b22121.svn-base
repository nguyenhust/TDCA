using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable]
    public partial class LoadLopHocLienTuc : BusinessBase<LoadLopHocLienTuc>
    {
        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDDieuTri"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDLopHocProperty = RegisterProperty<Int64>(p => p.IDLopHoc, "ID lớp học");
        /// <summary>
        /// ID dieu tri ma benh nhan dang nam dieu tri thuc hien hoan
        /// </summary>
        /// <value>The IDDieu Tri.</value>
        public Int64 IDLopHoc
        {
            get { return GetProperty(IDLopHocProperty); }
            set { SetProperty(IDLopHocProperty, value); }
        }

        public static readonly PropertyInfo<string> MaLopProperty = RegisterProperty<string>(p => p.MaLop, "Ma lop");
        /// <summary>
        /// So phieu hoan ky quy: yymmdd-99999
        /// </summary>
        /// <value>The So Phieu Hoan.</value>
        public string MaLop
        {
            get { return GetProperty(MaLopProperty); }
            set { SetProperty(MaLopProperty, value); }
        }

        public static readonly PropertyInfo<string> TenNguoiDongProperty = RegisterProperty<string>(p => p.TenNguoiDong, "Ten nguoi dong");
        /// <summary>
        /// So phieu hoan ky quy: yymmdd-99999
        /// </summary>
        /// <value>The So Phieu Hoan.</value>
        public string TenNguoiDong
        {
            get { return GetProperty(TenNguoiDongProperty); }
            set { SetProperty(TenNguoiDongProperty, value); }
        }

        public static readonly PropertyInfo<string> NoiCongTacProperty = RegisterProperty<string>(p => p.NoiCongTac, "Noi Cong Tac");
        /// <summary>
        /// So phieu hoan ky quy: yymmdd-99999
        /// </summary>
        /// <value>The So Phieu Hoan.</value>
        public string NoiCongTac
        {
            get { return GetProperty(NoiCongTacProperty); }
            set { SetProperty(NoiCongTacProperty, value); }
        }

        public static readonly PropertyInfo<string> NoiDungDTProperty = RegisterProperty<string>(p => p.NoiDungDT, "Noi dung dao tao");
        /// <summary>
        /// So phieu hoan ky quy: yymmdd-99999
        /// </summary>
        /// <value>The So Phieu Hoan.</value>
        public string NoiDungDT
        {
            get { return GetProperty(NoiDungDTProperty); }
            set { SetProperty(NoiDungDTProperty, value); }
        }
        #endregion

        #region Factory Methods

        public static LoadLopHocLienTuc GetLopHoc(Int64 iDLopHoc)
        {
            //if (!CanGetObject())
            //    throw new SystemException("Bạn không có quyền xem phiếu hoàn");
            return DataPortal.Fetch<LoadLopHocLienTuc>(iDLopHoc);
        }


        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="IP_HoanKyQuy"/> object, based on given parameters.
        /// </summary>
        /// <param name="iDPhieuHoan">The IDPhieuHoan parameter of the IP_HoanKyQuy to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetLopHoc(Int64 iDLopHoc, EventHandler<DataPortalResult<LoadLopHocLienTuc>> callback)
        {
            DataPortal.BeginFetch<LoadLopHocLienTuc>(iDLopHoc, callback);
        }


        public override LoadLopHocLienTuc Save()
        {
            //if (this.IsDirty)
            //if (!CanEditObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền sửa ký quỹ");
            return base.Save();
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_HoanKyQuy"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private LoadLopHocLienTuc()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="IP_HoanKyQuy"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            ////LoadProperty(IDPhieuHoanProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            //LoadProperty(IP_HoanKyQuy_ChiTiet_ChildProperty, DataPortal.CreateChild<IP_HoanKyQuy_ChiTiet_Coll>());
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="IP_HoanKyQuy"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="iDPhieuHoan">The IDPhieu Hoan.</param>
        protected void DataPortal_Fetch(Int64 iDLopHoc)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.LoadLopHocLienTuc_Get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDLopHoc", iDLopHoc).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd, iDLopHoc);
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
                    //FetchChildren(dr);
                }
            }
        }

        /// <summary>
        /// Loads a <see cref="IP_HoanKyQuy"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            //LoadProperty(IDPhieuHoanProperty, dr.GetInt64("IDPhieuHoan"));
            LoadProperty(IDLopHocProperty, dr.GetInt64("IDLopHoc"));
            LoadProperty(MaLopProperty, dr.GetString("MaLop"));
            LoadProperty(TenNguoiDongProperty, dr.GetString("TenNguoiDong"));
            LoadProperty(NoiCongTacProperty, dr.GetString("NoiCongTac"));
            LoadProperty(NoiDungDTProperty, dr.GetString("NoiDungDT"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
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
