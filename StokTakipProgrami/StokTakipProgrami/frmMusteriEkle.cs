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

namespace StokTakipProgrami
{
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteri(tc,adsoyad,telefon,adres,eposta) values(@tc,@adsoyad,@telefon,@adres,@eposta)", baglanti);
            komut.Parameters.AddWithValue("@tc",txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@eposta", txtEposta.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı başarıyla eklendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }


        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
