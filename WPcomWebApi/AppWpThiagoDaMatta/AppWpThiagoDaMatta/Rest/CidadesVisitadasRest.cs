using AppWpThiagoDaMatta.Contexto;
using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AppWpThiagoDaMatta.Uteis;

namespace AppWpThiagoDaMatta.Dao
{
    public class CidadesVisitadasRest
    {
        public async Task<bool> Alterar(CidadesVisitadas request)
        {
            try
            {
                var cidade = await new ContextoRest<CidadesVisitadas>().RequisicaoRestCrud("cidade/alterar/"+request.Id, Constantes.GET, request);
                if (cidade == null)
                    return false;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CidadesVisitadas> BuscaPorId(int id)
        {
            try
            {
                var existingPessoa = await new ContextoRest<CidadesVisitadas>().RequisicaoRestPesquisa("cidade/pesquisa/"+id, Constantes.GET);

                return existingPessoa;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public async Task<bool> Excluir(int id)
        {
            try
            {
                var cidade = await new ContextoRest<CidadesVisitadas>().RequisicaoRestPesquisa("cidade/excluir/" + id, Constantes.DELETE);
                if (cidade == null)
                    return false;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Inserir(CidadesVisitadas request)
        {
            try
            {
                var cidade = await new ContextoRest<CidadesVisitadas>().RequisicaoRestCrud("cidade/novo", Constantes.POST, request);
                if (cidade == null)
                    return false;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ObservableCollection<CidadesVisitadas>> ListaTodos()
        {
            try
            {
                var objLista = await new ContextoRest<ObservableCollection<CidadesVisitadas>>().RequisicaoRestPesquisa("cidade/lista", Constantes.GET);
                return objLista;
            }
            catch (Exception)
            {
                return new ObservableCollection<CidadesVisitadas>();
            }
        }
    }
}
