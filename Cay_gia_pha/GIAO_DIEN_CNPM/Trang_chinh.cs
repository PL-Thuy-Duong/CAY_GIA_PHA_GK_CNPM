using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace GIAO_DIEN_CNPM
{

    public partial class Trang_chinh : Form
    {
        private Dang_nhap dang_Nhap;
        public Form child = null;

        public Trang_chinh(Dang_nhap dang_Nhap)
        {
            InitializeComponent();
            dang_Nhap.Hide();
            this.dang_Nhap = dang_Nhap;
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
            //dua form thong tin vào panelmain
            Thong_tin thong_Tin = new Thong_tin();
            thong_Tin.TopLevel = false;
            panelmain.Controls.Add(thong_Tin);
            thong_Tin.Dock = DockStyle.Fill;
            thong_Tin.Show();
        }

        private void pcHelp_Click(object sender, EventArgs e)
        {
            Tro_giup tro_Giup = new Tro_giup();
            tro_Giup.TopLevel = false;
            panelmain.Controls.Add(tro_Giup);
            tro_Giup.Dock = DockStyle.Fill;
            tro_Giup.Show();
        }


        private void pcTimkiem_Click(object sender, EventArgs e)
        {
           
            Ho_so_gia_pha frm2 = new Ho_so_gia_pha();
            frm2.TopLevel = false;
            panelmain.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
            
        }
    }
}
