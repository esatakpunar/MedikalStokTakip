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

namespace StokTakipProgrami
{
    public partial class frmSatisListele : Form
    {
        public frmSatisListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            baglanti.Close();
        }

        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            satislistele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSatisGrafik ekle = new frmSatisGrafik();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSatisRaporla raporla = new frmSatisRaporla();
            raporla.ShowDialog();
        }
    }
}
