using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {

        public ChiTietHoaDon() { }
        public ChiTietHoaDon(DataRow row)
        {
            this.MaHoaDon1 = row["MaHoaDon"].ToString();
            this.MaMonAn1 = row["MaMonAn"].ToString();
            this.SoLuong = row["soLuong"].ToString();
            this.DonGia1 = row["DonGia"].ToString();

        }

        private string MaHoaDon;
        private string MaMonAn;
        private string soLuong;
        private string DonGia;

        public string MaHoaDon1 { get => MaHoaDon; set => MaHoaDon = value; }
        public string MaMonAn1 { get => MaMonAn; set => MaMonAn = value; }
        public string SoLuong { get => soLuong; set => soLuong = value; }
        public string DonGia1 { get => DonGia; set => DonGia = value; }
    }
}
