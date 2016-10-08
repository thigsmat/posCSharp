using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site1.Controllers
{
    public class BaseController : Controller
    {
        public static List<string> Usuarios;

        static BaseController()
        {
            using (var db = new Contexto())
            {
                Usuarios = db.Usuarios.Select(x => x.Email).ToList();
            }
        }

        public Contexto Db { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Db == null)
            {
                Db = new Contexto();
            }

            base.OnActionExecuting(filterContext);
        }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        protected override void Dispose(bool disposing)
        {
            if (Db != null && disposing)
            {
                Db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}