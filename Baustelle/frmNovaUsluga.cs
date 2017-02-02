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
    public partial class frmNovaUsluga : Form
    {
        public frmNovaUsluga()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load event koji puni određene Datasetove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNovaUsluga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UslugaSet' table. You can move, or remove it, as needed.
            this.uslugaSetTableAdapter.Fill(this.baustelleDBDataSet2.UslugaSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.StavkaUslugeSet' table. You can move, or remove it, as needed.
            this.stavkaUslugeSetTableAdapter.Fill(this.baustelleDBDataSet2.StavkaUslugeSet);
        }

        /// <summary>
        /// Click event koji sprema novu Uslugu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new BaustelleDBEntities())
            {
                try
                {
                    if (txtNaziv.Text.Length != 0) // Provjerava se da li su sva polja popunjena
                    {
                        UslugaSet usluga = new UslugaSet
                        {
                            Naziv = txtNaziv.Text,
                            Cijena = decimal.Parse(txtCijena.Text),
                            ZaposlenikId = (int)cmbZaposlenik.SelectedValue,
                            DatumKreiranja = DateTime.Now
                        };

                        db.UslugaSet.Add(usluga);
                        db.SaveChanges();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Popunite sva polja!", " Upozorenje! ");
                        txtNaziv.Focus();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Popunite sva polja!", " Upozorenje! ");
                    txtCijena.Clear();
                    txtCijena.Focus();
                }
            }
        }
    }
}
