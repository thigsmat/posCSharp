using Aula3.Models.ModelsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Aula3.Controllers
{
    public class LoginController : Controller
    {
     

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (model.Login.Equals("admin") && model.Senha.Equals("admin"))
            {
                FormsAuthentication.SetAuthCookie(model.Login, false);

                if (!String.IsNullOrEmpty(model.ReturnUrl)) {
                    return Redirect(model.ReturnUrl);
                }
                return RedirectToAction("index", "Products");

            }

            ModelState.AddModelError("Login", "Login inválido cabeçudo!");

            return View();
        }
    }
}