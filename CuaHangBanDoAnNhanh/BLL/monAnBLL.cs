using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class monAnBLL
    {

        MonAnDAO monan = new MonAnDAO();


        


        public List<MonAn> load()
        {
            return monan.list();
        }

        public List<MonAn> loadDanhMuc(string a)
        {
            return  monan.listDanhMuc(a);
        }





        public string them(MonAn a)
        {
            if (monan.KiemTraId(a))
            {
                return "mã bị trùng";
            }
            else
            {
                if (monan.them(a))
                {
                    return "thành công";
                }
                else
                {
                    return "thất bại";
                }


            }
        }

        public string sua(MonAn a)
        {
            if (monan.sua(a))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }
        }


        public string xoa(MonAn a)
        {
            if (monan.xoa(a))
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
