namespace Baustelle
{
    partial class frmDetaljiPonude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetaljiPonude));
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.ponudaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.zaspolenikSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.klijentSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblKlijent = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.klijentSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.KlijentSetTableAdapter();
            this.ponudaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.PonudaSetTableAdapter();
            this.zaspolenikSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter();
            this.lblDetaljiOPonudi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ponudaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNapomena
            // 
            this.txtNapomena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNapomena.Location = new System.Drawing.Point(344, 60);
            this.txtNapomena.Margin = new System.Windows.Forms.Padding(4);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(216, 100);
            this.txtNapomena.TabIndex = 16;
            // 
            // lblNapomena
            // 
            this.lblNapomena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(419, 39);
            this.lblNapomena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(76, 17);
            this.lblNapomena.TabIndex = 17;
            this.lblNapomena.Text = "Napomena:";
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbZaposlenik.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ponudaSetBindingSource, "ZaposlenikId", true));
            this.cmbZaposlenik.DataSource = this.zaspolenikSetBindingSource;
            this.cmbZaposlenik.DisplayMember = "Prezime";
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(126, 119);
            this.cmbZaposlenik.Margin = new System.Windows.Forms.Padding(4);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(157, 25);
            this.cmbZaposlenik.TabIndex = 15;
            this.cmbZaposlenik.ValueMember = "IdZaposlenik";
            // 
            // ponudaSetBindingSource
            // 
            this.ponudaSetBindingSource.DataMember = "PonudaSet";
            this.ponudaSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // baustelleDBDataSet2
            // 
            this.baustelleDBDataSet2.DataSetName = "BaustelleDBDataSet2";
            this.baustelleDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaspolenikSetBindingSource
            // 
            this.zaspolenikSetBindingSource.DataMember = "ZaspolenikSet";
            this.zaspolenikSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(42, 122);
            this.lblZaposlenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(76, 17);
            this.lblZaposlenik.TabIndex = 15;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbKlijent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ponudaSetBindingSource, "KlijentId", true));
            this.cmbKlijent.DataSource = this.klijentSetBindingSource;
            this.cmbKlijent.DisplayMember = "Naziv";
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(126, 60);
            this.cmbKlijent.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(157, 25);
            this.cmbKlijent.TabIndex = 14;
            this.cmbKlijent.ValueMember = "IdKlijent";
            // 
            // klijentSetBindingSource
            // 
            this.klijentSetBindingSource.DataMember = "KlijentSet";
            this.klijentSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // lblKlijent
            // 
            this.lblKlijent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Location = new System.Drawing.Point(68, 63);
            this.lblKlijent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(50, 17);
            this.lblKlijent.TabIndex = 13;
            this.lblKlijent.Text = "Klijent:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 192);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(344, 261);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 44);
            this.btnSpremi.TabIndex = 17;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.btnOdustani.Location = new System.Drawing.Point(460, 261);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 18;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // klijentSetTableAdapter
            // 
            this.klijentSetTableAdapter.ClearBeforeFill = true;
            // 
            // ponudaSetTableAdapter
            // 
            this.ponudaSetTableAdapter.ClearBeforeFill = true;
            // 
            // zaspolenikSetTableAdapter
            // 
            this.zaspolenikSetTableAdapter.ClearBeforeFill = true;
            // 
            // lblDetaljiOPonudi
            // 
            this.lblDetaljiOPonudi.AutoSize = true;
            this.lblDetaljiOPonudi.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDetaljiOPonudi.ForeColor = System.Drawing.Color.Navy;
            this.lblDetaljiOPonudi.Location = new System.Drawing.Point(12, 9);
            this.lblDetaljiOPonudi.Name = "lblDetaljiOPonudi";
            this.lblDetaljiOPonudi.Size = new System.Drawing.Size(106, 19);
            this.lblDetaljiOPonudi.TabIndex = 22;
            this.lblDetaljiOPonudi.Text = "Detalji o ponudi.";
            // 
            // frmDetaljiPonude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 339);
            this.Controls.Add(this.lblDetaljiOPonudi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.cmbKlijent);
            this.Controls.Add(this.lblKlijent);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDetaljiPonude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.DetaljiPonude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ponudaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource klijentSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.KlijentSetTableAdapter klijentSetTableAdapter;
        private System.Windows.Forms.BindingSource ponudaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.PonudaSetTableAdapter ponudaSetTableAdapter;
        private System.Windows.Forms.BindingSource zaspolenikSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter zaspolenikSetTableAdapter;
        private System.Windows.Forms.Label lblDetaljiOPonudi;
    }
}