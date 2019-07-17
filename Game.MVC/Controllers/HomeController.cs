using Game.Common.Entities;
using Game.Core;
using Game.MVC.Models;
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(Account user)
        {
            var ms = new MemberService();
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if (ms.Auth(new Member { Account = user.Name , Password = user.Password}))
                {
                    Session["Account"] = user.Name;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    user.LoginErrorMessage = "錯誤的使用者帳戶或密碼";
                    return View("Login", user);
                }
            }
        }
    }
}