using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Site1.Models.Validations
{
    public class CpfAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var cpf = value.ToString();

            cpf = Regex.Replace(cpf, "[^0-9]", "");

            if (string.IsNullOrEmpty(cpf) || cpf.Length != 11 || cpf.Distinct().Count() == 1)
            {
                return false;
            }

            // Valida 1o digito
            int add = 0;
            for (int i = 0; i < 9; i++)
                add += int.Parse(cpf.ElementAt(i).ToString()) * (10 - i);
            int rev = 11 - (add % 11);
            if (rev == 10 || rev == 11)
                rev = 0;
            if (rev != int.Parse(cpf.ElementAt(9).ToString()))
                return false;

            // Valida 2o digito
            add = 0;
            for (int i = 0; i < 10; i++)
                add += int.Parse(cpf.ElementAt(i).ToString()) * (11 - i);
            rev = 11 - (add % 11);
            if (rev == 10 || rev == 11)
                rev = 0;
            if (rev != int.Parse(cpf.ElementAt(10).ToString()))
                return false;

            return true;
        }
    }
}