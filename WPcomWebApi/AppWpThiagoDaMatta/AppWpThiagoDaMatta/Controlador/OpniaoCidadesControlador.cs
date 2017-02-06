using AppWpThiagoDaMatta.Dao;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AppWpThiagoDaMatta.Controlador
{
    public class OpiniaoCidadesControlador
    {
        private OpiniaoCidadesRest _Rest;

        public OpiniaoCidadesControlador()
        {
            _Rest = new OpiniaoCidadesRest();
        }

        public async Task<ObservableCollection<OpiniaoCidades>> ListaTodos()
        {
            return  await _Rest.ListaTodos();
        }

        public async Task<ObservableCollection<OpiniaoCidades>> ListaTodosPorCidade(int IdCidade)
        {
            return await _Rest.BuscaPorIdCidade(IdCidade);
        }

        internal async Task Salvar(OpiniaoCidades opniaoCidades)
        {
            if (opniaoCidades == null)
                throw new Exception("Registro está vazio");

            if (opniaoCidades.Id == 0)
                await _Rest.Inserir(opniaoCidades);
            else
                await _Rest.Alterar(opniaoCidades);
        }

        internal async Task ExcluirPorCidade(int idCidade)
        {
            foreach (var item in await _Rest.BuscaPorIdCidade(idCidade))
            {
                await _Rest.Excluir(item.Id);
            }
        }
    }
}