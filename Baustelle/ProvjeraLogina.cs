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
    class ProvjeraLogina
    {
        public ProvjeraLogina()
        {

        }

        /// <summary>
        /// Metoda koja provjerava da li je korisnik registriran u bazi ili ne
        /// </summary>
        /// <param name="user">Uneseno Korisničko ime</param>
        /// <param name="pass">Unesena Lozinka</param>
        /// <returns>Ako je korisnik u bazi vraća true, ako nije vraća false</returns>
        public bool VerifyPassword(string user, string pass)
        {
            //".FirstOrDefault()" metoda će vratiti ili prvu vrijednost upita ili null
            using (var db = new BaustelleDBEntities())
            {
                ZaspolenikSet zaposlenik = new ZaspolenikSet();
                var myUser = db.ZaspolenikSet.FirstOrDefault(u => u.Username == user && u.Password == pass);
                


                if (myUser != null && myUser.UlogaId == 1)    //Korisnik je pronađen
                {
                    FormAdministrator main = new FormAdministrator();
                    main.ShowDialog();
                    return true;
                }
                else if (myUser != null && myUser.UlogaId == 2)
                {
                    FormKorisnik main = new FormKorisnik();
                    main.ShowDialog();
                    return true;
                }
                else    //Korisnik nije pronađen
                {
                    MessageBox.Show("Poštovani, vaše korisničko ime ili lozinka nisu točni.\nMolimo Vas da ponovite postupak.");
                    return false;
                }
            }
        }
    }
}
