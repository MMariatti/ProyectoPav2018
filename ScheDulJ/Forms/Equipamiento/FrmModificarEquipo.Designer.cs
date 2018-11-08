namespace ScheDulJ.Forms
{
    partial class FrmModificarEquipo
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
            this.lblModificarEquipo = new System.Windows.Forms.Label();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnModificarDescripcion = new System.Windows.Forms.Button();
            this.BtnCostoAlquiler = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.txtDescripcionEquipo = new System.Windows.Forms.TextBox();
            this.txtCostoAlquiler = new System.Windows.Forms.TextBox();
            this.cmbItemsModificar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblModificarEquipo
            // 
            this.lblModificarEquipo.AutoSize = true;
            this.lblModificarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblModificarEquipo.Location = new System.Drawing.Point(150, 23);
            this.lblModificarEquipo.Name = "lblModificarEquipo";
            this.lblModificarEquipo.Size = new System.Drawing.Size(119, 18);
            this.lblModificarEquipo.TabIndex = 10;
            this.lblModificarEquipo.Text = "Modificar Equipo";
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNombreEquipo.Location = new System.Drawing.Point(29, 66);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(60, 18);
            this.lblNombreEquipo.TabIndex = 9;
            this.lblNombreEquipo.Text = "Equipo*";
            this.lblNombreEquipo.Click += new System.EventHandler(this.lblNombreEquipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(29, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo de Alquiler";
            // 
            // BtnModificarDescripcion
            // 
            this.BtnModificarDescripcion.Enabled = false;
            this.BtnModificarDescripcion.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarDescripcion.Location = new System.Drawing.Point(304, 96);
            this.BtnModificarDescripcion.Name = "BtnModificarDescripcion";
            this.BtnModificarDescripcion.Size = new System.Drawing.Size(87, 43);
            this.BtnModificarDescripcion.TabIndex = 3;
            this.BtnModificarDescripcion.Text = "Modificar Descripcion";
            this.BtnModificarDescripcion.UseVisualStyleBackColor = true;
            this.BtnModificarDescripcion.Click += new System.EventHandler(this.BtnModificarDescripcion_Click);
            // 
            // BtnCostoAlquiler
            // 
            this.BtnCostoAlquiler.Enabled = false;
            this.BtnCostoAlquiler.ForeColor = System.Drawing.Color.Black;
            this.BtnCostoAlquiler.Location = new System.Drawing.Point(304, 160);
            this.BtnCostoAlquiler.Name = "BtnCostoAlquiler";
            this.BtnCostoAlquiler.Size = new System.Drawing.Size(87, 43);
            this.BtnCostoAlquiler.TabIndex = 5;
            this.BtnCostoAlquiler.Text = "Modificar costo de alquiler";
            this.BtnCostoAlquiler.UseVisualStyleBackColor = true;
            this.BtnCostoAlquiler.Click += new System.EventHandler(this.BtnCostoAlquiler_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Location = new System.Drawing.Point(166, 210);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 28);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtDescripcionEquipo
            // 
            this.txtDescripcionEquipo.Enabled = false;
            this.txtDescripcionEquipo.Location = new System.Drawing.Point(153, 105);
            this.txtDescripcionEquipo.Name = "txtDescripcionEquipo";
            this.txtDescripcionEquipo.Size = new System.Drawing.Size(116, 20);
            this.txtDescripcionEquipo.TabIndex = 2;
            this.txtDescripcionEquipo.TextChanged += new System.EventHandler(this.txtDescripcionEquipo_TextChanged);
            // 
            // txtCostoAlquiler
            // 
            this.txtCostoAlquiler.Enabled = false;
            this.txtCostoAlquiler.Location = new System.Drawing.Point(153, 172);
            this.txtCostoAlquiler.Name = "txtCostoAlquiler";
            this.txtCostoAlquiler.Size = new System.Drawing.Size(100, 20);
            this.txtCostoAlquiler.TabIndex = 4;
            // 
            // cmbItemsModificar
            // 
            this.cmbItemsModificar.FormattingEnabled = true;
            this.cmbItemsModificar.Location = new System.Drawing.Point(153, 63);
            this.cmbItemsModificar.Name = "cmbItemsModificar";
            this.cmbItemsModificar.Size = new System.Drawing.Size(210, 21);
            this.cmbItemsModificar.TabIndex = 11;
            this.cmbItemsModificar.SelectedIndexChanged += new System.EventHandler(this.cmbItemsModificar_SelectedIndexChanged);
            // 
            // FrmModificarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(403, 257);
            this.Controls.Add(this.lblNombreEquipo);
            this.Controls.Add(this.cmbItemsModificar);
            this.Controls.Add(this.txtCostoAlquiler);
            this.Controls.Add(this.txtDescripcionEquipo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnCostoAlquiler);
            this.Controls.Add(this.BtnModificarDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblModificarEquipo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmModificarEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar equipo";
            this.Load += new System.EventHandler(this.FrmModificarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblModificarEquipo;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnModificarDescripcion;
        private System.Windows.Forms.Button BtnCostoAlquiler;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox txtDescripcionEquipo;
        private System.Windows.Forms.TextBox txtCostoAlquiler;
        private System.Windows.Forms.ComboBox cmbItemsModificar;
    }
}