using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OgrenciNotKayıtSistemi
{
    public partial class OgrenciDetay : Form
    {
        public OgrenciDetay()
        {
            InitializeComponent();
        }
        public string Numara;
        SqlConnection baglanti= new SqlConnection(@"Data Source=DESKTOP-P1SH4NN\SQL;Initial Catalog=OgrenciNotOtomasyonu;Integrated Security=True");

        private void OgrenciDetay_Load(object sender, EventArgs e)
        {
           lblnumara.Text= Numara;
            baglanti.Open();
            SqlCommand komut= new SqlCommand("select * from Tbl_ogrencidetay where ogrno=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", Numara);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1].ToString() + "" + dr[2].ToString();
                lbls1.Text= dr[4].ToString();
                lbls2.Text=dr[5].ToString();
                lbls3.Text=dr[6].ToString();
                lblortalama.Text= dr[7].ToString();
                lbldurum.Text= dr[8].ToString();
            }
            baglanti.Close();
            if (lbldurum.Text=="True")
            {
                lbldurum.Text = "Gecti.";

            }
            else
            {
                lbldurum.Text = "Kaldı.";
            }

        }
    }
}
