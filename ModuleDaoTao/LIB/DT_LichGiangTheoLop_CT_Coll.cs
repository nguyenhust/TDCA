using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleDaoTao.LIB
{

    [Serializable]
    public partial class DT_LichGiangTheoLop_CT_Coll : BusinessBindingListBase<DT_LichGiangTheoLop_CT_Coll,DT_LichGiangTheoLop_CT_Info>
    {
        
        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="PhieuNhapCT_Info"/> item from the collection.
        /// </summary>
        /// <param name="iDPhieuNhapCT">The IDPhieuNhapCT of the item to be removed.</param>
        public void Remove(Int64 iDLichGiangCT)
        {
            foreach (var dt_lichgiangtheolop_CT_Info in this)
            {
                if (dt_lichgiangtheolop_CT_Info.IDLichGiangCT == iDLichGiangCT)
                {
                    Remove(dt_lichgiangtheolop_CT_Info);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="PhieuNhapCT_Info"/> item is in the collection.
        /// </summary>
        /// <param name="iDPhieuNhapCT">The IDPhieuNhapCT of the item to search for.</param>
        /// <returns><c>true</c> if the PhieuNhapCT_Info is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(Int64 iDLichGiangCT)
        {
            foreach (var dt_lichgiangtheolop_CT_Info in this)
            {
                if (dt_lichgiangtheolop_CT_Info.IDLichGiangCT == iDLichGiangCT)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="PhieuNhapCT_Info"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="iDPhieuNhapCT">The IDPhieuNhapCT of the item to search for.</param>
        /// <returns><c>true</c> if the PhieuNhapCT_Info is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(Int64 iDLichGiangCT)
        {
            foreach (var dt_lichgiangtheolop_CT_Info in this.DeletedList)
            {
                if (dt_lichgiangtheolop_CT_Info.IDLichGiangCT == iDLichGiangCT)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PhieuNhapCT_Coll"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="PhieuNhapCT_Coll"/> collection.</returns>
        internal static DT_LichGiangTheoLop_CT_Coll NewDT_LichGiangTheoLop_CT_Coll()
        {
            return DataPortal.CreateChild<DT_LichGiangTheoLop_CT_Coll>();
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="PhieuNhapCT_Coll"/> collection.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        internal static void NewDT_LichGiangTheoLop_CT_Coll(EventHandler<DataPortalResult<DT_LichGiangTheoLop_CT_Coll>> callback)
        {
            DataPortal.BeginCreate<DT_LichGiangTheoLop_CT_Coll>(callback);
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PhieuNhapCT_Coll"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PhieuNhapCT_Coll"/> object.</returns>
        internal static DT_LichGiangTheoLop_CT_Coll GetDT_LichGiangTheoLop_CT_Coll(SafeDataReader dr)
        {
            DT_LichGiangTheoLop_CT_Coll obj = new DT_LichGiangTheoLop_CT_Coll();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PhieuNhapCT_Coll"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private DT_LichGiangTheoLop_CT_Coll()
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
        /// Loads all <see cref="PhieuNhapCT_Coll"/> collection items from the given SafeDataReader.
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
                Add(DT_LichGiangTheoLop_CT_Info.GetDT_LichGiangTheoLop_CT_Info(dr));
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
