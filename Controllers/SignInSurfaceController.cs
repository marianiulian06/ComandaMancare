using comandamancare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Install.Models;
using Umbraco.Web.Mvc;

namespace comandamancare.Controllers
{
    public class SignInSurfaceController : SurfaceController
    {
        // GET: SignInSurface
        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/SignIn/";
        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_SignIn.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult SubmitForm(User userModel)
        {
          

            using(UmbracoDatabaseEntities db = new UmbracoDatabaseEntities() )
            {

                var userDetails = db.Users.Where( x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                if( userDetails == null)
                {
                    userModel.LoginErrorMessage = "username sau parola gresita.";

                    return PartialView(PARTIAL_VIEW_FOLDER + "_SignInError.cshtml");
                }

            }

            return PartialView(PARTIAL_VIEW_FOLDER + "_SignInSuccess.cshtml");
        }
    }
}