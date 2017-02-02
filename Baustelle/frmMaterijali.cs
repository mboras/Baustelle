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
    public partial class frmMaterijali : Form
    {
        public frmMaterijali()
        {
            InitializeComponent();
        }

        OsvjeziTablicu osvjezi = new OsvjeziTablicu();
        /// <summary>
        /// Metoda koja se pokreće na klik na sliku i otvara formu za dodavanje novog materijala
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmDodajMaterijal dodajMaterijal = new frmDodajMaterijal();
            
            dodajMaterijal.ShowDialog();
            materijalSetBindingSource.DataSource = osvjezi.PrikaziMaterijal();
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
        private void frmMaterijali_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.JedinicaMjereSet' table. You can move, or remove it, as needed.
            this.jedinicaMjereSetTableAdapter.Fill(this.baustelleDBDataSet2.JedinicaMjereSet);
            materijalSetBindingSource.DataSource = osvjezi.PrikaziMaterijal();
        }


        
       /// <summary>
       /// Metoda koje se pokreće na dvostruki klik miša na određeni redak u data grid view-u. Otvara detalje o određenom materijalu
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void dgvMaterijali_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            MaterijalSet odabraniMaterijal = materijalSetBindingSource.Current as MaterijalSet;
            if (odabraniMaterijal!=null)
	        {
		        frmDetaljiMaterijala materijal = new frmDetaljiMaterijala(odabraniMaterijal);
                materijal.ShowDialog();
                materijalSetBindingSource.DataSource = osvjezi.PrikaziMaterijal();
	        }
            
        }
    }
}
