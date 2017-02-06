using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWpThiagoDaMatta.Model
{
    public class OpiniaoCidades : IDados
    {
        [SQLite.Net.Attributes.PrimaryKey, SQLite.Net.Attributes.AutoIncrement]
        public int Id { get; set; }
        public int IdCidade { get; set; }
        public string Opiniao { get; set; }
    }
}
