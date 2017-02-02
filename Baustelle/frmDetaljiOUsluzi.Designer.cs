namespace Baustelle
{
    partial class frmDetaljiOUsluzi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiOUsluzi));
            this.lblDatumkreiranja = new System.Windows.Forms.Label();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.uslugaSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.zaspolenikSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.uslugaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter();
            this.zaspolenikSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblDetaljIOuzsluz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatumkreiranja
            // 
            this.lblDatumkreiranja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatumkreiranja.AutoSize = true;
            this.lblDatumkreiranja.Location = new System.Drawing.Point(22, 183);
            this.lblDatumkreiranja.Name = "lblDatumkreiranja";
            this.lblDatumkreiranja.Size = new System.Drawing.Size(106, 17);
            this.lblDatumkreiranja.TabIndex = 39;
            this.lblDatumkreiranja.Text = "Datum kreiranja:";
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbZaposlenik.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uslugaSetBindingSource1, "ZaposlenikId", true));
            this.cmbZaposlenik.DataSource = this.zaspolenikSetBindingSource;
            this.cmbZaposlenik.DisplayMember = "Prezime";
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(133, 138);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(157, 25);
            this.cmbZaposlenik.TabIndex = 38;
            this.cmbZaposlenik.ValueMember = "IdZaposlenik";
            // 
            // uslugaSetBindingSource1
            // 
            this.uslugaSetBindingSource1.DataMember = "UslugaSet";
            this.uslugaSetBindingSource1.DataSource = this.baustelleDBDataSet2;
            // 
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaspolenikSetBindingSource
            // 
            this.zaspolenikSetBindingSource.DataMember = "ZaspolenikSet";
            this.zaspolenikSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // txtCijena
            // 
            this.txtCijena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCijena.Location = new System.Drawing.Point(133, 100);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(157, 22);
            this.txtCijena.TabIndex = 37;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Location = new System.Drawing.Point(133, 60);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(157, 22);
            this.txtNaziv.TabIndex = 36;
            // 
            // lblCijena
            // 
            this.lblCijena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(50, 103);
            this.lblCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(78, 17);
            this.lblCijena.TabIndex = 35;
            this.lblCijena.Text = "Cijena rada:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(85, 63);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 17);
            this.lblNaziv.TabIndex = 34;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(52, 141);
            this.lblZaposlenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(76, 17);
            this.lblZaposlenik.TabIndex = 33;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(66, 244);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 44);
            this.btnSpremi.TabIndex = 32;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(190, 244);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 31;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // pictLogo
            // 
            this.pictLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(66, 296);
            this.pictLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(225, 63);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 30;
            this.pictLogo.TabStop = false;
            // 
            // uslugaSetBindingSource
            // 
            this.uslugaSetBindingSource.DataMember = "UslugaSet";
            this.uslugaSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // uslugaSetTableAdapter
            // 
            this.uslugaSetTableAdapter.ClearBeforeFill = true;
            // 
            // zaspolenikSetTableAdapter
            // 
            this.zaspolenikSetTableAdapter.ClearBeforeFill = true;
            // 
            // txtDatum
            // 
            this.txtDatum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatum.Location = new System.Drawing.Point(134, 183);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(157, 22);
            this.txtDatum.TabIndex = 41;
            // 
            // lblDetaljIOuzsluz
            // 
            this.lblDetaljIOuzsluz.AutoSize = true;
            this.lblDetaljIOuzsluz.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetaljIOuzsluz.ForeColor = System.Drawing.Color.Navy;
            this.lblDetaljIOuzsluz.Location = new System.Drawing.Point(12, 9);
            this.lblDetaljIOuzsluz.Name = "lblDetaljIOuzsluz";
            this.lblDetaljIOuzsluz.Size = new System.Drawing.Size(99, 19);
            this.lblDetaljIOuzsluz.TabIndex = 42;
            this.lblDetaljIOuzsluz.Text = "Detalji o usluzi.";
            // 
            // frmDetaljiOUsluzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 363);
            this.Controls.Add(this.lblDetaljIOuzsluz);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblDatumkreiranja);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictLogo);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDetaljiOUsluzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.frmDetaljiOUsluzi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatumkreiranja;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.PictureBox pictLogo;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter uslugaSetTableAdapter;
        private System.Windows.Forms.BindingSource zaspolenikSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter zaspolenikSetTableAdapter;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource1;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblDetaljIOuzsluz;
    }
}