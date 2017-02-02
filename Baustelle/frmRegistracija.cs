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
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event unos podataka novog korisnika
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

                    }
                    else
                    {
                        popunjeno = false;
                        // ako je polje prazno
                    }
                }
            }

            if (popunjeno == false) //ako je neko od polja postavilo na popunjeno na false znaci da je ostalo prazno pa se pokazuje prozor s upozorenjem
            {
                MessageBox.Show("Popunite sva polja! ", " Upozorenje!");
                txtIme.Focus();
            }
            else // ako su sva polja popunjena onda registrira korisnika
            {
                using (var db = new BaustelleDBEntities())
                {
                    ZaspolenikSet zaposlenik = new ZaspolenikSet
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        OIB = txtOIB.Text,
                        Adresa = txtAdresa.Text,
                        Kontakt = txtKontakt.Text,
                        Email = txtEmail.Text,
                        Username = txtUsername.Text,
                        Password = txtPasssword.Text,
                        DatumRodjenja = dtpDatum.Value,
                        UlogaId = 2
                    };
                    db.ZaspolenikSet.Add(zaposlenik);
                    db.SaveChanges();
                }
                Close();
            }
        }


        private void txtPasssword_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
