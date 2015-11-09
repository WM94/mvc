using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class AtributteValue
    {
        public int ID_Atrybutu { set; get; }
        public string Nazwa_atrybutu { set; get; }
        public List<AtributteValueModelView> Wartosc { set; get; }
        public int Id_Ogloszenia { set; get; }
    }
}
