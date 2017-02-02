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
    public partial class frmPonude : Form
    {
        public frmPonude()
        {
            InitializeComponent();
        }

        OsvjeziTablicu osvjezi = new OsvjeziTablicu();

        /// <summary>
        /// event koji otvara formu za nos nove ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmNovaPonuda nPonuda = new frmNovaPonuda();
            nPonuda.ShowDialog();          
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// na load popunjavamo Datasetove određenim vrijednostima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPonude_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.KlijentSet' table. You can move, or remove it, as needed.
            this.klijentSetTableAdapter.Fill(this.baustelleDBDataSet2.KlijentSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UslugaSet' table. You can move, or remove it, as needed.
            this.uslugaSetTableAdapter.Fill(this.baustelleDBDataSet2.UslugaSet);

            ponudaSetBindingSource.DataSource = osvjezi.PrikaziPonude();
            stavkaPonudeSetBindingSource.DataSource = osvjezi.PrikaziStavkePonude(ponudaSetBindingSource.Current as PonudaSet);

        }

        /// <summary>
        /// na promjenu ponude mjenjamo usluge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsluge_SelectionChanged(object sender, EventArgs e)
        {
            PonudaSet odabranaPonuda = ponudaSetBindingSource.Current as PonudaSet;
            if (odabranaPonuda != null)
            {
                stavkaPonudeSetBindingSource.DataSource = osvjezi.PrikaziStavkePonude(odabranaPonuda);
            }
        }

        /// <summary>
        /// event koji otvara formu za unos nove ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovaPonuda_Click(object sender, EventArgs e)
        {
            frmNovaPonuda novaPonuda = new frmNovaPonuda();
            novaPonuda.ShowDialog();
            ponudaSetBindingSource.DataSource = osvjezi.PrikaziPonude();
        }

        /// <summary>
        /// event koji otvara formu za izmjenu odabrane ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmjeniPonudu_Click(object sender, EventArgs e)
        {
            PonudaSet odabranaPonuda = ponudaSetBindingSource.Current as PonudaSet;

            frmDetaljiPonude detaljiPonude = new frmDetaljiPonude(odabranaPonuda);
            detaljiPonude.ShowDialog();
            ponudaSetBindingSource.DataSource = osvjezi.PrikaziPonude();
        }

        /// <summary>
        /// event koji briše odabranu ponudu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzbrisiPonudu_Click(object sender, EventArgs e)
        {
            PonudaSet odabranaPonuda = ponudaSetBindingSource.Current as PonudaSet;

            if (odabranaPonuda !=null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new BaustelleDBEntities())
                    {
                        db.PonudaSet.Attach(odabranaPonuda);
                        if (odabranaPonuda.StavkaPonudeSet.Count() == 0)
                        {
                            db.PonudaSet.Remove(odabranaPonuda);
                            db.SaveChanges();
                        }

                        else
                        {
                            MessageBox.Show("Nije moguće obrisati ponudu prije brisanja njezinih stavki!", "Upozorenje!");
                        }
                    }
                    ponudaSetBindingSource.DataSource = osvjezi.PrikaziPonude();
                }
                
            }
        }

        /// <summary>
        /// event koji otvara formu za unos nove stavke ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovaStavkaPonude_Click(object sender, EventArgs e)
        {
            frmNovaStavkaPonude novaStavka = new frmNovaStavkaPonude(ponudaSetBindingSource.Current as PonudaSet);
            novaStavka.ShowDialog();
            stavkaPonudeSetBindingSource.DataSource = osvjezi.PrikaziStavkePonude(ponudaSetBindingSource.Current as PonudaSet);
        }

        /// <summary>
        /// event koji otvara formu za izmjenu odabrane stavke ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmjeniStavkuPonude_Click(object sender, EventArgs e)
        {

            if (stavkaPonudeSetBindingSource.Current != null) 
            {
                frmDetaljiStavkePonude detStavkePonude = new frmDetaljiStavkePonude(stavkaPonudeSetBindingSource.Current as StavkaPonudeSet);
                detStavkePonude.ShowDialog();
                stavkaPonudeSetBindingSource.DataSource = osvjezi.PrikaziStavkePonude(ponudaSetBindingSource.Current as PonudaSet);
            }
            else
            {
                MessageBox.Show("Nije odabrana nijedna stavka ponude!", "Upozorenje!");
            }           
        }

        /// <summary>
        /// event koji briše odabranu stavku ponude
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzbrisiStavkuPonude_Click(object sender, EventArgs e)
        {
            StavkaPonudeSet odabranaStavka = stavkaPonudeSetBindingSource.Current as StavkaPonudeSet;

            if (odabranaStavka != null)
            {
                if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new BaustelleDBEntities())
                    {
                        db.StavkaPonudeSet.Attach(odabranaStavka);
                            db.StavkaPonudeSet.Remove(odabranaStavka);
                            db.SaveChanges();
                    }
                    stavkaPonudeSetBindingSource.DataSource = osvjezi.PrikaziStavkePonude(ponudaSetBindingSource.Current as PonudaSet);
                }

            }
            else
            {
                MessageBox.Show("Nije odabrana nijedna stavka ponude!", "Upozorenje!");
            }
        }

        /// <summary>
        /// event koji otvara izvješće za trenutno odabranu ponudu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIspisPonude_Click(object sender, EventArgs e)
        {
            frmIspisPonude izvjestaj = new frmIspisPonude(ponudaSetBindingSource.Current as PonudaSet);
            izvjestaj.MdiParent = this.ParentForm;
            izvjestaj.Show();

        }

        
    }
}
