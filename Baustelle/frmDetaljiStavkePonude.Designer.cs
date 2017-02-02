namespace Baustelle
{
    partial class frmDetaljiStavkePonude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiStavkePonude));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cmbUsluga = new System.Windows.Forms.ComboBox();
            this.stavkaPonudeSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.uslugaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblUsluga = new System.Windows.Forms.Label();
            this.uslugaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter();
            this.stavkaPonudeSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.StavkaPonudeSetTableAdapter();
            this.lblDetaljiOstavciPonude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPonudeSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 319);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(202, 242);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(75, 242);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 44);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cmbUsluga
            // 
            this.cmbUsluga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbUsluga.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stavkaPonudeSetBindingSource, "UslugaId", true));
            this.cmbUsluga.DataSource = this.uslugaSetBindingSource;
            this.cmbUsluga.DisplayMember = "Naziv";
            this.cmbUsluga.FormattingEnabled = true;
            this.cmbUsluga.Location = new System.Drawing.Point(145, 74);
            this.cmbUsluga.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsluga.Name = "cmbUsluga";
            this.cmbUsluga.Size = new System.Drawing.Size(157, 25);
            this.cmbUsluga.TabIndex = 21;
            this.cmbUsluga.ValueMember = "IdUsluge";
            // 
            // stavkaPonudeSetBindingSource
            // 
            this.stavkaPonudeSetBindingSource.DataMember = "StavkaPonudeSet";
            this.stavkaPonudeSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uslugaSetBindingSource
            // 
            this.uslugaSetBindingSource.DataMember = "UslugaSet";
            this.uslugaSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKolicina.Location = new System.Drawing.Point(145, 137);
            this.txtKolicina.Margin = new System.Windows.Forms.Padding(4);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(157, 22);
            this.txtKolicina.TabIndex = 20;
            // 
            // lblKolicina
            // 
            this.lblKolicina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(78, 140);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(58, 17);
            this.lblKolicina.TabIndex = 19;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblUsluga
            // 
            this.lblUsluga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.Location = new System.Drawing.Point(84, 77);
            this.lblUsluga.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(52, 17);
            this.lblUsluga.TabIndex = 18;
            this.lblUsluga.Text = "Usluga:";
            // 
            // uslugaSetTableAdapter
            // 
            this.uslugaSetTableAdapter.ClearBeforeFill = true;
            // 
            // stavkaPonudeSetTableAdapter
            // 
            this.stavkaPonudeSetTableAdapter.ClearBeforeFill = true;
            // 
            // lblDetaljiOstavciPonude
            // 
            this.lblDetaljiOstavciPonude.AutoSize = true;
            this.lblDetaljiOstavciPonude.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetaljiOstavciPonude.ForeColor = System.Drawing.Color.Navy;
            this.lblDetaljiOstavciPonude.Location = new System.Drawing.Point(12, 9);
            this.lblDetaljiOstavciPonude.Name = "lblDetaljiOstavciPonude";
            this.lblDetaljiOstavciPonude.Size = new System.Drawing.Size(147, 19);
            this.lblDetaljiOstavciPonude.TabIndex = 25;
            this.lblDetaljiOstavciPonude.Text = "Detalji o stavci ponude.";
            // 
            // frmDetaljiStavkePonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 410);
            this.Controls.Add(this.lblDetaljiOstavciPonude);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbUsluga);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblUsluga);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDetaljiStavkePonude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.DetaljiStavkePonude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPonudeSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cmbUsluga;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblUsluga;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter uslugaSetTableAdapter;
        private System.Windows.Forms.BindingSource stavkaPonudeSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.StavkaPonudeSetTableAdapter stavkaPonudeSetTableAdapter;
        private System.Windows.Forms.Label lblDetaljiOstavciPonude;

    }
}