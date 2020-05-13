namespace StokTakipProgrami
{
    partial class frmUrunListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisfiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SatisFiyatitxt = new System.Windows.Forms.TextBox();
            this.Barkodtxt = new System.Windows.Forms.TextBox();
            this.AlisFiyatitxt = new System.Windows.Forms.TextBox();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.Miktaritxt = new System.Windows.Forms.TextBox();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.UrunAditxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkod,
            this.kategori,
            this.marka,
            this.urunadi,
            this.miktari,
            this.alisfiyati,
            this.satisfiyati,
            this.tarih});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(258, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 543);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // barkod
            // 
            this.barkod.DataPropertyName = "barkod";
            this.barkod.HeaderText = "Barkod";
            this.barkod.Name = "barkod";
            this.barkod.ReadOnly = true;
            // 
            // kategori
            // 
            this.kategori.DataPropertyName = "kategori";
            this.kategori.HeaderText = "Kategori";
            this.kategori.Name = "kategori";
            this.kategori.ReadOnly = true;
            // 
            // marka
            // 
            this.marka.DataPropertyName = "marka";
            this.marka.HeaderText = "Marka";
            this.marka.Name = "marka";
            this.marka.ReadOnly = true;
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
            this.miktari.HeaderText = "Miktar";
            this.miktari.Name = "miktari";
            this.miktari.ReadOnly = true;
            // 
            // alisfiyati
            // 
            this.alisfiyati.DataPropertyName = "alisfiyati";
            this.alisfiyati.HeaderText = "Alış Fiyatı";
            this.alisfiyati.Name = "alisfiyati";
            this.alisfiyati.ReadOnly = true;
            // 
            // satisfiyati
            // 
            this.satisfiyati.DataPropertyName = "satisfiyati";
            this.satisfiyati.HeaderText = "Satış Fiyatı";
            this.satisfiyati.Name = "satisfiyati";
            this.satisfiyati.ReadOnly = true;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageKey = "direction.png";
            this.btnGuncelle.ImageList = this.imageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(114, 339);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(131, 34);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(16, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(25, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(43, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(29, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(45, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(31, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Kategori";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(39, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Barkod";
            // 
            // SatisFiyatitxt
            // 
            this.SatisFiyatitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SatisFiyatitxt.Location = new System.Drawing.Point(135, 292);
            this.SatisFiyatitxt.Name = "SatisFiyatitxt";
            this.SatisFiyatitxt.Size = new System.Drawing.Size(100, 27);
            this.SatisFiyatitxt.TabIndex = 28;
            // 
            // Barkodtxt
            // 
            this.Barkodtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Barkodtxt.Location = new System.Drawing.Point(135, 58);
            this.Barkodtxt.Name = "Barkodtxt";
            this.Barkodtxt.Size = new System.Drawing.Size(100, 27);
            this.Barkodtxt.TabIndex = 21;
            // 
            // AlisFiyatitxt
            // 
            this.AlisFiyatitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AlisFiyatitxt.Location = new System.Drawing.Point(135, 253);
            this.AlisFiyatitxt.Name = "AlisFiyatitxt";
            this.AlisFiyatitxt.Size = new System.Drawing.Size(100, 27);
            this.AlisFiyatitxt.TabIndex = 27;
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kategoritxt.Location = new System.Drawing.Point(135, 97);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(100, 27);
            this.Kategoritxt.TabIndex = 23;
            // 
            // Miktaritxt
            // 
            this.Miktaritxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Miktaritxt.Location = new System.Drawing.Point(135, 214);
            this.Miktaritxt.Name = "Miktaritxt";
            this.Miktaritxt.Size = new System.Drawing.Size(100, 27);
            this.Miktaritxt.TabIndex = 26;
            // 
            // Markatxt
            // 
            this.Markatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Markatxt.Location = new System.Drawing.Point(135, 136);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(100, 27);
            this.Markatxt.TabIndex = 24;
            // 
            // UrunAditxt
            // 
            this.UrunAditxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunAditxt.Location = new System.Drawing.Point(135, 175);
            this.UrunAditxt.Name = "UrunAditxt";
            this.UrunAditxt.Size = new System.Drawing.Size(100, 27);
            this.UrunAditxt.TabIndex = 25;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "send-to-trash.png";
            this.btnSil.ImageList = this.imageList1;
            this.btnSil.Location = new System.Drawing.Point(3, 339);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 34);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodAra.Location = new System.Drawing.Point(1028, 24);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(179, 27);
            this.txtBarkodAra.TabIndex = 37;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(825, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Barkod\' a Göre Ara";
            // 
            // comboKategori
            // 
            this.comboKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(114, 379);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(121, 28);
            this.comboKategori.TabIndex = 39;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(114, 418);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 28);
            this.comboMarka.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Marka";
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarkaGuncelle.ImageKey = "direction.png";
            this.btnMarkaGuncelle.ImageList = this.imageList1;
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(29, 452);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(206, 56);
            this.btnMarkaGuncelle.TabIndex = 43;
            this.btnMarkaGuncelle.Text = "Kategori/Marka Güncelle";
            this.btnMarkaGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageKey = "bars.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(27, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 44);
            this.button1.TabIndex = 44;
            this.button1.Text = "Raporla";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "business.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(27, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 44);
            this.button2.TabIndex = 45;
            this.button2.Text = "Stok Grafiği";
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1032, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1219, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SatisFiyatitxt);
            this.Controls.Add(this.Barkodtxt);
            this.Controls.Add(this.AlisFiyatitxt);
            this.Controls.Add(this.Kategoritxt);
            this.Controls.Add(this.Miktaritxt);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.UrunAditxt);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SatisFiyatitxt;
        private System.Windows.Forms.TextBox Barkodtxt;
        private System.Windows.Forms.TextBox AlisFiyatitxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.TextBox Miktaritxt;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox UrunAditxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn alisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisfiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}