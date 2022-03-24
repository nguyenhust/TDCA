using System;
using System.Collections.Generic;
using System.Text;
using Csla;

namespace ModuleHanhChinh.LIB
{
    public class LoadHocVien : BusinessBase<LoadHocVien>
    {
        private Int64 _intIDHocVien;
        private string _strMaHocVien = string.Empty;
        private string _strTenHocVien = string.Empty;
        private string _strTrinhDo = string.Empty;
        private string _strSoCMT = string.Empty;
        private string _strHinhThucHoc = string.Empty;
        private string _strNoiDungHoc = string.Empty;

        public Int64 IDHocVien
        {
            get { return _intIDHocVien; }
            set { _intIDHocVien = value; }
        }
        public string MaHocVien
        {
            get { return _strMaHocVien; }
            set { _strMaHocVien = value; }
        }
        public string TenHocVien
        {
            get { return _strTenHocVien; }
            set { _strTenHocVien = value; }
        }
        public string TrinhDo
        {
            get { return _strTrinhDo; }
            set { _strTrinhDo = value; }
        }
        public string SoCMT
        {
            get { return _strSoCMT; }
            set { _strSoCMT = value; }
        }
        public string HinhThucHoc
        {
            get { return _strHinhThucHoc; }
            set { _strHinhThucHoc = value; }
        }
        public string NoiDungHoc
        {
            get { return _strNoiDungHoc; }
            set { _strNoiDungHoc = value; }
        }

        public LoadHocVien()
        {

        }
    }
}
