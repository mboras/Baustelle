//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baustelle
{
    using System;
    using System.Collections.Generic;
    
    public partial class UslugaSet
    {
        public UslugaSet()
        {
            this.StavkaPonudeSet = new HashSet<StavkaPonudeSet>();
            this.StavkaUslugeSet = new HashSet<StavkaUslugeSet>();
        }
    
        public int IdUsluge { get; set; }
        public int ZaposlenikId { get; set; }
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public System.DateTime DatumKreiranja { get; set; }
    
        public virtual ICollection<StavkaPonudeSet> StavkaPonudeSet { get; set; }
        public virtual ICollection<StavkaUslugeSet> StavkaUslugeSet { get; set; }
        public virtual ZaspolenikSet ZaspolenikSet { get; set; }
    }
}