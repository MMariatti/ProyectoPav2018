namespace ScheDulJ.Forms
{
    partial class frmUserAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAdmin));
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Location = new System.Drawing.Point(12, 27);
            this.gridUsuarios.MultiSelect = false;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuarios.Size = new System.Drawing.Size(140, 128);
            this.gridUsuarios.TabIndex = 0;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(158, 27);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(100, 38);
            this.btnAgregarUsuario.TabIndex = 1;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(158, 71);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(100, 38);
            this.btnEliminarUsuario.TabIndex = 3;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(196, 158);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(62, 28);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 158);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 28);
            this.btnRefrescar.TabIndex = 4;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios.Location = new System.Drawing.Point(12, 6);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(68, 18);
            this.lblUsuarios.TabIndex = 6;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // frmUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(267, 194);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.gridUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.frmUserAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Label lblUsuarios;
    }
}