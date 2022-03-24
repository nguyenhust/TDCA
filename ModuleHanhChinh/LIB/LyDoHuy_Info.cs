using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace ModuleHanhChinh.LIB
{

    [Serializable()]
    public partial class LyDoHuy_Info : ReadOnlyBase<LyDoHuy_Info>
    {
        #region State Fields

        private String _LyDoHuy = String.Empty;
        private Int64 _IDHuy = 0;

        #endregion

        #region Business Properties and Methods

        public String LyDoHuy
        {
            get
            {
                return _LyDoHuy;
            }
        }
        public Int64 IDHuy
        {
            get
            {
                return _IDHuy;
            }
        }
       

        protected override object GetIdValue()
        {
            return _LyDoHuy;
        }

        #endregion

        #region Constructors

        public LyDoHuy_Info()
        {
            // Prevent direct creation
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. New <see cref="MS_DieuKien_Info" /> Object is created and loaded from the given SafeDataReader.
        /// </summary>
        internal static LyDoHuy_Info GetLyDoHuy_Info(SafeDataReader dr)
        {
            LyDoHuy_Info obj = new LyDoHuy_Info();
            obj.Fetch(dr);

            return obj;
        }

        #endregion

        #region Authorization

        /// <summary>
        /// Checks if the role of the current user can retrieve MS_DieuKien_Info's properties.
        /// </summary>
        public static bool CanGetObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Load a <see cref="MS_DieuKien_Info" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            _IDHuy = dr.GetInt64("IDHuy");
            _LyDoHuy = dr.GetString("LyDoHuy");
            ApplicationContext.LocalContext["dpDataReader"] = dr;
            onFetchRead(this, EventArgs.Empty);
            ApplicationContext.LocalContext["dpDataReader"] = null;
        }

        #endregion

        #region Events

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_fetchRead;

        protected event EventHandler FetchRead
        {
            add
            {
                d_fetchRead = (EventHandler)Delegate.Combine(d_fetchRead, value);
            }
            remove
            {
                d_fetchRead = (EventHandler)Delegate.Remove(d_fetchRead, value);
            }
        }

        private void onFetchRead(object sender, EventArgs e)
        {
            if (d_fetchRead != null)
                d_fetchRead(sender, e);
        }

        #endregion
    }
}
