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
    public partial class Ho_so_gia_pha : Form
    {
        public Ho_so_gia_pha()
        {
            InitializeComponent();
        }

        private void pcView_Click(object sender, EventArgs e)
        {
            Gia_PhaDataContext db = new Gia_PhaDataContext();
            datathongtin.DataSource = db.THONG_TIN_TVs.Select(p=>p);
        }

        private void pcAdd_Click(object sender, EventArgs e)
        {

        }

        private void pcEdit_Click(object sender, EventArgs e)
        {

        }

        private void pcDelete_Click(object sender, EventArgs e)
        {

        }

        private void datathongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
