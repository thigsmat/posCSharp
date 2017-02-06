using System.ComponentModel.DataAnnotations;

namespace WebApp.Model
{
    public class OpiniaoCidades : IDados
    {
        [Key]
        public int Id { get; set; }
        public int IdCidade { get; set; }
        public string Opiniao { get; set; }

    }
}
