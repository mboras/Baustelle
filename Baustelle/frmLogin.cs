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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda koje se pokreće na klik miša na na button Registracija. Otvara formu registracije.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija reg = new frmRegistracija();
            reg.ShowDialog();
        }


        /// <summary>
        /// Metoda koje se pokreće na klik miša na na button Login nakon unosa podataka.
        /// Instancira se klasa i provjeravaju se uneseni podaci te ukoliko se slazu sa onima u bazi.
        /// Omogućuje se korisniku da pristupi aplikaciji.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProvjeraLogina provjera = new ProvjeraLogina();
            if (provjera.VerifyPassword(txtUsername.Text, txtPassword.Text) == true)
            {
                
                this.Close();

            }
            else
            {
                txtPassword.Focus();
                txtPassword.Clear();
            }
        }


        /// <summary>
        /// Metoda koje se pokreće na pritisak tipke Enter nakon unosa podataka.
        /// Instancira se klasa i provjeravaju se uneseni podaci te ukoliko se slazu sa onima u bazi.
        /// Omogućuje se korisniku da pristupi aplikaciji.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                ProvjeraLogina provjera = new ProvjeraLogina();

                if (provjera.VerifyPassword(txtUsername.Text, txtPassword.Text) == true)
                {

                    this.Close();
                }
                else {
                    txtPassword.Focus();
                    txtPassword.Clear();
                }
            }
        }

        

        
    }
}
