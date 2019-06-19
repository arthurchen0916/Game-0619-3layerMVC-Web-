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
    }
}