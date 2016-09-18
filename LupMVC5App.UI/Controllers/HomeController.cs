using System.Web.Mvc;

namespace LupMVC5App.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int a = 10;
            return View("Index");
        }
    }
}