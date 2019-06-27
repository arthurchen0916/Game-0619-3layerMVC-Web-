using Game.Common.Entities;
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
        
        //Add功能
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Item model)
        {
            itemService = new ItemService();
            var chk = itemService.Add(model);

            if(chk)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }

            //Delete功能
             public ActionResult Delete(int?id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            itemService = new ItemService();
            var chk = itemService.Delete((int)id);
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
            itemService = new ItemService();
            var chk = itemService.Query((int)id);
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
        public ActionResult Edit (int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            itemService = new ItemService();
            var chk = itemService.Query((int)id);
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
        public ActionResult Edit(Item model)
        {
            itemService = new ItemService();
            var chk = itemService.Update(model);
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