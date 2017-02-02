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
    public partial class frmUsluge : Form
    {
        public frmUsluge()
        {
            InitializeComponent();
        }

        OsvjeziTablicu osvjezi = new OsvjeziTablicu();


        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsluge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet21.StavkaUslugeSet' table. You can move, or remove it, as needed.
            this.stavkaUslugeSetTableAdapter.Fill(this.baustelleDBDataSet2.StavkaUslugeSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.MaterijalSet' table. You can move, or remove it, as needed.
            this.materijalSetTableAdapter.Fill(this.baustelleDBDataSet2.MaterijalSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.ZaspolenikSet' table. You can move, or remove it, as needed.
            this.zaspolenikSetTableAdapter.Fill(this.baustelleDBDataSet2.ZaspolenikSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UslugaSet' table. You can move, or remove it, as needed.
            this.uslugaSetTableAdapter.Fill(this.baustelleDBDataSet2.UslugaSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.StavkaUslugeSet' table. You can move, or remove it, as needed.
           // this.stavkaUslugeSetTableAdapter.Fill(this.baustelleDBDataSet2.StavkaUslugeSet);
            this.jedinicaMjereSetTableAdapter1.Fill(this.baustelleDBDataSet2.JedinicaMjereSet);
            
            uslugaSetBindingSource.DataSource = osvjezi.PrikaziUsluge();
        }

        /// <summary>
        /// event na klik otvara formu za unos nove usluge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovi_Click(object sender, EventArgs e)
        {
            frmNovaUsluga novaUsluga = new frmNovaUsluga();
            novaUsluga.ShowDialog();
            uslugaSetBindingSource.DataSource = osvjezi.PrikaziUsluge();

        }

        /// <summary>
        /// event koji na promjeni ponude filtrira njezine usluge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUsluge_SelectionChanged(object sender, EventArgs e)
        {
            UslugaSet odabranaUsluga = uslugaSetBindingSource.Current as UslugaSet;
            if (odabranaUsluga != null)
            {
                stavkaUslugeSetBindingSource.DataSource = osvjezi.PrikaziStavkeUsluge(odabranaUsluga);
            }
        }

        /// <summary>
        /// event koji otvara formu za izmjenu odabrane usluge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmjeniUslugu_Click_1(object sender, EventArgs e)
        {
            UslugaSet odabranaUsluga = uslugaSetBindingSource.Current as UslugaSet;
            if (odabranaUsluga != null)
            {
                frmDetaljiOUsluzi detaljiUsluge = new frmDetaljiOUsluzi(odabranaUsluga);
                detaljiUsluge.ShowDialog();
                uslugaSetBindingSource.DataSource = osvjezi.PrikaziUsluge();
            }
        }

        /// <summary>
        /// event koji odabranu ponudu briše iz liste(baze)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzbriši_Click(object sender, EventArgs e)
        {
            UslugaSet odabranaUsluga = uslugaSetBindingSource.Current as UslugaSet;
            if (odabranaUsluga != null )
            {
                if (MessageBox.Show("Da li ste sigurni? ", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new BaustelleDBEntities())
                    {
                        db.UslugaSet.Attach(odabranaUsluga);

                        if (odabranaUsluga.StavkaUslugeSet.Count == 0)
                        {
                            db.UslugaSet.Remove(odabranaUsluga);
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Nije moguće obrisati usluge koje sadrže stavke!", "Upozorenje! ");
                        }
                    }
                    uslugaSetBindingSource.DataSource = osvjezi.PrikaziUsluge();
                }
               
            }
        }

        /// <summary>
        /// event na kojem otvaramo formu za unos nove Usluge na odabranu ponudu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovaStavka_Click(object sender, EventArgs e)
        {

            frmNovaStavkaUsluge novaStavka = new frmNovaStavkaUsluge(uslugaSetBindingSource.Current as UslugaSet);
            novaStavka.ShowDialog();
            stavkaUslugeSetBindingSource.DataSource = osvjezi.PrikaziStavkeUsluge(uslugaSetBindingSource.Current as UslugaSet);
        }

        /// <summary>
        /// event na kojem otvaramo formu za izmjenu usluge za odabranu ponudu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmjeniStavku_Click(object sender, EventArgs e)
        {
            StavkaUslugeSet odabranastavka = stavkaUslugeSetBindingSource.Current as StavkaUslugeSet;
            if(odabranastavka != null)
            {
                frmDetaljiOstavciUsluge detaljiOStavci = new frmDetaljiOstavciUsluge(odabranastavka);
                detaljiOStavci.ShowDialog();
                stavkaUslugeSetBindingSource.DataSource = osvjezi.PrikaziStavkeUsluge(uslugaSetBindingSource.Current as UslugaSet);
            }
            else
            {
                MessageBox.Show("Nije odabrana nijedna stavka usluge!");
            }
        }

        /// <summary>
        /// event kojime brišemo trenutno odabranu uslugu za odabranu ponudu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzbrisiUslugu_Click(object sender, EventArgs e)
        {
            StavkaUslugeSet odabranaStavka = stavkaUslugeSetBindingSource.Current as StavkaUslugeSet;

                if (odabranaStavka != null)
                {
                    if (MessageBox.Show("Da li ste sigurni? ", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        using (var db = new BaustelleDBEntities())
                        {
                            db.StavkaUslugeSet.Attach(odabranaStavka);
                         
                                db.StavkaUslugeSet.Remove(odabranaStavka);
                                db.SaveChanges();                          
                        }

                        stavkaUslugeSetBindingSource.DataSource = osvjezi.PrikaziStavkeUsluge(uslugaSetBindingSource.Current as UslugaSet);
                }

            }
                else
                {
                    MessageBox.Show("Nije odabrana nijedna stavka usluge!");
                }
        }

        
     
    }
}
