using Game.Core;
using System.Linq;
using System.Web.Mvc;

namespace Game.MVC.Controllers
{
    public class MonsterController : Controller
    {
        MonsterService monsterService;

        // GET: Monster
        public ActionResult Index()
        {
            monsterService = new MonsterService();
            var model = monsterService.GetAll().ToList();
            return View(model);
        }
    }
}