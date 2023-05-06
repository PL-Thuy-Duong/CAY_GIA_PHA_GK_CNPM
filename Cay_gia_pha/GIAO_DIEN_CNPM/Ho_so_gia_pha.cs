using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        /*        private void pcTimKiem_Click_1(object sender, EventArgs e)
                {
                    using (Gia_PhaDataContext db = new Gia_PhaDataContext())
                    {
                        datathongtin.DataSource = db.THONG_TIN_TVs.Where(p => p.TenTV.Equals(txtTimKiem));
                    }
                } 


        */
        private void pcDelete_Click_1(object sender, EventArgs e)
        {
            //lấy ra cái id cột khi bấm vào dòng muốn xóa
            using (Gia_PhaDataContext db = new Gia_PhaDataContext())
            {
                string id = datathongtin.SelectedCells[0].OwningRow.Cells["MaTV"].Value.ToString();
                THONG_TIN_TV delete = db.THONG_TIN_TVs.Where(p => p.MaTV.Equals(id)).SingleOrDefault();
                db.THONG_TIN_TVs.DeleteOnSubmit(delete);
                //lưu lại data
                db.SubmitChanges();
                //load lại
                pictureBox2_Click(sender, e);
            }
        }
        private void txtSearch_keypress(object sender, KeyPressEventArgs e)
        {
        }


        private void pcTimKiem_Click(object sender, EventArgs e)
        {
            using (Gia_PhaDataContext db = new Gia_PhaDataContext())
            {
                datathongtin.DataSource = db.THONG_TIN_TVs.Where(p => p.Doi.Equals(txtTimKiem));
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)//xem hồ sơ thành viên
        {
            using (Gia_PhaDataContext db = new Gia_PhaDataContext())
            {
                /*datathongtin.DataSource = db.THONG_TIN_TVs.Select(p => p);*/
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

        private void pcEdit_Click_1(object sender, EventArgs e)
        {

            Chinh_sua chinh_Sua = new Chinh_sua();  
            chinh_Sua.Show();
           /* using (Gia_PhaDataContext db = new Gia_PhaDataContext())
            {
                //lấy thoogn tin
                string name = datathongtin.SelectedCells[0].OwningRow.Cells["TenTV"].Value.ToString();
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
                edit.NgheNghiep = nn;
                edit.QueQuan = qq;

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


                //lưu lại data
                db.SubmitChanges();
                //load lại
                pictureBox2_Click(sender, e);

            }*/
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
    }
}
