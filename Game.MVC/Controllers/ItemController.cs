using Game.Core;
using System.Linq;
using System.Web.Mvc;

namespace Game.MVC.Controllers
{
    public class ItemController : Controller
    {
        ItemService itemService;

        // GET: Item
        public ActionResult Index()
        {
            itemService = new ItemService();
            var model = itemService.GetAll().ToList();
            return View(model);
        }
    }
}