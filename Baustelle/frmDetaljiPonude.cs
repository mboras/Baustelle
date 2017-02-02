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
    public partial class frmDetaljiPonude : Form
    {
        PonudaSet ponudaZaIzmjenu;
        public frmDetaljiPonude(PonudaSet ponuda)
        {
            InitializeComponent();
            ponudaZaIzmjenu = ponuda;
        }

        /// <summary>
        /// Load event koji puni određene Datasetove podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetaljiPonude_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.PonudaSet' table. You can move, or remove it, as needed.
            this.ponudaSetTableAdapter.Fill(this.baustelleDBDataSet2.PonudaSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.KlijentSet' table. You can move, or remove it, as needed.
            this.klijentSetTableAdapter.Fill(this.baustelleDBDataSet2.KlijentSet);
            txtNapomena.Text = ponudaZaIzmjenu.Napomena;
            cmbKlijent.SelectedValue = ponudaZaIzmjenu.KlijentId;
            cmbZaposlenik.SelectedValue = ponudaZaIzmjenu.ZaposlenikId;
        }

        /// <summary>
        /// Click event koji gasi formu Detalji Ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click event koji sprema nove promjene na Ponudi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new BaustelleDBEntities())
            {
                if (ponudaZaIzmjenu!=null)
                {
                    db.PonudaSet.Attach(ponudaZaIzmjenu);
                    ponudaZaIzmjenu.ZaposlenikId = (int)cmbZaposlenik.SelectedValue;
                    ponudaZaIzmjenu.KlijentId = (int)cmbKlijent.SelectedValue;
                    ponudaZaIzmjenu.Napomena = txtNapomena.Text;
                    db.SaveChanges();
                }
            }
            Close();
        }
    }
}
