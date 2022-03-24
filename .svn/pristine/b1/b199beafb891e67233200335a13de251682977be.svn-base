using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using System.Data.Common;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable()]
    public partial class LyDoHuy_Coll : ReadOnlyListBase<LyDoHuy_Coll, LyDoHuy_Info>
    {
        #region Business Properties and Methods

        #endregion

        #region Criteria
        [Serializable]
        public class Criteria
        {
            //private Int64 _DichVuId;
            //public Int64 DichVuId
            //{
            //    get { return _DichVuId; }
            //    set { _DichVuId = value; }
            //}
            //private Int64 _YeuCauId;
            //public Int64 YeuCauId
            //{
            //    get { return _YeuCauId; }
            //    set { _YeuCauId = value; }
            //}
            public Criteria()
            {
            }
        }
        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. New <see cref="MS_DieuKien_Coll" /> Object is loaded from the database, based on given parameters.
        /// </summary>
        public static LyDoHuy_Coll GetLyDoHuy_Coll()
        {
            return DataPortal.Fetch<LyDoHuy_Coll>(new CriteriaGet());
        }
        public static LyDoHuy_Coll GetLyDoHuy_Get()
        {
            return DataPortal.Fetch<LyDoHuy_Coll>(new Criteria());
        }
        /// <summary>
        /// Factory method. New <see cref="MS_DieuKien_Coll" /> Object is created and loaded from the given SafeDataReader.
        /// </summary>
        internal static LyDoHuy_Coll GetMS_DieuKien_Coll(SafeDataReader dr)
        {
            LyDoHuy_Coll obj = new LyDoHuy_Coll();
            obj.Fetch(dr);

            return obj;
        }

        #endregion

        #region Constructors

        protected LyDoHuy_Coll()
        {
            // Prevent direct creation
        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class CriteriaGet
        {
            //private Int64 _DichVuId;
            //public Int64 DichVuId
            //{
            //    get { return _DichVuId; }
            //    set { _DichVuId = value; }
            //}
            //private Int64 _PatientId;
            //public Int64 PatientId
            //{
            //    get { return _PatientId; }
            //    set { _PatientId = value; }
            //}
            public CriteriaGet()
            {
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaGet)
                {
                    CriteriaGet c = (CriteriaGet) obj;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaGet").GetHashCode();
            }
        }

        #endregion

        #region Authorization

        /// <summary>
        /// Checks if the role of the current user can retrieve MS_DieuKien_Coll's properties.
        /// </summary>
        public static bool CanGetObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Load <see cref="MS_DieuKien_Coll" /> collection from the database, based on given parameters.
        /// </summary>
        protected void DataPortal_Fetch(CriteriaGet crit)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LyDoHuy_Coll_get";
                    cn.Open();
                    ApplicationContext.LocalContext["dpCriteria"] = crit;
                    LoadCollection(cmd);
                    IsReadOnly = true;
                }
            }
        }
        protected void DataPortal_Fetch(Criteria crit)
        {
            using (SqlConnection cn = new SqlConnection(DBConnection.Connection))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LyDoHuy_Coll_Get";
                    cn.Open();
                    ApplicationContext.LocalContext["dpCriteria"] = crit;
                    LoadCollection(cmd);
                    IsReadOnly = true;
                }
            }
        }
        private void LoadCollection(SqlCommand cmd)
        {
            ApplicationContext.LocalContext["dpCommand"] = cmd;
            ApplicationContext.LocalContext["dpConnection"] = cmd.Connection;
            onFetchPre(this, EventArgs.Empty);
            using (SafeDataReader dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                Fetch(dr);
            }
            ApplicationContext.LocalContext["dpCommand"] = cmd;
            ApplicationContext.LocalContext["dpConnection"] = cmd.Connection;
            onFetchPost(this, EventArgs.Empty);
        }

        /// <summary>
        /// Load all <see cref="MS_DieuKien_Coll" /> collection items from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            RaiseListChangedEvents = false;
            IsReadOnly = false;
            while (dr.Read())
            {
                LyDoHuy_Info obj = LyDoHuy_Info.GetLyDoHuy_Info(dr);
                Add(obj);
            }
            IsReadOnly = true;
            RaiseListChangedEvents = true;
        }

        #endregion

        #region Events

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_fetchPre;

        protected event EventHandler FetchPre
        {
            add
            {
                d_fetchPre = (EventHandler)Delegate.Combine(d_fetchPre, value);
            }
            remove
            {
                d_fetchPre = (EventHandler)Delegate.Remove(d_fetchPre, value);
            }
        }

        private void onFetchPre(object sender, EventArgs e)
        {
            if (d_fetchPre != null)
                d_fetchPre(sender, e);
        }

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_fetchPost;

        protected event EventHandler FetchPost
        {
            add
            {
                d_fetchPost = (EventHandler)Delegate.Combine(d_fetchPost, value);
            }
            remove
            {
                d_fetchPost = (EventHandler)Delegate.Remove(d_fetchPost, value);
            }
        }

        private void onFetchPost(object sender, EventArgs e)
        {
            if (d_fetchPost != null)
                d_fetchPost(sender, e);
        }

        #endregion

    }
}
