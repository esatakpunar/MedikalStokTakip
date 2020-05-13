namespace StokTakipProgrami
{
    partial class frmUrunRaporla
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunRaporla));
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stok_TakipDataSet = new StokTakipProgrami.Stok_TakipDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.urunTableAdapter = new StokTakipProgrami.Stok_TakipDataSetTableAdapters.urunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok_TakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.Stok_TakipDataSet;
            // 
            // Stok_TakipDataSet
            // 
            this.Stok_TakipDataSet.DataSetName = "Stok_TakipDataSet";
            this.Stok_TakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.urunBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StokTakipProgrami.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(969, 582);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // frmUrunRaporla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(969, 582);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunRaporla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urun Raporlama Sayfası";
            this.Load += new System.EventHandler(this.frmUrunRaporla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok_TakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private Stok_TakipDataSet Stok_TakipDataSet;
        private Stok_TakipDataSetTableAdapters.urunTableAdapter urunTableAdapter;
    }
}