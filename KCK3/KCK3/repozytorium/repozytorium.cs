using KCK3._class;
using System;
using System.Collections.Generic;

namespace KCK3.repozytorium
{
    public static class repozytorium
    {
        public static List<Faktura> listFakturaSprzedazy = new List<Faktura>();
        public static List<Wydarzenie> listWydarzenia = new List<Wydarzenie>();
        public static List<Emailcs> listEmail = new List<Emailcs>();
        public static List<Pracownik> listPracownikow = new List<Pracownik>();


        public static void init()
        {
           
              for(int i=0;i<10;i++)
              {
                    listPracownikow.Add(new Pracownik
                {
                     id=i,
                      Imie="Andrzej",
                       Nazwisko="Kowal"
                });
              }
          

            listEmail.Add(new Emailcs
            {

                id = 2,
                DataOtrzymania = DateTime.Now,
                Tytuł = "tytuł",
                Zawartosc = "Zawartosc Zawartosc Zawartosc ZawartoscZawartoscZawartosc ZawartoscZawartosc",
                 Nadawca="email@o2.pl"
            });

            listEmail.Add(new Emailcs
            {

                id = 2,
                DataOtrzymania = DateTime.Now,
                Tytuł = "tytuł",
                Zawartosc = "Zawartosc Zawartosc Zawartosc ZawartoscZawartoscZawartosc ZawartoscZawartosc",
                Nadawca = "email@o2.pl"
            });
            listEmail.Add(new Emailcs
            {

                id = 2,
                DataOtrzymania = DateTime.Now,
                Tytuł = "tytuł",
                Zawartosc = "Zawartosc Zawartosc Zawartosc ZawartoscZawartoscZawartosc ZawartoscZawartosc",
                Nadawca = "email@o2.pl"
            });
            listEmail.Add(new Emailcs
            {

                id = 2,
                DataOtrzymania = DateTime.Now,
                Tytuł = "tytuł",
                Zawartosc = "Zawartosc Zawartosc Zawartosc ZawartoscZawartoscZawartosc ZawartoscZawartosc",
                Nadawca = "email@o2.pl"
            });
            listEmail.Add(new Emailcs
            {

                id = 2,
                DataOtrzymania = DateTime.Now,
                Tytuł = "tytuł",
                Zawartosc = "Zawartosc Zawartosc Zawartosc ZawartoscZawartoscZawartosc ZawartoscZawartosc",
                Nadawca = "email@o2.pl"
            });

            
            
            listWydarzenia.Add(new Wydarzenie
            {
                id = 1,
                Nazwa = "Spotkanie z klientem",
                CzyWazne = true,
                Data = DateTime.Now
            });

            listWydarzenia.Add(new Wydarzenie
            {
                id = 1,
                Nazwa = "Spotkanie z klientem",
                CzyWazne = true,
                Data = DateTime.Now
            });

            listWydarzenia.Add(new Wydarzenie
            {
                id = 1,
                Nazwa = "Spotkanie z klientem",
                CzyWazne = true,
                Data = DateTime.Now
            });

            listWydarzenia.Add(new Wydarzenie
            {
                id = 1,
                Nazwa = "Spotkanie z klientem",
                CzyWazne = true,
                Data = DateTime.Now
            });
            
            
            listFakturaSprzedazy.Add(new Faktura
                {
                    id = 1,
                    DataWystawienia = new DateTime(2012, 3, 3, 12, 23, 22),
                    Imie_Klienta = "Antoni",
                    Nazwisko_Klienta = "Nowak",
                    Kwota = 23,
                    Numer = "FS/233/221"
                });

            listFakturaSprzedazy.Add(new Faktura
            {
                id = 1,
                DataWystawienia = new DateTime(2012, 3, 3, 12, 23, 22),
                Imie_Klienta = "Antoni",
                Nazwisko_Klienta = "Nowak",
                Kwota = 23,
                Numer = "FS/233/221"
            });

            listFakturaSprzedazy.Add(new Faktura
            {
                id = 1,
                DataWystawienia = new DateTime(2012, 3, 3, 12, 23, 22),
                Imie_Klienta = "Antoni",
                Nazwisko_Klienta = "Nowak",
                Kwota = 23,
                Numer = "FS/233/221"
            });

            listFakturaSprzedazy.Add(new Faktura
            {
                id = 1,
                DataWystawienia = new DateTime(2012, 3, 3, 12, 23, 22),
                Imie_Klienta = "Antoni",
                Nazwisko_Klienta = "Nowak",
                Kwota = 23,
                Numer = "FS/233/221"
            });
        }
    }
}