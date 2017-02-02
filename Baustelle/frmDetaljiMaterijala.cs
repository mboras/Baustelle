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
    public partial class frmDetaljiMaterijala : Form
    {

 
        private MaterijalSet materijalZaIzmjenu;

        /// <summary>
        /// Konstruktor koji prima paramater materijli tipa MaterijalSet
        /// </summary>
        /// <param name="materijal"></param>
        public frmDetaljiMaterijala(MaterijalSet materijal)
        {
            InitializeComponent();
            materijalZaIzmjenu = materijal;
        }

        /// <summary>
        /// Metoda koja se izvršava pri učitvanju forme o detalju odabranog materijala i puni ga odabranim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDetaljiMaterijala_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.MaterijalSet' table. You can move, or remove it, as needed.
            this.materijalSetTableAdapter.Fill(this.baustelleDBDataSet2.MaterijalSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.JedinicaMjereSet' table. You can move, or remove it, as needed.
            this.jedinicaMjereSetTableAdapter.Fill(this.baustelleDBDataSet2.JedinicaMjereSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.MaterijalSet' table. You can move, or remove it, as needed.
            this.materijalSetTableAdapter.Fill(this.baustelleDBDataSet2.MaterijalSet);
            if (materijalZaIzmjenu != null)
            {
                //txtId.Text = materijalZaIzmjenu.IdMaterijal.ToString();
                txtNapomena.Text = materijalZaIzmjenu.Napomena;
                txtNaziv.Text = materijalZaIzmjenu.Naziv;
                cmbJedinicaMjere.SelectedValue = materijalZaIzmjenu.JedinicaMjereId;
            }
        }

        /// <summary>
        /// Metoda koja se izvršva prilikom klika na gumb Izmjeni i izmjenjuje odabrane podatke o Materijalu u bazi podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text.Length  != 0)
            {
                using (var db = new BaustelleDBEntities())
                {
                    db.MaterijalSet.Attach(materijalZaIzmjenu);

                    materijalZaIzmjenu.Naziv = txtNaziv.Text;
                    materijalZaIzmjenu.Napomena = txtNapomena.Text;
                    materijalZaIzmjenu.JedinicaMjereId = int.Parse(cmbJedinicaMjere.SelectedValue.ToString());

                    db.SaveChanges();

                }
                Close();
            }
            else
            {
                MessageBox.Show("Popunite sva polja! ", " Upozorenje!");
                txtNaziv.Focus();
            }                                             
        }

        /// <summary>
        /// Metoda koja se izvršava prilikom klika na gumb Obriši i briše odabrani materijala iz baze podataka ukoluko se isti ne koristi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (materijalZaIzmjenu != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new BaustelleDBEntities())
                    {
                        try
                        {
                            db.MaterijalSet.Attach(materijalZaIzmjenu);
                            db.MaterijalSet.Remove(materijalZaIzmjenu);
                            db.SaveChanges();
                            this.Close();
                        }
                        catch (System.Data.Entity.Infrastructure.DbUpdateException)
                        {
                            MessageBox.Show("Materijal nije moguće brisati jer se koristi na drugome mjestu!");
                        }
                    }
                }
            }
           
        }

        /// <summary>
        /// Metoda koja se izvršava prilikom klika na gumb Odustani i zatvara aplikaciju 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
