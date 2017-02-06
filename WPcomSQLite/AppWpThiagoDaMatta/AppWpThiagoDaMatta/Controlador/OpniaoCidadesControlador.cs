using AppWpThiagoDaMatta.Dao;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.ObjectModel;

namespace AppWpThiagoDaMatta.Controlador
{
    public class OpiniaoCidadesControlador
    {
        private OpiniaoCidadesDao _Dao;

        public OpiniaoCidadesControlador()
        {
            _Dao = new OpiniaoCidadesDao();
        }

        public ObservableCollection<OpiniaoCidades> ListaTodos()
        {
            return _Dao.ListaTodos();
        }

        public ObservableCollection<OpiniaoCidades> ListaTodosPorCidade(int IdCidade)
        {
            return _Dao.BuscaPorIdCidade(IdCidade);
        }

        internal void Salvar(OpiniaoCidades opniaoCidades)
        {
            if (opniaoCidades == null)
                throw new Exception("Registro está vazio");

            if (opniaoCidades.Id == 0)
                _Dao.Inserir(opniaoCidades);
            else
                _Dao.Alterar(opniaoCidades);
        }

        internal void ExcluirPorCidade(int idCidade) {
            foreach (var item in _Dao.BuscaPorIdCidade(idCidade))
            {
                _Dao.Excluir(item.Id);
            }
        }
    }
}