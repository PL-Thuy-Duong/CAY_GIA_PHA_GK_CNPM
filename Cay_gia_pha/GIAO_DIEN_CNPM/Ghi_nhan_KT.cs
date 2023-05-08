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
    public partial class Ghi_nhan_KT : Form
    {
        public Ghi_nhan_KT()
        {
            InitializeComponent();
        }
        private void hienthingmat()
        {
            Gia_PhaDataContext contex = new Gia_PhaDataContext();
            dtgvngmat.DataSource = from u in contex.NN_DD_KET_THUCs
                                       select new
                                       {
                                           Mã_Thành_Viên = u.MaTV,
                                           Nguyên_Nhân = u.NguyenNhan,
                                           Địa_Điểm = u.DD,
                                           Ngày_Mât = u.NgayGio
                                       };
        }
        private void hienthithanhvienlistbox()
        {

            Gia_PhaDataContext contex = new Gia_PhaDataContext();
            List<THONG_TIN_TV> dmtv = contex.THONG_TIN_TVs.ToList();
            lstHovaTen.DataSource = dmtv;
            lstHovaTen.ValueMember = "MaTV";
            lstHovaTen.DisplayMember = "TenTV";
            dautien = true;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (lstHovaTen.SelectedValue == null)
            {
                return;
            }

            try
            {
                Gia_PhaDataContext contex = new Gia_PhaDataContext();
                string ma = txtmatv.Text;
                THONG_TIN_TV ttin = contex.THONG_TIN_TVs.FirstOrDefault(x => x.MaTV == ma);
                NN_DD_KET_THUC nnkt = new NN_DD_KET_THUC(); 

                nnkt.MaTV = txtmatv.Text;
                nnkt.DD = txtDDmt.Text;
                nnkt.NguyenNhan = txtNgnhan.Text;
                DateTime nmat = DateTime.ParseExact(txtNgaymat.Text, "mm/dd/yyyy", null);
                nnkt.NgayGio = nmat;

                contex.NN_DD_KET_THUCs.InsertOnSubmit(nnkt);

                contex.SubmitChanges();
                MessageBox.Show("Tiếp nhận thành công");
                txtNgaymat.Clear();
                txtNgnhan.Clear();
                txtDDmt.Clear();
                hienthithanhvienlistbox();
                hienthingmat();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        bool dautien = true;
        private void lstHovaTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dautien == false)
            {
                return;
            }
            if (lstHovaTen.SelectedValue == null)
            {
                return;
            }
            THONG_TIN_TV tv = lstHovaTen.SelectedItem as THONG_TIN_TV;
            txthovaten.Text = tv.TenTV;
            txtmatv.Text = tv.MaTV;
           
        }

        private void Ghi_nhan_KT_Load(object sender, EventArgs e)
        {
            hienthingmat();
            hienthithanhvienlistbox();
        }
    }
}
