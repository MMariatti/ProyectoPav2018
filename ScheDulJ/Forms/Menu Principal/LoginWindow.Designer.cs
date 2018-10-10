namespace ScheDulJ
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsuarioInsert = new System.Windows.Forms.TextBox();
            this.txtPasswordInsert = new System.Windows.Forms.TextBox();
            this.imgLoginBackBox = new System.Windows.Forms.PictureBox();
            this.btnExitLogin = new System.Windows.Forms.Button();
            this.imgUserImage = new System.Windows.Forms.PictureBox();
            this.imgPasswordImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginBackBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(340, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsuarioInsert
            // 
            this.txtUsuarioInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioInsert.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUsuarioInsert.Location = new System.Drawing.Point(315, 268);
            this.txtUsuarioInsert.Name = "txtUsuarioInsert";
            this.txtUsuarioInsert.Size = new System.Drawing.Size(178, 24);
            this.txtUsuarioInsert.TabIndex = 0;
            this.txtUsuarioInsert.Text = "Usuario";
            this.txtUsuarioInsert.Click += new System.EventHandler(this.txtUsuarioInsert_Clicked);
            // 
            // txtPasswordInsert
            // 
            this.txtPasswordInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordInsert.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPasswordInsert.Location = new System.Drawing.Point(315, 298);
            this.txtPasswordInsert.Name = "txtPasswordInsert";
            this.txtPasswordInsert.Size = new System.Drawing.Size(178, 24);
            this.txtPasswordInsert.TabIndex = 1;
            this.txtPasswordInsert.Text = "Contrasena ";
            this.txtPasswordInsert.Click += new System.EventHandler(this.txtPasswordInsert_Clicked);
            // 
            // imgLoginBackBox
            // 
            this.imgLoginBackBox.BackColor = System.Drawing.Color.Silver;
            this.imgLoginBackBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLoginBackBox.Location = new System.Drawing.Point(274, 254);
            this.imgLoginBackBox.Name = "imgLoginBackBox";
            this.imgLoginBackBox.Size = new System.Drawing.Size(237, 80);
            this.imgLoginBackBox.TabIndex = 5;
            this.imgLoginBackBox.TabStop = false;
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitLogin.Location = new System.Drawing.Point(668, 512);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(104, 38);
            this.btnExitLogin.TabIndex = 3;
            this.btnExitLogin.Text = "Salir";
            this.btnExitLogin.UseVisualStyleBackColor = true;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // imgUserImage
            // 
            this.imgUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgUserImage.Image = ((System.Drawing.Image)(resources.GetObject("imgUserImage.Image")));
            this.imgUserImage.Location = new System.Drawing.Point(284, 267);
            this.imgUserImage.Name = "imgUserImage";
            this.imgUserImage.Size = new System.Drawing.Size(25, 25);
            this.imgUserImage.TabIndex = 7;
            this.imgUserImage.TabStop = false;
            // 
            // imgPasswordImage
            // 
            this.imgPasswordImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPasswordImage.Image = ((System.Drawing.Image)(resources.GetObject("imgPasswordImage.Image")));
            this.imgPasswordImage.Location = new System.Drawing.Point(284, 298);
            this.imgPasswordImage.Name = "imgPasswordImage";
            this.imgPasswordImage.Size = new System.Drawing.Size(25, 25);
            this.imgPasswordImage.TabIndex = 8;
            this.imgPasswordImage.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.imgPasswordImage);
            this.Controls.Add(this.imgUserImage);
            this.Controls.Add(this.btnExitLogin);
            this.Controls.Add(this.txtPasswordInsert);
            this.Controls.Add(this.txtUsuarioInsert);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.imgLoginBackBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheDulJ-Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginBackBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPasswordImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsuarioInsert;
        private System.Windows.Forms.TextBox txtPasswordInsert;
        private System.Windows.Forms.PictureBox imgLoginBackBox;
        private System.Windows.Forms.Button btnExitLogin;
        private System.Windows.Forms.PictureBox imgUserImage;
        private System.Windows.Forms.PictureBox imgPasswordImage;
    }
}

