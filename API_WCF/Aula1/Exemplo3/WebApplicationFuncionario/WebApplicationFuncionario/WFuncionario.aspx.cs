using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationFuncionario.ServiceReference1;

namespace WebApplicationFuncionario
{
    public partial class WFuncionario : System.Web.UI.Page
    {
               protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            ServicoFuncionarioSoapClient servico = new ServicoFuncionarioSoapClient();
            try
            {
                var retorno = servico.CarregaFuncionario();
                GridView1.DataSource = retorno;
                GridView1.DataBind();

                Label2.Text = servico.SelecionarFuncionario(2).Nome;
                servico.Close();
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                Label1.Text = erro;
                servico.Abort();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }
    }
}