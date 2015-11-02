using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class PrzemiotViewModel
    {
        public int Id { set; get; }
        [Required]
        [Display(Name = "Nazwa")]
        public string Nazwa { set; get; }
        [Required]
        [Display(Name = "Opis")]
        public string Opis { set; get; }
      
        public int Id_Uzytkownik { set; get; }

    }
}
