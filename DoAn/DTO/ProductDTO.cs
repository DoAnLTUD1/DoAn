using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        private string _maSP;

        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        private string _tenSP;

        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }
        private double _giaTien;

        public double GiaTien
        {
            get { return _giaTien; }
            set { _giaTien = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        private string _nsx;

        public string NSX
        {
            get { return _nsx; }
            set { _nsx = value; }
        }
        private string _donViTinh;

        public string DonViTinh
        {
            get { return _donViTinh; }
            set { _donViTinh = value; }
        }

    }
}
