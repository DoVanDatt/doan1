using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class danhMucBLL
    {

        DanhMucDAO dm = new DanhMucDAO();


         public List<DanhMuc> load()
            {
            return dm.list();
            }

       

        public string them(string id,string name)
        {
            if (dm.Kiemtraid(id))
            {
                return "id bị trùng";
            }
            else
            {
                if (dm.them(id,name))
                {
                    return "thành công";
                }
                else
                {
                    return "thất bại";
                }


            }
        }

        public string sua(string id,string name)
        {
            if (dm.sua(id,name))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }
        }


        public string xoa(string id)
        {
            if (dm.xoa(id))
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
