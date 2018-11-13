namespace ScheDulJ.Forms.Estadisticas
{
    partial class frmEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartEventosMensuales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartItemsPorAño = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSalir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.chartEventosMensuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemsPorAño)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEventosMensuales
            // 
            this.chartEventosMensuales.BackColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.chartEventosMensuales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEventosMensuales.Legends.Add(legend1);
            this.chartEventosMensuales.Location = new System.Drawing.Point(30, 12);
            this.chartEventosMensuales.Name = "chartEventosMensuales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Cantidad Eventos";
            series1.XValueMember = "Mes";
            series1.YValueMembers = "Cantidad";
            this.chartEventosMensuales.Series.Add(series1);
            this.chartEventosMensuales.Size = new System.Drawing.Size(732, 233);
            this.chartEventosMensuales.TabIndex = 0;
            this.chartEventosMensuales.Text = "chartEventosAnuales";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Titulo";
            title1.Text = "Eventos por mes global";
            this.chartEventosMensuales.Titles.Add(title1);
            // 
            // chartItemsPorAño
            // 
            this.chartItemsPorAño.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.chartItemsPorAño.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartItemsPorAño.Legends.Add(legend2);
            this.chartItemsPorAño.Location = new System.Drawing.Point(30, 251);
            this.chartItemsPorAño.Name = "chartItemsPorAño";
            this.chartItemsPorAño.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Cantidad Solicitada";
            series2.XValueMember = "Nombre";
            series2.YValueMembers = "Cantidad";
            this.chartItemsPorAño.Series.Add(series2);
            this.chartItemsPorAño.Size = new System.Drawing.Size(732, 253);
            this.chartItemsPorAño.TabIndex = 1;
            this.chartItemsPorAño.Text = "chart2";
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Equipamiento Por Año";
            title2.Text = "Equipamiento Utilizado Anualmente";
            this.chartItemsPorAño.Titles.Add(title2);
            this.chartItemsPorAño.Click += new System.EventHandler(this.chartItemsPorAño_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(671, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 39);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(76, 28);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chartItemsPorAño);
            this.Controls.Add(this.chartEventosMensuales);
            this.Name = "frmEstadisticas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEventosMensuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemsPorAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEventosMensuales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartItemsPorAño;
        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}