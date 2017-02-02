namespace Baustelle
{
    partial class frmNovaPonuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaPonuda));
            this.lblKlijent = new System.Windows.Forms.Label();
            this.cmbKlijent = new System.Windows.Forms.ComboBox();
            this.ponudaSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baustelleDBDataSet2 = new Baustelle.BaustelleDBDataSet2();
            this.klijentSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.zaspolenikSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.klijentSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.KlijentSetTableAdapter();
            this.ponudaSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.PonudaSetTableAdapter();
            this.zaspolenikSetTableAdapter = new Baustelle.BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter();
            this.lblNovaPonuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ponudaSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKlijent
            // 
            this.lblKlijent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.Location = new System.Drawing.Point(70, 64);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(50, 17);
            this.lblKlijent.TabIndex = 7;
            this.lblKlijent.Text = "Klijent:";
            // 
            // cmbKlijent
            // 
            this.cmbKlijent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbKlijent.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ponudaSetBindingSource, "KlijentId", true));
            this.cmbKlijent.DataSource = this.klijentSetBindingSource;
            this.cmbKlijent.DisplayMember = "Naziv";
            this.cmbKlijent.FormattingEnabled = true;
            this.cmbKlijent.Location = new System.Drawing.Point(126, 60);
            this.cmbKlijent.Name = "cmbKlijent";
            this.cmbKlijent.Size = new System.Drawing.Size(157, 25);
            this.cmbKlijent.TabIndex = 8;
            this.cmbKlijent.ValueMember = "IdKlijent";
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
            // klijentSetBindingSource
            // 
            this.klijentSetBindingSource.DataMember = "KlijentSet";
            this.klijentSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(47, 123);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(76, 17);
            this.lblZaposlenik.TabIndex = 9;
            this.lblZaposlenik.Text = "Zaposlenik:";
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbZaposlenik.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ponudaSetBindingSource, "ZaposlenikId", true));
            this.cmbZaposlenik.DataSource = this.zaspolenikSetBindingSource;
            this.cmbZaposlenik.DisplayMember = "Prezime";
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(126, 119);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(157, 25);
            this.cmbZaposlenik.TabIndex = 9;
            this.cmbZaposlenik.ValueMember = "IdZaposlenik";
            // 
            // zaspolenikSetBindingSource
            // 
            this.zaspolenikSetBindingSource.DataMember = "ZaspolenikSet";
            this.zaspolenikSetBindingSource.DataSource = this.baustelleDBDataSet2;
            // 
            // lblNapomena
            // 
            this.lblNapomena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(419, 39);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(76, 17);
            this.lblNapomena.TabIndex = 11;
            this.lblNapomena.Text = "Napomena:";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNapomena.Location = new System.Drawing.Point(344, 60);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(216, 100);
            this.txtNapomena.TabIndex = 10;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOdustani.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold);
            this.btnOdustani.Location = new System.Drawing.Point(460, 261);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(100, 44);
            this.btnOdustani.TabIndex = 12;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSpremi.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(344, 261);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 44);
            this.btnSpremi.TabIndex = 11;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
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
            // lblNovaPonuda
            // 
            this.lblNovaPonuda.AutoSize = true;
            this.lblNovaPonuda.Font = new System.Drawing.Font("Ubuntu Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNovaPonuda.ForeColor = System.Drawing.Color.Navy;
            this.lblNovaPonuda.Location = new System.Drawing.Point(12, 9);
            this.lblNovaPonuda.Name = "lblNovaPonuda";
            this.lblNovaPonuda.Size = new System.Drawing.Size(139, 19);
            this.lblNovaPonuda.TabIndex = 17;
            this.lblNovaPonuda.Text = "Dodajte novu ponudu.";
            // 
            // frmNovaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 339);
            this.Controls.Add(this.lblNovaPonuda);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmNovaPonuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova ponuda";
            this.Load += new System.EventHandler(this.frmNovaPonuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ponudaSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baustelleDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaspolenikSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cmbKlijent;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BaustelleDBDataSet2 baustelleDBDataSet2;
        private System.Windows.Forms.BindingSource klijentSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.KlijentSetTableAdapter klijentSetTableAdapter;
        private System.Windows.Forms.BindingSource ponudaSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.PonudaSetTableAdapter ponudaSetTableAdapter;
        private System.Windows.Forms.BindingSource zaspolenikSetBindingSource;
        private BaustelleDBDataSet2TableAdapters.ZaspolenikSetTableAdapter zaspolenikSetTableAdapter;
        private System.Windows.Forms.Label lblNovaPonuda;
    }
}