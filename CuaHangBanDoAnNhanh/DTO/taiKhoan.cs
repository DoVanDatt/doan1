using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class taiKhoan
    {

        public taiKhoan(DataRow row) 
        {

            this.HoTen = row["HoTen"].ToString();
            this.TenDangNhap1 = row["TenDangNhap"].ToString();
            this.MatKhau1 = row["MatKhau"].ToString();
            this.Quyen1 = row["quyen"].ToString();
        }
        public taiKhoan() { }
        
        private string HoTen;
        private string TenDangNhap;
        private string MatKhau;
        private string Quyen;

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string Quyen1 { get => Quyen; set => Quyen = value; }
    }
}
