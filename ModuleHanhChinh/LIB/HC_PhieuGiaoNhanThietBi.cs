//  This file was generated by CSLA Object Generator - CslaGenFork v4.3.0
//
// Filename:    HC_PhieuGiaoNhanThietBi
// ObjectType:  HC_PhieuGiaoNhanThietBi
// CSLAType:    EditableRoot

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using NETLINK.LIB;

namespace ModuleHanhChinh.LIB
{

    /// <summary>
    /// HC_PhieuGiaoNhanThietBi (editable root object).<br/>
    /// This is a generated base class of <see cref="HC_PhieuGiaoNhanThietBi"/> business object.
    /// </summary>
    [Serializable]
    public partial class HC_PhieuGiaoNhanThietBi : BusinessBase<HC_PhieuGiaoNhanThietBi>
    {

        #region Static Fields

        private static int _lastID;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IDProperty = RegisterProperty<int>(p => p.ID, "ID");
        /// <summary>
        /// Gets the ID.
        /// </summary>
        /// <value>The ID.</value>
        public int ID
        {
            get { return GetProperty(IDProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="NgayLapPhieu"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> NgayLapPhieuProperty = RegisterProperty<SmartDate>(p => p.NgayLapPhieu, "Ngay Lap Phieu");
        /// <summary>
        /// Gets or sets the Ngay Lap Phieu.
        /// </summary>
        /// <value>The Ngay Lap Phieu.</value>
        public string NgayLapPhieu
        {
            get { return GetPropertyConvert<SmartDate, String>(NgayLapPhieuProperty); }
            set { SetPropertyConvert<SmartDate, String>(NgayLapPhieuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GiaoTen1"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GiaoTen1Property = RegisterProperty<string>(p => p.GiaoTen1, "Giao Ten1");
        /// <summary>
        /// Gets or sets the Giao Ten1.
        /// </summary>
        /// <value>The Giao Ten1.</value>
        public string GiaoTen1
        {
            get { return GetProperty(GiaoTen1Property); }
            set { SetProperty(GiaoTen1Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GiaoTen2"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GiaoTen2Property = RegisterProperty<string>(p => p.GiaoTen2, "Giao Ten2");
        /// <summary>
        /// Gets or sets the Giao Ten2.
        /// </summary>
        /// <value>The Giao Ten2.</value>
        public string GiaoTen2
        {
            get { return GetProperty(GiaoTen2Property); }
            set { SetProperty(GiaoTen2Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GiaoTen3"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GiaoTen3Property = RegisterProperty<string>(p => p.GiaoTen3, "Giao Ten3");
        /// <summary>
        /// Gets or sets the Giao Ten3.
        /// </summary>
        /// <value>The Giao Ten3.</value>
        public string GiaoTen3
        {
            get { return GetProperty(GiaoTen3Property); }
            set { SetProperty(GiaoTen3Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MuonTen1"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MuonTen1Property = RegisterProperty<string>(p => p.MuonTen1, "Muon Ten1");
        /// <summary>
        /// Gets or sets the Muon Ten1.
        /// </summary>
        /// <value>The Muon Ten1.</value>
        public string MuonTen1
        {
            get { return GetProperty(MuonTen1Property); }
            set { SetProperty(MuonTen1Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MuonTen2"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MuonTen2Property = RegisterProperty<string>(p => p.MuonTen2, "Muon Ten2");
        /// <summary>
        /// Gets or sets the Muon Ten2.
        /// </summary>
        /// <value>The Muon Ten2.</value>
        public string MuonTen2
        {
            get { return GetProperty(MuonTen2Property); }
            set { SetProperty(MuonTen2Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="MuonTen3"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> MuonTen3Property = RegisterProperty<string>(p => p.MuonTen3, "Muon Ten3");
        /// <summary>
        /// Gets or sets the Muon Ten3.
        /// </summary>
        /// <value>The Muon Ten3.</value>
        public string MuonTen3
        {
            get { return GetProperty(MuonTen3Property); }
            set { SetProperty(MuonTen3Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChucVuGiao1"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChucVuGiao1Property = RegisterProperty<string>(p => p.ChucVuGiao1, "Chuc Vu Giao1");
        /// <summary>
        /// Gets or sets the Chuc Vu Giao1.
        /// </summary>
        /// <value>The Chuc Vu Giao1.</value>
        public string ChucVuGiao1
        {
            get { return GetProperty(ChucVuGiao1Property); }
            set { SetProperty(ChucVuGiao1Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChucVuGiao2"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChucVuGiao2Property = RegisterProperty<string>(p => p.ChucVuGiao2, "Chuc Vu Giao2");
        /// <summary>
        /// Gets or sets the Chuc Vu Giao2.
        /// </summary>
        /// <value>The Chuc Vu Giao2.</value>
        public string ChucVuGiao2
        {
            get { return GetProperty(ChucVuGiao2Property); }
            set { SetProperty(ChucVuGiao2Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChucVuGiao3"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChucVuGiao3Property = RegisterProperty<string>(p => p.ChucVuGiao3, "Chuc Vu Giao3");
        /// <summary>
        /// Gets or sets the Chuc Vu Giao3.
        /// </summary>
        /// <value>The Chuc Vu Giao3.</value>
        public string ChucVuGiao3
        {
            get { return GetProperty(ChucVuGiao3Property); }
            set { SetProperty(ChucVuGiao3Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChucVuMuon1"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChucVuMuon1Property = RegisterProperty<string>(p => p.ChucVuMuon1, "Chuc Vu Muon1");
        /// <summary>
        /// Gets or sets the Chuc Vu Muon1.
        /// </summary>
        /// <value>The Chuc Vu Muon1.</value>
        public string ChucVuMuon1
        {
            get { return GetProperty(ChucVuMuon1Property); }
            set { SetProperty(ChucVuMuon1Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChucVuMuon2"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChucVuMuon2Property = RegisterProperty<string>(p => p.ChucVuMuon2, "Chuc Vu Muon2");
        /// <summary>
        /// Gets or sets the Chuc Vu Muon2.
        /// </summary>
        /// <value>The Chuc Vu Muon2.</value>
        public string ChucVuMuon2
        {
            get { return GetProperty(ChucVuMuon2Property); }
            set { SetProperty(ChucVuMuon2Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ChucVuMuon3"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ChucVuMuon3Property = RegisterProperty<string>(p => p.ChucVuMuon3, "Chuc Vu Muon3");
        /// <summary>
        /// Gets or sets the Chuc Vu Muon3.
        /// </summary>
        /// <value>The Chuc Vu Muon3.</value>
        public string ChucVuMuon3
        {
            get { return GetProperty(ChucVuMuon3Property); }
            set { SetProperty(ChucVuMuon3Property, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DiaDiemMuon"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DiaDiemMuonProperty = RegisterProperty<string>(p => p.DiaDiemMuon, "Dia Diem Muon");
        /// <summary>
        /// Gets or sets the Dia Diem Muon.
        /// </summary>
        /// <value>The Dia Diem Muon.</value>
        public string DiaDiemMuon
        {
            get { return GetProperty(DiaDiemMuonProperty); }
            set { SetProperty(DiaDiemMuonProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ThoiGianMuon"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ThoiGianMuonProperty = RegisterProperty<string>(p => p.ThoiGianMuon, "Thoi Gian Muon");
        /// <summary>
        /// Gets or sets the Thoi Gian Muon.
        /// </summary>
        /// <value>The Thoi Gian Muon.</value>
        public string ThoiGianMuon
        {
            get { return GetProperty(ThoiGianMuonProperty); }
            set { SetProperty(ThoiGianMuonProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Type"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> TypeProperty = RegisterProperty<int?>(p => p.Type, "Type");
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        /// <value>The Type.</value>
        public int? Type
        {
            get { return GetProperty(TypeProperty); }
            set { SetProperty(TypeProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="GhiChu"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> GhiChuProperty = RegisterProperty<string>(p => p.GhiChu, "Ghi Chu");
        /// <summary>
        /// Gets or sets the Ghi Chu.
        /// </summary>
        /// <value>The Ghi Chu.</value>
        public string GhiChu
        {
            get { return GetProperty(GhiChuProperty); }
            set { SetProperty(GhiChuProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="LastEdited_IDUser"/> property.
        /// </summary>
        public static readonly PropertyInfo<Int64?> LastEdited_IDUserProperty = RegisterProperty<Int64?>(p => p.LastEdited_IDUser, "Last Edited IDUser");
        /// <summary>
        /// Gets or sets the Last Edited IDUser.
        /// </summary>
        /// <value>The Last Edited IDUser.</value>
        public Int64? LastEdited_IDUser
        {
            get { return GetProperty(LastEdited_IDUserProperty); }
            set { SetProperty(LastEdited_IDUserProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="LastEdited_Date"/> property.
        /// </summary>
        public static readonly PropertyInfo<SmartDate> LastEdited_DateProperty = RegisterProperty<SmartDate>(p => p.LastEdited_Date, "Last Edited Date");
        /// <summary>
        /// Gets or sets the Last Edited Date.
        /// </summary>
        /// <value>The Last Edited Date.</value>
        public string LastEdited_Date
        {
            get { return GetPropertyConvert<SmartDate, String>(LastEdited_DateProperty); }
            set { SetPropertyConvert<SmartDate, String>(LastEdited_DateProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="TongSoLanIn"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> TongSoLanInProperty = RegisterProperty<int?>(p => p.TongSoLanIn, "Tong So Lan In");
        /// <summary>
        /// Gets or sets the Tong So Lan In.
        /// </summary>
        /// <value>The Tong So Lan In.</value>
        public int? TongSoLanIn
        {
            get { return GetProperty(TongSoLanInProperty); }
            set { SetProperty(TongSoLanInProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DaiDienBenGiao"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DaiDienBenGiaoProperty = RegisterProperty<string>(p => p.DaiDienBenGiao, "Dai Dien Ben Giao");
        /// <summary>
        /// Gets or sets the Dai Dien Ben Giao.
        /// </summary>
        /// <value>The Dai Dien Ben Giao.</value>
        public string DaiDienBenGiao
        {
            get { return GetProperty(DaiDienBenGiaoProperty); }
            set { SetProperty(DaiDienBenGiaoProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DaiDienBenMuon"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DaiDienBenMuonProperty = RegisterProperty<string>(p => p.DaiDienBenMuon, "Dai Dien Ben Muon");
        /// <summary>
        /// Gets or sets the Dai Dien Ben Muon.
        /// </summary>
        /// <value>The Dai Dien Ben Muon.</value>
        public string DaiDienBenMuon
        {
            get { return GetProperty(DaiDienBenMuonProperty); }
            set { SetProperty(DaiDienBenMuonProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="HC_PhieuGiaoNhanThietBi"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="HC_PhieuGiaoNhanThietBi"/> object.</returns>
        public static HC_PhieuGiaoNhanThietBi NewHC_PhieuGiaoNhanThietBi()
        {
            return DataPortal.Create<HC_PhieuGiaoNhanThietBi>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="HC_PhieuGiaoNhanThietBi"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the HC_PhieuGiaoNhanThietBi to fetch.</param>
        /// <returns>A reference to the fetched <see cref="HC_PhieuGiaoNhanThietBi"/> object.</returns>
        public static HC_PhieuGiaoNhanThietBi GetHC_PhieuGiaoNhanThietBi(int id)
        {
            return DataPortal.Fetch<HC_PhieuGiaoNhanThietBi>(id);
        }

        /// <summary>
        /// Factory method. Deletes a <see cref="HC_PhieuGiaoNhanThietBi"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the HC_PhieuGiaoNhanThietBi to delete.</param>
        public static void DeleteHC_PhieuGiaoNhanThietBi(int id)
        {
            DataPortal.Delete<HC_PhieuGiaoNhanThietBi>(id);
        }

        /// <summary>
        /// Factory method. Asynchronously creates a new <see cref="HC_PhieuGiaoNhanThietBi"/> object.
        /// </summary>
        /// <param name="callback">The completion callback method.</param>
        public static void NewHC_PhieuGiaoNhanThietBi(EventHandler<DataPortalResult<HC_PhieuGiaoNhanThietBi>> callback)
        {
            DataPortal.BeginCreate<HC_PhieuGiaoNhanThietBi>(callback);
        }

        /// <summary>
        /// Factory method. Asynchronously loads a <see cref="HC_PhieuGiaoNhanThietBi"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID parameter of the HC_PhieuGiaoNhanThietBi to fetch.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void GetHC_PhieuGiaoNhanThietBi(int id, EventHandler<DataPortalResult<HC_PhieuGiaoNhanThietBi>> callback)
        {
            DataPortal.BeginFetch<HC_PhieuGiaoNhanThietBi>(id, callback);
        }

        /// <summary>
        /// Factory method. Asynchronously deletes a <see cref="HC_PhieuGiaoNhanThietBi"/> object, based on given parameters.
        /// </summary>
        /// <param name="id">The ID of the HC_PhieuGiaoNhanThietBi to delete.</param>
        /// <param name="callback">The completion callback method.</param>
        public static void DeleteHC_PhieuGiaoNhanThietBi(int id, EventHandler<DataPortalResult<HC_PhieuGiaoNhanThietBi>> callback)
        {
            DataPortal.BeginDelete<HC_PhieuGiaoNhanThietBi>(id, callback);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HC_PhieuGiaoNhanThietBi"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        private HC_PhieuGiaoNhanThietBi()
        {
            // Prevent direct creation
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="HC_PhieuGiaoNhanThietBi"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void DataPortal_Create()
        {
            LoadProperty(IDProperty, System.Threading.Interlocked.Decrement(ref _lastID));
            LoadProperty(NgayLapPhieuProperty, null);
            LoadProperty(GiaoTen1Property, null);
            LoadProperty(GiaoTen2Property, null);
            LoadProperty(GiaoTen3Property, null);
            LoadProperty(MuonTen1Property, null);
            LoadProperty(MuonTen2Property, null);
            LoadProperty(MuonTen3Property, null);
            LoadProperty(ChucVuGiao1Property, null);
            LoadProperty(ChucVuGiao2Property, null);
            LoadProperty(ChucVuGiao3Property, null);
            LoadProperty(ChucVuMuon1Property, null);
            LoadProperty(ChucVuMuon2Property, null);
            LoadProperty(ChucVuMuon3Property, null);
            LoadProperty(DiaDiemMuonProperty, null);
            LoadProperty(ThoiGianMuonProperty, null);
            LoadProperty(GhiChuProperty, null);
            LoadProperty(LastEdited_DateProperty, null);
            LoadProperty(DaiDienBenGiaoProperty, null);
            LoadProperty(DaiDienBenMuonProperty, null);
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.DataPortal_Create();
        }

        /// <summary>
        /// Loads a <see cref="HC_PhieuGiaoNhanThietBi"/> object from the database, based on given criteria.
        /// </summary>
        /// <param name="id">The ID.</param>
        protected void DataPortal_Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_PhieuGiaoNhanThietBi_get", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, id);
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
        /// Loads a <see cref="HC_PhieuGiaoNhanThietBi"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(IDProperty, dr.GetInt32("ID"));
            LoadProperty(NgayLapPhieuProperty, dr.GetSmartDate("NgayLapPhieu"));
            LoadProperty(GiaoTen1Property, dr.GetString("GiaoTen1"));
            LoadProperty(GiaoTen2Property, dr.GetString("GiaoTen2"));
            LoadProperty(GiaoTen3Property, dr.GetString("GiaoTen3"));
            LoadProperty(MuonTen1Property, dr.GetString("MuonTen1"));
            LoadProperty(MuonTen2Property, dr.GetString("MuonTen2"));
            LoadProperty(MuonTen3Property, dr.GetString("MuonTen3"));
            LoadProperty(ChucVuGiao1Property, dr.GetString("ChucVuGiao1"));
            LoadProperty(ChucVuGiao2Property, dr.GetString("ChucVuGiao2"));
            LoadProperty(ChucVuGiao3Property, dr.GetString("ChucVuGiao3"));
            LoadProperty(ChucVuMuon1Property, dr.GetString("ChucVuMuon1"));
            LoadProperty(ChucVuMuon2Property, dr.GetString("ChucVuMuon2"));
            LoadProperty(ChucVuMuon3Property, dr.GetString("ChucVuMuon3"));
            LoadProperty(DiaDiemMuonProperty, dr.GetString("DiaDiemMuon"));
            LoadProperty(ThoiGianMuonProperty, dr.GetString("ThoiGianMuon"));
            LoadProperty(TypeProperty, dr.GetInt32("Type"));
            LoadProperty(GhiChuProperty, dr.GetString("GhiChu"));
            LoadProperty(LastEdited_IDUserProperty, dr.GetInt64("LastEdited_IDUser"));
            LoadProperty(LastEdited_DateProperty, dr.GetSmartDate("LastEdited_Date"));
            LoadProperty(TongSoLanInProperty, dr.GetInt32("TongSoLanIn"));
            LoadProperty(DaiDienBenGiaoProperty, dr.GetString("DaiDienBenGiao"));
            LoadProperty(DaiDienBenMuonProperty, dr.GetString("DaiDienBenMuon"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="HC_PhieuGiaoNhanThietBi"/> object in the database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_PhieuGiaoNhanThietBi_add", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@NgayLapPhieu", ReadProperty(NgayLapPhieuProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GiaoTen1", ReadProperty(GiaoTen1Property) == null ? (object)DBNull.Value : ReadProperty(GiaoTen1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GiaoTen2", ReadProperty(GiaoTen2Property) == null ? (object)DBNull.Value : ReadProperty(GiaoTen2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GiaoTen3", ReadProperty(GiaoTen3Property) == null ? (object)DBNull.Value : ReadProperty(GiaoTen3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MuonTen1", ReadProperty(MuonTen1Property) == null ? (object)DBNull.Value : ReadProperty(MuonTen1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MuonTen2", ReadProperty(MuonTen2Property) == null ? (object)DBNull.Value : ReadProperty(MuonTen2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MuonTen3", ReadProperty(MuonTen3Property) == null ? (object)DBNull.Value : ReadProperty(MuonTen3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuGiao1", ReadProperty(ChucVuGiao1Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuGiao1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuGiao2", ReadProperty(ChucVuGiao2Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuGiao2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuGiao3", ReadProperty(ChucVuGiao3Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuGiao3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuMuon1", ReadProperty(ChucVuMuon1Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuMuon1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuMuon2", ReadProperty(ChucVuMuon2Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuMuon2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuMuon3", ReadProperty(ChucVuMuon3Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuMuon3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DiaDiemMuon", ReadProperty(DiaDiemMuonProperty) == null ? (object)DBNull.Value : ReadProperty(DiaDiemMuonProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiGianMuon", ReadProperty(ThoiGianMuonProperty) == null ? (object)DBNull.Value : ReadProperty(ThoiGianMuonProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Type", ReadProperty(TypeProperty) == null ? (object)DBNull.Value : ReadProperty(TypeProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_IDUser", ReadProperty(LastEdited_IDUserProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_IDUserProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@TongSoLanIn", ReadProperty(TongSoLanInProperty) == null ? (object)DBNull.Value : ReadProperty(TongSoLanInProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DaiDienBenGiao", ReadProperty(DaiDienBenGiaoProperty) == null ? (object)DBNull.Value : ReadProperty(DaiDienBenGiaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DaiDienBenMuon", ReadProperty(DaiDienBenMuonProperty) == null ? (object)DBNull.Value : ReadProperty(DaiDienBenMuonProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(IDProperty, (int) cmd.Parameters["@ID"].Value);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="HC_PhieuGiaoNhanThietBi"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_PhieuGiaoNhanThietBi_update", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ReadProperty(IDProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@NgayLapPhieu", ReadProperty(NgayLapPhieuProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@GiaoTen1", ReadProperty(GiaoTen1Property) == null ? (object)DBNull.Value : ReadProperty(GiaoTen1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GiaoTen2", ReadProperty(GiaoTen2Property) == null ? (object)DBNull.Value : ReadProperty(GiaoTen2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@GiaoTen3", ReadProperty(GiaoTen3Property) == null ? (object)DBNull.Value : ReadProperty(GiaoTen3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MuonTen1", ReadProperty(MuonTen1Property) == null ? (object)DBNull.Value : ReadProperty(MuonTen1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MuonTen2", ReadProperty(MuonTen2Property) == null ? (object)DBNull.Value : ReadProperty(MuonTen2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@MuonTen3", ReadProperty(MuonTen3Property) == null ? (object)DBNull.Value : ReadProperty(MuonTen3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuGiao1", ReadProperty(ChucVuGiao1Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuGiao1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuGiao2", ReadProperty(ChucVuGiao2Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuGiao2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuGiao3", ReadProperty(ChucVuGiao3Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuGiao3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuMuon1", ReadProperty(ChucVuMuon1Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuMuon1Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuMuon2", ReadProperty(ChucVuMuon2Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuMuon2Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ChucVuMuon3", ReadProperty(ChucVuMuon3Property) == null ? (object)DBNull.Value : ReadProperty(ChucVuMuon3Property)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DiaDiemMuon", ReadProperty(DiaDiemMuonProperty) == null ? (object)DBNull.Value : ReadProperty(DiaDiemMuonProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ThoiGianMuon", ReadProperty(ThoiGianMuonProperty) == null ? (object)DBNull.Value : ReadProperty(ThoiGianMuonProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Type", ReadProperty(TypeProperty) == null ? (object)DBNull.Value : ReadProperty(TypeProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@GhiChu", ReadProperty(GhiChuProperty) == null ? (object)DBNull.Value : ReadProperty(GhiChuProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@LastEdited_IDUser", ReadProperty(LastEdited_IDUserProperty) == null ? (object)DBNull.Value : ReadProperty(LastEdited_IDUserProperty).Value).DbType = DbType.Int64;
                    cmd.Parameters.AddWithValue("@LastEdited_Date", ReadProperty(LastEdited_DateProperty).DBValue).DbType = DbType.DateTime;
                    cmd.Parameters.AddWithValue("@TongSoLanIn", ReadProperty(TongSoLanInProperty) == null ? (object)DBNull.Value : ReadProperty(TongSoLanInProperty).Value).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@DaiDienBenGiao", ReadProperty(DaiDienBenGiaoProperty) == null ? (object)DBNull.Value : ReadProperty(DaiDienBenGiaoProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@DaiDienBenMuon", ReadProperty(DaiDienBenMuonProperty) == null ? (object)DBNull.Value : ReadProperty(DaiDienBenMuonProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                ctx.Commit();
            }
        }

        /// <summary>
        /// Self deletes the <see cref="HC_PhieuGiaoNhanThietBi"/> object.
        /// </summary>
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(ID);
        }

        /// <summary>
        /// Deletes the <see cref="HC_PhieuGiaoNhanThietBi"/> object from database.
        /// </summary>
        /// <param name="id">The delete criteria.</param>
        protected void DataPortal_Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager("Connection"))
            {
                using (var cmd = new SqlCommand("dbo.HC_PhieuGiaoNhanThietBi_delete", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd, id);
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
