using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class CtHoaDonDAO:DataProvider
    {

        public List<ChiTietHoaDon> list(string a)
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();

            string query = "select * from dbo.ChiTiethoaDon where MaHoaDon='"+a+"'";
            DataTable data = ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiTietHoaDon ds = new ChiTietHoaDon(item);
                list.Add(ds);
            }
            return list;
        }


        public bool them(ChiTietHoaDon a)
        {

            string query = string.Format("[dbo].[ThemSp] @maHD ='{0}', @MaSp  ='{1}' , @SoLuong  ='{2}'",a.MaHoaDon1,a.MaMonAn1,a.SoLuong );
            int result = ExecuteNonQuery(query);

            return result > 0;

        }


        public bool xoa(ChiTietHoaDon a)
        {

            string query = string.Format("sp_xoaSP @MaHoaDon  ='{0}',@MaSanPham  ='{1}'",a.MaHoaDon1,a.MaMonAn1);
            int result = ExecuteNonQuery(query);

            return result > 0;

        }
    }
}
