using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {


        public NhanVien() { }
        public NhanVien(DataRow row) 
        {
            this.MaNhanVien1 = row["MaNhanVien"].ToString();
            this.HoTen = row["hoTen"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NgaySinh = row["ngaySinh"].ToString();
            this.SDT1 = row["SDT"].ToString();
            this.DiaChi1 = row["DiaChi"].ToString();
          
        }
        private string MaNhanVien;
        private string hoTen;
        private string gioiTinh;
        private string ngaySinh;
        private string SDT;
        private string DiaChi;

        public string MaNhanVien1 { get => MaNhanVien; set => MaNhanVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
    }
}
