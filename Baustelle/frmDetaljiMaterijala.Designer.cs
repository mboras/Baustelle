namespace Baustelle
{
    partial class frmDetaljiMaterijala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiMaterijala));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.cmbJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.materijalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.jedinicaMjereSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblJedinicaMjere = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.jedinicaMjereSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.JedinicaMjereSetTableAdapter();
            this.materijalSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicaMjereSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 213);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(474, 257);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 44);
            this.btnOdustani.TabIndex = 28;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIzmjeni.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmjeni.Location = new System.Drawing.Point(282, 257);
            this.btnIzmjeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(88, 44);
            this.btnIzmjeni.TabIndex = 26;
            this.btnIzmjeni.Text = "Izmijeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // cmbJedinicaMjere
            // 
            this.cmbJedinicaMjere.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbJedinicaMjere.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.materijalSetBindingSource, "JedinicaMjereId", true));
            this.cmbJedinicaMjere.DataSource = this.jedinicaMjereSetBindingSource;
            this.cmbJedinicaMjere.DisplayMember = "Naziv";
            this.cmbJedinicaMjere.FormattingEnabled = true;
            this.cmbJedinicaMjere.Location = new System.Drawing.Point(118, 108);
            this.cmbJedinicaMjere.Margin = new System.Windows.Forms.Padding(4);
            this.cmbJedinicaMjere.Name = "cmbJedinicaMjere";
            this.cmbJedinicaMjere.Size = new System.Drawing.Size(157, 25);
            this.cmbJedinicaMjere.TabIndex = 24;
            this.cmbJedinicaMjere.ValueMember = "IdJedinicaMjere";
            // 
            // materijalSetBindingSource
            // 
            this.materijalSetBindingSource.DataMember = "MaterijalSet";
            this.materijalSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jedinicaMjereSetBindingSource
            // 
            this.jedinicaMjereSetBindingSource.DataMember = "JedinicaMjereSet";
            this.jedinicaMjereSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNapomena.Location = new System.Drawing.Point(335, 63);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(4);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(227, 107);
            this.txtNapomena.TabIndex = 25;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNaziv.Location = new System.Drawing.Point(118, 63);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(157, 22);
            this.txtNaziv.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Napomena:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(67, 66);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(43, 17);
            this.lblNaziv.TabIndex = 20;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblJedinicaMjere
            // 
            this.lblJedinicaMjere.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblJedinicaMjere.AutoSize = true;
            this.lblJedinicaMjere.Location = new System.Drawing.Point(13, 111);
            this.lblJedinicaMjere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJedinicaMjere.Name = "lblJedinicaMjere";
            this.lblJedinicaMjere.Size = new System.Drawing.Size(99, 17);
            this.lblJedinicaMjere.TabIndex = 19;
            this.lblJedinicaMjere.Text = "Jedinica mjere:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnObrisi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(378, 257);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(88, 44);
            this.btnObrisi.TabIndex = 27;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // jedinicaMjereSetTableAdapter
            // 
            this.jedinicaMjereSetTableAdapter.ClearBeforeFill = true;
            // 
            // materijalSetTableAdapter
            // 
            this.materijalSetTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetaljiMaterijala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 339);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.cmbJedinicaMjere);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblJedinicaMjere);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDetaljiMaterijala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.frmDetaljiMaterijala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedinicaMjereSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.ComboBox cmbJedinicaMjere;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblJedinicaMjere;
        private System.Windows.Forms.Button btnObrisi;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource jedinicaMjereSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.JedinicaMjereSetTableAdapter jedinicaMjereSetTableAdapter;
        private System.Windows.Forms.BindingSource materijalSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter materijalSetTableAdapter;
    }
}