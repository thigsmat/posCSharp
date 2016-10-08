using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWS_Aluno.ServiceReferenceAluno;

namespace ClienteWS_Aluno
{
    public partial class ClienteWebForms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtCarregar_Click(object sender, EventArgs e)
        {
            lblerro.Text = "";
            ServicoAlunoSoapClient servico = new ServicoAlunoSoapClient();
            try
            {
                var retorno = servico.CarregarAlunos();
                grvAlunos.DataSource = retorno;
                grvAlunos.DataBind();
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