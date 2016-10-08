using DesenvolvimentoWebModuloII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace DesenvolvimentoWebModuloII.Controllers.Api
{
    public class TesteModelBinderController : Controller
    {
        public ActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Post(TesteModelBinder model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Decimal1", "Ocorreu um erro 1");
                ModelState.AddModelError("Decimal2", "Ocorreu um erro 2");
            }
            return View(model);
        }
    }
}
