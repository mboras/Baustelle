using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Baustelle
{
    class RacunPonude
    {
        
        
        
        /// <summary>
        /// Metoda računa ukupnu cijenu Usluga na Ponudi
        /// </summary>
        /// <param name="ponuda">Ponuda za mkoju se računa ukupna cijena</param>
        /// <returns>Ukupnu cijenu</returns>
        public decimal IzracunUkupneCijene(PonudaSet ponuda) 
        {
            decimal ukupCijena = 0;
            BindingList<StavkaPonudeSet> listaStavki = null;
            BindingList<UslugaSet> listaUsluga = null;
            using (var db = new BaustelleDBEntities())
            {
                db.PonudaSet.Attach(ponuda);
                listaStavki = new BindingList<StavkaPonudeSet>(ponuda.StavkaPonudeSet.ToList<StavkaPonudeSet>());
                listaUsluga = new BindingList<UslugaSet>(db.UslugaSet.ToList<UslugaSet>());
            }

            foreach (StavkaPonudeSet k in listaStavki)
            {
                foreach (UslugaSet u in listaUsluga)
                {
                    if (k.UslugaId==u.IdUsluge)
                    {
                        ukupCijena +=(decimal) k.Kolicina * u.Cijena;
                    }
                }
            }
            return ukupCijena;
        }


       
    }
}
