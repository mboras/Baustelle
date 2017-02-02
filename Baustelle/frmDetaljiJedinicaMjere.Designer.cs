namespace Baustelle
{
    partial class frmDetaljiJedinicaMjere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiJedinicaMjere));
            this.lblDodajNovu = new System.Windows.Forms.Label();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtSkraceniNaziv = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblSkraceniNaziv = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDodajNovu
            // 
            this.lblDodajNovu.AutoSize = true;
            this.lblDodajNovu.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajNovu.ForeColor = System.Drawing.Color.Navy;
            this.lblDodajNovu.Location = new System.Drawing.Point(12, 9);
            this.lblDodajNovu.Name = "lblDodajNovu";
            this.lblDodajNovu.Size = new System.Drawing.Size(141, 19);
            this.lblDodajNovu.TabIndex = 47;
            this.lblDodajNovu.Text = "Detalji o jedinici mjere.";
            // 
            // pictLogo
            // 
            this.pictLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(69, 287);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(225, 63);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 46;
            this.pictLogo.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(250, 216);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 45;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(38, 216);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 44);
            this.btnSpremi.TabIndex = 44;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtSkraceniNaziv
            // 
            this.txtSkraceniNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSkraceniNaziv.Location = new System.Drawing.Point(157, 111);
            this.txtSkraceniNaziv.Name = "txtSkraceniNaziv";
            this.txtSkraceniNaziv.Size = new System.Drawing.Size(157, 22);
            this.txtSkraceniNaziv.TabIndex = 43;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNaziv.Location = new System.Drawing.Point(157, 83);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(157, 22);
            this.txtNaziv.TabIndex = 42;
            // 
            // lblSkraceniNaziv
            // 
            this.lblSkraceniNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSkraceniNaziv.AutoSize = true;
            this.lblSkraceniNaziv.Location = new System.Drawing.Point(56, 114);
            this.lblSkraceniNaziv.Name = "lblSkraceniNaziv";
            this.lblSkraceniNaziv.Size = new System.Drawing.Size(95, 17);
            this.lblSkraceniNaziv.TabIndex = 41;
            this.lblSkraceniNaziv.Text = "Skraćeni naziv:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(105, 83);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 17);
            this.lblNaziv.TabIndex = 40;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(144, 216);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 44);
            this.btnObrisi.TabIndex = 48;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmDetaljiJedinicaMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(396, 375);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lblDodajNovu);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtSkraceniNaziv);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblSkraceniNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDetaljiJedinicaMjere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.frmDetaljiJedinicaMjere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDodajNovu;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtSkraceniNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblSkraceniNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnObrisi;
    }
}