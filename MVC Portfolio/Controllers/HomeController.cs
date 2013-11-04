using System.Web.Mvc;

namespace MVCPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Information()
        {
            return View();
        }
        

    }
}
