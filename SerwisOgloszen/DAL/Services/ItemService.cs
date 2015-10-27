using DAL.ViewModel;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class ItemService
    {

        public List<PrzemiotViewModel> GetItemByUserID(int id)
        {
            var context = new hEntities();
            var list = context.Przedmiot.Where(x => x.Id_Uzytkownik == id).ToList();

            List<PrzemiotViewModel> items  = new List<PrzemiotViewModel>();

            foreach (var item in list)
            {
                items.Add(new PrzemiotViewModel
                    {
                        Id = item.Id,
                        Nazwa = item.Nazwa,
                        Opis = item.Opis,
                        Id_Uzytkownik=item.Id_Uzytkownik

                    });
                
            }

            return items;



        }

        public int AddItemToDatabase(PrzemiotViewModel item)
        {
            var context = new hEntities();
            Przedmiot it = new Przedmiot
                {
                     Nazwa=item.Nazwa,
                     Opis=item.Opis,
                     Id_Uzytkownik = item.Id_Uzytkownik,
                     Czy_Kupiony=false,
                         
                       
                };

            context.Przedmiot.Add(it);

            context.SaveChanges();

            return it.Id;



        }

    }
}
