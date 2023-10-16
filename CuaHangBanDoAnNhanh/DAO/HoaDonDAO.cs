using DTO;
using quanLyBanXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO : DataProvider
    {


        public List<HoaDon> list()
        {
            List<HoaDon> list = new List<HoaDon>();

            string query = "select * from dbo.HoaDon ";
            DataTable data = ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDon ds = new HoaDon(item);
                list.Add(ds);
            }
            return list;
        }


        public bool them(HoaDon a)
        {

            string query = string.Format("insert into dbo.HoaDon(MaHoaDon,MaKhahHang,NgayNhap,loaiHoaDon,GiChu,TongTien)  values ('{0}','{1}','{2}','{3}',N'{4}',0)", a.MaHoaDon1,a.MaKhahHang1,a.NgayNhap1,a.LoaiHoaDon,a.GiChu1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }


        public bool xoa(HoaDon a)
        {

            string query = string.Format("delete  from  dbo.HoaDon where  MaHoaDon ='{0}'", a.MaHoaDon1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool KiemTraid(HoaDon a)
        {

            string query = string.Format("select *  from  dbo.HoaDon where  MaHoaDon ='{0}'", a.MaHoaDon1);
            int result = KiemTraMa(query);

            return result > 0;
        }





        public DataTable thongTinDon(string id,string tk)
        {
            DataTable tblThongtinHD = new DataTable();
            string sql = "SELECT a.MaHoaDon, a.NgayNhap, a.Tongtien, b.tenKhachHang, b.sdtKhachHang, c.HoTen FROM HoaDon AS a, KhachHang AS b, TaiKhoan AS c WHERE a.MaHoaDon = " + id + " AND a.MaKhahHang = b.idKhachHang and c.TenDangNhap ='"+tk+"' ";
            tblThongtinHD = ExecuteQuery(sql);
            return tblThongtinHD;
        }


        public DataTable thongTinCtHD(string id)
        {
            DataTable tblThongtinHD = new DataTable();
            string sql = "SELECT x.tenMonAn, a.SoLuong, x.donGia, a.DonGia FROM ChiTiethoaDon AS a , HoaDon AS b , dbo.MonAn as x WHERE a.MaHoaDon = " + id + " AND a.MaHoaDon = b.MaHoaDon and a.MaMonAn = x.MaMonAn";
            tblThongtinHD = ExecuteQuery(sql);
            return tblThongtinHD;
        }
        public DataTable inThongKeThang(string thang, string nam)
        {
            DataTable thongke;
            string query = string.Format("SELECT * FROM fn_DoanhThuTheoThang({0}, {1}) ", thang, nam);
            thongke = ExecuteQuery(query);
            return thongke;
        }
        public List<thongKe> thongKethang(string thang, string nam)
        {
            List<thongKe> list = new List<thongKe>();

            string query = string.Format("SELECT * FROM fn_DoanhThuTheoThang({0}, {1}) ", thang, nam);
            DataTable data = ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                thongKe baoCao = new thongKe(item);
                list.Add(baoCao);
            }
            return list;
        }
    }
}
