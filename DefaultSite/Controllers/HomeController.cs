using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DefaultSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.StatusCode = 404;
            return null;
        }
    }
}