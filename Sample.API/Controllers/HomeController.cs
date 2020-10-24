using System.Web.Mvc;

namespace Sample.API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("~/swagger/ui/index");
        }
    }
}
