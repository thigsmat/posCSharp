using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceAtividade_III.Repositorio
{
    [DataContract]
    public class Aluno
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public double Nota1 { get; set; }
        [DataMember]
        public double Nota2 { get; set; }
        [DataMember]
        public double Nota3 { get; set; }
    }
}