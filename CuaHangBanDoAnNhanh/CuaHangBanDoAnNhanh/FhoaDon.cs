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
    public partial class hóa_đơn : Form
    {
        public hóa_đơn(string tenNv)
        {
            InitializeComponent();
            this.tenNv = tenNv;
        }
        HoaDon hd = new HoaDon();
        danhMucBLL dmBLL = new danhMucBLL();
        monAnBLL monAnBLL = new monAnBLL();
        HoaDonBLL hdBLL = new HoaDonBLL();

        ChiTietHoaDon ct= new ChiTietHoaDon();

        CTHoaDonBLL CTBLL = new CTHoaDonBLL();


        string tenNv;

        void load()
        {
            dgvDsHd.DataSource=hdBLL.load();
            txtMa.Enabled = true;
            btnXoa.Enabled = false;
            txtMaSP.Enabled = false;
            button4.Enabled = false;

        }


        void loadDanhmuc()
        {
            List<DanhMuc> listCategory = dmBLL.load();
            ccbDm.DataSource = listCategory;
            ccbDm.DisplayMember = "TenDanhMuc1";
            themSP.Enabled = false;

        }


        void loadMA()
        {
            List<MonAn> listCategory = monAnBLL.load();
            ccbSp.DataSource = listCategory;
            ccbSp.DisplayMember = "TenMonAn";

        }

        void loadMADm(string a)
        {
            List<MonAn> listCategory = monAnBLL.loadDanhMuc(a);
            ccbSp.DataSource = listCategory;
            ccbSp.DisplayMember = "TenMonAn";
        }




        HoaDon getData()
        {
            hd.MaHoaDon1 = txtMa.Text;
            hd.MaKhahHang1 = txtMaKh.Text;
            hd.LoaiHoaDon = ccbloai.SelectedText;
            hd.NgayNhap1 = setDate.ConvertDateTime(DateTime.Now.ToString());
            hd.GiChu1= txtGiChu.Text;

            return hd;
        }

        void xoa()
        {
            txtMa.Text = "";
            txtMaKh.Text = "";
            ccbloai.SelectedItem=null;
            txtGiChu.Text = "";
        }


        void loadCtHd(string a)
        {
            dgvChiTiet.DataSource=CTBLL.load(a);
        }

        private void hóa_đơn_Load(object sender, EventArgs e)
        {
            load();
            loadDanhmuc();
            nmCount.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            MessageBox.Show(hdBLL.them(getData()), "thông báo");
            load();
                xoa();
            }
            catch
            {
                MessageBox.Show("lỗi nhập", "Error");
            }



        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(hdBLL.xoa(getData()), "thông báo");
                load();
                xoa();

            }
            catch
            {
                MessageBox.Show("bạn phải xóa sản phẩm trong đơn");
            }
        }

        private void dgvDsHd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDsHd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvDsHd.DataSource, "MaHoaDon1");
            button4.Enabled = true;
            loadCtHd(txtMa.Text);
            txtMa.Enabled=false;
            btnXoa.Enabled=true;
        }

        private void ccbDm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((ccbDm.SelectedItem as DanhMuc).MaDanhMuc1.Trim()=="1") 
            {
                loadMA();
            }
            else
            {
                loadMADm((ccbDm.SelectedItem as DanhMuc).MaDanhMuc1.Trim());
            }

           
        }

        private void ccbSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            nmCount.Enabled= true;
            themSP.Enabled= true;


        }

        private void nmCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBQ_Click(object sender, EventArgs e)
        {
            load();
            xoa();
        }

        private void themSP_Click(object sender, EventArgs e)
        {
            try
            {
                ct.MaHoaDon1 = txtMa.Text;
                ct.MaMonAn1 = (ccbSp.SelectedItem as MonAn).MaMonAn.Trim();
                ct.SoLuong = nmCount.Value.ToString();
                MessageBox.Show(CTBLL.them(ct));
                loadCtHd(txtMa.Text);
                load();
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void xóaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {

                ct.MaHoaDon1 = txtMa.Text;
                txtMaSP.DataBindings.Clear();
                txtMaSP.DataBindings.Add("Text", dgvChiTiet.DataSource, "MaMonAn1");
                ct.MaMonAn1 = txtMaSP.Text;
             
                MessageBox.Show(CTBLL.xoa(ct));
                loadCtHd(txtMa.Text);
                load();
            }
            catch
            {
                MessageBox.Show("lỗi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hdBLL.inHD(txtMa.Text,tenNv);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("bạn có muốn thoát", "cảnh báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
