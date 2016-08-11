using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Haneef.Controllers
{
    public class LangController : Controller
    {
        //
        // GET: /Lang/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Change(string lang)
            {
            if (lang != null)
                {

                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);

                }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = lang;
            Response.Cookies.Add(cookie);

            return View("Index");
            }

    }
}
