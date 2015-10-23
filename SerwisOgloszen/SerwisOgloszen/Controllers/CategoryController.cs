using DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SerwisOgloszen.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllCategory()
        {
            CategoryService ser = new CategoryService();
            var category = ser.GetAllCategory();
            return Json(category, JsonRequestBehavior.AllowGet);

        }

    }
}
