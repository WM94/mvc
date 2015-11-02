using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class UserViewModel
    {
       
        public int Id { set; get; }
       
        public string Imie { set; get; }
        [Required]
        public string Nazwisko { set; get; }
        [Required]
        public string Email { set; get; }
        [Required]
        public string Telefon { set; get; }
        [Required]
        public string Adres { set; get; }
        [DataType(DataType.Date)]
        public DateTime Data_Rejestracji {set;get;}
        [DataType(DataType.Date)]
        public DateTime Data_Ostatniego_logowania { set; get; }
         [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Data_Urodzenia { set; get; }

        public bool Aktywny {set;get;}
        [Required]
        public string Nick { set; get; }
        [Required]
        [DataType(DataType.Password)]
        public string Haslo { set; get; }
    }
}
