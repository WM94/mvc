//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Atrybut
    {
        public Atrybut()
        {
            this.Atrybut_Wartosc = new HashSet<Atrybut_Wartosc>();
            this.Atrybuty_Ogloszenie = new HashSet<Atrybuty_Ogloszenie>();
            this.Kategoria_Atrybut = new HashSet<Kategoria_Atrybut>();
        }
    
        public int Id { get; set; }
        public string Nazwa { get; set; }
    
        public virtual ICollection<Atrybut_Wartosc> Atrybut_Wartosc { get; set; }
        public virtual ICollection<Atrybuty_Ogloszenie> Atrybuty_Ogloszenie { get; set; }
        public virtual ICollection<Kategoria_Atrybut> Kategoria_Atrybut { get; set; }
    }
}
