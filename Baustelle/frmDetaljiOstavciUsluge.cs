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
    public partial class frmDetaljiOstavciUsluge : Form
    {
        private StavkaUslugeSet stavkaZaIzmjenu;

        public frmDetaljiOstavciUsluge()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktorkoji prima prametar StavkaUsluge tipa StavkaUslugeSet
        /// </summary>
        /// <param name="stavkaUsluge"></param>
        public frmDetaljiOstavciUsluge(StavkaUslugeSet stavkaUsluge)
        {
            stavkaZaIzmjenu = stavkaUsluge;
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koja se izvršava prilkom učitavanja forme Detalji o stavci usluge i puni formu podacima o odabranoj usluzi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDetaljiOstavciUsluge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.StavkaUslugeSet' table. You can move, or remove it, as needed.
            this.stavkaUslugeSetTableAdapter.Fill(this.baustelleDBDataSet2.StavkaUslugeSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.MaterijalSet' table. You can move, or remove it, as needed.
            this.materijalSetTableAdapter.Fill(this.baustelleDBDataSet2.MaterijalSet);

            if (stavkaZaIzmjenu != null)
            {
                txtKolicina.Text = stavkaZaIzmjenu.Kolicina.ToString();
                cmbMaterijal.SelectedValue = stavkaZaIzmjenu.MaterijalId;
            }
        }

        /// <summary>
        /// Metoda koja se izvršava prilikom klika na gumb Spremi i sprema izmjenjene podatke o stavci usluge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BaustelleDBEntities())
                {
                    db.StavkaUslugeSet.Attach(stavkaZaIzmjenu);

                    stavkaZaIzmjenu.MaterijalId = (int)cmbMaterijal.SelectedValue;
                    stavkaZaIzmjenu.Kolicina = decimal.Parse(txtKolicina.Text);

                    db.SaveChanges();
                }
                this.Close();
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Popunite sva polja! ", " Upozorenje! ");
                txtKolicina.Focus();
            }

        }

        /// <summary>
        /// Metoda koja se izvršava prilikom klika na gumb Odustani i zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
