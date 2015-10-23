using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class KategoriaViewModel
    {
        public int Id { set; get; }
        public string Nazwa { set; get; }
        public int? IdParent { set; get; }
    }
}
