using Game.Common.Entities;
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
        
        //Add功能
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Treasure model)
        {
            treasureService = new TreasureService();
            var chk = treasureService.Add(model);

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
            treasureService = new TreasureService();
            var chk = treasureService.Delete((int)id);
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
            treasureService = new TreasureService();
            var chk = treasureService.Query((int)id);
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
            treasureService = new TreasureService();
            var chk = treasureService.Query((int)id);
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
        public ActionResult Edit(Treasure model)
        {
            treasureService = new TreasureService();
            var chk = treasureService.Update(model);
            if (chk)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        //合併
        public ActionResult MonsterItem()
        {
            treasureService = new TreasureService();
            var model = treasureService.QueryName();

            return View(model);
            }
        }
}