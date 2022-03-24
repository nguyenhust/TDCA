using System;
using Csla;

namespace ModuleHanhChinh.LIB
{
    [Serializable()]
    public class BienLaiBase<T> : BusinessBase<BienLaiBase<T>> where T : BienLaiBase<T>
    {
        #region Protected Var
        /// <summary>
        /// ID biên lai
        /// </summary>
        protected long _lngIDBienLai;
        /// <summary>
        /// ID điều trị
        /// </summary>
        protected long _lngIDDieuTri;
        /// <summary>
        /// ID điểm thu
        /// </summary>
        protected long _lngIDDiemThu;
        /// <summary>
        /// Mã biên lai thu
        /// </summary>
        protected string _strMaBienLai = string.Empty;
        /// <summary>
        /// Ngày biên lai
        /// </summary>
        protected SmartDate _dteNgayBienLai;
        /// <summary>
        /// Số tiền trên biên lai
        /// </summary>
        protected decimal _decSoTien;
        /// <summary>
        /// Người thu
        /// </summary>
        protected string _strNguoiThu = string.Empty;
        /// <summary>
        /// Người nộp
        /// </summary>
        protected string _strNguoiNop = string.Empty;
        /// <summary>
        /// Tiền thực thu
        /// </summary>
        protected decimal _decThucThu;
        /// <summary>
        /// Người thêm
        /// </summary>
        protected long _lngIDNguoiThem;
        /// <summary>
        /// Người sửa lần cuối cùng
        /// </summary>
        protected long _lngIDNguoiSua;
        /// <summary>
        /// Người thực hiện hoàn ký quỹ
        /// </summary>
        protected long _lngIDNguoiHoan;
        #endregion

        #region Public Properties

        public long IDBienLai
        {
            get
            {
                //CanReadProperty(true);
                return _lngIDBienLai;
            }
            set
            {
                //CanWriteProperty(true);
                if (_lngIDBienLai != value)
                {
                    _lngIDBienLai = value;
                   // PropertyHasChanged();
                }
            }
        }
        public long IDDieuTri
        {
            get
            {
                //CanReadProperty(true);
                return _lngIDDieuTri;
            }
            set
            {
                //CanWriteProperty(true);
                if (_lngIDDieuTri != value)
                {
                    _lngIDDieuTri = value;
                    //PropertyHasChanged();
                }
            }
        }
        public long IDDiemThu
        {
            get
            {
                //CanReadProperty(true);
                return _lngIDDiemThu;
            }
            set
            {
                //CanWriteProperty(true);
                if (_lngIDDiemThu != value)
                {
                    _lngIDDiemThu = value;
                    //PropertyHasChanged();
                }
            }
        }
        public string MaBienLai
        {
            get
            {
                //CanReadProperty(true);
                return _strMaBienLai;
            }
            set
            {
                //CanWriteProperty(true);
                if (_strMaBienLai != value)
                {
                    _strMaBienLai = value;
                    //PropertyHasChanged();
                }
            }
        }
        public string NgayBienLai
        {
            get
            {
                //CanReadProperty(true);
                return _dteNgayBienLai.Text;
            }
            set
            {
                //CanWriteProperty(true);
                if (_dteNgayBienLai.Text != value)
                {
                    _dteNgayBienLai.Text = value;
                    //PropertyHasChanged();
                }
            }
        }
        public decimal SoTien
        {
            get
            {
                //CanReadProperty(true);
                return _decSoTien;
            }
            set
            {
                //CanWriteProperty(true);
                if (_decSoTien != value)
                {
                    _decSoTien = value;
                    //PropertyHasChanged();
                }
            }
        }
        public string NguoiThu
        {
            get
            {
                //CanReadProperty(true);
                return _strNguoiThu;
            }
            set
            {
                //CanWriteProperty(true);
                if (_strNguoiThu != value)
                {
                    _strNguoiThu = value;
                    //PropertyHasChanged();
                }
            }
        }
        public string NguoiNop
        {
            get
            {
                //CanReadProperty(true);
                return _strNguoiNop;
            }
            set
            {
                //CanWriteProperty(true);
                if (_strNguoiNop != value)
                {
                    _strNguoiNop = value;
                    //PropertyHasChanged();
                }
            }
        }
        public decimal ThucThu
        {
            get
            {
                //CanReadProperty(true);
                return _decThucThu;
            }
            set
            {
                //CanWriteProperty(true);
                if (_decThucThu != value)
                {
                    _decThucThu = value;
                    //PropertyHasChanged();
                }
            }
        }
        public long IDNguoiThem
        {
            get
            {
                //CanReadProperty(true);
                return _lngIDNguoiThem;
            }
            set
            {
                //CanWriteProperty(true);
                if (_lngIDNguoiThem != value)
                {
                    _lngIDNguoiThem = value;
                    //PropertyHasChanged();
                }
            }
        }
        public long IDNguoiSua
        {
            get
            {
                //CanReadProperty(true);
                return _lngIDNguoiSua;
            }
            set
            {
                //CanWriteProperty(true);
                if (_lngIDNguoiSua != value)
                {
                    _lngIDNguoiSua = value;
                    //PropertyHasChanged();
                }
            }
        }
        public long IDNguoiHoan
        {
            get
            {
                //CanReadProperty(true);
                return _lngIDNguoiHoan;
            }
            set
            {
                //CanWriteProperty(true);
                if (_lngIDNguoiHoan != value)
                {
                    _lngIDNguoiHoan = value;
                    //PropertyHasChanged();
                }
            }
        }
        protected override object GetIdValue()
        {
            return _lngIDBienLai;
        }
        #endregion

        #region Validation Rules
        protected override void AddBusinessRules()
        {
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("MaBienLai", 9));
            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "MaBienLai");
        }

        #endregion

        #region Factory Methods
        public virtual new T Save()
        {
            return (T)base.Save();
        }
        public virtual new T Clone()
        {
            return (T)base.Clone();
        }
        #endregion
    }
}
