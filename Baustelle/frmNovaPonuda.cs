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
    public partial class frmNovaPonuda : Form
    {
        public frmNovaPonuda()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        /// <summary>
        /// Metoda koja se pokreće na klik gumba Spremi i sprema unesene podatke u bazu podataka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new BaustelleDBEntities())
            {
                PonudaSet ponuda = new PonudaSet 
                {
                    ZaposlenikId = (int)cmbZaposlenik.SelectedValue,
                    KlijentId = (int)cmbKlijent.SelectedValue,
                    Napomena = txtNapomena.Text,
                    DatumIzdavanja = DateTime.Now
                };
                db.PonudaSet.Add(ponuda);
                db.SaveChanges();
            }
            Close();
        }


        /// <summary>
        /// Metoda koja se pokreće prilikom otvaranja forme i puni datasetove potrebnim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNovaPonuda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.PonudaSet' table. You can move, or remove it, as needed.
            this.ponudaSetTableAdapter.Fill(this.baustelleDBDataSet2.PonudaSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.KlijentSet' table. You can move, or remove it, as needed.
            this.klijentSetTableAdapter.Fill(this.baustelleDBDataSet2.KlijentSet);

        }

        
    }
}
