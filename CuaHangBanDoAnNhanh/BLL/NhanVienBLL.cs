using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class NhanVienBLL
    {

        NhaVienDAO nv = new NhaVienDAO();


        public List<NhanVien> load()
        {
            return nv.list();
        }
        

        public string them(NhanVien a)
        {
            if (nv.KiemTraId(a))
            {
                return "id bị trùng";
            }
            else
            {
                if (nv.them(a))
                {
                    return "thành công";
                }
                else
                {
                    return "thất bại";
                }


            }
        }

        public string sua(NhanVien a)
        {
            if (nv.sua(a))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }
        }


        public string xoa(NhanVien a)
        {
            if (nv.xoa(a))
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
