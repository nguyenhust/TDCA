using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace DanhMuc.LIB
{
    [Serializable]
    public partial class TrangThaiCuaHocVien_Info : ReadOnlyBase<TrangThaiCuaHocVien_Info>
    {
        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        public Int64 IDTrangThai { get; private set; }

        public string TenTrangThai { get; private set; }

        public string GhiChu { get; private set; }

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. Loads a <see cref="DIC_ChucVu_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DIC_ChucVu_Info"/> object.</returns>
        internal static TrangThaiCuaHocVien_Info GetTrangThaiCuaHocVien_Info(SafeDataReader dr)
        {
            TrangThaiCuaHocVien_Info obj = new TrangThaiCuaHocVien_Info();
            // show the framework that this is a child object
            obj.Fetch(dr);
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_ChucVu_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public TrangThaiCuaHocVien_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            IDTrangThai = dr.GetInt64("IDTrangThai");
            TenTrangThai = dr.GetString("TenTrangThai");
            GhiChu = !dr.IsDBNull("GhiChu") ? dr.GetString("GhiChu") : null;
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
