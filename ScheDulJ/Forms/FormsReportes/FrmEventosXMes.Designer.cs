namespace ScheDulJ.Forms.FormsReportes
{
    partial class FrmEventosXMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventosXMes));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ScheDulJ.Reportes.ReportEventoXmes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 406);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(317, 12);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(106, 23);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(211, 12);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 2;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(161, 11);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(44, 18);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año*:";
            // 
            // FrmEventosXMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEventosXMes";
            this.Text = "FrmEventosXMes";
            this.Load += new System.EventHandler(this.FrmEventosXMes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
    }
}