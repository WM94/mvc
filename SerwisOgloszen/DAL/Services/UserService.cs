using DAL.Exceptions;
using DAL.ViewModel;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Services
{
    public class UserService
    {
        public IEnumerable<UserViewModel> GetAllUsers()
        {
            var context = new Entities();

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
            var context = new Entities();
            var use = new Uzytkownik
            {
                Nick = user.Nick,
                Adres_Zamieszkania = user.Adres,
                Aktywny = user.Aktywny,
                Data_Rejestracji = DateTime.Now,
                Email = user.Email,
                Imie = user.Imie,
                Nazwisko = user.Nazwisko,
                Telefon = user.Telefon
            };
            context.Uzytkownik.Add(use);

            context.SaveChanges();
            return true;
        }

        public UserViewModel LogInUser(UserViewModel user)
        {
            var context = new Entities();

            UserViewModel userLogin = (from u in context.Uzytkownik
                            where u.Nick == user.Nick
                            select new UserViewModel
                            {
                                Haslo= u.Hasło,
                                Nick = u.Nick,
                                Adres = u.Adres_Zamieszkania,
                                Email = u.Email,
                                Imie = u.Imie,
                                Nazwisko = u.Nazwisko,
                                Telefon = u.Telefon
                            }).Single();

            if( userLogin==null)
            {
                throw new DAL.Exceptions.Exceptions.WrongLoginException();
            }

            if (userLogin.Haslo!= user.Haslo)
            {
                throw new DAL.Exceptions.Exceptions.WrongPasswordException();
            }

            return userLogin;
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
            var context = new Entities();

            var ExistUser = (from u in context.Uzytkownik
                             where ( (u.Nick!=null && u.Nick == user.Nick) || (u.Email!=null && u.Email== user.Nick) )
                             select new UserViewModel
                                       {
                                           Haslo = u.Hasło,
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