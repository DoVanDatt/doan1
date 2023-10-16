using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CuaHangBanDoAnNhanh
{
    public partial class FdanhMuc : Form
    {
        public FdanhMuc()
        {
            InitializeComponent();
        }
        
        danhMucBLL dmBLL = new danhMucBLL();
        DanhMuc dm = new DanhMuc();

        bool kieu = false;

        
        public FdanhMuc(string ma,string name)
        {

            
            dm.MaDanhMuc1 = ma;
            dm.TenDanhMuc1=name;
            kieu = true;
            
            InitializeComponent();
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (kieu)
            {
                
                MessageBox.Show(dmBLL.sua(txtMaDanhMuc.Text, txtTenDanhMuc.Text), "thông báo");
                this.Close();
            }
            else
            {
                MessageBox.Show(dmBLL.them(txtMaDanhMuc.Text, txtTenDanhMuc.Text), "thông báo");
                this.Close();
            }
        }

        private void FdanhMuc_Load(object sender, EventArgs e)
        {
            txtMaDanhMuc.Text = dm.MaDanhMuc1;
            txtTenDanhMuc.Text = dm.TenDanhMuc1;


            if (kieu)
            {

                txtMaDanhMuc.Enabled = false;
            }

           
        }
    }
}
