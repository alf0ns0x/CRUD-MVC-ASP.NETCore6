using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;


namespace CRUDCORE.Models
{
    public class ContactoModel
    {
        public int IdContacto { get; set; }
        
        [Required(ErrorMessage="Rellenar el campo es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Rellenar el campo es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Rellenar el campo es obligatorio")]
        public string? Correo { get; set; }
    }
}
