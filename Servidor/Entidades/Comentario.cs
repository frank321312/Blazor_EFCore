using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace Servidor.Entidades;

public class Comentario
{
    public int ComentarioId { get; set; }
    public string Contenido { get; set; } = null!;
    public int UsuarioId { get; set; }
    [JsonIgnore]
    public Usuario Usuario { get; set; } = null!;
}
