﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_III.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}