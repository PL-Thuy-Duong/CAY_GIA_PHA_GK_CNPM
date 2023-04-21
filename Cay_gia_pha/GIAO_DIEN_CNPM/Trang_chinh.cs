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
        public Trang_chinh()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pcTree_Click(object sender, EventArgs e)
        {

        }

        private void pcAboutus_Click(object sender, EventArgs e)
        {
            Thong_tin tt = new Thong_tin();
            tt.Show();
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pcTimkiem_Click(object sender, EventArgs e)
        {
            Ho_so_gia_pha hoso = new Ho_so_gia_pha();
            hoso.TopLevel = false;
            hoso.AutoScroll = true;
            PanelMain.Controls.Add(hoso);
            hoso.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Trang_chu tc = new Trang_chu();
            tc.Show();
        }
    }
}
