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
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.lblNuevoTelefono = new System.Windows.Forms.Label();
            this.txtNuevoTelefono = new System.Windows.Forms.TextBox();
            this.btnModificarTelefono = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNuevoApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevaDireccion = new System.Windows.Forms.TextBox();
            this.BtnModificarDireccion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.BtnModificarApellido = new System.Windows.Forms.Button();
            this.BtnModificarNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCliente.Location = new System.Drawing.Point(13, 55);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 18);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Nombre";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(148, 55);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNuevoNombre.TabIndex = 0;
            this.txtNuevoNombre.Click += new System.EventHandler(this.txtNuevoNombre_Click);
            // 
            // lblNuevoTelefono
            // 
            this.lblNuevoTelefono.AutoSize = true;
            this.lblNuevoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNuevoTelefono.Location = new System.Drawing.Point(12, 126);
            this.lblNuevoTelefono.Name = "lblNuevoTelefono";
            this.lblNuevoTelefono.Size = new System.Drawing.Size(117, 18);
            this.lblNuevoTelefono.TabIndex = 3;
            this.lblNuevoTelefono.Text = "Nuevo Telefono ";
            // 
            // txtNuevoTelefono
            // 
            this.txtNuevoTelefono.Location = new System.Drawing.Point(148, 126);
            this.txtNuevoTelefono.Name = "txtNuevoTelefono";
            this.txtNuevoTelefono.Size = new System.Drawing.Size(125, 20);
            this.txtNuevoTelefono.TabIndex = 3;
            this.txtNuevoTelefono.Click += new System.EventHandler(this.txtNuevoTelefono_Click);
            // 
            // btnModificarTelefono
            // 
            this.btnModificarTelefono.Enabled = false;
            this.btnModificarTelefono.ForeColor = System.Drawing.Color.Black;
            this.btnModificarTelefono.Location = new System.Drawing.Point(279, 118);
            this.btnModificarTelefono.Name = "btnModificarTelefono";
            this.btnModificarTelefono.Size = new System.Drawing.Size(126, 28);
            this.btnModificarTelefono.TabIndex = 4;
            this.btnModificarTelefono.Text = "Modificar Telefono";
            this.btnModificarTelefono.UseVisualStyleBackColor = true;
            this.btnModificarTelefono.Click += new System.EventHandler(this.btnModificarTelefono_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(152, 225);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNuevoApellido
            // 
            this.txtNuevoApellido.Location = new System.Drawing.Point(148, 89);
            this.txtNuevoApellido.Name = "txtNuevoApellido";
            this.txtNuevoApellido.Size = new System.Drawing.Size(125, 20);
            this.txtNuevoApellido.TabIndex = 1;
            this.txtNuevoApellido.TextChanged += new System.EventHandler(this.txtNuevoApellido_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblApellido.Location = new System.Drawing.Point(12, 89);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 18);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(13, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nueva Direccion ";
            // 
            // txtNuevaDireccion
            // 
            this.txtNuevaDireccion.Location = new System.Drawing.Point(148, 162);
            this.txtNuevaDireccion.Name = "txtNuevaDireccion";
            this.txtNuevaDireccion.Size = new System.Drawing.Size(125, 20);
            this.txtNuevaDireccion.TabIndex = 5;
            this.txtNuevaDireccion.Click += new System.EventHandler(this.txtNuevaDireccion_Click);
            // 
            // BtnModificarDireccion
            // 
            this.BtnModificarDireccion.Enabled = false;
            this.BtnModificarDireccion.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarDireccion.Location = new System.Drawing.Point(279, 157);
            this.BtnModificarDireccion.Name = "BtnModificarDireccion";
            this.BtnModificarDireccion.Size = new System.Drawing.Size(126, 28);
            this.BtnModificarDireccion.TabIndex = 6;
            this.BtnModificarDireccion.Text = "Modificar Direccion";
            this.BtnModificarDireccion.UseVisualStyleBackColor = true;
            this.BtnModificarDireccion.Click += new System.EventHandler(this.BtnModificarDireccion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id Cliente*";
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Location = new System.Drawing.Point(148, 12);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.ReadOnly = true;
            this.txt_IdCliente.Size = new System.Drawing.Size(125, 20);
            this.txt_IdCliente.TabIndex = 9;
            // 
            // BtnModificarApellido
            // 
            this.BtnModificarApellido.Enabled = false;
            this.BtnModificarApellido.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarApellido.Location = new System.Drawing.Point(279, 84);
            this.BtnModificarApellido.Name = "BtnModificarApellido";
            this.BtnModificarApellido.Size = new System.Drawing.Size(126, 28);
            this.BtnModificarApellido.TabIndex = 10;
            this.BtnModificarApellido.Text = "Modificar Apellido";
            this.BtnModificarApellido.UseVisualStyleBackColor = true;
            this.BtnModificarApellido.Click += new System.EventHandler(this.BtnModificarApellido_Click);
            // 
            // BtnModificarNombre
            // 
            this.BtnModificarNombre.Enabled = false;
            this.BtnModificarNombre.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarNombre.Location = new System.Drawing.Point(279, 50);
            this.BtnModificarNombre.Name = "BtnModificarNombre";
            this.BtnModificarNombre.Size = new System.Drawing.Size(126, 28);
            this.BtnModificarNombre.TabIndex = 11;
            this.BtnModificarNombre.Text = "Modificar Nombre";
            this.BtnModificarNombre.UseVisualStyleBackColor = true;
            this.BtnModificarNombre.Click += new System.EventHandler(this.BtnModificarNombre_Click);
            // 
            // FrmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(421, 263);
            this.Controls.Add(this.BtnModificarNombre);
            this.Controls.Add(this.BtnModificarApellido);
            this.Controls.Add(this.txt_IdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnModificarDireccion);
            this.Controls.Add(this.txtNuevaDireccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNuevoApellido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarTelefono);
            this.Controls.Add(this.txtNuevoTelefono);
            this.Controls.Add(this.lblNuevoTelefono);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblCliente);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.FrmCambiarTelefono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNuevoTelefono;
        private System.Windows.Forms.Button btnModificarTelefono;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnModificarDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnModificarApellido;
        private System.Windows.Forms.Button BtnModificarNombre;
        public System.Windows.Forms.TextBox txtNuevoNombre;
        public System.Windows.Forms.TextBox txtNuevoTelefono;
        public System.Windows.Forms.TextBox txtNuevoApellido;
        public System.Windows.Forms.TextBox txtNuevaDireccion;
        public System.Windows.Forms.TextBox txt_IdCliente;
    }
}