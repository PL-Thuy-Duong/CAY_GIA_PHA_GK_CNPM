using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GIAO_DIEN_CNPM
{
    public partial class Tiep_nhan_TT : Form
    {
        public Tiep_nhan_TT()
        {
            InitializeComponent();
        }
        private void hienthithanhtich()
        {
            Gia_PhaDataContext contex = new Gia_PhaDataContext();
            dtgvthanhtich.DataSource = from u in contex.THANH_TICHes
                                       select new
                                       {
                                           Mã_Thành_Viên = u.MaTVien,
                                           Loại_Thành_Tích = u.TenTT,
                                           Ngày_Phát_Sinh=u.NgayGN
                                       };
        }
        private void btKtraDN_Click(object sender, EventArgs e)
        {
            
           
            if (lstHovaTen.SelectedValue == null)
            {
                return;
            }

            try
            {
                Gia_PhaDataContext contex = new Gia_PhaDataContext();
                //THONG_TIN_TV ttin = new THONG_TIN_TV();

                string ma = txtmatv.Text;
                THONG_TIN_TV ttin = contex.THONG_TIN_TVs.FirstOrDefault(x => x.MaTV == ma); 
                THANH_TICH tt = new THANH_TICH();

  /*              if (ttin != null)
                {*/
                    tt.MaTVien = txtmatv.Text;
                    tt.TenTT = txtthtich.Text;
                    DateTime npsinh = DateTime.ParseExact(txtnps.Text, "mm/dd/yyyy", null);
                    tt.NgayGN = npsinh;

                    ttin.MaTV = txtmatv.Text;
                    ttin.ThanhTich = txtthtich.Text;

                    contex.THANH_TICHes.InsertOnSubmit(tt);

                    contex.SubmitChanges();
                    MessageBox.Show("Tiếp nhận thành công");
                    hienthithanhvienlistbox();
                    hienthithanhtich();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txthvt_TextChanged(object sender, EventArgs e)
        {

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
            txthvt.Text = tv.TenTV;
            txtthtich.Text = tv.ThanhTich;
            txtmatv.Text = tv.MaTV;

        }

        private void Tiep_nhan_TT_Load(object sender, EventArgs e)
        {
            hienthithanhtich();
            hienthithanhvienlistbox();
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

        private void dtgvthanhtich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            hienthithanhtich();
            hienthithanhvienlistbox();

        }
    }
}
