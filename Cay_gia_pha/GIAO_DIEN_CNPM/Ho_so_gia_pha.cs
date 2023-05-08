using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIAO_DIEN_CNPM
{
    public partial class Ho_so_gia_pha : Form
    {
        public Ho_so_gia_pha()
        {
            InitializeComponent();
        }

      
        private void loadHoSoGiaPha()
        {
            using (Gia_PhaDataContext db = new Gia_PhaDataContext())
            {
                //datathongtin.DataSource = db.THONG_TIN_TVs.Select(p => p);
                datathongtin.DataSource = from u in db.THONG_TIN_TVs
                                              // from v in db.QUAN_HEs
                                              //where u.MaTV == v.MaTV1

                                          select new
                                          {
                                              Họ_và_Tên = u.TenTV,
                                              Ngày_Sinh = u.NgayGSinh,
                                              Đời = u.Doi,
                                              Nghề_Nghiệp = u.NgheNghiep,
                                              Quê_Quán = u.QueQuan,
                                              //Cha_Mẹ = u.TenTV 
                                              //thiếu quan hệ nhen
                                          };


            }
        }



        private void txtSearch_keypress(object sender, KeyPressEventArgs e)
        {
        }


        private void pcTimKiem_Click(object sender, EventArgs e)
        {
           /* using (Gia_PhaDataContext db = new Gia_PhaDataContext())
            {
                datathongtin.DataSource = db.THONG_TIN_TVs.Where(p => p.Doi.Equals(txtTimKiem.Text));
            }*/
        }

       

        private void pcEdit_Click_1(object sender, EventArgs e)
        {

            Chinh_sua chinh_Sua = new Chinh_sua();  
            chinh_Sua.Show();
          
        }

        private void pcAdd_Click(object sender, EventArgs e)
        {
            Tiep_nhan_tv tiep_Nhan = new Tiep_nhan_tv();
            tiep_Nhan.Show();   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Tiep_nhan_TT tiep_Nhan_TT = new Tiep_nhan_TT();
            tiep_Nhan_TT.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ghi_nhan_KT ghi_Nhan_KT = new Ghi_nhan_KT();
            ghi_Nhan_KT.Show();
        }

        

        private void Ho_so_gia_pha_Load(object sender, EventArgs e)
        {
            loadHoSoGiaPha();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
            string rowFilter = string.Format("{0} like '{1}'", "TenTV", "*" + txtTimKiem.Text + "*");
            (datathongtin.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadHoSoGiaPha();
        }
    }
}
