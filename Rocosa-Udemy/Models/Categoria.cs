using System.ComponentModel.DataAnnotations;

namespace Rocosa_Udemy.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Nombre de categoría obligatorio.")]
        public string NombreCategoria { get; set; }
        [Required(ErrorMessage="Orden obligatoria")]
        [Range(1, int.MaxValue, ErrorMessage = "El orden debe ser mayor a 0.")]
        public int MostrarOrden { get; set; }
    }
}
