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

        public Trang_chinh(Dang_nhap dang_Nhap)
        {
            InitializeComponent();
            dang_Nhap.Hide();
            this.dang_Nhap = dang_Nhap;
        }
        public Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelmain.Controls.Add(childForm);
            panelmain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            dang_Nhap.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
                dang_Nhap.Show();
            }

        }

        private void pcAboutus_Click(object sender, EventArgs e)
        {
            //dua form thong tin vào panelmain
            Thong_tin thong_Tin = new Thong_tin();
            OpenChildForm(thong_Tin);
        }

        private void pcHelp_Click(object sender, EventArgs e)
        {
            Tro_giup tro_Giup = new Tro_giup();
            OpenChildForm(tro_Giup);
        }


        private void pcTimkiem_Click(object sender, EventArgs e)
        {
           
            Ho_so_gia_pha frm2 = new Ho_so_gia_pha();
            OpenChildForm(frm2);
        }

        private void pcLaw_Click(object sender, EventArgs e)
        {
            Quy_dinh qd = new Quy_dinh();
            OpenChildForm(qd);
        }

     
        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Bao_cao bc = new Bao_cao();
            bc.Show();
        }
    }
}
