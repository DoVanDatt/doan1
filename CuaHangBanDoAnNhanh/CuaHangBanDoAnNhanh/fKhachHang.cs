using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace CuaHangBanDoAnNhanh
{
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }
        KhachHang kh = new KhachHang();
        khachHangBLL KhBLL = new khachHangBLL();



        KhachHang getData()
        {
            kh.Id=   txtMa.Text;
            kh.Name= txtTen.Text;
            kh.Sdt = TxtSDT.Text;
            return kh;
        }

        void xoa()
        {

            txtMa.Text = "";
            txtTen.Text = "";
            TxtSDT.Text = "";
        }

        void load()
        {
            dgvDs.DataSource=KhBLL.load();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMa.Enabled = true;
        }



        void DataBinding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvDs.DataSource, "Id");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvDs.DataSource, "Name");
            TxtSDT.DataBindings.Clear();
            TxtSDT.DataBindings.Add("Text", dgvDs.DataSource, "Sdt");
            txtMa.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

        }


        private void btnThen_Click(object sender, EventArgs e)
        {

            MessageBox.Show(KhBLL.them(getData()));
            load();
            xoa();

        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KhBLL.sua(getData()));
            load();
            xoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(KhBLL.xoa(getData()));
                load();
                xoa();
            }
            catch
            {
                MessageBox.Show("lỗi không thể xóa vì khách hàng này có một trong hóa đơn nào đó");
            }
           
        }

        private void dgvDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBinding();
        
         }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            load();
            xoa() ;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo",MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
