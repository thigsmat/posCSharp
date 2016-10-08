using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AtividadeConsumirWScorreios.ServiceReferenceCorreios;

namespace AtividadeConsumirWScorreios
{
    public partial class ClienteWScorreios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CalcPrecoPrazoWSSoapClient servico = new CalcPrecoPrazoWSSoapClient();
            try
            {
                dadosConsulta dados = new dadosConsulta();
                dados.nCdEmpresa = "";
                dados.sDsSenha = ""; 
                dados.nCdServico= "41106"; 
                dados.sCepOrigem= "87305300";
                dados.sCepDestino = "85845000";
                dados.nVlPeso = "1";
                dados.nCdFormato = 1;
                dados.nVlComprimento = 17;
                dados.nVlAltura = 10;
                dados.nVlLargura = 12;
                dados.nVlDiametro = 10;
                dados.sCdMaoPropria = "S";
                dados.nVlValorDeclarado = 0;
                dados.sCdAvisoRecebimento = "N";

                var retorno = servico.CalcPrecoPrazo(
                    dados.nCdEmpresa, 
                    dados.sDsSenha, 
                    dados.nCdServico, 
                    dados.sCepOrigem,
                    dados.sCepDestino, 
                    dados.nVlPeso, 
                    dados.nCdFormato, 
                    dados.nVlComprimento, 
                    dados.nVlAltura, 
                    dados.nVlLargura, 
                    dados.nVlDiametro,
                    dados.sCdMaoPropria,
                    dados.nVlValorDeclarado,
                    dados.sCdAvisoRecebimento);

                grv.DataSource = retorno.Servicos.ToList();
                grv.DataBind();
                servico.Close();
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                lblerro.Text = erro;
                servico.Abort();
            }
        }
    }
}