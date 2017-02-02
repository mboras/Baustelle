namespace Baustelle
{
    partial class frmPonude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPonude));
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbStavkaUsluge = new System.Windows.Forms.GroupBox();
            this.btnNovaStavkaPonude = new System.Windows.Forms.Button();
            this.btnIzmjeniStavkuPonude = new System.Windows.Forms.Button();
            this.btnIzbrisiStavkuPonude = new System.Windows.Forms.Button();
            this.dgvStavkePonude = new System.Windows.Forms.DataGridView();
            this.idStavkePonudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponudaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uslugaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaPonudeSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbUsluge = new System.Windows.Forms.GroupBox();
            this.btnNovaPonuda = new System.Windows.Forms.Button();
            this.btnIzmjeniPonudu = new System.Windows.Forms.Button();
            this.btnIzbrisiPonudu = new System.Windows.Forms.Button();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.idPonudaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.klijentSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaspolenikSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datumIzdavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponudaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ponudaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.PonudaSetTableAdapter();
            this.stavkaPonudeSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.StavkaPonudeSetTableAdapter();
            this.uslugaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter();
            this.btnIspisPonude = new System.Windows.Forms.Button();
            this.klijentSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.KlijentSetTableAdapter();
            this.zaspolenikSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbStavkaUsluge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePonude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPonudeSetBindingSource)).BeginInit();
            this.gbUsluge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponudaSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(641, 533);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 57);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 510);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // gbStavkaUsluge
            // 
            this.gbStavkaUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStavkaUsluge.Controls.Add(this.btnNovaStavkaPonude);
            this.gbStavkaUsluge.Controls.Add(this.btnIzmjeniStavkuPonude);
            this.gbStavkaUsluge.Controls.Add(this.btnIzbrisiStavkuPonude);
            this.gbStavkaUsluge.Controls.Add(this.dgvStavkePonude);
            this.gbStavkaUsluge.Location = new System.Drawing.Point(27, 266);
            this.gbStavkaUsluge.Name = "gbStavkaUsluge";
            this.gbStavkaUsluge.Size = new System.Drawing.Size(714, 202);
            this.gbStavkaUsluge.TabIndex = 23;
            this.gbStavkaUsluge.TabStop = false;
            this.gbStavkaUsluge.Text = "Stavke ponude";
            // 
            // btnNovaStavkaPonude
            // 
            this.btnNovaStavkaPonude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaStavkaPonude.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaStavkaPonude.Location = new System.Drawing.Point(456, 169);
            this.btnNovaStavkaPonude.Name = "btnNovaStavkaPonude";
            this.btnNovaStavkaPonude.Size = new System.Drawing.Size(80, 27);
            this.btnNovaStavkaPonude.TabIndex = 22;
            this.btnNovaStavkaPonude.Text = "Novi";
            this.btnNovaStavkaPonude.UseVisualStyleBackColor = true;
            this.btnNovaStavkaPonude.Click += new System.EventHandler(this.btnNovaStavkaPonude_Click);
            // 
            // btnIzmjeniStavkuPonude
            // 
            this.btnIzmjeniStavkuPonude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmjeniStavkuPonude.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmjeniStavkuPonude.Location = new System.Drawing.Point(542, 169);
            this.btnIzmjeniStavkuPonude.Name = "btnIzmjeniStavkuPonude";
            this.btnIzmjeniStavkuPonude.Size = new System.Drawing.Size(80, 27);
            this.btnIzmjeniStavkuPonude.TabIndex = 21;
            this.btnIzmjeniStavkuPonude.Text = "Izmjeni";
            this.btnIzmjeniStavkuPonude.UseVisualStyleBackColor = true;
            this.btnIzmjeniStavkuPonude.Click += new System.EventHandler(this.btnIzmjeniStavkuPonude_Click);
            // 
            // btnIzbrisiStavkuPonude
            // 
            this.btnIzbrisiStavkuPonude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzbrisiStavkuPonude.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiStavkuPonude.Location = new System.Drawing.Point(628, 169);
            this.btnIzbrisiStavkuPonude.Name = "btnIzbrisiStavkuPonude";
            this.btnIzbrisiStavkuPonude.Size = new System.Drawing.Size(80, 27);
            this.btnIzbrisiStavkuPonude.TabIndex = 20;
            this.btnIzbrisiStavkuPonude.Text = "Izbriši";
            this.btnIzbrisiStavkuPonude.UseVisualStyleBackColor = true;
            this.btnIzbrisiStavkuPonude.Click += new System.EventHandler(this.btnIzbrisiStavkuPonude_Click);
            // 
            // dgvStavkePonude
            // 
            this.dgvStavkePonude.AllowUserToAddRows = false;
            this.dgvStavkePonude.AllowUserToDeleteRows = false;
            this.dgvStavkePonude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStavkePonude.AutoGenerateColumns = false;
            this.dgvStavkePonude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePonude.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStavkePonudeDataGridViewTextBoxColumn,
            this.ponudaIdDataGridViewTextBoxColumn,
            this.uslugaIdDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvStavkePonude.DataSource = this.stavkaPonudeSetBindingSource;
            this.dgvStavkePonude.Location = new System.Drawing.Point(7, 22);
            this.dgvStavkePonude.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStavkePonude.Name = "dgvStavkePonude";
            this.dgvStavkePonude.ReadOnly = true;
            this.dgvStavkePonude.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkePonude.Size = new System.Drawing.Size(700, 140);
            this.dgvStavkePonude.TabIndex = 2;
            // 
            // idStavkePonudeDataGridViewTextBoxColumn
            // 
            this.idStavkePonudeDataGridViewTextBoxColumn.DataPropertyName = "IdStavkePonude";
            this.idStavkePonudeDataGridViewTextBoxColumn.HeaderText = "IdStavkePonude";
            this.idStavkePonudeDataGridViewTextBoxColumn.Name = "idStavkePonudeDataGridViewTextBoxColumn";
            this.idStavkePonudeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStavkePonudeDataGridViewTextBoxColumn.Visible = false;
            // 
            // ponudaIdDataGridViewTextBoxColumn
            // 
            this.ponudaIdDataGridViewTextBoxColumn.DataPropertyName = "PonudaId";
            this.ponudaIdDataGridViewTextBoxColumn.HeaderText = "Ponuda";
            this.ponudaIdDataGridViewTextBoxColumn.Name = "ponudaIdDataGridViewTextBoxColumn";
            this.ponudaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ponudaIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // uslugaIdDataGridViewTextBoxColumn
            // 
            this.uslugaIdDataGridViewTextBoxColumn.DataPropertyName = "UslugaId";
            this.uslugaIdDataGridViewTextBoxColumn.DataSource = this.uslugaSetBindingSource;
            this.uslugaIdDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.uslugaIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.uslugaIdDataGridViewTextBoxColumn.HeaderText = "Usluga";
            this.uslugaIdDataGridViewTextBoxColumn.Name = "uslugaIdDataGridViewTextBoxColumn";
            this.uslugaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.uslugaIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uslugaIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.uslugaIdDataGridViewTextBoxColumn.ValueMember = "IdUsluge";
            this.uslugaIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // uslugaSetBindingSource
            // 
            this.uslugaSetBindingSource.DataMember = "UslugaSet";
            this.uslugaSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 200;
            // 
            // stavkaPonudeSetBindingSource
            // 
            this.stavkaPonudeSetBindingSource.DataMember = "StavkaPonudeSet";
            this.stavkaPonudeSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // gbUsluge
            // 
            this.gbUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsluge.Controls.Add(this.btnNovaPonuda);
            this.gbUsluge.Controls.Add(this.btnIzmjeniPonudu);
            this.gbUsluge.Controls.Add(this.btnIzbrisiPonudu);
            this.gbUsluge.Controls.Add(this.dgvUsluge);
            this.gbUsluge.Location = new System.Drawing.Point(27, 29);
            this.gbUsluge.Name = "gbUsluge";
            this.gbUsluge.Size = new System.Drawing.Size(714, 202);
            this.gbUsluge.TabIndex = 22;
            this.gbUsluge.TabStop = false;
            this.gbUsluge.Text = "Ponude";
            // 
            // btnNovaPonuda
            // 
            this.btnNovaPonuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaPonuda.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaPonuda.Location = new System.Drawing.Point(456, 169);
            this.btnNovaPonuda.Name = "btnNovaPonuda";
            this.btnNovaPonuda.Size = new System.Drawing.Size(80, 27);
            this.btnNovaPonuda.TabIndex = 22;
            this.btnNovaPonuda.Text = "Nova";
            this.btnNovaPonuda.UseVisualStyleBackColor = true;
            this.btnNovaPonuda.Click += new System.EventHandler(this.btnNovaPonuda_Click);
            // 
            // btnIzmjeniPonudu
            // 
            this.btnIzmjeniPonudu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmjeniPonudu.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmjeniPonudu.Location = new System.Drawing.Point(542, 169);
            this.btnIzmjeniPonudu.Name = "btnIzmjeniPonudu";
            this.btnIzmjeniPonudu.Size = new System.Drawing.Size(80, 27);
            this.btnIzmjeniPonudu.TabIndex = 21;
            this.btnIzmjeniPonudu.Text = "Izmjeni";
            this.btnIzmjeniPonudu.UseVisualStyleBackColor = true;
            this.btnIzmjeniPonudu.Click += new System.EventHandler(this.btnIzmjeniPonudu_Click);
            // 
            // btnIzbrisiPonudu
            // 
            this.btnIzbrisiPonudu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzbrisiPonudu.Font = new System.Drawing.Font("Ubuntu", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiPonudu.Location = new System.Drawing.Point(628, 169);
            this.btnIzbrisiPonudu.Name = "btnIzbrisiPonudu";
            this.btnIzbrisiPonudu.Size = new System.Drawing.Size(80, 27);
            this.btnIzbrisiPonudu.TabIndex = 20;
            this.btnIzbrisiPonudu.Text = "Izbriši";
            this.btnIzbrisiPonudu.UseVisualStyleBackColor = true;
            this.btnIzbrisiPonudu.Click += new System.EventHandler(this.btnIzbrisiPonudu_Click);
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsluge.AutoGenerateColumns = false;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPonudaDataGridViewTextBoxColumn,
            this.klijentIdDataGridViewTextBoxColumn,
            this.zaposlenikIdDataGridViewTextBoxColumn,
            this.datumIzdavanjaDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn});
            this.dgvUsluge.DataSource = this.ponudaSetBindingSource;
            this.dgvUsluge.Location = new System.Drawing.Point(7, 22);
            this.dgvUsluge.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsluge.Size = new System.Drawing.Size(700, 140);
            this.dgvUsluge.TabIndex = 2;
            this.dgvUsluge.SelectionChanged += new System.EventHandler(this.dgvUsluge_SelectionChanged);
            // 
            // idPonudaDataGridViewTextBoxColumn
            // 
            this.idPonudaDataGridViewTextBoxColumn.DataPropertyName = "IdPonuda";
            this.idPonudaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idPonudaDataGridViewTextBoxColumn.Name = "idPonudaDataGridViewTextBoxColumn";
            this.idPonudaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPonudaDataGridViewTextBoxColumn.Width = 50;
            // 
            // klijentIdDataGridViewTextBoxColumn
            // 
            this.klijentIdDataGridViewTextBoxColumn.DataPropertyName = "KlijentId";
            this.klijentIdDataGridViewTextBoxColumn.DataSource = this.klijentSetBindingSource;
            this.klijentIdDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.klijentIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.klijentIdDataGridViewTextBoxColumn.HeaderText = "Klijent";
            this.klijentIdDataGridViewTextBoxColumn.Name = "klijentIdDataGridViewTextBoxColumn";
            this.klijentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.klijentIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.klijentIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.klijentIdDataGridViewTextBoxColumn.ValueMember = "IdKlijent";
            this.klijentIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // klijentSetBindingSource
            // 
            this.klijentSetBindingSource.DataMember = "KlijentSet";
            this.klijentSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // zaposlenikIdDataGridViewTextBoxColumn
            // 
            this.zaposlenikIdDataGridViewTextBoxColumn.DataPropertyName = "ZaposlenikId";
            this.zaposlenikIdDataGridViewTextBoxColumn.DataSource = this.zaspolenikSetBindingSource;
            this.zaposlenikIdDataGridViewTextBoxColumn.DisplayMember = "Prezime";
            this.zaposlenikIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.zaposlenikIdDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikIdDataGridViewTextBoxColumn.Name = "zaposlenikIdDataGridViewTextBoxColumn";
            this.zaposlenikIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zaposlenikIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zaposlenikIdDataGridViewTextBoxColumn.ValueMember = "IdZaposlenik";
            this.zaposlenikIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // zaspolenikSetBindingSource
            // 
            this.zaspolenikSetBindingSource.DataMember = "ZaspolenikSet";
            this.zaspolenikSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // datumIzdavanjaDataGridViewTextBoxColumn
            // 
            this.datumIzdavanjaDataGridViewTextBoxColumn.DataPropertyName = "DatumIzdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.HeaderText = "Datum izdavanja";
            this.datumIzdavanjaDataGridViewTextBoxColumn.Name = "datumIzdavanjaDataGridViewTextBoxColumn";
            this.datumIzdavanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumIzdavanjaDataGridViewTextBoxColumn.Width = 200;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.Width = 250;
            // 
            // ponudaSetBindingSource
            // 
            this.ponudaSetBindingSource.DataMember = "PonudaSet";
            this.ponudaSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // ponudaSetTableAdapter
            // 
            this.ponudaSetTableAdapter.ClearBeforeFill = true;
            // 
            // stavkaPonudeSetTableAdapter
            // 
            this.stavkaPonudeSetTableAdapter.ClearBeforeFill = true;
            // 
            // uslugaSetTableAdapter
            // 
            this.uslugaSetTableAdapter.ClearBeforeFill = true;
            // 
            // btnIspisPonude
            // 
            this.btnIspisPonude.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspisPonude.Location = new System.Drawing.Point(515, 533);
            this.btnIspisPonude.Name = "btnIspisPonude";
            this.btnIspisPonude.Size = new System.Drawing.Size(100, 57);
            this.btnIspisPonude.TabIndex = 24;
            this.btnIspisPonude.Text = "Ispis ponude";
            this.btnIspisPonude.UseVisualStyleBackColor = true;
            this.btnIspisPonude.Click += new System.EventHandler(this.btnIspisPonude_Click);
            // 
            // klijentSetTableAdapter
            // 
            this.klijentSetTableAdapter.ClearBeforeFill = true;
            // 
            // zaspolenikSetTableAdapter
            // 
            this.zaspolenikSetTableAdapter.ClearBeforeFill = true;
            // 
            // frmPonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 628);
            this.Controls.Add(this.btnIspisPonude);
            this.Controls.Add(this.gbStavkaUsluge);
            this.Controls.Add(this.gbUsluge);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOdustani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPonude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ponude";
            this.Load += new System.EventHandler(this.frmPonude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbStavkaUsluge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePonude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPonudeSetBindingSource)).EndInit();
            this.gbUsluge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ponudaSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbStavkaUsluge;
        private System.Windows.Forms.Button btnNovaStavkaPonude;
        private System.Windows.Forms.Button btnIzmjeniStavkuPonude;
        private System.Windows.Forms.Button btnIzbrisiStavkuPonude;
        private System.Windows.Forms.DataGridView dgvStavkePonude;
        private System.Windows.Forms.GroupBox gbUsluge;
        private System.Windows.Forms.Button btnNovaPonuda;
        private System.Windows.Forms.Button btnIzmjeniPonudu;
        private System.Windows.Forms.Button btnIzbrisiPonudu;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource ponudaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.PonudaSetTableAdapter ponudaSetTableAdapter;
        private System.Windows.Forms.BindingSource stavkaPonudeSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.StavkaPonudeSetTableAdapter stavkaPonudeSetTableAdapter;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter uslugaSetTableAdapter;
        private System.Windows.Forms.Button btnIspisPonude;
        private System.Windows.Forms.BindingSource klijentSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.KlijentSetTableAdapter klijentSetTableAdapter;
        private System.Windows.Forms.BindingSource zaspolenikSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter zaspolenikSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPonudaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn klijentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zaposlenikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIzdavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStavkePonudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ponudaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn uslugaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}