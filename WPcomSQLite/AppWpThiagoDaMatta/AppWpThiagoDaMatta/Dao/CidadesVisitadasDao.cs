using AppWpThiagoDaMatta.Conexao;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWpThiagoDaMatta.Dao
{
    public class CidadesVisitadasDao : IDao<CidadesVisitadas>
    {
        private ContextoSQLite Conexao;

        public CidadesVisitadasDao()
        {
            Conexao = new ContextoSQLite();
        }

        public bool Alterar(CidadesVisitadas t)
        {
            try
            {
                var existingPessoa = BuscaPorId(t.Id);
                if (existingPessoa != null)
                {
                    Conexao.getConn().RunInTransaction(() =>
                        {
                            Conexao.getConn().Update(t);
                        });
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CidadesVisitadas BuscaPorId(int id)
        {
            var existingPessoa = Conexao.getConn().Table<CidadesVisitadas>().ToList().Find(x => x.Id == id);
            return existingPessoa;
        }

        public bool Excluir(int id)
        {
            try
            {
                var existingPessoa = BuscaPorId(id);
                if (existingPessoa != null)
                {
                    Conexao.getConn().RunInTransaction(() =>
                    {
                        Conexao.getConn().Delete(existingPessoa);
                    });
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Inserir(CidadesVisitadas t)
        {
            try
            {
                Conexao.getConn().RunInTransaction(() =>
                {
                    Conexao.getConn().Insert(t);
                });

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ObservableCollection<CidadesVisitadas> ListaTodos()
        {
            try
            {
                List<CidadesVisitadas> myCollection = Conexao.getConn().Table<CidadesVisitadas>().ToList();
                ObservableCollection<CidadesVisitadas> objLista = new ObservableCollection<CidadesVisitadas>(myCollection);
                return objLista;
            }
            catch (Exception)
            {
                return new ObservableCollection<CidadesVisitadas>();
            }
        }
    }
}
