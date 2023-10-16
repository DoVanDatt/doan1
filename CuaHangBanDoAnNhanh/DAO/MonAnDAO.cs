using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MonAnDAO : DataProvider
    {


        public List<MonAn> list()
        {
            List<MonAn> list = new List<MonAn>();

            string query = "select * from dbo.MonAn ";
            DataTable data = ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MonAn ds = new MonAn(item);
                list.Add(ds);
            }
            return list;
        }


        public List<MonAn> listDanhMuc(string a)
        {
            List<MonAn> list = new List<MonAn>();

            string query = string.Format("select * from dbo.MonAn where  MaDanhMuc ='{0}' ",a);
            DataTable data = ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MonAn ds = new MonAn(item);
                list.Add(ds);
            }
            return list;
        }


        public bool them(MonAn a)
        {

            string query = string.Format("insert into dbo.MonAn(MaMonAn,tenMonAn,DonVi,donGia,MaDanhMuc)  values ('{0}',N'{1}',N'{2}',{3},'{4}')", a.MaMonAn, a.TenMonAn, a.DonVi, a.DonGia, a.MaDanhMuc);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool sua(MonAn a)
        {

            string query = string.Format("UPDATE dbo.MonAn set tenMonAn=N'{1}',DonVi=N'{2}',donGia={3},MaDanhMuc='{4}' where MaMonAn = '{0}' ", a.MaMonAn, a.TenMonAn, a.DonVi, a.DonGia, a.MaDanhMuc);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool xoa(MonAn a)
        {

            string query = string.Format("delete  from  dbo.MonAn where  MaMonAn ='{0}'", a.MaMonAn);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }

        public bool KiemTraId(MonAn a)
        {

            string query = string.Format("select *  from  dbo.MonAn where  MaMonAn ='{0}'", a.MaMonAn);
            int result = KiemTraMa(query);

            return result > 0;
        }
    }
}
