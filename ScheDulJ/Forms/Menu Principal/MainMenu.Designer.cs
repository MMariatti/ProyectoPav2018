namespace ScheDulJ
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btnExitMainMenu = new System.Windows.Forms.Button();
            this.gridEventos = new System.Windows.Forms.DataGridView();
            this.columnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoEvento = new System.Windows.Forms.Button();
            this.btnModificarEvento = new System.Windows.Forms.Button();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.lblEventos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEventos = new System.Windows.Forms.Panel();
            this.btnRefrescarE = new System.Windows.Forms.Button();
            this.btnTipoEvento = new System.Windows.Forms.Button();
            this.btnAdministrarEquipamiento = new System.Windows.Forms.Button();
            this.gridEquipamiento = new System.Windows.Forms.DataGridView();
            this.NombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoAlquilerEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEquipamiento = new System.Windows.Forms.Label();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.btnCargarEquipamiento = new System.Windows.Forms.Button();
            this.panelEquipamiento = new System.Windows.Forms.Panel();
            this.panelAdministracion = new System.Windows.Forms.Panel();
            this.lblAdministracion = new System.Windows.Forms.Label();
            this.chartEventos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).BeginInit();
            this.panelEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipamiento)).BeginInit();
            this.panelEquipamiento.SuspendLayout();
            this.panelAdministracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitMainMenu
            // 
            this.btnExitMainMenu.Location = new System.Drawing.Point(8, 208);
            this.btnExitMainMenu.Name = "btnExitMainMenu";
            this.btnExitMainMenu.Size = new System.Drawing.Size(100, 38);
            this.btnExitMainMenu.TabIndex = 7;
            this.btnExitMainMenu.Text = "Salir";
            this.btnExitMainMenu.UseVisualStyleBackColor = true;
            this.btnExitMainMenu.Click += new System.EventHandler(this.btnExitMainMenu_Click);
            // 
            // gridEventos
            // 
            this.gridEventos.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaID,
            this.Nombre,
            this.Fecha,
            this.IDTipoEvento,
            this.HoraInicio,
            this.HoraFin,
            this.Direccion,
            this.IDCliente});
            this.gridEventos.Location = new System.Drawing.Point(30, 31);
            this.gridEventos.Name = "gridEventos";
            this.gridEventos.ReadOnly = true;
            this.gridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEventos.Size = new System.Drawing.Size(692, 203);
            this.gridEventos.TabIndex = 0;
            this.gridEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEventos_CellContentClick);
            this.gridEventos.SelectionChanged += new System.EventHandler(this.gridEventos_SelectionChanged);
            this.gridEventos.Click += new System.EventHandler(this.gridEventos_Click);
            // 
            // columnaID
            // 
            this.columnaID.DataPropertyName = "ID";
            this.columnaID.HeaderText = "ID";
            this.columnaID.Name = "columnaID";
            this.columnaID.ReadOnly = true;
            this.columnaID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaID.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // IDTipoEvento
            // 
            this.IDTipoEvento.DataPropertyName = "idTipoEvento";
            this.IDTipoEvento.HeaderText = "Tipo Evento";
            this.IDTipoEvento.Name = "IDTipoEvento";
            this.IDTipoEvento.ReadOnly = true;
            this.IDTipoEvento.Width = 60;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "horario";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            this.HoraInicio.Width = 60;
            // 
            // HoraFin
            // 
            this.HoraFin.DataPropertyName = "horarioFin";
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            this.HoraFin.Width = 60;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 140;
            // 
            // IDCliente
            // 
            this.IDCliente.DataPropertyName = "idCliente";
            this.IDCliente.HeaderText = "IDCliente";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            this.IDCliente.Width = 80;
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoEvento.Location = new System.Drawing.Point(30, 240);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(94, 38);
            this.btnNuevoEvento.TabIndex = 1;
            this.btnNuevoEvento.Text = "Nuevo Evento";
            this.btnNuevoEvento.UseVisualStyleBackColor = false;
            this.btnNuevoEvento.Click += new System.EventHandler(this.btnNuevoEvento_Click);
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.Location = new System.Drawing.Point(137, 240);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(95, 38);
            this.btnModificarEvento.TabIndex = 2;
            this.btnModificarEvento.Text = "Modificar Evento";
            this.btnModificarEvento.UseVisualStyleBackColor = true;
            this.btnModificarEvento.Click += new System.EventHandler(this.btnModificarEvento_Click);
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Location = new System.Drawing.Point(244, 240);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(91, 38);
            this.btnEliminarEvento.TabIndex = 3;
            this.btnEliminarEvento.Text = "Eliminar Evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEvento_Click);
            // 
            // btnAdministrarUsuarios
            // 
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(7, 31);
            this.btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            this.btnAdministrarUsuarios.Size = new System.Drawing.Size(100, 38);
            this.btnAdministrarUsuarios.TabIndex = 5;
            this.btnAdministrarUsuarios.Text = "Administrar Usuarios";
            this.btnAdministrarUsuarios.UseVisualStyleBackColor = true;
            this.btnAdministrarUsuarios.Click += new System.EventHandler(this.btnAdministrarUsuarios_Click);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.White;
            this.lblEventos.Location = new System.Drawing.Point(27, 8);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(71, 20);
            this.lblEventos.TabIndex = 7;
            this.lblEventos.Text = "Eventos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Administrar \r\nClientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.administrarClientes_Click);
            // 
            // panelEventos
            // 
            this.panelEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEventos.Controls.Add(this.btnRefrescarE);
            this.panelEventos.Controls.Add(this.lblEventos);
            this.panelEventos.Controls.Add(this.btnNuevoEvento);
            this.panelEventos.Controls.Add(this.btnEliminarEvento);
            this.panelEventos.Controls.Add(this.btnModificarEvento);
            this.panelEventos.Controls.Add(this.gridEventos);
            this.panelEventos.Location = new System.Drawing.Point(11, 9);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(760, 285);
            this.panelEventos.TabIndex = 8;
            // 
            // btnRefrescarE
            // 
            this.btnRefrescarE.Location = new System.Drawing.Point(650, 240);
            this.btnRefrescarE.Name = "btnRefrescarE";
            this.btnRefrescarE.Size = new System.Drawing.Size(72, 25);
            this.btnRefrescarE.TabIndex = 8;
            this.btnRefrescarE.Text = "Refrescar";
            this.btnRefrescarE.UseVisualStyleBackColor = true;
            this.btnRefrescarE.Click += new System.EventHandler(this.btnRefrescarE_Click);
            // 
            // btnTipoEvento
            // 
            this.btnTipoEvento.Location = new System.Drawing.Point(8, 75);
            this.btnTipoEvento.Name = "btnTipoEvento";
            this.btnTipoEvento.Size = new System.Drawing.Size(99, 38);
            this.btnTipoEvento.TabIndex = 10;
            this.btnTipoEvento.Text = "Administrar TipoEvento";
            this.btnTipoEvento.UseVisualStyleBackColor = true;
            this.btnTipoEvento.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdministrarEquipamiento
            // 
            this.btnAdministrarEquipamiento.Location = new System.Drawing.Point(8, 163);
            this.btnAdministrarEquipamiento.Name = "btnAdministrarEquipamiento";
            this.btnAdministrarEquipamiento.Size = new System.Drawing.Size(100, 38);
            this.btnAdministrarEquipamiento.TabIndex = 6;
            this.btnAdministrarEquipamiento.Text = "Administrar Equipamiento";
            this.btnAdministrarEquipamiento.UseVisualStyleBackColor = true;
            this.btnAdministrarEquipamiento.Click += new System.EventHandler(this.btnAdministrarEquipamiento_Click);
            // 
            // gridEquipamiento
            // 
            this.gridEquipamiento.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridEquipamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEquipo,
            this.CostoAlquilerEquipo});
            this.gridEquipamiento.Location = new System.Drawing.Point(29, 31);
            this.gridEquipamiento.Name = "gridEquipamiento";
            this.gridEquipamiento.ReadOnly = true;
            this.gridEquipamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEquipamiento.Size = new System.Drawing.Size(305, 157);
            this.gridEquipamiento.TabIndex = 0;
            this.gridEquipamiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEquipamiento_CellContentClick);
            // 
            // NombreEquipo
            // 
            this.NombreEquipo.DataPropertyName = "Nombre";
            this.NombreEquipo.HeaderText = "Nombre";
            this.NombreEquipo.Name = "NombreEquipo";
            this.NombreEquipo.ReadOnly = true;
            this.NombreEquipo.Width = 150;
            // 
            // CostoAlquilerEquipo
            // 
            this.CostoAlquilerEquipo.DataPropertyName = "CostoAlquiler";
            this.CostoAlquilerEquipo.HeaderText = "Costo de Alquiler";
            this.CostoAlquilerEquipo.Name = "CostoAlquilerEquipo";
            this.CostoAlquilerEquipo.ReadOnly = true;
            this.CostoAlquilerEquipo.Width = 115;
            // 
            // lblEquipamiento
            // 
            this.lblEquipamiento.AutoSize = true;
            this.lblEquipamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipamiento.ForeColor = System.Drawing.Color.White;
            this.lblEquipamiento.Location = new System.Drawing.Point(26, 9);
            this.lblEquipamiento.Name = "lblEquipamiento";
            this.lblEquipamiento.Size = new System.Drawing.Size(184, 20);
            this.lblEquipamiento.TabIndex = 7;
            this.lblEquipamiento.Text = "Equipamiento Solicitado:";
            this.lblEquipamiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.Location = new System.Drawing.Point(29, 194);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(100, 38);
            this.btnAgregarEquipo.TabIndex = 8;
            this.btnAgregarEquipo.Text = "Agregar Equipamiento";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarEquipo_Click);
            // 
            // btnCargarEquipamiento
            // 
            this.btnCargarEquipamiento.Location = new System.Drawing.Point(262, 194);
            this.btnCargarEquipamiento.Name = "btnCargarEquipamiento";
            this.btnCargarEquipamiento.Size = new System.Drawing.Size(72, 25);
            this.btnCargarEquipamiento.TabIndex = 9;
            this.btnCargarEquipamiento.Text = "Refrescar";
            this.btnCargarEquipamiento.UseVisualStyleBackColor = true;
            this.btnCargarEquipamiento.Click += new System.EventHandler(this.btnCargarEquipamiento_Click);
            // 
            // panelEquipamiento
            // 
            this.panelEquipamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEquipamiento.Controls.Add(this.lblEquipamiento);
            this.panelEquipamiento.Controls.Add(this.btnCargarEquipamiento);
            this.panelEquipamiento.Controls.Add(this.btnAgregarEquipo);
            this.panelEquipamiento.Controls.Add(this.gridEquipamiento);
            this.panelEquipamiento.Location = new System.Drawing.Point(12, 300);
            this.panelEquipamiento.Name = "panelEquipamiento";
            this.panelEquipamiento.Size = new System.Drawing.Size(360, 249);
            this.panelEquipamiento.TabIndex = 9;
            // 
            // panelAdministracion
            // 
            this.panelAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAdministracion.Controls.Add(this.lblAdministracion);
            this.panelAdministracion.Controls.Add(this.button1);
            this.panelAdministracion.Controls.Add(this.btnExitMainMenu);
            this.panelAdministracion.Controls.Add(this.btnAdministrarEquipamiento);
            this.panelAdministracion.Controls.Add(this.btnTipoEvento);
            this.panelAdministracion.Controls.Add(this.btnAdministrarUsuarios);
            this.panelAdministracion.Location = new System.Drawing.Point(655, 300);
            this.panelAdministracion.Name = "panelAdministracion";
            this.panelAdministracion.Size = new System.Drawing.Size(116, 249);
            this.panelAdministracion.TabIndex = 11;
            // 
            // lblAdministracion
            // 
            this.lblAdministracion.AutoSize = true;
            this.lblAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministracion.ForeColor = System.Drawing.Color.White;
            this.lblAdministracion.Location = new System.Drawing.Point(29, 8);
            this.lblAdministracion.Name = "lblAdministracion";
            this.lblAdministracion.Size = new System.Drawing.Size(49, 20);
            this.lblAdministracion.TabIndex = 11;
            this.lblAdministracion.Text = "Menu";
            // 
            // chartEventos
            // 
            this.chartEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "Eventos";
            chartArea1.ShadowColor = System.Drawing.Color.DimGray;
            this.chartEventos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEventos.Legends.Add(legend1);
            this.chartEventos.Location = new System.Drawing.Point(380, 300);
            this.chartEventos.Name = "chartEventos";
            series1.ChartArea = "Eventos";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Eventos";
            series1.XValueMember = "TipoEvento";
            series1.YValueMembers = "Cantidad";
            this.chartEventos.Series.Add(series1);
            this.chartEventos.Size = new System.Drawing.Size(269, 249);
            this.chartEventos.TabIndex = 12;
            this.chartEventos.Text = "Eventos Anuales";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "TipoEventoAnuales";
            title1.Text = "Tipos de Evento Anuales";
            this.chartEventos.Titles.Add(title1);
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento.ForeColor = System.Drawing.Color.White;
            this.lblTipoEvento.Location = new System.Drawing.Point(519, 331);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(62, 13);
            this.lblTipoEvento.TabIndex = 10;
            this.lblTipoEvento.Text = "TipoEvento";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(532, 516);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(106, 23);
            this.btnEstadisticas.TabIndex = 9;
            this.btnEstadisticas.Text = "Mas Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.chartEventos);
            this.Controls.Add(this.panelEquipamiento);
            this.Controls.Add(this.panelEventos);
            this.Controls.Add(this.panelAdministracion);
            this.Name = "FrmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShceDulJ - Menu Principal ";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).EndInit();
            this.panelEventos.ResumeLayout(false);
            this.panelEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipamiento)).EndInit();
            this.panelEquipamiento.ResumeLayout(false);
            this.panelEquipamiento.PerformLayout();
            this.panelAdministracion.ResumeLayout(false);
            this.panelAdministracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitMainMenu;
        private System.Windows.Forms.DataGridView gridEventos;
        private System.Windows.Forms.Button btnNuevoEvento;
        private System.Windows.Forms.Button btnModificarEvento;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.Button btnAdministrarUsuarios;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelEventos;
        private System.Windows.Forms.Button btnTipoEvento;
        private System.Windows.Forms.Button btnRefrescarE;
        private System.Windows.Forms.Button btnAdministrarEquipamiento;
        private System.Windows.Forms.DataGridView gridEquipamiento;
        private System.Windows.Forms.Label lblEquipamiento;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button btnCargarEquipamiento;
        private System.Windows.Forms.Panel panelEquipamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTipoEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoAlquilerEquipo;
        private System.Windows.Forms.Panel panelAdministracion;
        private System.Windows.Forms.Label lblAdministracion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEventos;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}