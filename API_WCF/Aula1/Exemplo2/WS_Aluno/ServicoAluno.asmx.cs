using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_Aluno
{
    /// <summary>
    /// Summary description for ServicoAluno
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoAluno : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<Aluno> CarregarAlunos()
        {
            return new List<Aluno> {
                                        new Aluno() {Id=1,Nome="Thiago",Nota=10 },
                                        new Aluno() {Id=2,Nome="Thiago1",Nota=5 },
                                        new Aluno() {Id=3,Nome="Thiago2",Nota=6 },
                                        new Aluno() {Id=4,Nome="Thiago3",Nota=7 },
                                        new Aluno() {Id=5,Nome="Thiago4",Nota=8 },
                                        new Aluno() {Id=6,Nome="Thiago5",Nota=9 },

                                    };
        }
    }
}
