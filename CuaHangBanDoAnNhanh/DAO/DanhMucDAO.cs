using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class DanhMucDAO : DataProvider
    {


        public List<DanhMuc> list()
        {
            List<DanhMuc> list = new List<DanhMuc>();

            string query = "select * from dbo.DanhMuc ";
            DataTable data = ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DanhMuc ds = new DanhMuc(item);
                list.Add(ds);
            }
            return list;
        }


        public bool them(string id ,string  name)
        {

            string query = string.Format("insert into dbo.DanhMuc(MaDanhMuc,TenDanhMuc)  values ('{0}',N'{1}')", id, name);

            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool sua(string id , string name)
        {

            string query = string.Format("UPDATE dbo.DanhMuc set TenDanhMuc=N'{1}' where MaDanhMuc='{0}' ", id, name);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool xoa(string id)
        {

            string query = string.Format("delete  from  dbo.DanhMuc where  MaDanhMuc ='{0}'", id);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool Kiemtraid(string id)
        {

            string query = string.Format("select *  from  dbo.DanhMuc where  MaDanhMuc ='{0}'", id);
            int result = KiemTraMa(query);

            return result > 0;
        }
    }
}
