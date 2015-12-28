using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCK3._class
{
    public class Faktura
    {
        public int id { get; set; }
        public string Numer { get; set; }
        public DateTime DataWystawienia { get; set; }

        public decimal Kwota { get; set; }

        public string Imie_Klienta { get; set; }
        public string Nazwisko_Klienta { get; set; }


    }
}
