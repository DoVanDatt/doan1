using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class CTHoaDonBLL
    {

        CtHoaDonDAO ctDAo=new CtHoaDonDAO();


        public List<ChiTietHoaDon> load(string a)
        {
           return ctDAo.list(a);
        }


        public string xoa(ChiTietHoaDon a)
        {
            if (!ctDAo.xoa(a))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }
        }


        public string them(ChiTietHoaDon a)
        {
            if (ctDAo.them(a))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }
        }
    }
}
