using comandamancare.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace comandamancare.Controllers
{
    public class EmployeeSurfaceController : SurfaceController
    {

        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/Employee/";
        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_Employee.cshtml");
        }

    }

    }