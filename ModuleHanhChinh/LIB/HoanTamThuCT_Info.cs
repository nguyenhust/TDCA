using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable]
    public partial class HoanTamThuCT_Info : BusinessBase<HoanTamThuCT_Info>
    {
        #region Business Properties


        /// <summary>
        /// Maintains metadata about <see cref="IDBienLaiKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDBienLaiTamUngProperty = RegisterProperty<Int64>(p => p.IDBienLaiTamUng, "IDBien Lai Tam Ung");
        /// <summary>
        /// Gets or sets the IDBien Lai Ky Quy.
        /// </summary>
        /// <value>The IDBien Lai Ky Quy.</value>
        public Int64 IDBienLaiTamUng
        {
            get { return GetProperty(IDBienLaiTamUngProperty); }
            set { SetProperty(IDBienLaiTamUngProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDDieuTri"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDHocVienProperty = RegisterProperty<Int64>(p => p.IDHocVien, "IDHoc Vien");
        /// <summary>
        /// Gets or sets the IDDieu Tri.
        /// </summary>
        /// <value>The IDDieu Tri.</value>
        public Int64 IDHocVien
        {
            get { return GetProperty(IDHocVienProperty); }
            set { SetProperty(IDHocVienProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MaBienLai"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MaBienLaiProperty = RegisterProperty<string>(p => p.MaBienLai, "Ma Bien Lai");
        /// <summary>
        /// Gets or sets the Ma Bien Lai.
        /// </summary>
        /// <value>The Ma Bien Lai.</value>
        public string MaBienLai
        {
            get { return GetProperty(MaBienLaiProperty); }
            set { SetProperty(MaBienLaiProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SoLan"/> property.
        /// </summary>
        public static readonly PropertyInfo<byte> SoLanProperty = RegisterProperty<byte>(p => p.SoLan, "So Lan");
        /// <summary>
        /// Gets or sets the So Lan.
        /// </summary>
        /// <value>The So Lan.</value>
        public byte SoLan
        {
            get { return GetProperty(SoLanProperty); }
            set { SetProperty(SoLanProperty, value); }
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

        /// <summary>
        /// Maintains metadata about <see cref="NgayKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayTamUngProperty = RegisterProperty<SmartDate>(p => p.NgayTamUng, "Ngay Ky Quy");
        /// <summary>
        /// Gets or sets the Ngay Ky Quy.
        /// </summary>
        /// <value>The Ngay Ky Quy.</value>
        public string NgayTamUng
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayTamUngProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayTamUngProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NguoiKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NguoiThuProperty = RegisterProperty<string>(p => p.NguoiThu, "Nguoi Ky Quy");
        /// <summary>
        /// Nguoi dong tien ky quy
        /// </summary>
        /// <value>The Nguoi Ky Quy.</value>
        public string NguoiThu
        {
            get { return GetProperty(NguoiThuProperty); }
            set { SetProperty(NguoiThuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDNguoiKyQuy"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDNguoiThuProperty = RegisterProperty<Int64>(p => p.IDNguoiThu, "IDNguoi Ky Quy");
        /// <summary>
        /// ID nguoi thu ky quy
        /// </summary>
        /// <value>The IDNguoi Ky Quy.</value>
        public Int64 IDNguoiThu
        {
            get { return GetProperty(IDNguoiThuProperty); }
            set { SetProperty(IDNguoiThuProperty, value); }
        }


        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object.</returns>
        public static HoanTamThuCT_Info NewHoanTamThuCT_Info()
        {
            return DataPortal.CreateChild<HoanTamThuCT_Info>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewHoanTamThuCT_Info(EventHandler<DataPortalResult<HoanTamThuCT_Info>> callback)
        {
            DataPortal.BeginCreate<HoanTamThuCT_Info>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object.</returns>
        internal static HoanTamThuCT_Info GetHoanTamThuCT_Info(SafeDataReader dr)
        {
            HoanTamThuCT_Info obj = new HoanTamThuCT_Info();
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
        /// Initializes a new instance of the <see cref="IP_HoanKyQuy_ChiTiet_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HoanTamThuCT_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }
        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object properties.
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
            LoadProperty(IDBienLaiTamUngProperty, dr.GetInt64("IDBienLaiTamUng"));
            //LoadProperty(IDDieuTriProperty,dr.GetInt64("IDDieuTri"));
            LoadProperty(MaBienLaiProperty, Convert.ToDecimal(dr.GetString("MaBienLai")).ToString("###/##/#######"));
            LoadProperty(NgayTamUngProperty, dr.GetSmartDate("NgayBienLai"));
            LoadProperty(SoTienProperty, dr.GetDecimal("SoTien"));
            //LoadProperty(IDNguoiKyQuyProperty, dr.GetInt64("IDNguoiThu"));
            LoadProperty(NguoiThuProperty, dr.GetString("NguoiThu"));
            LoadProperty(SoLanProperty, dr.GetByte("SoLan"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }


        /// <summary>
        /// Inserts a new <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        private void Child_Insert(HoanTamThu parent)
        {
            try
            {
                using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
                {
                    using (var cmd = new SqlCommand("dbo.HoanTamThu_ChiTiet_ins", ctx.Connection))
                    {
                        cmd.Transaction = ctx.Transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.AddWithValue("@IDPhieuHoan", parent.IDPhieuHoan).DbType = DbType.Int64;
                        cmd.Parameters.AddWithValue("@IDBienLaiTamThu", ReadProperty(IDBienLaiTamUngProperty)).DbType = DbType.Int64;
                        var args = new DataPortalHookArgs(cmd);
                        OnInsertPre(args);
                        cmd.ExecuteNonQuery();
                        OnInsertPost(args);
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object.
        /// sẽ không bao giờ xảy ra trường hợp update
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;
            try
            {
                using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
                {
                    using (var cmd = new SqlCommand("dbo.HoanTamThu_ChiTiet_Info_Upd", ctx.Connection))
                    {
                        cmd.Transaction = ctx.Transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDBienLaiTamThu", ReadProperty(IDBienLaiTamUngProperty)).DbType = DbType.Int64;
                        var args = new DataPortalHookArgs(cmd);
                        OnUpdatePre(args);
                        cmd.ExecuteNonQuery();
                        OnUpdatePost(args);
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
            }
        }

        /// <summary>
        /// Self deletes the <see cref="IP_HoanKyQuy_ChiTiet_Info"/> object from database.
        /// Không bjo xảy ra trường hợp delete
        /// </summary>
        private void Child_DeleteSelf()
        {
            try
            {
                using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
                {
                    using (var cmd = new SqlCommand("dbo.IP_HoanKyQuy_ChiTiet_Info_Delete", ctx.Connection))
                    {
                        cmd.Transaction = ctx.Transaction;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDBienLaiTamUng", ReadProperty(IDBienLaiTamUngProperty)).DbType = DbType.Int64;
                        var args = new DataPortalHookArgs(cmd);
                        OnDeletePre(args);
                        cmd.ExecuteNonQuery();
                        OnDeletePost(args);
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalCommon.ShowErrorMessager(ex);
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
