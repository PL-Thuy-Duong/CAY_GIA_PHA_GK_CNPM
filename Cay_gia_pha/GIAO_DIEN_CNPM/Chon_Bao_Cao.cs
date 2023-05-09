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
    public partial class Chon_Bao_Cao : Form
    {
        public Chon_Bao_Cao()
        {
            InitializeComponent();
        }

        private void Chon_Bao_Cao_Load(object sender, EventArgs e)
        {

        }

        private void btnTGTV_Click(object sender, EventArgs e)
        {
            Bao_Cao_TGTV bao_Cao_TGTV = new Bao_Cao_TGTV();
            bao_Cao_TGTV.Show();
        }

        private void btnSLTT_Click(object sender, EventArgs e)
        {
            Bao_Cao_SLTT_1 bao_Cao_SLTT_1 = new Bao_Cao_SLTT_1();
            bao_Cao_SLTT_1.Show();
        }
    }
}

 

