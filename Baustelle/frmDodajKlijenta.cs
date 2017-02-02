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
    public partial class frmDodajKlijenta : Form
    {
        public frmDodajKlijenta()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Metoda koja se pokrece pritiskom na gumb Spremi, i sprema unesene podatke za klijenta u bazu podataka.
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


                    KlijentSet klijent = new KlijentSet
                    {
                        Naziv = txtNaziv.Text,
                        OIB = txtOIB.Text,
                        Adresa = txtAdresaStanovanja.Text,
                        Telefon = txtKontaktTelefon.Text,
                        Email = txtEmail.Text
                    };
                    db.KlijentSet.Add(klijent);
                    db.SaveChanges();
                }
                Close();
            }

           
            
        }

       
    }
}
