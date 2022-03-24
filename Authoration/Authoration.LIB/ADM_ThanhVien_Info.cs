﻿//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    ADM_ThanhVien_Info
// ObjectType:  ADM_ThanhVien_Info
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace Authoration.LIB
{

    /// <summary>
    /// ADM_ThanhVien_Info (editable child object).<br/>
    /// This is a generated base class of <see cref="ADM_ThanhVien_Info"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="ADM_ThanhVien_Coll"/> collection.
    /// </remarks>
    [Serializable]
    public partial class ADM_ThanhVien_Info : BusinessBase<ADM_ThanhVien_Info>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="IDQuyenDuocPhan"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDQuyenDuocPhanProperty = RegisterProperty<Int64>(p => p.IDQuyenDuocPhan, "IDQuyen Duoc Phan");
        /// <summary>
        /// Gets or sets the IDQuyen Duoc Phan.
        /// </summary>
        /// <value>The IDQuyen Duoc Phan.</value>
        public Int64 IDQuyenDuocPhan
        {
            get { return GetProperty(IDQuyenDuocPhanProperty); }
            set { SetProperty(IDQuyenDuocPhanProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IDNhomNguoiDung"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64> IDNhomNguoiDungProperty = RegisterProperty<Int64>(p => p.IDNhomNguoiDung, "IDNhom Nguoi Dung");
        /// <summary>
        /// Gets or sets the IDNhom Nguoi Dung.
        /// </summary>
        /// <value>The IDNhom Nguoi Dung.</value>
        public Int64 IDNhomNguoiDung
        {
            get { return GetProperty(IDNhomNguoiDungProperty); }
            set { SetProperty(IDNhomNguoiDungProperty, value); }
        }

        #endregion

        #region Authoration
        public static bool CanGetObject()
        {
            bool result = false;
            if (Csla.ApplicationContext.User.IsInRole("ThanhVien:S")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
                result = true;
            return result;
        }

        public static bool CanAddObject()
        {
            bool result = false;
            if (Csla.ApplicationContext.User.IsInRole("ThanhVien:I")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
                result = true;
            return result;
        }

        public static bool CanEditObject()
        {
            bool result = false;
            if (Csla.ApplicationContext.User.IsInRole("ThanhVien:U")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
                result = true;
            return result;
        }

        public static bool CanDeleteObject()
        {
            bool result = false;
            if (Csla.ApplicationContext.User.IsInRole("ThanhVien:D")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
                result = true;
            return result;
        }
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="ADM_ThanhVien_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="ADM_ThanhVien_Info"/> object.</returns>
        internal static ADM_ThanhVien_Info GetADM_ThanhVien_Info(SafeDataReader dr)
        {
            if (!CanGetObject())
                throw new System.Security.SecurityException("Bạn không có quyền xem ThanhVien");
            ADM_ThanhVien_Info obj = new ADM_ThanhVien_Info();
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
        /// Initializes a new instance of the <see cref="ADM_ThanhVien_Info"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public ADM_ThanhVien_Info()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="ADM_ThanhVien_Info"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDQuyenDuocPhanProperty, dr.GetInt64("IDQuyenDuocPhan"));
            LoadProperty(IDNhomNguoiDungProperty, dr.GetInt64("IDNhomNguoiDung"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="ADM_ThanhVien_Info"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        private void Child_Insert(ADM_NguoiDung parent)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.ADM_ThanhVien_Info_Add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDNguoiDung", parent.IDNguoiDung).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDQuyenDuocPhan", ReadProperty(IDQuyenDuocPhanProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDNhomNguoiDung", ReadProperty(IDNhomNguoiDungProperty)).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="ADM_ThanhVien_Info"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.ADM_ThanhVien_Info_Upd", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDQuyenDuocPhan", ReadProperty(IDQuyenDuocPhanProperty)).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@IDNhomNguoiDung", ReadProperty(IDNhomNguoiDungProperty)).DbType = DbType.Int64;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="ADM_ThanhVien_Info"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.ADM_ThanhVien_Info_Delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.Parameters.AddWithValue("@IDQuyenDuocPhan", ReadProperty(IDQuyenDuocPhanProperty)).DbType = DbType.Int64;
                    cmd.CommandType = CommandType.StoredProcedure;
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