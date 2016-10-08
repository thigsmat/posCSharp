﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtividadeConsumirWScorreios
{
    public class dadosConsulta
    {
        public string nCdEmpresa { get; set; }
        public string sDsSenha { get; set; }
        public string nCdServico { get; set; }
        public string sCepOrigem { get; set; }
        public string sCepDestino { get; set; }
        public string nVlPeso { get; set; }
        public int nCdFormato { get; set; }
        public decimal nVlComprimento { get; set; }
        public decimal nVlAltura { get; set; }
        public decimal nVlLargura { get; set; }
        public decimal nVlDiametro { get; set; }
        public string sCdMaoPropria { get; set; }
        public decimal nVlValorDeclarado { get; set; }
        public string sCdAvisoRecebimento { get; set; }
    }
}