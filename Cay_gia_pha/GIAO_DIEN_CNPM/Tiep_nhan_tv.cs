using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GIAO_DIEN_CNPM
{
    public partial class Tiep_nhan_tv : Form
    {
        public Tiep_nhan_tv()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void hienthithanhvienlistbox()
        {
            Gia_PhaDataContext contex = new Gia_PhaDataContext();
            List<THONG_TIN_TV> dmtv = contex.THONG_TIN_TVs.ToList();
        }
        private void btntiepnhantv_Click(object sender, EventArgs e)
        {
            try
            {
                Gia_PhaDataContext contex = new Gia_PhaDataContext();
                THONG_TIN_TV tv = new THONG_TIN_TV();
                QUAN_HE qh = new QUAN_HE();
                tv.MaTV = txtmatvmoi.Text;
                tv.TenTV = txttentvmoi.Text;
                DateTime nsinh = DateTime.ParseExact(txtngsinh.Text, "mm/dd/yyyy", null);
                tv.NgayGSinh = nsinh;
                NumberStyles style;
                style = NumberStyles.None;
                tv.GT = Byte.Parse(txtgt.Text, style);
                tv.QueQuan = txtqquan.Text;
                tv.DC = txtdc.Text;
                //tv.NgayPSinh = DateTime.Parse(txtngphatsinh.Text);
                DateTime ngps = DateTime.ParseExact(txtngphatsinh.Text, "mm/dd/yyyy", null);
                tv.NgayPSinh = ngps;
                /* qh.MaTV1 = txtmatvmoi.Text;
                 qh.QuanHe = txtloaiqhe.Text;
                 qh.MaTV2 = txtmatvcu.Text;*/

                contex.THONG_TIN_TVs.InsertOnSubmit(tv);
                contex.SubmitChanges();

               /* contex.QUAN_HEs.InsertOnSubmit(qh);
                contex.SubmitChanges();*/

                hienthithanhvienlistbox();
                MessageBox.Show("Đã lưu thành công thành viên mới!");
            }
            catch (Exception ex)//tbao khi lỗi dữ liệu
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}

