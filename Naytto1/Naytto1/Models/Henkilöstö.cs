//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Naytto1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Henkilöstö
    {
        public Henkilöstö()
        {
            this.Logins = new HashSet<Logins>();
        }
    
        public int HenkilöId { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Puhelin { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Logins> Logins { get; set; }
    }
}
