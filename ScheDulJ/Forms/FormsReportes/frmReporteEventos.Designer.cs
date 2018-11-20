namespace ScheDulJ.Forms.FormsReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteEventos));
            this.eventosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.eventosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equipamientoMasUtilizadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.dataSetScheDulJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetScheDulJ = new ScheDulJ.DataSetScheDulJ();
            this.eventosTableAdapter = new ScheDulJ.DataSetScheDulJTableAdapters.EventosTableAdapter();
            this.equipamientoMasUtilizadoTableAdapter = new ScheDulJ.DataSetScheDulJTableAdapters.EquipamientoMasUtilizadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoMasUtilizadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheDulJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheDulJ)).BeginInit();
            this.SuspendLayout();
            // 
            // eventosBindingSource2
            // 
            this.eventosBindingSource2.DataMember = "Eventos";
            this.eventosBindingSource2.DataSource = this.dataSetScheDulJBindingSource;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "Eventos";
            this.eventosBindingSource.DataSource = this.dataSetScheDulJBindingSource;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ScheDulJ.Reportes.REventos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(634, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // eventosBindingSource1
            // 
            this.eventosBindingSource1.DataMember = "Eventos";
            this.eventosBindingSource1.DataSource = this.dataSetScheDulJBindingSource;
            // 
            // equipamientoMasUtilizadoBindingSource
            // 
            this.equipamientoMasUtilizadoBindingSource.DataMember = "EquipamientoMasUtilizado";
            this.equipamientoMasUtilizadoBindingSource.DataSource = this.dataSetScheDulJBindingSource;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(233, 11);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(115, 24);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(155, 14);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(72, 20);
            this.txtAño.TabIndex = 2;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(105, 14);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(44, 18);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año*:";
            // 
            // dataSetScheDulJBindingSource
            // 
            this.dataSetScheDulJBindingSource.DataSource = this.dataSetScheDulJ;
            this.dataSetScheDulJBindingSource.Position = 0;
            // 
            // dataSetScheDulJ
            // 
            this.dataSetScheDulJ.DataSetName = "DataSetScheDulJ";
            this.dataSetScheDulJ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // equipamientoMasUtilizadoTableAdapter
            // 
            this.equipamientoMasUtilizadoTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Eventos";
            this.Load += new System.EventHandler(this.frmReporteEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoMasUtilizadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheDulJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheDulJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetScheDulJ dataSetScheDulJ;
        private System.Windows.Forms.BindingSource dataSetScheDulJBindingSource;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private DataSetScheDulJTableAdapters.EventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.BindingSource eventosBindingSource1;
        private System.Windows.Forms.BindingSource equipamientoMasUtilizadoBindingSource;
        private DataSetScheDulJTableAdapters.EquipamientoMasUtilizadoTableAdapter equipamientoMasUtilizadoTableAdapter;
        private System.Windows.Forms.BindingSource eventosBindingSource2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
    }
}