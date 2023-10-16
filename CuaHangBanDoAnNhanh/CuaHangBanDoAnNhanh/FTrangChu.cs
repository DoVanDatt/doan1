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
    public partial class FTrangChu : Form
    {
        string quyen, taiKhoan;
        public FTrangChu(string[] arr)
        {
            InitializeComponent();
            taiKhoan = arr[0];
            quyen = arr[1];
        }

        private void tÀIKHOẢNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen != "0")
            {
                MessageBox.Show("bạn không đủ quyền hạn");
                tÀIKHOẢNToolStripMenuItem.Enabled = false;
            }
            else
            {
                fTaiKhoan f = new fTaiKhoan();
                f.ShowDialog();
            }
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen != "0")
            {
                MessageBox.Show("bạn không đủ quyền hạn");
                nHÂNVIÊNToolStripMenuItem.Enabled = false;
            }
            else
            {
                FnhanVien f = new FnhanVien();
                f.ShowDialog();
            }
        }

        private void sẢNPHẨMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen != "0")
            {
                MessageBox.Show("bạn không đủ quyền hạn");
                sẢNPHẨMToolStripMenuItem.Enabled = false;
            }
            else
            {
                FmonAn f = new FmonAn();
                f.ShowDialog();
            }
        }

        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hóa_đơn f = new hóa_đơn(taiKhoan);
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fKhachHang f = new fKhachHang();
            f.ShowDialog();
        }

        private void tHỐNGKẾToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen != "0")
            {
                MessageBox.Show("bạn không đủ quyền hạn");
                tHỐNGKẾToolStripMenuItem.Enabled = false;
            }
            else
            {
                FthongKe f = new FthongKe();
                f.ShowDialog();
            }
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
