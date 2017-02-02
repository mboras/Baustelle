namespace Baustelle
{
    partial class frmNovaUsluga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaUsluga));
            this.stavkaUslugeSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.uslugaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaspolenikSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaUslugeSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.StavkaUslugeSetTableAdapter();
            this.zaspolenikSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter();
            this.uslugaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter();
            this.lblNovaUsluga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaUslugeSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stavkaUslugeSetBindingSource
            // 
            this.stavkaUslugeSetBindingSource.DataMember = "StavkaUslugeSet";
            this.stavkaUslugeSetBindingSource.DataSource = this.baustelleDBDataSet2BindingSource;
            // 
            // baustelleDBDataSet2BindingSource
            // 
            this.baustelleDBDataSet2BindingSource.DataSource = this.baustelleDBDataSet2;
            this.baustelleDBDataSet2BindingSource.Position = 0;
            // 
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictLogo
            // 
            this.pictLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(65, 287);
            this.pictLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(225, 63);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 17;
            this.pictLogo.TabStop = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(65, 221);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 44);
            this.btnSpremi.TabIndex = 28;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(190, 221);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 29;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(52, 155);
            this.lblZaposlenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(76, 17);
            this.lblZaposlenik.TabIndex = 21;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(85, 63);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 17);
            this.lblNaziv.TabIndex = 22;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblCijena
            // 
            this.lblCijena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(50, 106);
            this.lblCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(78, 17);
            this.lblCijena.TabIndex = 23;
            this.lblCijena.Text = "Cijena rada:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNaziv.Location = new System.Drawing.Point(133, 60);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(157, 22);
            this.txtNaziv.TabIndex = 25;
            // 
            // txtCijena
            // 
            this.txtCijena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCijena.Location = new System.Drawing.Point(133, 103);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(157, 22);
            this.txtCijena.TabIndex = 26;
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbZaposlenik.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uslugaSetBindingSource, "ZaposlenikId", true));
            this.cmbZaposlenik.DataSource = this.zaspolenikSetBindingSource;
            this.cmbZaposlenik.DisplayMember = "Prezime";
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(133, 152);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(157, 25);
            this.cmbZaposlenik.TabIndex = 27;
            this.cmbZaposlenik.ValueMember = "IdZaposlenik";
            // 
            // uslugaSetBindingSource
            // 
            this.uslugaSetBindingSource.DataMember = "UslugaSet";
            this.uslugaSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // zaspolenikSetBindingSource
            // 
            this.zaspolenikSetBindingSource.DataMember = "ZaspolenikSet";
            this.zaspolenikSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // stavkaUslugeSetTableAdapter
            // 
            this.stavkaUslugeSetTableAdapter.ClearBeforeFill = true;
            // 
            // zaspolenikSetTableAdapter
            // 
            this.zaspolenikSetTableAdapter.ClearBeforeFill = true;
            // 
            // uslugaSetTableAdapter
            // 
            this.uslugaSetTableAdapter.ClearBeforeFill = true;
            // 
            // lblNovaUsluga
            // 
            this.lblNovaUsluga.AutoSize = true;
            this.lblNovaUsluga.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNovaUsluga.ForeColor = System.Drawing.Color.Navy;
            this.lblNovaUsluga.Location = new System.Drawing.Point(12, 9);
            this.lblNovaUsluga.Name = "lblNovaUsluga";
            this.lblNovaUsluga.Size = new System.Drawing.Size(134, 19);
            this.lblNovaUsluga.TabIndex = 28;
            this.lblNovaUsluga.Text = "Dodajte novu uslugu.";
            // 
            // frmNovaUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 363);
            this.Controls.Add(this.lblNovaUsluga);
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
            this.Name = "frmNovaUsluga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Usluga";
            this.Load += new System.EventHandler(this.frmNovaUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stavkaUslugeSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.BindingSource baustelleDBDataSet2BindingSource;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource stavkaUslugeSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.StavkaUslugeSetTableAdapter stavkaUslugeSetTableAdapter;
        private System.Windows.Forms.BindingSource zaspolenikSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter zaspolenikSetTableAdapter;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter uslugaSetTableAdapter;
        private System.Windows.Forms.Label lblNovaUsluga;
    }
}