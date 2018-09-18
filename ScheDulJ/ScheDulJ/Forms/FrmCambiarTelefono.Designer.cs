namespace ScheDulJ.Forms
{
    partial class FrmCambiarTelefono
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
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(22, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(255, 31);
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
            this.lblNuevoTelefono.Size = new System.Drawing.Size(123, 18);
            this.lblNuevoTelefono.TabIndex = 3;
            this.lblNuevoTelefono.Text = "Nuevo Telefono *";
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
            this.btnModificarTelefono.Location = new System.Drawing.Point(22, 181);
            this.btnModificarTelefono.Name = "btnModificarTelefono";
            this.btnModificarTelefono.Size = new System.Drawing.Size(100, 28);
            this.btnModificarTelefono.TabIndex = 4;
            this.btnModificarTelefono.Text = "Modificar";
            this.btnModificarTelefono.UseVisualStyleBackColor = true;
            this.btnModificarTelefono.Click += new System.EventHandler(this.btnModificarTelefono_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(177, 181);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 5;
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
            // FrmCambiarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtClienteApellido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificarTelefono);
            this.Controls.Add(this.txtNuevoTelefono);
            this.Controls.Add(this.lblNuevoTelefono);
            this.Controls.Add(this.txtClienteNombre);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmCambiarTelefono";
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
    }
}