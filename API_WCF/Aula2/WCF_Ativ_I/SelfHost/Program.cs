using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfAtiv_I;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost servHost = new ServiceHost(typeof(ServicoFuncionario));
            Uri endereco = new Uri("http://localhost:8080/ServicoFuncionario/");

            servHost.AddServiceEndpoint(typeof(IFuncionario),new BasicHttpBinding(),endereco);

            try
            {
                servHost.Open();
                Console.WriteLine("O servico {0} está on-line",servHost.Description.ServiceType);

                foreach (var item in servHost.Description.Endpoints)
                {
                    Console.WriteLine("+  Servico: {0} | EndPoints: {1} ", servHost.Description.ServiceType,item.Address);
                }

                Console.ReadLine();

                servHost.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("O servico {0} deu erro: {1}", servHost.Description.ServiceType,ex.Message);
                servHost.Abort();

                Console.ReadLine();
            }
        }
    }
}
