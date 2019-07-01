using System.Linq;
using System.Web.Mvc;
using Game.Dal.Base;
using Game.MVC.Models;

namespace Game.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(Member user)
        {
                using (DBModels db = new DBModels())
                {
                    var userDetail = db.Member.Where( x => x.Account == user.Account && x.Password == user.Password).FirstOrDefault();
                    if (userDetail == null)
                    {
                        user.LoginErrorMessage = "錯誤的使用者帳戶或密碼";
                        return View("Index",user);
                    }
                    else
                    {
                        Session["Account"] = user.Account;
                        return RedirectToAction("Index", "Home");
                    }
                }
        }
  

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}