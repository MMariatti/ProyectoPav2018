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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btnExitMainMenu = new System.Windows.Forms.Button();
            this.gridEventos = new System.Windows.Forms.DataGridView();
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
            this.lblEquipamiento = new System.Windows.Forms.Label();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.btnCargarEquipamiento = new System.Windows.Forms.Button();
            this.panelEquipamiento = new System.Windows.Forms.Panel();
            this.columnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTipoEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoAlquilerEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAdministracion = new System.Windows.Forms.Panel();
            this.lblAdministracion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).BeginInit();
            this.panelEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipamiento)).BeginInit();
            this.panelEquipamiento.SuspendLayout();
            this.panelAdministracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitMainMenu
            // 
            this.btnExitMainMenu.Location = new System.Drawing.Point(668, 511);
            this.btnExitMainMenu.Name = "btnExitMainMenu";
            this.btnExitMainMenu.Size = new System.Drawing.Size(104, 38);
            this.btnExitMainMenu.TabIndex = 7;
            this.btnExitMainMenu.Text = "Salir";
            this.btnExitMainMenu.UseVisualStyleBackColor = true;
            this.btnExitMainMenu.Click += new System.EventHandler(this.btnExitMainMenu_Click);
            // 
            // gridEventos
            // 
            this.gridEventos.BackgroundColor = System.Drawing.Color.White;
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
            this.gridEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEventos.Size = new System.Drawing.Size(692, 203);
            this.gridEventos.TabIndex = 0;
            this.gridEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEventos_CellContentClick);
            this.gridEventos.SelectionChanged += new System.EventHandler(this.gridEventos_SelectionChanged);
            this.gridEventos.Click += new System.EventHandler(this.gridEventos_Click);
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
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(265, 32);
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
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.White;
            this.lblEventos.Location = new System.Drawing.Point(55, 8);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(71, 20);
            this.lblEventos.TabIndex = 7;
            this.lblEventos.Text = "Eventos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 32);
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
            this.btnRefrescarE.Location = new System.Drawing.Point(369, 240);
            this.btnRefrescarE.Name = "btnRefrescarE";
            this.btnRefrescarE.Size = new System.Drawing.Size(72, 38);
            this.btnRefrescarE.TabIndex = 8;
            this.btnRefrescarE.Text = "Refrescar";
            this.btnRefrescarE.UseVisualStyleBackColor = true;
            this.btnRefrescarE.Click += new System.EventHandler(this.btnRefrescarE_Click);
            // 
            // btnTipoEvento
            // 
            this.btnTipoEvento.Location = new System.Drawing.Point(148, 32);
            this.btnTipoEvento.Name = "btnTipoEvento";
            this.btnTipoEvento.Size = new System.Drawing.Size(99, 38);
            this.btnTipoEvento.TabIndex = 10;
            this.btnTipoEvento.Text = "Administrar TipoEvento";
            this.btnTipoEvento.UseVisualStyleBackColor = true;
            this.btnTipoEvento.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdministrarEquipamiento
            // 
            this.btnAdministrarEquipamiento.Location = new System.Drawing.Point(237, 195);
            this.btnAdministrarEquipamiento.Name = "btnAdministrarEquipamiento";
            this.btnAdministrarEquipamiento.Size = new System.Drawing.Size(100, 38);
            this.btnAdministrarEquipamiento.TabIndex = 6;
            this.btnAdministrarEquipamiento.Text = "Administrar Equipamiento";
            this.btnAdministrarEquipamiento.UseVisualStyleBackColor = true;
            this.btnAdministrarEquipamiento.Click += new System.EventHandler(this.btnAdministrarEquipamiento_Click);
            // 
            // gridEquipamiento
            // 
            this.gridEquipamiento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridEquipamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEquipo,
            this.CostoAlquilerEquipo});
            this.gridEquipamiento.Location = new System.Drawing.Point(29, 31);
            this.gridEquipamiento.Name = "gridEquipamiento";
            this.gridEquipamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEquipamiento.Size = new System.Drawing.Size(305, 157);
            this.gridEquipamiento.TabIndex = 0;
            this.gridEquipamiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEquipamiento_CellContentClick);
            // 
            // lblEquipamiento
            // 
            this.lblEquipamiento.AutoSize = true;
            this.lblEquipamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAgregarEquipo.Location = new System.Drawing.Point(131, 195);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(100, 38);
            this.btnAgregarEquipo.TabIndex = 8;
            this.btnAgregarEquipo.Text = "Agregar Equipamiento";
            this.btnAgregarEquipo.UseVisualStyleBackColor = true;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarEquipo_Click);
            // 
            // btnCargarEquipamiento
            // 
            this.btnCargarEquipamiento.Location = new System.Drawing.Point(32, 195);
            this.btnCargarEquipamiento.Name = "btnCargarEquipamiento";
            this.btnCargarEquipamiento.Size = new System.Drawing.Size(93, 38);
            this.btnCargarEquipamiento.TabIndex = 9;
            this.btnCargarEquipamiento.Text = "Cargar Equipamiento";
            this.btnCargarEquipamiento.UseVisualStyleBackColor = true;
            this.btnCargarEquipamiento.Click += new System.EventHandler(this.btnCargarEquipamiento_Click);
            // 
            // panelEquipamiento
            // 
            this.panelEquipamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelEquipamiento.Controls.Add(this.lblEquipamiento);
            this.panelEquipamiento.Controls.Add(this.btnCargarEquipamiento);
            this.panelEquipamiento.Controls.Add(this.btnAgregarEquipo);
            this.panelEquipamiento.Controls.Add(this.btnAdministrarEquipamiento);
            this.panelEquipamiento.Controls.Add(this.gridEquipamiento);
            this.panelEquipamiento.Location = new System.Drawing.Point(12, 300);
            this.panelEquipamiento.Name = "panelEquipamiento";
            this.panelEquipamiento.Size = new System.Drawing.Size(360, 249);
            this.panelEquipamiento.TabIndex = 9;
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
            this.Nombre.Width = 120;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // IDTipoEvento
            // 
            this.IDTipoEvento.DataPropertyName = "idTipoEvento";
            this.IDTipoEvento.HeaderText = "Tipo Evento";
            this.IDTipoEvento.Name = "IDTipoEvento";
            this.IDTipoEvento.Width = 60;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "horario";
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 60;
            // 
            // HoraFin
            // 
            this.HoraFin.DataPropertyName = "horarioFin";
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 60;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 140;
            // 
            // IDCliente
            // 
            this.IDCliente.DataPropertyName = "idCliente";
            this.IDCliente.HeaderText = "IDCliente";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.Width = 80;
            // 
            // NombreEquipo
            // 
            this.NombreEquipo.DataPropertyName = "Nombre";
            this.NombreEquipo.HeaderText = "Nombre";
            this.NombreEquipo.Name = "NombreEquipo";
            this.NombreEquipo.Width = 150;
            // 
            // CostoAlquilerEquipo
            // 
            this.CostoAlquilerEquipo.DataPropertyName = "CostoAlquiler";
            this.CostoAlquilerEquipo.HeaderText = "Costo de Alquiler";
            this.CostoAlquilerEquipo.Name = "CostoAlquilerEquipo";
            this.CostoAlquilerEquipo.Width = 115;
            // 
            // panelAdministracion
            // 
            this.panelAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAdministracion.Controls.Add(this.lblAdministracion);
            this.panelAdministracion.Controls.Add(this.button1);
            this.panelAdministracion.Controls.Add(this.btnTipoEvento);
            this.panelAdministracion.Controls.Add(this.btnAdministrarUsuarios);
            this.panelAdministracion.Location = new System.Drawing.Point(380, 300);
            this.panelAdministracion.Name = "panelAdministracion";
            this.panelAdministracion.Size = new System.Drawing.Size(391, 87);
            this.panelAdministracion.TabIndex = 11;
            // 
            // lblAdministracion
            // 
            this.lblAdministracion.AutoSize = true;
            this.lblAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministracion.ForeColor = System.Drawing.Color.White;
            this.lblAdministracion.Location = new System.Drawing.Point(112, 9);
            this.lblAdministracion.Name = "lblAdministracion";
            this.lblAdministracion.Size = new System.Drawing.Size(157, 20);
            this.lblAdministracion.TabIndex = 11;
            this.lblAdministracion.Text = "Menu Administracion";
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelEquipamiento);
            this.Controls.Add(this.panelEventos);
            this.Controls.Add(this.btnExitMainMenu);
            this.Controls.Add(this.panelAdministracion);
            this.Name = "FrmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SheDulJ - Menu Principal ";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).EndInit();
            this.panelEventos.ResumeLayout(false);
            this.panelEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipamiento)).EndInit();
            this.panelEquipamiento.ResumeLayout(false);
            this.panelEquipamiento.PerformLayout();
            this.panelAdministracion.ResumeLayout(false);
            this.panelAdministracion.PerformLayout();
            this.ResumeLayout(false);

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
    }
}