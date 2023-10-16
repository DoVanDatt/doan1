using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn
    {

        public MonAn() { } 
        public MonAn(DataRow row) 
        {
            this.MaMonAn = row["maMonAn"].ToString();
            this.TenMonAn = row["tenMonAn"].ToString();
            this.DonGia = row["donGia"].ToString();
            this.DonVi = row["donVi"].ToString();
            this.MaDanhMuc = row["maDanhMuc"].ToString();
        }


        private string maMonAn;
        private string tenMonAn;
        private string donGia;
        private string donVi;
        private string maDanhMuc;

        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public string MaDanhMuc { get => maDanhMuc; set => maDanhMuc = value; }
    }
}
