namespace Baustelle
{
    partial class frmJedinicaMjere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJedinicaMjere));
            this.pctPlus = new System.Windows.Forms.PictureBox();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.idJedinicaMjereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skraceniNazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicaMjereSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.jedinicaMjereSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.JedinicaMjereSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicaMjereSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pctPlus
            // 
            this.pctPlus.Image = ((System.Drawing.Image)(resources.GetObject("pctPlus.Image")));
            this.pctPlus.Location = new System.Drawing.Point(51, 67);
            this.pctPlus.Margin = new System.Windows.Forms.Padding(4);
            this.pctPlus.Name = "pctPlus";
            this.pctPlus.Size = new System.Drawing.Size(52, 57);
            this.pctPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPlus.TabIndex = 1;
            this.pctPlus.TabStop = false;
            this.pctPlus.Click += new System.EventHandler(this.pctPlus_Click);
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            this.dgvKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKlijenti.AutoGenerateColumns = false;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJedinicaMjereDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.skraceniNazivDataGridViewTextBoxColumn});
            this.dgvKlijenti.DataSource = this.jedinicaMjereSetBindingSource;
            this.dgvKlijenti.Location = new System.Drawing.Point(51, 171);
            this.dgvKlijenti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(669, 358);
            this.dgvKlijenti.TabIndex = 2;
            this.dgvKlijenti.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKlijenti_CellMouseDoubleClick);
            // 
            // idJedinicaMjereDataGridViewTextBoxColumn
            // 
            this.idJedinicaMjereDataGridViewTextBoxColumn.DataPropertyName = "IdJedinicaMjere";
            this.idJedinicaMjereDataGridViewTextBoxColumn.HeaderText = "IdJedinicaMjere";
            this.idJedinicaMjereDataGridViewTextBoxColumn.Name = "idJedinicaMjereDataGridViewTextBoxColumn";
            this.idJedinicaMjereDataGridViewTextBoxColumn.ReadOnly = true;
            this.idJedinicaMjereDataGridViewTextBoxColumn.Visible = false;
            this.idJedinicaMjereDataGridViewTextBoxColumn.Width = 200;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 200;
            // 
            // skraceniNazivDataGridViewTextBoxColumn
            // 
            this.skraceniNazivDataGridViewTextBoxColumn.DataPropertyName = "SkraceniNaziv";
            this.skraceniNazivDataGridViewTextBoxColumn.HeaderText = "Skraćeni naziv";
            this.skraceniNazivDataGridViewTextBoxColumn.Name = "skraceniNazivDataGridViewTextBoxColumn";
            this.skraceniNazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.skraceniNazivDataGridViewTextBoxColumn.Width = 200;
            // 
            // jedinicaMjereSetBindingSource
            // 
            this.jedinicaMjereSetBindingSource.DataMember = "JedinicaMjereSet";
            this.jedinicaMjereSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 542);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(620, 573);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 18;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // jedinicaMjereSetTableAdapter
            // 
            this.jedinicaMjereSetTableAdapter.ClearBeforeFill = true;
            // 
            // frmJedinicaMjere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 667);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.pctPlus);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmJedinicaMjere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jedinica mjere";
            this.Load += new System.EventHandler(this.frmJedinicaMjere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicaMjereSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPlus;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOdustani;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource jedinicaMjereSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.JedinicaMjereSetTableAdapter jedinicaMjereSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJedinicaMjereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skraceniNazivDataGridViewTextBoxColumn;

    }
}