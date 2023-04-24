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
    public partial class Tiep_nhan_tv : Form
    {
        public Tiep_nhan_tv()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btKtraDN_Click(object sender, EventArgs e)
        {
            using (Gia_PhaDataContext db = new Gia_PhaDataContext())
            {
                
               /* //lấy thoogn tin
                string name = datathongtin.SelectedCells[0].OwningRow.Cells["Họ_và_Tên_TV_1"].Value.ToString();
                byte gt = (byte)datathongtin.SelectedCells[0].OwningRow.Cells["Giới_Tính"].Value;
                //DateTime nsinh = (DateTime)datathongtin.SelectedCells[0].OwningRow.Cells["Ngày_Sinh"].Value;
                //DateTime npsinh = (DateTime)datathongtin.SelectedCells[0].OwningRow.Cells["Ngày_Phát_Sinh"].Value;
                string dc = datathongtin.SelectedCells[0].OwningRow.Cells["Địa_Chỉ"].Value.ToString();
                string qq = datathongtin.SelectedCells[0].OwningRow.Cells["Quê_Quán"].Value.ToString();
                string nn = datathongtin.SelectedCells[0].OwningRow.Cells["Nghề_Nghiệp"].Value.ToString();
                //cập nhập lại thong tin
                THONG_TIN_TV edit = db.THONG_TIN_TVs.Where(p => p.TenTV.Equals(name)).SingleOrDefault();
                edit.GT = gt;
                edit.DC = dc;

                if (datathongtin.SelectedCells[0].OwningRow.Cells["Ngày_Sinh"].Value == null)
                {
                    edit.NgayPSinh = null;
                }
                else
                {
                    edit.NgayPSinh = (DateTime)datathongtin.SelectedCells[0].OwningRow.Cells["Ngày_Phát_Sinh"].Value;
                }
                if (datathongtin.SelectedCells[0].OwningRow.Cells["Ngày_Sinh"].Value == null)
                {
                    edit.NgayGSinh = null;
                }
                else
                {
                    edit.NgayGSinh = (DateTime)datathongtin.SelectedCells[0].OwningRow.Cells["Ngày_Sinh"].Value;
                }

                NGHE_NGHIEP edit1 = db.NGHE_NGHIEPs.Where(p => p.TenNN.Equals(nn)).SingleOrDefault();
                QUE_QUAN edit2 = db.QUE_QUANs.Where(p => p.TenQQ.Equals(qq)).SingleOrDefault();
                //lưu lại data
                db.SubmitChanges();
                //load lại
                pictureBox2_Click(sender, e);
*/
            }
        }
    }
    }
}
