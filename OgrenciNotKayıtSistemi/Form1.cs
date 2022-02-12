using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayıtSistemi
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            OgrenciDetay frm= new OgrenciDetay();
            frm.Numara = mskOgrNo.Text;
            frm.Show();
            

        }

        private void mskOgrNo_TextChanged(object sender, EventArgs e)
        {
            if (mskOgrNo.Text=="1111")
            {
                OgretmenDetay frm = new OgretmenDetay();
                frm.Show();

            }
        }
    }
}
