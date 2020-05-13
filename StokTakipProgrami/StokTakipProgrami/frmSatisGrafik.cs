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
    public partial class frmSatisGrafik : Form
    {
        public frmSatisGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=Stok_Takip;Integrated Security=True");

        private void frmSatisGrafik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select urunadi,sum(miktari) as miktari from satis group by urunadi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Satışlar"].Points.AddXY(oku[0].ToString(), oku[1].ToString());
            }
        }
    }
}
