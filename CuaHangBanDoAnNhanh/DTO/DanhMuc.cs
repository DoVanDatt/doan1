using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMuc
    {

        public DanhMuc() { }
        public DanhMuc(DataRow row) 
        {
            this.MaDanhMuc1 = row["MaDanhMuc"].ToString();
            this.TenDanhMuc1 = row["TenDanhMuc"].ToString();
        }

        private string MaDanhMuc;
        private string TenDanhMuc;

        public string MaDanhMuc1 { get => MaDanhMuc; set => MaDanhMuc = value; }
        public string TenDanhMuc1 { get => TenDanhMuc; set => TenDanhMuc = value; }
    }
}
