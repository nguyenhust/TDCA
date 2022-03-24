﻿//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    ADM_QuyenNguoiDung_Coll
// ObjectType:  ADM_QuyenNguoiDung_Coll
// CSLAType:    EditableChildCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace Authoration.LIB
{

    /// <summary>
    /// ADM_QuyenNguoiDung_Coll (editable child list).<br/>
    /// This is a generated base class of <see cref="ADM_QuyenNguoiDung_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is child of <see cref="ADM_NguoiDung"/> editable root object.<br/>
    /// The items of the collection are <see cref="ADM_QuyenNguoiDung_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class ADM_QuyenNguoiDung_Coll : BusinessBindingListBase<ADM_QuyenNguoiDung_Coll, ADM_QuyenNguoiDung_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="ADM_QuyenNguoiDung_Info"/> item from the collection.
        /// </summary>
        /// <param name="iDChucNang">The IDChucNang of the item to be removed.</param>
        public void Remove(int iDChucNang)
        {
            foreach (var aDM_QuyenNguoiDung_Info in this)
            {
                if (aDM_QuyenNguoiDung_Info.IDChucNang == iDChucNang)
                {
                    Remove(aDM_QuyenNguoiDung_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="ADM_QuyenNguoiDung_Info"/> item is in the collection.
        /// </summary>
        /// <param name="iDChucNang">The IDChucNang of the item to search for.</param>
        /// <returns><c>true</c> if the ADM_QuyenNguoiDung_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int iDChucNang)
        {
            foreach (var aDM_QuyenNguoiDung_Info in this)
            {
                if (aDM_QuyenNguoiDung_Info.IDChucNang == iDChucNang)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="ADM_QuyenNguoiDung_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="iDChucNang">The IDChucNang of the item to search for.</param>
        /// <returns><c>true</c> if the ADM_QuyenNguoiDung_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int iDChucNang)
        {
            foreach (var aDM_QuyenNguoiDung_Info in this.DeletedList)
            {
                if (aDM_QuyenNguoiDung_Info.IDChucNang == iDChucNang)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Authoration
        public static bool CanGetObject()
        {
            bool result = false;
            if (Csla.ApplicationContext.User.IsInRole("QuyenNguoiDung:S")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
                result = true;
            return result;
        }

        public static bool CanAddObject()
        {
            bool result = false;
            if (Csla.ApplicationContext.User.IsInRole("QuyenNguoiDung:I")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
                result = true;
            return result;
        }

        public static bool CanEditObject()
        {
            bool result = false;
            if (Csla.ApplicationContext.User.IsInRole("QuyenNguoiDung:U")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
                result = true;
            return result;
        }

        public static bool CanDeleteObject()
        {
            bool result = false;
            if (Csla.ApplicationContext.User.IsInRole("QuyenNguoiDung:D")
                || Csla.ApplicationContext.User.Identity.Name.ToUpper() == "SYSMAN")
                result = true;
            return result;
        }
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="ADM_QuyenNguoiDung_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="ADM_QuyenNguoiDung_Coll"/> collection.</returns>
        internal static ADM_QuyenNguoiDung_Coll NewADM_QuyenNguoiDung_Coll()
        {
            if (!CanAddObject())
                throw new System.Security.SecurityException("Bạn không có quyền thêm mới QuyenNguoiDung");
            return DataPortal.CreateChild<ADM_QuyenNguoiDung_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="ADM_QuyenNguoiDung_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewADM_QuyenNguoiDung_Coll(EventHandler<DataPortalResult<ADM_QuyenNguoiDung_Coll>> callback)
        {
            if (!CanAddObject())
                throw new System.Security.SecurityException("Bạn không có quyền thêm mới QuyenNguoiDung");
            DataPortal.BeginCreate<ADM_QuyenNguoiDung_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="ADM_QuyenNguoiDung_Coll"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="ADM_QuyenNguoiDung_Coll"/> object.</returns>
        internal static ADM_QuyenNguoiDung_Coll GetADM_QuyenNguoiDung_Coll(SafeDataReader dr)
        {
            if (!CanGetObject())
                throw new System.Security.SecurityException("Bạn không có quyền xem QuyenNguoiDung");
            ADM_QuyenNguoiDung_Coll obj = new ADM_QuyenNguoiDung_Coll();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            return obj;
        }

        public override ADM_QuyenNguoiDung_Coll Save()
        {
            if (IsDirty && !CanEditObject())
                throw new System.Security.SecurityException("Bạn không có quyền sửa đối tượng");
            else if (IsDirty && !CanDeleteObject())
                throw new System.Security.SecurityException("Bạn không có quyền xóa");
            return base.Save();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ADM_QuyenNguoiDung_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public ADM_QuyenNguoiDung_Coll()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = true;
            AllowEdit = true;
            AllowRemove = true;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads all <see cref="ADM_QuyenNguoiDung_Coll"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(ADM_QuyenNguoiDung_Info.GetADM_QuyenNguoiDung_Info(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Pseudo Events

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        #endregion

    }
}
