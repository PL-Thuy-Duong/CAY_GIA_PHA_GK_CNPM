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
    public partial class Dang_ki : Form
    {
        private Dang_nhap dang_Nhap;
        public Dang_ki(Dang_nhap dang_Nhap)
        {
            InitializeComponent();
            this.dang_Nhap = dang_Nhap;
            dang_Nhap.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            dang_Nhap.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (txtpassnew.PasswordChar == '\0')
            {
                txtpassnew.PasswordChar = '●';
                guna2PictureBox2.Image = GIAO_DIEN_CNPM.Properties.Resources.hide_pass;
            }
            else
            {
                txtpassnew.PasswordChar = '\0';
                guna2PictureBox2.Image = GIAO_DIEN_CNPM.Properties.Resources.show_pass;
            }
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.PasswordChar == '\0')
            {
                guna2TextBox3.PasswordChar = '●';
                guna2PictureBox3.Image = GIAO_DIEN_CNPM.Properties.Resources.hide_pass;
            }
            else
            {
                guna2TextBox3.PasswordChar = '\0';
                guna2PictureBox3.Image = GIAO_DIEN_CNPM.Properties.Resources.show_pass;
            }
        }
    }
}
