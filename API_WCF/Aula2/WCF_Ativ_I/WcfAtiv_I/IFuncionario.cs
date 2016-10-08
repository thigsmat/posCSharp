using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfAtiv_I
{
    [ServiceContract]
    public interface IFuncionario
    {
        [OperationContract]
        List<Funcionario> ListarFuncionario();
        [OperationContract]
        Funcionario SelecioarFuncionario(int id);
    }
}
