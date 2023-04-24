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
    public partial class Dang_nhap : Form
    {
        private Trang_chu trang_Chu;
        public Dang_nhap(Trang_chu trang_Chu)
        {
            InitializeComponent();
            this.trang_Chu = trang_Chu;
            trang_Chu.Hide();
        }

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            trang_Chu.Show();
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if(txtpass.PasswordChar == '\0')
            {
                txtpass.PasswordChar = '●';
                guna2PictureBox2.Image = GIAO_DIEN_CNPM.Properties.Resources.hide_pass;
            }
            else
            {
                txtpass.PasswordChar = '\0';
                guna2PictureBox2.Image = GIAO_DIEN_CNPM.Properties.Resources.show_pass;
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

    
        private void btKtraDN_Click(object sender, EventArgs e)
        {
            Trang_chinh tc = new Trang_chinh(this);
            tc.Show();
        }
    }
}
