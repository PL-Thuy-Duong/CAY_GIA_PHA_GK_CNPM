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

      
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if(txtpass.PasswordChar == '\0')
            {
                txtpass.PasswordChar = '●';
                guna2PictureBox2.Image = GIAO_DIEN_CNPM.Properties.Resources.show_pass;
            }
            else
            {
                txtpass.PasswordChar = '\0';
                guna2PictureBox2.Image = GIAO_DIEN_CNPM.Properties.Resources.hide_pass;
            }
        }
    }
}
