namespace Baustelle
{
    partial class frmNovaStavkaUsluge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaStavkaUsluge));
            this.lblNtpis = new System.Windows.Forms.Label();
            this.cmbMaterijal = new System.Windows.Forms.ComboBox();
            this.uslugaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.materijalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblMaterijal = new System.Windows.Forms.Label();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.materijalSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter();
            this.uslugaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNtpis
            // 
            this.lblNtpis.AutoSize = true;
            this.lblNtpis.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNtpis.ForeColor = System.Drawing.Color.Navy;
            this.lblNtpis.Location = new System.Drawing.Point(12, 9);
            this.lblNtpis.Name = "lblNtpis";
            this.lblNtpis.Size = new System.Drawing.Size(192, 19);
            this.lblNtpis.TabIndex = 19;
            this.lblNtpis.Text = "Dodajte novu stavku na uslugu.";
            // 
            // cmbMaterijal
            // 
            this.cmbMaterijal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaterijal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uslugaSetBindingSource, "ZaposlenikId", true));
            this.cmbMaterijal.DataSource = this.materijalSetBindingSource;
            this.cmbMaterijal.DisplayMember = "Naziv";
            this.cmbMaterijal.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.cmbMaterijal.FormattingEnabled = true;
            this.cmbMaterijal.Location = new System.Drawing.Point(134, 72);
            this.cmbMaterijal.Name = "cmbMaterijal";
            this.cmbMaterijal.Size = new System.Drawing.Size(157, 25);
            this.cmbMaterijal.TabIndex = 24;
            this.cmbMaterijal.ValueMember = "IdMaterijal";
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
            // materijalSetBindingSource
            // 
            this.materijalSetBindingSource.DataMember = "MaterijalSet";
            this.materijalSetBindingSource.DataSource = this.baustelleDBDataSet2BindingSource;
            // 
            // baustelleDBDataSet2BindingSource
            // 
            this.baustelleDBDataSet2BindingSource.DataSource = this.baustelleDBDataSet2;
            this.baustelleDBDataSet2BindingSource.Position = 0;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKolicina.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.txtKolicina.Location = new System.Drawing.Point(134, 127);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(157, 22);
            this.txtKolicina.TabIndex = 23;
            // 
            // lblKolicina
            // 
            this.lblKolicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Ubuntu", 9.749999F);
            this.lblKolicina.Location = new System.Drawing.Point(70, 130);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(58, 17);
            this.lblKolicina.TabIndex = 22;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblMaterijal
            // 
            this.lblMaterijal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaterijal.AutoSize = true;
            this.lblMaterijal.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMaterijal.Location = new System.Drawing.Point(63, 75);
            this.lblMaterijal.Name = "lblMaterijal";
            this.lblMaterijal.Size = new System.Drawing.Size(65, 17);
            this.lblMaterijal.TabIndex = 26;
            this.lblMaterijal.Text = "Materijal:";
            // 
            // pictLogo
            // 
            this.pictLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(66, 280);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(225, 67);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 29;
            this.pictLogo.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(191, 214);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 47);
            this.btnOdustani.TabIndex = 28;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(68, 214);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 47);
            this.btnSpremi.TabIndex = 27;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // materijalSetTableAdapter
            // 
            this.materijalSetTableAdapter.ClearBeforeFill = true;
            // 
            // uslugaSetTableAdapter
            // 
            this.uslugaSetTableAdapter.ClearBeforeFill = true;
            // 
            // frmNovaStavkaUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 359);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblMaterijal);
            this.Controls.Add(this.cmbMaterijal);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblNtpis);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNovaStavkaUsluge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stavka usluge";
            this.Load += new System.EventHandler(this.frmNovaStavkaUsluge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uslugaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNtpis;
        private System.Windows.Forms.ComboBox cmbMaterijal;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblMaterijal;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.BindingSource baustelleDBDataSet2BindingSource;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource materijalSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter materijalSetTableAdapter;
        private System.Windows.Forms.BindingSource uslugaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.UslugaSetTableAdapter uslugaSetTableAdapter;
    }
}