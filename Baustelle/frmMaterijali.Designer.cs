namespace Baustelle
{
    partial class frmMaterijali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterijali));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.idMaterijalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicaMjereIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jedinicaMjereSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.materijalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materijalSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter();
            this.baustelleDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jedinicaMjereSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.JedinicaMjereSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicaMjereSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(603, 538);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 41);
            this.btnOdustani.TabIndex = 3;
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
            // dgvMaterijali
            // 
            this.dgvMaterijali.AllowUserToAddRows = false;
            this.dgvMaterijali.AllowUserToDeleteRows = false;
            this.dgvMaterijali.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterijali.AutoGenerateColumns = false;
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterijalDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.jedinicaMjereIdDataGridViewTextBoxColumn});
            this.dgvMaterijali.DataSource = this.materijalSetBindingSource;
            this.dgvMaterijali.Location = new System.Drawing.Point(51, 139);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.ReadOnly = true;
            this.dgvMaterijali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterijali.Size = new System.Drawing.Size(652, 351);
            this.dgvMaterijali.TabIndex = 18;
            this.dgvMaterijali.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterijali_CellMouseDoubleClick_1);
            // 
            // idMaterijalDataGridViewTextBoxColumn
            // 
            this.idMaterijalDataGridViewTextBoxColumn.DataPropertyName = "IdMaterijal";
            this.idMaterijalDataGridViewTextBoxColumn.HeaderText = "IdMaterijal";
            this.idMaterijalDataGridViewTextBoxColumn.Name = "idMaterijalDataGridViewTextBoxColumn";
            this.idMaterijalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMaterijalDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 200;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.Width = 200;
            // 
            // jedinicaMjereIdDataGridViewTextBoxColumn
            // 
            this.jedinicaMjereIdDataGridViewTextBoxColumn.DataPropertyName = "JedinicaMjereId";
            this.jedinicaMjereIdDataGridViewTextBoxColumn.DataSource = this.jedinicaMjereSetBindingSource;
            this.jedinicaMjereIdDataGridViewTextBoxColumn.DisplayMember = "Naziv";
            this.jedinicaMjereIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jedinicaMjereIdDataGridViewTextBoxColumn.HeaderText = "Jedinica mjere";
            this.jedinicaMjereIdDataGridViewTextBoxColumn.Name = "jedinicaMjereIdDataGridViewTextBoxColumn";
            this.jedinicaMjereIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicaMjereIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jedinicaMjereIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jedinicaMjereIdDataGridViewTextBoxColumn.ValueMember = "IdJedinicaMjere";
            this.jedinicaMjereIdDataGridViewTextBoxColumn.Width = 200;
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
            // materijalSetBindingSource
            // 
            this.materijalSetBindingSource.DataMember = "MaterijalSet";
            this.materijalSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // materijalSetTableAdapter
            // 
            this.materijalSetTableAdapter.ClearBeforeFill = true;
            // 
            // baustelleDBDataSet2BindingSource
            // 
            this.baustelleDBDataSet2BindingSource.DataSource = this.baustelleDBDataSet2;
            this.baustelleDBDataSet2BindingSource.Position = 0;
            // 
            // jedinicaMjereSetTableAdapter
            // 
            this.jedinicaMjereSetTableAdapter.ClearBeforeFill = true;
            // 
            // frmMaterijali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 628);
            this.Controls.Add(this.dgvMaterijali);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMaterijali";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materijali";
            this.Load += new System.EventHandler(this.frmMaterijali_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicaMjereSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvMaterijali;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource materijalSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter materijalSetTableAdapter;
        private System.Windows.Forms.BindingSource baustelleDBDataSet2BindingSource;
        private System.Windows.Forms.BindingSource jedinicaMjereSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.JedinicaMjereSetTableAdapter jedinicaMjereSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterijalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn jedinicaMjereIdDataGridViewTextBoxColumn;
    }
}