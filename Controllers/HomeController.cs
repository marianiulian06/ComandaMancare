using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comandamancare.Controllers
{
    public class HomeController : Controller
    {
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/ContactSugestiiClienti/";
        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_ContactSugestiiClienti.cshtml");
        }
        public ActionResult Index()
        {
            TempData["name"] = "Bill";

            return View();
        }

        public ActionResult About()
        {
            //the following throws exception as TempData["name"] is null 
            //because we already accessed it in the Index.cshtml view
            //name = TempData["name"].ToString(); 

            return View();
        }

        public ActionResult Contact()
        {
            //the following throws exception as TempData["name"] is null 
            //because we already accessed it in the Index.cshtml view
            //name = TempData["name"].ToString(); 

            return View();
        }
    }
}