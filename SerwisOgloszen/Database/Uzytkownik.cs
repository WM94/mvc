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
    
    public partial class Uzytkownik
    {
        public Uzytkownik()
        {
            this.Ogloszenie = new HashSet<Ogloszenie>();
            this.Ogloszenie1 = new HashSet<Ogloszenie>();
            this.Przedmiot = new HashSet<Przedmiot>();
        }
    
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres_Zamieszkania { get; set; }
        public System.DateTime Data_Rejestracji { get; set; }
        public bool Aktywny { get; set; }
        public string Nick { get; set; }
        public string Haslo { get; set; }
        public System.DateTime Data_Urodzenia { get; set; }
        public System.DateTime Data_Ostatniego_Logowania { get; set; }
    
        public virtual ICollection<Ogloszenie> Ogloszenie { get; set; }
        public virtual ICollection<Ogloszenie> Ogloszenie1 { get; set; }
        public virtual ICollection<Przedmiot> Przedmiot { get; set; }
    }
}
