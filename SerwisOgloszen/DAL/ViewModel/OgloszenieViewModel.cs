using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL.ViewModel
{
    public class OgloszenieModelView
    {
      
        public int id { set; get; }
        [Required]
        [Display(Name = "Cena")]
        public int Cena { set; get; }
        
        public DateTime Data_Wystawienia { set; get; }
     
        public DateTime? Data_Zakonczenia { set; get; }
        public int Id_Uzytkownika { set; get; }
        public int? Id_Kupujacy { set; get; }
        public int Id_Przedmiot { set; get;  }
        public bool? Czy_Kupiony { set; get; }
        [Display(Name = "Opis")]
        [Required]
        public string Opis { set; get; }
        [Display(Name = "Nazwa")]
        [Required]
        public string Nazwa { set; get; }
        public HttpPostedFileBase url_zdjecie { get; set; }
    }
}
