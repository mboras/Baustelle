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
    public partial class frmKlijenti : Form
    {
        public frmKlijenti()
        {
            InitializeComponent();
        }

        OsvjeziTablicu osvjezi = new OsvjeziTablicu();
        
        /// <summary>
        /// Metoda koja se pokreće na klik na sliku i otvara formu za dodavanje novog klijenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDodajKlijenta dodajKlijenta = new frmDodajKlijenta();
            
            dodajKlijenta.ShowDialog();
            klijentSetBindingSource.DataSource = osvjezi.PrikaziKlijente();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Metoda koja se pokreće pri otvaranju forme i puni dataset-ove s podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmKlijenti_Load(object sender, EventArgs e)
        {
            klijentSetBindingSource.DataSource = osvjezi.PrikaziKlijente();

        }

        /// <summary>
        /// Metoda koje se pokreće na dvostruki klik miša na određeni redak u data grid view-u. Otvara detalje o određenom klijentu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKlijenti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmDetaljiKlijenta detaljiKlijenta = new frmDetaljiKlijenta(klijentSetBindingSource.Current as KlijentSet);
            detaljiKlijenta.ShowDialog();
            klijentSetBindingSource.DataSource = osvjezi.PrikaziKlijente();
        }
    }
}
