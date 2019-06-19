using Game.Core;
using System.Linq;
using System.Web.Mvc;

namespace Game.MVC.Controllers
{
    public class TreasureController : Controller
    {
        TreasureService treasureService;

        // GET: Treasure
        public ActionResult Index()
        {
            treasureService = new TreasureService();
            var model = treasureService.GetAll().ToList();
            return View(model);
        }
    }
}