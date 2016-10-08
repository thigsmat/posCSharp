using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceAtividade_III.Repositorio;

namespace WcfServiceAtividade_III
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAlunoService
    {

        [OperationContract]
        List<Aluno> ListAlunos();

        [OperationContract]
        Aluno GetAluno(int id);

        [OperationContract]
        double GetMedia(int id);
    }


  
}
