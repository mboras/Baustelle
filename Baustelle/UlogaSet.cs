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
    
    public partial class UlogaSet
    {
        public UlogaSet()
        {
            this.ZaspolenikSet = new HashSet<ZaspolenikSet>();
        }
    
        public int IdUloga { get; set; }
        public string Naziv { get; set; }
    
        public virtual ICollection<ZaspolenikSet> ZaspolenikSet { get; set; }
    }
}
