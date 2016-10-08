using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;

namespace WcfFuncionarioRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFuncionario" in both code and config file together.
    [ServiceContract]
    public interface IFuncionario
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "ListFuncionario/")]
        List<FuncionarioType> ListarFuncionario();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetFuncionario/{id}")]
        FuncionarioType SelecioarFuncionario(string id);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetNomeFuncionario/{nome}")]
        List<FuncionarioType> SelecioarFuncionarioPorNome(string nome);

        [OperationContract]
        [WebInvoke(Method = "PUT", ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddFuncionario/{id},{nome},{salario}")]
        bool AddFuncionario(string id, string nome, string salario);
    }
}
