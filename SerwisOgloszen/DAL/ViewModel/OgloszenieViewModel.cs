using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class OgloszenieModelView
    {
        public int id { set; get; }
        public int Cena { set; get; }
        public DateTime Data_Wystawienia { set; get; }
        public DateTime Data_Zakonczenia { set; get; }
        public int Id_Uzytkownika { set; get; }
        public int Id_Kupujacy { set; get; }
        public int Id_Przedmiot { set; get;  }
        public bool? Czy_Kupiony { set; get; }
       

    }
}
