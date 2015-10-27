using DAL.Exceptions;
using DAL.ViewModel;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Services
{
    public class UserService
    {
        public IEnumerable<UserViewModel> GetAllUsers()
        {
            var context = new hEntities();

            var list = (from user in context.Uzytkownik
                        select new UserViewModel
                        {
                             
                            Adres = user.Adres_Zamieszkania,
                            Aktywny = user.Aktywny,
                            Data_Rejestracji = user.Data_Rejestracji,
                            Email = user.Email,
                            Id = user.Id,
                            Imie = user.Imie,
                            Nazwisko = user.Nazwisko,
                            Telefon = user.Telefon,
                        });

            return list;
        }

        public bool AddUserToDatabase(UserViewModel user)
        {
            var context = new hEntities();
            var use = new Uzytkownik
            {
                Haslo=user.Haslo,
                Nick = user.Nick,
                Adres_Zamieszkania = user.Adres,
                Aktywny = true,
                Data_Rejestracji = DateTime.Now,
                Email = user.Email,
                Imie = user.Imie,
                Nazwisko = user.Nazwisko,
                Telefon = user.Telefon,
                Data_Ostatniego_Logowania= DateTime.Now,
                Data_Urodzenia=user.Data_Urodzenia
                   
            };
            context.Uzytkownik.Add(use);

            context.SaveChanges();
            return true;
        }

        public UserViewModel LogInUser(UserViewModel user)
        {
            var context = new hEntities();
            UserViewModel temp;

            Uzytkownik userLogin = context.Uzytkownik.FirstOrDefault(uk => uk.Nick == user.Nick);



            if (userLogin == null)
            {
                throw new DAL.Exceptions.Exceptions.WrongLoginException();
            }
           
            if(userLogin.Haslo==user.Haslo)
            {
                  temp=  new UserViewModel
                            {
                                 Id=userLogin.Id,
                                Haslo = userLogin.Haslo,
                                Nick = userLogin.Nick,
                                Adres = userLogin.Adres_Zamieszkania,
                                Email = userLogin.Email,
                                Imie = userLogin.Imie,
                                Nazwisko = userLogin.Nazwisko,
                                Telefon = userLogin.Telefon
                                  
                            };
            }
            else
            {
                throw new DAL.Exceptions.Exceptions.WrongPasswordException();
            }
   

            return temp;
        }

        public void RemindPassword(UserViewModel user)
        {
            if(CheckIfUserExistsByNickOrEmail (user))
            {
                SendEmailToUser(user);
            }
        }

        public bool CheckIfUserExistsByNickOrEmail (UserViewModel user)
        {
            var context = new hEntities();

            var ExistUser = (from u in context.Uzytkownik
                             where ( (u.Nick!=null && u.Nick == user.Nick) || (u.Email!=null && u.Email== user.Nick) )
                             select new UserViewModel
                                       {
                                           Haslo = u.Haslo,
                                           Nick = u.Nick,
                                           Adres = u.Adres_Zamieszkania,
                                           Email = u.Email,
                                           Imie = u.Imie,
                                           Nazwisko = u.Nazwisko,
                                           Telefon = u.Telefon
                                       }).Single();

            if( ExistUser==null)
            {
                throw new DAL.Exceptions.Exceptions.WrongLoginException();
            }
            else
            {
                return true;
            }
            return false;
        }


        public void SendEmailToUser( UserViewModel user)
        {


        }
    }
}