using System.ComponentModel.DataAnnotations;
using Servidor.Entidades;
namespace Servidor.DTos;

public class ComentarioCreacionDTO
{
    [StringLength(maximumLength: 500)]
    public string Contenido { get; set; } = null!;
    public int UsuarioId { get; set; }
    // public Usuario Usuario { get; set; } = null!;
}
