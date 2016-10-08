using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceFuncionarioPublicacao
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFuncionario" in both code and config file together.
    [ServiceContract]
    public interface IFuncionario
    {
        [OperationContract]
        List<FuncionarioType> ListarFuncionario();
        [OperationContract]
        FuncionarioType SelecioarFuncionario(int id);
        [OperationContract]
        List<FuncionarioType> SelecioarFuncionarioPorNome(string nome);
    }
}
