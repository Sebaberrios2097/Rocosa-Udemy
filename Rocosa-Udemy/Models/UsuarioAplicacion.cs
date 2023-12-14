using Microsoft.AspNetCore.Identity;

namespace Rocosa_Udemy.Models
{
    public class UsuarioAplicacion : IdentityUser
    {
        public string NombreCompleto { get; set; }
    }
}
