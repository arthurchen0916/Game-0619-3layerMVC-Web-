using Game.Common.Entities;
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

        //Add功能
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Monster model)
        {
            monsterService = new MonsterService();
            var chk = monsterService.Add(model);

            if (chk)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }

        //Delete功能
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            monsterService = new MonsterService();
            var chk = monsterService.Delete((int)id);
            if (chk)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }


        //Details功能
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            monsterService = new MonsterService();
            var chk = monsterService.Query((int)id);
            if (chk == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(chk);
            }
        }

        //Edit功能
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            monsterService = new MonsterService();
            var chk = monsterService.Query((int)id);
            if (chk == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(chk);
            }
        }

        [HttpPost]
        public ActionResult Edit(Monster model)
        {
            monsterService = new MonsterService();
            var chk = monsterService.Update(model);
            if (chk)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

    }
}