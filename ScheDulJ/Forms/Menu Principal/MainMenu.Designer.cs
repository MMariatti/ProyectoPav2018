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
            this.btnAdministrarEquipamiento = new System.Windows.Forms.Button();
            this.panelEventos = new System.Windows.Forms.Panel();
            this.panelEquipamiento = new System.Windows.Forms.Panel();
            this.gridEquipamiento = new System.Windows.Forms.DataGridView();
            this.lblEquipamiento = new System.Windows.Forms.Label();
            this.btnTipoEvento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).BeginInit();
            this.panelEventos.SuspendLayout();
            this.panelEquipamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipamiento)).BeginInit();
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
            this.gridEventos.Location = new System.Drawing.Point(16, 31);
            this.gridEventos.Name = "gridEventos";
            this.gridEventos.Size = new System.Drawing.Size(370, 203);
            this.gridEventos.TabIndex = 0;
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoEvento.Location = new System.Drawing.Point(16, 240);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(110, 38);
            this.btnNuevoEvento.TabIndex = 1;
            this.btnNuevoEvento.Text = "Nuevo Evento";
            this.btnNuevoEvento.UseVisualStyleBackColor = false;
            this.btnNuevoEvento.Click += new System.EventHandler(this.btnNuevoEvento_Click);
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.Location = new System.Drawing.Point(144, 240);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(110, 38);
            this.btnModificarEvento.TabIndex = 2;
            this.btnModificarEvento.Text = "Modificar Evento";
            this.btnModificarEvento.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Location = new System.Drawing.Point(276, 240);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(110, 38);
            this.btnEliminarEvento.TabIndex = 3;
            this.btnEliminarEvento.Text = "Eliminar Evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarUsuarios
            // 
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(672, 399);
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
            this.lblEventos.BackColor = System.Drawing.SystemColors.Control;
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.Black;
            this.lblEventos.Location = new System.Drawing.Point(29, 10);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(66, 18);
            this.lblEventos.TabIndex = 7;
            this.lblEventos.Text = "Eventos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Administrar \r\nClientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.administrarClientes_Click);
            // 
            // btnAdministrarEquipamiento
            // 
            this.btnAdministrarEquipamiento.Location = new System.Drawing.Point(192, 239);
            this.btnAdministrarEquipamiento.Name = "btnAdministrarEquipamiento";
            this.btnAdministrarEquipamiento.Size = new System.Drawing.Size(100, 38);
            this.btnAdministrarEquipamiento.TabIndex = 6;
            this.btnAdministrarEquipamiento.Text = "Administrar Equipamiento";
            this.btnAdministrarEquipamiento.UseVisualStyleBackColor = true;
            this.btnAdministrarEquipamiento.Click += new System.EventHandler(this.btnAdministrarEquipamiento_Click);
            // 
            // panelEventos
            // 
            this.panelEventos.Controls.Add(this.lblEventos);
            this.panelEventos.Controls.Add(this.btnNuevoEvento);
            this.panelEventos.Controls.Add(this.btnEliminarEvento);
            this.panelEventos.Controls.Add(this.btnModificarEvento);
            this.panelEventos.Controls.Add(this.gridEventos);
            this.panelEventos.Location = new System.Drawing.Point(11, 9);
            this.panelEventos.Name = "panelEventos";
            this.panelEventos.Size = new System.Drawing.Size(408, 298);
            this.panelEventos.TabIndex = 8;
            // 
            // panelEquipamiento
            // 
            this.panelEquipamiento.Controls.Add(this.lblEquipamiento);
            this.panelEquipamiento.Controls.Add(this.gridEquipamiento);
            this.panelEquipamiento.Controls.Add(this.btnAdministrarEquipamiento);
            this.panelEquipamiento.Location = new System.Drawing.Point(455, 10);
            this.panelEquipamiento.Name = "panelEquipamiento";
            this.panelEquipamiento.Size = new System.Drawing.Size(316, 296);
            this.panelEquipamiento.TabIndex = 9;
            // 
            // gridEquipamiento
            // 
            this.gridEquipamiento.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridEquipamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipamiento.Location = new System.Drawing.Point(19, 30);
            this.gridEquipamiento.Name = "gridEquipamiento";
            this.gridEquipamiento.Size = new System.Drawing.Size(273, 202);
            this.gridEquipamiento.TabIndex = 0;
            // 
            // lblEquipamiento
            // 
            this.lblEquipamiento.AutoSize = true;
            this.lblEquipamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipamiento.Location = new System.Drawing.Point(26, 9);
            this.lblEquipamiento.Name = "lblEquipamiento";
            this.lblEquipamiento.Size = new System.Drawing.Size(171, 18);
            this.lblEquipamiento.TabIndex = 7;
            this.lblEquipamiento.Text = "Equipamiento Solicitado:";
            this.lblEquipamiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTipoEvento
            // 
            this.btnTipoEvento.Location = new System.Drawing.Point(672, 443);
            this.btnTipoEvento.Name = "btnTipoEvento";
            this.btnTipoEvento.Size = new System.Drawing.Size(99, 45);
            this.btnTipoEvento.TabIndex = 10;
            this.btnTipoEvento.Text = "Administrar TipoEvento";
            this.btnTipoEvento.UseVisualStyleBackColor = true;
            this.btnTipoEvento.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnTipoEvento);
            this.Controls.Add(this.panelEquipamiento);
            this.Controls.Add(this.panelEventos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdministrarUsuarios);
            this.Controls.Add(this.btnExitMainMenu);
            this.Name = "FrmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SheDulJ - Menu Principal ";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).EndInit();
            this.panelEventos.ResumeLayout(false);
            this.panelEventos.PerformLayout();
            this.panelEquipamiento.ResumeLayout(false);
            this.panelEquipamiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipamiento)).EndInit();
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
        private System.Windows.Forms.Button btnAdministrarEquipamiento;
        private System.Windows.Forms.Panel panelEventos;
        private System.Windows.Forms.Panel panelEquipamiento;
        private System.Windows.Forms.Label lblEquipamiento;
        private System.Windows.Forms.DataGridView gridEquipamiento;
        private System.Windows.Forms.Button btnTipoEvento;
    }
}