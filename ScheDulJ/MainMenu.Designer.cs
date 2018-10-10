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
            this.SuspendLayout();
            // 
            // btnExitMainMenu
            // 
            this.btnExitMainMenu.Location = new System.Drawing.Point(668, 511);
            this.btnExitMainMenu.Name = "btnExitMainMenu";
            this.btnExitMainMenu.Size = new System.Drawing.Size(104, 38);
            this.btnExitMainMenu.TabIndex = 0;
            this.btnExitMainMenu.Text = "Salir";
            this.btnExitMainMenu.UseVisualStyleBackColor = true;
            this.btnExitMainMenu.Click += new System.EventHandler(this.btnExitMainMenu_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnExitMainMenu);
            this.Name = "FrmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SheDulJ - Menu Principal ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitMainMenu;
    }
}