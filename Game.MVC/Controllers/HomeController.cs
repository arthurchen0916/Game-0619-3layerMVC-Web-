using Game.Core;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        ItemService itemService;


        public ActionResult Index()
        {
            itemService = new ItemService();
            var model = itemService.GetAll().ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Authorise(Login account)
        {
            if (account == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("About", "Home");
            }

        }
    }
}