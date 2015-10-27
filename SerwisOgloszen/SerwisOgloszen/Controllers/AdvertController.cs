using DAL.Services;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerwisOgloszen.Controllers
{
    public class AdvertController : Controller
    {
        //
        // GET: /Advert/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddAdvertToDatabase(int id)
        {
            return View();

        }



        [HttpGet]
        public ActionResult AddAdvert( )
        {
            return View();

        }

   
     

    }
}
