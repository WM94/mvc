using DAL.Services;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SerwisOgloszen.Const;

namespace SerwisOgloszen.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Register/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();

        }
        [HttpPost]
        public ActionResult SignUp(UserViewModel user)
        {
            UserService us = new UserService();
            if (!us.CheckIfUserExistsByNickOrEmail(user))
            {
                us.AddUserToDatabase(user);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Podany użytkownik lub email jest już zarejestrowany");
                return View(user);
            }
            
          


        }
        [HttpPost]
        public ActionResult LogIn (UserViewModel user)
        {
            UserService us = new UserService();
            UserViewModel temp=null;
            
            try 
            {
                temp = us.LogInUser(user);
            }


  

            catch (DAL.Exceptions.Exceptions.WrongPasswordException ex)        
            {
                ModelState.AddModelError("",  ex.Message);
                return View(user);

            }
            catch(DAL.Exceptions.Exceptions.WrongLoginException ex ) 
            
            {
                ModelState.AddModelError("",  ex.Message);
                return View(user);
            }
            catch {

                return null ;
            
            }
            Session["UserID"] = temp.Id;


            return RedirectToAction("Index", "Home");


        }
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();


        }
        [HttpGet]
        public ActionResult RemindPassword()
        {
            return View();

        }

        [HttpPost]
        public ActionResult RemindPassword(UserViewModel user)
        {
            return View();

        }

        [HttpGet]
        public ActionResult LogOut()
        {
            Session["UserID"] = null;

            return RedirectToAction("Index", "Home");


        }

        [HttpGet]
        public ActionResult test()
        {
            return View();

        }
    }
}
