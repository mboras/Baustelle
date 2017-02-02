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
    public partial class frmDetaljiZaposlenika : Form
    {
        private ZaspolenikSet zaposlenikZaIzmjenu;
        /// <summary>
        /// Konstruktor koji proslijeđuje odabranog zaposlenika za prikaz na formi
        /// </summary>
        /// <param name="zaposlenik"></param>
        public frmDetaljiZaposlenika(ZaspolenikSet zaposlenik)
        {
            InitializeComponent();
            zaposlenikZaIzmjenu = zaposlenik;
        }

        OsvjeziTablicu osvjezi = new OsvjeziTablicu();


        /// <summary>
        /// Metoda koja se pokreće prilikom otvaranja forme. Puni dataset-ove podacima kao i potrebne kontrole.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDetaljiZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UlogaSet' table. You can move, or remove it, as needed.
            this.ulogaSetTableAdapter.Fill(this.baustelleDBDataSet2.UlogaSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            {
                if (zaposlenikZaIzmjenu != null)
                {
                    txtIme.Text = zaposlenikZaIzmjenu.Ime;
                    txtPrezime.Text = zaposlenikZaIzmjenu.Prezime;
                    txtAdresa.Text = zaposlenikZaIzmjenu.Adresa;
                    txtEmail.Text = zaposlenikZaIzmjenu.Email;
                    txtKontakt.Text = zaposlenikZaIzmjenu.Kontakt;
                    txtOIB.Text = zaposlenikZaIzmjenu.OIB;
                    txtPasssword.Text = zaposlenikZaIzmjenu.Password;
                    txtUsername.Text = zaposlenikZaIzmjenu.Username;
                    txtDatum.Text = zaposlenikZaIzmjenu.DatumRodjenja.ToString();
                }
            }
        }

        /// <summary>
        /// Metoda koja se pokreće pritiskom na gumb izmijeni i koja sprema unesene podatke u bazu.
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
                    }
                }
            }

            if (popunjeno == false)
            {
                MessageBox.Show("Popunite sva polja! ", " Upozorenje!");
                txtIme.Focus();
            }
            else
            {
                using (var db = new BaustelleDBEntities())
                {
                    db.ZaspolenikSet.Attach(zaposlenikZaIzmjenu);
                    zaposlenikZaIzmjenu.Ime = txtIme.Text;
                    zaposlenikZaIzmjenu.Prezime = txtPrezime.Text;
                    zaposlenikZaIzmjenu.Adresa = txtAdresa.Text;
                    zaposlenikZaIzmjenu.Email = txtEmail.Text;
                    zaposlenikZaIzmjenu.Kontakt = txtKontakt.Text;
                    zaposlenikZaIzmjenu.OIB = txtOIB.Text;
                    zaposlenikZaIzmjenu.Password = txtPasssword.Text;
                    zaposlenikZaIzmjenu.Username = txtUsername.Text;
                    zaposlenikZaIzmjenu.UlogaId = (int)cmbUloga.SelectedValue;
                    db.SaveChanges();
                    zaspolenikSetBindingSource.DataSource = osvjezi.PrikaziZaposlenika();
                }
                Close();
            }
            
        }


        /// <summary>
        /// Metoda koja se pokreće klikom na gumb izbriši, i briše odabranog zaposlenika iz baze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (zaposlenikZaIzmjenu != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                               
                    using (var db = new BaustelleDBEntities())
                    {
                        try 
	                    {	  
		                    db.ZaspolenikSet.Attach(zaposlenikZaIzmjenu);
                            db.ZaspolenikSet.Remove(zaposlenikZaIzmjenu);
                            db.SaveChanges();
                            zaspolenikSetBindingSource.DataSource = osvjezi.PrikaziZaposlenika();
	                    }
	                    catch (System.Data.Entity.Infrastructure.DbUpdateException)
	                    {
		                    MessageBox.Show("Zaposlenika nije moguće obrisati!!!", " Upozorenje! ");

	                    }       
                    }
                }
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
