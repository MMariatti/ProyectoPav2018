namespace ScheDulJ.Forms
{
    partial class FrmAgregarEquipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.lblDespcripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostoAlquiler = new System.Windows.Forms.TextBox();
            this.txtDescripcionEquipo = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.lblNuevoEquipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre*";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(124, 54);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(164, 20);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // lblDespcripcion
            // 
            this.lblDespcripcion.AutoSize = true;
            this.lblDespcripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblDespcripcion.Location = new System.Drawing.Point(12, 89);
            this.lblDespcripcion.Name = "lblDespcripcion";
            this.lblDespcripcion.Size = new System.Drawing.Size(93, 18);
            this.lblDespcripcion.TabIndex = 7;
            this.lblDespcripcion.Text = "Descripcion*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Costo Alquiler*";
            // 
            // txtCostoAlquiler
            // 
            this.txtCostoAlquiler.Location = new System.Drawing.Point(124, 131);
            this.txtCostoAlquiler.Name = "txtCostoAlquiler";
            this.txtCostoAlquiler.Size = new System.Drawing.Size(164, 20);
            this.txtCostoAlquiler.TabIndex = 2;
            // 
            // txtDescripcionEquipo
            // 
            this.txtDescripcionEquipo.Location = new System.Drawing.Point(124, 90);
            this.txtDescripcionEquipo.Name = "txtDescripcionEquipo";
            this.txtDescripcionEquipo.Size = new System.Drawing.Size(164, 20);
            this.txtDescripcionEquipo.TabIndex = 1;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(217, 163);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 28);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(12, 163);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 28);
            this.BtnCrear.TabIndex = 3;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // lblNuevoEquipo
            // 
            this.lblNuevoEquipo.AutoSize = true;
            this.lblNuevoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNuevoEquipo.Location = new System.Drawing.Point(98, 9);
            this.lblNuevoEquipo.Name = "lblNuevoEquipo";
            this.lblNuevoEquipo.Size = new System.Drawing.Size(99, 18);
            this.lblNuevoEquipo.TabIndex = 5;
            this.lblNuevoEquipo.Text = "Nuevo equipo";
            this.lblNuevoEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmAgregarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 198);
            this.Controls.Add(this.lblNuevoEquipo);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.txtDescripcionEquipo);
            this.Controls.Add(this.txtCostoAlquiler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDespcripcion);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar equipo";
            this.Load += new System.EventHandler(this.FrmAgregarEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label lblDespcripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCostoAlquiler;
        private System.Windows.Forms.TextBox txtDescripcionEquipo;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Label lblNuevoEquipo;
    }
}