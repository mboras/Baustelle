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
    
    public partial class StavkaPonudeSet
    {
        public int IdStavkePonude { get; set; }
        public int PonudaId { get; set; }
        public int UslugaId { get; set; }
        public decimal Kolicina { get; set; }
    
        public virtual PonudaSet PonudaSet { get; set; }
        public virtual UslugaSet UslugaSet { get; set; }
    }
}