namespace ScheDulJ.Forms.Usuarios
{
    partial class frmModificarContrasena
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
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.txtContraNueva = new System.Windows.Forms.TextBox();
            this.txtConfirmContra = new System.Windows.Forms.TextBox();
            this.lblContraAct = new System.Windows.Forms.Label();
            this.lblContraN = new System.Windows.Forms.Label();
            this.lblContraNC = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContraActual
            // 
            this.txtContraActual.Location = new System.Drawing.Point(161, 20);
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.Size = new System.Drawing.Size(156, 20);
            this.txtContraActual.TabIndex = 0;
            this.txtContraActual.UseSystemPasswordChar = true;
            // 
            // txtContraNueva
            // 
            this.txtContraNueva.Location = new System.Drawing.Point(161, 63);
            this.txtContraNueva.Name = "txtContraNueva";
            this.txtContraNueva.Size = new System.Drawing.Size(156, 20);
            this.txtContraNueva.TabIndex = 1;
            this.txtContraNueva.UseSystemPasswordChar = true;
            // 
            // txtConfirmContra
            // 
            this.txtConfirmContra.Location = new System.Drawing.Point(161, 106);
            this.txtConfirmContra.Name = "txtConfirmContra";
            this.txtConfirmContra.Size = new System.Drawing.Size(156, 20);
            this.txtConfirmContra.TabIndex = 2;
            this.txtConfirmContra.UseSystemPasswordChar = true;
            // 
            // lblContraAct
            // 
            this.lblContraAct.AutoSize = true;
            this.lblContraAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraAct.Location = new System.Drawing.Point(12, 20);
            this.lblContraAct.Name = "lblContraAct";
            this.lblContraAct.Size = new System.Drawing.Size(143, 18);
            this.lblContraAct.TabIndex = 3;
            this.lblContraAct.Text = "Contraseña Actual:* ";
            // 
            // lblContraN
            // 
            this.lblContraN.AutoSize = true;
            this.lblContraN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraN.Location = new System.Drawing.Point(12, 63);
            this.lblContraN.Name = "lblContraN";
            this.lblContraN.Size = new System.Drawing.Size(141, 18);
            this.lblContraN.TabIndex = 4;
            this.lblContraN.Text = "Contraseña Nueva:*";
            // 
            // lblContraNC
            // 
            this.lblContraNC.AutoSize = true;
            this.lblContraNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraNC.Location = new System.Drawing.Point(54, 90);
            this.lblContraNC.Name = "lblContraNC";
            this.lblContraNC.Size = new System.Drawing.Size(99, 36);
            this.lblContraNC.TabIndex = 5;
            this.lblContraNC.Text = "Confirmar \r\nContraseña:* ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmar.Location = new System.Drawing.Point(204, 134);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(113, 38);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Cambiar Contraseña";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(12, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmModificarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(329, 180);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblContraNC);
            this.Controls.Add(this.lblContraN);
            this.Controls.Add(this.lblContraAct);
            this.Controls.Add(this.txtConfirmContra);
            this.Controls.Add(this.txtContraNueva);
            this.Controls.Add(this.txtContraActual);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmModificarContrasena";
            this.Text = "frmModificarContrasena";
            this.Load += new System.EventHandler(this.frmModificarContrasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.TextBox txtContraNueva;
        private System.Windows.Forms.TextBox txtConfirmContra;
        private System.Windows.Forms.Label lblContraAct;
        private System.Windows.Forms.Label lblContraN;
        private System.Windows.Forms.Label lblContraNC;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}