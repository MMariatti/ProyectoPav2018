namespace ScheDulJ.Forms
{
    partial class frmAdministrarTipoEventos
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
            this.gridTipoEventos = new System.Windows.Forms.DataGridView();
            this.btnNuevoTEvento = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTipoEventos
            // 
            this.gridTipoEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipoEventos.Location = new System.Drawing.Point(22, 12);
            this.gridTipoEventos.Name = "gridTipoEventos";
            this.gridTipoEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTipoEventos.Size = new System.Drawing.Size(325, 139);
            this.gridTipoEventos.TabIndex = 0;
            this.gridTipoEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTipoEventos_CellContentClick);
            // 
            // btnNuevoTEvento
            // 
            this.btnNuevoTEvento.Location = new System.Drawing.Point(353, 12);
            this.btnNuevoTEvento.Name = "btnNuevoTEvento";
            this.btnNuevoTEvento.Size = new System.Drawing.Size(100, 28);
            this.btnNuevoTEvento.TabIndex = 1;
            this.btnNuevoTEvento.Text = "Nuevo";
            this.btnNuevoTEvento.UseVisualStyleBackColor = true;
            this.btnNuevoTEvento.Click += new System.EventHandler(this.btnNuevoTEvento_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(353, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(22, 157);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(100, 28);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(353, 155);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmAdministrarTipoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 195);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevoTEvento);
            this.Controls.Add(this.gridTipoEventos);
            this.Name = "frmAdministrarTipoEventos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Tipos de Evento";
            this.Load += new System.EventHandler(this.frmAdministrarTipoEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTipoEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTipoEventos;
        private System.Windows.Forms.Button btnNuevoTEvento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnSalir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}