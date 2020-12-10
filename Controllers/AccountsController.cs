using FuzzBrain.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace FuzzBrain.Controllers
{   
    public class AccountsController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            using (FuzzBrainDBContext context = new FuzzBrainDBContext()) 
            {
                bool isValidUser = context.Users.Any(user => user.UserName.ToLower() == model.UserName.ToLower() && 
                                                            user.UserPassword == model.UserPassword);
                if (isValidUser)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }

                ModelState.AddModelError(string.Empty, "Invalid Username or Password");
                return View();
            }            
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(User model)
        {
            using (FuzzBrainDBContext context = new FuzzBrainDBContext())
            {
                context.Users.Add(model);
                context.SaveChanges();
            }

            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}