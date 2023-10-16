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
using TOOL;

namespace CuaHangBanDoAnNhanh
{
    public partial class FnhanVien : Form
    {
        public FnhanVien()
        {
            InitializeComponent();
        }

        NhanVienBLL nv =new NhanVienBLL();

        private void FnhanVien_Load(object sender, EventArgs e)
        {
            load();
        }




        void load()
        {
            dgvDs.DataSource= nv.load();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        NhanVien get()
        {
            NhanVien a = new NhanVien();
            a.MaNhanVien1 = txtMa.Text;
            a.HoTen=txtTen.Text;
            a.SDT1=TxtSDT.Text;
            a.DiaChi1 = txtDiaChi.Text;
          
            a.NgaySinh= setDate.ConvertDateTime(dateNgaysinh.Value.ToString());
            try
            {
                a.GioiTinh = ccbGioiTinh.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("chọn ngày sinh");
            }
            
            return a;
            
        }

        void xoa()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            TxtSDT.Text = "";
            txtDiaChi.Text = "";
            txtDiaChi.Text = "";
        }

        void DataBinding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvDs.DataSource, "MaNhanVien1");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", dgvDs.DataSource, "HoTen");
            TxtSDT.DataBindings.Clear();
            TxtSDT.DataBindings.Add("Text", dgvDs.DataSource, "SDT1");
            dateNgaysinh.DataBindings.Clear();
            dateNgaysinh.DataBindings.Add("Text", dgvDs.DataSource, "NgaySinh");
            ccbGioiTinh.DataBindings.Clear();
            ccbGioiTinh.DataBindings.Add("Text", dgvDs.DataSource, "GioiTinh");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDs.DataSource, "DiaChi1");

            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnThen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nv.them(get()));
            load();
            xoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nv.sua(get()));
            load();
            xoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nv.xoa(get()));
            load();
            xoa();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            load();
            xoa();
        }

        private void dgvDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataBinding();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
