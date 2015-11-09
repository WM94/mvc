using DAL.ViewModel;
using DAL.ViewModel.Custom;
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
        public bool AddAdvert(OgloszenieModelView ogloszenie)
        {
            var context = new hEntities();
            var og = new Ogloszenie
            {
                Cena = ogloszenie.Cena,
                Data_Wystawienia = DateTime.Now,
                Id_Przedmiot = ogloszenie.Id_Przedmiot,
                Id_Uzytkownik = ogloszenie.Id_Uzytkownika,
            };
            context.Ogloszenie.Add(og);
            context.SaveChanges();

            return true;
        }

        public int AddAdvert(OgloszenieModelView ogloszenie, string[] category)
        {
            var context = new hEntities();
            var og = new Ogloszenie
            {
                Cena = ogloszenie.Cena,
                Data_Wystawienia = DateTime.Now,
                Id_Przedmiot = ogloszenie.Id_Przedmiot,
                Id_Uzytkownik = ogloszenie.Id_Uzytkownika,
                Opis=ogloszenie.Opis,
                Nazwa=ogloszenie.Nazwa,
                Czy_Kupiony=false

            };
            context.Ogloszenie.Add(og);
            context.SaveChanges();
            var id = og.Id;
            foreach (var item in category)
            {
                var og_cat = new Ogloszenie_kategoria
                   {
                       Id_Kategoria_ = Convert.ToInt32(item),
                       Id_Ogloszenie =id
                   };
                context.Ogloszenie_kategoria.Add(og_cat);
            }

            context.SaveChanges();

            return og.Id;
        }


        public IEnumerable<AdvertWithUserViewModel> GetLast100AllAdverts()
        {
            var context = new hEntities();

            var collection = (

                              (from ogl in context.Ogloszenie
                               join cat_ogl in context.Ogloszenie_kategoria on ogl.Id equals cat_ogl.Id_Ogloszenie
                               join user in context.Uzytkownik on ogl.Id_Uzytkownik equals user.Id
                               join cat in context.Kategoria on cat_ogl.Id_Kategoria_ equals cat.Id
                         
                               select new AdvertWithUserViewModel
                               {

                                   ogloszenie = new OgloszenieModelView()
                                   {

                                       id = ogl.Id,
                                       Cena = ogl.Cena,
                                       Data_Wystawienia = ogl.Data_Wystawienia,
                                       Data_Zakonczenia = ogl.Data_Zakonczenia,
                                       Id_Przedmiot = ogl.Id_Przedmiot,
                                       Id_Kupujacy = ogl.Id_Kupujący,
                                       Czy_Kupiony = ogl.Czy_Kupiony,
                                       Opis = ogl.Opis
                                   },
                                   user = new UserViewModel()
                                   {

                                       Id = user.Id,
                                       Nick = user.Nick,
                                       Adres = user.Adres_Zamieszkania,
                                       Email = user.Email,
                                       Imie = user.Imie,
                                       Nazwisko = user.Nazwisko,
                                       Telefon = user.Telefon
                                   }


                               }
                               )



            ).Take(100);

            return collection;
        }

        public IEnumerable<AdvertWithUserViewModel> GetLast100ActiveAdverts()
        {
            var context = new hEntities();

            var collection = (

                              (from ogl in context.Ogloszenie
                               join cat_ogl in context.Ogloszenie_kategoria on ogl.Id equals cat_ogl.Id_Ogloszenie
                               join user in context.Uzytkownik on ogl.Id_Uzytkownik equals user.Id
                               join cat in context.Kategoria on cat_ogl.Id_Kategoria_ equals cat.Id
                              // where ogl.Czy_Kupiony==false
                               select new AdvertWithUserViewModel
                               {

                                   ogloszenie = new OgloszenieModelView()
                                   {

                                       id = ogl.Id,
                                       Cena = ogl.Cena,
                                       Data_Wystawienia = ogl.Data_Wystawienia,
                                       Data_Zakonczenia = ogl.Data_Zakonczenia,
                                       Id_Przedmiot = ogl.Id_Przedmiot,
                                       Id_Kupujacy = ogl.Id_Kupujący,
                                       Czy_Kupiony = ogl.Czy_Kupiony,
                                       Opis = ogl.Opis,
                                       Nazwa=ogl.Nazwa
                                   },
                                   user = new UserViewModel()
                                   {

                                       Id = user.Id,
                                       Nick = user.Nick,
                                       Adres = user.Adres_Zamieszkania,
                                       Email = user.Email,
                                       Imie = user.Imie,
                                       Nazwisko = user.Nazwisko,
                                       Telefon = user.Telefon
                                   }


                               }
                               )



            ).Take(100);

            return collection;

          
        }

        public IEnumerable<AdvertWithUserViewModel> GetLast100ActiveAdvertsByCategory(int _id)
        {
            var context = new hEntities();

            var collection = (

                              (from ogl in context.Ogloszenie
                               join cat_ogl in context.Ogloszenie_kategoria on ogl.Id equals cat_ogl.Id_Ogloszenie
                               join user in context.Uzytkownik on ogl.Id_Uzytkownik equals user.Id
                               join cat in context.Kategoria on cat_ogl.Id_Kategoria_ equals cat.Id
                               where cat.Id == _id || cat.Id_Parent == _id
                               select new AdvertWithUserViewModel {

                                   ogloszenie = new OgloszenieModelView()
                                   {
                                        
                                         id = ogl.Id,
                                         Cena = ogl.Cena,
                                         Data_Wystawienia = ogl.Data_Wystawienia,
                                         Data_Zakonczenia = ogl.Data_Zakonczenia,
                                         Id_Przedmiot = ogl.Id_Przedmiot,
                                         Id_Kupujacy = ogl.Id_Kupujący,
                                         Czy_Kupiony = ogl.Czy_Kupiony,
                                         Opis=ogl.Opis,
                                         Nazwa=ogl.Nazwa
                                   },
                                   user = new UserViewModel()
                                   {

                                       Id = user.Id,
                                       Nick = user.Nick,
                                       Adres = user.Adres_Zamieszkania,
                                       Email = user.Email,
                                       Imie = user.Imie,
                                       Nazwisko = user.Nazwisko,
                                       Telefon = user.Telefon
                                   }
                                    
                               
                               }
                               )

                           

            ).Take(100);

            return collection;
        }
        public AdvertWithAtributte GetAtributteForAdvert(OgloszenieModelView _ogl)
        {
            var context = new hEntities();

            AdvertWithAtributte advert = new AdvertWithAtributte();
            advert.atr = new List<AtributteValue>();


            var category = (from cat_ogl in context.Ogloszenie_kategoria
                     join cat in context.Kategoria on cat_ogl.Id_Kategoria_ equals cat.Id
                     join cat_atr in context.Kategoria_Atrybut on cat.Id equals cat_atr.Id_Kategoria_
                     //join atr in context.Atrybut on cat_atr.Id_Atrybut equals atr.Id

                     where cat_ogl.Id_Ogloszenie == _ogl.id
                     select cat_atr);

            List<AtributteValue> atributes = new List<AtributteValue>();

            foreach (var item in category)
            {

                var attribute = (from atr in context.Atrybut
                          where atr.Id == item.Id_Atrybut
                          select new AtributteValue
                          {
                              ID_Atrybutu = atr.Id,
                              Id_Ogloszenia = _ogl.id,
                              Nazwa_atrybutu = atr.Nazwa,
                              Wartosc = (from atr_val in context.Atrybut_Wartosc
                                         where atr_val.Id_Atrybut == atr.Id
                                         select new AtributteValueModelView()
                                         {
                                             ID = atr_val.Id,
                                             Wartosc = atr_val.Wartosc
                                         }).ToList()

                          }).Single() ;

                advert.atr.Add(attribute);
                
            }
            return advert;
        }

        
    }
}