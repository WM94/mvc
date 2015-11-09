using DAL.Services;
using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerwisOgloszen.Controllers
{
    public class ItemController : Controller
    {
        //
        // GET: /Item/

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetItemUsersByID()
        {
            int id = Convert.ToInt16(Session["UserID"]);

            if (id == null || id == 0)
            {
                return RedirectToAction("LogIn", "Account");
            }
            ItemService sv = new ItemService();
            var list = sv.GetItemByUserID(id);

            return Json(list, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public ActionResult AddItemToDatabase(string name, string description)
        {
            PrzemiotViewModel item = new PrzemiotViewModel
            {
                   Id_Uzytkownik= Convert.ToInt16(Session["UserID"]),
                    Nazwa=name,
                     Opis=description
                    
            };
            ItemService sr = new ItemService();
            int id= sr.AddItemToDatabase(item);
          
            return Json(id, JsonRequestBehavior.AllowGet);

        }

    }
}
