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
    public partial class frmDetaljiOUsluzi : Form
    {
        private UslugaSet odabranaUsluga;

        public frmDetaljiOUsluzi()
        {
            InitializeComponent();
        }
        public frmDetaljiOUsluzi(UslugaSet usluga)
        {
            InitializeComponent();
            odabranaUsluga = usluga;
        }

        /// <summary>
        /// Click event koji gasi formu Detalja Usluge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load event koji puni podatke o odabranoj Usluzi u formi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDetaljiOUsluzi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UslugaSet' table. You can move, or remove it, as needed.
            this.uslugaSetTableAdapter.Fill(this.baustelleDBDataSet2.UslugaSet);

            txtNaziv.Focus();

            if (odabranaUsluga != null)
            {
                txtCijena.Text = odabranaUsluga.Cijena.ToString();
                txtNaziv.Text = odabranaUsluga.Naziv;
                cmbZaposlenik.SelectedValue = odabranaUsluga.ZaposlenikId;
                txtDatum.Text = odabranaUsluga.DatumKreiranja.ToString();
            }
        }

        /// <summary>
        /// Click event koji sprema promjene na Usluzi, te provjerava da li su sva polja unesena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new BaustelleDBEntities())
            {
                try
                {
                    if (txtNaziv.Text.Length != 0)
                    {

                        db.UslugaSet.Attach(odabranaUsluga);
                        odabranaUsluga.Naziv = txtNaziv.Text;
                        odabranaUsluga.Cijena = int.Parse(txtCijena.Text);
                        odabranaUsluga.DatumKreiranja = DateTime.Now;
                        odabranaUsluga.ZaposlenikId = (int)cmbZaposlenik.SelectedValue;
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Popunite sva polja! ", " Upozorenje! ");
                        txtNaziv.Focus();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Popunite sva polja! ", " Upozorenje! ");
                    txtCijena.Clear();
                    txtCijena.Focus();
                }
            }
        }
    }
}

