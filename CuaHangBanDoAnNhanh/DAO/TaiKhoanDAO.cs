using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class TaiKhoanDAO : DataProvider
    {

        public List<taiKhoan> list()
        {
            List<taiKhoan> list = new List<taiKhoan>();

            string query = "select * from dbo.TaiKhoan ";
            DataTable data = ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                taiKhoan ds = new taiKhoan(item);
                list.Add(ds);
            }
            return list;
        }

        public bool DangNhap(string tk, string mk)
        {

            
            string query = string.Format("Select * from dbo.TaiKhoan where TenDangNhap = '" + tk + "'  and MatKhau='" + mk + "' ");
            int result = KiemTraMa(query);

            return result > 0;

        }

        public string[] layQuyen(string tk,string mk)
        {

            DataTable data = ExecuteQuery("Select HoTen,quyen from dbo.TaiKhoan where TenDangNhap = '" + tk + "'  and MatKhau='" + mk + "' "); 
            string[] s = new string[2];
            foreach (DataRow row in data.Rows)
            {
                s[0] = row[0].ToString(); ;
                s[1] = row[1].ToString(); ;
                break;
            }

            return s;

        }


        public bool them(taiKhoan a)
        {

            string query = string.Format("insert into dbo.TaiKhoan(hoTen,tenDangNhap,matKhau,Quyen) values (N'{0}','{1}','{2}',{3})", a.HoTen1, a.TenDangNhap1, a.MatKhau1, a.Quyen1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool sua(taiKhoan a)
        {

            string query = string.Format("UPDATE dbo.TaiKhoan set hoTen = N'{0}' , matKhau  = '{2}' ,Quyen= {3} where  tenDangNhap ='{1}'", a.HoTen1, a.TenDangNhap1, a.MatKhau1, a.Quyen1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool xoa(taiKhoan a)
        {

            string query = string.Format("delete  from  dbo.TaiKhoan where  tenDangNhap ='{0}'", a.TenDangNhap1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool KiemTraId(taiKhoan a)
        {

            string query = string.Format("select *  from  dbo.TaiKhoan where  tenDangNhap ='{0}'", a.TenDangNhap1);
            int result = KiemTraMa(query);

            return result > 0;
        }
    }
}
