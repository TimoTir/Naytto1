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
    
    public partial class Tilausrivi
    {
        public int tilausId { get; set; }
        public int tuoteId { get; set; }
        public int määrä { get; set; }
    
        public virtual Tilaus Tilaus { get; set; }
        public virtual Tuotteet Tuotteet { get; set; }
    }
}
