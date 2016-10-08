using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula3.Models.ModelsView
{
    public class LoginViewModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Lembrar { get; set; }
        public string ReturnUrl { get; set; }

    }
}