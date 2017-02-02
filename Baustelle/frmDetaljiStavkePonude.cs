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
    public partial class frmDetaljiStavkePonude : Form
    {
        private StavkaPonudeSet odabranaStavka;
        public frmDetaljiStavkePonude(StavkaPonudeSet stavka)
        {
            InitializeComponent();
            odabranaStavka = stavka;
        }

        /// <summary>
        /// Load event koji određene Datasetove puni podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetaljiStavkePonude_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.StavkaPonudeSet' table. You can move, or remove it, as needed.
            this.stavkaPonudeSetTableAdapter.Fill(this.baustelleDBDataSet2.StavkaPonudeSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UslugaSet' table. You can move, or remove it, as needed.
            this.uslugaSetTableAdapter.Fill(this.baustelleDBDataSet2.UslugaSet);

            try
            {
                txtKolicina.Text = odabranaStavka.Kolicina.ToString();
                cmbUsluga.SelectedValue = odabranaStavka.UslugaId;
            }
            catch (Exception)
            {
                MessageBox.Show("Nije odabrana stavka za izmjenu");
            } 
        }

        /// <summary>
        /// Click event koji sprema promjenjene podatke o Stavci Ponude, te provjerava da li su sva polja popunjena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaustelleDBEntities())
                {
                    db.StavkaPonudeSet.Attach(odabranaStavka);

                    odabranaStavka.Kolicina = decimal.Parse(txtKolicina.Text);
                    odabranaStavka.UslugaId = (int)cmbUsluga.SelectedValue;

                    db.SaveChanges();
                }
                this.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Popunite sva polja! ", " Upozorenje!");
                txtKolicina.Focus();
            } 
        }

        /// <summary>
        /// Click event koji gasi formu Detalja Stavki Ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
