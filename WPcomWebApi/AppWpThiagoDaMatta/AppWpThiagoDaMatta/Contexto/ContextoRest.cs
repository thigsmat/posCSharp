using AppWpThiagoDaMatta.Model;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppWpThiagoDaMatta.Contexto
{
    public class ContextoRest<T>
    {
        private string urlApi = "http://localhost:60844/api/";

        public ContextoRest()
        {
          
        }

        public async Task<T> RequisicaoRestCrud(string uri, string metodo, IDados obj)
        {
            HttpWebRequest httpWebRequest = RequisicaoCreate(uri, metodo);

            using (var streamWriter = new StreamWriter(await httpWebRequest.GetRequestStreamAsync()))
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                streamWriter.Write(json);
                streamWriter.Flush();
            }


            try
            {
                var httpResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
                Stream dataStream = httpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                T objRetorno = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(reader.ReadToEnd());

                return objRetorno;
            }
            catch (WebException e)
            {
                //if (e.Status == WebExceptionStatus.ProtocolError)
                //    Console.WriteLine("Status Description : {0}", ((HttpWebResponse)e.Response).StatusDescription);

                return default(T);
            }
        }

        private HttpWebRequest RequisicaoCreate(string uri, string metodo)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(urlApi + uri);
            httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = metodo;
            return httpWebRequest;
        }

        public async Task<T> RequisicaoRestPesquisa(string uri,string metodo)
        {
            var httpWebRequest = RequisicaoCreate(uri, metodo);

            try
            {
               var httpResponse =(HttpWebResponse) await httpWebRequest.GetResponseAsync();
                Stream dataStream = httpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                T obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
                return obj;
            }
            catch (WebException e)
            {
                throw new Exception(e.Status + " - " + e.Message + " - " + e.InnerException);
            }
        }
    }
}
