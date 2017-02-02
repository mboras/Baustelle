namespace Baustelle
{
    partial class frmDetaljiOstavciUsluge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiOstavciUsluge));
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblMaterijal = new System.Windows.Forms.Label();
            this.cmbMaterijal = new System.Windows.Forms.ComboBox();
            this.stavkaUslugeSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.materijalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.materijalSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter();
            this.stavkaUslugeSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.StavkaUslugeSetTableAdapter();
            this.lblDetaljiOstav = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaUslugeSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictLogo
            // 
            this.pictLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictLogo.Image")));
            this.pictLogo.Location = new System.Drawing.Point(66, 280);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(225, 67);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 36;
            this.pictLogo.TabStop = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.Location = new System.Drawing.Point(191, 214);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 35;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(66, 214);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 44);
            this.btnSpremi.TabIndex = 34;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblMaterijal
            // 
            this.lblMaterijal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaterijal.AutoSize = true;
            this.lblMaterijal.Location = new System.Drawing.Point(63, 82);
            this.lblMaterijal.Name = "lblMaterijal";
            this.lblMaterijal.Size = new System.Drawing.Size(65, 17);
            this.lblMaterijal.TabIndex = 33;
            this.lblMaterijal.Text = "Materijal:";
            // 
            // cmbMaterijal
            // 
            this.cmbMaterijal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMaterijal.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.stavkaUslugeSetBindingSource, "MaterijalId", true));
            this.cmbMaterijal.DataSource = this.materijalSetBindingSource;
            this.cmbMaterijal.DisplayMember = "Naziv";
            this.cmbMaterijal.FormattingEnabled = true;
            this.cmbMaterijal.Location = new System.Drawing.Point(134, 79);
            this.cmbMaterijal.Name = "cmbMaterijal";
            this.cmbMaterijal.Size = new System.Drawing.Size(157, 25);
            this.cmbMaterijal.TabIndex = 32;
            this.cmbMaterijal.ValueMember = "IdMaterijal";
            // 
            // stavkaUslugeSetBindingSource
            // 
            this.stavkaUslugeSetBindingSource.DataMember = "StavkaUslugeSet";
            this.stavkaUslugeSetBindingSource.DataSource = this.baustelleDBDataSet2;
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
            this.txtKolicina.Location = new System.Drawing.Point(134, 131);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(157, 22);
            this.txtKolicina.TabIndex = 31;
            // 
            // lblKolicina
            // 
            this.lblKolicina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(70, 134);
            this.lblKolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(58, 17);
            this.lblKolicina.TabIndex = 30;
            this.lblKolicina.Text = "Količina:";
            // 
            // materijalSetTableAdapter
            // 
            this.materijalSetTableAdapter.ClearBeforeFill = true;
            // 
            // stavkaUslugeSetTableAdapter
            // 
            this.stavkaUslugeSetTableAdapter.ClearBeforeFill = true;
            // 
            // lblDetaljiOstav
            // 
            this.lblDetaljiOstav.AutoSize = true;
            this.lblDetaljiOstav.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetaljiOstav.ForeColor = System.Drawing.Color.Navy;
            this.lblDetaljiOstav.Location = new System.Drawing.Point(12, 9);
            this.lblDetaljiOstav.Name = "lblDetaljiOstav";
            this.lblDetaljiOstav.Size = new System.Drawing.Size(142, 19);
            this.lblDetaljiOstav.TabIndex = 37;
            this.lblDetaljiOstav.Text = "Detalji o stavci usluge.";
            // 
            // frmDetaljiOstavciUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 359);
            this.Controls.Add(this.lblDetaljiOstav);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblMaterijal);
            this.Controls.Add(this.cmbMaterijal);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetaljiOstavciUsluge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.frmDetaljiOstavciUsluge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaUslugeSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materijalSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblMaterijal;
        private System.Windows.Forms.ComboBox cmbMaterijal;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.BindingSource baustelleDBDataSet2BindingSource;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource materijalSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.MaterijalSetTableAdapter materijalSetTableAdapter;
        private System.Windows.Forms.BindingSource stavkaUslugeSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.StavkaUslugeSetTableAdapter stavkaUslugeSetTableAdapter;
        private System.Windows.Forms.Label lblDetaljiOstav;
    }
}