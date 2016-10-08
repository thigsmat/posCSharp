using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Site1.Models.Validations
{
    public class CpfAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var cpf = value.ToString();
            cpf = Regex.Replace(cpf, "[^0-9]", "");

            return true;
        }
    }
}