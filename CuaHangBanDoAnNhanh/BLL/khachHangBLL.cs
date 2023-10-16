using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class khachHangBLL
    {


        khachHangDAO kh = new khachHangDAO();


        public List<KhachHang> load()
        {
            return kh.list();
        }

        public string them(KhachHang a)
        {
            if (kh.checkId(a))
            {
                return "id bị trùng";
            }
            else
            {
                if (kh.them(a))
                {
                    return "thành công";
                }
                else
                {
                    return "thất bại";
                }


            }
        }

        public string sua(KhachHang a)
        {
            if (kh.sua(a))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }
        }


        public string xoa(KhachHang a)
        {
            if (kh.xoa(a))
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
