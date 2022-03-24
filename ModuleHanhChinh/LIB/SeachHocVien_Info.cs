using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable]
    public partial class SeachHocVien_Info:BusinessBase<SeachHocVien_Info>

    {
        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDBienLai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> HoTenProperty = RegisterProperty<string>(p => p.HoTen, "Ho Ten");
        /// <summary>
        /// Gets or sets the Ho Ten.
        /// </summary>
        /// <value>The Ho Ten.</value>
        public string HoTen
        {
            get { return GetProperty(HoTenProperty); }
            set { SetProperty(HoTenProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="MaBienLai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaHocVienProperty = RegisterProperty<string>(p => p.MaHocVien, "Ma Hoc Vien");
        /// <summary>
        /// Gets or sets the Ma Bien Lai.
        /// </summary>
        /// <value>The Ma Bien Lai.</value>
        public string MaHocVien
        {
            get { return GetProperty(MaHocVienProperty); }
            set { SetProperty(MaHocVienProperty, value); }
        }

        public static readonly PropertyInfo<string> HinhThucHocProperty = RegisterProperty<string>(p => p.HinhThucHoc, "Hinh Thuc Hoc");
        /// <summary>
        /// Gets or sets the Hinh Thuc Hoc.
        /// </summary>
        /// <value>The Hinh Thuc Hoc.</value>
        public string HinhThucHoc
        {
            get { return GetProperty(HinhThucHocProperty); }
            set { SetProperty(HinhThucHocProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NoiDungDaoTao"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NoiDungDaoTaoProperty = RegisterProperty<string>(p => p.NoiDungDaoTao, "Noi Dung Dao Tao");
        /// <summary>
        /// Gets or sets the Noi Dung Dao Tao.
        /// </summary>
        /// <value>The Noi Dung Dao Tao.</value>
        public string NoiDungDaoTao
        {
            get { return GetProperty(NoiDungDaoTaoProperty); }
            set { SetProperty(NoiDungDaoTaoProperty, value); }
        }

        public static readonly PropertyInfo<string> ChuyenKhoaProperty = RegisterProperty<string>(p => p.ChuyenKhoa, "Noi Dung Dao Tao");
        /// <summary>
        /// Gets or sets the Noi Dung Dao Tao.
        /// </summary>
        /// <value>The Noi Dung Dao Tao.</value>
        public string ChuyenKhoa
        {
            get { return GetProperty(ChuyenKhoaProperty); }
            set { SetProperty(ChuyenKhoaProperty, value); }
        }
        /// <summary>
        /// Maintains metadata about <see cref="SoTien"/> property.
        /// </summary>
        public static readonly PropertyInfo<Decimal> SoTienProperty = RegisterProperty<Decimal>(p => p.SoTien, "So Tien");
        /// <summary>
        /// Gets or sets the So Tien.
        /// </summary>
        /// <value>The So Tien.</value>
        public Decimal SoTien
        {
            get { return GetProperty(SoTienProperty); }
            set { SetProperty(SoTienProperty, value); }
        }

        //public static readonly PropertyInfo<bool?> DaDongHocPhiProperty = RegisterProperty<bool?>(p => p.DaDongHocPhi, "Da Dong Hoc Phi");
        ///// <summary>
        ///// Gets or sets the Da Dong Hoc Phi.
        ///// </summary>
        ///// <value><c>true</c> if Da Dong Hoc Phi; <c>false</c> if not Da Dong Hoc Phi; otherwise, <c>null</c>.</value>
        //public bool? DaDongHocPhi
        //{
        //    get { return GetProperty(DaDongHocPhiProperty); }
        //    set { SetProperty(DaDongHocPhiProperty, value); }
        //}
    
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="IP_KyQuy_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="IP_KyQuy_Info"/> object.</returns>
        public static SeachHocVien_Info NewSeachHocVien_Info()
        {
            //if (!CanAddObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền thêm mới ký quỹ");
            return DataPortal.CreateChild<SeachHocVien_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="IP_KyQuy_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewSeachHocVien_Info(EventHandler<DataPortalResult<SeachHocVien_Info>> callback)
        {
            //if (!CanAddObject())
            //    throw new System.Security.SecurityException("Bạn không có quyền thêm mới ký quỹ");
            DataPortal.BeginCreate<SeachHocVien_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_KyQuy_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_KyQuy_Info"/> object.</returns>
        internal static SeachHocVien_Info GetSeachHocVien_Info(SafeDataReader dr)
        {
            SeachHocVien_Info obj = new SeachHocVien_Info();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
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
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IP_KyQuy_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private SeachHocVien_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion
        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="IP_KyQuy_Info"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {         
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(MaHocVienProperty, dr.GetString("MaHocVien"));
            LoadProperty(HoTenProperty, dr.GetString("HoTen"));
            LoadProperty(NoiDungDaoTaoProperty, dr.GetString("NoiDung"));
            LoadProperty(ChuyenKhoaProperty, dr.GetString("ChuyenKhoa"));
            LoadProperty(HinhThucHocProperty, dr.GetString("HinhThucHoc"));
            LoadProperty(SoTienProperty, dr.GetDecimal("SoTien"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }     
        #endregion
    }
}
