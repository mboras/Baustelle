namespace Baustelle
{
    partial class frmDetaljiZaposlenika
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiZaposlenika));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.lblUloga = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPasssword = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.zaspolenikSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.ulogaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.zaspolenikSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaspolenikSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter();
            this.ulogaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.UlogaSetTableAdapter();
            this.lblDetaljiOZaposleniku = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnObrisi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(288, 346);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(5);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 44);
            this.btnObrisi.TabIndex = 68;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(223, 436);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(225, 63);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 36;
            this.pctLogo.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(411, 346);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(5);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 69;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIzmjeni.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmjeni.Location = new System.Drawing.Point(164, 346);
            this.btnIzmjeni.Margin = new System.Windows.Forms.Padding(5);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(100, 44);
            this.btnIzmjeni.TabIndex = 67;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // lblUloga
            // 
            this.lblUloga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(86, 73);
            this.lblUloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(50, 17);
            this.lblUloga.TabIndex = 38;
            this.lblUloga.Text = "Uloga: ";
            // 
            // lblIme
            // 
            this.lblIme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(98, 119);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(33, 17);
            this.lblIme.TabIndex = 39;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(71, 166);
            this.lblPrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(60, 17);
            this.lblPrezime.TabIndex = 40;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblDatum
            // 
            this.lblDatum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(31, 212);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(100, 17);
            this.lblDatum.TabIndex = 41;
            this.lblDatum.Text = "Datum rođenja:";
            // 
            // lblOIB
            // 
            this.lblOIB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOIB.AutoSize = true;
            this.lblOIB.Location = new System.Drawing.Point(99, 258);
            this.lblOIB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(32, 17);
            this.lblOIB.TabIndex = 42;
            this.lblOIB.Text = "OIB:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(376, 76);
            this.lblAdresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(57, 17);
            this.lblAdresa.TabIndex = 43;
            this.lblAdresa.Text = "Adresa: ";
            // 
            // lblKontakt
            // 
            this.lblKontakt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(373, 117);
            this.lblKontakt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(60, 17);
            this.lblKontakt.TabIndex = 44;
            this.lblKontakt.Text = "Kontakt:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(390, 161);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(358, 210);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 17);
            this.lblUsername.TabIndex = 46;
            this.lblUsername.Text = "Username: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsername.Location = new System.Drawing.Point(441, 207);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 22);
            this.txtUsername.TabIndex = 65;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(441, 161);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 22);
            this.txtEmail.TabIndex = 64;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKontakt.Location = new System.Drawing.Point(441, 114);
            this.txtKontakt.Margin = new System.Windows.Forms.Padding(4);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(157, 22);
            this.txtKontakt.TabIndex = 63;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAdresa.Location = new System.Drawing.Point(441, 73);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(157, 22);
            this.txtAdresa.TabIndex = 62;
            // 
            // txtOIB
            // 
            this.txtOIB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOIB.Location = new System.Drawing.Point(139, 253);
            this.txtOIB.Margin = new System.Windows.Forms.Padding(4);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(157, 22);
            this.txtOIB.TabIndex = 61;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(365, 258);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 17);
            this.lblPassword.TabIndex = 52;
            this.lblPassword.Text = "Password:";
            // 
            // txtPasssword
            // 
            this.txtPasssword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPasssword.Location = new System.Drawing.Point(441, 255);
            this.txtPasssword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasssword.Name = "txtPasssword";
            this.txtPasssword.Size = new System.Drawing.Size(157, 22);
            this.txtPasssword.TabIndex = 66;
            // 
            // txtIme
            // 
            this.txtIme.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIme.Location = new System.Drawing.Point(139, 116);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(157, 22);
            this.txtIme.TabIndex = 58;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrezime.Location = new System.Drawing.Point(139, 163);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(157, 22);
            this.txtPrezime.TabIndex = 59;
            // 
            // cmbUloga
            // 
            this.cmbUloga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbUloga.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zaspolenikSetBindingSource1, "UlogaId", true));
            this.cmbUloga.DataSource = this.ulogaSetBindingSource;
            this.cmbUloga.DisplayMember = "Naziv";
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(139, 70);
            this.cmbUloga.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(157, 25);
            this.cmbUloga.TabIndex = 57;
            this.cmbUloga.ValueMember = "IdUloga";
            // 
            // zaspolenikSetBindingSource1
            // 
            this.zaspolenikSetBindingSource1.DataMember = "ZaspolenikSet";
            this.zaspolenikSetBindingSource1.DataSource = this.baustelleDBDataSet2;
            // 
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaSetBindingSource
            // 
            this.ulogaSetBindingSource.DataMember = "UlogaSet";
            this.ulogaSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDatum.Location = new System.Drawing.Point(139, 209);
            this.txtDatum.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(157, 22);
            this.txtDatum.TabIndex = 60;
            // 
            // zaspolenikSetBindingSource
            // 
            this.zaspolenikSetBindingSource.DataMember = "ZaspolenikSet";
            this.zaspolenikSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // zaspolenikSetTableAdapter
            // 
            this.zaspolenikSetTableAdapter.ClearBeforeFill = true;
            // 
            // ulogaSetTableAdapter
            // 
            this.ulogaSetTableAdapter.ClearBeforeFill = true;
            // 
            // lblDetaljiOZaposleniku
            // 
            this.lblDetaljiOZaposleniku.AutoSize = true;
            this.lblDetaljiOZaposleniku.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetaljiOZaposleniku.ForeColor = System.Drawing.Color.Navy;
            this.lblDetaljiOZaposleniku.Location = new System.Drawing.Point(12, 9);
            this.lblDetaljiOZaposleniku.Name = "lblDetaljiOZaposleniku";
            this.lblDetaljiOZaposleniku.Size = new System.Drawing.Size(135, 19);
            this.lblDetaljiOZaposleniku.TabIndex = 59;
            this.lblDetaljiOZaposleniku.Text = "Detalji o zaposleniku.";
            // 
            // frmDetaljiZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 512);
            this.Controls.Add(this.lblDetaljiOZaposleniku);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtPasssword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzmjeni);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDetaljiZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.frmDetaljiZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPasssword;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.TextBox txtDatum;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource zaspolenikSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter zaspolenikSetTableAdapter;
        private System.Windows.Forms.BindingSource ulogaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.UlogaSetTableAdapter ulogaSetTableAdapter;
        private System.Windows.Forms.BindingSource zaspolenikSetBindingSource1;
        private System.Windows.Forms.Label lblDetaljiOZaposleniku;
    }
}