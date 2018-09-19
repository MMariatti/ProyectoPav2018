namespace ScheDulJ.Forms
{
    partial class FrmModificarCliente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoTelefono = new System.Windows.Forms.Label();
            this.txtNuevoTelefono = new System.Windows.Forms.TextBox();
            this.btnModificarTelefono = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevaDireccion = new System.Windows.Forms.TextBox();
            this.BtnModificarDireccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(22, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(387, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCliente.Location = new System.Drawing.Point(19, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(59, 18);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente*";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(152, 21);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(125, 20);
            this.txtClienteNombre.TabIndex = 0;
            // 
            // lblNuevoTelefono
            // 
            this.lblNuevoTelefono.AutoSize = true;
            this.lblNuevoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNuevoTelefono.Location = new System.Drawing.Point(19, 136);
            this.lblNuevoTelefono.Name = "lblNuevoTelefono";
            this.lblNuevoTelefono.Size = new System.Drawing.Size(117, 18);
            this.lblNuevoTelefono.TabIndex = 3;
            this.lblNuevoTelefono.Text = "Nuevo Telefono ";
            // 
            // txtNuevoTelefono
            // 
            this.txtNuevoTelefono.Enabled = false;
            this.txtNuevoTelefono.Location = new System.Drawing.Point(152, 137);
            this.txtNuevoTelefono.Name = "txtNuevoTelefono";
            this.txtNuevoTelefono.Size = new System.Drawing.Size(125, 20);
            this.txtNuevoTelefono.TabIndex = 3;
            // 
            // btnModificarTelefono
            // 
            this.btnModificarTelefono.Enabled = false;
            this.btnModificarTelefono.Location = new System.Drawing.Point(283, 132);
            this.btnModificarTelefono.Name = "btnModificarTelefono";
            this.btnModificarTelefono.Size = new System.Drawing.Size(126, 28);
            this.btnModificarTelefono.TabIndex = 4;
            this.btnModificarTelefono.Text = "Modificar Telefono";
            this.btnModificarTelefono.UseVisualStyleBackColor = true;
            this.btnModificarTelefono.Click += new System.EventHandler(this.btnModificarTelefono_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(177, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Location = new System.Drawing.Point(152, 47);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(125, 20);
            this.txtClienteApellido.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblApellido.Location = new System.Drawing.Point(19, 46);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 18);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(19, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nueva Direccion ";
            // 
            // txtNuevaDireccion
            // 
            this.txtNuevaDireccion.Enabled = false;
            this.txtNuevaDireccion.Location = new System.Drawing.Point(152, 163);
            this.txtNuevaDireccion.Name = "txtNuevaDireccion";
            this.txtNuevaDireccion.Size = new System.Drawing.Size(125, 20);
            this.txtNuevaDireccion.TabIndex = 5;
            // 
            // BtnModificarDireccion
            // 
            this.BtnModificarDireccion.Enabled = false;
            this.BtnModificarDireccion.Location = new System.Drawing.Point(283, 165);
            this.BtnModificarDireccion.Name = "BtnModificarDireccion";
            this.BtnModificarDireccion.Size = new System.Drawing.Size(126, 28);
            this.BtnModificarDireccion.TabIndex = 6;
            this.BtnModificarDireccion.Text = "Modificar Direccion";
            this.BtnModificarDireccion.UseVisualStyleBackColor = true;
            this.BtnModificarDireccion.Click += new System.EventHandler(this.BtnModificarDireccion_Click);
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 244);
            this.Controls.Add(this.BtnModificarDireccion);
            this.Controls.Add(this.txtNuevaDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtClienteApellido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarTelefono);
            this.Controls.Add(this.txtNuevoTelefono);
            this.Controls.Add(this.lblNuevoTelefono);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar telefono";
            this.Load += new System.EventHandler(this.FrmCambiarTelefono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label lblNuevoTelefono;
        private System.Windows.Forms.TextBox txtNuevoTelefono;
        private System.Windows.Forms.Button btnModificarTelefono;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtClienteApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevaDireccion;
        private System.Windows.Forms.Button BtnModificarDireccion;
    }
}