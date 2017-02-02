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
    public partial class FormKorisnik : Form
    {

        public FormKorisnik()
        {
            InitializeComponent();
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
            nPonuda.MdiParent = this;
            nPonuda.Show();
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
