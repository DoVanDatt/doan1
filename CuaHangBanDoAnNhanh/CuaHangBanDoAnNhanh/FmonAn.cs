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
    public partial class FmonAn : Form
    {
        public FmonAn()
        {
            InitializeComponent();
        }
        danhMucBLL dmBLL = new danhMucBLL();
        monAnBLL monAnBLL = new monAnBLL();
        MonAn ma = new MonAn();


        void loadDanhmuc()
        {
            List<DanhMuc> listCategory = dmBLL.load();
            ccbDanhMuc.DataSource = listCategory;
            ccbDanhMuc.DisplayMember = "TenDanhMuc1";
            
        }

        void LoadMonAn()
        {
            dgvmonAn.DataSource= monAnBLL.load();
        }

        void LoadMonAnDm(string a)
        {
            dgvmonAn.DataSource= monAnBLL.loadDanhMuc(a);
        }



        private void FmonAn_Load(object sender, EventArgs e)
        {
            loadDanhmuc();
        }



        private void ccbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ccbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc1.Trim() == "1")
            {

                LoadMonAn();
            }
            else
            {
                LoadMonAnDm((ccbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc1.Trim());
            }
        }

        private void btnThemDm_Click(object sender, EventArgs e)
        {
            FdanhMuc f = new FdanhMuc();
            f.ShowDialog();
            f.Hide();
            FmonAn_Load(sender, e);

        }

        private void btnSuaDm_Click(object sender, EventArgs e)
        {
            string id = (ccbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc1;
            string name = (ccbDanhMuc.SelectedItem as DanhMuc).TenDanhMuc1;

            FdanhMuc f = new FdanhMuc(id, name);
            f.ShowDialog();
            f.Hide();
            FmonAn_Load(sender, e);
        }

        private void btnXoaDm_Click(object sender, EventArgs e)
        {
            try
            {

                var result = MessageBox.Show("bạn có muốn xóa", "cảnh báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if ((ccbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc1.Trim() != "1")
                    {

                        dmBLL.xoa((ccbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc1);
                        FmonAn_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("bạn không thể xóa tất cả");
                    }
                   
                }
                loadDanhmuc();


            }
            catch
            {
                MessageBox.Show("bạn phải xóa hết món ăn trong danh mục");
            }
        }

        private void dgvmonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tHÊMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FthemMonAn f = new FthemMonAn();
            f.ShowDialog();
            FmonAn_Load(sender, e);
        }

        private void themMonAn_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void sỬAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ma.MaMonAn = dgvmonAn.Rows[dgvmonAn.CurrentCell.RowIndex].Cells["MaMonAn"].Value.ToString();
            ma.TenMonAn = dgvmonAn.Rows[dgvmonAn.CurrentCell.RowIndex].Cells["TenMonAn"].Value.ToString();
            ma.DonGia = dgvmonAn.Rows[dgvmonAn.CurrentCell.RowIndex].Cells["DonGia"].Value.ToString();
            ma.DonVi = dgvmonAn.Rows[dgvmonAn.CurrentCell.RowIndex].Cells["DonVi"].Value.ToString();
            ma.MaDanhMuc = dgvmonAn.Rows[dgvmonAn.CurrentCell.RowIndex].Cells["MaDanhMuc"].Value.ToString();
            FthemMonAn f = new FthemMonAn(ma);
            f.ShowDialog();
            FmonAn_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void xÓAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ma.MaMonAn = dgvmonAn.Rows[dgvmonAn.CurrentCell.RowIndex].Cells["MaMonAn"].Value.ToString();
                MessageBox.Show(monAnBLL.xoa(ma));
                dgvmonAn.DataSource=monAnBLL.load();

            }
            catch
            {
                MessageBox.Show("lỗi vì món ăn này liên kết với chi tiết hóa đơn nào đó");
            }
        
        }
    }
}
