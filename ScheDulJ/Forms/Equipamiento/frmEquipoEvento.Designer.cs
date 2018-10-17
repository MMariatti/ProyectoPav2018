namespace ScheDulJ.Forms.Equipamiento
{
    partial class frmEquipoEvento
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
            this.gridSeleccionado = new System.Windows.Forms.DataGridView();
            this.lblEquipamiento = new System.Windows.Forms.Label();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtIdE = new System.Windows.Forms.TextBox();
            this.cmbEquipamientoEvento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridSeleccionado)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSeleccionado
            // 
            this.gridSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSeleccionado.Location = new System.Drawing.Point(24, 134);
            this.gridSeleccionado.Name = "gridSeleccionado";
            this.gridSeleccionado.Size = new System.Drawing.Size(324, 167);
            this.gridSeleccionado.TabIndex = 1;
            this.gridSeleccionado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSeleccionado_CellContentClick);
            // 
            // lblEquipamiento
            // 
            this.lblEquipamiento.AutoSize = true;
            this.lblEquipamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipamiento.Location = new System.Drawing.Point(21, 59);
            this.lblEquipamiento.Name = "lblEquipamiento";
            this.lblEquipamiento.Size = new System.Drawing.Size(108, 18);
            this.lblEquipamiento.TabIndex = 2;
            this.lblEquipamiento.Text = "Equipamiento:*";
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionado.Location = new System.Drawing.Point(21, 113);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(108, 18);
            this.lblSeleccionado.TabIndex = 3;
            this.lblSeleccionado.Text = "Seleccionado:*";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(270, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(270, 307);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(78, 28);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(24, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 26);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(256, 358);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(92, 26);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreE.Location = new System.Drawing.Point(21, 19);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(58, 18);
            this.lblNombreE.TabIndex = 8;
            this.lblNombreE.Text = "Evento:";
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(85, 20);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.ReadOnly = true;
            this.txtNombreEvento.Size = new System.Drawing.Size(187, 20);
            this.txtNombreEvento.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(278, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 18);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID:";
            // 
            // txtIdE
            // 
            this.txtIdE.Location = new System.Drawing.Point(310, 21);
            this.txtIdE.Name = "txtIdE";
            this.txtIdE.ReadOnly = true;
            this.txtIdE.Size = new System.Drawing.Size(38, 20);
            this.txtIdE.TabIndex = 11;
            // 
            // cmbEquipamientoEvento
            // 
            this.cmbEquipamientoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipamientoEvento.FormattingEnabled = true;
            this.cmbEquipamientoEvento.Location = new System.Drawing.Point(24, 80);
            this.cmbEquipamientoEvento.Name = "cmbEquipamientoEvento";
            this.cmbEquipamientoEvento.Size = new System.Drawing.Size(240, 21);
            this.cmbEquipamientoEvento.TabIndex = 12;
            // 
            // frmEquipoEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 393);
            this.Controls.Add(this.cmbEquipamientoEvento);
            this.Controls.Add(this.txtIdE);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtNombreEvento);
            this.Controls.Add(this.lblNombreE);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.lblEquipamiento);
            this.Controls.Add(this.gridSeleccionado);
            this.Name = "frmEquipoEvento";
            this.Text = "frmEquipoEvento";
            this.Load += new System.EventHandler(this.frmEquipoEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSeleccionado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridSeleccionado;
        private System.Windows.Forms.Label lblEquipamiento;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNombreE;
        public System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtIdE;
        private System.Windows.Forms.ComboBox cmbEquipamientoEvento;
    }
}