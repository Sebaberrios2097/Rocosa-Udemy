namespace Rocosa_Udemy.Models.ViewModels
{
    public class DetalleVM
    {
        public DetalleVM()
        {
            Producto = new Producto();
        }

        public Producto Producto { get; set; }
        public bool ExisteEnCarro { get; set; }
    }
}
