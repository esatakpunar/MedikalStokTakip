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
    public partial class frmUrunGrafik : Form
    {
        public frmUrunGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=Stok_Takip;Integrated Security=True");
        private void frmUrunGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select urunadi,miktari from urun", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Ürünler"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            }
            baglanti.Close();
        }
    }
}
