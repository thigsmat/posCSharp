using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClienteWCF_ativ_III_AlunoService.ServiceReferenceAluno;

namespace ClienteWCF_ativ_III_AlunoService
{
    public partial class WebFormAlunos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                AlunoServiceClient client = new AlunoServiceClient();
                GridViewAlunos.DataSource = client.ListAlunos();
                GridViewAlunos.DataBind();
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
                var listFunc = new List<Aluno>();
                AlunoServiceClient client = new AlunoServiceClient();

                foreach (var item in lstr)
                {
                    listFunc.Add(client.GetAluno(Convert.ToInt32(item)));
                }

                GridViewAlunos.DataSource = listFunc;
                GridViewAlunos.DataBind();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void btnMedia_Click(object sender, EventArgs e)
        {
            try
            {
                var listFunc = new List<Aluno>();
                AlunoServiceClient client = new AlunoServiceClient();

                listFunc.Add(client.GetAluno(Convert.ToInt32(txtIDMedia.Text)));
                txtMedia.Text = Convert.ToString(client.GetMedia(Convert.ToInt32(txtIDMedia.Text)));

                GridViewAlunos.DataSource = listFunc;
                GridViewAlunos.DataBind();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}