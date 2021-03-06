//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    CDT_PhieuKhaoSat_YeuCauHoTro
// ObjectType:  CDT_PhieuKhaoSat_YeuCauHoTro
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleChiDaoTuyen.LIB
{

    /// <summary>
    /// CDT_PhieuKhaoSat_YeuCauHoTro (editable root object).<br/>
    /// This is a generated base class of <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> business object.
    /// </summary>
    [Serializable]
    public partial class CDT_PhieuKhaoSat_YeuCauHoTro : BusinessBase<CDT_PhieuKhaoSat_YeuCauHoTro>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="idPhieuKhaoSat"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IdPhieuKhaoSatProperty = RegisterProperty<int>(p => p.IdPhieuKhaoSat, "id Phieu Khao Sat");
        /// <summary>
        /// Gets the id Phieu Khao Sat.
        /// </summary>
        /// <value>The id Phieu Khao Sat.</value>
        public int IdPhieuKhaoSat
        {
            get { return GetProperty(IdPhieuKhaoSatProperty); }
            set { SetProperty(IdPhieuKhaoSatProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="idPhieuKhaoSat"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(p => p.Id, "id");
        /// <summary>
        /// Gets the id Phieu Khao Sat.
        /// </summary>
        /// <value>The id Phieu Khao Sat.</value>
        public int Id
        {
            get { return GetProperty(IdProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro1"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro1Property = RegisterProperty<string>(p => p.YeuCauHoTro1, "Yeu Cau Ho Tro1");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro1.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro1.</value>
        public string YeuCauHoTro1
        {
            get { return GetProperty(YeuCauHoTro1Property); }
            set { SetProperty(YeuCauHoTro1Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro2"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro2Property = RegisterProperty<string>(p => p.YeuCauHoTro2, "Yeu Cau Ho Tro2");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro2.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro2.</value>
        public string YeuCauHoTro2
        {
            get { return GetProperty(YeuCauHoTro2Property); }
            set { SetProperty(YeuCauHoTro2Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro3"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro3Property = RegisterProperty<string>(p => p.YeuCauHoTro3, "Yeu Cau Ho Tro3");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro3.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro3.</value>
        public string YeuCauHoTro3
        {
            get { return GetProperty(YeuCauHoTro3Property); }
            set { SetProperty(YeuCauHoTro3Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro4"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro4Property = RegisterProperty<string>(p => p.YeuCauHoTro4, "Yeu Cau Ho Tro4");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro4.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro4.</value>
        public string YeuCauHoTro4
        {
            get { return GetProperty(YeuCauHoTro4Property); }
            set { SetProperty(YeuCauHoTro4Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro5Property = RegisterProperty<string>(p => p.YeuCauHoTro5, "Yeu Cau Ho Tro5");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public string YeuCauHoTro5
        {
            get { return GetProperty(YeuCauHoTro5Property); }
            set { SetProperty(YeuCauHoTro5Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro6"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro6Property = RegisterProperty<string>(p => p.YeuCauHoTro6, "Yeu Cau Ho Tro6");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro6.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro6.</value>
        public string YeuCauHoTro6
        {
            get { return GetProperty(YeuCauHoTro6Property); }
            set { SetProperty(YeuCauHoTro6Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro7"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro7Property = RegisterProperty<string>(p => p.YeuCauHoTro7, "Yeu Cau Ho Tro7");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro7.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro7.</value>
        public string YeuCauHoTro7
        {
            get { return GetProperty(YeuCauHoTro7Property); }
            set { SetProperty(YeuCauHoTro7Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro8"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro8Property = RegisterProperty<string>(p => p.YeuCauHoTro8, "Yeu Cau Ho Tro8");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro8.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro8.</value>
        public string YeuCauHoTro8
        {
            get { return GetProperty(YeuCauHoTro8Property); }
            set { SetProperty(YeuCauHoTro8Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro9"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro9Property = RegisterProperty<string>(p => p.YeuCauHoTro9, "Yeu Cau Ho Tro9");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro9.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro9.</value>
        public string YeuCauHoTro9
        {
            get { return GetProperty(YeuCauHoTro9Property); }
            set { SetProperty(YeuCauHoTro9Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro10"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> YeuCauHoTro10Property = RegisterProperty<string>(p => p.YeuCauHoTro10, "Yeu Cau Ho Tro10");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro10.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro10.</value>
        public string YeuCauHoTro10
        {
            get { return GetProperty(YeuCauHoTro10Property); }
            set { SetProperty(YeuCauHoTro10Property, value); }
        }


        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro1Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro1, "Co Yeu Cau Ho Tro1");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro1
        {
            get { return GetProperty(CoYeuCauHoTro1Property); }
            set { SetProperty(CoYeuCauHoTro1Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro2Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro2, "Co Yeu Cau Ho Tro2");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro2
        {
            get { return GetProperty(CoYeuCauHoTro2Property); }
            set { SetProperty(CoYeuCauHoTro2Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro3Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro3, "Co Yeu Cau Ho Tro3");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro3
        {
            get { return GetProperty(CoYeuCauHoTro3Property); }
            set { SetProperty(CoYeuCauHoTro3Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro4Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro4, "Co Yeu Cau Ho Tro4");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro4
        {
            get { return GetProperty(CoYeuCauHoTro4Property); }
            set { SetProperty(CoYeuCauHoTro4Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro5Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro5, "Co Yeu Cau Ho Tro5");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro5
        {
            get { return GetProperty(CoYeuCauHoTro5Property); }
            set { SetProperty(CoYeuCauHoTro5Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro6Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro6, "Co Yeu Cau Ho Tro6");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro6
        {
            get { return GetProperty(CoYeuCauHoTro6Property); }
            set { SetProperty(CoYeuCauHoTro6Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro7Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro7, "Co Yeu Cau Ho Tro7");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro7
        {
            get { return GetProperty(CoYeuCauHoTro7Property); }
            set { SetProperty(CoYeuCauHoTro7Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro8Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro8, "Co Yeu Cau Ho Tro8");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro8
        {
            get { return GetProperty(CoYeuCauHoTro8Property); }
            set { SetProperty(CoYeuCauHoTro8Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro10Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro10, "Co Yeu Cau Ho Tro10");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro10
        {
            get { return GetProperty(CoYeuCauHoTro10Property); }
            set { SetProperty(CoYeuCauHoTro10Property, value); }
        }

        // truong de phan biet yeu cau co hay khong
        /// <summary>
        /// Maintains metadata about <see cref="YeuCauHoTro5"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> CoYeuCauHoTro9Property = RegisterProperty<bool>(p => p.CoYeuCauHoTro9, "Co Yeu Cau Ho Tro9");
        /// <summary>
        /// Gets or sets the Yeu Cau Ho Tro5.
        /// </summary>
        /// <value>The Yeu Cau Ho Tro5.</value>
        public bool CoYeuCauHoTro9
        {
            get { return GetProperty(CoYeuCauHoTro9Property); }
            set { SetProperty(CoYeuCauHoTro9Property, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object.</returns>
        public static CDT_PhieuKhaoSat_YeuCauHoTro NewCDT_PhieuKhaoSat_YeuCauHoTro()
        {
            return DataPortal.Create<CDT_PhieuKhaoSat_YeuCauHoTro>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object, based on given parameters.
        /// </summary>
        /// <param name="idPhieuKhaoSat">The IdPhieuKhaoSat parameter of the CDT_PhieuKhaoSat_YeuCauHoTro to fetch.</param>
        /// <returns>A reference to the fetched <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object.</returns>
        public static CDT_PhieuKhaoSat_YeuCauHoTro GetCDT_PhieuKhaoSat_YeuCauHoTro(int Id)
        {
            return DataPortal.Fetch<CDT_PhieuKhaoSat_YeuCauHoTro>(Id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object, based on given parameters.
        /// </summary>
        /// <param name="idPhieuKhaoSat">The IdPhieuKhaoSat of the CDT_PhieuKhaoSat_YeuCauHoTro to delete.</param>
        public static void DeleteCDT_PhieuKhaoSat_YeuCauHoTro(int Id)
        {
            DataPortal.Delete<CDT_PhieuKhaoSat_YeuCauHoTro>(Id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewCDT_PhieuKhaoSat_YeuCauHoTro(EventHandler<DataPortalResult<CDT_PhieuKhaoSat_YeuCauHoTro>> callback)
        {
            DataPortal.BeginCreate<CDT_PhieuKhaoSat_YeuCauHoTro>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object, based on given parameters.
        /// </summary>
        /// <param name="idPhieuKhaoSat">The IdPhieuKhaoSat parameter of the CDT_PhieuKhaoSat_YeuCauHoTro to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetCDT_PhieuKhaoSat_YeuCauHoTro(int Id, EventHandler<DataPortalResult<CDT_PhieuKhaoSat_YeuCauHoTro>> callback)
        {
            DataPortal.BeginFetch<CDT_PhieuKhaoSat_YeuCauHoTro>(Id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object, based on given parameters.
        /// </summary>
        /// <param name="idPhieuKhaoSat">The IdPhieuKhaoSat of the CDT_PhieuKhaoSat_YeuCauHoTro to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteCDT_PhieuKhaoSat_YeuCauHoTro(int Id, EventHandler<DataPortalResult<CDT_PhieuKhaoSat_YeuCauHoTro>> callback)
        {
            DataPortal.BeginDelete<CDT_PhieuKhaoSat_YeuCauHoTro>(Id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private CDT_PhieuKhaoSat_YeuCauHoTro()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IdProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(YeuCauHoTro1Property, null);
            LoadProperty(YeuCauHoTro2Property, null);
            LoadProperty(YeuCauHoTro3Property, null);
            LoadProperty(YeuCauHoTro4Property, null);
            LoadProperty(YeuCauHoTro5Property, null);
            LoadProperty(YeuCauHoTro6Property, null);
            LoadProperty(YeuCauHoTro7Property, null);
            LoadProperty(YeuCauHoTro8Property, null);
            LoadProperty(YeuCauHoTro9Property, null);
            LoadProperty(YeuCauHoTro10Property, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="idPhieuKhaoSat">The id Phieu Khao Sat.</param>
        protected void DataPortal_Fetch(int Id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_YeuCauHoTro_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", Id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, Id);
                    OnFetchPre(args);
                    Fetch(cmd);
                    OnFetchPost(args);
                }
            }
            // check all object rules and property rules
            BusinessRules.CheckRules();
        }

        private void Fetch(SqlCommand cmd)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                }
            }
        }

        /// <summary>
        /// Loads a <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IdProperty, dr.GetInt32("Id"));
            LoadProperty(IdPhieuKhaoSatProperty, dr.GetInt32("IdPhieuKhaoSat"));
            LoadProperty(YeuCauHoTro1Property, dr.GetString("YeuCauHoTro1"));
            LoadProperty(YeuCauHoTro2Property, dr.GetString("YeuCauHoTro2"));
            LoadProperty(YeuCauHoTro3Property, dr.GetString("YeuCauHoTro3"));
            LoadProperty(YeuCauHoTro4Property, dr.GetString("YeuCauHoTro4"));
            LoadProperty(YeuCauHoTro5Property, dr.GetString("YeuCauHoTro5"));
            LoadProperty(YeuCauHoTro6Property, dr.GetString("YeuCauHoTro6"));
            LoadProperty(YeuCauHoTro7Property, dr.GetString("YeuCauHoTro7"));
            LoadProperty(YeuCauHoTro8Property, dr.GetString("YeuCauHoTro8"));
            LoadProperty(YeuCauHoTro9Property, dr.GetString("YeuCauHoTro9"));
            LoadProperty(YeuCauHoTro10Property, dr.GetString("YeuCauHoTro10"));

            if (string.IsNullOrEmpty(YeuCauHoTro1))
            {
                LoadProperty(CoYeuCauHoTro1Property, false);
            }
            else {
                LoadProperty(CoYeuCauHoTro1Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro2))
            {
                LoadProperty(CoYeuCauHoTro2Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro2Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro3))
            {
                LoadProperty(CoYeuCauHoTro3Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro3Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro4))
            {
                LoadProperty(CoYeuCauHoTro4Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro4Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro5))
            {
                LoadProperty(CoYeuCauHoTro5Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro5Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro6))
            {
                LoadProperty(CoYeuCauHoTro6Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro6Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro7))
            {
                LoadProperty(CoYeuCauHoTro7Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro7Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro8))
            {
                LoadProperty(CoYeuCauHoTro8Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro8Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro9))
            {
                LoadProperty(CoYeuCauHoTro9Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro9Property, true);
            }

            if (string.IsNullOrEmpty(YeuCauHoTro10))
            {
                LoadProperty(CoYeuCauHoTro10Property, false);
            }
            else
            {
                LoadProperty(CoYeuCauHoTro10Property, true);
            }

            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_YeuCauHoTro_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", ReadProperty(IdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro1", ReadProperty(YeuCauHoTro1Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro2", ReadProperty(YeuCauHoTro2Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro3", ReadProperty(YeuCauHoTro3Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro4", ReadProperty(YeuCauHoTro4Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro4Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro5", ReadProperty(YeuCauHoTro5Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro5Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro6", ReadProperty(YeuCauHoTro6Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro6Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro7", ReadProperty(YeuCauHoTro7Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro7Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro8", ReadProperty(YeuCauHoTro8Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro8Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro9", ReadProperty(YeuCauHoTro9Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro9Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro10", ReadProperty(YeuCauHoTro10Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro10Property)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IdProperty, (int) cmd.Parameters["@id"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_YeuCauHoTro_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", ReadProperty(IdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@idPhieuKhaoSat", ReadProperty(IdPhieuKhaoSatProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro1", ReadProperty(YeuCauHoTro1Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro2", ReadProperty(YeuCauHoTro2Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro3", ReadProperty(YeuCauHoTro3Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro4", ReadProperty(YeuCauHoTro4Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro4Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro5", ReadProperty(YeuCauHoTro5Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro5Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro6", ReadProperty(YeuCauHoTro6Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro6Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro7", ReadProperty(YeuCauHoTro7Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro7Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro8", ReadProperty(YeuCauHoTro8Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro8Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro9", ReadProperty(YeuCauHoTro9Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro9Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@YeuCauHoTro10", ReadProperty(YeuCauHoTro10Property) == null ? (object)DBNull.Value : ReadProperty(YeuCauHoTro10Property)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(IdPhieuKhaoSat);
        }

        /// <summary>
        /// Deletes the <see cref="CDT_PhieuKhaoSat_YeuCauHoTro"/> object from database.
        /// </summary>
        /// <param name="idPhieuKhaoSat">The delete criteria.</param>
        protected void DataPortal_Delete(int Id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.CDT_PhieuKhaoSat_YeuCauHoTro_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", Id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, Id);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
                ctx.Commit();
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
