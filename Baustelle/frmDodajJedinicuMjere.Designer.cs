namespace Baustelle
{
    partial class frmDodajJedinicuMjere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodajJedinicuMjere));
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtSkraceniNaziv = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblSkraceniNaziv = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblDodajNovu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictLogo
            // 
            this.pictLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(40, 312);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(225, 63);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 38;
            this.pictLogo.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(174, 238);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 41);
            this.btnOdustani.TabIndex = 37;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(49, 238);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 41);
            this.btnSpremi.TabIndex = 36;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtSkraceniNaziv
            // 
            this.txtSkraceniNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSkraceniNaziv.Location = new System.Drawing.Point(132, 134);
            this.txtSkraceniNaziv.Name = "txtSkraceniNaziv";
            this.txtSkraceniNaziv.Size = new System.Drawing.Size(157, 22);
            this.txtSkraceniNaziv.TabIndex = 35;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNaziv.Location = new System.Drawing.Point(132, 101);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(157, 22);
            this.txtNaziv.TabIndex = 34;
            // 
            // lblSkraceniNaziv
            // 
            this.lblSkraceniNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSkraceniNaziv.AutoSize = true;
            this.lblSkraceniNaziv.Location = new System.Drawing.Point(31, 137);
            this.lblSkraceniNaziv.Name = "lblSkraceniNaziv";
            this.lblSkraceniNaziv.Size = new System.Drawing.Size(95, 17);
            this.lblSkraceniNaziv.TabIndex = 33;
            this.lblSkraceniNaziv.Text = "Skraćeni naziv:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(80, 101);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(46, 17);
            this.lblNaziv.TabIndex = 32;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // lblDodajNovu
            // 
            this.lblDodajNovu.AutoSize = true;
            this.lblDodajNovu.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDodajNovu.ForeColor = System.Drawing.Color.Navy;
            this.lblDodajNovu.Location = new System.Drawing.Point(12, 9);
            this.lblDodajNovu.Name = "lblDodajNovu";
            this.lblDodajNovu.Size = new System.Drawing.Size(174, 19);
            this.lblDodajNovu.TabIndex = 39;
            this.lblDodajNovu.Text = "Dodajte novu jedinicu mjere.";
            // 
            // frmDodajJedinicuMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 400);
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
            this.Name = "frmDodajJedinicuMjere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novu jedinicu mjere";
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtSkraceniNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblSkraceniNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblDodajNovu;

    }
}