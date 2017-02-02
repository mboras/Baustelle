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
    public partial class frmNovaStavkaPonude : Form
    {
        private PonudaSet odabranaPonuda;
        /// <summary>
        /// Konstruktor koji proslijeđuje odabranu ponudu koja se veže sa stavkom ponude
        /// </summary>
        /// <param name="ponuda"></param>
        public frmNovaStavkaPonude(PonudaSet ponuda)
        {
            InitializeComponent();
            odabranaPonuda = ponuda;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metoda koja se pokreće na klik gumba Spremi i sprema unesene podatke u bazu podataka.
        /// Provjerava postoji li određena stavka vezana na tu ponudu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {

            try
            {

                BindingList<StavkaPonudeSet> stavkaPonude = null;

                using (var db = new BaustelleDBEntities())
                {
                    db.PonudaSet.Attach(odabranaPonuda);
                    stavkaPonude = new BindingList<StavkaPonudeSet>(odabranaPonuda.StavkaPonudeSet.ToList());
                    bool nadjeno = false;

                    foreach (StavkaPonudeSet s in stavkaPonude)
                    {
                        if (s.UslugaId == (int)cmbUsluga.SelectedValue)
                        {
                            nadjeno = true;
                        }
                    }

                    if (nadjeno == true)
                    {
                        MessageBox.Show("Usluga već postoji na ponudi! ", "Upozorenje! ");
                    }

                    else
                    {
                        StavkaPonudeSet stavka = new StavkaPonudeSet
                        {
                            UslugaId = (int)cmbUsluga.SelectedValue,
                            Kolicina = decimal.Parse(txtKolicina.Text),
                            PonudaSet = odabranaPonuda
                        };
                        db.StavkaPonudeSet.Add(stavka);
                        db.SaveChanges();
                        this.Close();
                    }
                   

                }
               
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Popunite sva polja! ", " Upozorenje!");
                txtKolicina.Focus();
            }






        }

        private void frmNovaStavkaPonude_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.StavkaPonudeSet' table. You can move, or remove it, as needed.
            this.stavkaPonudeSetTableAdapter.Fill(this.baustelleDBDataSet2.StavkaPonudeSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UslugaSet' table. You can move, or remove it, as needed.
            this.uslugaSetTableAdapter.Fill(this.baustelleDBDataSet2.UslugaSet);

        }
    }
}
