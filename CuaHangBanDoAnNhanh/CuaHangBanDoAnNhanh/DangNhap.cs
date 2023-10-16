using BLL;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        taiKhoanBLL tk = new taiKhoanBLL();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "" || txbPassWord.Text == "")
            {
                MessageBox.Show("nhập tài khoản và mật khẩu");
            }else
            {
                if(tk.dangnhap(txbUserName.Text, txbPassWord.Text))
                {
                    FTrangChu F = new FTrangChu(tk.layQuyen(txbUserName.Text, txbPassWord.Text));
                    F.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("sai tài khoản hoặc mật khẩu");
                    
                }

            }
    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
