using System.ComponentModel.DataAnnotations;

namespace Rocosa_Udemy.Models
{
    public class TipoAplicacion
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del tipo de aplicación es obligatorio.")]
        public string? Nombre { get; set; }
    }
}
