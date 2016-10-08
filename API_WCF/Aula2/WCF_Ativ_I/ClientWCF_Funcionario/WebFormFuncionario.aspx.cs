using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClientWCF_Funcionario.ServiceReferenceFuncionario;
namespace ClientWCF_Funcionario
{
    public partial class WebFormFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioClient client = new FuncionarioClient();
                GridViewfuncionario.DataSource = client.ListarFuncionario();
                GridViewfuncionario.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected void btnSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                char[] separators = { ',', '.', '!', '?', ';', ':', ' ' };
                List<string> lstr = new List<string>();
                lstr.AddRange(txtBuscar.Text.Split(separators));
                var listFunc = new List<Funcionario>();
                FuncionarioClient client = new FuncionarioClient();

                foreach (var item in lstr)
                {
                    listFunc.Add(client.SelecioarFuncionario(Convert.ToInt32(item)));
                }

                GridViewfuncionario.DataSource = listFunc;
                GridViewfuncionario.DataBind();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}