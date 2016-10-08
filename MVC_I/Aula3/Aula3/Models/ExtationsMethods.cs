using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula3.Models
{
    public static class ExtationsMethods
    {
        public static string ToMoeda(this decimal? valor)
        {
            if (valor.HasValue)
            {
                return valor.Value.ToString("C");
            }

            return string.Empty;
        }

    
    }
}