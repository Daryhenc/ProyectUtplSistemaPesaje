
namespace ReporteBascula.Reportes.Compras
{
    partial class FrmReporteCompra
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
            this.reportViewerCompras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClassObDatoListCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClassObDatoListCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerCompras
            // 
            this.reportViewerCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSCompra";
            reportDataSource1.Value = this.ClassObDatoListCompraBindingSource;
            this.reportViewerCompras.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCompras.LocalReport.ReportEmbeddedResource = "ReporteBascula.Reportes.Compras.DatoList.ReportCompra.rdlc";
            this.reportViewerCompras.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCompras.Name = "reportViewerCompras";
            this.reportViewerCompras.ServerReport.BearerToken = null;
            this.reportViewerCompras.Size = new System.Drawing.Size(1254, 578);
            this.reportViewerCompras.TabIndex = 0;
            // 
            // ClassObDatoListCompraBindingSource
            // 
            this.ClassObDatoListCompraBindingSource.DataSource = typeof(ReporteBascula.Reportes.Compras.DatoList.ClassObDatoListCompra);
            // 
            // FrmReporteCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 578);
            this.Controls.Add(this.reportViewerCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReporteCompra";
            ((System.ComponentModel.ISupportInitialize)(this.ClassObDatoListCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCompras;
        private System.Windows.Forms.BindingSource ClassObDatoListCompraBindingSource;
    }
}