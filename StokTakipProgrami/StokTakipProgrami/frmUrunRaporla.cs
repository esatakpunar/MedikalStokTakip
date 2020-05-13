using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgrami
{
    public partial class frmUrunRaporla : Form
    {
        public frmUrunRaporla()
        {
            InitializeComponent();
        }

        private void frmUrunRaporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Stok_TakipDataSet.urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter.Fill(this.Stok_TakipDataSet.urun);

            this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
