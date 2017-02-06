using AppWpThiagoDaMatta.Model;
using System;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using Windows.Storage;
using System.IO;

namespace AppWpThiagoDaMatta.Conexao
{
    public class ContextoSQLite
    {
        public static string DB_NAME = "DadosApp.sqlite";
        public static string DB_PATH =
           Path.Combine(
               Path.Combine(ApplicationData.Current.LocalFolder.Path, DB_NAME));

        private static SQLiteConnection conn;

        public void CreateDatabase()
        {
            if (!CheckFileExists(DB_NAME).Result)
            {
                getConn().CreateTable<OpiniaoCidades>();
                getConn().CreateTable<OpiniaoCidades>();
            }
        }

        private async Task<bool> CheckFileExists(string fileName)
        {
            try
            {
                var store = await ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SQLiteConnection getConn()
        {
            if (conn == null)
                conn = new SQLiteConnection(new SQLitePlatformWinRT(), DB_PATH);

            return conn;
        }
    }
}