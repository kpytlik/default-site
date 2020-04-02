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