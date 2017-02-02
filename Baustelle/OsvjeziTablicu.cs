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
    class OsvjeziTablicu
    {

        public OsvjeziTablicu()
        {
                
        }

        /// <summary>
        /// Metoda osvježava listu JedinicaMjere
        /// </summary>
        /// <returns>Objekt svake JediniceMjere</returns>
        public object PrikaziJediniceMjere()
        {
            BindingList<JedinicaMjereSet> listaJedinicaMjere = null;
            using (var db = new BaustelleDBEntities())
            {
                listaJedinicaMjere = new BindingList<JedinicaMjereSet>(db.JedinicaMjereSet.ToList());

            }
            return listaJedinicaMjere;
        }

        /// <summary>
        /// Metoda osvježava listu Klijenata
        /// </summary>
        /// <returns>Objekt svakog Klijenta</returns>
        public object PrikaziKlijente()
        {
            BindingList<KlijentSet> listaKlijenata = null;
            using (var db = new BaustelleDBEntities())
            {
                listaKlijenata = new BindingList<KlijentSet>(db.KlijentSet.ToList());
            }
            return listaKlijenata;
        }

        /// <summary>
        /// Metoda osvježava listu Materijala
        /// </summary>
        /// <returns>Ovjekt svakog Materijala</returns>
        public object PrikaziMaterijal()
        {
            BindingList<MaterijalSet> listaMaterijala = null;
            using (var db = new BaustelleDBEntities())
            {
                listaMaterijala = new BindingList<MaterijalSet>(db.MaterijalSet.ToList());
            }
            return listaMaterijala;
        }

        /// <summary>
        /// Metoda osvježava listu Ponude
        /// </summary>
        /// <returns>Ovjekt svake Ponude</returns>
        public object PrikaziPonude()
        {
            BindingList<PonudaSet> listaPonuda = null;

            using (var db = new BaustelleDBEntities())
            {
                listaPonuda = new BindingList<PonudaSet>(db.PonudaSet.ToList());
            }
            return listaPonuda;
        }

        /// <summary>
        /// Metoda osvježava listu Stavki za svaku Ponudu
        /// </summary>
        /// <param name="ponuda"></param>
        /// <returns>Objekt Stavke svake Ponude</returns>
        public object PrikaziStavkePonude(PonudaSet ponuda)
        {
            BindingList<StavkaPonudeSet> listaStavkiPonude = null;
            using (var db = new BaustelleDBEntities())
            {
                db.PonudaSet.Attach(ponuda);
                listaStavkiPonude = new BindingList<StavkaPonudeSet>(ponuda.StavkaPonudeSet.ToList<StavkaPonudeSet>());
            }
            return listaStavkiPonude;
        }

        /// <summary>
        /// Metoda osvježava listu Usluga
        /// </summary>
        /// <returns>Objekt svake Usluge</returns>
        public object PrikaziUsluge()
        {
            BindingList<UslugaSet> listaUsluga = null;
            using (var db = new BaustelleDBEntities())
            {
                listaUsluga = new BindingList<UslugaSet>(db.UslugaSet.ToList());
            }
            return listaUsluga;
        }

        /// <summary>
        /// Metoda osvježava listu Usluga svake Stavke
        /// </summary>
        /// <param name="usluga"></param>
        /// <returns>Objekt Usluge svake Stavke</returns>
        public object PrikaziStavkeUsluge(UslugaSet usluga)
        {
            BindingList<StavkaUslugeSet> listaUsluga = null;
            using (var db = new BaustelleDBEntities())
            {
                db.UslugaSet.Attach(usluga);
                listaUsluga = new BindingList<StavkaUslugeSet>(usluga.StavkaUslugeSet.ToList<StavkaUslugeSet>());
            }
            return listaUsluga;
        }

        /// <summary>
        /// Metoda osvježava listu Zaposlenika
        /// </summary>
        /// <returns>Objekt svakog Zaposlenika</returns>
        public object PrikaziZaposlenika()
        {
            BindingList<ZaspolenikSet> listaZaposlenika = null;
            using (var db = new BaustelleDBEntities())
            {
                listaZaposlenika = new BindingList<ZaspolenikSet>(db.ZaspolenikSet.ToList());
            }
            return listaZaposlenika;
        }

        
    }
}
