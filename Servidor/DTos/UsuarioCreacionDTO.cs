using System.ComponentModel.DataAnnotations;
namespace Servidor.DTos;

public class UsuarioCreacionDTO
{
    [StringLength(maximumLength: 45)]
    public string Nombre { get; set; } = null!;

    [StringLength(maximumLength: 75)]
    public string Email { get; set;} = null!;

    [StringLength(maximumLength: 45)]
    public string Password { get; set; } = null!;
}
