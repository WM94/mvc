using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class UzytkownikViewModel
    {
        
        public int Id { set; get; }
       
        public string Imie { set; get; }
        public string Nazwisko { set; get; }
        public string Email { set; get; }
        public string Telefon { set; get; }
        public string Adres { set; get; }
        public DateTime Data_Rejestracji {set;get;}
        public bool Aktywny {set;get;}
    }
}
