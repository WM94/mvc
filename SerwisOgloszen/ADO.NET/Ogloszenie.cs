//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADO.NET
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogloszenie
    {
        public int Id { get; set; }
        public int Cena { get; set; }
        public System.DateTime Data_Wystawienia { get; set; }
        public Nullable<System.DateTime> Data_Zakonczenia { get; set; }
        public int Id_Uzytkownik { get; set; }
        public Nullable<int> Id_Kupujący { get; set; }
        public int Id_Przedmiot { get; set; }
    
        public virtual Kategoria Kategoria { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }
        public virtual Przedmiot Przedmiot { get; set; }
        public virtual Uzytkownik Uzytkownik1 { get; set; }
    }
}
