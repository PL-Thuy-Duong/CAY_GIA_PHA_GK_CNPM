using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIAO_DIEN_CNPM
{
    public partial class Trang_chinh : Form
    {
        private Dang_nhap dang_Nhap;
        public Trang_chinh(Dang_nhap dang_Nhap)
        {
            InitializeComponent();
            dang_Nhap.Hide();
            this.dang_Nhap = dang_Nhap;
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pcTree_Click(object sender, EventArgs e)
        {
            Ho_so_gia_pha ho_So_Gia_Pha = new Ho_so_gia_pha();
            ho_So_Gia_Pha.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            dang_Nhap.Show();

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            dang_Nhap.Show();
        }

        private void pcAboutus_Click(object sender, EventArgs e)
        {
            Thong_tin thong_Tin = new Thong_tin();
            thong_Tin.Show();
        }

        private void pcHelp_Click(object sender, EventArgs e)
        {
            Tro_giup tro_Giup = new Tro_giup();
            tro_Giup.Show();
        }
    }
}
