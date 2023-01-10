namespace Bank_Darah
{
    partial class Laporan
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Bank_DarahKIKIDataSet = new Bank_Darah.Bank_DarahKIKIDataSet();
            this.view_detaildonasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_detaildonasiTableAdapter = new Bank_Darah.Bank_DarahKIKIDataSetTableAdapters.view_detaildonasiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Bank_DarahKIKIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_detaildonasiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_detaildonasiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bank_Darah.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(893, 463);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // Bank_DarahKIKIDataSet
            // 
            this.Bank_DarahKIKIDataSet.DataSetName = "Bank_DarahKIKIDataSet";
            this.Bank_DarahKIKIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_detaildonasiBindingSource
            // 
            this.view_detaildonasiBindingSource.DataMember = "view_detaildonasi";
            this.view_detaildonasiBindingSource.DataSource = this.Bank_DarahKIKIDataSet;
            // 
            // view_detaildonasiTableAdapter
            // 
            this.view_detaildonasiTableAdapter.ClearBeforeFill = true;
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 464);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Laporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bank_DarahKIKIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_detaildonasiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_detaildonasiBindingSource;
        private Bank_DarahKIKIDataSet Bank_DarahKIKIDataSet;
        private Bank_DarahKIKIDataSetTableAdapters.view_detaildonasiTableAdapter view_detaildonasiTableAdapter;
    }
}