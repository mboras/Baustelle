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
    
    public partial class JedinicaMjereSet
    {
        public JedinicaMjereSet()
        {
            this.MaterijalSet = new HashSet<MaterijalSet>();
        }
    
        public int IdJedinicaMjere { get; set; }
        public string Naziv { get; set; }
        public string SkraceniNaziv { get; set; }
    
        public virtual ICollection<MaterijalSet> MaterijalSet { get; set; }
    }
}
