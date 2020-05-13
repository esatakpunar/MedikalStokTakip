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
    public partial class frmSatisRaporla : Form
    {
        public frmSatisRaporla()
        {
            InitializeComponent();
        }

        private void frmSatisRaporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Stok_TakipDataSet.satis' table. You can move, or remove it, as needed.
            this.satisTableAdapter.Fill(this.Stok_TakipDataSet.satis);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
