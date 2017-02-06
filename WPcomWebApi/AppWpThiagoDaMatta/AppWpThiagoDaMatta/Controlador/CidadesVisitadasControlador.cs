using AppWpThiagoDaMatta.Contexto;
using AppWpThiagoDaMatta.Controlador;
using AppWpThiagoDaMatta.Dao;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AppWpThiagoDaMatta.Controller
{
    public class CidadesVisitadasControlador
    {
        private CidadesVisitadasRest _Rest;

        public CidadesVisitadasControlador()
        {
            _Rest = new CidadesVisitadasRest();
        }


        public async Task<ObservableCollection<CidadesVisitadas>> ListaTodos()
        {
            return await _Rest.ListaTodos();
        }

        public async Task Salvar(CidadesVisitadas cidadesVisistadas)
        {
            if (cidadesVisistadas == null)
                throw new Exception("Registro está vazio");

            if (cidadesVisistadas.Id == 0)
               await _Rest.Inserir(cidadesVisistadas);
            else
                await _Rest.Alterar(cidadesVisistadas);
        }

        public async Task ExcluirCidade(int id)
        {
            await new OpiniaoCidadesControlador().ExcluirPorCidade(id);
            await _Rest.Excluir(id);
        }

        public async Task ExcluirTodasCidades()
        {
            foreach (var item in await ListaTodos())
            {
              await  ExcluirCidade(item.Id);
            }
        }
    }
}
