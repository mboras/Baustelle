namespace Baustelle
{
    partial class frmNovaStavkaPonude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaStavkaPonude));
            this.lblUsluga = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cmbUsluga = new System.Windows.Forms.ComboBox();
            this.stavkaPonudeSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.uslugaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNtpis = new System.Windows.Forms.Label();
            this.uslugaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter();
            this.stavkaPonudeSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.StavkaPonudeSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPonudeSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsluga
            // 
            this.lblUsluga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsluga.Location = new System.Drawing.Point(86, 76);
            this.lblUsluga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(52, 17);
            this.lblUsluga.TabIndex = 2;
            this.lblUsluga.Text = "Usluga:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKolicina.Location = new System.Drawing.Point(80, 139);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(58, 17);
            this.lblKolicina.TabIndex = 3;
            this.lblKolicina.Text = "Količina:";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKolicina.Location = new System.Drawing.Point(145, 137);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(157, 22);
            this.txtKolicina.TabIndex = 5;
            // 
            // cmbUsluga
            // 
            this.cmbUsluga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbUsluga.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stavkaPonudeSetBindingSource, "UslugaId", true));
            this.cmbUsluga.DataSource = this.uslugaSetBindingSource;
            this.cmbUsluga.DisplayMember = "Naziv";
            this.cmbUsluga.FormattingEnabled = true;
            this.cmbUsluga.Location = new System.Drawing.Point(145, 74);
            this.cmbUsluga.Name = "cmbUsluga";
            this.cmbUsluga.Size = new System.Drawing.Size(157, 24);
            this.cmbUsluga.TabIndex = 7;
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
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(75, 242);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 44);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(202, 242);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(75, 319);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblNtpis
            // 
            this.lblNtpis.AutoSize = true;
            this.lblNtpis.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNtpis.ForeColor = System.Drawing.Color.Navy;
            this.lblNtpis.Location = new System.Drawing.Point(12, 9);
            this.lblNtpis.Name = "lblNtpis";
            this.lblNtpis.Size = new System.Drawing.Size(199, 19);
            this.lblNtpis.TabIndex = 18;
            this.lblNtpis.Text = "Dodajte novu uslugu na ponudu.";
            // 
            // uslugaSetTableAdapter
            // 
            this.uslugaSetTableAdapter.ClearBeforeFill = true;
            // 
            // stavkaPonudeSetTableAdapter
            // 
            this.stavkaPonudeSetTableAdapter.ClearBeforeFill = true;
            // 
            // frmNovaStavkaPonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 410);
            this.Controls.Add(this.lblNtpis);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cmbUsluga);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblUsluga);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNovaStavkaPonude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova stavka";
            this.Load += new System.EventHandler(this.frmNovaStavkaPonude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stavkaPonudeSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsluga;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cmbUsluga;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNtpis;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter uslugaSetTableAdapter;
        private System.Windows.Forms.BindingSource stavkaPonudeSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.StavkaPonudeSetTableAdapter stavkaPonudeSetTableAdapter;
    }
}