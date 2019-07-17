using Game.Common.Entities;
using Game.Core;
using System.Collections.Generic;
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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Item model)
        {
            itemService = new ItemService();
            var chk = itemService.Add(model);
            if (chk)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Detail(int? id)
        {
            if (null == id)
            {
                return HttpNotFound();
            }

            itemService = new ItemService();
            var chk = itemService.Query((int)id);
            if (null == chk)
            {
                return HttpNotFound();
            }
            else
            {
                return View(chk);
            }
        }

        public ActionResult Edit(int? id)
        {
            if (null == id)
            {
                return HttpNotFound();
            }

            itemService = new ItemService();
            var chk = itemService.Query((int)id);
            if (null == chk)
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

        public ActionResult Delete(int? id)
        {
            if (null == id)
            {
                return HttpNotFound();
            }

            itemService = new ItemService();
            var chk = itemService.Remove((int)id);
            if (chk)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return HttpNotFound();
            }
        }

        public ActionResult Query()
        {
            itemService = new ItemService();
            var items = itemService.GetAll().ToList();

            ViewBag.Items = items.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.Name,
                                      Value = x.Id.ToString()
                                  });
            return View(new List<Item>());
        }

        [HttpPost]
        public ActionResult Query(int weight)
        {
            itemService = new ItemService();
            var items = itemService.GetAll().ToList();

            ViewBag.Items = items.Select(x =>
                                  new SelectListItem()
                                  {
                                      Text = x.Name,
                                      Value = x.Id.ToString()
                                  }); ;


            var model = itemService.QueryByWeight(weight).ToList();
            return View(model);
        }

        public ActionResult QueryByItem(int weight)
        {

            var model = itemService.QueryByWeight(weight).ToList();
            return View(model);

        }
    }
}