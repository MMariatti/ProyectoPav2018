﻿namespace ScheDulJ.Forms.FormsReportes
{
    partial class frmReporteEventos
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
            this.dataSetScheDulJ = new ScheDulJ.DataSetScheDulJ();
            this.dataSetScheDulJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter = new ScheDulJ.DataSetScheDulJTableAdapters.EventosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheDulJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheDulJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteEventos";
            reportDataSource1.Value = this.eventosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ScheDulJ.Reportes.REventos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetScheDulJ
            // 
            this.dataSetScheDulJ.DataSetName = "DataSetScheDulJ";
            this.dataSetScheDulJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetScheDulJBindingSource
            // 
            this.dataSetScheDulJBindingSource.DataSource = this.dataSetScheDulJ;
            this.dataSetScheDulJBindingSource.Position = 0;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "Eventos";
            this.eventosBindingSource.DataSource = this.dataSetScheDulJBindingSource;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteEventos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Eventos";
            this.Load += new System.EventHandler(this.frmReporteEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheDulJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheDulJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetScheDulJ dataSetScheDulJ;
        private System.Windows.Forms.BindingSource dataSetScheDulJBindingSource;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private DataSetScheDulJTableAdapters.EventosTableAdapter eventosTableAdapter;
    }
}