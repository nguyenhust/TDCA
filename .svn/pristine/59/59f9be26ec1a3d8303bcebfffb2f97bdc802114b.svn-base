using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace ModuleHanhChinh.LIB
{
    [Serializable()]
    public partial class HuyBienLai_Coll : BusinessListBase<HuyBienLai_Coll, HuyBienLai_Info>
    {
        #region Business Properties and Methods

        /// <summary>
        /// Add new <see cref="IP_SuDungDichVuDK_Info"/> Object to the IP_SuDungDichVuDK_Coll collection.
        /// </summary>
        public void Add()
        {
            HuyBienLai_Info huyBienLai_Info = HuyBienLai_Info.NewHuyBienLai_Info();
            Add(huyBienLai_Info);
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="IP_SuDungDichVuDK_Info" /> collection.
        /// </summary>
        public static HuyBienLai_Coll NewHuyBienLai_Coll()
        {
            return new HuyBienLai_Coll();
        }

        /// <summary>
        /// Factory method. New <see cref="IP_SuDungDichVuDK_Coll" /> Object is created and loaded from the given SafeDataReader.
        /// </summary>
        internal static HuyBienLai_Coll GetHuyBienLai_Coll(SafeDataReader dr)
        {
            HuyBienLai_Coll obj = new HuyBienLai_Coll();
            obj.Fetch(dr);

            return obj;
        }

        #endregion

        #region Authorization

        /// <summary>
        /// Checks if the role of the current user can retrieve IP_SuDungDichVuDK_Coll's properties.
        /// </summary>
        public static bool CanGetObject()
        {
            return true;
        }

        /// <summary>
        /// Checks if the role of the current user can delete a IP_SuDungDichVuDK_Coll object.
        /// </summary>
        public static bool CanDeleteObject()
        {
            return true;
        }

        /// <summary>
        /// Checks if the role of the current user can create a new IP_SuDungDichVuDK_Coll object.
        /// </summary>
        public static bool CanAddObject()
        {
            return true;
        }

        /// <summary>
        /// Checks if the role of the current user can change IP_SuDungDichVuDK_Coll's properties.
        /// </summary>
        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Constructors

        public HuyBienLai_Coll()
        {
            // Prevent direct creation

            // Show the framework that this is a Child Object
            MarkAsChild();

            RaiseListChangedEvents = false;
            AllowNew = true;
            AllowEdit = true;
            AllowRemove = true;
            RaiseListChangedEvents = true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Load all <see cref="IP_SuDungDichVuDK_Coll" /> collection items from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                HuyBienLai_Info obj = HuyBienLai_Info.GetHuyBienLai_Info(dr);
                Add(obj);
            }
            RaiseListChangedEvents = true;
        }

        /// <summary>
        /// Update all changes made on <see cref="IP_SuDungDichVuDK_Coll" /> Object's children to the underlying database.
        /// </summary>
        internal void Update(SqlTransaction tns)
        {
            RaiseListChangedEvents = false;
            onUpdateStart(this, EventArgs.Empty);
            onUpdatePre(this, EventArgs.Empty);
            // Loop through the deleted child objects and call their Update methods
            foreach (HuyBienLai_Info child in DeletedList)
                child.DeleteSelf();

            //Now clear the deleted objects from the list
            DeletedList.Clear();

            // Loop through the objects to add and update, calling the Update Method
            foreach (HuyBienLai_Info child in this)
            {
                if (child.IsNew)
                    child.Insert();
                else
                    child.Update();
            }
            onUpdatePost(this, EventArgs.Empty);
            RaiseListChangedEvents = true;
        }
        //internal void Update(SqlTransaction tns, DichVuKhacCT parent)
        //{
        //    RaiseListChangedEvents = false;
        //    onUpdateStart(this, EventArgs.Empty);
        //    onUpdatePre(this, EventArgs.Empty);
        //    // Loop through the deleted child objects and call their Update methods
        //    foreach (IP_SuDungDichVuDK_Info child in DeletedList)
        //        child.DeleteSelf();

        //    //Now clear the deleted objects from the list
        //    DeletedList.Clear();

        //    // Loop through the objects to add and update, calling the Update Method
        //    foreach (IP_SuDungDichVuDK_Info child in this)
        //    {
        //        if (child.IsNew)
        //            child.Insert(tns, parent);
        //        else
        //            child.Update();
        //    }
        //    onUpdatePost(this, EventArgs.Empty);
        //    RaiseListChangedEvents = true;
        //}
        #endregion

        #region Events

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_updateStart;

        protected event EventHandler UpdateStart
        {
            add
            {
                d_updateStart = (EventHandler)Delegate.Combine(d_updateStart, value);
            }
            remove
            {
                d_updateStart = (EventHandler)Delegate.Remove(d_updateStart, value);
            }
        }

        private void onUpdateStart(object sender, EventArgs e)
        {
            if (d_updateStart != null)
                d_updateStart(sender, e);
        }

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_updatePre;

        protected event EventHandler UpdatePre
        {
            add
            {
                d_updatePre = (EventHandler)Delegate.Combine(d_updatePre, value);
            }
            remove
            {
                d_updatePre = (EventHandler)Delegate.Remove(d_updatePre, value);
            }
        }

        private void onUpdatePre(object sender, EventArgs e)
        {
            if (d_updatePre != null)
                d_updatePre(sender, e);
        }

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_updatePost;

        protected event EventHandler UpdatePost
        {
            add
            {
                d_updatePost = (EventHandler)Delegate.Combine(d_updatePost, value);
            }
            remove
            {
                d_updatePost = (EventHandler)Delegate.Remove(d_updatePost, value);
            }
        }

        private void onUpdatePost(object sender, EventArgs e)
        {
            if (d_updatePost != null)
                d_updatePost(sender, e);
        }

        #endregion

    }
}
