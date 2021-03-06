﻿namespace ScheDulJ.Forms
{
    partial class FrmAdministrarEquipamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrarEquipamiento));
            this.GridEquipamiento = new System.Windows.Forms.DataGridView();
            this.BtnAgregarEquipo = new System.Windows.Forms.Button();
            this.BtnModficarEquipo = new System.Windows.Forms.Button();
            this.BtnEliminarEquipo = new System.Windows.Forms.Button();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridEquipamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEquipamiento
            // 
            this.GridEquipamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEquipamiento.Location = new System.Drawing.Point(12, 12);
            this.GridEquipamiento.Name = "GridEquipamiento";
            this.GridEquipamiento.ReadOnly = true;
            this.GridEquipamiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEquipamiento.Size = new System.Drawing.Size(450, 195);
            this.GridEquipamiento.TabIndex = 0;
            // 
            // BtnAgregarEquipo
            // 
            this.BtnAgregarEquipo.Location = new System.Drawing.Point(468, 12);
            this.BtnAgregarEquipo.Name = "BtnAgregarEquipo";
            this.BtnAgregarEquipo.Size = new System.Drawing.Size(100, 28);
            this.BtnAgregarEquipo.TabIndex = 1;
            this.BtnAgregarEquipo.Text = "Agregar Equipo";
            this.BtnAgregarEquipo.UseVisualStyleBackColor = true;
            this.BtnAgregarEquipo.Click += new System.EventHandler(this.BtnAgregarEquipo_Click);
            // 
            // BtnModficarEquipo
            // 
            this.BtnModficarEquipo.Location = new System.Drawing.Point(468, 46);
            this.BtnModficarEquipo.Name = "BtnModficarEquipo";
            this.BtnModficarEquipo.Size = new System.Drawing.Size(100, 28);
            this.BtnModficarEquipo.TabIndex = 2;
            this.BtnModficarEquipo.Text = "Modificar Equipo";
            this.BtnModficarEquipo.UseVisualStyleBackColor = true;
            this.BtnModficarEquipo.Click += new System.EventHandler(this.BtnModficarEquipo_Click);
            // 
            // BtnEliminarEquipo
            // 
            this.BtnEliminarEquipo.Location = new System.Drawing.Point(468, 80);
            this.BtnEliminarEquipo.Name = "BtnEliminarEquipo";
            this.BtnEliminarEquipo.Size = new System.Drawing.Size(100, 28);
            this.BtnEliminarEquipo.TabIndex = 3;
            this.BtnEliminarEquipo.Text = "Eliminar Equipo";
            this.BtnEliminarEquipo.UseVisualStyleBackColor = true;
            this.BtnEliminarEquipo.Click += new System.EventHandler(this.BtnEliminarEquipo_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.Location = new System.Drawing.Point(12, 213);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(100, 28);
            this.BtnRefrescar.TabIndex = 4;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(468, 213);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 28);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmAdministrarEquipamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(577, 251);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnRefrescar);
            this.Controls.Add(this.BtnEliminarEquipo);
            this.Controls.Add(this.BtnModficarEquipo);
            this.Controls.Add(this.BtnAgregarEquipo);
            this.Controls.Add(this.GridEquipamiento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdministrarEquipamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrarEquipamiento";
            this.Load += new System.EventHandler(this.FrmAdministrarEquipamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEquipamiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEquipamiento;
        private System.Windows.Forms.Button BtnAgregarEquipo;
        private System.Windows.Forms.Button BtnModficarEquipo;
        private System.Windows.Forms.Button BtnEliminarEquipo;
        private System.Windows.Forms.Button BtnRefrescar;
        private System.Windows.Forms.Button BtnSalir;
    }
}