using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDCORE.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string? UserName { get; set; }
        public string? Clave { get; set; }

        [NotMapped]
        public bool MantenerActivo { get; set; }    
    }
}
