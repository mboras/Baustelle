namespace Baustelle
{
    partial class FormAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ponudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poslovnaPravilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazUslugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUsluguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisZaposlenikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materijaliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazMaterijalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajMaterijalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedinicaMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazJedinicaMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajJedinicuMjereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponudeToolStripMenuItem,
            this.poslovnaPravilaToolStripMenuItem,
            this.zaposleniciToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.materijaliToolStripMenuItem,
            this.jedinicaMjereToolStripMenuItem,
            this.izvještajiToolStripMenuItem,
            this.pomoćToolStripMenuItem,
            this.oNamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ponudeToolStripMenuItem
            // 
            this.ponudeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazPonudaToolStripMenuItem,
            this.novaPonudaToolStripMenuItem});
            this.ponudeToolStripMenuItem.Name = "ponudeToolStripMenuItem";
            this.ponudeToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.ponudeToolStripMenuItem.Text = "Ponude";
            // 
            // prikazPonudaToolStripMenuItem
            // 
            this.prikazPonudaToolStripMenuItem.Name = "prikazPonudaToolStripMenuItem";
            this.prikazPonudaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.prikazPonudaToolStripMenuItem.Text = "Prikaz ponuda";
            this.prikazPonudaToolStripMenuItem.Click += new System.EventHandler(this.prikazPonudaToolStripMenuItem_Click);
            // 
            // novaPonudaToolStripMenuItem
            // 
            this.novaPonudaToolStripMenuItem.Name = "novaPonudaToolStripMenuItem";
            this.novaPonudaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.novaPonudaToolStripMenuItem.Text = "Nova ponuda";
            this.novaPonudaToolStripMenuItem.Click += new System.EventHandler(this.novaPonudaToolStripMenuItem_Click);
            // 
            // poslovnaPravilaToolStripMenuItem
            // 
            this.poslovnaPravilaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazUslugaToolStripMenuItem,
            this.dodajUsluguToolStripMenuItem});
            this.poslovnaPravilaToolStripMenuItem.Name = "poslovnaPravilaToolStripMenuItem";
            this.poslovnaPravilaToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.poslovnaPravilaToolStripMenuItem.Text = "Usluge";
            // 
            // prikazUslugaToolStripMenuItem
            // 
            this.prikazUslugaToolStripMenuItem.Name = "prikazUslugaToolStripMenuItem";
            this.prikazUslugaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prikazUslugaToolStripMenuItem.Text = "Prikaz usluga";
            this.prikazUslugaToolStripMenuItem.Click += new System.EventHandler(this.prikazUslugaToolStripMenuItem_Click);
            // 
            // dodajUsluguToolStripMenuItem
            // 
            this.dodajUsluguToolStripMenuItem.Name = "dodajUsluguToolStripMenuItem";
            this.dodajUsluguToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dodajUsluguToolStripMenuItem.Text = "Dodaj uslugu";
            this.dodajUsluguToolStripMenuItem.Click += new System.EventHandler(this.dodajUsluguToolStripMenuItem_Click);
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popisZaposlenikaToolStripMenuItem});
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            // 
            // popisZaposlenikaToolStripMenuItem
            // 
            this.popisZaposlenikaToolStripMenuItem.Name = "popisZaposlenikaToolStripMenuItem";
            this.popisZaposlenikaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.popisZaposlenikaToolStripMenuItem.Text = "Prikaz zaposlenika";
            this.popisZaposlenikaToolStripMenuItem.Click += new System.EventHandler(this.popisZaposlenikaToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazKlijenataToolStripMenuItem,
            this.dodajKlijentaToolStripMenuItem});
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            // 
            // prikazKlijenataToolStripMenuItem
            // 
            this.prikazKlijenataToolStripMenuItem.Name = "prikazKlijenataToolStripMenuItem";
            this.prikazKlijenataToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.prikazKlijenataToolStripMenuItem.Text = "Prikaz klijenata";
            this.prikazKlijenataToolStripMenuItem.Click += new System.EventHandler(this.prikazKlijenataToolStripMenuItem_Click);
            // 
            // dodajKlijentaToolStripMenuItem
            // 
            this.dodajKlijentaToolStripMenuItem.Name = "dodajKlijentaToolStripMenuItem";
            this.dodajKlijentaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dodajKlijentaToolStripMenuItem.Text = "Dodaj klijenta";
            this.dodajKlijentaToolStripMenuItem.Click += new System.EventHandler(this.dodajKlijentaToolStripMenuItem_Click);
            // 
            // materijaliToolStripMenuItem
            // 
            this.materijaliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazMaterijalaToolStripMenuItem,
            this.dodajMaterijalToolStripMenuItem});
            this.materijaliToolStripMenuItem.Name = "materijaliToolStripMenuItem";
            this.materijaliToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.materijaliToolStripMenuItem.Text = "Materijali";
            // 
            // prikazMaterijalaToolStripMenuItem
            // 
            this.prikazMaterijalaToolStripMenuItem.Name = "prikazMaterijalaToolStripMenuItem";
            this.prikazMaterijalaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.prikazMaterijalaToolStripMenuItem.Text = "Prikaz materijala";
            this.prikazMaterijalaToolStripMenuItem.Click += new System.EventHandler(this.prikazMaterijalaToolStripMenuItem_Click);
            // 
            // dodajMaterijalToolStripMenuItem
            // 
            this.dodajMaterijalToolStripMenuItem.Name = "dodajMaterijalToolStripMenuItem";
            this.dodajMaterijalToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dodajMaterijalToolStripMenuItem.Text = "Dodaj materijal";
            this.dodajMaterijalToolStripMenuItem.Click += new System.EventHandler(this.dodajMaterijalToolStripMenuItem_Click);
            // 
            // jedinicaMjereToolStripMenuItem
            // 
            this.jedinicaMjereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikazJedinicaMjereToolStripMenuItem,
            this.dodajJedinicuMjereToolStripMenuItem});
            this.jedinicaMjereToolStripMenuItem.Name = "jedinicaMjereToolStripMenuItem";
            this.jedinicaMjereToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.jedinicaMjereToolStripMenuItem.Text = "Jedinica mjere";
            // 
            // prikazJedinicaMjereToolStripMenuItem
            // 
            this.prikazJedinicaMjereToolStripMenuItem.Name = "prikazJedinicaMjereToolStripMenuItem";
            this.prikazJedinicaMjereToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.prikazJedinicaMjereToolStripMenuItem.Text = "Prikaz jedinica mjere";
            this.prikazJedinicaMjereToolStripMenuItem.Click += new System.EventHandler(this.prikazJedinicaMjereToolStripMenuItem_Click);
            // 
            // dodajJedinicuMjereToolStripMenuItem
            // 
            this.dodajJedinicuMjereToolStripMenuItem.Name = "dodajJedinicuMjereToolStripMenuItem";
            this.dodajJedinicuMjereToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.dodajJedinicuMjereToolStripMenuItem.Text = "Dodaj jedinicu mjere";
            this.dodajJedinicuMjereToolStripMenuItem.Click += new System.EventHandler(this.dodajJedinicuMjereToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            this.izvještajiToolStripMenuItem.Click += new System.EventHandler(this.izvještajiToolStripMenuItem_Click);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.pomoćToolStripMenuItem_Click);
            // 
            // oNamaToolStripMenuItem
            // 
            this.oNamaToolStripMenuItem.Name = "oNamaToolStripMenuItem";
            this.oNamaToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.oNamaToolStripMenuItem.Text = "O nama";
            this.oNamaToolStripMenuItem.Click += new System.EventHandler(this.oNamaToolStripMenuItem_Click);
            // 
            // FormAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 556);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baustelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ponudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poslovnaPravilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materijaliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazMaterijalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajMaterijalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazKlijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazPonudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPonudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazUslugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUsluguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedinicaMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisZaposlenikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazJedinicaMjereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajJedinicuMjereToolStripMenuItem;

    }
}

