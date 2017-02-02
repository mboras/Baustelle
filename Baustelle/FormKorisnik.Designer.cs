namespace Baustelle
{
    partial class FormKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKorisnik));
            this.ponudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponudeToolStripMenuItem,
            this.pomoćToolStripMenuItem,
            this.oNamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1543, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(1096, 435);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 4;
            // 
            // FormKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 830);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormKorisnik";
            this.Text = "Baustelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem ponudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazPonudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPonudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNamaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblInfo;

    }
}