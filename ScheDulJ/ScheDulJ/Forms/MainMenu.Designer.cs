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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.lblEventos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdministrarEquipamiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitMainMenu
            // 
            this.btnExitMainMenu.Location = new System.Drawing.Point(668, 511);
            this.btnExitMainMenu.Name = "btnExitMainMenu";
            this.btnExitMainMenu.Size = new System.Drawing.Size(104, 38);
            this.btnExitMainMenu.TabIndex = 6;
            this.btnExitMainMenu.Text = "Salir";
            this.btnExitMainMenu.UseVisualStyleBackColor = true;
            this.btnExitMainMenu.Click += new System.EventHandler(this.btnExitMainMenu_Click);
            // 
            // gridEventos
            // 
            this.gridEventos.BackgroundColor = System.Drawing.Color.White;
            this.gridEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEventos.Location = new System.Drawing.Point(27, 40);
            this.gridEventos.Name = "gridEventos";
            this.gridEventos.Size = new System.Drawing.Size(370, 203);
            this.gridEventos.TabIndex = 0;
            // 
            // btnNuevoEvento
            // 
            this.btnNuevoEvento.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevoEvento.Location = new System.Drawing.Point(27, 249);
            this.btnNuevoEvento.Name = "btnNuevoEvento";
            this.btnNuevoEvento.Size = new System.Drawing.Size(110, 38);
            this.btnNuevoEvento.TabIndex = 1;
            this.btnNuevoEvento.Text = "Nuevo Evento";
            this.btnNuevoEvento.UseVisualStyleBackColor = false;
            // 
            // btnModificarEvento
            // 
            this.btnModificarEvento.Location = new System.Drawing.Point(155, 249);
            this.btnModificarEvento.Name = "btnModificarEvento";
            this.btnModificarEvento.Size = new System.Drawing.Size(110, 38);
            this.btnModificarEvento.TabIndex = 2;
            this.btnModificarEvento.Text = "Modificar Evento";
            this.btnModificarEvento.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.Location = new System.Drawing.Point(287, 249);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(110, 38);
            this.btnEliminarEvento.TabIndex = 3;
            this.btnEliminarEvento.Text = "Eliminar Evento";
            this.btnEliminarEvento.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 285);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            this.lblEventos.BackColor = System.Drawing.Color.LightGray;
            this.lblEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.Black;
            this.lblEventos.Location = new System.Drawing.Point(40, 19);
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
            this.btnAdministrarEquipamiento.Location = new System.Drawing.Point(672, 443);
            this.btnAdministrarEquipamiento.Name = "btnAdministrarEquipamiento";
            this.btnAdministrarEquipamiento.Size = new System.Drawing.Size(100, 38);
            this.btnAdministrarEquipamiento.TabIndex = 8;
            this.btnAdministrarEquipamiento.Text = "Administrar Equipamiento";
            this.btnAdministrarEquipamiento.UseVisualStyleBackColor = true;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAdministrarEquipamiento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEventos);
            this.Controls.Add(this.btnAdministrarUsuarios);
            this.Controls.Add(this.btnNuevoEvento);
            this.Controls.Add(this.btnEliminarEvento);
            this.Controls.Add(this.btnModificarEvento);
            this.Controls.Add(this.gridEventos);
            this.Controls.Add(this.btnExitMainMenu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SheDulJ - Menu Principal ";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitMainMenu;
        private System.Windows.Forms.DataGridView gridEventos;
        private System.Windows.Forms.Button btnNuevoEvento;
        private System.Windows.Forms.Button btnModificarEvento;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdministrarUsuarios;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdministrarEquipamiento;
    }
}