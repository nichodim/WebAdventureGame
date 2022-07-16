using System.Web.Mvc;

namespace WebAdventureGame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}