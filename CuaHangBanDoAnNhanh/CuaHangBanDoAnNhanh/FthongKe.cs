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
    public partial class FthongKe : Form
    {
        public FthongKe()
        {
            InitializeComponent();
        }

        HoaDonBLL hdBLL = new HoaDonBLL();

        private void txtTongKe_Click(object sender, EventArgs e)
        {
            if(txtThang.Text == "" || txtNam.Text == "")
            {
                MessageBox.Show("nhập đủ");
            }
            else
            {
                dgvDsTk.DataSource= hdBLL.loadThongKe(txtThang.Text, txtNam.Text);
            }

        }

        private void txtInTK_Click(object sender, EventArgs e)
        {
            if (txtThang.Text == "" || txtNam.Text == "")
            {
                MessageBox.Show("nhập đủ");
            }
            else
            {
                hdBLL.inthongKethang(txtThang.Text, txtNam.Text);
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

        private void FthongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
