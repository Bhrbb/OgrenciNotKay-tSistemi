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
    public partial class OgretmenDetay : Form
    {
        public OgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-P1SH4NN\SQL;Initial Catalog=OgrenciNotOtomasyonu;Integrated Security=True");
      
        


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kaydet= new SqlCommand("insert into tbl_ogrencidetay (ogrno,ogrAd,ogrSoyad) values (@p1,@p2,@p3)",baglanti);
            kaydet.Parameters.AddWithValue("@p1",mskogrNo.Text);
            kaydet.Parameters.AddWithValue("@p2",txtAd.Text);
            kaydet.Parameters.AddWithValue("@p3",txtSoyad.Text);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ogrenci Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.tbl_ogrencidetayTableAdapter.Fill(this.ogrenciNotOtomasyonuDataSet.Tbl_ogrencidetay);
        }

        private void OgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciNotOtomasyonuDataSet.Tbl_ogrencidetay' table. You can move, or remove it, as needed.
            this.tbl_ogrencidetayTableAdapter.Fill(this.ogrenciNotOtomasyonuDataSet.Tbl_ogrencidetay);
            baglanti.Open();
            SqlCommand say = new SqlCommand("SELECT COUNT(ORTALAMA) FROM Tbl_ogrencidetay WHERE ORTALAMA>=50;", baglanti);
            SqlDataReader dr = say.ExecuteReader();
            while (dr.Read())
            {
                lblgecensayi.Text = dr[0].ToString();

            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand say2 = new SqlCommand("SELECT COUNT(ORTALAMA) FROM Tbl_ogrencidetay WHERE ORTALAMA<50;", baglanti);
            SqlDataReader dr2= say2.ExecuteReader();
            
            while (dr2.Read())
            {
                lblkalansayi.Text = dr2[0].ToString();
            }
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            double ortalama, s1, s2, s3,gecen=0,kalan=0;
            string durum;
            s1 = Convert.ToDouble(txtSınav1.Text);
            s2 = Convert.ToDouble(txtSınav2.Text);
            s3 = Convert.ToDouble(txtSınav3.Text);
            ortalama =Convert.ToDouble( (s1 + s2 + s3) / 3);
            label10.Text = ortalama.ToString();
            if (ortalama>=50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_ogrencidetay set sınav1=@p1,Sınav2=@p2,Sınav3=@p3,ortalama=@p4,durum=@p5 where ogrNo=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSınav1.Text);
            komut.Parameters.AddWithValue("@p2", txtSınav2.Text);
            komut.Parameters.AddWithValue("@p3", txtSınav3.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(label10.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", mskogrNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Guncellendi.");
            /*
            if (durum=="True")
            {
                gecen += 1;
                

            }
            else
            {
                kalan += 1;
            }
            */
            lblgecensayi.Text = gecen.ToString();
            lblkalansayi.Text=kalan.ToString();
           

           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text=dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskogrNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


        }
    }
}
