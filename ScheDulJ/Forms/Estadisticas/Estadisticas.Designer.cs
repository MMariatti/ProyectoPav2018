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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartEventosMensuales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartItemsPorAño = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartEventosMensuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemsPorAño)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEventosMensuales
            // 
            this.chartEventosMensuales.BackColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartArea1";
            this.chartEventosMensuales.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartEventosMensuales.Legends.Add(legend3);
            this.chartEventosMensuales.Location = new System.Drawing.Point(30, 12);
            this.chartEventosMensuales.Name = "chartEventosMensuales";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Cantidad Eventos";
            series3.XValueMember = "Mes";
            series3.YValueMembers = "Cantidad";
            this.chartEventosMensuales.Series.Add(series3);
            this.chartEventosMensuales.Size = new System.Drawing.Size(732, 233);
            this.chartEventosMensuales.TabIndex = 0;
            this.chartEventosMensuales.Text = "chartEventosAnuales";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Titulo";
            title3.Text = "Eventos por mes global";
            this.chartEventosMensuales.Titles.Add(title3);
            // 
            // chartItemsPorAño
            // 
            this.chartItemsPorAño.BackColor = System.Drawing.Color.DarkGray;
            chartArea4.Name = "ChartArea1";
            this.chartItemsPorAño.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartItemsPorAño.Legends.Add(legend4);
            this.chartItemsPorAño.Location = new System.Drawing.Point(30, 251);
            this.chartItemsPorAño.Name = "chartItemsPorAño";
            this.chartItemsPorAño.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Cantidad Solicitada";
            series4.XValueMember = "Nombre";
            series4.YValueMembers = "Cantidad";
            this.chartItemsPorAño.Series.Add(series4);
            this.chartItemsPorAño.Size = new System.Drawing.Size(732, 253);
            this.chartItemsPorAño.TabIndex = 1;
            this.chartItemsPorAño.Text = "chart2";
            title4.BackColor = System.Drawing.Color.Transparent;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Equipamiento Por Año";
            title4.Text = "Equipamiento Utilizado Anualmente";
            this.chartItemsPorAño.Titles.Add(title4);
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