﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hEntities : DbContext
    {
        public hEntities()
            : base("name=hEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Atrybut> Atrybut { get; set; }
        public DbSet<Atrybut_Wartosc> Atrybut_Wartosc { get; set; }
        public DbSet<Atrybuty_Ogloszenie> Atrybuty_Ogloszenie { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        public DbSet<Kategoria_Atrybut> Kategoria_Atrybut { get; set; }
        public DbSet<Multimedia> Multimedia { get; set; }
        public DbSet<Niedozwolone_Wyrazenia> Niedozwolone_Wyrazenia { get; set; }
        public DbSet<Ogloszenie> Ogloszenie { get; set; }
        public DbSet<Ogloszenie_kategoria> Ogloszenie_kategoria { get; set; }
        public DbSet<Przedmiot> Przedmiot { get; set; }
        public DbSet<Uzytkownik> Uzytkownik { get; set; }
    }
}
