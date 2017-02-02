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
    public partial class frmDodajMaterijal : Form
    {
        public frmDodajMaterijal()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        ///  Ova metoda puni podatke u DataSet koji se koristi da prikaze jedinicu mjere u combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDodajMaterijal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.JedinicaMjereSet' table. You can move, or remove it, as needed.
            this.jedinicaMjereSetTableAdapter.Fill(this.baustelleDBDataSet2.JedinicaMjereSet);

        }
        /// <summary>
        /// Metoda koja se pokreće na klik gumba Spremi, i sprema unesene podatke za materijal u bazu podataka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {

            if (txtNaziv.Text.Length != 0)
            {
                using (var db = new BaustelleDBEntities())
                {
                    MaterijalSet materijal = new MaterijalSet
                    {
                        Naziv = txtNaziv.Text,
                        Napomena = txtNapomena.Text,
                        JedinicaMjereId = int.Parse(cmbJedinicaMjere.SelectedValue.ToString())
                    };
                    db.MaterijalSet.Add(materijal);
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
    }
}
