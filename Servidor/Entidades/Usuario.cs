namespace Servidor.Entidades;

public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nombre { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public List<Comentario> Comemtarios { get; set; } = new List<Comentario>();
}
