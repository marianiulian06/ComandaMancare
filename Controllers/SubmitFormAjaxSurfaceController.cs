using Umbraco.Web.Mvc;
using System.Web.Mvc;
using comandamancare.Models;
using System.Net.Mail;

namespace comandamancare.Controllers
{
    public class SubmitFormAjaxSurfaceController : SurfaceController
    {

        public const string PARTIAL_VIEW_FOLDER = "~/Views/Partials/SubmitFormAjax/";
        public ActionResult RenderForm()
        {
            return PartialView(PARTIAL_VIEW_FOLDER + "_SubmitFormAjax.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //  prevent cross-site request forgery attacks
        public ActionResult SubmitForm(ContactSugestiiClienti model)
        {
            if (ModelState.IsValid)
            {
                SendEmail(model);
                TempData["ContactSucces"] = true;
                return PartialView(PARTIAL_VIEW_FOLDER + "_FormSuccess.cshtml");
            }
            return PartialView(PARTIAL_VIEW_FOLDER + "_FormError.cshtml");

        }

        private void SendEmail(ContactSugestiiClienti model)
        {
            MailMessage message = new MailMessage(model.EmailAddress, "website@comandamancare.web.local");
            message.Subject = string.Format("De la {0} {1} - {2}", model.FirstName, model.LastName, model.EmailAddress);
            message.Body = model.Message;
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }
    }
}