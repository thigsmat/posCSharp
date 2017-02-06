using AppWpThiagoDaMatta.Controlador;
using AppWpThiagoDaMatta.Dao;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.ObjectModel;

namespace AppWpThiagoDaMatta.Controller
{
    public class CidadesVisitadasControlador
    {
        private CidadesVisitadasDao _Dao;

        public CidadesVisitadasControlador()
        {
            _Dao = new CidadesVisitadasDao();
        }


        public ObservableCollection<CidadesVisitadas> ListaTodos()
        {
            return _Dao.ListaTodos();
        }

        public void Salvar(CidadesVisitadas cidadesVisistadas)
        {
            if (cidadesVisistadas == null)
                throw new Exception("Registro está vazio");

            if (cidadesVisistadas.Id == 0)
                _Dao.Inserir(cidadesVisistadas);
            else
                _Dao.Alterar(cidadesVisistadas);
        }

        internal void ExcluirCidade(int id)
        {
            new OpiniaoCidadesControlador().ExcluirPorCidade(id);
            _Dao.Excluir(id);
        }

        internal void ExcluirTodasCidades()
        {
            foreach (var item in ListaTodos())
            {
                ExcluirCidade(item.Id);
            }
        }
    }
}
