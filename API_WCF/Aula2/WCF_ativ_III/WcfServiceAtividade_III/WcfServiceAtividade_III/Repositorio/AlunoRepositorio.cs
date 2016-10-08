using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceAtividade_III.Repositorio
{
    public class AlunoRepositorio
    {
        public static List<Aluno> listaAlunos;
        public AlunoRepositorio()
        {
            listaAlunos = new List<Aluno>(){
                new Aluno() { Id=1,Nome="Zé da Pinga1", Nota1 = 5,Nota2 = 1,Nota3 = 5 },
                new Aluno() { Id=2,Nome="Zé da Pinga2", Nota1 = 2,Nota2 = 1,Nota3 = 0 },
                new Aluno() { Id=3,Nome="Zé da Pinga3", Nota1 = 6,Nota2 = 4,Nota3 = 0 },
                new Aluno() { Id=4,Nome="Zé da Pinga4", Nota1 = 8,Nota2 = 5,Nota3 = 5 },
                new Aluno() { Id=5,Nome="Zé da Pinga5", Nota1 = 9,Nota2 = 4,Nota3 = 5 },
                new Aluno() { Id=6,Nome="Zé da Pinga6", Nota1 = 4,Nota2 = 3,Nota3 = 5 },
           };
        }

        public List<Aluno> ListAlunos()
        {
            return listaAlunos;
        }


        public Aluno GetAluno(int id)
        {
            return listaAlunos.Find(x => x.Id == id);
        }

        public double GetMedia(int id)
        {
            var aluno = listaAlunos.Find(x => x.Id == id);
            return Math.Round(((aluno.Nota1 + aluno.Nota2 + aluno.Nota3) / 3), 2);
        }
    }
}