
using System.ComponentModel.DataAnnotations;

namespace WebApp.Model
{
    public class CidadesVisitadas:IDados
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
