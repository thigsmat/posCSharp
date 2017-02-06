using AppWpThiagoDaMatta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using AppWpThiagoDaMatta.Contexto;
using System.Threading.Tasks;
using AppWpThiagoDaMatta.Uteis;

namespace AppWpThiagoDaMatta.Dao
{
   public class OpiniaoCidadesRest 
    {

        public async Task<bool> Alterar(OpiniaoCidades request)
        {
            try
            {
                var opiniao = await new ContextoRest<OpiniaoCidades>().RequisicaoRestCrud("opiniao/alterar/"+request.Id, Constantes.PUT, request);
                if (opiniao == null)
                    return false;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ObservableCollection<OpiniaoCidades>> BuscaPorIdCidade(int idCidade)
        {
            try
            {
                var opiniao = await new ContextoRest<ObservableCollection<OpiniaoCidades>>().RequisicaoRestPesquisa("opiniao/listaPorCidade/" + idCidade, Constantes.GET);

                return opiniao;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<OpiniaoCidades> BuscaPorId(int id)
        {
            try
            {
                var opiniao = await new ContextoRest<OpiniaoCidades>().RequisicaoRestPesquisa("opiniao/pesquisa/" + id, Constantes.GET);

                return opiniao;
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
                var opiniao = await new ContextoRest<OpiniaoCidades>().RequisicaoRestPesquisa("opiniao/excluir/" + id, Constantes.DELETE);
                if (opiniao == null)
                    return false;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Inserir(OpiniaoCidades request)
        {
            try
            {
                var opiniao = await new ContextoRest<OpiniaoCidades>().RequisicaoRestCrud("opiniao/novo", Constantes.POST, request);
                if (opiniao == null)
                    return false;

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ObservableCollection<OpiniaoCidades>> ListaTodos()
        {
            try
            {
                var objLista = await new ContextoRest<ObservableCollection<OpiniaoCidades>>().RequisicaoRestPesquisa("opiniao/lista", Constantes.GET);
                return objLista;
            }
            catch (Exception)
            {
                return new ObservableCollection<OpiniaoCidades>();
            }
        }
    }
}
