using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baustelle
{
    public partial class FormAdministrator : Form
    {
        ProvjeraLogina pr = new ProvjeraLogina();

        public FormAdministrator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja pritiskom tipke f1 na tipkovnici poziva statičku metodu koja otvara pdf korisničke dokumentacije
        /// u korisnikovom web pregledniku
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                F1.pomoc();
                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // <summary>
        /// Metoda koja otvara formu za prikaz materijala s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prikazMaterijalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterijali materijali = new frmMaterijali();
            materijali.MdiParent = this;
            materijali.Show();
        }
        // <summary>
        /// Metoda koja otvara formu za dodavanje materijala 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajMaterijalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajMaterijal dodajMaterijal = new frmDodajMaterijal();
            dodajMaterijal.MdiParent = this;
            dodajMaterijal.Show();
        }

        // <summary>
        /// Metoda koja otvara formu za dodavanje klijenta 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajKlijenta dodajKlijenta = new frmDodajKlijenta();
            dodajKlijenta.ShowDialog();
        }

        // <summary>
        /// Metoda koja otvara formu za prikaz materijala s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prikazKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKlijenti klijenti = new frmKlijenti();
            klijenti.MdiParent = this;  
            klijenti.Show();
        }

        // <summary>
        /// Metoda koja otvara formu za prikaz ponuda i stavka ponuda s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prikazPonudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPonude ponuda = new frmPonude();
            ponuda.MdiParent = this;
            ponuda.Show();
        }
        // <summary>
        /// Metoda koja otvara formu za dodavanje nove ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void novaPonudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaPonuda nPonuda = new frmNovaPonuda();       
            nPonuda.ShowDialog();
        }

        // <summary>
        /// Metoda koja otvara formu o nama, na kojoj senalaze podaci o timu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oNamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnama oNama = new frmOnama();
            oNama.MdiParent = this;
            oNama.Show();
        }

        // <summary>
        /// Metoda koja otvara formu za prikaz usluga i stavka usluga s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prikazUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsluge usluge = new frmUsluge();
            usluge.MdiParent = this;
            usluge.Show();
        }

        // <summary>
        /// Metoda koja otvara formu za dodavanje nove usluge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajUsluguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaUsluga novaUsluga = new frmNovaUsluga();
            novaUsluga.MdiParent = this;
            novaUsluga.Show();
        }

        // <summary>
        /// Metoda koja otvara formu za prikaz jedinica mjere s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jedinicaMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJedinicaMjere jedinicaMjere = new frmJedinicaMjere();
            jedinicaMjere.MdiParent = this;
            jedinicaMjere.Show();
        }

        // <summary>
        /// Metoda koja otvara formu za prikaz zaposlenika s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void popisZaposlenikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZaposlenici zaposlenici = new frmZaposlenici();
            zaposlenici.MdiParent = this;
            zaposlenici.Show();
        }


        // <summary>
        /// Metoda koja otvara formu sa izvještajima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void izvještajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzvjestaj izvjestaj = new frmIzvjestaj();
            izvjestaj.MdiParent = this;
            izvjestaj.Show();

        }

        // <summary>
        /// Metoda koja otvara formu za dodavanje nove jedinice mjere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dodajJedinicuMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajJedinicuMjere dodajJedinicuMjere = new frmDodajJedinicuMjere();
            dodajJedinicuMjere.ShowDialog();
        }

        // <summary>
        /// Metoda koja otvara formu za prikaz svih jedinica mjera s CRUD mogućnostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void prikazJedinicaMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJedinicaMjere jedinicaMjere = new frmJedinicaMjere();
            jedinicaMjere.MdiParent = this;
            jedinicaMjere.Show();
        }

       
        /// <summary>
        /// Metoda koja na odabir opcije za pomoć otvara online PDF dokument s korisničkom dokumentacijom aplikacije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F1.pomoc();
        }
    }
}
