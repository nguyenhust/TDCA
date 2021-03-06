//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    DIC_TinhChild_Coll
// ObjectType:  DIC_TinhChild_Coll
// CSLAType:    EditableChildCollection

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;

namespace TruyenThong.LIB
{

    /// <summary>
    /// DIC_TinhChild_Coll (editable child list).<br/>
    /// This is a generated base class of <see cref="DIC_TinhChild_Coll"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is child of <see cref="DIC_Tinh"/> editable root object.<br/>
    /// The items of the collection are <see cref="DIC_TinhChild_Info"/> objects.
    /// </remarks>
    [Serializable]
    public partial class DIC_TinhChild_Coll : BusinessBindingListBase<DIC_TinhChild_Coll, DIC_TinhChild_Info>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="DIC_TinhChild_Info"/> item from the collection.
        /// </summary>
        /// <param name="id">The ID of the item to be removed.</param>
        public void Remove(Int64 id)
        {
            foreach (var dIC_TinhChild_Info in this)
            {
                if (dIC_TinhChild_Info.ID == id)
                {
                    Remove(dIC_TinhChild_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="DIC_TinhChild_Info"/> item is in the collection.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the DIC_TinhChild_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 id)
        {
            foreach (var dIC_TinhChild_Info in this)
            {
                if (dIC_TinhChild_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="DIC_TinhChild_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="id">The ID of the item to search for.</param>
        /// <returns><c>true</c> if the DIC_TinhChild_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(Int64 id)
        {
            foreach (var dIC_TinhChild_Info in this.DeletedList)
            {
                if (dIC_TinhChild_Info.ID == id)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DIC_TinhChild_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="DIC_TinhChild_Coll"/> collection.</returns>
        internal static DIC_TinhChild_Coll NewDIC_TinhChild_Coll()
        {
            return DataPortal.CreateChild<DIC_TinhChild_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="DIC_TinhChild_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDIC_TinhChild_Coll(EventHandler<DataPortalResult<DIC_TinhChild_Coll>> callback)
        {
            DataPortal.BeginCreate<DIC_TinhChild_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="DIC_TinhChild_Coll"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DIC_TinhChild_Coll"/> object.</returns>
        internal static DIC_TinhChild_Coll GetDIC_TinhChild_Coll(SafeDataReader dr)
        {
            DIC_TinhChild_Coll obj = new DIC_TinhChild_Coll();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DIC_TinhChild_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DIC_TinhChild_Coll()
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
        /// Loads all <see cref="DIC_TinhChild_Coll"/> collection items from the given SafeDataReader.
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
                Add(DIC_TinhChild_Info.GetDIC_TinhChild_Info(dr));
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
