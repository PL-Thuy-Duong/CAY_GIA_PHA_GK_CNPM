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
    public partial class Chinh_sua : Form
    {

        public Chinh_sua()
        {
            InitializeComponent();
        }

        private void Chinh_sua_Load(object sender, EventArgs e)
        {
            hienthithanhvienlistbox();
        }
        private void hienthithanhvienlistbox()
        {
            Gia_PhaDataContext contex = new Gia_PhaDataContext();
            List<THONG_TIN_TV> dmtv = contex.THONG_TIN_TVs.ToList ();
            lstTvien.DataSource = dmtv;
            lstTvien.ValueMember = "MaTV";
            lstTvien.DisplayMember = "TenTV";
            dautien = true;
        }
        bool dautien = false;
        private void lstTvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dautien == false )
            {
                return;
            }    
            if(lstTvien.SelectedValue == null)
            {
                return;
            }    
            THONG_TIN_TV tv = lstTvien.SelectedItem as THONG_TIN_TV;
            
            txtmaTV.Text = tv.MaTV;
            txtqq.Text = tv.QueQuan;
            txtten.Text = tv.TenTV;
            txtnn.Text = tv.NgheNghiep;
            txttt.Text = tv.ThanhTich;

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lstTvien.SelectedValue == null)
            {
                return;
            }

            try
            {
                string ma = txtmaTV.Text;
                Gia_PhaDataContext contex = new Gia_PhaDataContext();
                THONG_TIN_TV tt = contex.THONG_TIN_TVs.FirstOrDefault(x => x.MaTV == ma);
                tt.QueQuan = txtqq.Text;
                tt.NgheNghiep = txtnn.Text;
                tt.ThanhTich = txttt.Text;
                tt.TenTV = txtten.Text;
                contex.SubmitChanges();
                MessageBox.Show("Chỉnh sửa thành công");
                hienthithanhvienlistbox();
                }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstTvien.SelectedValue == null)
            {
                return;
            }
            try
            {
                Gia_PhaDataContext contex = new Gia_PhaDataContext();
                string ma = txtmaTV.Text;
                THONG_TIN_TV tt = contex.THONG_TIN_TVs.FirstOrDefault(x => x.MaTV == ma);

                
                if (tt != null)
                {
                    if(tt.NN_DD_KET_THUC != null)
                    {
                        MessageBox.Show("Không thể xóa vì người này đã mất");

                    }
                    contex.THONG_TIN_TVs.DeleteOnSubmit(tt);
                    contex.SubmitChanges();
                    
                    MessageBox.Show("Xóa thành công");
                    this.Close();
                }
                hienthithanhvienlistbox();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
