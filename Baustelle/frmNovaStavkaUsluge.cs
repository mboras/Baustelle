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
    public partial class frmNovaStavkaUsluge : Form
    {
        private UslugaSet odabranaUsluga;  // autribut u koji pohranjuhemo selketirani tim

        public frmNovaStavkaUsluge(UslugaSet usluga)
        {
            InitializeComponent();
            odabranaUsluga = usluga;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Click event koji sprema novu Stavku Usluge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new BaustelleDBEntities())
            {
                try
                {
                    db.UslugaSet.Attach(odabranaUsluga);

                    StavkaUslugeSet stavkaUsluge = new StavkaUslugeSet
                    {
                        MaterijalId = (int)cmbMaterijal.SelectedValue,
                        Kolicina = int.Parse(txtKolicina.Text),
                        UslugaSet = odabranaUsluga
                    };

                    db.StavkaUslugeSet.Add(stavkaUsluge);
                    db.SaveChanges();

                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Neka polja su prazna! Popunte ih. ", "Upozorenje!");
                    txtKolicina.Focus();
                }
            }
        }

        /// <summary>
        /// Load event koji koji puni određene Datasetove podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNovaStavkaUsluge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.UslugaSet' table. You can move, or remove it, as needed.
            this.uslugaSetTableAdapter.Fill(this.baustelleDBDataSet2.UslugaSet);
            // TODO: This line of code loads data into the 'baustelleDBDataSet2.MaterijalSet' table. You can move, or remove it, as needed.
            this.materijalSetTableAdapter.Fill(this.baustelleDBDataSet2.MaterijalSet);
        }
    }
}
