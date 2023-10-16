using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class taiKhoanBLL
    {

        TaiKhoanDAO taiKhoan = new TaiKhoanDAO();


        public List<taiKhoan> load()
        {
            return taiKhoan.list();
        }
        public bool dangnhap(string tk,string mk)
        {
            return taiKhoan.DangNhap(tk,mk);
        }

        public string[] layQuyen(string tk, string mk)
        {
            return taiKhoan.layQuyen (tk, mk);
        }
        public string them(taiKhoan a)
        {
            if (taiKhoan.KiemTraId(a))
            {
                return "tài khoản bị trùng";
            }
            else
            {
                if (taiKhoan.them(a))
                {
                    return "thành công";
                }
                else
                {
                    return "thất bại";
                }
                
                
            }
        }

        public string sua(taiKhoan a)
        {
            if (taiKhoan.sua(a))
            {
                return "thành công";
            }
            else
            {
                return "thất bại";
            }
        }


        public string xoa(taiKhoan a)
        {
            if (taiKhoan.xoa(a))
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
