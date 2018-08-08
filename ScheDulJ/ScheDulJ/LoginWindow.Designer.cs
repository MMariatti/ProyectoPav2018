namespace ScheDulJ
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsuarioInsert = new System.Windows.Forms.TextBox();
            this.txtPasswordInsert = new System.Windows.Forms.TextBox();
            this.imgLoginBackBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginBackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(340, 378);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 37);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Silver;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(243, 249);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 29);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Silver;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(243, 302);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(136, 29);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtUsuarioInsert
            // 
            this.txtUsuarioInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioInsert.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtUsuarioInsert.Location = new System.Drawing.Point(385, 254);
            this.txtUsuarioInsert.Name = "txtUsuarioInsert";
            this.txtUsuarioInsert.Size = new System.Drawing.Size(178, 24);
            this.txtUsuarioInsert.TabIndex = 3;
            this.txtUsuarioInsert.Text = "Nombre de Usuario";
            this.txtUsuarioInsert.Click += new System.EventHandler(this.txtUsuarioInsert_Clicked);
            this.txtUsuarioInsert.TextChanged += new System.EventHandler(this.txtUsuarioInsert_TextChanged);
            // 
            // txtPasswordInsert
            // 
            this.txtPasswordInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordInsert.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPasswordInsert.Location = new System.Drawing.Point(385, 302);
            this.txtPasswordInsert.Name = "txtPasswordInsert";
            this.txtPasswordInsert.Size = new System.Drawing.Size(178, 24);
            this.txtPasswordInsert.TabIndex = 4;
            this.txtPasswordInsert.Text = "Contrasena ";
            this.txtPasswordInsert.Click += new System.EventHandler(this.txtPasswordInsert_Clicked);
            this.txtPasswordInsert.TextChanged += new System.EventHandler(this.txtPasswordInsert_TextChanged);
            // 
            // imgLoginBackBox
            // 
            this.imgLoginBackBox.BackColor = System.Drawing.Color.Silver;
            this.imgLoginBackBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLoginBackBox.Location = new System.Drawing.Point(219, 236);
            this.imgLoginBackBox.Name = "imgLoginBackBox";
            this.imgLoginBackBox.Size = new System.Drawing.Size(367, 107);
            this.imgLoginBackBox.TabIndex = 5;
            this.imgLoginBackBox.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtPasswordInsert);
            this.Controls.Add(this.txtUsuarioInsert);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.imgLoginBackBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "ScheDulJ-Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoginBackBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsuarioInsert;
        private System.Windows.Forms.TextBox txtPasswordInsert;
        private System.Windows.Forms.PictureBox imgLoginBackBox;
    }
}

