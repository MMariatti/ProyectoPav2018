namespace ScheDulJ.Forms.Eventos
{
    partial class frmModificarEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarEvento));
            this.lblId = new System.Windows.Forms.Label();
            this.lblNE = new System.Windows.Forms.Label();
            this.lblIdCargado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calendarioNuevaFecha = new System.Windows.Forms.MonthCalendar();
            this.txtHoraI = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraF = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarFecha = new System.Windows.Forms.Button();
            this.btnModifcarHI = new System.Windows.Forms.Button();
            this.btnModificarHF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(269, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 18);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblNE
            // 
            this.lblNE.AutoSize = true;
            this.lblNE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNE.Location = new System.Drawing.Point(16, 16);
            this.lblNE.Name = "lblNE";
            this.lblNE.Size = new System.Drawing.Size(66, 18);
            this.lblNE.TabIndex = 1;
            this.lblNE.Text = "Nombre:";
            // 
            // lblIdCargado
            // 
            this.lblIdCargado.AutoSize = true;
            this.lblIdCargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCargado.Location = new System.Drawing.Point(316, 16);
            this.lblIdCargado.Name = "lblIdCargado";
            this.lblIdCargado.Size = new System.Drawing.Size(19, 18);
            this.lblIdCargado.TabIndex = 3;
            this.lblIdCargado.Text = "id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(104, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nuevo Horario Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nuevo Horario Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nueva fecha:";
            // 
            // calendarioNuevaFecha
            // 
            this.calendarioNuevaFecha.Location = new System.Drawing.Point(123, 59);
            this.calendarioNuevaFecha.Name = "calendarioNuevaFecha";
            this.calendarioNuevaFecha.TabIndex = 8;
            // 
            // txtHoraI
            // 
            this.txtHoraI.Location = new System.Drawing.Point(187, 238);
            this.txtHoraI.Mask = "00:00";
            this.txtHoraI.Name = "txtHoraI";
            this.txtHoraI.Size = new System.Drawing.Size(37, 20);
            this.txtHoraI.TabIndex = 10;
            this.txtHoraI.ValidatingType = typeof(System.DateTime);
            // 
            // txtHoraF
            // 
            this.txtHoraF.Location = new System.Drawing.Point(187, 290);
            this.txtHoraF.Mask = "00:00";
            this.txtHoraF.Name = "txtHoraF";
            this.txtHoraF.Size = new System.Drawing.Size(37, 20);
            this.txtHoraF.TabIndex = 11;
            this.txtHoraF.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(358, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar ";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificarFecha
            // 
            this.btnModificarFecha.ForeColor = System.Drawing.Color.Black;
            this.btnModificarFecha.Location = new System.Drawing.Point(358, 59);
            this.btnModificarFecha.Name = "btnModificarFecha";
            this.btnModificarFecha.Size = new System.Drawing.Size(75, 34);
            this.btnModificarFecha.TabIndex = 13;
            this.btnModificarFecha.Text = "Modificar Fecha";
            this.btnModificarFecha.UseVisualStyleBackColor = true;
            this.btnModificarFecha.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnModifcarHI
            // 
            this.btnModifcarHI.ForeColor = System.Drawing.Color.Black;
            this.btnModifcarHI.Location = new System.Drawing.Point(358, 235);
            this.btnModifcarHI.Name = "btnModifcarHI";
            this.btnModifcarHI.Size = new System.Drawing.Size(75, 35);
            this.btnModifcarHI.TabIndex = 16;
            this.btnModifcarHI.Text = "Modificar Hora Inicio";
            this.btnModifcarHI.UseVisualStyleBackColor = true;
            this.btnModifcarHI.Click += new System.EventHandler(this.btnModifcarHI_Click);
            // 
            // btnModificarHF
            // 
            this.btnModificarHF.ForeColor = System.Drawing.Color.Black;
            this.btnModificarHF.Location = new System.Drawing.Point(358, 276);
            this.btnModificarHF.Name = "btnModificarHF";
            this.btnModificarHF.Size = new System.Drawing.Size(75, 34);
            this.btnModificarHF.TabIndex = 17;
            this.btnModificarHF.Text = "Modificar Hora Fin";
            this.btnModificarHF.UseVisualStyleBackColor = true;
            this.btnModificarHF.Click += new System.EventHandler(this.btnModificarHF_Click);
            // 
            // frmModificarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(454, 351);
            this.Controls.Add(this.btnModificarHF);
            this.Controls.Add(this.btnModifcarHI);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificarFecha);
            this.Controls.Add(this.txtHoraF);
            this.Controls.Add(this.txtHoraI);
            this.Controls.Add(this.calendarioNuevaFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdCargado);
            this.Controls.Add(this.lblNE);
            this.Controls.Add(this.lblId);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Evento ";
            this.Load += new System.EventHandler(this.frmModificarEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNE;
        internal System.Windows.Forms.Label lblIdCargado;
        internal System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendarioNuevaFecha;
        private System.Windows.Forms.MaskedTextBox txtHoraI;
        private System.Windows.Forms.MaskedTextBox txtHoraF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarFecha;
        private System.Windows.Forms.Button btnModifcarHI;
        private System.Windows.Forms.Button btnModificarHF;
    }
}