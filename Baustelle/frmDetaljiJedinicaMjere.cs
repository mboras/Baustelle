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
    public partial class frmDetaljiJedinicaMjere : Form
    {
        private JedinicaMjereSet jedinicaZaIzmjenu;

        public frmDetaljiJedinicaMjere()
        {
            InitializeComponent();
        }

        // <summary>
        /// Konstruktor koji prima paramter jedinica mjere
        /// </summary>      
        /// <param name="jedincaMjere"> </param>

        public frmDetaljiJedinicaMjere(JedinicaMjereSet jedinicaMjere)
        {
            InitializeComponent();
            jedinicaZaIzmjenu = jedinicaMjere;
        }

        /// <summary>
        /// Metoda koja otvara formu sa detaljima jedinice mjere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDetaljiJedinicaMjere_Load(object sender, EventArgs e)
        {
            if (jedinicaZaIzmjenu != null)
            {
                txtNaziv.Text = jedinicaZaIzmjenu.Naziv;
                txtSkraceniNaziv.Text = jedinicaZaIzmjenu.SkraceniNaziv;

            }
        }
        /// <summary>
        ///  Metoda koja zatvara formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda koja se pokreće na klik gumba Spremi i sprema unesene podatke u bazu podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {

            bool popunjeno = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text != string.Empty)
                    {

                    }
                    else
                    {
                        popunjeno = false;
                    }
                }
            }

            if (popunjeno == false)
            {
                MessageBox.Show("Popunite sva polja! ", " Upozorenje!");
                txtNaziv.Focus();
            }
            else
            {
                using (var db = new BaustelleDBEntities())
                {


                    db.JedinicaMjereSet.Attach(jedinicaZaIzmjenu);

                    jedinicaZaIzmjenu.Naziv = txtNaziv.Text;
                    jedinicaZaIzmjenu.SkraceniNaziv = txtSkraceniNaziv.Text;
                    db.SaveChanges();


                }

                this.Close();
            }
        }


        

        /// <summary>
        /// Metoda koja se pokreće na klik gumba Obriši i briše odabrane podatke iz baze podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new BaustelleDBEntities())
                    {
                        db.JedinicaMjereSet.Attach(jedinicaZaIzmjenu);
                        db.JedinicaMjereSet.Remove(jedinicaZaIzmjenu);
                        db.SaveChanges();

                        this.Close();

                    }

                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("Materijal nije moguće brisati jer se koristi na drugome mjestu!", " Upozorenje! ");
            }

        }
    }

}
