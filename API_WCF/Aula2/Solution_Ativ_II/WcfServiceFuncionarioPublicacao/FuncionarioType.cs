using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfServiceFuncionarioPublicacao
{
    [DataContract]
    public class FuncionarioType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public double Salario { get; set; }

        [DataMember]
        public DateTime DataCadastro { get; set; }
    }
}
