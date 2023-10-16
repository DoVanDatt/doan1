using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaVienDAO : DataProvider
    {

        public List<NhanVien> list()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "select * from dbo.NhanVien ";
            DataTable data = ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien ds = new NhanVien(item);
                list.Add(ds);
            }
            return list;
        }


        public bool them(NhanVien a)
        {

            string query = string.Format("insert into dbo.NhanVien(MaNhanVien,hoTen,gioiTinh,ngaySinh,SDT,DiaChi)  values ('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}')", a.MaNhanVien1, a.HoTen, a.GioiTinh, a.NgaySinh,a.SDT1,a.DiaChi1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool sua(NhanVien a)
        {

            string query = string.Format("UPDATE dbo.NhanVien set hoTen= '{1}' ,gioiTinh= '{2}',ngaySinh= '{3}',SDT= '{4}',DiaChi= '{5}' where MaNhanVien= '{0}'", a.MaNhanVien1, a.HoTen, a.GioiTinh, a.NgaySinh, a.SDT1, a.DiaChi1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool xoa(NhanVien a)
        {

            string query = string.Format("delete  from  dbo.NhanVien where  MaNhanVien ='{0}'", a.MaNhanVien1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool KiemTraId(NhanVien a)
        {

            string query = string.Format("select *  from  dbo.NhanVien where  MaNhanVien ='{0}'", a.MaNhanVien1);
            int result = KiemTraMa(query);

            return result > 0;
        }
    }
}
