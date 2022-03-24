using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{
    [Serializable()]
    public partial class HuyBienLai_Info : BusinessBase<HuyBienLai_Info>
    {
        
        #region State Fields

        private String _LyDoHuy = String.Empty;
        private Int32 _IDHocVien = 0;
        private Int64 _IDBienLai = 0;
        private String _SoPhieuHuy = String.Empty;
        private Decimal _SoTien = 0;
        private DateTime _NgayHuy = GlobalCommon.GetTimeServer();
        private Int64 _IDNguoiHuy = 0;
        private string _NguoiNhan = string.Empty;
        private Int32 _TrangThai = 0;

        #endregion

        #region Business Properties and Methods

        public String LyDoHuy
        {
            get
            {
                return _LyDoHuy;
            }
            set
            {
                if (_LyDoHuy != value)
                {
                    _LyDoHuy = value;
                }
            }
        }

        public Int64 IDBienLai
        {
            get
            {
                return _IDBienLai;
            }
            set
            {
                if (_IDBienLai != value)
                {
                    _IDBienLai = value;
                }
            }
        }

        public Decimal SoTien
        {
            get
            {
                return _SoTien;
            }
            set
            {
                if (_SoTien != value)
                {
                    _SoTien = value;
                }
            }
        }

        public Int32 IDHocVien
        {
            get
            {
                return _IDHocVien;
            }
            set
            {
                if (_IDHocVien != value)
                {
                    _IDHocVien = value;
                }
            }
        }
        public String SoPhieuHuy
        {
            get
            {
                return _SoPhieuHuy;
            }
            set
            {
                if (_SoPhieuHuy != value)
                {
                    _SoPhieuHuy = value;
                }
            }
        }
        public DateTime NgayHuy
        {
            get
            {
                return _NgayHuy;
            }
            set
            {
                if (_NgayHuy != value)
                {
                    _NgayHuy = value;
                }
            }
        }
        public Int64 IDNguoiHuy
        {
            get
            {
                return _IDNguoiHuy;
            }
            set
            {
                if (_IDNguoiHuy != value)
                {
                    _IDNguoiHuy = value;
                }
            }
        }
        public String NguoiNhan
        {
            get
            {
                return _NguoiNhan;
            }
            set
            {
                if (_NguoiNhan != value)
                {
                    _NguoiNhan = value;
                }
            }
        }
        public Int32 TrangThai
        {
            get
            {
                return _TrangThai;
            }
            set
            {
                if (_TrangThai != value)
                {
                    _TrangThai = value;
                }
            }
        }
        protected override object GetIdValue()
        {
            return _LyDoHuy.ToString();
        }

        #endregion
        
        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. New <see cref="IP_SuDungDichVuDK_Info" /> Object is created, based on given parameters.
        /// </summary>
        public static HuyBienLai_Info NewHuyBienLai_Info()
        {
            return DataPortal.Create<HuyBienLai_Info>(new CriteriaNew());
        }

        /// <summary>
        /// Factory method. New <see cref="IP_SuDungDichVuDK_Info" /> Object is created and loaded from the given SafeDataReader.
        /// </summary>
        internal static HuyBienLai_Info GetHuyBienLai_Info(SafeDataReader dr)
        {
            HuyBienLai_Info obj = new HuyBienLai_Info();
            obj.Fetch(dr);
            obj.MarkOld();
            //obj.ValidationRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructors

        protected internal HuyBienLai_Info()
        {
            // Prevent direct creation

            // Show the framework that this is a Child Object
            MarkAsChild();
        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class CriteriaNew
        {
            public CriteriaNew()
            {
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaNew)
                {
                    CriteriaNew c = (CriteriaNew) obj;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaNew").GetHashCode();
            }
        }

        #endregion

        #region Authorization

        /// <summary>
        /// Checks if the role of the current user can retrieve IP_SuDungDichVuDK_Info's properties.
        /// </summary>
        public static bool CanGetObject()
        {
            return true;
        }

        /// <summary>
        /// Checks if the role of the current user can delete a IP_SuDungDichVuDK_Info object.
        /// </summary>
        public static bool CanDeleteObject()
        {
            return true;
        }

        /// <summary>
        /// Checks if the role of the current user can create a new IP_SuDungDichVuDK_Info object.
        /// </summary>
        public static bool CanAddObject()
        {
            return true;
        }

        /// <summary>
        /// Checks if the role of the current user can change IP_SuDungDichVuDK_Info's properties.
        /// </summary>
        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Load default values for the <see cref="IP_SuDungDichVuDK_Info" /> Object's properties from the database.
        /// </summary>
        [Csla.RunLocal()]
        protected void DataPortal_Create(CriteriaNew crit)
        {
            onCreate(this, EventArgs.Empty);
            //this.ValidationRules.CheckRules();
        }

        /// <summary>
        /// Load a <see cref="IP_SuDungDichVuDK_Info" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            //// Value properties
            //_maDieuKien = dr.GetString("MaDieuKien");
            //_yeuCauId = dr.GetInt64("YeuCauId");
            //_giaTP = dr.GetDecimal("GiaTP");
            //_giaTN = dr.GetDecimal("GiaTN");
            //ApplicationContext.LocalContext["dpDataReader"] = dr;
            //onFetchRead(this, EventArgs.Empty);
            //ApplicationContext.LocalContext["dpDataReader"] = null;
        }

        /// <summary>
        /// Insert <see cref="IP_SuDungDichVuDK_Info" /> Object to database with or without transaction.
        /// </summary>
        internal void Insert()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HuyBienLai_InfoAdd";
                onInsertStart(this, EventArgs.Empty);
                DoInsertUpdate(cmd);
                onInsertPre(this, EventArgs.Empty);
                cmd.ExecuteNonQuery();
                onInsertPost(this, EventArgs.Empty);
                MarkOld();
            }
        }
        internal void Insert(SqlTransaction tns)
        {
            using (SqlCommand cmd = tns.Connection.CreateCommand())
            {
                cmd.Transaction = tns;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HuyBienLai_InfoAdd";                
                onInsertStart(this, EventArgs.Empty);
                DoInsertUpdate(cmd);
                onInsertPre(this, EventArgs.Empty);
                cmd.ExecuteNonQuery();
                onInsertPost(this, EventArgs.Empty);
                MarkOld();
            }
        }
        /// <summary>
        /// Save <see cref="IP_SuDungDichVuDK_Info" /> Object to database with or without transaction.
        /// </summary>
        internal void Update()
        {
            if (base.IsDirty)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = (SqlConnection)ApplicationContext.LocalContext["dpConnection"];
                    cmd.Transaction = (SqlTransaction)ApplicationContext.LocalContext["dpTransaction"];
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "HuyBienLai_InfoUpd";
                    onUpdateStart(this, EventArgs.Empty);
                    DoInsertUpdate(cmd);
                    onUpdatePre(this, EventArgs.Empty);
                    cmd.ExecuteNonQuery();
                    onUpdatePost(this, EventArgs.Empty);
                    MarkOld();
                }
            }
        }

        private void DoInsertUpdate(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@IDHocVien", _IDHocVien).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@IDBienLai", _IDBienLai).DbType = DbType.Int64;
            cmd.Parameters.AddWithValue("@SoPhieuHuy", _SoPhieuHuy).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@SoTien", _SoTien).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@NgayHuy", _NgayHuy).DbType = DbType.DateTime;
            cmd.Parameters.AddWithValue("@IDNguoiHuy", _IDNguoiHuy).DbType = DbType.Int64;
            cmd.Parameters.AddWithValue("@NguoiNhan", _NguoiNhan).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@LyDoHuy", _LyDoHuy).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@TrangThai", _TrangThai).DbType = DbType.Int32; 
        }
        
        /// <summary>
        /// Delete <see cref="IP_SuDungDichVuDK_Info" /> Object from database with or without transaction.
        /// </summary>
        internal void DeleteSelf()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = (SqlConnection)ApplicationContext.LocalContext["dpConnection"];
                cmd.Transaction = (SqlTransaction)ApplicationContext.LocalContext["dpTransaction"];
                cmd.CommandType = CommandType.StoredProcedure;
                if (!IsNew)
                {
                    cmd.CommandText = "IP_SuDungDichVuDK_InfoDel";
                    cmd.Parameters.AddWithValue("@IDBienLai", _IDBienLai);
                    onDeletePre(this, EventArgs.Empty);
                    cmd.ExecuteNonQuery();
                    onDeletePost(this, EventArgs.Empty);
                }
            }
        }

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

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_insertStart;

        protected event EventHandler InsertStart
        {
            add
            {
                d_insertStart = (EventHandler)Delegate.Combine(d_insertStart, value);
            }
            remove
            {
                d_insertStart = (EventHandler)Delegate.Remove(d_insertStart, value);
            }
        }

        private void onInsertStart(object sender, EventArgs e)
        {
            if (d_insertStart != null)
                d_insertStart(sender, e);
        }

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_insertPre;

        protected event EventHandler InsertPre
        {
            add
            {
                d_insertPre = (EventHandler)Delegate.Combine(d_insertPre, value);
            }
            remove
            {
                d_insertPre = (EventHandler)Delegate.Remove(d_insertPre, value);
            }
        }

        private void onInsertPre(object sender, EventArgs e)
        {
            if (d_insertPre != null)
                d_insertPre(sender, e);
        }

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_insertPost;

        protected event EventHandler InsertPost
        {
            add
            {
                d_insertPost = (EventHandler)Delegate.Combine(d_insertPost, value);
            }
            remove
            {
                d_insertPost = (EventHandler)Delegate.Remove(d_insertPost, value);
            }
        }

        private void onInsertPost(object sender, EventArgs e)
        {
            if (d_insertPost != null)
                d_insertPost(sender, e);
        }

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_deletePre;

        protected event EventHandler DeletePre
        {
            add
            {
                d_deletePre = (EventHandler)Delegate.Combine(d_deletePre, value);
            }
            remove
            {
                d_deletePre = (EventHandler)Delegate.Remove(d_deletePre, value);
            }
        }

        private void onDeletePre(object sender, EventArgs e)
        {
            if (d_deletePre != null)
                d_deletePre(sender, e);
        }

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_deletePost;

        protected event EventHandler DeletePost
        {
            add
            {
                d_deletePost = (EventHandler)Delegate.Combine(d_deletePost, value);
            }
            remove
            {
                d_deletePost = (EventHandler)Delegate.Remove(d_deletePost, value);
            }
        }

        private void onDeletePost(object sender, EventArgs e)
        {
            if (d_deletePost != null)
                d_deletePost(sender, e);
        }

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

        [NonSerialized()]
        [NotUndoable()]
        private EventHandler d_create;

        protected event EventHandler Create
        {
            add
            {
                d_create = (EventHandler)Delegate.Combine(d_create, value);
            }
            remove
            {
                d_create = (EventHandler)Delegate.Remove(d_create, value);
            }
        }

        private void onCreate(object sender, EventArgs e)
        {
            if (d_create != null)
                d_create(sender, e);
        }

        #endregion

    }
}
