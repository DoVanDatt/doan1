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

namespace CuaHangBanDoAnNhanh
{
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
        }

        taiKhoanBLL tkBLL = new taiKhoanBLL();
        taiKhoan TK = new taiKhoan();

        taiKhoan getdata()
        {
            TK.TenDangNhap1 = txtTk.Text;
            TK.MatKhau1 = txtMk.Text;
            TK.HoTen1 = txtTen.Text;
            TK.Quyen1 = ccbQuyen.SelectedIndex.ToString();
            return TK;

        }

        void load()
        {
            dataGridView1.DataSource=tkBLL.load();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }


        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // kiểm tra hàng được click là hàng thực sự, không phải hàng tiêu đề
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtTen.Text = row.Cells[0].Value.ToString();
                txtMk.Text = row.Cells[2].Value.ToString();
                txtTk.Text = row.Cells[1].Value.ToString();
                ccbQuyen.SelectedIndex = int.Parse(row.Cells[3].Value.ToString());

                btnSua.Enabled = true;
                btnXoa.Enabled = true;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(tkBLL.sua(getdata()));
                load();
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(tkBLL.them(getdata()));
                load();
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(tkBLL.xoa(getdata()));
                load();
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
