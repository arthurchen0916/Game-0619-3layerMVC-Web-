using Game.Common.Entities;
using Game.Core;
using System.Linq;
using System.Web.Mvc;

namespace Game.MVC.Controllers
{
    public class MemberController : Controller
    {
        MemberService memberService;

        // GET: Member
        public ActionResult Index()
        {
            memberService = new MemberService();
            var model = memberService.GetAll().ToList();
            return View(model);
        }

        //Add功能
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Member model)
        {
            memberService = new MemberService();
            var chk = memberService.Add(model);

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
            memberService = new MemberService();
            var chk = memberService.Delete((int)id);
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
            memberService = new MemberService();
            var chk = memberService.Query((int)id);
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
            memberService = new MemberService();
            var chk = memberService.Query((int)id);
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
        public ActionResult Edit(Member model)
        {
            memberService = new MemberService();
            var chk = memberService.Update(model);
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