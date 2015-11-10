using DAL.Services;
using DAL.ViewModel;
using DAL.ViewModel.Custom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SerwisOgloszen.Controllers
{
    public class AdvertController : Controller
    {
        //
        // GET: /Advert/

        private string url_zdjecie;

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
            var id = Convert.ToInt16(Session["UserID"]);
            if (id == null || id == 0)
            {
                return RedirectToAction("LogIn", "Account");
            }

            return View();

        }


        [HttpPost]
        public ActionResult AddAdvert(OgloszenieModelView advert, string[] category)
         {
             AdvertService sr = new AdvertService();
             var id = Convert.ToInt16(Session["UserID"]);
             if (id == null || id==0)
             {
                 return RedirectToAction("LogIn", "Account");
             }
             advert.Id_Uzytkownika = Convert.ToInt16(Session["UserID"]);
             var _id = sr.AddAdvert(advert, category);

             advert.id = _id;
           /// return  RedirectToAction("ChooseAtributte", "Advert", new { adv = advert });
            // return RedirectToAction("ChooseAtributte", new RouteValueDictionary(advert));

             //return View("test");
             //return RedirectToAction("test");
             return RedirectToAction("test", "Advert");
             //var _url = "/Home/Index";

             //return Json(new { url = _url });
        }

          [HttpGet]
        public ActionResult GetAllAdverts()
        {

            return null;
        }

          [HttpGet]
          public ActionResult GetAdvertByCategory(int id)
        {
            AdvertService srv = new AdvertService();
      
              if(id==0)
              {
                  var list = srv.GetLast100ActiveAdverts();
                  return View(list);
              }
              else
              {
                 var  list = srv.GetLast100ActiveAdvertsByCategory(id);
                 return View(list);

              }
                
                
             
        
        }


          [HttpGet]
          public ActionResult GetAdvertByCategoryAsPartialView(int id)
          {
              AdvertService srv = new AdvertService();

              if (id == 0)
              {
                  var list = srv.GetLast100ActiveAdverts();
                  return PartialView(list);
              }
              else
              {
                  var list = srv.GetLast100ActiveAdvertsByCategory(id);
                  return PartialView(list);

              }




          }
          [HttpPost]
          public ActionResult File(HttpPostedFileBase file)
          {
              // Verify that the user selected a file
              if (file != null && file.ContentLength > 0)
              {
                  // extract only the filename
                  var fileName = Path.GetFileName(file.FileName);
                  var url = "hjg";
                  // store the file inside ~/App_Data/uploads folder
                  var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
                  file.SaveAs(path);
              }
              // redirect back to the index action to show the form once again
              return RedirectToAction("Index");
          }


          [HttpGet]
          public ActionResult ChooseAtributte(OgloszenieModelView adv)
          {
              ModelState.Clear();
              AdvertService srv = new AdvertService();
              var item= srv.GetAtributteForAdvert(adv);

              return View();

          }
          [HttpGet]
          public ActionResult test()
          {
             
              return View();

          }

    }
}
