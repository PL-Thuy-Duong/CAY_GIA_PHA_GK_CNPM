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
        public Dang_nhap()
        {
            InitializeComponent();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if(guna2TextBox2.UseSystemPasswordChar == false)
            {
                guna2TextBox2.UseSystemPasswordChar = true;
                guna2PictureBox2.Image = GIAO_DIEN_CNPM.Properties.Resources.show_pass;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = false;
                guna2PictureBox2.Image = GIAO_DIEN_CNPM.Properties.Resources.hide_pass;
            }
        }
    }
}
