using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;

namespace Wmb.Controllers
{
    public class HomeController : CustomBaseController
    {
        public ActionResult Index()
        {
            string localizedAbout = Resources.LocalizedText.Home;

            ViewBag.Message = Resources.LocalizedText.Home;
            return View();
        }

        [HttpPost]
        public ActionResult Culture(string redirectUrl)
        {
            string culture = (string)Request.Form["CultureList"];
            this.Session["culture"] = culture;

            // TODO: Save the culture in the user's profile

            return Redirect(redirectUrl);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
