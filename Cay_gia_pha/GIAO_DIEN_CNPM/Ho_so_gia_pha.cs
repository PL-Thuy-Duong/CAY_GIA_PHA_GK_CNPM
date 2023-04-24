﻿using System;
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
                //datathongtin.DataSource = db.THONG_TIN_TVs.Select(p => p);
                datathongtin.DataSource = from u in db.THONG_TIN_TVs
                                          from v in db.NGHE_NGHIEPs
                                          from t in db.QUE_QUANs
                                          from z in db.QUAN_HEs
                                          from x in db.THANH_TICHes
                                          where u.MaQQ == t.MaQQ
                                          where u.MaNN == v.maNN
                                          where u.MaTV == z.MaTV1
                                          where x.MaTT == u.MaTT
                                          select new
                                          {
                                              Họ_và_Tên_TV_1 = u.TenTV,
                                              Ngày_Sinh = u.NgayGSinh,
                                              Đời = u.Doi,
                                              Nghề_Nghiệp = v.TenNN,
                                              Quê_Quán = t.TenQQ,
                                              Thành_Tích = x.TenTT,
                                              Cha_Mẹ = z.MaTV2

                                          };


            }
        }

        private void pcEdit_Click_1(object sender, EventArgs e)
        {
            using (Gia_PhaDataContext db = new Gia_PhaDataContext())
            {
                //lấy thoogn tin
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

            }
        }

        private void pcAdd_Click(object sender, EventArgs e)
        {
            Tiep_nhan_tv tiep_Nhan = new Tiep_nhan_tv();
            tiep_Nhan.Show();   
        }
    }
}
