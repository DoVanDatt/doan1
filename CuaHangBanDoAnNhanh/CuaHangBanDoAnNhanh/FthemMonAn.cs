using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangBanDoAnNhanh
{
    public partial class FthemMonAn : Form
    {
        public FthemMonAn()
        {
            InitializeComponent();
        }
        MonAn ma = new MonAn();
        monAnBLL maBLL = new monAnBLL();
        bool kieu = true;
        MonAn getMonAn()
        {

            ma.MaMonAn =  txtMaMonAn.Text;
            ma.TenMonAn=  txtTen.Text;
            ma.DonGia=    txtGia.Text;
            ma.DonVi=     txtDonVi.Text;

            if (ccbDanhMuc.SelectedIndex == -1)
            {
                MessageBox.Show("chọn danh mục");
            }
            else
            {
                ma.MaDanhMuc = (ccbDanhMuc.SelectedItem as DanhMuc).MaDanhMuc1.Trim();
            }
            
            
            return ma;
        }


        public FthemMonAn(MonAn a)
        {

            ma.MaMonAn =a.MaMonAn;
            ma.TenMonAn = a.TenMonAn;
            ma.DonGia = a.DonGia;
            ma.DonVi = a.DonVi;
            ma.MaDanhMuc = a.MaDanhMuc;
            kieu = false;
            InitializeComponent();
        }



        danhMucBLL dmBLL = new danhMucBLL();
        monAnBLL monAnBLL = new monAnBLL();
        void loadDanhmuc()
        {
            List<DanhMuc> listCategory = dmBLL.load();
            ccbDanhMuc.DataSource = listCategory;
            ccbDanhMuc.DisplayMember = "TenDanhMuc1";
            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ccbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FthemMonAn_Load(object sender, EventArgs e)
        {
            loadDanhmuc();
            txtMaMonAn.Text = ma.MaMonAn;
            txtTen.Text = ma.TenMonAn;
            txtGia.Text = ma.DonGia;
            txtDonVi.Text = ma.DonVi;
            ccbDanhMuc.SelectedItem = ma.MaDanhMuc;


            if (!kieu)
            {

                txtMaMonAn.Enabled = false;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!kieu)
            {

                MessageBox.Show(maBLL.sua(getMonAn()),"Thông báo");
                this.Close();
            }
            else
            {
                try
                {
                    MessageBox.Show(maBLL.them(getMonAn()), "Thông báo");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("vui long nhập ");
                }
               
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
