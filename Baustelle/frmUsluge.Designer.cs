namespace Baustelle
{
    partial class frmUsluge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsluge));
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.idUslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.zaspolenikSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.gbUsluge = new System.Windows.Forms.GroupBox();
            this.btnNovaUsluga = new System.Windows.Forms.Button();
            this.btnIzmjeniUslugu = new System.Windows.Forms.Button();
            this.btnIzbriši = new System.Windows.Forms.Button();
            this.gbStavkaUsluge = new System.Windows.Forms.GroupBox();
            this.btnNovaStavka = new System.Windows.Forms.Button();
            this.btnIzmjeniStavku = new System.Windows.Forms.Button();
            this.btnIzbrisiUslugu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idStavkaUslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uslugaSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.materijalIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.materijalSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaUslugeSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uslugaSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materijalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stavkaUslugeSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.StavkaUslugeSetTableAdapter();
            this.uslugaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter();
            this.zaspolenikSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter();
            this.materijalSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter();
            this.jedinicaMjereSetTableAdapter1 = new Baustelle.BaustelleDBDataSet2TableAdapters.JedinicaMjereSetTableAdapter();
            this.baustelleDBDataSet21BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.gbUsluge.SuspendLayout();
            this.gbStavkaUsluge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaUslugeSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet21BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.idUslugeDataGridViewTextBoxColumn,
            this.zaposlenikIdDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.datumKreiranjaDataGridViewTextBoxColumn});
            this.dgvUsluge.DataSource = this.uslugaSetBindingSource;
            this.dgvUsluge.Location = new System.Drawing.Point(7, 22);
            this.dgvUsluge.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsluge.Size = new System.Drawing.Size(795, 140);
            this.dgvUsluge.TabIndex = 2;
            this.dgvUsluge.SelectionChanged += new System.EventHandler(this.dgvUsluge_SelectionChanged);
            // 
            // idUslugeDataGridViewTextBoxColumn
            // 
            this.idUslugeDataGridViewTextBoxColumn.DataPropertyName = "IdUsluge";
            this.idUslugeDataGridViewTextBoxColumn.HeaderText = "IdUsluge";
            this.idUslugeDataGridViewTextBoxColumn.Name = "idUslugeDataGridViewTextBoxColumn";
            this.idUslugeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idUslugeDataGridViewTextBoxColumn.Visible = false;
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
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 200;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDataGridViewTextBoxColumn.Width = 200;
            // 
            // datumKreiranjaDataGridViewTextBoxColumn
            // 
            this.datumKreiranjaDataGridViewTextBoxColumn.DataPropertyName = "DatumKreiranja";
            this.datumKreiranjaDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja";
            this.datumKreiranjaDataGridViewTextBoxColumn.Name = "datumKreiranjaDataGridViewTextBoxColumn";
            this.datumKreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumKreiranjaDataGridViewTextBoxColumn.Width = 200;
            // 
            // uslugaSetBindingSource
            // 
            this.uslugaSetBindingSource.DataMember = "UslugaSet";
            this.uslugaSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // pictLogo
            // 
            this.pictLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(51, 553);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(429, 106);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 18;
            this.pictLogo.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(715, 582);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 41);
            this.btnOdustani.TabIndex = 19;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // gbUsluge
            // 
            this.gbUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsluge.Controls.Add(this.btnNovaUsluga);
            this.gbUsluge.Controls.Add(this.btnIzmjeniUslugu);
            this.gbUsluge.Controls.Add(this.btnIzbriši);
            this.gbUsluge.Controls.Add(this.dgvUsluge);
            this.gbUsluge.Location = new System.Drawing.Point(21, 30);
            this.gbUsluge.Name = "gbUsluge";
            this.gbUsluge.Size = new System.Drawing.Size(809, 202);
            this.gbUsluge.TabIndex = 20;
            this.gbUsluge.TabStop = false;
            this.gbUsluge.Text = "Usluge";
            // 
            // btnNovaUsluga
            // 
            this.btnNovaUsluga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaUsluga.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaUsluga.Location = new System.Drawing.Point(551, 169);
            this.btnNovaUsluga.Name = "btnNovaUsluga";
            this.btnNovaUsluga.Size = new System.Drawing.Size(80, 27);
            this.btnNovaUsluga.TabIndex = 22;
            this.btnNovaUsluga.Text = "Nova";
            this.btnNovaUsluga.UseVisualStyleBackColor = true;
            this.btnNovaUsluga.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnIzmjeniUslugu
            // 
            this.btnIzmjeniUslugu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmjeniUslugu.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmjeniUslugu.Location = new System.Drawing.Point(637, 169);
            this.btnIzmjeniUslugu.Name = "btnIzmjeniUslugu";
            this.btnIzmjeniUslugu.Size = new System.Drawing.Size(80, 27);
            this.btnIzmjeniUslugu.TabIndex = 21;
            this.btnIzmjeniUslugu.Text = "Izmjeni";
            this.btnIzmjeniUslugu.UseVisualStyleBackColor = true;
            this.btnIzmjeniUslugu.Click += new System.EventHandler(this.btnIzmjeniUslugu_Click_1);
            // 
            // btnIzbriši
            // 
            this.btnIzbriši.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzbriši.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbriši.Location = new System.Drawing.Point(723, 169);
            this.btnIzbriši.Name = "btnIzbriši";
            this.btnIzbriši.Size = new System.Drawing.Size(80, 27);
            this.btnIzbriši.TabIndex = 20;
            this.btnIzbriši.Text = "Izbriši";
            this.btnIzbriši.UseVisualStyleBackColor = true;
            this.btnIzbriši.Click += new System.EventHandler(this.btnIzbriši_Click);
            // 
            // gbStavkaUsluge
            // 
            this.gbStavkaUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStavkaUsluge.Controls.Add(this.btnNovaStavka);
            this.gbStavkaUsluge.Controls.Add(this.btnIzmjeniStavku);
            this.gbStavkaUsluge.Controls.Add(this.btnIzbrisiUslugu);
            this.gbStavkaUsluge.Controls.Add(this.dataGridView1);
            this.gbStavkaUsluge.Location = new System.Drawing.Point(21, 345);
            this.gbStavkaUsluge.Name = "gbStavkaUsluge";
            this.gbStavkaUsluge.Size = new System.Drawing.Size(809, 167);
            this.gbStavkaUsluge.TabIndex = 21;
            this.gbStavkaUsluge.TabStop = false;
            this.gbStavkaUsluge.Text = "Stavka usluge";
            // 
            // btnNovaStavka
            // 
            this.btnNovaStavka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaStavka.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaStavka.Location = new System.Drawing.Point(551, 134);
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Size = new System.Drawing.Size(80, 27);
            this.btnNovaStavka.TabIndex = 22;
            this.btnNovaStavka.Text = "Nova";
            this.btnNovaStavka.UseVisualStyleBackColor = true;
            this.btnNovaStavka.Click += new System.EventHandler(this.btnNovaStavka_Click);
            // 
            // btnIzmjeniStavku
            // 
            this.btnIzmjeniStavku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzmjeniStavku.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmjeniStavku.Location = new System.Drawing.Point(637, 134);
            this.btnIzmjeniStavku.Name = "btnIzmjeniStavku";
            this.btnIzmjeniStavku.Size = new System.Drawing.Size(80, 27);
            this.btnIzmjeniStavku.TabIndex = 21;
            this.btnIzmjeniStavku.Text = "Izmjeni";
            this.btnIzmjeniStavku.UseVisualStyleBackColor = true;
            this.btnIzmjeniStavku.Click += new System.EventHandler(this.btnIzmjeniStavku_Click);
            // 
            // btnIzbrisiUslugu
            // 
            this.btnIzbrisiUslugu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzbrisiUslugu.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiUslugu.Location = new System.Drawing.Point(723, 134);
            this.btnIzbrisiUslugu.Name = "btnIzbrisiUslugu";
            this.btnIzbrisiUslugu.Size = new System.Drawing.Size(80, 27);
            this.btnIzbrisiUslugu.TabIndex = 20;
            this.btnIzbrisiUslugu.Text = "Izbriši";
            this.btnIzbrisiUslugu.UseVisualStyleBackColor = true;
            this.btnIzbrisiUslugu.Click += new System.EventHandler(this.btnIzbrisiUslugu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStavkaUslugeDataGridViewTextBoxColumn,
            this.uslugaIdDataGridViewTextBoxColumn,
            this.materijalIdDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stavkaUslugeSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(795, 105);
            this.dataGridView1.TabIndex = 2;
            // 
            // idStavkaUslugeDataGridViewTextBoxColumn
            // 
            this.idStavkaUslugeDataGridViewTextBoxColumn.DataPropertyName = "IdStavkaUsluge";
            this.idStavkaUslugeDataGridViewTextBoxColumn.HeaderText = "IdStavkaUsluge";
            this.idStavkaUslugeDataGridViewTextBoxColumn.Name = "idStavkaUslugeDataGridViewTextBoxColumn";
            this.idStavkaUslugeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStavkaUslugeDataGridViewTextBoxColumn.Visible = false;
            // 
            // uslugaIdDataGridViewTextBoxColumn
            // 
            this.uslugaIdDataGridViewTextBoxColumn.DataPropertyName = "UslugaId";
            this.uslugaIdDataGridViewTextBoxColumn.DataSource = this.uslugaSetBindingSource2;
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
            // uslugaSetBindingSource2
            // 
            this.uslugaSetBindingSource2.DataMember = "UslugaSet";
            this.uslugaSetBindingSource2.DataSource = this.baustelleDBDataSet2;
            // 
            // materijalIdDataGridViewTextBoxColumn
            // 
            this.materijalIdDataGridViewTextBoxColumn.DataPropertyName = "MaterijalId";
            this.materijalIdDataGridViewTextBoxColumn.DataSource = this.materijalSetBindingSource1;
            this.materijalIdDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.materijalIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.materijalIdDataGridViewTextBoxColumn.HeaderText = "Materijal";
            this.materijalIdDataGridViewTextBoxColumn.Name = "materijalIdDataGridViewTextBoxColumn";
            this.materijalIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.materijalIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.materijalIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.materijalIdDataGridViewTextBoxColumn.ValueMember = "IdMaterijal";
            this.materijalIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // materijalSetBindingSource1
            // 
            this.materijalSetBindingSource1.DataMember = "MaterijalSet";
            this.materijalSetBindingSource1.DataSource = this.baustelleDBDataSet2;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 200;
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
            // uslugaSetBindingSource1
            // 
            this.uslugaSetBindingSource1.DataMember = "UslugaSet";
            this.uslugaSetBindingSource1.DataSource = this.baustelleDBDataSet2;
            // 
            // materijalSetBindingSource
            // 
            this.materijalSetBindingSource.DataMember = "MaterijalSet";
            this.materijalSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // stavkaUslugeSetTableAdapter
            // 
            this.stavkaUslugeSetTableAdapter.ClearBeforeFill = true;
            // 
            // uslugaSetTableAdapter
            // 
            this.uslugaSetTableAdapter.ClearBeforeFill = true;
            // 
            // zaspolenikSetTableAdapter
            // 
            this.zaspolenikSetTableAdapter.ClearBeforeFill = true;
            // 
            // materijalSetTableAdapter
            // 
            this.materijalSetTableAdapter.ClearBeforeFill = true;
            // 
            // jedinicaMjereSetTableAdapter1
            // 
            this.jedinicaMjereSetTableAdapter1.ClearBeforeFill = true;
            // 
            // frmUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 671);
            this.Controls.Add(this.gbStavkaUsluge);
            this.Controls.Add(this.gbUsluge);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsluge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usluge";
            this.Load += new System.EventHandler(this.frmUsluge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.gbUsluge.ResumeLayout(false);
            this.gbStavkaUsluge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaUslugeSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet21BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource baustelleDBDataSet2BindingSource;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.GroupBox gbUsluge;
        private System.Windows.Forms.Button btnNovaUsluga;
        private System.Windows.Forms.Button btnIzmjeniUslugu;
        private System.Windows.Forms.Button btnIzbriši;
        private System.Windows.Forms.GroupBox gbStavkaUsluge;
        private System.Windows.Forms.Button btnNovaStavka;
        private System.Windows.Forms.Button btnIzmjeniStavku;
        private System.Windows.Forms.Button btnIzbrisiUslugu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource stavkaUslugeSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.StavkaUslugeSetTableAdapter stavkaUslugeSetTableAdapter;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter uslugaSetTableAdapter;
        private System.Windows.Forms.BindingSource zaspolenikSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter zaspolenikSetTableAdapter;
        private System.Windows.Forms.BindingSource materijalSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter materijalSetTableAdapter;
        private System.Windows.Forms.BindingSource baustelleDBDataSet21BindingSource;
        private BaustelleDBDataSet2TableAdapters.JedinicaMjereSetTableAdapter jedinicaMjereSetTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn zaposlenikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource1;
        private System.Windows.Forms.BindingSource materijalSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStavkaUslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn uslugaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource2;
        private System.Windows.Forms.DataGridViewComboBoxColumn materijalIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}