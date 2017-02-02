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
    public partial class frmJedinicaMjere : Form
    {
        public frmJedinicaMjere()
        {
            InitializeComponent();
        }

        OsvjeziTablicu osvjezi = new OsvjeziTablicu();
        

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja poziva otvaranje nove forme za unos jedinice mjere 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctPlus_Click(object sender, EventArgs e)
        {
            frmDodajJedinicuMjere dodajJedinicuMjere = new frmDodajJedinicuMjere();
       
            dodajJedinicuMjere.ShowDialog();
            jedinicaMjereSetBindingSource.DataSource = osvjezi.PrikaziJediniceMjere();    
        }
        /// <summary>
        /// Metoda koja se pokreće na otvaranju forme i u kojoj punimo dataset-ove s potrebnim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmJedinicaMjere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.JedinicaMjereSet' table. You can move, or remove it, as needed.
            this.jedinicaMjereSetTableAdapter.Fill(this.baustelleDBDataSet2.JedinicaMjereSet);
            jedinicaMjereSetBindingSource.DataSource = osvjezi.PrikaziJediniceMjere();  
            
        }
        /// <summary>
        /// Metoda koje se pokreće na dvostruki klik miša na određeni redak u data grid view-u. Otvara detalje o određenoj jedinici mjere.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKlijenti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            JedinicaMjereSet odabranajedinicaMjere = jedinicaMjereSetBindingSource.Current as JedinicaMjereSet;
            if(odabranajedinicaMjere != null)
            {
                frmDetaljiJedinicaMjere detealjiOJediniciMjere = new frmDetaljiJedinicaMjere(odabranajedinicaMjere);
                detealjiOJediniciMjere.ShowDialog();

                jedinicaMjereSetBindingSource.DataSource = osvjezi.PrikaziJediniceMjere();  
            }
        }
    }
}
