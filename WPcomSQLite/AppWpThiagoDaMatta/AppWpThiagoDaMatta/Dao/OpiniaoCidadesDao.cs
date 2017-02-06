using AppWpThiagoDaMatta.Conexao;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace AppWpThiagoDaMatta.Dao
{
    class OpiniaoCidadesDao : IDao<OpiniaoCidades>
    {
        private ContextoSQLite Conexao;

        public OpiniaoCidadesDao()
        {
            Conexao = new ContextoSQLite();
        }

        public bool Alterar(OpiniaoCidades t)
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

        public OpiniaoCidades BuscaPorId(int id)
        {
            var existingPessoa = Conexao.getConn().Table<OpiniaoCidades>().ToList().Find(x => x.Id == id);
            return existingPessoa;
        }

        public ObservableCollection<OpiniaoCidades> BuscaPorIdCidade(int idCidade)
        {
            List<OpiniaoCidades> myCollection = Conexao.getConn().Table<OpiniaoCidades>().ToList().Where(x => x.IdCidade == idCidade).ToList();
            ObservableCollection<OpiniaoCidades> objLista = new ObservableCollection<OpiniaoCidades>(myCollection);
            return objLista;
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

        public bool Inserir(OpiniaoCidades t)
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

        public ObservableCollection<OpiniaoCidades> ListaTodos()
        {
            try
            {
                List<OpiniaoCidades> myCollection = Conexao.getConn().Table<OpiniaoCidades>().ToList();
                ObservableCollection<OpiniaoCidades> objLista = new ObservableCollection<OpiniaoCidades>(myCollection);
                return objLista;
            }
            catch (Exception e)
            {
                return new ObservableCollection<OpiniaoCidades>();
            }
        }

        ObservableCollection<OpiniaoCidades> IDao<OpiniaoCidades>.ListaTodos()
        {
            throw new NotImplementedException();
        }
    }
}