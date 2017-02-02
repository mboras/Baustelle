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
    public partial class frmIzvjestaj : Form
    {
        public frmIzvjestaj()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda load pokreće se pri otvaranju forme i puni dataset-ove s podacim koji se koriste za prikaz na report-u.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.StavkaUslugeSet' table. You can move, or remove it, as needed.
            this.stavkaUslugeSetTableAdapter.Fill(this.baustelleDBDataSet2.StavkaUslugeSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.JedinicaMjereSet' table. You can move, or remove it, as needed.
            this.jedinicaMjereSetTableAdapter.Fill(this.baustelleDBDataSet2.JedinicaMjereSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.MaterijalSet' table. You can move, or remove it, as needed.
            this.materijalSetTableAdapter.Fill(this.baustelleDBDataSet2.MaterijalSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.KlijentSet' table. You can move, or remove it, as needed.
            this.klijentSetTableAdapter.Fill(this.baustelleDBDataSet2.KlijentSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UslugaSet' table. You can move, or remove it, as needed.
            this.uslugaSetTableAdapter.Fill(this.baustelleDBDataSet2.UslugaSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.StavkaPonudeSet' table. You can move, or remove it, as needed.
            this.StavkaPonudeSetTableAdapter.Fill(this.baustelleDBDataSet2.StavkaPonudeSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.PonudaSet' table. You can move, or remove it, as needed.
            this.ponudaSetTableAdapter.Fill(this.baustelleDBDataSet2.PonudaSet);

            this.reportViewer1.RefreshReport();
        }


        /// <summary>
        /// Metoda koja se pokreće na promjenu vrijednosti u combobox-u i na osnovu te vrijednosti puni se dataset koji se koristi za prikaz podataka na reportu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPonuda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbPonuda.SelectedValue != null)
            {
                int PonudaID = (int)this.cmbPonuda.SelectedValue;
                this.StavkaPonudeSetTableAdapter.FillByPonudaIdStavke(this.baustelleDBDataSet2.StavkaPonudeSet,PonudaID);
                this.ponudaSetTableAdapter2.FillByPonuda(this.baustelleDBDataSet27.PonudaSet, PonudaID);
                //this.materijalSetTableAdapter(this.baustelleDBDataSet23.MaterijalSet, PonudaID);
                
                this.zaspolenikSetTableAdapter.FillByZaposlenikID(this.baustelleDBDataSet23.ZaspolenikSet,PonudaID);
                baustelleDBDataSet24.EnforceConstraints = false;
                this.materijalSetTableAdapter1.FillByMaterijali(this.baustelleDBDataSet24.MaterijalSet, PonudaID);
                baustelleDBDataSet25.EnforceConstraints = false;
                this.stavkaUslugeSetTableAdapter1.FillByKolicinaPonudaId(this.baustelleDBDataSet25.StavkaUslugeSet,PonudaID);
                baustelleDBDataSet26.EnforceConstraints = false;
                this.jedinicaMjereSetTableAdapter1.FillByJedinica(this.baustelleDBDataSet26.JedinicaMjereSet,PonudaID);

            }
            
            
            this.reportViewer1.RefreshReport();
        }
    }
}
