//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ET
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kategoria
    {
        public Kategoria()
        {
            this.Przedmiot = new HashSet<Przedmiot>();
            this.Kategoria_Atrybut = new HashSet<Kategoria_Atrybut>();
            this.Ogloszenie = new HashSet<Ogloszenie>();
        }
    
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public Nullable<int> Id_Parent { get; set; }
    
        public virtual ICollection<Przedmiot> Przedmiot { get; set; }
        public virtual ICollection<Kategoria_Atrybut> Kategoria_Atrybut { get; set; }
        public virtual ICollection<Ogloszenie> Ogloszenie { get; set; }
    }
}
