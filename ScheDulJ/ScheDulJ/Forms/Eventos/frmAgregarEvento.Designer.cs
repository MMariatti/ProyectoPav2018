namespace ScheDulJ.Forms.Eventos
{
    partial class frmAgregarEvento
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.calendarioEvento = new System.Windows.Forms.MonthCalendar();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtHoraI = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraF = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // calendarioEvento
            // 
            this.calendarioEvento.Location = new System.Drawing.Point(99, 44);
            this.calendarioEvento.Name = "calendarioEvento";
            this.calendarioEvento.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre Evento*:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 18);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha*:";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(2, 242);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(93, 18);
            this.lblHoraInicio.TabIndex = 5;
            this.lblHoraInicio.Text = "Hora Inicio*: ";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(18, 271);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(75, 18);
            this.lblHoraFin.TabIndex = 6;
            this.lblHoraFin.Text = "Hora Fin*:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(99, 299);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(212, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 298);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(81, 18);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Direccion*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cliente*:";
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(101, 338);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(121, 21);
            this.cmbClientes.TabIndex = 12;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(233, 338);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(107, 23);
            this.btnNuevoCliente.TabIndex = 13;
            this.btnNuevoCliente.TabStop = false;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(17, 383);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 28);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(240, 383);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtHoraI
            // 
            this.txtHoraI.Location = new System.Drawing.Point(109, 242);
            this.txtHoraI.Mask = "90:00";
            this.txtHoraI.Name = "txtHoraI";
            this.txtHoraI.Size = new System.Drawing.Size(38, 20);
            this.txtHoraI.TabIndex = 16;
            this.txtHoraI.ValidatingType = typeof(System.DateTime);
            this.txtHoraI.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtHoraI_MaskInputRejected);
            // 
            // txtHoraF
            // 
            this.txtHoraF.Location = new System.Drawing.Point(109, 269);
            this.txtHoraF.Mask = "90:00";
            this.txtHoraF.Name = "txtHoraF";
            this.txtHoraF.Size = new System.Drawing.Size(38, 20);
            this.txtHoraF.TabIndex = 17;
            this.txtHoraF.ValidatingType = typeof(System.DateTime);
            // 
            // cmbTipoEvento
            // 
            this.cmbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(109, 215);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoEvento.TabIndex = 18;
            // 
            // lblTipoEvento
            // 
            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEvento.Location = new System.Drawing.Point(2, 217);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(101, 18);
            this.lblTipoEvento.TabIndex = 19;
            this.lblTipoEvento.Text = "Tipo Evento*: ";
            // 
            // frmAgregarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 423);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.txtHoraF);
            this.Controls.Add(this.txtHoraI);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.calendarioEvento);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmAgregarEvento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Evento";
            this.Load += new System.EventHandler(this.frmAgregarEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MonthCalendar calendarioEvento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MaskedTextBox txtHoraI;
        private System.Windows.Forms.MaskedTextBox txtHoraF;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.Label lblTipoEvento;
    }
}