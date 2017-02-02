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
    public partial class frmZaposlenici : Form
    {
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        OsvjeziTablicu osvjezi = new OsvjeziTablicu();

        private void frmZaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UlogaSet' table. You can move, or remove it, as needed.
            this.ulogaSetTableAdapter.Fill(this.baustelleDBDataSet2.UlogaSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            zaspolenikSetBindingSource.DataSource = osvjezi.PrikaziZaposlenika();

        }


        /// <summary>
        /// Na dupli klik ćelije otvaramo detalje odabranog zaposlenika u novoj formu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKlijenti_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmDetaljiZaposlenika zaposlenici = new frmDetaljiZaposlenika(zaspolenikSetBindingSource.Current as ZaspolenikSet);
            zaposlenici.ShowDialog();
            zaspolenikSetBindingSource.DataSource = osvjezi.PrikaziZaposlenika();
        }

        /// <summary>
        /// event koji gasi formu Zaposlenika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
