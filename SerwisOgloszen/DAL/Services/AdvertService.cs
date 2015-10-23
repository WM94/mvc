using DAL.ViewModel;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class AdvertService
    {

        public bool AddAdvert(OgloszenieModelView ogloszenie )
        {
            var context = new hEntities();
            var og = new Ogloszenie
            {
             Cena= ogloszenie.Cena,
             Data_Wystawienia=ogloszenie.Data_Wystawienia,
             Data_Zakonczenia=ogloszenie.Data_Zakonczenia,
             Id_Kupujący= ogloszenie.Id_Kupujacy,
              
             Id_Przedmiot= ogloszenie.Id_Przedmiot,
             Id_Uzytkownik=ogloszenie.Id_Przedmiot,         

            };
            context.Ogloszenie.Add(og);
            context.SaveChanges();
        
            return true;
        }
    }
}
