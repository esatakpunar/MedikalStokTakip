namespace StokTakipProgrami
{
    partial class frmSatisListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tc,
            this.adsoyad,
            this.telefon,
            this.barkod,
            this.urunadi,
            this.miktari,
            this.satisfiyati,
            this.toplamfiyati,
            this.tarih});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 440);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tc
            // 
            this.tc.DataPropertyName = "tc";
            this.tc.HeaderText = "TC";
            this.tc.Name = "tc";
            this.tc.ReadOnly = true;
            // 
            // adsoyad
            // 
            this.adsoyad.DataPropertyName = "adsoyad";
            this.adsoyad.HeaderText = "Ad Soyad";
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.ReadOnly = true;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            // 
            // barkod
            // 
            this.barkod.DataPropertyName = "barkod";
            this.barkod.HeaderText = "Barkod";
            this.barkod.Name = "barkod";
            this.barkod.ReadOnly = true;
            // 
            // urunadi
            // 
            this.urunadi.DataPropertyName = "urunadi";
            this.urunadi.HeaderText = "Ürün Adı";
            this.urunadi.Name = "urunadi";
            this.urunadi.ReadOnly = true;
            // 
            // miktari
            // 
            this.miktari.DataPropertyName = "miktari";
            this.miktari.HeaderText = "Miktarı";
            this.miktari.Name = "miktari";
            this.miktari.ReadOnly = true;
            // 
            // satisfiyati
            // 
            this.satisfiyati.DataPropertyName = "satisfiyati";
            this.satisfiyati.HeaderText = "Satış Fiyatı";
            this.satisfiyati.Name = "satisfiyati";
            this.satisfiyati.ReadOnly = true;
            // 
            // toplamfiyati
            // 
            this.toplamfiyati.DataPropertyName = "toplamfiyati";
            this.toplamfiyati.HeaderText = "Toplam Fiyatı";
            this.toplamfiyati.Name = "toplamfiyati";
            this.toplamfiyati.ReadOnly = true;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "bars.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(649, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Raporla";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "business.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(871, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Satış Grafiği";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "social-media.png");
            this.imageList1.Images.SetKeyName(1, "document.png");
            this.imageList1.Images.SetKeyName(2, "signs.png");
            this.imageList1.Images.SetKeyName(3, "commerce.png");
            this.imageList1.Images.SetKeyName(4, "shopping-list.png");
            this.imageList1.Images.SetKeyName(5, "web-design.png");
            this.imageList1.Images.SetKeyName(6, "signaling.png");
            this.imageList1.Images.SetKeyName(7, "shopping.png");
            this.imageList1.Images.SetKeyName(8, "sale.png");
            this.imageList1.Images.SetKeyName(9, "send-to-trash.png");
            this.imageList1.Images.SetKeyName(10, "interface.png");
            this.imageList1.Images.SetKeyName(11, "direction.png");
            this.imageList1.Images.SetKeyName(12, "bars.png");
            this.imageList1.Images.SetKeyName(13, "business.png");
            // 
            // frmSatisListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1087, 513);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatisListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmSatisListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
    }
}