using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;
using System.Threading;

namespace Wmb.Controllers
{
    public class CustomBaseController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);

            // TODO: Need to check if user is authenticated. If yes, set the Session culture to their preference

            string culture = requestContext.HttpContext.Session["culture"] as string;
            {
                if (!String.IsNullOrWhiteSpace(culture))
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(culture);
                }
            }
        }
    }
}