namespace StokTakipProgrami
{
    partial class frmSatisRaporla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatisRaporla));
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Stok_TakipDataSet = new StokTakipProgrami.Stok_TakipDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.satisTableAdapter = new StokTakipProgrami.Stok_TakipDataSetTableAdapters.satisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok_TakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "satis";
            this.satisBindingSource.DataSource = this.Stok_TakipDataSet;
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
            reportDataSource1.Value = this.satisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "StokTakipProgrami.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // frmSatisRaporla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatisRaporla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Raporlama Sayfası";
            this.Load += new System.EventHandler(this.frmSatisRaporla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok_TakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource satisBindingSource;
        private Stok_TakipDataSet Stok_TakipDataSet;
        private Stok_TakipDataSetTableAdapters.satisTableAdapter satisTableAdapter;
    }
}