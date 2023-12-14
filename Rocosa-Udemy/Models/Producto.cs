using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rocosa_Udemy.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string NombreProducto { get; set; }
        [Required(ErrorMessage = "La descripción corta es obligatorio.")]
        public string DescripcionCorta { get; set; }
        [Required(ErrorMessage = "La descripcion del producto es requerida.")]
        public string DescripcionProducto { get; set; }
        [Required(ErrorMessage = "Se requiere el precio del producto")]
        [Range(1, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public double Precio { get; set; }
        public string? ImagenUrl { get; set; }

        // Foreign Key
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual Categoria? Categoria { get; set; }
        public int TipoAplicacionId { get; set; }
        [ForeignKey("TipoAplicacionId")]
        public virtual TipoAplicacion? TipoAplicacion { get; set; }

    }
}
