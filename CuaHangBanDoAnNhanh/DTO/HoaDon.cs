using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {

        public HoaDon() { }
        public HoaDon(DataRow row)
        {
            this.MaHoaDon1 = row["MaHoaDon"].ToString();
            this.MaKhahHang1 = row["MaKhahHang"].ToString();
            this.NgayNhap1 = row["NgayNhap"].ToString();
            this.LoaiHoaDon = row["loaiHoaDon"].ToString();
            this.GiChu1 = row["GiChu"].ToString();
            this.TongTien1= row["TongTien"].ToString();
        }
        private string MaHoaDon;
        private string MaKhahHang;
        private string NgayNhap;
        private string loaiHoaDon;
        private string GiChu;
        private string TongTien;

        public string MaHoaDon1 { get => MaHoaDon; set => MaHoaDon = value; }
        public string MaKhahHang1 { get => MaKhahHang; set => MaKhahHang = value; }
        public string NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public string LoaiHoaDon { get => loaiHoaDon; set => loaiHoaDon = value; }
        public string GiChu1 { get => GiChu; set => GiChu = value; }
        public string TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
