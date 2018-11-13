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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartEventosMensuales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartItemsPorAño = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartEventosMensuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemsPorAño)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEventosMensuales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEventosMensuales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEventosMensuales.Legends.Add(legend1);
            this.chartEventosMensuales.Location = new System.Drawing.Point(30, 34);
            this.chartEventosMensuales.Name = "chartEventosMensuales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEventosMensuales.Series.Add(series1);
            this.chartEventosMensuales.Size = new System.Drawing.Size(732, 240);
            this.chartEventosMensuales.TabIndex = 0;
            this.chartEventosMensuales.Text = "chartEventosAnuales";
            // 
            // chartItemsPorAño
            // 
            this.chartItemsPorAño.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.chartItemsPorAño.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartItemsPorAño.Legends.Add(legend2);
            this.chartItemsPorAño.Location = new System.Drawing.Point(30, 309);
            this.chartItemsPorAño.Name = "chartItemsPorAño";
            this.chartItemsPorAño.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Equipamiento";
            series2.XValueMember = "Nombre";
            series2.YValueMembers = "Cantidad";
            this.chartItemsPorAño.Series.Add(series2);
            this.chartItemsPorAño.Size = new System.Drawing.Size(732, 240);
            this.chartItemsPorAño.TabIndex = 1;
            this.chartItemsPorAño.Text = "chart2";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Name = "Equipamiento Por Año";
            title1.Text = "Equipamiento Utilizado Anualmente";
            this.chartItemsPorAño.Titles.Add(title1);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.chartItemsPorAño);
            this.Controls.Add(this.chartEventosMensuales);
            this.Name = "frmEstadisticas";
            this.ShowIcon = false;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEventosMensuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemsPorAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEventosMensuales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartItemsPorAño;
    }
}