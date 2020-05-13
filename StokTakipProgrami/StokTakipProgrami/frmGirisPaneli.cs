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
    public partial class frmGirisPaneli : Form
    {
        public frmGirisPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici;
            string sifre;
            kullanici = textBox1.Text;
            sifre = textBox2.Text;
            if (kullanici=="Medikal" && sifre == "123456")
            {
                
                this.Hide();
                frmSatisSayfasi giris = new frmSatisSayfasi();
                
                giris.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.Lütfen tekrar deneyiniz..");
            }
        }

        private void frmGirisPaneli_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
