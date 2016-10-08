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

    public class AlunoService : IAlunoService
    {
        private AlunoRepositorio rep;

        public AlunoService()
        {
            if (rep == null)
                rep = new AlunoRepositorio();
        }

        public Aluno GetAluno(int id)
        {
          return  rep.GetAluno(id);
        }

        public double GetMedia(int id)
        {
           return rep.GetMedia(id);
        }

        public List<Aluno> ListAlunos()
        {
            return rep.ListAlunos();
        }
    }
}

