using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class UserViewModel
    {
        
        public int Id { set; get; }
       
        public string Imie { set; get; }
        public string Nazwisko { set; get; }
        public string Email { set; get; }
        public string Telefon { set; get; }
        public string Adres { set; get; }
        public DateTime Data_Rejestracji {set;get;}
        public bool Aktywny {set;get;}
        public string Nick { set; get; }
        public string Haslo { set; get; }
    }
}
