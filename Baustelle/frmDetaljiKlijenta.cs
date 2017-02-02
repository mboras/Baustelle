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
    public partial class frmDetaljiKlijenta : Form
    {

        private KlijentSet klijentZaIzmjenu;
        /// <summary>
        /// Konstruktor koji prima prametar klijent
        /// </summary>
        /// <param name="klijent"></param>
        public frmDetaljiKlijenta(KlijentSet klijent)
        {
            InitializeComponent();
            klijentZaIzmjenu = klijent;
        }


        /// <summary>
        /// Metoda koja koja se izvršava pri učitavanju detalja klijnata i puni formu podacima o odabranom klijentu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDetaljiKlijenta_Load(object sender, EventArgs e)
        {
            if (klijentZaIzmjenu != null)
            {
                txtNaziv.Text = klijentZaIzmjenu.Naziv;
                txtAdresaStanovanja.Text = klijentZaIzmjenu.Adresa;
                txtEmail.Text = klijentZaIzmjenu.Email;
                txtOIB.Text = klijentZaIzmjenu.OIB;
                txtKontaktTelefon.Text = klijentZaIzmjenu.Telefon;
            }
        }

        /// <summary>
        /// Metoda koja se izvršava na klik na gumbu Izmjeni i izmjenjuje odabrane podatke u bazi podataka o odabranom klijentu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmjeni_Click(object sender, EventArgs e)
        {

            bool popunjeno = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text != string.Empty)
                    {
                        popunjeno = true;
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
                
            }
            else
            {
                using (var db = new BaustelleDBEntities())
                {
                    db.KlijentSet.Attach(klijentZaIzmjenu);
                    klijentZaIzmjenu.Naziv = txtNaziv.Text;
                    klijentZaIzmjenu.OIB = txtOIB.Text;
                    klijentZaIzmjenu.Telefon = txtKontaktTelefon.Text;
                    klijentZaIzmjenu.Adresa = txtAdresaStanovanja.Text;
                    klijentZaIzmjenu.Email = txtEmail.Text;
                    db.SaveChanges();
                }
                Close();
            }       
        }

        /// <summary>
        /// Metoda koja se izvršava na klik na gumbu Obriši i briše odabranog klijenta iz baze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (klijentZaIzmjenu != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new BaustelleDBEntities())
                    {
                        try
                        {
                            db.KlijentSet.Attach(klijentZaIzmjenu);
                            db.KlijentSet.Remove(klijentZaIzmjenu);
                            db.SaveChanges();
                            this.Close();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException)
                        {
                            MessageBox.Show("Klijenta nije moguće brisati jer se koristi na drugome mjestu!");
                        }
                    }
                }
            }
            
        }

        /// <summary>
        /// Metoda koja se pokreće klikom na gumb Odustani i zatvara  formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
